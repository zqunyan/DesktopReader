namespace ZGReader
{
    partial class LocalSetting
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
            this.cmbFontFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.txtLineSpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pColor = new System.Windows.Forms.Panel();
            this.ckbWhite = new System.Windows.Forms.CheckBox();
            this.ckbGreen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtScrollValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFontFamily
            // 
            this.cmbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontFamily.FormattingEnabled = true;
            this.cmbFontFamily.Location = new System.Drawing.Point(106, 24);
            this.cmbFontFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFontFamily.Name = "cmbFontFamily";
            this.cmbFontFamily.Size = new System.Drawing.Size(163, 23);
            this.cmbFontFamily.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font Family";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font Size";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(106, 50);
            this.txtFontSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(70, 23);
            this.txtFontSize.TabIndex = 3;
            // 
            // txtLineSpace
            // 
            this.txtLineSpace.Location = new System.Drawing.Point(106, 76);
            this.txtLineSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLineSpace.Name = "txtLineSpace";
            this.txtLineSpace.Size = new System.Drawing.Size(70, 23);
            this.txtLineSpace.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Line Space";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 190);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Back Color";
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(100, 18);
            this.pColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(35, 21);
            this.pColor.TabIndex = 12;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // ckbWhite
            // 
            this.ckbWhite.AutoSize = true;
            this.ckbWhite.Location = new System.Drawing.Point(141, 19);
            this.ckbWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbWhite.Name = "ckbWhite";
            this.ckbWhite.Size = new System.Drawing.Size(61, 19);
            this.ckbWhite.TabIndex = 13;
            this.ckbWhite.Text = "White";
            this.ckbWhite.UseVisualStyleBackColor = true;
            // 
            // ckbGreen
            // 
            this.ckbGreen.AutoSize = true;
            this.ckbGreen.ForeColor = System.Drawing.Color.PaleGreen;
            this.ckbGreen.Location = new System.Drawing.Point(202, 19);
            this.ckbGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbGreen.Name = "ckbGreen";
            this.ckbGreen.Size = new System.Drawing.Size(61, 19);
            this.ckbGreen.TabIndex = 14;
            this.ckbGreen.Text = "Green";
            this.ckbGreen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScrollValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFontFamily);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFontSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLineSpace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(278, 129);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paragraph";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbWhite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ckbGreen);
            this.groupBox2.Controls.Add(this.pColor);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 52);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // txtScrollValue
            // 
            this.txtScrollValue.Location = new System.Drawing.Point(106, 102);
            this.txtScrollValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScrollValue.Name = "txtScrollValue";
            this.txtScrollValue.Size = new System.Drawing.Size(70, 23);
            this.txtScrollValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scroll Value";
            // 
            // LocalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 221);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LocalSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.LocalSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFontFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.TextBox txtLineSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.CheckBox ckbWhite;
        private System.Windows.Forms.CheckBox ckbGreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtScrollValue;
        private System.Windows.Forms.Label label4;
    }
}