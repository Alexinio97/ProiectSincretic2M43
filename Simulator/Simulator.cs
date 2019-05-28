using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Simulator
{
    
    public class Simulator
    {
        // declaring a list of four pumps
        private List<Pump> pumps = Pump.GeneratePumpList();

        //private byte[] _state = new byte[2] { 0x00, 0x00 };
        private float _pressureLevel;
        private readonly float maxpressureLevel;
        // variabila pentru nivelul debitului de scurgere ( cu cat scadem)
        private float drainDebit;
        private float increaseUnit;

        public Simulator()
        {
            _pressureLevel = 0;
            maxpressureLevel = 17;
            drainDebit = 0;
            increaseUnit = 1;
        }
        
        public async Task executeCommandAsync(byte command)
        {
            if(command == 1)
            {
                Console.WriteLine("Pump one deactivating...");
                await Task.Delay(2000);
                increaseUnit--;
                pumps[0].State = false;
               
            }
            if(command == 2)
            {
                Console.WriteLine("Pump two deactivating...");
                await Task.Delay(2000);
                increaseUnit--;
                pumps[1].State = false;
            }
            if (command == 3)
            {
                Console.WriteLine("Pump three deactivating...");
                await Task.Delay(2000);
                increaseUnit--;
                pumps[2].State = false;
            }
            if (command == 4)
            {
                Console.WriteLine("Pump four deactivating...");
                await Task.Delay(2000);
                increaseUnit--;
                pumps[3].State = false;
            }
            if (command == 0) // stop all pumps
            {
                Console.WriteLine("All pumps stopping...");
                foreach (var pump in pumps)
                {
                    pump.State = false;
                    await Task.Delay(2000);
                }         
            }
        }
        
        public async Task StatusPressureLevelAsync()
        {
            // pornim pompele secvential in functie de debitul de golire dat de robinet
            // daca debitul de golire > capacitatea pompelor pornite ? start alta : nu
            // scadem si adunam in acelasi timp in functie de debitul de golire
            // debitul de golire va fii preluat de la user TODO: in ClientProtocol.cs
            
            pumps[0].State = true; //first pump will always be on
            while (true)
            {

                
                if (drainDebit > increaseUnit)
                {
                    foreach (var pump in pumps) //activate a pump in order
                    {
                        if (pump.State.Equals(false))
                        {
                            pump.State = true;
                            Console.WriteLine("Activating pump number - " + pump.PumpNumber);
                            increaseUnit++;   // increase the unit for rising the water
                            await Task.Delay(2000);
                            break;
                        }
                    }
                }
                //if(drainDebit < increaseUnit)
                //{
                //    for(int i =3;i>=0;i--)
                //    {
                //        if(pumps[i].State.Equals(true))
                //        {
                //            pumps[i].State = false;
                //            increaseUnit--;
                //            Console.WriteLine("Deactivating pump number - " + pumps[i].PumpNumber);
                //            await Task.Delay(2000);
                //            break;
                //        }
                //    }
                //}
                _pressureLevel += increaseUnit; //raising water level
                _pressureLevel -= drainDebit;  //draining water
                
                await Task.Delay(1000);
                if (_pressureLevel > maxpressureLevel)
                    _pressureLevel = maxpressureLevel;
            }
        }

        public byte[] getState() //this will return the number of pump activated
        {
            int i = 0;
            byte[] result = new byte[4];
            foreach (var pump in pumps)
            {
                result[i] = byte.Parse(pump.PumpNumber + "" + Convert.ToInt16(pump.State)); // store first number of the pump and the second number is the state
                // of it and it cant be 0 or 1 - on or off
                Console.WriteLine("Pump: " + result[i]);
                i++;
               
            }
            return result;
        }

        public byte[] RaiseDrainLevel()
        {
            
            drainDebit += 1;
            if(drainDebit > 4)
            {
                drainDebit = 4;
            }
            byte[] result = new byte[1];
            result[0] = (byte)drainDebit;
            return result;
        }

        public byte[] LowerDrainLevel()
        {
            
            drainDebit -= 1;
            if (drainDebit < 0)
            {
                drainDebit = 0;
            }

            byte[] result = new byte[1];
            result[0] = (byte)drainDebit;
            return result;
        }

        public byte[] getPressureLevel()
        {
            return new byte[1] { (byte)_pressureLevel };
        }
        
    }
}
