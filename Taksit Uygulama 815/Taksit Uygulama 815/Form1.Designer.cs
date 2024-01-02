namespace Taksit_Uygulama_815
{
    partial class Form1
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
            this.lbTaksit = new System.Windows.Forms.ListBox();
            this.lbTarih = new System.Windows.Forms.ListBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.numTaksit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTaksit
            // 
            this.lbTaksit.FormattingEnabled = true;
            this.lbTaksit.Location = new System.Drawing.Point(191, 33);
            this.lbTaksit.Name = "lbTaksit";
            this.lbTaksit.Size = new System.Drawing.Size(109, 225);
            this.lbTaksit.TabIndex = 0;
            // 
            // lbTarih
            // 
            this.lbTarih.FormattingEnabled = true;
            this.lbTarih.Location = new System.Drawing.Point(317, 33);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(138, 225);
            this.lbTarih.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(41, 33);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(41, 86);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(120, 40);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // numTaksit
            // 
            this.numTaksit.Location = new System.Drawing.Point(41, 60);
            this.numTaksit.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numTaksit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTaksit.Name = "numTaksit";
            this.numTaksit.Size = new System.Drawing.Size(120, 20);
            this.numTaksit.TabIndex = 4;
            this.numTaksit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 295);
            this.Controls.Add(this.numTaksit);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.lbTaksit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTaksit;
        private System.Windows.Forms.ListBox lbTarih;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown numTaksit;
    }
}

