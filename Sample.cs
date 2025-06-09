using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    internal class SampleAdd
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.Write("정적 생성자 호출");
        }
    }
}
