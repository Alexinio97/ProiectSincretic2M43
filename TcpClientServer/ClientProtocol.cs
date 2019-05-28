using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TcpClientServer
{
    // in this class we receive the commands from our client and send results back to it
    class ClientProtocol : IProtocol
    {
        // here we should receive and get  the commands sent from client
        public async Task ExecuteCommandAsync(Client client, Simulator.Simulator simulator)
        {
            Console.WriteLine("Receive data from client...");
            byte[] commandFromClient = new byte[1];
            while (commandFromClient[0] != 9)
            {
                commandFromClient = await client.ReceiveAsync(1);
                // check what command we got
                //await menuAsync(simulator, commandFromClient[0],client);

              
                Console.WriteLine("Command received: " + commandFromClient[0]);
                
                await menuAsync(simulator, commandFromClient[0], client);
            }

            Console.WriteLine("Press ENTER to disconnect client");
            Console.ReadLine();
        }

        public static async Task menuAsync(Simulator.Simulator simulator,byte command,Client client)
        {
            // TODO: inca o optiune pentru cresterea si scaderea debitului
            switch (command)
            {
                case 1:
                    await simulator.executeCommandAsync(command); //stops pump one
                    break;
                case 2:
                    await simulator.executeCommandAsync(command); //stops pump 2
                    break;
                case 3:
                    await simulator.executeCommandAsync(command);
                    break;
                case 4:
                    await simulator.executeCommandAsync(command);
                    break;
                case 5:
                    await client.SendAsync(simulator.getState());
                    break;
                case 6:
                    await client.SendAsync(simulator.getPressureLevel()); // sends the pressure level
                    break;
                case 7:
                    Console.WriteLine("Raising draining level.");
                    await client.SendAsync(simulator.RaiseDrainLevel()); //raise drain level with 1 unit
                    break;
                case 8:
                    Console.WriteLine("Lowering draining level.");
                    await client.SendAsync(simulator.LowerDrainLevel()); //raise drain level with 1 unit
                    break;
                case 0:
                    await simulator.executeCommandAsync(command); //stop all pumps
                    break;

                default:
                    Console.WriteLine("Not a valid option.");
                    break;
            }
        }
    }
}
