using P02PolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05KontrolkaDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza pzb;

            if(string.IsNullOrWhiteSpace(txtParametryPolaczenia.Text) )
            {
               var d=  MessageBox.Show("Nie podano parametrów polaczenia. Czy chcesz uzyc domyslnych ?","Pytanie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                    pzb = new PolaczenieZBaza();
                else
                    return;
            }
            else
                pzb = new PolaczenieZBaza(txtParametryPolaczenia.Text);

            if (string.IsNullOrWhiteSpace(txtPolecenieSQL.Text))
            {
                MessageBox.Show("Nie podano polecenia SQL", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                object[][] wynik = pzb.WyslijPolecenieSQL(txtPolecenieSQL.Text);

                dgvDane.Rows.Clear();

                if (wynik.Length > 0)
                {
                    dgvDane.ColumnCount = wynik[0].Length;

                    foreach (var wiersz in wynik)
                        dgvDane.Rows.Add(wiersz);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Błąd bazy danych");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Nieznany bład", "Błąd aplikacji");
            }
            
        }
    }
}
