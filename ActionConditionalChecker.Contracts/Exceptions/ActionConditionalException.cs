using ActionConditionalChecker.Contracts.AccessCondition;
using System;

namespace ActionConditionalChecker.Contracts.Exceptions
{
    public class ActionConditionalException<TRequest> : Exception
    {
        private readonly BaseAccessCondition<TRequest> _accessCondition;

        public ActionConditionalException(BaseAccessCondition<TRequest> accessCondition)
        {
            _accessCondition = accessCondition;
        }

        public override string Message => ConstructExceptionMessage(_accessCondition);

        public override Exception GetBaseException() => ConstructInnerExceptionDetails(_accessCondition);

        protected virtual string ConstructExceptionMessage(BaseAccessCondition<TRequest> accessCondition) => default;

        protected virtual Exception ConstructInnerExceptionDetails(BaseAccessCondition<TRequest> accessCondition) => default;
    }
}
