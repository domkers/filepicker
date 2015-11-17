namespace DumpPicker
{
    partial class FormFileName
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileName));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDumpContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUnFix = new System.Windows.Forms.Button();
            this.buttonFix = new System.Windows.Forms.Button();
            this.groupBoxPicker = new System.Windows.Forms.GroupBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFontSizeDown = new System.Windows.Forms.Button();
            this.buttonFontSizeUp = new System.Windows.Forms.Button();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名：";
            // 
            // textBoxDumpContent
            // 
            this.textBoxDumpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDumpContent.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDumpContent.Location = new System.Drawing.Point(5, 49);
            this.textBoxDumpContent.Multiline = true;
            this.textBoxDumpContent.Name = "textBoxDumpContent";
            this.textBoxDumpContent.ReadOnly = true;
            this.textBoxDumpContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDumpContent.Size = new System.Drawing.Size(923, 575);
            this.textBoxDumpContent.TabIndex = 1;
            this.textBoxDumpContent.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonUnFix);
            this.groupBox1.Controls.Add(this.buttonFix);
            this.groupBox1.Location = new System.Drawing.Point(934, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "处理";
            // 
            // buttonUnFix
            // 
            this.buttonUnFix.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUnFix.ForeColor = System.Drawing.Color.Red;
            this.buttonUnFix.Location = new System.Drawing.Point(32, 73);
            this.buttonUnFix.Name = "buttonUnFix";
            this.buttonUnFix.Size = new System.Drawing.Size(75, 23);
            this.buttonUnFix.TabIndex = 1;
            this.buttonUnFix.Text = "UnFix";
            this.buttonUnFix.UseVisualStyleBackColor = true;
            this.buttonUnFix.Click += new System.EventHandler(this.buttonUnFix_Click);
            // 
            // buttonFix
            // 
            this.buttonFix.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFix.ForeColor = System.Drawing.Color.Red;
            this.buttonFix.Location = new System.Drawing.Point(32, 29);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(75, 23);
            this.buttonFix.TabIndex = 0;
            this.buttonFix.Text = "Fix";
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // groupBoxPicker
            // 
            this.groupBoxPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPicker.Location = new System.Drawing.Point(935, 307);
            this.groupBoxPicker.Name = "groupBoxPicker";
            this.groupBoxPicker.Size = new System.Drawing.Size(145, 317);
            this.groupBoxPicker.TabIndex = 3;
            this.groupBoxPicker.TabStop = false;
            this.groupBoxPicker.Text = "指派";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(62, 20);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(866, 21);
            this.textBoxFileName.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonFontSizeDown);
            this.groupBox2.Controls.Add(this.buttonFontSizeUp);
            this.groupBox2.Location = new System.Drawing.Point(935, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示";
            // 
            // buttonFontSizeDown
            // 
            this.buttonFontSizeDown.Location = new System.Drawing.Point(31, 69);
            this.buttonFontSizeDown.Name = "buttonFontSizeDown";
            this.buttonFontSizeDown.Size = new System.Drawing.Size(75, 23);
            this.buttonFontSizeDown.TabIndex = 1;
            this.buttonFontSizeDown.Text = "字号-";
            this.buttonFontSizeDown.UseVisualStyleBackColor = true;
            this.buttonFontSizeDown.Click += new System.EventHandler(this.buttonFontSizeDown_Click);
            // 
            // buttonFontSizeUp
            // 
            this.buttonFontSizeUp.Location = new System.Drawing.Point(31, 29);
            this.buttonFontSizeUp.Name = "buttonFontSizeUp";
            this.buttonFontSizeUp.Size = new System.Drawing.Size(75, 23);
            this.buttonFontSizeUp.TabIndex = 0;
            this.buttonFontSizeUp.Text = "字号+";
            this.buttonFontSizeUp.UseVisualStyleBackColor = true;
            this.buttonFontSizeUp.Click += new System.EventHandler(this.buttonFontSizeUp_Click);
            // 
            // labelFileCount
            // 
            this.labelFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(1023, 23);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(41, 12);
            this.labelFileCount.TabIndex = 6;
            this.labelFileCount.Text = "label2";
            // 
            // FormFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 636);
            this.Controls.Add(this.labelFileCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.groupBoxPicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDumpContent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFileName";
            this.Text = "Dump文件分发";
            this.Load += new System.EventHandler(this.FormFileName_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDumpContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUnFix;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.GroupBox groupBoxPicker;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFontSizeDown;
        private System.Windows.Forms.Button buttonFontSizeUp;
        private System.Windows.Forms.Label labelFileCount;
    }
}

