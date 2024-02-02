using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Zawodnicy.Shared.Domain
{
    public class Trener
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string PelneImie => $"{Imie} {Nazwisko}";
    }
}
