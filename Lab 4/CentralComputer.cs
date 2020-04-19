using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_4
{
    public class CentralComputer : IFabric
    {
        private Machine[] machines_S;
        private int shift = 1440;//Valor definido para termino de turno
        private int time;
        public void SetupFabric(Machine[] machines)
	    {
            machines_S = machines;
	    }
        public void StartMachines()
        {
            foreach (Machine machine in machines_S)
            {
                machine.Start();
                Thread.Sleep(1000);
            }
        }
        public void RestartMachine(Machine machine) //Implementacion parte 4 (solo necesite un metodo para lograrlo)
        {
            machine.Restart();
        }
        public void StopFabric()
        {
            
            foreach (Machine machine in machines_S)
            {
                machine.Turnoff();
                Console.WriteLine("\n");
                Thread.Sleep(1000);
            }
        }
        public void StartFabric(string mode)
        {
            if (mode == "1")//Automatic
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
            else if (mode == "2") //Manual
            {
                int select;
                bool check = true;
                time = 0;
                StartMachines();
                while (time != shift)
                {
                    foreach (Machine machine in machines_S)
                    {
                        Thread.Sleep(1000);
                        if (machine.Work())
                        {
                            check = true;
                            while (check)
                            {
                                Console.WriteLine("\nSeleccione la maquina a reiniciar:\n(1)Reception\n(2)Storage\n(3)Assembly\n(4)Verification\n(5)Packaging\n");
                                Int32.TryParse(Console.ReadLine(), out select);
                                if (select >= 1 && select <= 5)
                                {
                                    RestartMachine(machines_S[select - 1]);
                                    if (machines_S[select - 1] != machine)
                                    {
                                        Console.WriteLine("La maquina {0} sigue con la memoria llene, porfavor reiniciarla", machine);
                                    }
                                    else
                                    {
                                        check = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida, reintente:\n");
                                    continue;
                                }


                            }
                            time++;

                        }
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
