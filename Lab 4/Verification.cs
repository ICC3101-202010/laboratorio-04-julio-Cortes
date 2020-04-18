using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Verification:Machine
    {
        public Verification()
        {
            maxMemory = 75;
            memory = 0;
        }
        public bool Verify()
        {
            Console.WriteLine("Piece Verified\n");
            memory += 25;
            if (memory==maxMemory)
            {
                Console.WriteLine("Verification machine memory full, please Restart");
                return true;
            }
            return false;
        }

        public override bool Work()
        {
            return this.Verify();
        }
    }
}
