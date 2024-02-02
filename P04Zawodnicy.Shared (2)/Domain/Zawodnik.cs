using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Zawodnicy.Shared.Domain
{
    public class Zawodnik
    {
        public int Id_zawodnika { get; set; }
        public int? Id_trenera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public int Wzrost { get; set; }
        public int Waga { get; set; }

        public string ImieNazwisko => Imie + " " + Nazwisko;

        public static string[] WyswietlaneKolumny { get; set; }   // np: {Imie, Nazwisko, Kraj} 

        public object this[string nazwaWlasciwosci]
        {
            get
            {
                return this.GetType().GetProperty(nazwaWlasciwosci).GetValue(this, null);
            }
            set
            {
                this.GetType().GetProperty(nazwaWlasciwosci).SetValue(this, value, null);
            }
        }

        public string DynamicznaWlasciwosc
        {
            get
            {
                string s = "";
                foreach (var k in WyswietlaneKolumny)
                    s += this[k] + " ";
                
                return s;
            }
        }
    }
}


