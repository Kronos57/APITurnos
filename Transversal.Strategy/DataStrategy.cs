using System;
using Transversal.Exceptions;

namespace Transversal.Strategy
{
    public class DataStrategy : MainStrategy
    {
        public override StateStrategy Execute()
        {
            State = StateStrategy.Execution;

            try
            {
                this.Process();
                State = StateStrategy.Success;
            }
            catch (TurnException ex)
            {
                State = StateStrategy.Exception;
                SetException(ex.Message);
            }
            catch (Exception ex)
            {
                State = StateStrategy.Exception;
                SetException("Error de Datos. Por Favor Intente Nuevamente: " + ex);
            }

            return State;
        }

        protected override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
