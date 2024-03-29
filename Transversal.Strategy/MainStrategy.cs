﻿using System;
using System.Text;
using Transversal.Exceptions;

namespace Transversal.Strategy
{
    public abstract class MainStrategy
    {
        private Object result = null;
        private StringBuilder validations = new StringBuilder();

        public abstract StateStrategy Execute();

        protected abstract void Process();

        public StateStrategy State { get; set; }

        public Object Result
        {
            get
            {
                return this.result;
            }
        }

        public void SetResult(object result)
        {
            this.result = result;
            this.State = StateStrategy.Success;
        }

        public void SetValidation(string message)
        {
            this.validations.AppendLine(message);
            this.State = StateStrategy.Validation;
        }

        public string GetValidation()
        {
            return this.validations.ToString();
        }

        public void SetException(string message)
        {
            this.validations.AppendLine(message);
            this.State = StateStrategy.Exception;
        }

        public Exception GetException()
        {
            if (this.State == StateStrategy.Exception)
            {
                return new TurnException(this.validations.ToString());
            }
            else
            {
                return new TurnExceptionValidation(this.validations.ToString());
            }
        }
    }
}
