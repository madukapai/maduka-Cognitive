using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoApp
{
    public partial class frmFaceVerify : Form
    {
        public frmFaceVerify()
        {
            InitializeComponent();
        }

        private void btnOpenPic1_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                txtPic1.Text = openFileDialog1.FileName;
                pic1.Load(txtPic1.Text);
            }
        }

        private void btnOpenPic2_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                txtPic2.Text = openFileDialog1.FileName;
                pic2.Load(txtPic2.Text);
            }
        }
    }
}
