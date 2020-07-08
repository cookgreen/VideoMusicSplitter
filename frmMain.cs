using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMusicSplitter
{
    public partial class frmMain : Form
    {
        private VMSConfigReader configReader;

        public frmMain()
        {
            InitializeComponent();
            LoadFFMPEGFromSystemEnvironment();
            configReader = new VMSConfigReader();
            configReader.Read(Environment.CurrentDirectory + "\\vms_config.ini");
        }

        private void LoadFFMPEGFromSystemEnvironment()
        {
            string path = Environment.GetEnvironmentVariable("PATH");
            List<string> pathes = path.Split(';').ToList();
            foreach (var ph in pathes)
            {
                if (Directory.Exists(ph))
                {
                    var result = (new DirectoryInfo(ph)).EnumerateFiles().Where(p => p.FullName.Contains("ffmpeg.exe"));
                    if (result.Count() > 0)
                    {
                        txtFFMPEG.Text = result.First().FullName;
                        btnChooseFFMPEG.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video Splitter Information File|*.sif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = dialog.FileName;
            }
        }

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = dialog.SelectedPath;
            }
        }

        private void BtnChooseFFMPEG_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "FFMPEG|ffmpeg.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFFMPEG.Text = dialog.FileName;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtFFMPEG.Text))
            {
                MessageBox.Show("FFMPEG is needed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(txtVideoMusicFile.Text))
            {
                MessageBox.Show("Video or music file is needed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(txtInputFile.Text))
            {
                MessageBox.Show("Input file is needed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtOutputFolder.Text))
            {
                MessageBox.Show("Output folder is needed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<VideoSplitterInfo> videoSplitterInfos = parseVideoSplitterInfos();
            int index = 0;
            foreach(var vsi in videoSplitterInfos)
            {
                string outputFileName = txtOutputPrefix.Text;
                if (chkNumberic.Checked)
                {
                    outputFileName = outputFileName + txtConnector.Text + (index + 1).ToString();
                }
                outputFileName += txtConnector.Text + vsi.Name.ToLower() + txtExtension.Text;
                outputFileName = Path.Combine(txtOutputFolder.Text, outputFileName);
                string argumLine = " -i \"" + txtVideoMusicFile.Text + "\"" + " -ss " + vsi.StartTime + " -to " + vsi.EndTime + " -c copy \"" + outputFileName + "\"";

                Process ffmpegProcess = new Process();
                ffmpegProcess.StartInfo.FileName = txtFFMPEG.Text;
                ffmpegProcess.StartInfo.Arguments = argumLine;
                ffmpegProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ffmpegProcess.StartInfo.RedirectStandardError = true;
                ffmpegProcess.StartInfo.RedirectStandardOutput = true;
                ffmpegProcess.StartInfo.RedirectStandardInput = true;
				ffmpegProcess.OutputDataReceived += ffmpegProcess_OutputDataReceived;
                ffmpegProcess.Start();

                index++;
            }
        }

		private void ffmpegProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
            txtOutput.AppendText(e.Data);
            txtOutput.AppendText(Environment.NewLine);
		}

		private List<VideoSplitterInfo> parseVideoSplitterInfos()
        {
            List<VideoSplitterInfo> videoSplitterInfos = new List<VideoSplitterInfo>();
            using (StreamReader reader = new StreamReader(txtInputFile.Text))
            {
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine();
                    string[] tokens = line.Split(' ');
                    string[] tokens2 = tokens[0].Split('-');
                    VideoSplitterInfo vsi = new VideoSplitterInfo();
                    vsi.StartTime = tokens2[0];
                    vsi.EndTime = tokens2[1];
                    vsi.Name = tokens[1];
                    videoSplitterInfos.Add(vsi);
                }
            }
            return videoSplitterInfos;
        }

        private void BtnChooseVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video/Music File|" + configReader.Extension;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtVideoMusicFile.Text = dialog.FileName;
            }
            txtExtension.Text = Path.GetExtension(txtVideoMusicFile.Text);
        }
    }
}
