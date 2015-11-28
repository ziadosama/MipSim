using MipSim.CPUComponents;

namespace MipSim.Instructions
{
    class Add : Instruction
    {
        private readonly int _rd;
        private readonly int _rs;
        private readonly int _rt;

        private int _op1;
        private int _op2;

        private int _result;

        public Add(string instr, int rd, int rs, int rt) : base(instr)
        {
            _rd = rd;
            _rs = rs;
            _rt = rt;
        }

        public override void Decode()
        {
            _op1 = RegisterFile.Read(_rs);
            _op2 = RegisterFile.Read(_rt);
        }

        public override void Execute()
        {
            _result = _op1 + _op2;
        }

        public override void MemoryOp()
        {
        }

        public override void WriteBack()
        {
            RegisterFile.Write(_rd, _result);
        }

        public override string GetDecode()
        {
            return string.Format("Add Instruction: rd => ${0}, rs => ${1}, rt = ${2}", _rd, _rs, _rt);
        }

        public override string GetExecute()
        {
            return string.Format("Add {0} + {1} = {2}", _op1, _op2, _result);
        }

        public override string GetMem()
        {
            return "None";
        }

        public override string GetWriteback()
        {
            return string.Format("Register ${0} <= {1}", _rd, _result);
        }

        public override string GetInstructionType()
        {
            return "Add";
        }
    }
}
