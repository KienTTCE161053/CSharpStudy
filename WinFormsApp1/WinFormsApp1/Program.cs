using System;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WinFormsApp1
{
    internal static class Program
    {
        static string GetConnection()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("jsconfig1.json", true, true)
                .Build();
            var strConnection = config["ConnectionString:ClickMob"];
            return strConnection;
        }

        static void TestView()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;

            using DbConnection connection =
                factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Can't");
                return;
            }
            connection.ConnectionString = GetConnection();
            connection.Open();
            DbCommand command = factory.CreateCommand();
            if (command == null)
            {
                Console.WriteLine("cmd can't");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select NameMob From ClickMob";

            using DbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine($"Name: {dataReader["NameMob"]}");
            }

        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            TestView();

        }
    }
}
