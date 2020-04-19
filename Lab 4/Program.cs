using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine[] machines = { new Reception(), new Storage(), new Assembly(), new Verification(), new Packaging() };
            string mode;
            CentralComputer centralComputer = new CentralComputer();

            Console.WriteLine("Modo automatico(1)[Parte 2] o Modo manual(2)[Parte 4]");
            mode = Console.ReadLine();
            centralComputer.SetupFabric(machines);
            centralComputer.StartFabric(mode);

        }
    }
}
