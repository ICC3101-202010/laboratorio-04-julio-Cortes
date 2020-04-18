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
        private static int shift = 1440;//Valor definido para termino de turno
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
        public static void RestartMachine(Machine machine) //Implementacion parte 4
        {
            machine.Restart();
        }
        public static void StopFabric()
        {
            
            foreach (Machine machine in machines_S)
            {
                machine.Turnoff();
                Console.WriteLine("\n");
                Thread.Sleep(1000);
            }
        }
        public static void Startfabric(string mode)
        {
            if (mode=="1")
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
                        Thread.Sleep(1000);
                        time++;

                    }
                }
                StopFabric();
            }
            else if (mode=="2")
            {
                int select;
                time = 0;
                StartMachines();
                while (time != shift)
                {
                    foreach (Machine machine in machines_S)
                    {
                        if (machine.Work())
                        {
                            Console.WriteLine("\nSeleccione la maquina a reiniciar:\n(1)Reception\n(2)Storage\n(3)Assembly\n(4)Verification\n(5)Packaging\n");
                            Int32.TryParse(Console.ReadLine(),out select);
                            RestartMachine(machines_S[select-1]);
                            while (machines_S[select-1]!=machine)
                            {
                                Console.WriteLine("La maquina {0} sigue atascada, porfavor reiniciar\n",machine);
                                Console.WriteLine("Seleccione la maquina a reiniciar:\n(1)Reception\n(2)Storage\n(3)Assembly\n(4)Verification\n(5)Packaging\n");
                                Int32.TryParse(Console.ReadLine(), out select);
                                RestartMachine(machines_S[select - 1]);
                            }
                            

                        }
                        time++;

                    }
                }
                StopFabric();
            }
            else
            {
                Console.WriteLine("Modo seleccionado invalido");
            }

        }

        


    }
}
