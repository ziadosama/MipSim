namespace MipSim.Instructions
{
    abstract class Instruction
    {
        protected string InstrString;

        public int RelativeClock { get; private set; }

        protected Instruction(string instr)
        {
            InstrString = instr;
            RelativeClock = 0;
        }

        public void AdvanceClock()
        {
            switch (++RelativeClock)
            {
                case 1:
                    Decode();
                    break;

                case 2:
                    Execute();
                    break;

                case 3:
                    MemoryOp();
                    break;

                case 4:
                    WriteBack();
                    break;
            }
        }

        public abstract void Decode();

        public abstract void Execute();

        public abstract void MemoryOp();

        public abstract void WriteBack();

        public string GetFetch()
        {
            return InstrString;
        }

        public abstract string GetDecode();

        public abstract string GetExecute();

        public abstract string GetMem();

        public abstract string GetWriteback();

        public abstract string GetInstructionType();
    }
}
