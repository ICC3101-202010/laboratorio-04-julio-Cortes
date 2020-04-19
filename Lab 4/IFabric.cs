using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    interface IFabric
    {
        void StartMachines();
        void StartFabric(string mode);
        void StopFabric();
        void SetupFabric(Machine[] machines);
        void RestartMachine(Machine machine);
    }
}
