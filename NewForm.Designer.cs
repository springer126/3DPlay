using System.Windows.Forms;
namespace SvDemo
{
    partial class NewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.openToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.cfgToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.addCfgToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.demonstraToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.trainningToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.quizToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.msg = new DevComponents.DotNetBar.LabelX();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expandablePanel3 = new DevComponents.DotNetBar.ExpandablePanel();
            this.score = new DevComponents.DotNetBar.LabelX();
            this.status = new DevComponents.DotNetBar.LabelX();
            this.time = new DevComponents.DotNetBar.LabelX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.expandablePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem8});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(784, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.openToolStripMenuItem,
            this.cfgToolStripMenuItem,
            this.addCfgToolStripMenuItem});
            this.buttonItem1.Text = "文件";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // cfgToolStripMenuItem
            // 
            this.cfgToolStripMenuItem.Name = "cfgToolStripMenuItem";
            this.cfgToolStripMenuItem.Text = "修改";
            this.cfgToolStripMenuItem.Click += new System.EventHandler(this.cfgToolStripMenuItem_Click);
            // 
            // addCfgToolStripMenuItem
            // 
            this.addCfgToolStripMenuItem.Name = "addCfgToolStripMenuItem";
            this.addCfgToolStripMenuItem.Text = "添加";
            this.addCfgToolStripMenuItem.Click += new System.EventHandler(this.addCfgToolStripMenuItem_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.demonstraToolStripMenuItem,
            this.trainningToolStripMenuItem,
            this.quizToolStripMenuItem});
            this.buttonItem2.Text = "状态";
            // 
            // demonstraToolStripMenuItem
            // 
            this.demonstraToolStripMenuItem.Name = "demonstraToolStripMenuItem";
            this.demonstraToolStripMenuItem.Text = "演示";
            this.demonstraToolStripMenuItem.Click += new System.EventHandler(this.demonstraToolStripMenuItem_Click);
            // 
            // trainningToolStripMenuItem
            // 
            this.trainningToolStripMenuItem.Name = "trainningToolStripMenuItem";
            this.trainningToolStripMenuItem.Text = "训练";
            this.trainningToolStripMenuItem.Click += new System.EventHandler(this.trainningToolStripMenuItem_Click);
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Text = "测试";
            this.quizToolStripMenuItem.Click += new System.EventHandler(this.quizToolStripMenuItem_Click);
            // 
            // buttonItem8
            // 
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "帮助";
            this.buttonItem8.Click += new System.EventHandler(this.buttonItem8_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panelEx2);
            this.groupPanel1.Controls.Add(this.panelEx1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 25);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(784, 537);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.msg);
            this.panelEx2.Controls.Add(this.axShockwaveFlash1);
            this.panelEx2.Controls.Add(this.panel2);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(650, 531);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderWidth = 3;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.msg.BackgroundStyle.Class = "";
            this.msg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.msg.Location = new System.Drawing.Point(6, 10);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 0);
            this.msg.TabIndex = 5;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(3, 24);
            this.axShockwaveFlash1.MaximumSize = new System.Drawing.Size(640, 480);
            this.axShockwaveFlash1.MinimumSize = new System.Drawing.Size(640, 480);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(640, 480);
            this.axShockwaveFlash1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel2.Location = new System.Drawing.Point(3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 480);
            this.panel2.TabIndex = 6;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Controls.Add(this.expandablePanel3);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Location = new System.Drawing.Point(653, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(125, 531);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 416);
            this.panel1.TabIndex = 3;
            // 
            // expandablePanel3
            // 
            this.expandablePanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel3.Controls.Add(this.score);
            this.expandablePanel3.Controls.Add(this.status);
            this.expandablePanel3.Controls.Add(this.time);
            this.expandablePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel3.ExpandButtonVisible = false;
            this.expandablePanel3.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel3.Name = "expandablePanel3";
            this.expandablePanel3.Size = new System.Drawing.Size(125, 109);
            this.expandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel3.Style.GradientAngle = 90;
            this.expandablePanel3.TabIndex = 2;
            this.expandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel3.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel3.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel3.TitleStyle.GradientAngle = 90;
            this.expandablePanel3.TitleText = "信息";
            // 
            // score
            // 
            // 
            // 
            // 
            this.score.BackgroundStyle.Class = "";
            this.score.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.score.Location = new System.Drawing.Point(7, 81);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(109, 18);
            this.score.TabIndex = 2;
            this.score.Text = "得分：";
            // 
            // status
            // 
            // 
            // 
            // 
            this.status.BackgroundStyle.Class = "";
            this.status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.status.Location = new System.Drawing.Point(7, 33);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(109, 18);
            this.status.TabIndex = 0;
            this.status.Text = "状态：";
            // 
            // time
            // 
            // 
            // 
            // 
            this.time.BackgroundStyle.Class = "";
            this.time.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.time.Location = new System.Drawing.Point(7, 57);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(109, 18);
            this.time.TabIndex = 1;
            this.time.Text = "时间：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Program Files\\Microsoft Visual Studio 8\\Common7\\IDE";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewForm";
            this.Text = "实训系统";
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.expandablePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem openToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem cfgToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem demonstraToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem trainningToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem quizToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.LabelX score;
        private DevComponents.DotNetBar.LabelX time;
        private DevComponents.DotNetBar.LabelX status;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel3;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private DevComponents.DotNetBar.LabelX msg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private DevComponents.DotNetBar.ButtonItem addCfgToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;

    }
}