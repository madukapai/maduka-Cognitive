namespace VideoApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnTracking = new System.Windows.Forms.Button();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtOperationUrl = new System.Windows.Forms.TextBox();
            this.txtResultUrl = new System.Windows.Forms.TextBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.tiGetStatus = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.gvTimeTable = new System.Windows.Forms.DataGridView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblVedioSecound = new System.Windows.Forms.Label();
            this.tiVideoSecound = new System.Windows.Forms.Timer(this.components);
            this.lblEventCount = new System.Windows.Forms.Label();
            this.plTag = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTracking
            // 
            this.btnTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTracking.Location = new System.Drawing.Point(721, 12);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(124, 23);
            this.btnTracking.TabIndex = 0;
            this.btnTracking.Text = "Tracking Internet File";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // txtVideo
            // 
            this.txtVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideo.Location = new System.Drawing.Point(12, 12);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(595, 22);
            this.txtVideo.TabIndex = 1;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 96);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(417, 61);
            this.txtResponse.TabIndex = 2;
            // 
            // txtOperationUrl
            // 
            this.txtOperationUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperationUrl.Location = new System.Drawing.Point(12, 40);
            this.txtOperationUrl.Name = "txtOperationUrl";
            this.txtOperationUrl.Size = new System.Drawing.Size(752, 22);
            this.txtOperationUrl.TabIndex = 3;
            // 
            // txtResultUrl
            // 
            this.txtResultUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultUrl.Location = new System.Drawing.Point(12, 68);
            this.txtResultUrl.Name = "txtResultUrl";
            this.txtResultUrl.Size = new System.Drawing.Size(752, 22);
            this.txtResultUrl.TabIndex = 6;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetResult.Enabled = false;
            this.btnGetResult.Location = new System.Drawing.Point(770, 66);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(75, 23);
            this.btnGetResult.TabIndex = 7;
            this.btnGetResult.Text = "Get Result";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // tiGetStatus
            // 
            this.tiGetStatus.Interval = 15000;
            this.tiGetStatus.Tick += new System.EventHandler(this.tiGetStatus_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(770, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 22);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // gvTimeTable
            // 
            this.gvTimeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTimeTable.Location = new System.Drawing.Point(435, 96);
            this.gvTimeTable.Name = "gvTimeTable";
            this.gvTimeTable.RowTemplate.Height = 24;
            this.gvTimeTable.Size = new System.Drawing.Size(410, 655);
            this.gvTimeTable.TabIndex = 9;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 163);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(417, 276);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(12, 445);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(93, 445);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(174, 445);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblVedioSecound
            // 
            this.lblVedioSecound.Location = new System.Drawing.Point(255, 523);
            this.lblVedioSecound.Name = "lblVedioSecound";
            this.lblVedioSecound.Size = new System.Drawing.Size(129, 23);
            this.lblVedioSecound.TabIndex = 12;
            this.lblVedioSecound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tiVideoSecound
            // 
            this.tiVideoSecound.Tick += new System.EventHandler(this.tiVideoSecound_Tick);
            // 
            // lblEventCount
            // 
            this.lblEventCount.Location = new System.Drawing.Point(390, 523);
            this.lblEventCount.Name = "lblEventCount";
            this.lblEventCount.Size = new System.Drawing.Size(39, 23);
            this.lblEventCount.TabIndex = 13;
            // 
            // plTag
            // 
            this.plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTag.Location = new System.Drawing.Point(12, 474);
            this.plTag.Name = "plTag";
            this.plTag.Size = new System.Drawing.Size(417, 276);
            this.plTag.TabIndex = 14;
            this.plTag.Paint += new System.Windows.Forms.PaintEventHandler(this.plTag_Paint);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(613, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(102, 23);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Open Local File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 763);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.plTag);
            this.Controls.Add(this.lblEventCount);
            this.Controls.Add(this.lblVedioSecound);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gvTimeTable);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.txtResultUrl);
            this.Controls.Add(this.txtOperationUrl);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.gvTimeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtOperationUrl;
        private System.Windows.Forms.TextBox txtResultUrl;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Timer tiGetStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView gvTimeTable;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblVedioSecound;
        private System.Windows.Forms.Timer tiVideoSecound;
        private System.Windows.Forms.Label lblEventCount;
        private System.Windows.Forms.Panel plTag;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}