namespace BankaProjesi
{
    partial class frmParaYatirmaCekme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParaYatirmaCekme));
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDurumBil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(213, 42);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(159, 39);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(24, 42);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(159, 38);
            this.txtTutar.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(20, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tutar";
            // 
            // txtDurumBil
            // 
            this.txtDurumBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurumBil.Location = new System.Drawing.Point(24, 135);
            this.txtDurumBil.Margin = new System.Windows.Forms.Padding(4);
            this.txtDurumBil.Multiline = true;
            this.txtDurumBil.Name = "txtDurumBil";
            this.txtDurumBil.Size = new System.Drawing.Size(560, 197);
            this.txtDurumBil.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Durum Bilgisi";
            // 
            // frmParaYatirmaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 346);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDurumBil);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParaYatirmaCekme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDurumBil;
        private System.Windows.Forms.Label label3;
    }
}