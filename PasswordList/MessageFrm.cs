using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordList
{
    public partial class MessageFrm : Form
    {
        public MessageFrm()
        {
            InitializeComponent();
            MyGradiant(groupBox1, LinearGradientMode.Horizontal, Color.LawnGreen, Color.OrangeRed);
        }
        private void MyGradiant(Control Mycontrol, LinearGradientMode Direction, Color ColorStart, Color EndColor)
        {
            LinearGradientBrush BrushGrad;
            BrushGrad = new LinearGradientBrush(new Rectangle(0, 0, Mycontrol.Width, Mycontrol.Height), ColorStart, EndColor, Direction);
            Bitmap bmp = new Bitmap(Mycontrol.Width, Mycontrol.Height);
            Graphics GR = Graphics.FromImage(bmp);
            GR.FillRectangle(BrushGrad, new RectangleF(0, 0, Mycontrol.Width, Mycontrol.Height));
            Mycontrol.BackgroundImage = bmp;
            Mycontrol.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void MessageFrm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
