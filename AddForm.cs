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
    public partial class AddForm : Office2007Form
    {
        private bool MouseIsDown = false;
        private DataSet ds;
        private DataTable dt;
        private int num_pres = 0;
        private int order = -1;

        private const int padx = 220;
        private const int pady = 210;


        private Point start;
        private Rectangle MouseRect = Rectangle.Empty;


        private bool isAdd = true;

        public AddForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Application.StartupPath;
            this.MaximizeBox = false;
            btnDelete.Enabled = false;
            Reset();
            balloonTip.SetBalloonCaption(txtProcName, "提示");
            balloonTip.SetBalloonText(txtProcName, "输入该次组装步骤名称");

            ds = new DataSet("procedures");
            dt = new DataTable("procedure");
            dt.Columns.Add(new DataColumn("id", typeof(string)));
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("image", typeof(string)));
            dt.Columns.Add(new DataColumn("button", typeof(string)));
            dt.Columns.Add(new DataColumn("video", typeof(string)));
            dt.Columns.Add(new DataColumn("leftupx", typeof(string)));
            dt.Columns.Add(new DataColumn("leftupy", typeof(string)));
            dt.Columns.Add(new DataColumn("rightbottomx", typeof(string)));
            dt.Columns.Add(new DataColumn("rightbottomy", typeof(string)));
            ds.Tables.Add(dt);

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

        private void AddForm_Load(object sender, EventArgs e)
        {
            integerInput1.Value = 0;
            integerInput2.Value = 0;
            integerInput3.Value = 0;
            integerInput4.Value = 0;
        }

        private void btnBgImage_Click(object sender, EventArgs e)
        {
            string str =  getOpenFileName();
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
            //MouseRect = Rectangle.Empty;
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
            Cursor.Clip = this.RectangleToScreen(new Rectangle(padx,pady,400,300));
            MouseRect = Rectangle.Empty;
            MouseRect = new Rectangle(StartPoint.X + padx, StartPoint.Y + pady, 0, 0);
        }


       
        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonItem bt = sender as ButtonItem;
            SetAllUnchecked();
            bt.Checked = true;
            isAdd = false;
            btnDelete.Enabled = true;
            int i = Convert.ToInt32(bt.Tag);
            order = i;
            txtProcName.Text = dt.Rows[i]["name"].ToString();
            txtBgImage.Text = dt.Rows[i]["image"].ToString();
            pictureBox1.BackgroundImage = new Bitmap(Application.StartupPath + "\\" + txtBgImage.Text);
            txtCtrlImage.Text = dt.Rows[i]["button"].ToString();
            txtBgImage.Text = dt.Rows[i]["image"].ToString();
            txtVideo.Text = dt.Rows[i]["video"].ToString();
            integerInput1.Value = Convert.ToInt32(dt.Rows[i]["leftupx"]);
            integerInput2.Value = Convert.ToInt32(dt.Rows[i]["leftupy"]);
            integerInput3.Value = Convert.ToInt32(dt.Rows[i]["rightbottomx"]);
            integerInput4.Value = Convert.ToInt32(dt.Rows[i]["rightbottomy"]);

            //DrawStart(new Point(integerInput1.Value * 5 / 8, integerInput2.Value * 5 / 8));
            //MouseRect.Width = (integerInput3.Value - integerInput1.Value) * 5 / 8;
            //MouseRect.Height = (integerInput4.Value - integerInput2.Value) * 5 / 8;
            //DrawRectangle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                DataRow dr = dt.NewRow();
                num_pres++;
                dr["id"] = (num_pres).ToString();
                if (txtProcName.Text != "" && txtBgImage.Text != "" && txtCtrlImage.Text!=""
                    && txtVideo.Text != "" && integerInput1.Value > 0 && integerInput2.Value>0
                    &&  integerInput3.Value>0 && integerInput4.Value>0 )
                {
                    dr["name"] = txtProcName.Text;
                    dr["image"] = txtBgImage.Text;
                    dr["button"] = txtCtrlImage.Text;
                    dr["video"] = txtVideo.Text;
                    dr["leftupx"] = integerInput1.Value.ToString();
                    dr["leftupy"] = integerInput2.Value.ToString();
                    dr["rightbottomx"] = integerInput3.Value.ToString();
                    dr["rightbottomy"] = integerInput4.Value.ToString();
                    dt.Rows.Add(dr);
                    MouseRect = Rectangle.Empty;
                    ShowItem();
                    Reset();
                }
                else
                {
                    MessageBox.Show("请完整填写信息"); 
                    return;              
                }
            }
            else 
            {
                dt.Rows[order]["name"] = txtProcName.Text;
                dt.Rows[order]["image"] = txtBgImage.Text;
                dt.Rows[order]["button"] = txtCtrlImage.Text;
                dt.Rows[order]["video"] = txtVideo.Text;
                dt.Rows[order]["leftupx"] = integerInput1.Value.ToString();
                dt.Rows[order]["leftupy"] = integerInput2.Value.ToString();
                dt.Rows[order]["rightbottomx"] = integerInput3.Value.ToString();
                dt.Rows[order]["rightbottomy"] = integerInput4.Value.ToString();
            }
        }

        private void ShowItem() 
        {
            itemPanel2.Items.Clear();

            int number = dt.Rows.Count;
            for (int i = 0; i < number; i++)
            {
                dt.Rows[i]["id"] = (i + 1);
                ButtonItem bt = new ButtonItem();
                bt.Text = (i + 1) + ":" + dt.Rows[i]["name"].ToString();
                bt.Tag = i;
                itemPanel2.Items.Add(bt);
                bt.MouseDown += new MouseEventHandler(item_MouseDown);
            }
            itemPanel2.Refresh();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (itemPanel2.Items.Count == 0)
            {
                MessageBox.Show("无步骤，请添加步骤");
                return;
            }
            string fileName;
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                dt.WriteXml(fileName);
                XMLHelper xh = new XMLHelper(fileName, false, "procedures");
                xh.SetProcedureNumber("procedures", num_pres);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dt.Clear();
            itemPanel2.Items.Clear();
            itemPanel2.Refresh();
            Reset();
            isAdd = true;
            num_pres = 0;
            order = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (order != -1) 
            {
                dt.Rows.RemoveAt(order);
            }
            num_pres--;
            ShowItem();
            Reset();
            isAdd = true;
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
            MouseRect = Rectangle.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            isAdd = true;
            btnDelete.Enabled = false;
            SetAllUnchecked();
        }

        private void SetAllUnchecked()
        {
            for (int i = 0; i < itemPanel2.Items.Count; i++)
            {
                ButtonItem bt = itemPanel2.Items[i] as ButtonItem;
                bt.Checked = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (integerInput1.Value > 0 && integerInput2.Value > 0 && integerInput3.Value > 0 && integerInput4.Value > 0)
            {
                int x = integerInput1.Value * 5 / 8;
                int y = integerInput2.Value * 5 / 8;
                int width = (int)(integerInput3.Value - integerInput1.Value) * 5 / 8;
                int height = (int)(integerInput4.Value - integerInput2.Value) * 5 / 8;
                e.Graphics.DrawRectangle(Pens.Red, x, y, width, height);
            }
        }
      
    }
}