namespace ZGReader
{
    partial class ReaderForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBookName = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.pFind = new System.Windows.Forms.Panel();
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.pEncoding = new System.Windows.Forms.Panel();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblEncodingClose = new System.Windows.Forms.Label();
            this.btnSaveEncoding = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblFindClose = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tsmiEncoding = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbUtf8 = new System.Windows.Forms.RadioButton();
            this.rdbGb2312 = new System.Windows.Forms.RadioButton();
            this.MainMenu.SuspendLayout();
            this.pFind.SuspendLayout();
            this.pEncoding.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.ContextMenuStrip = this.MainMenu;
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContent.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(0, 0);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbContent.Size = new System.Drawing.Size(584, 261);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            this.rtbContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rtbContent_MouseUp);
            this.rtbContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtbContent_MouseMove);
            this.rtbContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbContent_MouseDown);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBookName,
            this.tsmiClose,
            this.tsmiTopMost,
            this.tsmiOpen,
            this.tsmiLoadBook,
            this.tsmiDeleteBook,
            this.tsmiSaveBook,
            this.tsmiEncoding,
            this.tsmiSetting});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowImageMargin = false;
            this.MainMenu.Size = new System.Drawing.Size(163, 198);
            // 
            // tsmiBookName
            // 
            this.tsmiBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsmiBookName.Name = "tsmiBookName";
            this.tsmiBookName.ReadOnly = true;
            this.tsmiBookName.Size = new System.Drawing.Size(127, 16);
            this.tsmiBookName.Text = "BookName";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(162, 22);
            this.tsmiClose.Text = "Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiTopMost
            // 
            this.tsmiTopMost.Name = "tsmiTopMost";
            this.tsmiTopMost.Size = new System.Drawing.Size(162, 22);
            this.tsmiTopMost.Text = "TopMost";
            this.tsmiTopMost.Click += new System.EventHandler(this.tsmiTopMost_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(162, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiLoadBook
            // 
            this.tsmiLoadBook.Name = "tsmiLoadBook";
            this.tsmiLoadBook.Size = new System.Drawing.Size(162, 22);
            this.tsmiLoadBook.Text = "Load";
            // 
            // tsmiDeleteBook
            // 
            this.tsmiDeleteBook.Name = "tsmiDeleteBook";
            this.tsmiDeleteBook.Size = new System.Drawing.Size(162, 22);
            this.tsmiDeleteBook.Text = "Delete";
            this.tsmiDeleteBook.Click += new System.EventHandler(this.tsmiDeleteBook_Click);
            // 
            // tsmiSaveBook
            // 
            this.tsmiSaveBook.Name = "tsmiSaveBook";
            this.tsmiSaveBook.Size = new System.Drawing.Size(162, 22);
            this.tsmiSaveBook.Text = "SaveBook";
            this.tsmiSaveBook.Click += new System.EventHandler(this.tsmiSaveBook_Click);
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(162, 22);
            this.tsmiSetting.Text = "Setting";
            this.tsmiSetting.Click += new System.EventHandler(this.tsmiSetting_Click);
            // 
            // pFind
            // 
            this.pFind.Controls.Add(this.lblFindClose);
            this.pFind.Controls.Add(this.btnFind);
            this.pFind.Controls.Add(this.txtFindText);
            this.pFind.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFind.Location = new System.Drawing.Point(104, 80);
            this.pFind.Name = "pFind";
            this.pFind.Size = new System.Drawing.Size(369, 35);
            this.pFind.TabIndex = 2;
            this.pFind.Visible = false;
            // 
            // txtFindText
            // 
            this.txtFindText.Location = new System.Drawing.Point(3, 4);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(306, 27);
            this.txtFindText.TabIndex = 0;
            this.txtFindText.TextChanged += new System.EventHandler(this.txtFindText_TextChanged);
            // 
            // pEncoding
            // 
            this.pEncoding.Controls.Add(this.rdbGb2312);
            this.pEncoding.Controls.Add(this.rdbUtf8);
            this.pEncoding.Controls.Add(this.lblEncodingClose);
            this.pEncoding.Controls.Add(this.btnSaveEncoding);
            this.pEncoding.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEncoding.Location = new System.Drawing.Point(155, 121);
            this.pEncoding.Name = "pEncoding";
            this.pEncoding.Size = new System.Drawing.Size(241, 36);
            this.pEncoding.TabIndex = 3;
            this.pEncoding.Visible = false;
            // 
            // lblFormClose
            // 
            this.lblFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormClose.AutoSize = true;
            this.lblFormClose.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormClose.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFormClose.Image = global::ZGReader.Properties.Resources.form_close;
            this.lblFormClose.Location = new System.Drawing.Point(567, 2);
            this.lblFormClose.Name = "lblFormClose";
            this.lblFormClose.Size = new System.Drawing.Size(14, 15);
            this.lblFormClose.TabIndex = 3;
            this.lblFormClose.Text = "X";
            this.lblFormClose.Click += new System.EventHandler(this.lblFormClose_Click);
            // 
            // lblEncodingClose
            // 
            this.lblEncodingClose.AutoSize = true;
            this.lblEncodingClose.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncodingClose.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEncodingClose.Image = global::ZGReader.Properties.Resources.form_close;
            this.lblEncodingClose.Location = new System.Drawing.Point(221, 4);
            this.lblEncodingClose.Name = "lblEncodingClose";
            this.lblEncodingClose.Size = new System.Drawing.Size(14, 15);
            this.lblEncodingClose.TabIndex = 2;
            this.lblEncodingClose.Text = "X";
            this.lblEncodingClose.Click += new System.EventHandler(this.lblEncodingClose_Click);
            // 
            // btnSaveEncoding
            // 
            this.btnSaveEncoding.BackgroundImage = global::ZGReader.Properties.Resources.button_save;
            this.btnSaveEncoding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveEncoding.FlatAppearance.BorderSize = 0;
            this.btnSaveEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEncoding.Location = new System.Drawing.Point(176, 6);
            this.btnSaveEncoding.Name = "btnSaveEncoding";
            this.btnSaveEncoding.Size = new System.Drawing.Size(25, 25);
            this.btnSaveEncoding.TabIndex = 1;
            this.btnSaveEncoding.UseVisualStyleBackColor = true;
            this.btnSaveEncoding.Click += new System.EventHandler(this.btnSaveEncoding_Click);
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMin.Image = global::ZGReader.Properties.Resources.minimize_box;
            this.lblMin.Location = new System.Drawing.Point(540, 4);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(14, 10);
            this.lblMin.TabIndex = 7;
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblFindClose
            // 
            this.lblFindClose.AutoSize = true;
            this.lblFindClose.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindClose.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFindClose.Image = global::ZGReader.Properties.Resources.form_close;
            this.lblFindClose.Location = new System.Drawing.Point(352, 3);
            this.lblFindClose.Name = "lblFindClose";
            this.lblFindClose.Size = new System.Drawing.Size(14, 15);
            this.lblFindClose.TabIndex = 2;
            this.lblFindClose.Text = "X";
            this.lblFindClose.Click += new System.EventHandler(this.lblFindClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::ZGReader.Properties.Resources.file_search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(310, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(32, 32);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tsmiEncoding
            // 
            this.tsmiEncoding.Name = "tsmiEncoding";
            this.tsmiEncoding.Size = new System.Drawing.Size(162, 22);
            this.tsmiEncoding.Text = "Encoding";
            this.tsmiEncoding.Click += new System.EventHandler(this.tsmiEncoding_Click);
            // 
            // rdbUtf8
            // 
            this.rdbUtf8.AutoSize = true;
            this.rdbUtf8.Location = new System.Drawing.Point(4, 6);
            this.rdbUtf8.Name = "rdbUtf8";
            this.rdbUtf8.Size = new System.Drawing.Size(70, 24);
            this.rdbUtf8.TabIndex = 5;
            this.rdbUtf8.TabStop = true;
            this.rdbUtf8.Text = "UTF-8";
            this.rdbUtf8.UseVisualStyleBackColor = true;
            // 
            // rdbGb2312
            // 
            this.rdbGb2312.AutoSize = true;
            this.rdbGb2312.Location = new System.Drawing.Point(75, 6);
            this.rdbGb2312.Name = "rdbGb2312";
            this.rdbGb2312.Size = new System.Drawing.Size(89, 24);
            this.rdbGb2312.TabIndex = 6;
            this.rdbGb2312.TabStop = true;
            this.rdbGb2312.Text = "GB-2312";
            this.rdbGb2312.UseVisualStyleBackColor = true;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lblFormClose);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.pEncoding);
            this.Controls.Add(this.pFind);
            this.Controls.Add(this.rtbContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ReaderForm";
            this.Text = "ZGReader";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReaderForm_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.pFind.ResumeLayout(false);
            this.pFind.PerformLayout();
            this.pEncoding.ResumeLayout(false);
            this.pEncoding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteBook;
        private System.Windows.Forms.Panel pFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.Label lblFindClose;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ToolStripMenuItem tsmiTopMost;
        private System.Windows.Forms.ToolStripTextBox tsmiBookName;
        private System.Windows.Forms.Panel pEncoding;
        private System.Windows.Forms.Label lblEncodingClose;
        private System.Windows.Forms.Button btnSaveEncoding;
        private System.Windows.Forms.ToolStripMenuItem tsmiEncoding;
        private System.Windows.Forms.RadioButton rdbUtf8;
        private System.Windows.Forms.RadioButton rdbGb2312;
    }
}