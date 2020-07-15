using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoMusicSplitter.Common;

namespace VideoMusicSplitter
{
	public partial class frmMain : Form
	{
		private SplitInfoTextCollection collection;
		private BackgroundWorker worker;

		public frmMain()
		{
			InitializeComponent();
			worker = new BackgroundWorker();
			worker.DoWork += Worker_DoWork;
			worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
		}

		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnOK.Enabled = true;
			btnQuit.Enabled = true;
		}

		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			collection = new SplitInfoTextCollection(txtVideo.Text);
			using (StreamReader reader = new StreamReader(txtInfo.Text))
			{
				while (reader.Peek() > -1)
				{
					string line = reader.ReadLine();
					string[] tokens = line.Split(' ');
					string time = tokens[0];
					string name = tokens[1];
					SplitInfoText splitInfoText = new SplitInfoText();
					splitInfoText.StartTime = time;
					splitInfoText.Name = name;
					collection.Append(splitInfoText);
				}
			}

			var sifList = collection.ToSIF();
			using (StreamWriter writer = new StreamWriter(e.Argument.ToString()))
			{
				foreach (var sif in sifList)
				{
					writer.WriteLine(sif.Text);
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Video/Music Split Information|*.sif";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				btnOK.Enabled = false;
				btnQuit.Enabled = false;
				worker.RunWorkerAsync(dialog.FileName);
			}
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnChooseInfo_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Split Information usually provided in the video description";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtInfo.Text = dialog.FileName;
			}
		}
	}
}
