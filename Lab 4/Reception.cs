using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
     public class Reception : Machine
    {
        public Reception()
        {
            maxMemory = 16;
            memory = 0;
        }

        public bool Recieve()
        {

            Console.WriteLine("piece recieved\n");
            memory += 4;
            if (memory == maxMemory)
            {
                Console.WriteLine("Reception machine memory full, please Restart");
                return true;
            }
            return false;
        }

        public override bool Work()
        {
            return this.Recieve();
        }
    }

    
}
