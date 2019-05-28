using System;
using System.Threading.Tasks;
namespace TcpClientServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
            Console.ReadLine();
        }

        private static async Task Run()
        {
            try
            {
                Console.WriteLine("Server started");
                var protocol = new ClientProtocol();
                var server = new Server(30000, protocol);
                await server.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server couldn't start.Error message: " + ex.ToString());
            }
        }
    }
}
