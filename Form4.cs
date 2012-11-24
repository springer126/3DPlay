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
    public partial class Form4 : Office2007Form
    {
        public Form4()
        {
            InitializeComponent();
            balloonTip.SetBalloonCaption(txtProcName, "提示");
            balloonTip.SetBalloonText(txtProcName, "输入该次组装步骤名称");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnBgImage_Click(object sender, EventArgs e)
        {
            txtBgImage.Text  = getOpenFileName();
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
                    path.Replace(Application.StartupPath, "");
                }
            }
            return path;
        }
    }
}