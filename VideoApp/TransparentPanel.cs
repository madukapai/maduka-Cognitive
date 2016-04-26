using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoApp
{
    class TransparentPanel : Panel
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = e.Graphics;
        //    Font font = new Font("Microsoft Sans Serif", 36F,
        //                   System.Drawing.FontStyle.Bold,
        //                   System.Drawing.GraphicsUnit.Point,
        //                   ((byte)(0)));
        //    SizeF stringSize = new SizeF();
        //    String str = "      www.whiteboardcoder.com         www.whiteboardcoder.com";
        //    int rowHeight;
        //    int textWidth;
        //    int xAdjust = 0;

        //    stringSize = e.Graphics.MeasureString(str, font, 800);
        //    rowHeight = (int)stringSize.Height +
        //                          (int)stringSize.Height;
        //    textWidth = ((int)stringSize.Width);

        //    g.RotateTransform(-20);
        //    for (int x = 0; x <
        //            (this.Width / textWidth) + 2; x++)
        //    {
        //        for (int y = 0; y < 2 *
        //                 (this.Height / rowHeight) + 2; y++)
        //        {
        //            xAdjust = textWidth / 2;
        //            g.DrawString(str, font,
        //                 System.Drawing.Brushes.Red,
        //               new Point(x * textWidth - xAdjust,
        //                     y * rowHeight));
        //        }
        //    }
        //}
    }
}