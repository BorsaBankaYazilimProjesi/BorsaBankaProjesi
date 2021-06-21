using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaProjesi
{
    public partial class Form_SatinAlEkrani : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        int miktar;
        void UrunGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-22ULV7P\\SQLEXPRESS;Initial Catalog=BankaProjesi;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM tblUrun", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public Form_SatinAlEkrani()
        {
            InitializeComponent();
        }

        private void Form_SaticiEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaProjesiDataSet5.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter.Fill(this.bankaProjesiDataSet5.tblUrun);
            // TODO: Bu kod satırı 'yazilimYapimiDataSet1.tblUrun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          

        }
        
        private void bttnSatinAl_Click(object sender, EventArgs e)
        {
            
            lblMessage.Text = "";
            
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                miktar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            }
            if (miktar<Convert.ToInt32(txtKilo.Text) || Convert.ToInt32(txtKilo.Text) <= 0)
            {
                MessageBox.Show("Girdiğiniz verilerde bir satış gerçekleştirilememektedir.");
            }
            else
            {
                MessageBox.Show("Satın alma işleminiz başarıyla gerçekleşti.");
            }
            

            
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmAnaEkran frmAnaEkran = new frmAnaEkran();
            frmAnaEkran.Show();
            this.Hide();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMiktar.ReadOnly = true;
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                txtMiktar.Text = Convert.ToString(dataGridView1.Rows[item.RowIndex].Cells["UrunMiktar"].Value);
                break;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtKilo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMiktar.ReadOnly = true;
        }
    }
}
