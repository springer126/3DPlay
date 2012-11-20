using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ButtonTest
{
    class XMLHelper
    {
        //定义XML文件的路径
        protected string strXmlFile;

        //定义XML文档对象
        protected static XmlDocument objXmlDoc = new XmlDocument();
        public static DataSet ds;


        public XMLHelper(string XmlFile, Boolean bOverWrite, string sRoot)
        {
            try
            {
                //如果覆盖模式，则强行创建一个xml文档
                if (bOverWrite)
                {
                    objXmlDoc.AppendChild(objXmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));//设置xml的版本，格式信息
                    objXmlDoc.AppendChild(objXmlDoc.CreateElement("", sRoot, ""));//创建根元素
                    objXmlDoc.Save(XmlFile);//保存
                }
                else //否则，检查文件是否存在，不存在则创建
                {
                    if (!(File.Exists(XmlFile)))
                    {
                        objXmlDoc.AppendChild(objXmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
                        objXmlDoc.AppendChild(objXmlDoc.CreateElement("", sRoot, ""));
                        objXmlDoc.Save(XmlFile);
                    }
                }
                objXmlDoc.Load(XmlFile);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            strXmlFile = XmlFile;
            ds = new DataSet();
        }

        public int GetProcedureNumber(string XmlPathNode)
        {
            try
            {
                XmlNode node = objXmlDoc.SelectSingleNode(XmlPathNode);
                int number = Convert.ToInt32(node.Attributes[0].Value);
                return number;
            }
            catch(System.Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public int SetProcedureNumber(string XmlPathNode,int num)
        {
            try
            {
                objXmlDoc.Load("D:\\cfg.xml");
                XmlNode node = objXmlDoc.SelectSingleNode(XmlPathNode);
                XmlAttribute xmlNum = objXmlDoc.CreateAttribute("number");
                xmlNum.Value = (num-1).ToString();
                node.Attributes.Append(xmlNum);
                StringReader read = new StringReader(objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
                ds.Clear();
                ds.ReadXml(read);
                return 1;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public DataView GetData(string XmlPathNode)
        {
            //查找数据。返回一个DataView
            try
            {
                StringReader read = new StringReader(objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
                ds.ReadXml(read);
                return ds.Tables[1].DefaultView;
            }
            catch
            {
                return null;
            }
        }

    
    }
}
