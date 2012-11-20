using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ButtonTest;

namespace SvDemo
{
    public partial class Form2 : Form
    {
        public string xmlFile;
        public int number;
        public DataSet ds;
        public Form2(string xmlFile,string tag)
        {
            InitializeComponent();
            this.xmlFile = xmlFile;
            number = 1;
            this.Tag = tag;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if((string)(this.Tag)=="Add")
            {
                this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
                this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            }
        }

        public void setDataView(DataView data) 
        {
            this.dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if ((string)(this.Tag) == "Modify")
                ButtonTest.XMLHelper.ds.WriteXml(xmlFile);
            else if((string)(this.Tag)=="Add") 
            {
                ds.WriteXml("D:\\cfg.xml");
                XMLHelper helper = new XMLHelper("D:\\cfg.xml", false, "procedures");
                helper.SetProcedureNumber("procedures", number);
                ButtonTest.XMLHelper.ds.WriteXml("D:\\cfg.xml");
            }

            this.Dispose();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            number++;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            number--;
        }


    }
}
