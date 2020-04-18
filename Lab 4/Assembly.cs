using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Assembly:Machine
    {
        public Assembly()
        {
            maxMemory = 150;
            memory = 0;
        }
        public bool Assemble()
        {
            Console.WriteLine("Piece assembled\n");
            memory += 30;
            if (memory==maxMemory)
            {
                Console.WriteLine("Assembly machine memory full, please Restart");
                return true;
            }
            return false;
        }

        public override bool Work()
        {
            return this.Assemble();
        }
    }
}
