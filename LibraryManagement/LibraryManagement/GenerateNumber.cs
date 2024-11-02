using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class GenerateNumber
    {
        int code = 0;
        public GenerateNumber()
        {
            Random random = new Random();
            code = random.Next(1000, 10000);
        }
        public int getValue() { return code; }
    }
}
