using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SvDemo;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
namespace SvDemo
{
    public partial class NewForm : Office2007Form
    {
        protected string xmlFileString;
        protected Point btnStart;
        protected Point btnEnd;
        protected Point btnOrigin;
        protected ButtonX[,] btnSlot;
        public static int number_pres;
        protected DataView xmlViewData;
        protected int errorCount = 0;
        protected int width = 80;
        protected int height = 60;
        protected Size size;
        protected int order = 0;
        protected int seconds = 0;
        protected int scores = 0;
        protected int play_order = 0;

        protected bool bMouseDown = false;

        public NewForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            xmlViewData = null;
            size = new Size(width, height);
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
           
        }


        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            ButtonX bt = sender as ButtonX;
            int index = Convert.ToInt32(bt.Tag);
            if (trainningToolStripMenuItem.Checked || quizToolStripMenuItem.Checked)
            {
                if (errorCount < 5)
                {
                    bt.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
                    bt.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
                    btnStart = Cursor.Position;
                    btnOrigin = bt.Location;
                    bMouseDown = true;
                    axShockwaveFlash1.SendToBack();
                    panel2.BackgroundImage = new Bitmap(Application.StartupPath + "\\" + xmlViewData[order]["image"].ToString());
                    this.panel1.Controls.Remove(bt);
                    this.panel2.Controls.Add(bt);
            
                    while (e.Button == MouseButtons.Left && bMouseDown)
                    {
                        int left = Cursor.Position.X - this.Location.X - 90;
                        int top = Cursor.Position.Y - this.Location.Y - 90;
                        bt.Location = new Point(left, top);
                        bt.Refresh();
                        Application.DoEvents();
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            ButtonX btn = sender as ButtonX;
            int btn_order = Convert.ToInt32(btn.Tag);
            if (trainningToolStripMenuItem.Checked || quizToolStripMenuItem.Checked)
            {
                if (errorCount < 5)
                {
                    this.panel2.Controls.Remove(btn);
                    this.panel1.Controls.Add(btn);
                    panel2.SendToBack();
                    bMouseDown = false;
                    Point pos = btn.Location;
                    btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                    btn.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Default;
                    btn.Location = btnOrigin;
                    int x = pos.X + 80;
                    int y = pos.Y + 60;
                    int leftupx = Convert.ToInt32(xmlViewData[btn_order]["leftupx"].ToString());
                    int leftupy = Convert.ToInt32(xmlViewData[btn_order]["leftupy"].ToString());
                    int rightbottomx = Convert.ToInt32(xmlViewData[btn_order]["rightbottomx"].ToString());
                    int rightbottomy = Convert.ToInt32(xmlViewData[btn_order]["rightbottomy"].ToString());

                    Point p1 = pos;
                    Point p2 = btnOrigin;
               
                    if (System.Math.Abs(p1.X - p2.X - 668) < 50 && System.Math.Abs(p1.Y - p2.Y - 120) < 50)
                    {
                        return;
                    }

                    if (btn_order != this.order)
                    {
                        scores -= 10;
                        score.Text = "得分：" + scores;
                        errorCount++;
                        msg.Text += "\n" + errorCount + ": 组装次序错误";
                    }
                    else if (x > leftupx && x < rightbottomx && y > leftupy && y < rightbottomy)
                    {
                        Play(Application.StartupPath + "\\" + xmlViewData[btn_order]["video"].ToString());
                        scores += 20;
                        score.Text = "得分：" + scores;
                        this.order++;
                    }
                    else
                    {
                        scores -= 5;
                        errorCount++;
                        msg.Text += "\n" + errorCount + ": 组装位置错误";
                        score.Text = "得分：" + scores;
                    }

                    if (errorCount == 5)
                    {
                        msg.Text += "\n错误次数已达5次，请您观看演示";
                    }

                    if (btn_order + 1 == number_pres)
                    {
                        timer1.Enabled = false;
                    }
                }
            }
            else
            {
                return;
            }

        }

        private void Play(string name)
        {
            string path = Application.StartupPath;
            //axShockwaveFlash1.BringToFront();
            axShockwaveFlash1.Visible = true;
            this.axShockwaveFlash1.Movie = name;
            this.axShockwaveFlash1.Play();
            this.axShockwaveFlash1.Loop = false;

        }

        private void cfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (number_pres != 0)
            {
                ModifyForm cf = new ModifyForm(xmlFileString);
                cf.Show();
            }
        }

        private void demonstraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(xmlViewData==null)
            {
                return;
            }

            ResetInfor(); 
            
            errorCount = 5;
            for (int j = 0; j < number_pres; j++)
            {
                btnSlot[j, 0].Top =j * (height + 10);
            }

            demonstraToolStripMenuItem.Checked = true;
            trainningToolStripMenuItem.Checked = false;
            quizToolStripMenuItem.Checked = false;
            this.order = 0;
            status.Text = "状态：演示";
            time.Visible = false;
            score.Visible = false;
            axShockwaveFlash1.Movie = Application.StartupPath + "\\flash\\S.swf";
            axShockwaveFlash1.Loop = false;
            axShockwaveFlash1.Play();
            play_order = 0;
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(timer_Tick);
            timer2.Start();
        }

        private void trainningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xmlViewData == null)
            {
                return;
            }
            ResetInfor();

            errorCount = 0;
            demonstraToolStripMenuItem.Checked = false;
            trainningToolStripMenuItem.Checked = true;
            quizToolStripMenuItem.Checked = false;
            timer2.Enabled = false;
            timer2.Stop();
            this.order = 0;
            status.Text = "状态：训练";
            time.Visible = true;
            for (int j = 0; j < number_pres; j++)
            {
                btnSlot[j, 0].Top = j * (height + 10);
            }
   

            seconds = 0;
            score.Visible = false;
            axShockwaveFlash1.Movie = Application.StartupPath + "\\flash\\S.swf";
            axShockwaveFlash1.Play();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xmlViewData == null)
            {
                return;
            }
            ResetInfor();

            errorCount = 0;
            demonstraToolStripMenuItem.Checked = false;
            trainningToolStripMenuItem.Checked = false;
            quizToolStripMenuItem.Checked = true;
            timer2.Enabled = false;
            timer2.Stop();
            int[] seq = BuildRandomSequence3(number_pres);
            for (int j = 0; j < number_pres; j++)
            {
                btnSlot[j, 0].Top = seq[j] * (height + 10);

            }


            this.order = 0;
            status.Text = "状态：测试";
            time.Visible = true;
            seconds = 0;
            scores = 0;
            score.Visible = true;
            score.Text = "得分：" + scores;
            axShockwaveFlash1.Movie = Application.StartupPath + "\\flash\\S.swf";
            axShockwaveFlash1.Play();
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((xmlFileString = openFileDialog1.FileName) != null)
                {
                    XMLHelper xmlHelper = new XMLHelper(xmlFileString, false, "procedures");
                    DataView xmlView = xmlHelper.GetData("procedures");
                    int number = xmlHelper.GetProcedureNumber("procedures");
                    number_pres = number;
                    this.xmlViewData = xmlView;
                    panel2.BackgroundImage = null;
                    MyInitializeComponent(number);
                    ResetInfor();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            time.Text = "时间：" + seconds + " 秒";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((axShockwaveFlash1.FrameNum + 1 == axShockwaveFlash1.TotalFrames)
                    && play_order < number_pres)
            {
                this.axShockwaveFlash1.Movie = Application.StartupPath + "\\" + xmlViewData[play_order]["video"].ToString();
                this.axShockwaveFlash1.Play();
                msg.Text = "步骤" + (play_order + 1) + "：" + xmlViewData[play_order]["name"].ToString();
                axShockwaveFlash1.Loop = false;
                play_order++;
            }
        }


        private void MyInitializeComponent(int number)
        {

            if (btnSlot != null)
            {
                if (btnSlot.Length != 0)
                    for (int i = 0; i < btnSlot.Length; i++)
                    {
                        this.panel1.Controls.Remove(btnSlot[i, 0]);
                        btnSlot[i, 0].Dispose();
                    }
            }
            btnSlot = new ButtonX[number, 1];
            for (int i = 0; i < number; i++)
            {
                btnSlot[i, 0] = new ButtonX();
                this.panel1.Controls.Add(btnSlot[i, 0]);
                this.btnSlot[i, 0].AllowDrop = true;

                btnSlot[i, 0].AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
                btnSlot[i, 0].BackColor = System.Drawing.Color.Transparent;
                btnSlot[i, 0].ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                btnSlot[i, 0].ForeColor = System.Drawing.Color.Transparent;
                btnSlot[i, 0].HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Default;
                btnSlot[i, 0].Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
                btnSlot[i, 0].Image = new Bitmap(Application.StartupPath + "\\" + xmlViewData[i]["button"].ToString());
                btnSlot[i, 0].Location = new System.Drawing.Point(15,i * (height + 10));
                btnSlot[i, 0].Tag = i;
                btnSlot[i, 0].Size = size;
      
                btnSlot[i, 0].MouseDown += new MouseEventHandler(OnMouseDown);
                btnSlot[i, 0].MouseUp += new MouseEventHandler(OnMouseUp);
            
            }
            time.Visible = false;
            score.Visible = false;
        }


        private static int[] BuildRandomSequence3(int length)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int x = 0, tmp = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                x = random.Next(0, i + 1);
                tmp = array[i];
                array[i] = array[x];
                array[x] = tmp;
            }
            return array;
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            //Form5 f = new Form5();
            //f.Show();
            //MessageBox.Show("   Version1.0\nwh_springer@163.com", "版本信息");
        }

        private void addCfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
            //
        }

        private void ResetInfor() 
        {
            msg.Text = "";
            msg.Width = 10;
            msg.Height = 10;
            msg.SendToBack();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }




      
    }
}