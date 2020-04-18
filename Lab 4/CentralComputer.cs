using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_4
{
    public static class CentralComputer
    {
        private static Machine[] machines_S;
        private static int shift = 1440;
        private static int time;
        public static void Setupfabric(Machine[] machines)
	    {
            machines_S = machines;
	    }
        public static void StartMachines()
        {
            foreach (Machine machine in machines_S)
            {
                machine.Start();
                Thread.Sleep(1000);
            }
        }
        public static void StopMachines()
        {
            
            foreach (Machine machine in machines_S)
            {
                machine.Turnoff();
                Thread.Sleep(1000);
            }
        }
        public static void Startfabric()
        {

            time = 0;
            StartMachines();
            while (time != shift)
            {
                foreach (Machine machine in machines_S)
                {
                    if (machine.Work())
                    {
                        machine.Restart();
                    }
                    time++;

                }
            }
            StopMachines();

        }


    }
}
