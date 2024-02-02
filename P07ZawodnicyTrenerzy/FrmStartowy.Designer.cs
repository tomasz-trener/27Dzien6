namespace P07ZawodnicyTrenerzy
{
    partial class FrmStartowy
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
            this.lblRaport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKraje = new System.Windows.Forms.ComboBox();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnPodglad = new System.Windows.Forms.Button();
            this.btnGenerujPDF = new System.Windows.Forms.Button();
            this.wbPrzegladarka = new System.Windows.Forms.WebBrowser();
            this.clbKolumny = new System.Windows.Forms.CheckedListBox();
            this.btnPokazSreniWiek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(260, 35);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 7;
            this.lblRaport.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kraj";
            // 
            // cbKraje
            // 
            this.cbKraje.FormattingEnabled = true;
            this.cbKraje.Location = new System.Drawing.Point(13, 32);
            this.cbKraje.Name = "cbKraje";
            this.cbKraje.Size = new System.Drawing.Size(241, 21);
            this.cbKraje.TabIndex = 5;
            this.cbKraje.SelectedIndexChanged += new System.EventHandler(this.cbKraje_SelectedIndexChanged);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(13, 59);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(242, 277);
            this.lbDane.TabIndex = 4;
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(261, 91);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 8;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(261, 62);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 9;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnPodglad
            // 
            this.btnPodglad.Location = new System.Drawing.Point(261, 120);
            this.btnPodglad.Name = "btnPodglad";
            this.btnPodglad.Size = new System.Drawing.Size(75, 23);
            this.btnPodglad.TabIndex = 10;
            this.btnPodglad.Text = "Podgląd";
            this.btnPodglad.UseVisualStyleBackColor = true;
            this.btnPodglad.Click += new System.EventHandler(this.btnPodglad_Click);
            // 
            // btnGenerujPDF
            // 
            this.btnGenerujPDF.Location = new System.Drawing.Point(261, 149);
            this.btnGenerujPDF.Name = "btnGenerujPDF";
            this.btnGenerujPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGenerujPDF.TabIndex = 11;
            this.btnGenerujPDF.Text = "Raport PDF";
            this.btnGenerujPDF.UseVisualStyleBackColor = true;
            this.btnGenerujPDF.Click += new System.EventHandler(this.btnGenerujPDF_Click);
            // 
            // wbPrzegladarka
            // 
            this.wbPrzegladarka.Location = new System.Drawing.Point(351, 32);
            this.wbPrzegladarka.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPrzegladarka.Name = "wbPrzegladarka";
            this.wbPrzegladarka.Size = new System.Drawing.Size(256, 304);
            this.wbPrzegladarka.TabIndex = 12;
            // 
            // clbKolumny
            // 
            this.clbKolumny.CheckOnClick = true;
            this.clbKolumny.FormattingEnabled = true;
            this.clbKolumny.Location = new System.Drawing.Point(261, 208);
            this.clbKolumny.Name = "clbKolumny";
            this.clbKolumny.Size = new System.Drawing.Size(75, 124);
            this.clbKolumny.TabIndex = 13;
            this.clbKolumny.SelectedIndexChanged += new System.EventHandler(this.clbKolumny_SelectedIndexChanged);
            // 
            // btnPokazSreniWiek
            // 
            this.btnPokazSreniWiek.Location = new System.Drawing.Point(261, 179);
            this.btnPokazSreniWiek.Name = "btnPokazSreniWiek";
            this.btnPokazSreniWiek.Size = new System.Drawing.Size(75, 23);
            this.btnPokazSreniWiek.TabIndex = 14;
            this.btnPokazSreniWiek.Text = "sr wiek";
            this.btnPokazSreniWiek.UseVisualStyleBackColor = true;
            this.btnPokazSreniWiek.Click += new System.EventHandler(this.btnPokazSreniWiek_Click);
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 352);
            this.Controls.Add(this.btnPokazSreniWiek);
            this.Controls.Add(this.clbKolumny);
            this.Controls.Add(this.wbPrzegladarka);
            this.Controls.Add(this.btnGenerujPDF);
            this.Controls.Add(this.btnPodglad);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKraje);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKraje;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnPodglad;
        private System.Windows.Forms.Button btnGenerujPDF;
        private System.Windows.Forms.WebBrowser wbPrzegladarka;
        private System.Windows.Forms.CheckedListBox clbKolumny;
        private System.Windows.Forms.Button btnPokazSreniWiek;
    }
}

