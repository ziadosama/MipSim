using System;

namespace MipSim.CPUComponents
{
    public class RegisterFile
    {
        private static readonly int[] Registers;

        static RegisterFile()
        {
            Registers = new int[32];
        }

        public static int Read(int register)
        {
            if (register < 0 || register > 31)
                throw new IndexOutOfRangeException();

            return Registers[register];
        }

        public static void Write(int register, int val)
        {
            if (register < 0 || register > 31)
                throw new IndexOutOfRangeException();

            Registers[register] = val;
        }
    }
}
