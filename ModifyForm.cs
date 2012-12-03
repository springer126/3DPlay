using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using SvDemo;
namespace SvDemo
{
    public partial class ModifyForm : Office2007Form
    {
        private bool MouseIsDown = false;
        private DataView xmlViewData;
        private string xmlFileString;
        private int order = -1;
        private int number;

        private const int padx = 220;
        private const int pady = 210;


        private Point start;
        private Rectangle MouseRect = Rectangle.Empty;

        public ModifyForm(string str)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            balloonTip.SetBalloonCaption(txtProcName, "提示");
            balloonTip.SetBalloonText(txtProcName, "输入该次组装步骤名称");
            xmlFileString = str;
            MyInitializeModifyComponent();

            this.pictureBox1.MouseDown += new MouseEventHandler(pic_MouseDown);
            this.pictureBox1.MouseMove += new MouseEventHandler(pic_MouseMove);
            this.pictureBox1.MouseUp += new MouseEventHandler(pic_MouseUp);
        }

        private void SetRegion() 
        {
            if (MouseRect.Width > 0 && MouseRect.Height > 0)
            {
                integerInput1.Value = (MouseRect.Left - padx) * 8 / 5;
                integerInput2.Value = (MouseRect.Top - pady) * 8 / 5;
                integerInput3.Value = (MouseRect.Left + MouseRect.Width - padx) * 8 / 5;
                integerInput4.Value = (MouseRect.Top + MouseRect.Height - pady) * 8 / 5;
            }
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            integerInput1.Value = 0;
            integerInput2.Value = 0;
            integerInput3.Value = 0;
            integerInput4.Value = 0;
        }

        private void btnBgImage_Click(object sender, EventArgs e)
        {
            string str = getOpenFileName();
            if (str != "" && str != null)
            {
                try
                {
                    pictureBox1.BackgroundImage = new Bitmap(Application.StartupPath + "\\" + str);
                    txtBgImage.Text = str;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("请选择正确图像路径");
                }
            }
        }

        private void btnCtrlImage_Click(object sender, EventArgs e)
        {
            txtCtrlImage.Text = getOpenFileName();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            txtVideo.Text = getOpenFileName();
        }

        private string getOpenFileName() 
        {
            string path = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != null)
                {
                    path = openFileDialog.FileName;
                    path = path.Replace(Application.StartupPath+"\\", "");
                }
            }
            return path;
        }


        void pic_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Capture = false;
            Cursor.Clip = Rectangle.Empty;
            MouseIsDown = false;
            SetRegion();
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            MouseRect = Rectangle.Empty;
            DrawRectangle();
            MouseIsDown = true;
            start.X = e.Location.X;
            start.Y = e.Location.Y;
            DrawStart(e.Location);
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
                ResizeToRectangle(e.Location);
        }
        private void ResizeToRectangle(Point p)
        {
            DrawRectangle();
            MouseRect.Width = p.X - start.X;
            MouseRect.Height = p.Y - start.Y;
            DrawRectangle();
        }
        private void DrawRectangle()
        {
            Rectangle rect = this.RectangleToScreen(MouseRect);
            ControlPaint.DrawReversibleFrame(rect, Color.Black, FrameStyle.Thick);
        }
        private void DrawStart(Point StartPoint)
        {
            this.pictureBox1.Capture = true;
            //Cursor.Clip = this.RectangleToScreen(this.pictureBox1.ClientRectangle);
            Cursor.Clip = this.RectangleToScreen(new Rectangle(padx, pady, 400, 300));
            MouseRect = Rectangle.Empty;
            MouseRect = new Rectangle(StartPoint.X+padx, StartPoint.Y+pady, 0, 0);
        }



        void MyInitializeModifyComponent() 
        {
            XMLHelper xmlHelper = new XMLHelper(xmlFileString, false, "procedures");
            number = xmlHelper.GetProcedureNumber("procedures");
            this.xmlViewData = xmlHelper.GetData("procedures");
            xmlViewData = XMLHelper.ds.Tables[1].DefaultView;
            for (int i = 0; i < number; i++)
            {
                ButtonItem bt = new ButtonItem();
                bt.Text = (i + 1) + ":" + xmlViewData[i]["name"].ToString();
                bt.Tag = i;
                itemPanel1.Items.Add(bt);
                bt.MouseDown += new MouseEventHandler(item_MouseDown);
            }
        }

        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonItem bt = sender as ButtonItem;
            SetAllUnchecked();
            bt.Checked = true;
            int  i = Convert.ToInt32(bt.Tag);
            order = i;
            txtProcName.Text = xmlViewData[i]["name"].ToString();
            txtBgImage.Text = xmlViewData[i]["image"].ToString();
            pictureBox1.BackgroundImage = new Bitmap(Application.StartupPath + "\\" + txtBgImage.Text);
            txtCtrlImage.Text = xmlViewData[i]["button"].ToString();
            txtVideo.Text = xmlViewData[i]["video"].ToString();
            integerInput1.Value = Convert.ToInt32(xmlViewData[i]["leftupx"]);
            integerInput2.Value = Convert.ToInt32(xmlViewData[i]["leftupy"]);
            integerInput3.Value = Convert.ToInt32(xmlViewData[i]["rightbottomx"]);
            integerInput4.Value = Convert.ToInt32(xmlViewData[i]["rightbottomy"]);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            order = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (order == -1) 
            {
                return;
            }
            ButtonItem bit = itemPanel1.Items[order] as ButtonItem;
            XMLHelper.ds.Tables[1].Rows[order]["name"] = txtProcName.Text;
            XMLHelper.ds.Tables[1].Rows[order]["image"] = txtBgImage.Text;
            XMLHelper.ds.Tables[1].Rows[order]["button"] = txtCtrlImage.Text;
            XMLHelper.ds.Tables[1].Rows[order]["video"] = txtVideo.Text;
            XMLHelper.ds.Tables[1].Rows[order]["leftupx"] = integerInput1.Value.ToString();
            XMLHelper.ds.Tables[1].Rows[order]["leftupy"] = integerInput2.Value.ToString();
            XMLHelper.ds.Tables[1].Rows[order]["rightbottomx"] = integerInput3.Value.ToString();
            XMLHelper.ds.Tables[1].Rows[order]["rightbottomy"] = integerInput4.Value.ToString();
            XMLHelper.ds.WriteXml(xmlFileString);
            bit.Text = (order+1)+":"+txtProcName.Text;
            bit.Refresh();
        }

        private void Reset()
        {
            txtProcName.Text = "";
            txtBgImage.Text = "";
            txtCtrlImage.Text = "";
            pictureBox1.BackgroundImage = null;
            txtBgImage.Text = "";
            txtVideo.Text = "";
            integerInput1.Value = 0;
            integerInput2.Value = 0;
            integerInput3.Value = 0;
            integerInput4.Value = 0;
        }

        private void SetAllUnchecked()
        {
            for (int i=0;i<itemPanel1.Items.Count;i++)
            {
                ButtonItem bt = itemPanel1.Items[i] as ButtonItem;
                bt.Checked = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (integerInput1.Value > 0 && integerInput2.Value > 0 && integerInput3.Value > 0 && integerInput4.Value > 0)
            {
                int x = integerInput1.Value * 5 / 8;
                int y = integerInput2.Value * 5 / 8;
                int width = (int)(integerInput3.Value - integerInput1.Value) * 5 /8;
                int height = (int)(integerInput4.Value - integerInput2.Value) * 5 / 8;
                e.Graphics.DrawRectangle(Pens.Red, x, y, width, height);  
            }
        }

      
    }
}