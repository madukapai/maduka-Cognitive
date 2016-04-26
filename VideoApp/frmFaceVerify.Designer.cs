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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.txtPic1 = new System.Windows.Forms.TextBox();
            this.txtPic2 = new System.Windows.Forms.TextBox();
            this.btnOpenPic1 = new System.Windows.Forms.Button();
            this.btnOpenPic2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(298, 259);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(316, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(298, 259);
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
            this.btnSend.Location = new System.Drawing.Point(12, 305);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(602, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Location = new System.Drawing.Point(12, 331);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(602, 23);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmFaceVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 372);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnOpenPic2);
            this.Controls.Add(this.btnOpenPic1);
            this.Controls.Add(this.txtPic2);
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}