using System;

namespace MipSim.CPUComponents
{
    public class GenericMemory
    {
        private readonly int[] _words;
        private readonly int _size;

        public GenericMemory(int size)
        {
            _size = size;
            _words = new int[_size];
        }

        public int Read(int address)
        {
            if (address < 0 || address >= _size)
                throw new IndexOutOfRangeException();

            return _words[address];
        }

        public void Write(int address, int val)
        {
            if (address < 0 || address >= _size)
                throw new IndexOutOfRangeException();

            _words[address] = val;
        }
    }
}
