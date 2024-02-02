using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P06ParametryzacjaZapytan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imie"); 
            string imie = Console.ReadLine();

            SqlConnection connection; // nawiazywanie polaczenia z baza 
            SqlCommand command; // przechowywanie polecen SQL 
            SqlDataReader sqlDataReader; // czytanie wyników z bazy

            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            // wpisanie w konsoli: 
            //'; DROP TABLE zawodnicy;--
            // jest atakiem sql injection 
            command = new SqlCommand($"select * from zawodnicy where imie = '{imie}'", connection);


            //bezpieczne rozwiazanie: 
            //string bezpiecznySQL = "select * from zawodnicy where imie = @imie";
            //command = new SqlCommand(bezpiecznySQL, connection);
            //command.Parameters.AddWithValue("@imie", imie);

            connection.Open();

            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                string wynik = (string)sqlDataReader.GetValue(2) + " " + (string)sqlDataReader.GetValue(3);
                Console.WriteLine(wynik);
            }

            connection.Close();
        }
    }
}
