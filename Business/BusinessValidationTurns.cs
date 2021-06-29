using Data.Turns;
using System;
using Transversal;
using Transversal.Strategy;

namespace Business.Turns
{
    public class BusinessGenerateTurns : BusinessStrategy
    {
        private GenerateTurnsParameters generateTurns;

        public BusinessGenerateTurns(GenerateTurnsParameters generateTurns)
        {
            this.generateTurns = generateTurns;
        }

        protected override void Process()
        { 
            //Aquí se incluirían las validaciones necesarias.
        
        }
    }
}
