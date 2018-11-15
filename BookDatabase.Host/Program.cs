using BookDatabase.Services;
using System;
using System.Diagnostics;
using System.ServiceModel;

namespace BookDatabase.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(BookDatabaseService));
                host.Open();
                Console.WriteLine("Hit any key");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
