using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

namespace BankaProjesi
{
    public partial class Form_Excel : Form
    {
        public Form_Excel()
        {
            InitializeComponent();
        }



        DataTableCollection tableCollection;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog() {  Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"})
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbmTablo.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbmTablo.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cbmTablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbmTablo.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnaEkran frmAnaEkran = new frmAnaEkran();
            frmAnaEkran.Show();
            this.Hide();
        }
    }  
    }

