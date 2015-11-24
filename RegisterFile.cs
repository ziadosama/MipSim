using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim
{
    public class RegisterFile
    {
        private static int[] _registers;

        static RegisterFile()
        {
            _registers = new int[32];
        }

        public static int Read(int register)
        {
            if (register < 0 || register > 31)
                throw new IndexOutOfRangeException();

            return _registers[register];
        }

        public static void Write(int register, int val)
        {
            if (register < 0 || register > 31)
                throw new IndexOutOfRangeException();

            _registers[register] = val;
        }
    }
}
