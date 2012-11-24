using System.Windows.Forms;
namespace SvDemo
{
    partial class Form4
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
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.expandablePanel3 = new DevComponents.DotNetBar.ExpandablePanel();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.expandablePanel4 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.integerInput4 = new DevComponents.Editors.IntegerInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.integerInput3 = new DevComponents.Editors.IntegerInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.integerInput2 = new DevComponents.Editors.IntegerInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnVideo = new DevComponents.DotNetBar.ButtonX();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnCtrlImage = new DevComponents.DotNetBar.ButtonX();
            this.txtCtrlImage = new System.Windows.Forms.TextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnBgImage = new DevComponents.DotNetBar.ButtonX();
            this.txtBgImage = new System.Windows.Forms.TextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.balloonTip = new DevComponents.DotNetBar.BalloonTip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.expandablePanel1.SuspendLayout();
            this.expandablePanel2.SuspendLayout();
            this.expandablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.expandablePanel3);
            this.expandablePanel1.Controls.Add(this.expandablePanel2);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(200, 573);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "配置选项";
            // 
            // expandablePanel3
            // 
            this.expandablePanel3.AutoScroll = true;
            this.expandablePanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel3.Location = new System.Drawing.Point(0, 237);
            this.expandablePanel3.Name = "expandablePanel3";
            this.expandablePanel3.Size = new System.Drawing.Size(200, 336);
            this.expandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.expandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel3.Style.GradientAngle = 90;
            this.expandablePanel3.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandablePanel3.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandablePanel3.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.expandablePanel3.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.expandablePanel3.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
            this.expandablePanel3.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
            this.expandablePanel3.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.expandablePanel3.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.expandablePanel3.TabIndex = 2;
            this.expandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel3.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel3.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel3.TitleStyle.GradientAngle = 90;
            this.expandablePanel3.TitleText = "添加配置文件";
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.AutoScroll = true;
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel2.Controls.Add(this.itemPanel1);
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 26);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(200, 211);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 1;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "修改配置文件";
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.itemPanel1.BackgroundStyle.BackColorGradientAngle = 90;
            this.itemPanel1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.itemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.itemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanel1.BackgroundStyle.Class = "";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 26);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(200, 185);
            this.itemPanel1.TabIndex = 1;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "黑色";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "蓝色";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "银色";
            // 
            // expandablePanel4
            // 
            this.expandablePanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel4.Controls.Add(this.btnCancel);
            this.expandablePanel4.Controls.Add(this.btnSave);
            this.expandablePanel4.Controls.Add(this.reflectionImage1);
            this.expandablePanel4.Controls.Add(this.integerInput4);
            this.expandablePanel4.Controls.Add(this.labelX9);
            this.expandablePanel4.Controls.Add(this.integerInput3);
            this.expandablePanel4.Controls.Add(this.labelX8);
            this.expandablePanel4.Controls.Add(this.integerInput2);
            this.expandablePanel4.Controls.Add(this.labelX7);
            this.expandablePanel4.Controls.Add(this.integerInput1);
            this.expandablePanel4.Controls.Add(this.labelX6);
            this.expandablePanel4.Controls.Add(this.labelX5);
            this.expandablePanel4.Controls.Add(this.btnVideo);
            this.expandablePanel4.Controls.Add(this.txtVideo);
            this.expandablePanel4.Controls.Add(this.labelX4);
            this.expandablePanel4.Controls.Add(this.btnCtrlImage);
            this.expandablePanel4.Controls.Add(this.txtCtrlImage);
            this.expandablePanel4.Controls.Add(this.labelX3);
            this.expandablePanel4.Controls.Add(this.btnBgImage);
            this.expandablePanel4.Controls.Add(this.txtBgImage);
            this.expandablePanel4.Controls.Add(this.labelX2);
            this.expandablePanel4.Controls.Add(this.txtProcName);
            this.expandablePanel4.Controls.Add(this.labelX1);
            this.expandablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel4.Location = new System.Drawing.Point(200, 0);
            this.expandablePanel4.Name = "expandablePanel4";
            this.expandablePanel4.Size = new System.Drawing.Size(555, 573);
            this.expandablePanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel4.Style.GradientAngle = 90;
            this.expandablePanel4.TabIndex = 1;
            this.expandablePanel4.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel4.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel4.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel4.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel4.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel4.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel4.TitleStyle.GradientAngle = 90;
            this.expandablePanel4.TitleText = "编辑框";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(263, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 32);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "修改";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(104, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 32);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.reflectionImage1.BackgroundStyle.BorderBottomColor = System.Drawing.SystemColors.ControlText;
            this.reflectionImage1.BackgroundStyle.BorderBottomWidth = 1;
            this.reflectionImage1.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlText;
            this.reflectionImage1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.reflectionImage1.BackgroundStyle.BorderLeftColor = System.Drawing.SystemColors.ControlText;
            this.reflectionImage1.BackgroundStyle.BorderLeftWidth = 1;
            this.reflectionImage1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.reflectionImage1.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.ControlText;
            this.reflectionImage1.BackgroundStyle.BorderRightWidth = 1;
            this.reflectionImage1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.reflectionImage1.BackgroundStyle.BorderTopColor = System.Drawing.SystemColors.ControlText;
            this.reflectionImage1.BackgroundStyle.BorderTopWidth = 1;
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Image = global::SvDemo.Properties.Resources.A;
            this.reflectionImage1.Location = new System.Drawing.Point(24, 210);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(400, 300);
            this.reflectionImage1.TabIndex = 21;
            // 
            // integerInput4
            // 
            // 
            // 
            // 
            this.integerInput4.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput4.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput4.Location = new System.Drawing.Point(412, 180);
            this.integerInput4.Name = "integerInput4";
            this.integerInput4.ShowUpDown = true;
            this.integerInput4.Size = new System.Drawing.Size(46, 21);
            this.integerInput4.TabIndex = 20;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(353, 180);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(64, 21);
            this.labelX9.TabIndex = 19;
            this.labelX9.Text = "右下角:Y";
            // 
            // integerInput3
            // 
            // 
            // 
            // 
            this.integerInput3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput3.Location = new System.Drawing.Point(301, 180);
            this.integerInput3.Name = "integerInput3";
            this.integerInput3.ShowUpDown = true;
            this.integerInput3.Size = new System.Drawing.Size(46, 21);
            this.integerInput3.TabIndex = 18;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(242, 180);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(64, 21);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "右下角:X";
            // 
            // integerInput2
            // 
            // 
            // 
            // 
            this.integerInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput2.Location = new System.Drawing.Point(190, 180);
            this.integerInput2.Name = "integerInput2";
            this.integerInput2.ShowUpDown = true;
            this.integerInput2.Size = new System.Drawing.Size(46, 21);
            this.integerInput2.TabIndex = 16;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(131, 180);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(64, 21);
            this.labelX7.TabIndex = 15;
            this.labelX7.Text = "左上角:Y";
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(79, 180);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(46, 21);
            this.integerInput1.TabIndex = 14;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(20, 180);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(64, 21);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "左上角:X";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(20, 158);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(89, 19);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "组装位置";
            // 
            // btnVideo
            // 
            this.btnVideo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVideo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVideo.Location = new System.Drawing.Point(315, 125);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(69, 21);
            this.btnVideo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVideo.TabIndex = 11;
            this.btnVideo.Text = "浏览……";
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // txtVideo
            // 
            this.txtVideo.Location = new System.Drawing.Point(115, 126);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(175, 21);
            this.txtVideo.TabIndex = 10;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(20, 128);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(64, 19);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "组装视频";
            // 
            // btnCtrlImage
            // 
            this.btnCtrlImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCtrlImage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCtrlImage.Location = new System.Drawing.Point(315, 93);
            this.btnCtrlImage.Name = "btnCtrlImage";
            this.btnCtrlImage.Size = new System.Drawing.Size(69, 21);
            this.btnCtrlImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCtrlImage.TabIndex = 8;
            this.btnCtrlImage.Text = "浏览……";
            this.btnCtrlImage.Click += new System.EventHandler(this.btnCtrlImage_Click);
            // 
            // txtCtrlImage
            // 
            this.txtCtrlImage.Location = new System.Drawing.Point(115, 94);
            this.txtCtrlImage.Name = "txtCtrlImage";
            this.txtCtrlImage.Size = new System.Drawing.Size(175, 21);
            this.txtCtrlImage.TabIndex = 7;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(20, 96);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(89, 19);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "组件背景图片";
            // 
            // btnBgImage
            // 
            this.btnBgImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBgImage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBgImage.Location = new System.Drawing.Point(315, 62);
            this.btnBgImage.Name = "btnBgImage";
            this.btnBgImage.Size = new System.Drawing.Size(69, 21);
            this.btnBgImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBgImage.TabIndex = 5;
            this.btnBgImage.Text = "浏览……";
            this.btnBgImage.Click += new System.EventHandler(this.btnBgImage_Click);
            // 
            // txtBgImage
            // 
            this.txtBgImage.Location = new System.Drawing.Point(115, 63);
            this.txtBgImage.Name = "txtBgImage";
            this.txtBgImage.Size = new System.Drawing.Size(175, 21);
            this.txtBgImage.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(20, 65);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(64, 19);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "背景图片";
            // 
            // txtProcName
            // 
            this.txtProcName.Location = new System.Drawing.Point(115, 32);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(175, 21);
            this.txtProcName.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(20, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 25);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "步骤名称";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = Application.StartupPath;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 573);
            this.Controls.Add(this.expandablePanel4);
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form4";
            this.Text = "实训系统配置";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel2.ResumeLayout(false);
            this.expandablePanel4.ResumeLayout(false);
            this.expandablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel3;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel4;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtProcName;
        private DevComponents.DotNetBar.BalloonTip balloonTip;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnBgImage;
        private System.Windows.Forms.TextBox txtBgImage;
        private DevComponents.DotNetBar.ButtonX btnCtrlImage;
        private System.Windows.Forms.TextBox txtCtrlImage;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnVideo;
        private System.Windows.Forms.TextBox txtVideo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.IntegerInput integerInput4;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.Editors.IntegerInput integerInput3;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.IntegerInput integerInput2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}