using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordList
{
    public partial class PaawordFrm : Form
    {
        char[] Upper = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','L','O','P','R','S','V','W','X','Y','Z'};
        char[] Lower = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','l','o','p','r','s','v','w','x','y','z'};
        char[] Numbers = { '1','2','3','4','5','6','7','8','9','0'};
        char[] SpecialChar = {'+','!','@','#','$','%','^','&','*','(',')','_','-','=','[',']','.','|' };
        Random Rand = new Random();
        public PaawordFrm()
        {
            InitializeComponent();
            this.Text = "                 نرم افزار ساخت پسورد لیست و کمبولیست ";
            MyGradiant(menuStrip1, LinearGradientMode.Horizontal, Color.RosyBrown, Color.LightGray);
            MyGradiant(statusStrip1, LinearGradientMode.Horizontal, Color.LawnGreen, Color.OrangeRed);
            MyGradiant(groupBox2, LinearGradientMode.Vertical, Color.CornflowerBlue, Color.CadetBlue);
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

        private void GeneratePassword()
        {
            string password = txtBeforeText.Text.Trim();
            List<char> Chooselist = new List<char>();
            if (checkUpperBox.Checked)
            {
                Chooselist.AddRange(Upper);
            }
            if (checkLowerBox.Checked)
            {
                Chooselist.AddRange(Lower);
            }
            if (checkNumBox.Checked)
            {
                Chooselist.AddRange(Numbers);
            }
            if (checkCahrBox.Checked)
            {
                Chooselist.AddRange(SpecialChar);
            }
            if (txtinclude.Text.Length>0)
            {
                Chooselist.AddRange(txtinclude.Text.ToArray());
            }
            if (txtexclude.Text.Length>0)
            {
                for (int i = 0; i < txtexclude.Text.Length; i++)
                {
                    Chooselist.RemoveAll(exclud=>exclud==txtexclude.Text[i]);
                }
            }
            char NEXT;

            for (int i = 0; i < (char)numericUpDown1.Value; i++)
            {
                if (Chooselist.Count>0)
                {
                    NEXT = Chooselist[Rand.Next(Chooselist.Count)];
                    Chooselist.RemoveAll(item=>item==NEXT);
                }
                else
                {
                    NEXT = ' ';
                }
                password += NEXT;
            }
            listBox1.Items.Add(password+txtAfterText.Text.Trim());
        }

        private void Timer(object p)
        {
            listBox1.Invoke((MethodInvoker)delegate
            {
                GeneratePassword();
                lblcountpasswords.Text = listBox1.Items.Count.ToString();

            });
        }
        private void PaawordFrm_Load(object sender, EventArgs e)
        {

        }
        System.Threading.Timer TimerThread;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            TimerThread = new System.Threading.Timer(new System.Threading.TimerCallback(Timer),null,0,50);
          
        }

        private void checkBeforeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBeforeBox.Checked)
            {
                txtBeforeText.ReadOnly = false;
                txtBeforeText.BackColor = Color.Gray;
                txtBeforeText.Select();
            }
            else
            {
                txtBeforeText.ReadOnly = true;
                txtBeforeText.Text = "";
                txtBeforeText.BackColor = Color.Beige;
            }
           
        }

        private void txtAfterText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkAfterBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAfterBox.Checked)
            {
                txtAfterText.ReadOnly = false;
                txtAfterText.BackColor = Color.Gray;
                txtAfterText.Select();
            }
            else
            {
                txtAfterText.ReadOnly = true;
                txtAfterText.Text = "";
                txtAfterText.BackColor = Color.Beige;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerThread.Dispose();
            TimerThread = null;
        }
       // StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Title = "Save Password List";
        
            if (savef.ShowDialog()==DialogResult.OK)
            {
               // WaitingClass.StartWiat();
                Cursor.Current = Cursors.WaitCursor;
                using (StreamWriter sw = new StreamWriter(savef.FileName, true))
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            foreach (string item in listBox1.Items)
                            {
                                sw.WriteLine(item);

                            }
                        });
                       
                    }
                    catch (Exception)
                    {

                       
                    }
                    finally
                    {
                        sw.Dispose();
                        sw.Close();
                    }
                    Cursor.Current = Cursors.Default;


                   // WaitingClass.EndWait();
                    MessageBox.Show("            Password list Saved!", "            Message ");

                }
               



            }
            else
            {
                
                return;
            }
           
        }

        private void makeComboListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MakeComboFrm().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createMobileNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start(@"cmd.exe", @"/k MobileNumber.exe");
          

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
