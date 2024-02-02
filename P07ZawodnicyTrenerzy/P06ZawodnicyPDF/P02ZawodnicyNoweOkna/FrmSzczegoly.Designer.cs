namespace P02ZawodnicyNoweOkna
{
    partial class FrmSzczegoly
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataUr = new System.Windows.Forms.DateTimePicker();
            this.numWzrost = new System.Windows.Forms.NumericUpDown();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 26);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(168, 20);
            this.txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(12, 65);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(168, 20);
            this.txtNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Urodzenia";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(12, 106);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(168, 20);
            this.txtKraj.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kraj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Waga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Wzrost";
            // 
            // dtpDataUr
            // 
            this.dtpDataUr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUr.Location = new System.Drawing.Point(12, 146);
            this.dtpDataUr.Name = "dtpDataUr";
            this.dtpDataUr.Size = new System.Drawing.Size(168, 20);
            this.dtpDataUr.TabIndex = 12;
            // 
            // numWzrost
            // 
            this.numWzrost.Location = new System.Drawing.Point(12, 184);
            this.numWzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numWzrost.Name = "numWzrost";
            this.numWzrost.Size = new System.Drawing.Size(165, 20);
            this.numWzrost.TabIndex = 13;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(12, 223);
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(165, 20);
            this.numWaga.TabIndex = 14;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 281);
            this.Controls.Add(this.numWaga);
            this.Controls.Add(this.numWzrost);
            this.Controls.Add(this.dtpDataUr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label1);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataUr;
        private System.Windows.Forms.NumericUpDown numWzrost;
        private System.Windows.Forms.NumericUpDown numWaga;
    }
}