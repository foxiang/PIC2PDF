using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace PIC2PDF
{
    public partial class FrmPIC2PDF : Form
    {
        private DataSetFileName.DataTableFileNameDataTable _pICFileNameDT = new DataSetFileName.DataTableFileNameDataTable();

        public FrmPIC2PDF()
        {
            InitializeComponent();
        }

        #region 控件操作


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void FrmPIC2PDF_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddPICFiles_Click(object sender, EventArgs e)
        {
            string[] tmpfileNameList = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tmpfileNameList = openFileDialog1.FileNames;
                foreach(string fn in tmpfileNameList)
                {
                    _pICFileNameDT.Rows.Add(new string[] { fn });
                }
                
                this.dgPICFiles.DataSource = _pICFileNameDT;
                this.dgPICFiles.Refresh();
            }
        }

        private void dgPICFiles_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void dgPICFiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgPICFiles.ColumnCount > 0)
            {
                this.dgPICFiles.Columns[0].HeaderText = "文件名";
                this.dgPICFiles.Columns[0].FillWeight = 100;
                this.dgPICFiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgPICFiles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dgPICFiles.SelectedRows)
                {
                    dgPICFiles.Rows.Remove(row);
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.dgPICFiles.SelectedRows.Count > 0)
            {
                int topIndex = this.dgPICFiles.SelectedRows[0].Index;
                if (topIndex == 0)
                {
                    return;
                }
                DataSetFileName.DataTableFileNameDataTable tmpDT = new DataSetFileName.DataTableFileNameDataTable();
                foreach (DataGridViewRow dgRow in this.dgPICFiles.SelectedRows)
                {
                    DataSetFileName.DataTableFileNameRow newDataRow = _pICFileNameDT.NewDataTableFileNameRow();
                    newDataRow.ColumnFileName = dgRow.Cells[0].Value.ToString();
                    _pICFileNameDT.Rows.InsertAt(newDataRow, topIndex - 1);
                    dgPICFiles.Rows.Remove(dgRow);
                }
                if (topIndex > 0)
                {
                    this.dgPICFiles.Rows[topIndex - 1].Selected = true; //继续选中
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.dgPICFiles.SelectedRows.Count > 0)
            {
                int bottomIndex = this.dgPICFiles.SelectedRows[0].Index;
                if (bottomIndex == this.dgPICFiles.Rows.Count - 1)
                {
                    return;
                }
                DataSetFileName.DataTableFileNameDataTable tmpDT = new DataSetFileName.DataTableFileNameDataTable();
                foreach (DataGridViewRow dgRow in this.dgPICFiles.SelectedRows)
                {
                    DataSetFileName.DataTableFileNameRow newDataRow = _pICFileNameDT.NewDataTableFileNameRow();
                    newDataRow.ColumnFileName = dgRow.Cells[0].Value.ToString();
                    _pICFileNameDT.Rows.InsertAt(newDataRow, bottomIndex + 2);
                    dgPICFiles.Rows.Remove(dgRow);
                }
                if (bottomIndex < this.dgPICFiles.Rows.Count - 1)
                {
                    this.dgPICFiles.Rows[bottomIndex + 1].Selected = true; //继续选中
                }
            }
        }

        private void btnDoit_Click(object sender, EventArgs e)
        {
            if(_pICFileNameDT.Count==0)
            {
                MessageBox.Show(this, "请先添加要合并的图片文件");
                return;
            }
            string savefileName = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savefileName = saveFileDialog1.FileName;
                string filename = savefileName;
                PdfDocument document = new PdfDocument();

                foreach (DataSetFileName.DataTableFileNameRow dataRow in _pICFileNameDT.Rows)
                {
                    #region image Sample
                   
                    string path = dataRow.ColumnFileName;
                    
                    //// Create an empty page
                    PDFTools PDFImage = new PDFTools(document);
                    PdfPage page = document.AddPage();
                    page.Size = PdfSharp.PageSize.A4;
                    PDFImage.DrawImage(page, path);

                    #endregion
                }

                document.Save(savefileName);

                MessageBox.Show(this, "PDF文件合并成功。存储在：" + savefileName);
                try
                {
                    Process.Start(filename);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
