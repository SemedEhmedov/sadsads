using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class PriceMustBeGratherThanZeroException:Exception
    {
        public PriceMustBeGratherThanZeroException()
        {
            Console.WriteLine("malin deyeri menfi ola bilmez");
        }
    }
}
