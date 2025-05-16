using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FormEVMotors
{
    public static class DataAccess
    {
        public static class DataBaseConfig
        {
            public static string ConnectionString { get; } = "Server=KYLEPC\\SQLEXPRESS;Database=EvMotors;Trusted_Connection=True;TrustServerCertificate=True;";
        }
    }
}
