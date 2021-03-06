﻿namespace MipSim.Instructions
{
    class ReturnProcedure : Instruction
    {
        public ReturnProcedure(string instr, int instructionNumber)
            : base (instr, instructionNumber)
        {
            JumpData = new JumpData { Type = JumpType.Jump, IsJumpTaken = false };
        }

        public override void Decode()
        {
            JumpData.Address = CPU.StackPop();
            JumpData.IsJumpTaken = true;
        }

        public override bool Execute()
        {
            return true;
        }

        public override void MemoryOp()
        {
        }

        public override void WriteBack()
        {
        }

        public override string GetDecode()
        {
            return string.Format("RP Instruction: Address => {0}", JumpData.Address);
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
    }
}
