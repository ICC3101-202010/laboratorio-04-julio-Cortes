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
            CentralComputer.Setupfabric(machines);
            CentralComputer.Startfabric();
        }
    }
}
