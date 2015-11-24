using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim
{
    class Add : Instruction
    {
        private int _rd;
        private int _rs;
        private int _rt;

        private int _op1;
        private int _op2;

        private int _result;

        public Add(string instr, int rd, int rs, int rt) : base(instr)
        {
            this._rd = rd;
            this._rs = rs;
            this._rt = rt;
        }

        public override void Decode()
        {
            this._op1 = RegisterFile.Read(this._rs);
            this._op2 = RegisterFile.Read(this._rt);
        }

        public override void Execute()
        {
            this._result = this._op1 + this._op2;
        }

        public override void MemoryOp() { }

        public override void WriteBack()
        {
            RegisterFile.Write(this._rd, this._result);
        }

        public override string GetDecode()
        {
            return string.Format("Add Instruction: rd => ${0}, rs => ${1}, rt = ${2}", _rd, _rs, _rt);
        }

        public override string GetExecute()
        {
            return string.Format("Add {0} + {1} = {2}", this._op1, this._op2, this._result);
        }

        public override string GetMem()
        {
            return "None";
        }

        public override string GetWB()
        {
            return string.Format("Register ${0} <= {1}", this._rd, this._result);
        }

        public override string GetInstructionType()
        {
            return "Add";
        }
    }
}
