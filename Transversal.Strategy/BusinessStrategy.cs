using System;

namespace Transversal.Strategy
{
    public class BusinessStrategy : MainStrategy
    {
        public override StateStrategy Execute()
        {
            State = StateStrategy.Execution;

            try
            {
                this.Process();
            }
            catch (Exception ex)
            {
                SetException("Error de Negocio. Por Favor Intente Nuevamente: " + ex);
            }

            return State;
        }

        protected override void Process()
        {
            
        }
    }
}
