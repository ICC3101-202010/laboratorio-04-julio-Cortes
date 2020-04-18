using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Storage:Machine
    {
        public Storage()
        {
            maxMemory = 200;
            memory = 0;
        }
        public bool Store()
        {

            Console.WriteLine("Piece Stored\n");
            memory+=20;
            if (memory == maxMemory)
            {
                Console.WriteLine("Reception machine memory full, please Restart");
                return true;
            }
            return false;

        }

        public override bool Work()
        {
            return this.Store();
        }
    }
}
