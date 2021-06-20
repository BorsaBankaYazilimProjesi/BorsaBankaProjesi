namespace BankaProjesi
{
    partial class frmYeniHesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniHesap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusNo = new System.Windows.Forms.TextBox();
            this.btnMusBul = new System.Windows.Forms.Button();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.txtMusBilgileri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Müşteri Numarası";
            // 
            // txtMusNo
            // 
            this.txtMusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusNo.Location = new System.Drawing.Point(28, 50);
            this.txtMusNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusNo.MaxLength = 6;
            this.txtMusNo.Multiline = true;
            this.txtMusNo.Name = "txtMusNo";
            this.txtMusNo.Size = new System.Drawing.Size(252, 38);
            this.txtMusNo.TabIndex = 0;
            // 
            // btnMusBul
            // 
            this.btnMusBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusBul.ForeColor = System.Drawing.Color.White;
            this.btnMusBul.Image = ((System.Drawing.Image)(resources.GetObject("btnMusBul.Image")));
            this.btnMusBul.Location = new System.Drawing.Point(28, 96);
            this.btnMusBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusBul.Name = "btnMusBul";
            this.btnMusBul.Size = new System.Drawing.Size(123, 57);
            this.btnMusBul.TabIndex = 1;
            this.btnMusBul.Text = "BUL";
            this.btnMusBul.UseVisualStyleBackColor = true;
            this.btnMusBul.Click += new System.EventHandler(this.btnMusBul_Click);
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAc.ForeColor = System.Drawing.Color.White;
            this.btnHesapAc.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapAc.Image")));
            this.btnHesapAc.Location = new System.Drawing.Point(159, 96);
            this.btnHesapAc.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(123, 57);
            this.btnHesapAc.TabIndex = 2;
            this.btnHesapAc.Text = "HESAP AÇ";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // txtMusBilgileri
            // 
            this.txtMusBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusBilgileri.Location = new System.Drawing.Point(305, 49);
            this.txtMusBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusBilgileri.Multiline = true;
            this.txtMusBilgileri.Name = "txtMusBilgileri";
            this.txtMusBilgileri.Size = new System.Drawing.Size(377, 102);
            this.txtMusBilgileri.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(301, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.Location = new System.Drawing.Point(163, 106);
            this.lblHesapNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(111, 29);
            this.lblHesapNo.TabIndex = 3;
            this.lblHesapNo.Text = "1234567";
            this.lblHesapNo.Click += new System.EventHandler(this.lblHesapNo_Click);
            // 
            // frmYeniHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 174);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.btnMusBul);
            this.Controls.Add(this.txtMusBilgileri);
            this.Controls.Add(this.txtMusNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHesapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniHesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YENİ HESAP AÇMA EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusNo;
        private System.Windows.Forms.Button btnMusBul;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.TextBox txtMusBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHesapNo;
    }
}