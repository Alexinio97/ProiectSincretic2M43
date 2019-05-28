using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpClientServer
{
    class Server
    {
        private readonly int _port;
        private readonly IProtocol _protocol;
        private Simulator.Simulator _simulator;

        public Server(int port, IProtocol protocol)
        {
            _simulator = new Simulator.Simulator();
            _port = port;
            _protocol = protocol;
        }

        public async Task Start()
        {
            var server = new TcpListener(new IPAddress(new byte[] { 0, 0, 0, 0 }), 30000);
            server.Start();
            

            Console.WriteLine("Accepting...");
            var clients = new List<Task>();
            var client = await server.AcceptTcpClientAsync();
            Task.Factory.StartNew(() => _simulator.StatusPressureLevelAsync()); // start automated pump system
            clients.Add(RunWorker(client));

            await Task.WhenAll(clients.ToArray());
        }

        private async Task RunWorker(TcpClient client)
        {
            using (var connectedClient = new Client(client))
            {
                await _protocol.ExecuteCommandAsync(connectedClient, _simulator);
            }
        }
    }
}
