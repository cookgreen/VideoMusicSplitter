namespace VideoMusicSplitter
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtVideo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInfo = new System.Windows.Forms.TextBox();
			this.btnChooseInfo = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Video Total Length:";
			// 
			// txtVideo
			// 
			this.txtVideo.Location = new System.Drawing.Point(138, 10);
			this.txtVideo.Name = "txtVideo";
			this.txtVideo.Size = new System.Drawing.Size(364, 21);
			this.txtVideo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Split Info:";
			// 
			// txtInfo
			// 
			this.txtInfo.Location = new System.Drawing.Point(138, 41);
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.ReadOnly = true;
			this.txtInfo.Size = new System.Drawing.Size(268, 21);
			this.txtInfo.TabIndex = 4;
			// 
			// btnChooseInfo
			// 
			this.btnChooseInfo.Location = new System.Drawing.Point(427, 39);
			this.btnChooseInfo.Name = "btnChooseInfo";
			this.btnChooseInfo.Size = new System.Drawing.Size(75, 23);
			this.btnChooseInfo.TabIndex = 5;
			this.btnChooseInfo.Text = "Choose";
			this.btnChooseInfo.UseVisualStyleBackColor = true;
			this.btnChooseInfo.Click += new System.EventHandler(this.btnChooseInfo_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(270, 75);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(113, 47);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(389, 75);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(113, 47);
			this.btnQuit.TabIndex = 7;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 134);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnChooseInfo);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtVideo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIF Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVideo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtInfo;
		private System.Windows.Forms.Button btnChooseInfo;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnQuit;
	}
}