using System;
using System.Collections.Generic;
using System.Text;

namespace DapperEFCorePerformanceBenchmarks
{
    public static class Constants
    {
        /// <summary>
        /// The connection string is not included in the sample project as, in my setup, it was too unique.
        /// Consequently you will need to set up your own connection to a SQL database and use your own connection string.
        /// </summary>
        public static readonly string SportsConnectionString = "Data Source=name_pc\\SQLEXPRESS;Initial Catalog=DBDapperEFCorePerformanceBench;User ID=**;Password=******;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
