using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReloaded.Domain
{
    public class Feeder
    {
        public string Talk()
        {
            string result = string.Format("Hello world {0}", DateTime.Now);
            return result;
        }
    
    }
}
