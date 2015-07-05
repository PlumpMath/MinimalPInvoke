using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MinimalPInvoke {
    class Program {
        [DllImport("clib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int i, int j);

        static void Main(string[] args) {
            Console.WriteLine("test {0}", Add(1, 2));
        }
    }
}
