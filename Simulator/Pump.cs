using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator
{
    public class Pump
    {
        private bool state; //0=pump stopped 1=pump started
        private bool led; //0=pump is available 1=pump is NOT available (currently working)
        private int pumpNumber;

        public Pump()
        {
            state = false;
        }
        public bool State
        {
            get => state;
            set
            {
                state = value;
                if (value)
                    led = true;
                else
                    led = false;
            }
        }

        public int PumpNumber { get => pumpNumber; set => pumpNumber = value; }

        static public List<Pump> GeneratePumpList()
        {
            List<Pump> pumps = new List<Pump>();
            for (int i =1; i <= 4; i++)
            {
                Pump pump = new Pump();
                pump.pumpNumber = i;
                pumps.Add(pump);
            }
            return pumps;
        }
    }
}
