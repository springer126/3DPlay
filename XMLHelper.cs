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
        //����XML�ļ���·��
        protected string strXmlFile;

        //����XML�ĵ�����
        protected static XmlDocument objXmlDoc = new XmlDocument();
        public static DataSet ds;


        public XMLHelper(string XmlFile, Boolean bOverWrite, string sRoot)
        {
            try
            {
                //�������ģʽ����ǿ�д���һ��xml�ĵ�
                if (bOverWrite)
                {
                    objXmlDoc.AppendChild(objXmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));//����xml�İ汾����ʽ��Ϣ
                    objXmlDoc.AppendChild(objXmlDoc.CreateElement("", sRoot, ""));//������Ԫ��
                    objXmlDoc.Save(XmlFile);//����
                }
                else //���򣬼���ļ��Ƿ���ڣ��������򴴽�
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
            //�������ݡ�����һ��DataView
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
