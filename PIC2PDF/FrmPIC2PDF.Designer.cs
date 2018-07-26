namespace PIC2PDF
{
    partial class FrmPIC2PDF
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDoit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgPICFiles = new System.Windows.Forms.DataGridView();
            this.btnAddPICFiles = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPICFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "图片文件|*.jpg;*.tif;*.png;*.bmp|所有文件|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(593, 60);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(46, 34);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "移上";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(593, 100);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(46, 34);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "移下";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF文件|*.pdf|所有文件|*.*";
            // 
            // btnDoit
            // 
            this.btnDoit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoit.Location = new System.Drawing.Point(593, 311);
            this.btnDoit.Name = "btnDoit";
            this.btnDoit.Size = new System.Drawing.Size(75, 39);
            this.btnDoit.TabIndex = 1;
            this.btnDoit.Text = "转换PDF";
            this.btnDoit.UseVisualStyleBackColor = true;
            this.btnDoit.Click += new System.EventHandler(this.btnDoit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(593, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgPICFiles
            // 
            this.dgPICFiles.AllowUserToAddRows = false;
            this.dgPICFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPICFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPICFiles.Location = new System.Drawing.Point(12, 12);
            this.dgPICFiles.MultiSelect = false;
            this.dgPICFiles.Name = "dgPICFiles";
            this.dgPICFiles.ReadOnly = true;
            this.dgPICFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPICFiles.RowTemplate.Height = 23;
            this.dgPICFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPICFiles.Size = new System.Drawing.Size(565, 473);
            this.dgPICFiles.TabIndex = 3;
            this.dgPICFiles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgPICFiles_DataBindingComplete);
            this.dgPICFiles.Layout += new System.Windows.Forms.LayoutEventHandler(this.dgPICFiles_Layout);
            // 
            // btnAddPICFiles
            // 
            this.btnAddPICFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPICFiles.Location = new System.Drawing.Point(593, 219);
            this.btnAddPICFiles.Name = "btnAddPICFiles";
            this.btnAddPICFiles.Size = new System.Drawing.Size(75, 39);
            this.btnAddPICFiles.TabIndex = 1;
            this.btnAddPICFiles.Text = "添加图片";
            this.btnAddPICFiles.UseVisualStyleBackColor = true;
            this.btnAddPICFiles.Click += new System.EventHandler(this.btnAddPICFiles_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(593, 140);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(46, 34);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // FrmPIC2PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 497);
            this.Controls.Add(this.dgPICFiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPICFiles);
            this.Controls.Add(this.btnDoit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "FrmPIC2PDF";
            this.Text = "图片转换PDF工具";
            this.Load += new System.EventHandler(this.FrmPIC2PDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPICFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDoit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgPICFiles;
        private System.Windows.Forms.Button btnAddPICFiles;
        private System.Windows.Forms.Button btnDel;
    }
}

