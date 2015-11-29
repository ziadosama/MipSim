namespace MipSim.CPUComponents
{
    public class ProgramCounter
    {
        private int _counter;

        public int Counter
        {
            get { return _counter >> 2; }
        }

        public ProgramCounter()
        {
            _counter = 0;
        }

        public void Advance(int offset = 1)
        {
            _counter = _counter + (offset << 2);
        }

        public void Jump(int address)
        {
            _counter = (int)(_counter & 0xF0000000) | (address << 2);
        }
    }
}
