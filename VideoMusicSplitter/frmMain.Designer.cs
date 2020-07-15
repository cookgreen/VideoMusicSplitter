namespace VideoMusicSplitter
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtInputFile = new System.Windows.Forms.TextBox();
			this.btnChooseSplitterInfo = new System.Windows.Forms.Button();
			this.txtOutputFolder = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnChooseFolder = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOutputPrefix = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFFMPEG = new System.Windows.Forms.TextBox();
			this.btnChooseFFMPEG = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.chkNumberic = new System.Windows.Forms.CheckBox();
			this.txtConnector = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtVideoMusicFile = new System.Windows.Forms.TextBox();
			this.btnChooseVideo = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtExtension = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOutput = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Splitter Info File:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtInputFile
			// 
			this.txtInputFile.Location = new System.Drawing.Point(173, 34);
			this.txtInputFile.Name = "txtInputFile";
			this.txtInputFile.ReadOnly = true;
			this.txtInputFile.Size = new System.Drawing.Size(344, 21);
			this.txtInputFile.TabIndex = 1;
			// 
			// btnChooseSplitterInfo
			// 
			this.btnChooseSplitterInfo.Location = new System.Drawing.Point(523, 32);
			this.btnChooseSplitterInfo.Name = "btnChooseSplitterInfo";
			this.btnChooseSplitterInfo.Size = new System.Drawing.Size(56, 23);
			this.btnChooseSplitterInfo.TabIndex = 2;
			this.btnChooseSplitterInfo.Text = "Choose";
			this.btnChooseSplitterInfo.UseVisualStyleBackColor = true;
			this.btnChooseSplitterInfo.Click += new System.EventHandler(this.BtnChoose_Click);
			// 
			// txtOutputFolder
			// 
			this.txtOutputFolder.Location = new System.Drawing.Point(173, 61);
			this.txtOutputFolder.Name = "txtOutputFolder";
			this.txtOutputFolder.ReadOnly = true;
			this.txtOutputFolder.Size = new System.Drawing.Size(344, 21);
			this.txtOutputFolder.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Output Folder:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnChooseFolder
			// 
			this.btnChooseFolder.Location = new System.Drawing.Point(523, 59);
			this.btnChooseFolder.Name = "btnChooseFolder";
			this.btnChooseFolder.Size = new System.Drawing.Size(56, 23);
			this.btnChooseFolder.TabIndex = 5;
			this.btnChooseFolder.Text = "Choose";
			this.btnChooseFolder.UseVisualStyleBackColor = true;
			this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "Output Prefix:";
			// 
			// txtOutputPrefix
			// 
			this.txtOutputPrefix.Location = new System.Drawing.Point(173, 88);
			this.txtOutputPrefix.Name = "txtOutputPrefix";
			this.txtOutputPrefix.Size = new System.Drawing.Size(406, 21);
			this.txtOutputPrefix.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "FFMPEG:";
			// 
			// txtFFMPEG
			// 
			this.txtFFMPEG.Location = new System.Drawing.Point(173, 115);
			this.txtFFMPEG.Name = "txtFFMPEG";
			this.txtFFMPEG.ReadOnly = true;
			this.txtFFMPEG.Size = new System.Drawing.Size(344, 21);
			this.txtFFMPEG.TabIndex = 9;
			// 
			// btnChooseFFMPEG
			// 
			this.btnChooseFFMPEG.Location = new System.Drawing.Point(523, 116);
			this.btnChooseFFMPEG.Name = "btnChooseFFMPEG";
			this.btnChooseFFMPEG.Size = new System.Drawing.Size(56, 23);
			this.btnChooseFFMPEG.TabIndex = 10;
			this.btnChooseFFMPEG.Text = "Choose";
			this.btnChooseFFMPEG.UseVisualStyleBackColor = true;
			this.btnChooseFFMPEG.Click += new System.EventHandler(this.BtnChooseFFMPEG_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(205, 502);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(185, 51);
			this.btnStart.TabIndex = 11;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// chkNumberic
			// 
			this.chkNumberic.AutoSize = true;
			this.chkNumberic.Location = new System.Drawing.Point(173, 147);
			this.chkNumberic.Name = "chkNumberic";
			this.chkNumberic.Size = new System.Drawing.Size(72, 16);
			this.chkNumberic.TabIndex = 12;
			this.chkNumberic.Text = "Numberic";
			this.chkNumberic.UseVisualStyleBackColor = true;
			// 
			// txtConnector
			// 
			this.txtConnector.Location = new System.Drawing.Point(173, 169);
			this.txtConnector.Name = "txtConnector";
			this.txtConnector.Size = new System.Drawing.Size(217, 21);
			this.txtConnector.TabIndex = 13;
			this.txtConnector.Text = "_";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "Connector:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(143, 12);
			this.label6.TabIndex = 15;
			this.label6.Text = "Input Video/Music File:";
			// 
			// txtVideoMusicFile
			// 
			this.txtVideoMusicFile.Location = new System.Drawing.Point(173, 6);
			this.txtVideoMusicFile.Name = "txtVideoMusicFile";
			this.txtVideoMusicFile.ReadOnly = true;
			this.txtVideoMusicFile.Size = new System.Drawing.Size(344, 21);
			this.txtVideoMusicFile.TabIndex = 16;
			// 
			// btnChooseVideo
			// 
			this.btnChooseVideo.Location = new System.Drawing.Point(523, 4);
			this.btnChooseVideo.Name = "btnChooseVideo";
			this.btnChooseVideo.Size = new System.Drawing.Size(56, 23);
			this.btnChooseVideo.TabIndex = 17;
			this.btnChooseVideo.Text = "Choose";
			this.btnChooseVideo.UseVisualStyleBackColor = true;
			this.btnChooseVideo.Click += new System.EventHandler(this.BtnChooseVideo_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(335, 151);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 18;
			this.label7.Text = "Extension:";
			// 
			// txtExtension
			// 
			this.txtExtension.Location = new System.Drawing.Point(406, 145);
			this.txtExtension.Name = "txtExtension";
			this.txtExtension.Size = new System.Drawing.Size(111, 21);
			this.txtExtension.TabIndex = 19;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtOutput);
			this.groupBox1.Location = new System.Drawing.Point(4, 196);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(585, 300);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Output";
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(10, 20);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(565, 274);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.Text = "";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 565);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtExtension);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnChooseVideo);
			this.Controls.Add(this.txtVideoMusicFile);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtConnector);
			this.Controls.Add(this.chkNumberic);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnChooseFFMPEG);
			this.Controls.Add(this.txtFFMPEG);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtOutputPrefix);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnChooseFolder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtOutputFolder);
			this.Controls.Add(this.btnChooseSplitterInfo);
			this.Controls.Add(this.txtInputFile);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Video/Music Splitter";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnChooseSplitterInfo;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFFMPEG;
        private System.Windows.Forms.Button btnChooseFFMPEG;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkNumberic;
        private System.Windows.Forms.TextBox txtConnector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVideoMusicFile;
        private System.Windows.Forms.Button btnChooseVideo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExtension;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox txtOutput;
	}
}

