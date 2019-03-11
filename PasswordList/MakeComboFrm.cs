using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordList
{
    public partial class MakeComboFrm : Form
    {
        public MakeComboFrm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
           
            MyGradiant(groupBox1, LinearGradientMode.Vertical, Color.DarkSlateGray, Color.DarkBlue);
        }
        OpenFileDialog opuser;
        OpenFileDialog oppass;
        private void btnmakecombo_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savetext = new SaveFileDialog();
                savetext.FileName = "Save ComboList";

                if (savetext.ShowDialog() == DialogResult.OK)
                {
                    WaitingClass.StartWiat();
                    string[] lines = File.ReadAllLines(opuser.FileName);
                    string[] lines2 = File.ReadAllLines(oppass.FileName);
                    FileStream stream = File.Open(savetext.FileName, FileMode.Create);
                    foreach (string item in lines)
                    {
                        foreach (string item2 in lines2)
                        {
                           
                                byte[] data = Encoding.Default.GetBytes(item + comboBox1.SelectedItem + item2 + Environment.NewLine);
                                stream.Write(data, 0, data.Length);
                           
                           
                        }
                    }
                    WaitingClass.EndWait();
                    stream.Close();
                    MessageBox.Show("                Combo List Created Success!","      MSG Creation Combo");
                    
                }
            }
            catch 
            {

                MessageBox.Show("         Your File Is not Valid!","     Error !");
            }
           
        }
       

        private void btnbrowsepass_Click(object sender, EventArgs e)
        {
            oppass = new OpenFileDialog();
            oppass.Multiselect = false;
            oppass.Filter = "txt files (*.txt)|*.txt";
            if (oppass.ShowDialog()==DialogResult.OK)
            {
                FileInfo inf = new FileInfo(oppass.FileName);
                label2.Text = inf.Length / 1024+"\t/KB";
               
               
                    txtpasswordpath.Text = oppass.FileName;
                

            }
        }

        private void btnbrowseuser_Click(object sender, EventArgs e)
        {
            opuser = new OpenFileDialog();
            opuser.Filter = "txt files (*.txt)|*.txt";
            opuser.Multiselect = false;
            if (opuser.ShowDialog() == DialogResult.OK)
            {
                FileInfo inf = new FileInfo(opuser.FileName);
                label3.Text = inf.Length / 1024 + "\t/KB";
                try
                {
                   
                   
                        txtuserpath.Text = opuser.FileName;
                   
                   
                }
                catch 
                {
 
                }

               
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savetext = new SaveFileDialog();
                savetext.FileName = "Save ComboList";

                if (savetext.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var lines = File.ReadAllLines(opuser.FileName);
                    var lines2 = File.ReadAllLines(oppass.FileName);
                    FileStream stream = File.Open(savetext.FileName, FileMode.Create);
                    foreach (var item in lines)
                    {
                        foreach (string item2 in lines2)
                        {
                            byte[] data = Encoding.Default.GetBytes(item + comboBox1.SelectedItem + item2 + Environment.NewLine);
                            stream.Write(data, 0, data.Length);
                        }
                    }
                    stream.Close();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("        Combo List Created Success!","     MSG For Creation");
                }
            }
            catch 
            {

                MessageBox.Show(           "Your File Is not Valid!","          Error !");
            }
          
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
        private void MakeComboFrm_Load(object sender, EventArgs e)
        {

        }
    }
 }
