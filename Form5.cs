using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace SvDemo
{
    public partial class Form5 : Office2007Form
    {
        protected Point btnStart;
        protected Point btnEnd;
        protected Point btnOrigin;
        private Rectangle Rect = Rectangle.Empty;
        private bool bMouseDown = false;
        private bool MouseIsDown = false;
        private Rectangle MouseRect = Rectangle.Empty;


        public Form5()
        {
            InitializeComponent();
            this.pictureBox2.MouseDown += new MouseEventHandler(MouseDown);
            this.pictureBox2.MouseMove += new MouseEventHandler(MouseMove);
            this.pictureBox2.MouseUp += new MouseEventHandler(MouseUp);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            buttonX1.MouseDown += new MouseEventHandler(OnMouseDown);
            buttonX1.MouseUp += new MouseEventHandler(OnMouseUp);
            balloonTip1.SetBalloonCaption(labelX1, "警告");
            balloonTip1.AutoCloseTimeOut = 1000;
            //balloonTip1.Enabled = false;
            balloonTip1.SetBalloonText(labelX1, "ospaufospeufioesuf");

            this.superTooltip1.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            superTooltip1.SetSuperTooltip(buttonX1,new DevComponents.DotNetBar.SuperTooltipInfo("警告","","警告12jldsjflk",null,null,DevComponents.DotNetBar.eTooltipColor.Lemon));
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            ButtonX bt = sender as ButtonX;
            bt.BackColor = System.Drawing.Color.Transparent;
            btnStart = Cursor.Position;
            btnOrigin = bt.Location;
            bMouseDown = true;
            bt.BringToFront();
            while (e.Button == MouseButtons.Left && bMouseDown)
            {
                int left = Cursor.Position.X - this.Location.X - 60;
                int top = Cursor.Position.Y - this.Location.Y - 60;
                bt.Location = new Point(left, top);
                Application.DoEvents();
            }
        
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            ButtonX btn = sender as ButtonX;
            bMouseDown = false;
            Point pos = btn.Location;
            btn.Location = btnOrigin;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Rect = new Rectangle(integerInput1.Value, integerInput2.Value, integerInput3.Value, integerInput4.Value);
            Rectangle rect = this.RectangleToScreen(Rect);
            ControlPaint.DrawReversibleFrame(rect, Color.Black, FrameStyle.Thick);
        }

        void MouseUp(object sender, MouseEventArgs e)
        {
            //this.Capture = false;
            this.pictureBox2.Capture = false;
            Cursor.Clip = Rectangle.Empty;
            MouseIsDown = false;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            DrawRectangle();
            MouseIsDown = true;
            DrawStart(e.Location);
        }
        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
                ResizeToRectangle(e.Location);
        }
        private void ResizeToRectangle(Point p)
        {
            DrawRectangle();
            MouseRect.Width = p.X - MouseRect.Left+pictureBox2.Location.X;
            MouseRect.Height = p.Y - MouseRect.Top + pictureBox2.Location.Y;
            DrawRectangle();
        }
        private void DrawRectangle()
        {
            Rectangle rect = this.RectangleToScreen(MouseRect);
            ControlPaint.DrawReversibleFrame(rect, Color.Black, FrameStyle.Thick);
        }
        private void DrawStart(Point StartPoint)
        {
            //this.Capture = true;
            this.pictureBox2.Capture = true;
            //这是设置鼠标筐选时鼠标的移动区域 和控件对鼠标的捕获
            //Cursor.Clip = this.RectangleToScreen(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            Cursor.Clip = this.RectangleToScreen(this.pictureBox2.ClientRectangle);
            MouseRect = new Rectangle(StartPoint.X+pictureBox2.Location.X, StartPoint.Y+pictureBox2.Location.Y, 0, 0);
        }

    }
}