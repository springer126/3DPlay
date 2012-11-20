using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Xml;
using SvDemo;

namespace ButtonTest
{
    public partial class Form1 : Form
    {        
   
        protected string xmlFileString;
        protected Point btnStart;
        protected Point btnEnd;
        protected Point btnOrigin;
        MyButton[,] btnSlot;
        int order = 0;
        int btn_order;
        public static int number_pres;
        int seconds = 0;
        int scores = 0;
        int play_order = 0;
        protected DataView xmlViewData;
        protected int errorCount = 0;
        protected int width = 60;
        protected int height = 45;

        private bool bMouseDown = false;
    
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            xmlViewData = null;
            int count =20;
            float[] factor = new float[count];
            int n = 0;
            factor[n++] = Size.Width;
            factor[n++] = Size.Height;
  
            factor[n++] = this.groupBox2.Location.X / (float)Size.Width;
            factor[n++] = this.groupBox2.Location.Y / (float)Size.Height;
            this.groupBox2.Tag = this.groupBox2.Size;

            factor[n++] = this.pictureBox1.Location.X / (float)Size.Width;
            factor[n++] = this.pictureBox1.Location.Y / (float)Size.Height;
            this.pictureBox1.Tag = this.pictureBox1.Size;

            factor[n++] = this.axShockwaveFlash1.Location.X / (float)Size.Width;
            factor[n++] = this.axShockwaveFlash1.Location.Y / (float)Size.Height;
            this.axShockwaveFlash1.Tag = this.axShockwaveFlash1.Size;

            factor[n++] = this.vScrollBar1.Location.X / (float)Size.Width;
            factor[n++] = this.vScrollBar1.Location.Y / (float)Size.Height;
            this.vScrollBar1.Tag = this.vScrollBar1.Size;

            factor[n++] = this.button1.Location.X / (float)Size.Width;
            factor[n++] = this.button1.Location.Y / (float)Size.Height;
            this.button1.Tag = this.button1.Size;

            factor[n++] = this.button2.Location.X / (float)Size.Width;
            factor[n++] = this.button2.Location.Y / (float)Size.Height;
            this.button2.Tag = this.button2.Size;

            factor[n++] = this.status.Location.X / (float)Size.Width;
            factor[n++] = this.status.Location.Y / (float)Size.Height;
            this.status.Tag = this.status.Size;

            factor[n++] = this.time.Location.X / (float)Size.Width;
            factor[n++] = this.time.Location.Y / (float)Size.Height;
            this.time.Tag = this.time.Size;

            factor[n++] = this.score.Location.X / (float)Size.Width;
            factor[n++] = this.score.Location.Y / (float)Size.Height;
            this.score.Tag = this.score.Size;

            Tag = factor;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {

            if (errorCount < 5)
            {
                Button bt = sender as Button;
                btnStart = Cursor.Position;
                btnOrigin = bt.Location;
                bMouseDown = true;
                btn_order = (int)(bt.Name[0] - 'A');

                axShockwaveFlash1.SendToBack();
                pictureBox1.BackgroundImage = new Bitmap(Application.StartupPath + "\\image\\pic\\" + bt.Name + ".bmp");
                pictureBox1.SendToBack();
                while (e.Button == MouseButtons.Left && bMouseDown)
                {
                    ControlTrans(pictureBox1, pictureBox1.BackgroundImage);
                    ControlTrans(bt, bt.BackgroundImage);

                    bt.Location = new Point(Cursor.Position.X - this.Location.X - 60, Cursor.Position.Y - this.Location.Y - 60);
                    Application.DoEvents();
                }
            }  
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {

        }


        private void GetButtonLoction(Button btn)
        {
            Point p = new Point(btnEnd.X - btnStart.X, btnEnd.Y - btnStart.Y); 
            btn.Location = new Point(btn.Location.X + p.X, btn.Location.Y + p.Y);
            btn.Refresh();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (errorCount < 5) 
            {
                bMouseDown = false;

                Button btn = sender as Button;
                Point pos = btn.Location;
                int x = pos.X + 28;
                int y = pos.Y + 18;
                //MessageBox.Show("Point Location:"+x+","+y);
                int leftupx = Convert.ToInt32(xmlViewData[btn_order]["leftupx"].ToString());
                int leftupy = Convert.ToInt32(xmlViewData[btn_order]["leftupy"].ToString());
                int rightbottomx = Convert.ToInt32(xmlViewData[btn_order]["rightbottomx"].ToString());
                int rightbottomy = Convert.ToInt32(xmlViewData[btn_order]["rightbottomy"].ToString());

                //MessageBox.Show("" + leftupx + " " + leftupy + " " + rightbottomx + " " + rightbottomy);

                btn.Location = btnOrigin;

                if (btn_order != this.order)
                {
                    scores -= 10;
                    score.Text = "得分：" + scores;
                    errorCount++;
                    msg.Text += "\n"+errorCount+": 组合次序错误";
                }
                else if (x > leftupx && x < rightbottomx && y > leftupy && y < rightbottomy)
                {
                    Play(btn.Name);
                    scores += 20;
                    score.Text = "得分：" + scores;
                    this.order++;
                }
                else 
                {
                    scores -= 5;
                    errorCount++;
                    msg.Text += "\n" + errorCount + ": 组合位置错误";
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

        private void Play(string name)
        {
            string path = Application.StartupPath;
            axShockwaveFlash1.Visible = true;
            this.axShockwaveFlash1.Movie = path + "\\flash\\" + name + ".swf";
            this.axShockwaveFlash1.Play();
            this.axShockwaveFlash1.Loop = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        private unsafe static GraphicsPath subGraphicsPath(Image img)
        {
            if (img == null) return null;

            // 建立GraphicsPath, 给我们的位图路径计算使用   
            GraphicsPath g = new GraphicsPath(FillMode.Alternate);

            Bitmap bitmap = new Bitmap(img);

            int width = bitmap.Width;
            int height = bitmap.Height;
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte* p = (byte*)bmData.Scan0;
            int offset = bmData.Stride - width * 3;
            int p0, p1, p2;         // 记录左上角0，0座标的颜色值  
            p0 = p[0];
            p1 = p[1];
            p2 = p[2];

            int start = -1;
            // 行座标 ( Y col )   
            for (int Y = 0; Y < height; Y++)
            {
                // 列座标 ( X row )   
                for (int X = 0; X < width; X++)
                {
                    if (start == -1 && (p[0] != p0 || p[1] != p1 || p[2] != p2))     //如果 之前的点没有不透明 且 不透明   
                    {
                        start = X;                            //记录这个点  
                    }
                    else if (start > -1 && (p[0] == p0 && p[1] == p1 && p[2] == p2))      //如果 之前的点是不透明 且 透明  
                    {
                        g.AddRectangle(new Rectangle(start, Y, X - start, 1));    //添加之前的矩形到  
                        start = -1;
                    }

                    if (X == width - 1 && start > -1)        //如果 之前的点是不透明 且 是最后一个点  
                    {
                        g.AddRectangle(new Rectangle(start, Y, X - start + 1, 1));      //添加之前的矩形到  
                        start = -1;
                    }
                    p += 3;                                   //下一个内存地址  
                }
                p += offset;
            }
            bitmap.UnlockBits(bmData);
            bitmap.Dispose();
            return g;
        }

     
        public static void ControlTrans(Control control, Image img)
        {
            GraphicsPath g;
            g = subGraphicsPath(img);
            if (g == null)
                return;
            control.Region = new Region(g);
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
                    MyInitializeComponent(number);                  
                }
            }

        }

        private void MyInitializeComponent(int number) 
        {

            if (btnSlot!=null) 
            {
                if(btnSlot.Length!=0)
                    for (int i = 0; i < btnSlot.Length; i++) 
                    {
                        this.groupBox2.Controls.Remove(btnSlot[i, 0]);
                        btnSlot[i,0].Dispose();
                    }
            }
            this.groupBox2.Refresh();
            

            btnSlot = new MyButton[number, 1];
            char c = 'A';
            float[] scale = (float[])Tag;
            Size size = new Size(width, height);

            for (int i = 0; i < number; i++)
            {
                char cname = (char)(c + i);
                string name = System.Convert.ToString(cname);
                btnSlot[i, 0] = new MyButton();
                this.groupBox2.Controls.Add(btnSlot[i, 0]);
                btnSlot[i, 0].AllowDrop = true;
                btnSlot[i, 0].BackColor = System.Drawing.Color.Transparent;
                btnSlot[i, 0].BackgroundImage = new Bitmap(Application.StartupPath + "\\image\\button\\" + xmlViewData[i]["button"].ToString());
                btnSlot[i, 0].FlatAppearance.BorderColor = System.Drawing.Color.White;
                btnSlot[i, 0].FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                btnSlot[i, 0].FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                btnSlot[i, 0].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnSlot[i, 0].Location = new System.Drawing.Point(680, 100 + i * (height + 20));
                btnSlot[i, 0].Name = name;
                btnSlot[i, 0].Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
                btnSlot[i, 0].Tag = 100 + i * (height + 20);
                btnSlot[i, 0].Size = size;
                btnSlot[i, 0].AllowDrop = true;
                btnSlot[i, 0].BackgroundImageLayout = ImageLayout.Stretch;
                btnSlot[i, 0].MouseDown += new MouseEventHandler(OnMouseDown);
                btnSlot[i, 0].MouseUp += new MouseEventHandler(OnMouseUp);
                btnSlot[i, 0].MouseMove += new MouseEventHandler(OnMouseMove);

                if (btnSlot[i, 0].Top + 45 > groupBox2.Top + groupBox2.Height) 
                {
                    btnSlot[i, 0].Visible = false;
                }
            }

            time.Visible = false;
            score.Visible = false;

            //
          
            
            //
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

        private void demonstraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg.Text = "";
            errorCount = 5;
            for (int j = 0; j < number_pres; j++)
            {
                btnSlot[j, 0].Top = 100 + j * (height + 20);
                btnSlot[j, 0].Refresh();
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
            msg.Text = "";
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
                btnSlot[j, 0].Top = 100 + j * (height + 20);
                btnSlot[j, 0].Refresh();
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
            msg.Text = "";
            errorCount = 0;
            demonstraToolStripMenuItem.Checked = false;
            trainningToolStripMenuItem.Checked = false;
            quizToolStripMenuItem.Checked = true;
            timer2.Enabled = false;
            timer2.Stop();
            int[] seq = BuildRandomSequence3(number_pres);
            for (int j = 0; j < number_pres; j++)
            {
                btnSlot[j, 0].Top = 100 + seq[j] * (height + 20);
                btnSlot[j, 0].Refresh();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            time.Text = "时间：" + seconds + " 秒";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (axShockwaveFlash1.FrameNum + 1 == axShockwaveFlash1.TotalFrames && play_order<number_pres)
            {
                this.axShockwaveFlash1.Movie = Application.StartupPath + "\\flash\\" + btnSlot[play_order, 0].Name + ".swf";
                this.axShockwaveFlash1.Play();
                axShockwaveFlash1.Loop = false;
                play_order++;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            for (int i = 0; i < number_pres; i++)
            {
                btnSlot[i, 0].Location = new Point(btnSlot[i, 0].Location.X, (int)btnSlot[i, 0].Tag - e.NewValue * 8);
                if (btnSlot[i, 0].Location.Y < 85 || btnSlot[i, 0].Top + 45 > groupBox2.Top + groupBox2.Height)
                {
                    btnSlot[i, 0].Visible = false;
                }
                else 
                {
                    btnSlot[i, 0].Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SvDemo.Form2 form2 = new SvDemo.Form2(xmlFileString,"Add");
            form2.Text = "增加XML文档";
            DataSet ds = new DataSet("procedures");
            DataTable dt = new DataTable("procedure");
            dt.Columns.Add(new DataColumn("id", typeof(string)));
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("button", typeof(string)));
            dt.Columns.Add(new DataColumn("video", typeof(string)));
            dt.Columns.Add(new DataColumn("leftupx", typeof(string)));
            dt.Columns.Add(new DataColumn("leftupy", typeof(string)));
            dt.Columns.Add(new DataColumn("rightbottomx", typeof(string)));
            dt.Columns.Add(new DataColumn("rightbottomy", typeof(string)));
            ds.Tables.Add(dt);

            form2.setDataView(dt.DefaultView);
            form2.ds = ds;
            form2.Visible = true;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xmlViewData != null)
            {

                Form2 form2 = new Form2(xmlFileString,"Modify");
                form2.Text = "修改XML文档";
                form2.setDataView(xmlViewData);
                form2.Visible = true;
            }
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     
      

    }
}