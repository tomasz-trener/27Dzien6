using P04Zawodnicy.Shared.Domain;
using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06ZawodnicyPDF
{
    public enum TrybOkienka
    {
        Dodwanie,
        Edycja,
        Podglad
    }

    public partial class FrmSzczegoly : Form
    {
        private Zawodnik wyswietlany;
        private readonly FrmStartowy frmStartowy;
        private readonly TrybOkienka trybOkienka;
        private readonly ManagerZawodnikow mz;

        public FrmSzczegoly(FrmStartowy frmStartowy, TrybOkienka trybOkienka, ManagerZawodnikow mz)
        {
            InitializeComponent();
            this.frmStartowy = frmStartowy;
            this.trybOkienka = trybOkienka;
            this.mz = mz;

            if(trybOkienka != TrybOkienka.Edycja)
                btnUsun.Visible = false;

            if(trybOkienka == TrybOkienka.Podglad)
            {
                foreach (Control c in pnlKontrolkiDoEdycji.Controls)
                {
                    if(c is TextBox)
                        ((TextBox)c).ReadOnly = true;
                    if (c is NumericUpDown)
                        ((NumericUpDown)c).ReadOnly = true;
                    if (c is DateTimePicker)
                        ((DateTimePicker)c).Enabled = false;
                }
                btnZapisz.Visible = false;
            }
        }

        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy frmStartowy, TrybOkienka trybOkienka, ManagerZawodnikow mz) : this(frmStartowy, trybOkienka,mz)
        {
          
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;

            wyswietlany = zawodnik;


            
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (trybOkienka == TrybOkienka.Edycja)
            {
                zczytajDaneZKontrolek();
                frmStartowy.Zapisz();    
            }
            else if (trybOkienka== TrybOkienka.Dodwanie)
            {
                wyswietlany = new Zawodnik();
                zczytajDaneZKontrolek();
                mz.Dodaj(wyswietlany);
                frmStartowy.Zapisz();
            }


            this.Close();
            frmStartowy.Odswiez();

        }

        private void zczytajDaneZKontrolek()
        {
            wyswietlany.Imie = txtImie.Text;
            wyswietlany.Nazwisko = txtNazwisko.Text;
            wyswietlany.Kraj = txtKraj.Text;
            wyswietlany.DataUrodzenia = dtpDataUr.Value;
            wyswietlany.Waga = Convert.ToInt32(numWaga.Value);
            wyswietlany.Wzrost = Convert.ToInt32(numWaga.Value);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Czy napewno chcesz usunać zawodnika {wyswietlany.ImieNazwisko} ?", "Uusuwanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question );
        
            if( dr == DialogResult.Yes )
            {
                mz.Usun(wyswietlany.Id_zawodnika);
                frmStartowy.Zapisz();
                this.Close();
                frmStartowy.Odswiez();
            }
        }
    }
}
