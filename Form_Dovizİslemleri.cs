using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BankaProjesi
{
    public partial class Form_Dovizİslemleri : Form
    {
        public Form_Dovizİslemleri()
        {
            InitializeComponent();
        }

        private void Form_Dovizİslemleri_Load(object sender, EventArgs e)
        {
            String bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date / Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlisText.Text = dolarAlis;

            string dolarSatis = xmldosya.SelectSingleNode("Tarih_Date / Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarSatisText.Text = dolarSatis;

            string euroAlis = xmldosya.SelectSingleNode("Tarih_Date / Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlisText.Text = euroAlis;

            string euroSatis = xmldosya.SelectSingleNode("Tarih_Date / Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            euroSatisText.Text = euroSatis;

            string frangAlis = xmldosya.SelectSingleNode("Tarih_Date / Currency[@Kod='CHF']/BanknoteBuying").InnerXml;
            frangAlisText.Text = frangAlis;

            string frangSatis = xmldosya.SelectSingleNode("Tarih_Date / Currency[@Kod='CHF']/BanknoteSelling").InnerXml;
            frangSatisText.Text = frangSatis;
        }

        private void btndolarAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = dolarAlisText.Text;
        }

        private void btndolarSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = dolarSatisText.Text;
        }

        private void btneuroAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = euroAlisText.Text;
        }

        private void btneuroSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = euroSatisText.Text;
        }

        private void btnfrangAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = frangAlisText.Text;
        }

        private void btnfrangSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = frangSatisText.Text;
        }
        double kur, miktar, tutar;

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnaEkran frmAnaEkran = new frmAnaEkran();
            frmAnaEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar * kur;
            txtTl.Text = tutar.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = miktar * kur;
            txtTutar.Text = tutar.ToString();
        }

        private void btnBozdurma_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtKalan.Text = kalan.ToString();
        }
    }
}
