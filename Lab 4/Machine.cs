using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_4
{
    public abstract class Machine : IFunctions
    {
        protected int memory { get; set; }
        protected int maxMemory { get; set; }
        public abstract bool Work();


        public void Start()
        {
            Console.WriteLine("Maquina{0}  se enciende\n", this);
            memory = 0;
        }

        public void Turnoff()
        {
            Console.WriteLine("Maquina{0} se apaga", this);
        }

        public void Restart()
        {
            this.Turnoff();
            this.Start();
        }
    }
}
