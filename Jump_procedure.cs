using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MipSim.Instructions
{
    class Jump_procedure : Instruction
    {
        private JumpData _jumpData;

        public Jump_procedure(string instr, int instructionNumber, int address)
            : base (instr, instructionNumber)
        {
            _jumpData.Type = JumpType.Jump;
            _jumpData.Address = address;
        }

        public override void Decode()
        {
            CPU.StackPush(_jumpData.Address);
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
            return string.Format("JP Instruction: Address => {0}", _jumpData.Address);
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
            return "JP";
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
