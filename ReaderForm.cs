using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace ZGReader
{
    public partial class ReaderForm : Form
    {
        XmlDocument xml = new XmlDocument();
        XmlElement nodeSetting, nodeArticles;
        XmlNode eleFormWidth, eleFormHeight, eleFormLocationX, eleFormLocationY, eleFontName, eleFontSize, eleLineSpace, eleBackColor;
        string xmlPath = "settings.xml";
        Encoding defaultEncode = Encoding.GetEncoding("GB2312");//Encoding.UTF8);
        string bookPath = "";
        string bookName = "";        
        int findIndex = 0;
        string scrollValue = "1";

        public ReaderForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义  
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作  
                return cp;
            }
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            rtbContent.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            rtbContent.MouseWheel += new MouseEventHandler(rtbContent_MouseWheel);
            if (File.Exists(xmlPath)) xml.Load(xmlPath);
            else
            {
                MessageBox.Show("Can't find settings file!");
                LocalSetting frm = new LocalSetting();
                if(frm.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("You have not saved settings file!");
                    this.Close();
                }
                else xml.Load(xmlPath);
            }
            nodeSetting = (XmlElement)xml.SelectSingleNode("//settings");
            nodeArticles = (XmlElement)xml.SelectSingleNode("//articles");
            eleFormWidth = nodeSetting.SelectSingleNode("//formWidth");
            eleFormHeight = nodeSetting.SelectSingleNode("//formHeight");
            eleFormLocationX = nodeSetting.SelectSingleNode("//formLocationX");
            eleFormLocationY = nodeSetting.SelectSingleNode("//formLocationY");

            if (eleFormWidth != null && eleFormWidth.InnerText.Trim() != "") this.Width = Convert.ToInt32(eleFormWidth.InnerText.Trim());
            if (eleFormHeight != null && eleFormHeight.InnerText.Trim() != "") this.Height = Convert.ToInt32(eleFormHeight.InnerText.Trim());
            if (eleFormLocationX != null && eleFormLocationY != null && eleFormLocationX.InnerText.Trim() != "" && eleFormLocationY.InnerText.Trim() != "")
                this.Location = new Point(Convert.ToInt32(eleFormLocationX.InnerText.Trim()), Convert.ToInt32(eleFormLocationY.InnerText.Trim()));

            #region 加载历史保存书单
            foreach (XmlElement elem in nodeArticles.ChildNodes)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(elem.GetAttribute("fileName"));
                tsmi.Click += new EventHandler(tsmi_Click);
                tsmiLoadBook.DropDownItems.Add(tsmi);

                if (elem.GetAttribute("status") == "1")
                {
                    bookPath = elem.GetAttribute("fileName");
                    if (!File.Exists(bookPath)) return;
                    //首先查找是否已经存在编码信息
                    if (elem.GetAttribute("encoding").ToString().Trim() != "") OpenFile(bookPath, Encoding.GetEncoding(elem.GetAttribute("encoding").ToString().Trim()));
                    else OpenFile(bookPath, TxtFileEncoder.GetEncoding(bookPath, defaultEncode));
                    if (elem.GetAttribute("readHist") != "")
                    {
                        rtbContent.Select(Convert.ToInt32(elem.GetAttribute("readHist")), 0);
                        rtbContent.ScrollToCaret();
                        tsmiBookName.Text = bookName;
                    }
                }
            }
            #endregion 加载历史保存书单
            //LoadSetting();
        }

        //加载历史书单事件
        void tsmi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            foreach (XmlElement elem in nodeArticles.ChildNodes)
            {
                elem.SetAttribute("status", "0");
                if (elem.GetAttribute("fileName") == bookPath)
                {
                    elem.SetAttribute("readHist", rtbContent.GetCharIndexFromPosition(new Point(1, 1)).ToString());
                }
                if (elem.GetAttribute("fileName") == tsmi.Text)
                {
                    elem.SetAttribute("status", "1");
                }

            }
            xml.Save(xmlPath);
            foreach (XmlElement elem in nodeArticles.ChildNodes)
            {
                if (elem.GetAttribute("fileName") == tsmi.Text)
                {
                    if (elem.GetAttribute("encoding").ToString().Trim() != "") OpenFile(elem.GetAttribute("fileName"), Encoding.GetEncoding(elem.GetAttribute("encoding").ToString().Trim()));
                    else OpenFile(elem.GetAttribute("fileName"), TxtFileEncoder.GetEncoding(elem.GetAttribute("fileName"), defaultEncode));
                    if (elem.GetAttribute("readHist") != "")
                    {
                        rtbContent.Select(Convert.ToInt32(elem.GetAttribute("readHist")), 0);
                        rtbContent.ScrollToCaret();
                    }
                }
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bookPath = ofd.FileName;
                OpenFile(ofd.FileName, TxtFileEncoder.GetEncoding(ofd.FileName, defaultEncode));
                //OpenFile(ofd.FileName, defaultEncode);
            }
        }

        private void OpenFile(string strPath, Encoding encoding)
        {
            Cursor.Current = Cursors.WaitCursor;
            bookPath = strPath;
            bookName = strPath.Substring(strPath.LastIndexOf('\\') + 1, strPath.LastIndexOf('.') - strPath.LastIndexOf('\\') - 1);
            tsmiBookName.Text = bookName;
            try
            {
                FileStream fs = new FileStream(strPath, FileMode.Open);
                StreamReader sr = new StreamReader(fs, encoding);
                rtbContent.Text = sr.ReadToEnd();
                rtbContent.Text = Regex.Replace(rtbContent.Text, @"(?s)\n\s*\n", "\n");
                sr.Dispose();
                sr.Close();
                getContentsList(rtbContent.Text);
                LoadSetting();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        //保存到书单
        private void tsmiSaveBook_Click(object sender, EventArgs e)
        {
            nodeArticles = (XmlElement)xml.SelectSingleNode("//articles");
            bool isHave = false;
            foreach (XmlElement elem in nodeArticles.ChildNodes)
            {
                if (elem.GetAttribute("fileName") != bookPath)
                {
                    elem.SetAttribute("status", "0");
                    //isHave = false;
                    //continue;
                }
                else
                {
                    elem.SetAttribute("status", "1");
                    isHave = true;
                    //break;
                }

            }
            if (!isHave)
            {
                XmlElement elem_new = xml.CreateElement("article");
                elem_new.SetAttribute("fileName", bookPath);
                elem_new.SetAttribute("status", "1");
                elem_new.SetAttribute("readHist", rtbContent.GetCharIndexFromPosition(new Point(1, 1)).ToString());
                nodeArticles.AppendChild(elem_new);
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Haved");
            }
            xml.Save(xmlPath);
        }

        //打开设置窗口
        private void tsmiSetting_Click(object sender, EventArgs e)
        {
            LocalSetting frmSetting = new LocalSetting();
            if (frmSetting.ShowDialog() == DialogResult.OK)
            {
                LoadSetting();
            }
        }

        //加载本地设置
        private void LoadSetting()
        {
            int index = rtbContent.GetCharIndexFromPosition(new Point(1, 1));
            rtbContent.SelectAll();
            xml.Load(xmlPath);
            XmlElement node = (XmlElement)xml.SelectSingleNode("//settings");
            XmlNode nodeFontName = node.SelectSingleNode("//fontName");
            XmlNode nodeFontSize = node.SelectSingleNode("//fontSize");
            XmlNode nodeLineSpace = node.SelectSingleNode("//lineSpace");
            XmlNode nodeBackColor = node.SelectSingleNode("//backColor");
            XmlNode nodeScrollValue = node.SelectSingleNode("//scrollValue");

            if (nodeLineSpace != null && nodeLineSpace.InnerText.Trim() != "") 
                Pub.SetLineSpace(rtbContent, Convert.ToInt32(nodeLineSpace.InnerText.Trim()));
            if (nodeFontName != null && nodeFontSize != null && nodeFontName.InnerText.Trim() != "" && nodeFontSize.InnerText.Trim() != "")
                rtbContent.Font = new Font(nodeFontName.InnerText.Trim(), Convert.ToInt32(nodeFontSize.InnerText.Trim()));
            if (nodeBackColor != null && nodeBackColor.InnerText != "")
                rtbContent.BackColor = Color.FromArgb(Convert.ToInt32(nodeBackColor.InnerText.Trim()));
            if (nodeScrollValue != null && nodeScrollValue.InnerText != "") 
                scrollValue = nodeScrollValue.InnerText;

            rtbContent.Select(index, 0);
            rtbContent.ScrollToCaret();
        }

        #region 关闭窗口事件
        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nodeArticles = (XmlElement)xml.SelectSingleNode("//articles");
            if (nodeArticles != null)
            {
                foreach (XmlElement elem in nodeArticles.ChildNodes)
                {
                    if (elem.GetAttribute("fileName") == bookPath)
                    {
                        elem.SetAttribute("readHist", rtbContent.GetCharIndexFromPosition(new Point(1, 1)).ToString());
                    }
                }

                nodeSetting = (XmlElement)xml.SelectSingleNode("//settings");
                eleFormWidth = nodeSetting.SelectSingleNode("//formWidth");
                eleFormHeight = nodeSetting.SelectSingleNode("//formHeight");
                eleFormLocationX = nodeSetting.SelectSingleNode("//formLocationX");
                eleFormLocationY = nodeSetting.SelectSingleNode("//formLocationY");

                if (eleFormWidth != null) eleFormWidth.InnerText = this.Width.ToString();
                else
                {
                    XmlElement newElement = xml.CreateElement("formWidth");
                    newElement.InnerText = this.Width.ToString();
                    nodeSetting.AppendChild(newElement);
                }
                if (eleFormHeight != null) eleFormHeight.InnerText = this.Height.ToString();
                else
                {
                    XmlElement newElement = xml.CreateElement("formHeight");
                    newElement.InnerText = this.Height.ToString();
                    nodeSetting.AppendChild(newElement);
                }
                if (eleFormLocationX != null) eleFormLocationX.InnerText = this.Location.X.ToString();
                else
                {
                    XmlElement newElement = xml.CreateElement("formLocationX");
                    newElement.InnerText = this.Location.X.ToString();
                    nodeSetting.AppendChild(newElement);
                }
                if (eleFormLocationY != null) eleFormLocationY.InnerText = this.Location.Y.ToString();
                else
                {
                    XmlElement newElement = xml.CreateElement("formLocationY");
                    newElement.InnerText = this.Location.Y.ToString();
                    nodeSetting.AppendChild(newElement);
                }

                xml.Save(xmlPath);
            }
        }
        #endregion 关闭窗口事件

        //删除图书
        private void tsmiDeleteBook_Click(object sender, EventArgs e)
        {
            nodeArticles = (XmlElement)xml.SelectSingleNode("//articles");
            foreach (XmlElement elem in nodeArticles.ChildNodes)
            {
                if (elem.GetAttribute("fileName") == bookPath)
                {
                    nodeArticles.RemoveChild(elem);
                }
            }
            if (!nodeArticles.HasChildNodes)
            {
                xml.Save(xmlPath);
                return;
            }
            XmlElement firstElem = (XmlElement)nodeArticles.FirstChild;
            firstElem.SetAttribute("status", "1");
            xml.Save(xmlPath);

            OpenFile(firstElem.GetAttribute("fileName"), TxtFileEncoder.GetEncoding(firstElem.GetAttribute("fileName"), defaultEncode));
            if (firstElem.GetAttribute("readHist") != "")
            {
                rtbContent.Select(Convert.ToInt32(firstElem.GetAttribute("readHist")), 0);
                rtbContent.ScrollToCaret();
            }
        }

        #region 查找文字
        private void lblFindClose_Click(object sender, EventArgs e)
        {
            txtFindText.Text = "";
            pFind.Visible = false;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindText.Text.Trim() == "")
            {
                return;
            }            
            if (findIndex == 0) findIndex = rtbContent.Find(txtFindText.Text.Trim(), RichTextBoxFinds.None);
            else findIndex = rtbContent.Find(txtFindText.Text.Trim(), findIndex + 1, RichTextBoxFinds.None);
            if (findIndex == -1)
            {
                findIndex = 0;
                return;
            }
            rtbContent.Select(findIndex, 2);
            rtbContent.ScrollToCaret();
            //pFind.Visible = false;
        }
        private void txtFindText_TextChanged(object sender, EventArgs e)
        {
            findIndex = 0;
        }
        //获取目录列表
        private void getContentsList(string strContent)
        {
            listContents.Items.Clear();
            string strPattern = @"(\s*第)(.{1,4})[章节卷集部篇回](.*)";
            foreach (Match mc in Regex.Matches(strContent, strPattern))
            {
                string strResult = mc.Value.Trim();
                if (strResult.Length > 25) listContents.Items.Add(strResult.Substring(0, 25));
                else listContents.Items.Add(strResult);
            }
        }
        private void listContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listContents.SelectedItem.ToString() != "")
            {
                index = rtbContent.Find(listContents.SelectedItem.ToString(), RichTextBoxFinds.None);
                rtbContent.SelectionStart = index;
                rtbContent.ScrollToCaret();
                rtbContent.Select(index, 0);
                listContents.Visible = false;
            }
        }

        #endregion 查找文字
        #region 文档编码
        private void tsmiEncoding_Click(object sender, EventArgs e)
        {
            pEncoding.Location = new Point(this.Width / 2 - pEncoding.Width / 2, this.Height / 2 - pEncoding.Height / 2);
            pEncoding.Visible = true;
        }

        private void lblEncodingClose_Click(object sender, EventArgs e)
        {
            pEncoding.Visible = false;
        }

        private void btnSaveEncoding_Click(object sender, EventArgs e)
        {
            nodeArticles = (XmlElement)xml.SelectSingleNode("//articles");
            if (nodeArticles != null)
            {
                foreach (XmlElement elem in nodeArticles.ChildNodes)
                {
                    if (elem.GetAttribute("fileName") == bookPath)
                    {
                        if (rdbUtf8.Checked) elem.SetAttribute("encoding", "utf-8");
                        else if (rdbGb2312.Checked) elem.SetAttribute("encoding", "GB2312");
                        xml.Save(xmlPath);
                        OpenFile(bookPath, Encoding.GetEncoding(elem.GetAttribute("encoding").ToString().Trim()));
                        pEncoding.Visible = false;
                        break;
                    }
                }
            }
        }
        #endregion 文档编码

        #region 窗口移动
        private Point oldMousePosition;
        private bool isMouseDown = false;
        int index = 0;
        private string mPosition = "";
        int pRight = 0;
        int pBottom = 0;

        private void rtbContent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldMousePosition = e.Location;
                isMouseDown = true;
                if (e.Location.X <= 5)
                {
                    this.Cursor = Cursors.SizeWE;
                    mPosition = "Left";
                    pRight = this.Right;
                }
                else if (e.Location.X >= this.Width - 5)
                {
                    this.Cursor = Cursors.SizeWE;
                    mPosition = "Right";
                }
                else if (e.Location.Y <= 5)
                {
                    this.Cursor = Cursors.SizeNS;
                    index = rtbContent.GetCharIndexFromPosition(new Point(1, 1));
                    mPosition = "Top";
                    pBottom = this.Bottom;
                }
                else if (e.Location.Y >= this.Height - 5)
                {
                    this.Cursor = Cursors.SizeNS;
                    index = rtbContent.GetCharIndexFromPosition(new Point(1, 1));
                    mPosition = "Bottom";
                }
            }
            else
            {
                isMouseDown = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void rtbContent_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            mPosition = "";
            rtbContent.Focus();//移动结束，重新获取焦点
            this.Cursor = Cursors.Default;
        }

        private void rtbContent_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown)
            {
                if (e.Location.X <= 5 || e.Location.X >= this.Width - 5)
                {
                    this.Cursor = Cursors.SizeWE;
                }
                else if (e.Location.Y <= 5 || e.Location.Y >= this.Height - 5)
                {
                    this.Cursor = Cursors.SizeNS;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                //按下 Ctrl 再拖动鼠标用以选择文字
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    this.Cursor = Cursors.Default;
                }
                else if (e.Button == MouseButtons.Left && mPosition == "Left")
                {
                    this.Width = pRight - MousePosition.X;
                    this.Location = new Point(MousePosition.X, this.Top);
                    rtbContent.Select(rtbContent.SelectionStart, 0);
                }
                else if (e.Button == MouseButtons.Left && mPosition == "Right")
                {
                    this.Width = MousePosition.X - this.Left;
                    rtbContent.Select(rtbContent.SelectionStart, 0);
                }
                else if (e.Button == MouseButtons.Left && mPosition == "Top") 
                {
                    this.Height = pBottom - MousePosition.Y;
                    this.Location = new Point(this.Left, MousePosition.Y);
                    rtbContent.Select(index, 0);
                    rtbContent.ScrollToCaret();
                }
                else if (e.Button == MouseButtons.Left && mPosition == "Bottom")
                {
                    this.Height = MousePosition.Y - this.Top;
                    rtbContent.Select(index, 0);
                    rtbContent.ScrollToCaret();
                }
                else if (e.Button == MouseButtons.Left)
                {
                    this.Cursor = Cursors.SizeAll;
                    lblMin.Focus(); //取消鼠标移动时，光标一直闪动，先把焦点移出控件
                    Point newPosition = new Point(e.Location.X - oldMousePosition.X, e.Location.Y - oldMousePosition.Y);
                    this.Location += new Size(newPosition);
                }
            }
        }
        #endregion 窗口移动

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //自订键盘快捷键
        private void ReaderForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F) && e.Control)
            {
                pFind.Location = new Point(this.Width / 2 - pFind.Width / 2, this.Height / 2 - pFind.Height / 2);
                pFind.Visible = true;
            }
            else if ((e.KeyCode == Keys.S) && e.Control)
            {
                tsmiSaveBook_Click(null, null); 
            }
            else if ((e.KeyCode == Keys.D) && e.Control)
            {
                tsmiEncoding_Click(null, null);
            }
            else if ((e.KeyCode == Keys.B) && e.Control)
            {
                if (listContents.Visible == false)
                {
                    listContents.Visible = true;
                    listContents.Location = new Point(this.Width / 2 - listContents.Width / 2, this.Height / 2 - listContents.Height / 2);
                }
                else listContents.Visible = false;
            }
        }

        //窗口置顶
        private void tsmiTopMost_Click(object sender, EventArgs e)
        {
            if (tsmiTopMost.Text == "TopMost")
            {
                tsmiTopMost.Text = "CancelTopMost";
                this.TopMost = true;
            }
            else 
            {
                tsmiTopMost.Text = "TopMost";
                this.TopMost = false;
            }
        }

        //鼠标滚动事件
        void rtbContent_MouseWheel(object sender, MouseEventArgs e)
        {
            int firstLine = rtbContent.GetLineFromCharIndex(rtbContent.GetCharIndexFromPosition(new Point(1, 1)));

            if (e.Delta > 0)
            {
                if (rtbContent.GetCharIndexFromPosition(new Point(1, 1)) == 0) return;
                int index = rtbContent.GetFirstCharIndexFromLine(firstLine - Convert.ToInt32(scrollValue));
                rtbContent.SelectionStart = index + 1;
                rtbContent.ScrollToCaret();
            }
            else
            {
                int index = rtbContent.GetFirstCharIndexFromLine(firstLine + Convert.ToInt32(scrollValue));
                rtbContent.SelectionStart = index + 1;
                rtbContent.ScrollToCaret();
            }
        }


    }
}