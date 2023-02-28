using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AutomobileLibrary.DataAccess
{
    internal class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; } = null;

        public SqlConnection connection = null;

        public BaseDAL() {
            var connectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connectionString);
        }

        private string GetConnectionString()
        {
            string connectionStrings;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true,true).Build();
            connectionStrings = config["ConnectionStrings:MyStock"];
            return connectionStrings;
        }

        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
