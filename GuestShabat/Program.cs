using GuestShabat.DAL;
using Microsoft.Extensions.Configuration;

namespace GuestShabat
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DBContext dBContext = new DBContext(GetConnString());

            new SeedContext(dBContext).EnsureDataBaseSetup();
            new FormHandler(dBContext).Run();
            Application.Run();
        }

        private static string GetConnString()
        {
            var config = new ConfigurationBuilder()
                        .AddUserSecrets<Program>()
                        .Build();
            string? connectionString = config["connectionString"];
            if (connectionString == null)
                throw new Exception("Cannot read conn striong from secrets");
            return connectionString;
        }
    }
}