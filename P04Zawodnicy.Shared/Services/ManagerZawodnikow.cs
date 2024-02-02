﻿using P02PolaczenieZBaza;
using P04Zawodnicy.Shared.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace P04Zawodnicy.Shared.Services
{
    //ten będzie działać na bazie danych
    public class ManagerZawodnikow
    {
        //private List<Zawodnik> zawodnicyCache;
        //const string url = @"C:\dane\zawodnicy.txt";

         PolaczenieZBaza pzb = new PolaczenieZBaza();

        public Zawodnik[] WczytajZawodnikow()
        {
            object[][] dane = pzb.WyslijPolecenieSQL("select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost,waga from zawodnicy");

            mapujZawodnikow(dane, out Zawodnik[] zawodnicy);
            return zawodnicy;
        }

        public string[] PodajKraje()
        {
            object[][] dane = pzb.WyslijPolecenieSQL("select distinct kraj from zawodnicy");

            string[] kraje = new string[dane.Length];
            for (int i = 0; i < dane.Length; i++)
                kraje[i] = (string)dane[i][0];

            return kraje;
            
        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            object[][] dane = pzb.WyslijPolecenieSQL($"select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost , waga from zawodnicy where kraj='{kraj}'");

            mapujZawodnikow(dane, out Zawodnik[] zawodnicy);
            return zawodnicy;
        }

        public double PodajSredniWzrost(string kraj)
        {
            object[][] dane = pzb.WyslijPolecenieSQL($"select avg(wzrost) from zawodnicy where kraj = '{kraj}'");
            return dane[0][0] == DBNull.Value ? double.NaN : Convert.ToDouble(dane[0][0]);
        }

        public void PosorotujZawodnikowPoNazwisku(Zawodnik[] posortowaniZawodnicy)
        {
            for (int i = 0; i < posortowaniZawodnicy.Length - 1; i++)
            {
                for (int j = 0; j < posortowaniZawodnicy.Length - i - 1; j++)
                {
                    if (string.Compare(posortowaniZawodnicy[j].Nazwisko, posortowaniZawodnicy[j + 1].Nazwisko) > 0)
                    {
                        // zamiana miejscami 
                        Zawodnik temp = posortowaniZawodnicy[j];
                        posortowaniZawodnicy[j] = posortowaniZawodnicy[j + 1];
                        posortowaniZawodnicy[j + 1] = temp;
                    }
                }
            }
        }

        public void Zapisz()
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Zawodnik z)
        {
            string szablon = "insert into zawodnicy (id_trenera,imie, nazwisko,kraj,data_ur,wzrost,waga) values ({0},'{1}','{2}','{3}','{4}',{5},{6})";

            string sql = string.Format(szablon,
                z.Id_trenera == null ? "null" : z.Id_trenera.ToString(),
                z.Imie, z.Nazwisko, z.Kraj, z.DataUrodzenia.ToString("yyyyMMdd"), z.Wzrost, z.Waga);

            pzb.WyslijPolecenieSQL(sql);
        }

        public void Usun(int id)
        {
            pzb.WyslijPolecenieSQL($"delete zawodnicy where id_zawodnika = {id}");
        }

        private void mapujZawodnikow(object[][] dane, out Zawodnik[] zawodnicy)
        {
            zawodnicy = new Zawodnik[dane.Length];
            for (int i = 0; i < dane.Length; i++)
            {
                var w = dane[i]; // i-ty wiersz 
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = (int)w[0];

                if (w[1] != DBNull.Value)
                    z.Id_trenera = (int)w[1];

                z.Imie = (string)w[2];
                z.Nazwisko = (string)w[3];
                z.Kraj = (string)w[4];

                if (w[5] != DBNull.Value)
                    z.DataUrodzenia = (DateTime)w[5];

                if (w[6] != DBNull.Value)
                    z.Wzrost = (int)w[6];

                if (w[7] != DBNull.Value)
                    z.Waga = (int)w[7];

                zawodnicy[i] = z;
            }
        }
    }
}