using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim.Instructions
{
    class JR : Instruction
    {
        private readonly int _rs;

        private JumpData _jumpData;


        public JR (string instr, int instructionNumber, int rs)
            : base (instr, instructionNumber)
        {
            _rs = rs;
            _jumpData.Type = JumpType.Jump;
        }

        public override void Decode()
        {
            //Jump address is stored in rs register
            _jumpData.Address = CPU.RegRead(_rs);
        }

        public override bool Execute()
        {
            return true; //(?)
        }

        public override void MemoryOp()
        {
            return;
        }

        public override void WriteBack()
        {
            return;
        }

        public override string GetDecode()
        {
            return string.Format("JR Instruction: rs => ${0}", _rs);
        }

        public override string GetExecute()
        {
            return "None";
        }

        public override string GetMem()
        {
            return "None";
        }

        public override string GetWriteback()
        {
            return "None";
        }

        public override string GetInstructionType()
        {
            return "JR";
        }

        public override bool IsJumpTaken()
        {
            return true;
        }

        public override JumpData GetJumpData()
        {
            return _jumpData;
        }

    }
}
