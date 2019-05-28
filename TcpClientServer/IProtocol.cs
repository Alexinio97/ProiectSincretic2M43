using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TcpClientServer
{
    interface IProtocol
    {
        Task ExecuteCommandAsync(Client client,Simulator.Simulator simulator);
    }
}
