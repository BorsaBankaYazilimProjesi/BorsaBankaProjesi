namespace BankaProjesi
{
    partial class frmHavale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHavale));
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtGondHesNo = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurumBilgisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesBul = new System.Windows.Forms.Button();
            this.txtGondBil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(223, 138);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(167, 41);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtGondHesNo
            // 
            this.txtGondHesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGondHesNo.Location = new System.Drawing.Point(44, 53);
            this.txtGondHesNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGondHesNo.MaxLength = 7;
            this.txtGondHesNo.Multiline = true;
            this.txtGondHesNo.Name = "txtGondHesNo";
            this.txtGondHesNo.Size = new System.Drawing.Size(217, 40);
            this.txtGondHesNo.TabIndex = 0;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(41, 138);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(159, 40);
            this.txtTutar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gönderilecek Hesap Numarası";
            // 
            // txtDurumBilgisi
            // 
            this.txtDurumBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurumBilgisi.Location = new System.Drawing.Point(44, 230);
            this.txtDurumBilgisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDurumBilgisi.Multiline = true;
            this.txtDurumBilgisi.Name = "txtDurumBilgisi";
            this.txtDurumBilgisi.Size = new System.Drawing.Size(648, 144);
            this.txtDurumBilgisi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(40, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Durum Bilgisi";
            // 
            // btnHesBul
            // 
            this.btnHesBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesBul.ForeColor = System.Drawing.Color.White;
            this.btnHesBul.Image = ((System.Drawing.Image)(resources.GetObject("btnHesBul.Image")));
            this.btnHesBul.Location = new System.Drawing.Point(288, 53);
            this.btnHesBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesBul.Name = "btnHesBul";
            this.btnHesBul.Size = new System.Drawing.Size(101, 41);
            this.btnHesBul.TabIndex = 1;
            this.btnHesBul.Text = "BUL";
            this.btnHesBul.UseVisualStyleBackColor = true;
            this.btnHesBul.Click += new System.EventHandler(this.btnHesBul_Click);
            // 
            // txtGondBil
            // 
            this.txtGondBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGondBil.Location = new System.Drawing.Point(435, 53);
            this.txtGondBil.Margin = new System.Windows.Forms.Padding(4);
            this.txtGondBil.Multiline = true;
            this.txtGondBil.Name = "txtGondBil";
            this.txtGondBil.Size = new System.Drawing.Size(257, 144);
            this.txtGondBil.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(431, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gönderilecek Kişinin Bilgileri";
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 393);
            this.Controls.Add(this.btnHesBul);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtGondHesNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGondBil);
            this.Controls.Add(this.txtDurumBilgisi);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHavale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HAVALE EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtGondHesNo;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDurumBilgisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesBul;
        private System.Windows.Forms.TextBox txtGondBil;
        private System.Windows.Forms.Label label4;
    }
}