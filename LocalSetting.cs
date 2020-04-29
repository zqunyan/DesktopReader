using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;
using System.IO;

namespace ZGReader
{
    public partial class LocalSetting : Form
    {
        XmlDocument xml = new XmlDocument();
        XmlElement node;
        XmlNode eleFontName, eleFontSize, eleLineSpace, eleBackColor, eleScrollValue;
        string xmlPath = "settings.xml";

        public LocalSetting()
        {
            InitializeComponent();
        }

        private void LocalSetting_Load(object sender, EventArgs e)
        {
            LoadFont();
            if (File.Exists(xmlPath)) xml.Load(xmlPath);
            else
            {
                XmlDeclaration dec = xml.CreateXmlDeclaration("1.0", "utf-8", null);
                xml.AppendChild(dec);
                XmlElement root = xml.CreateElement("settingItem");
                xml.AppendChild(root);
                XmlElement rootSettings = xml.CreateElement("settings");
                XmlElement rootArticles = xml.CreateElement("articles");
                root.AppendChild(rootSettings);
                root.AppendChild(rootArticles);
                xml.Save(xmlPath);
            }
            node = (XmlElement)xml.SelectSingleNode("//settings");
            eleFontName = node.SelectSingleNode("//fontName");
            eleFontSize = node.SelectSingleNode("//fontSize");
            eleLineSpace = node.SelectSingleNode("//lineSpace");
            eleBackColor = node.SelectSingleNode("//backColor");
            eleScrollValue = node.SelectSingleNode("//scrollValue");

            if (eleFontName != null && eleFontName.InnerText != "") cmbFontFamily.Text = eleFontName.InnerText;
            else cmbFontFamily.Text = "Microsoft YaHei UI";
            if (eleFontSize != null && eleFontSize.InnerText != "") txtFontSize.Text = eleFontSize.InnerText;
            else txtFontSize.Text = "12";
            if (eleLineSpace != null && eleLineSpace.InnerText != "") txtLineSpace.Text = eleLineSpace.InnerText;
            else txtLineSpace.Text = "450";
            if (eleBackColor != null && eleBackColor.InnerText != "") pColor.BackColor = Color.FromArgb(Convert.ToInt32(eleBackColor.InnerText));
            if (eleScrollValue != null && eleScrollValue.InnerText != "") txtScrollValue.Text = eleScrollValue.InnerText;
            else txtScrollValue.Text = "1";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //fontName
            if (eleFontName != null) eleFontName.InnerText = cmbFontFamily.Text.Trim();
            else
            {
                XmlElement newElement = xml.CreateElement("fontName");
                newElement.InnerText = cmbFontFamily.Text.Trim();
                node.AppendChild(newElement);
            }
            //fontSize
            if (eleFontSize != null)
            {
                if (txtFontSize.Text.Trim() != "") eleFontSize.InnerText = txtFontSize.Text.Trim();
                else
                {
                    MessageBox.Show("FontSize is empty!");
                    txtFontSize.Focus();
                    return;
                }
            }
            else
            {
                XmlElement newElement = xml.CreateElement("fontSize");
                newElement.InnerText = txtFontSize.Text.Trim();
                node.AppendChild(newElement);
            }
            //lineSpace
            if (eleLineSpace != null)
            {
                if (txtLineSpace.Text.Trim() != "") eleLineSpace.InnerText = txtLineSpace.Text.Trim();
                else
                {
                    MessageBox.Show("LineSpace is empty!");
                    txtLineSpace.Focus();
                    return;
                }
            }
            else
            {
                XmlElement newElement = xml.CreateElement("lineSpace");
                newElement.InnerText = txtLineSpace.Text.Trim();
                node.AppendChild(newElement);
            }
            //backColor
            if (eleBackColor != null)
            {
                eleBackColor.InnerText = pColor.BackColor.ToArgb().ToString();
                if (ckbGreen.Checked) eleBackColor.InnerText = "-3674676";
                else if (ckbWhite.Checked) eleBackColor.InnerText = "-1";
            }
            else
            {
                XmlElement newElement = xml.CreateElement("backColor");
                newElement.InnerText = pColor.BackColor.ToArgb().ToString();
                node.AppendChild(newElement);
            }
            //scrollValue
            if (eleScrollValue != null)
            {
                if (txtScrollValue.Text.Trim() != "") eleScrollValue.InnerText = txtScrollValue.Text.Trim();
                else
                {
                    MessageBox.Show("scrollValue is empty!");
                    txtScrollValue.Focus();
                    return;
                }
            }
            else
            {
                XmlElement newElement = xml.CreateElement("scrollValue");
                newElement.InnerText = txtScrollValue.Text.Trim();
                node.AppendChild(newElement);
            }
          
            xml.Save(xmlPath);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadFont()
        {
            InstalledFontCollection MyFont = new InstalledFontCollection();
            FontFamily[] MyFontFamilies = MyFont.Families;
            for (int i = 0; i < MyFontFamilies.Length; i++)
            {
                cmbFontFamily.Items.Add(MyFontFamilies[i].Name);
            }
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pColor.BackColor = cd.Color;
            }
        }

    }
}