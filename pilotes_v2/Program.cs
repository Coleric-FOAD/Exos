using System;
using MySqlConnector;

namespace pilotes_v2
{
    class Program
    {
        static string connectionString;

        static MySqlConnection connection; 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            connectionString = "server=localhost;user=root;password=;database=db_pilotes";

            connection = new MySqlConnection(connectionString);

            connection.Open();

            var command = new MySqlCommand("SELECT * FROM pilotes;", connection);

            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                string grade = reader.GetValue(1).ToString();
                string nom = reader.GetValue(2).ToString();

                Console.WriteLine(grade + ": " + nom);
            }




            Console.ReadLine();
        }
    }
}
