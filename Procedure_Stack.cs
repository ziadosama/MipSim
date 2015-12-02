using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim.CPUComponents
{
    class Procedure_Stack
    {
        private int[] _stack;

        private int _current;

        public Procedure_Stack()
        {
            _stack = new int[4];
            _current = 0;
        }

        public void push (int address)
        {
            _stack[_current] = address;
        }

        public int pop()
        {
            return _stack[_current--];
        }
    }
}
