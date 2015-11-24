using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim
{
    abstract class Instruction
    {
        protected string _instrString;
        protected int _relativeClock;

        public int RelativeClock
        {
            get { return _relativeClock; }
        }

        public Instruction(string instr)
        {
            this._instrString = instr;
            this._relativeClock = 0;
        }

        public void AdvanceClock()
        {
            switch(++this._relativeClock)
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
            return _instrString;
        }

        public abstract string GetDecode();

        public abstract string GetExecute();

        public abstract string GetMem();

        public abstract string GetWB();

        public abstract string GetInstructionType();
    }
}
