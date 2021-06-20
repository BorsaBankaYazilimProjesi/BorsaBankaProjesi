namespace BankaProjesi
{
    partial class frmYeniMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniMusteri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMusTur = new System.Windows.Forms.ComboBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblUyariTCKN = new System.Windows.Forms.Label();
            this.lblUyariTelNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(82, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "T.C. Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(41, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon Numarası";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(45, 181);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(271, 38);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(45, 107);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(271, 38);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(45, 255);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelNo.MaxLength = 10;
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(271, 38);
            this.txtTelNo.TabIndex = 3;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNo_TextChanged);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCKN.Location = new System.Drawing.Point(45, 37);
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCKN.MaxLength = 11;
            this.txtTCKN.Multiline = true;
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(271, 38);
            this.txtTCKN.TabIndex = 0;
            this.txtTCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCKN_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(41, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Müşteri Türü";
            // 
            // cmbMusTur
            // 
            this.cmbMusTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusTur.FormattingEnabled = true;
            this.cmbMusTur.Items.AddRange(new object[] {
            "Bireysel Müşteri",
            "Ticari Müşteri"});
            this.cmbMusTur.Location = new System.Drawing.Point(45, 329);
            this.cmbMusTur.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMusTur.Name = "cmbMusTur";
            this.cmbMusTur.Size = new System.Drawing.Size(271, 37);
            this.cmbMusTur.Sorted = true;
            this.cmbMusTur.TabIndex = 4;
            this.cmbMusTur.Text = "Bireysel - Ticari";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.Location = new System.Drawing.Point(116, 383);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(136, 52);
            this.btnMusteriEkle.TabIndex = 5;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriNo.Location = new System.Drawing.Point(133, 391);
            this.lblMusteriNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(97, 29);
            this.lblMusteriNo.TabIndex = 6;
            this.lblMusteriNo.Text = "123456";
            this.lblMusteriNo.Click += new System.EventHandler(this.lblMusteriNo_Click);
            // 
            // lblUyariTCKN
            // 
            this.lblUyariTCKN.AutoSize = true;
            this.lblUyariTCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyariTCKN.Location = new System.Drawing.Point(327, 33);
            this.lblUyariTCKN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyariTCKN.Name = "lblUyariTCKN";
            this.lblUyariTCKN.Size = new System.Drawing.Size(27, 39);
            this.lblUyariTCKN.TabIndex = 20;
            this.lblUyariTCKN.Text = "!";
            // 
            // lblUyariTelNo
            // 
            this.lblUyariTelNo.AutoSize = true;
            this.lblUyariTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyariTelNo.Location = new System.Drawing.Point(327, 251);
            this.lblUyariTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyariTelNo.Name = "lblUyariTelNo";
            this.lblUyariTelNo.Size = new System.Drawing.Size(27, 39);
            this.lblUyariTelNo.TabIndex = 21;
            this.lblUyariTelNo.Text = "!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-41, -57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 554);
            this.panel2.TabIndex = 51;
            // 
            // frmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 488);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.lblUyariTelNo);
            this.Controls.Add(this.lblUyariTCKN);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.cmbMusTur);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MÜŞTERİ EKLEME EKRANI";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMusTur;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblUyariTCKN;
        private System.Windows.Forms.Label lblUyariTelNo;
        private System.Windows.Forms.Panel panel2;
    }
}