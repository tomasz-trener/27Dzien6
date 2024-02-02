using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaBazodanowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // nawiazywanie polaczenia z baza 
            SqlCommand command; // przechowywanie polecen SQL 
            SqlDataReader sqlDataReader; // czytanie wyników z bazy

            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            command = new SqlCommand("select * from zawodnicy", connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader();

            ////teraz musimy przeczytac wynik 
            //sqlDataReader.Read(); // czytamy kolejny wiersz 
            //string wynik = (string)sqlDataReader.GetValue(2); // pobierz wartosc z pierwszego wiersza i kolumny o indeksie 2 
            //Console.WriteLine(wynik);

            //sqlDataReader.Read(); // czytamy kolejny wiersz 
            //wynik = (string)sqlDataReader.GetValue(2); // pobierz wartosc z pierwszego wiersza i kolumny o indeksie 2 
            //Console.WriteLine(wynik);

            while (sqlDataReader.Read())
            {
                string wynik = (string)sqlDataReader.GetValue(2) + " " + (string)sqlDataReader.GetValue(3);
                Console.WriteLine(wynik);
            }

            connection.Close();

            Console.ReadKey();

        }
    }
}
