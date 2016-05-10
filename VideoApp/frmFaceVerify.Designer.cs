namespace VideoApp
{
    partial class frmFaceVerify
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.txtPic1 = new System.Windows.Forms.TextBox();
            this.txtPic2 = new System.Windows.Forms.TextBox();
            this.btnOpenPic1 = new System.Windows.Forms.Button();
            this.btnOpenPic2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFace1Guid = new System.Windows.Forms.TextBox();
            this.txtFace2Guid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(298, 259);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(316, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(298, 259);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // txtPic1
            // 
            this.txtPic1.Location = new System.Drawing.Point(12, 277);
            this.txtPic1.Name = "txtPic1";
            this.txtPic1.Size = new System.Drawing.Size(217, 22);
            this.txtPic1.TabIndex = 2;
            // 
            // txtPic2
            // 
            this.txtPic2.Location = new System.Drawing.Point(316, 277);
            this.txtPic2.Name = "txtPic2";
            this.txtPic2.Size = new System.Drawing.Size(217, 22);
            this.txtPic2.TabIndex = 3;
            // 
            // btnOpenPic1
            // 
            this.btnOpenPic1.Location = new System.Drawing.Point(235, 277);
            this.btnOpenPic1.Name = "btnOpenPic1";
            this.btnOpenPic1.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPic1.TabIndex = 4;
            this.btnOpenPic1.Text = "Open";
            this.btnOpenPic1.UseVisualStyleBackColor = true;
            this.btnOpenPic1.Click += new System.EventHandler(this.btnOpenPic1_Click);
            // 
            // btnOpenPic2
            // 
            this.btnOpenPic2.Location = new System.Drawing.Point(539, 277);
            this.btnOpenPic2.Name = "btnOpenPic2";
            this.btnOpenPic2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPic2.TabIndex = 4;
            this.btnOpenPic2.Text = "Open";
            this.btnOpenPic2.UseVisualStyleBackColor = true;
            this.btnOpenPic2.Click += new System.EventHandler(this.btnOpenPic2_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 331);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(602, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send Verify";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFace1Guid
            // 
            this.txtFace1Guid.Enabled = false;
            this.txtFace1Guid.Location = new System.Drawing.Point(12, 303);
            this.txtFace1Guid.Name = "txtFace1Guid";
            this.txtFace1Guid.Size = new System.Drawing.Size(298, 22);
            this.txtFace1Guid.TabIndex = 2;
            // 
            // txtFace2Guid
            // 
            this.txtFace2Guid.Enabled = false;
            this.txtFace2Guid.Location = new System.Drawing.Point(316, 303);
            this.txtFace2Guid.Name = "txtFace2Guid";
            this.txtFace2Guid.Size = new System.Drawing.Size(298, 22);
            this.txtFace2Guid.TabIndex = 3;
            // 
            // frmFaceVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 372);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnOpenPic2);
            this.Controls.Add(this.btnOpenPic1);
            this.Controls.Add(this.txtFace2Guid);
            this.Controls.Add(this.txtPic2);
            this.Controls.Add(this.txtFace1Guid);
            this.Controls.Add(this.txtPic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "frmFaceVerify";
            this.Text = "frmFaceVerify";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.TextBox txtPic1;
        private System.Windows.Forms.TextBox txtPic2;
        private System.Windows.Forms.Button btnOpenPic1;
        private System.Windows.Forms.Button btnOpenPic2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFace1Guid;
        private System.Windows.Forms.TextBox txtFace2Guid;
    }
}