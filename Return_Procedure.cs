using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim.Instructions
{
    class Return_Procedure : Instruction
    {
        private JumpData _jumpData;
        public Return_Procedure(string instr, int instructionNumber)
            : base (instr, instructionNumber)
        {
        }

        public override void Decode()
        {
            _jumpData.Address = CPU.StackPop();
            _jumpData.Type = JumpType.Jump;
        }

        public override bool Execute()
        {
            return true;
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
            return string.Format("RP Instruction: Address => {0}", _jumpData.Address);
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
            return "RP";
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
