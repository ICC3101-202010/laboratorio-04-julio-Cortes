using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Packaging:Machine 
    {
        public Packaging()
        {
            maxMemory = 70;
            memory = 0;
        }
        public bool Package()
        {
            Console.WriteLine("Piece Packed\n");
            memory += 10;
            if (memory==maxMemory)
            {
                Console.WriteLine("Packaging machine memory full, please Restart");
                return true;    
            }
            return false;
        }

        public override bool Work()
        {
            return this.Package();
        }
    }
}
