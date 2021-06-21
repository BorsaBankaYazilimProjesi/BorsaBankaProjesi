
namespace BankaProjesi
{
    partial class Form_SatinAlEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SatinAlEkrani));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaProjesiDataSet5 = new BankaProjesi.BankaProjesiDataSet5();
            this.lblKilo = new System.Windows.Forms.Label();
            this.bttnSatinAl = new System.Windows.Forms.Button();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblUrunTableAdapter = new BankaProjesi.BankaProjesiDataSet5TableAdapters.tblUrunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjesiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunMiktarDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.tblUrunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(612, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // urunMiktarDataGridViewTextBoxColumn
            // 
            this.urunMiktarDataGridViewTextBoxColumn.DataPropertyName = "UrunMiktar";
            this.urunMiktarDataGridViewTextBoxColumn.HeaderText = "UrunMiktar";
            this.urunMiktarDataGridViewTextBoxColumn.Name = "urunMiktarDataGridViewTextBoxColumn";
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "tblUrun";
            this.tblUrunBindingSource.DataSource = this.bankaProjesiDataSet5;
            // 
            // bankaProjesiDataSet5
            // 
            this.bankaProjesiDataSet5.DataSetName = "BankaProjesiDataSet5";
            this.bankaProjesiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKilo.ForeColor = System.Drawing.Color.White;
            this.lblKilo.Image = ((System.Drawing.Image)(resources.GetObject("lblKilo.Image")));
            this.lblKilo.Location = new System.Drawing.Point(704, 60);
            this.lblKilo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(40, 13);
            this.lblKilo.TabIndex = 1;
            this.lblKilo.Text = "KİLO : ";
            // 
            // bttnSatinAl
            // 
            this.bttnSatinAl.BackColor = System.Drawing.Color.Transparent;
            this.bttnSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSatinAl.ForeColor = System.Drawing.Color.Transparent;
            this.bttnSatinAl.Location = new System.Drawing.Point(763, 136);
            this.bttnSatinAl.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSatinAl.Name = "bttnSatinAl";
            this.bttnSatinAl.Size = new System.Drawing.Size(97, 26);
            this.bttnSatinAl.TabIndex = 2;
            this.bttnSatinAl.Text = "SATIN AL";
            this.bttnSatinAl.UseVisualStyleBackColor = false;
            this.bttnSatinAl.Click += new System.EventHandler(this.bttnSatinAl_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(763, 60);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(98, 20);
            this.txtKilo.TabIndex = 3;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiyat.ForeColor = System.Drawing.Color.White;
            this.lblFiyat.Image = ((System.Drawing.Image)(resources.GetObject("lblFiyat.Image")));
            this.lblFiyat.Location = new System.Drawing.Point(688, 104);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(76, 13);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "BİRİM FİYAT :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(763, 102);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(98, 20);
            this.txtMiktar.TabIndex = 5;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Image = ((System.Drawing.Image)(resources.GetObject("btngeri.Image")));
            this.btngeri.Location = new System.Drawing.Point(9, 20);
            this.btngeri.Margin = new System.Windows.Forms.Padding(2);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(84, 24);
            this.btngeri.TabIndex = 6;
            this.btngeri.Text = "Geri Dön";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.ForeColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(738, 190);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // tblUrunTableAdapter
            // 
            this.tblUrunTableAdapter.ClearBeforeFill = true;
            // 
            // Form_SatinAlEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.bttnSatinAl);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_SatinAlEkrani";
            this.Text = "Form_SaticiEkrani";
            this.Load += new System.EventHandler(this.Form_SaticiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjesiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Button bttnSatinAl;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label lblMessage;
        private BankaProjesiDataSet5 bankaProjesiDataSet5;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private BankaProjesiDataSet5TableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}