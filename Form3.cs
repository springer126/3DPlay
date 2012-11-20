using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using ButtonTest;

namespace SvDemo
{
    public partial class Form3 : Form
    {
        private string xmlFileName;
        
        public Form3()
        {
            InitializeComponent();
        }


        #region 添加/编辑节点方法
        private StreamWriter sr;
        public void exportToXml(TreeView tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            //Write the header
            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            //Write our root node
            sr.WriteLine("<" + treeView1.Nodes[0].Text + " number=\""+Form1.number_pres+"\""+" >");
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes);
            }
            //Close the root node
            sr.WriteLine("</" + treeView1.Nodes[0].Text + ">");
            sr.Close();
        }
        //保存xml
        private void saveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                if (node.Nodes.Count > 0)
                {
                    sr.WriteLine("<" + node.Text + ">");
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text + ">");
                }
                else
                {
                    sr.WriteLine(node.Text);
                }

            }
        }
        #endregion

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtModify.Text != "")
            {
                string ss = treeView1.SelectedNode.Text;

                treeView1.SelectedNode.Text = txtModify.Text;
                txtModify.Text = "";
                exportToXml(treeView1, xmlFileName);

            }
            else
            {
                MessageBox.Show("请输入被编辑节点的名称！");
            }
        }

        public TreeView getView() 
        {
            return this.treeView1;
        }


        public void setXMLFileName(string str)
        {
            xmlFileName = str;
        }

        //添加节点
        public void addTreeNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList xNodeList;
            if (xmlNode.HasChildNodes)
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                {
                    xNode = xmlNode.ChildNodes[x];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[x];
                    addTreeNode(xNode, tNode);
                }
            }
            else
            {
                treeNode.Text = xmlNode.OuterXml.Trim();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "")
            {
                TreeView treeView = new TreeView();
                treeView1.SelectedNode.Nodes.Add(txtAdd.Text.Trim());
                txtAdd.Text = "";
                exportToXml(treeView1, xmlFileName);

            }
            else
            {
                MessageBox.Show("尚未输入节点的名称！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
            delexportToXml(treeView1, xmlFileName);
        }

        # region 删除节点方法
        public void delexportToXml(TreeView tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);

            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");

            sr.WriteLine("<" + treeView1.Nodes[0].Text + ">");
            foreach (TreeNode node in tv.Nodes)
            {
                delNode(node.Nodes);
            }

            sr.WriteLine("</" + treeView1.Nodes[0].Text + ">");
            sr.Close();
        }
        //保存xml
        private void delNode(TreeNodeCollection tnc)
        {

            XmlDocument xDoc = new XmlDocument();

            foreach (TreeNode node in tnc)
            {
                if (node.Nodes.Count > 0)
                {
                    sr.WriteLine("<" + node.Text + ">");
                    if (treeView1.Nodes[0].Name == node.Text) //遍历出的节点为当前所选节点则删除
                    {
                        xDoc.RemoveAll();
                    }
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text + ">");
                }
                else
                {
                    sr.WriteLine(node.Text);
                }

            }
        }
        #endregion
    }
}
