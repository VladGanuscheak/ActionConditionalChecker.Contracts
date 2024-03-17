using ActionConditionalChecker.Contracts.AccessCondition;
using System;

namespace ActionConditionalChecker.Contracts.Exceptions
{
    public class ActionConditionalException<TRequest>(BaseAccessCondition<TRequest> accessCondition) : Exception
    {
        private readonly BaseAccessCondition<TRequest> _accessCondition = accessCondition;

        public override string Message => ConstructExceptionMessage(_accessCondition);

        public override Exception GetBaseException() => ConstructInnerExceptionDetails(_accessCondition);

        protected virtual string ConstructExceptionMessage(BaseAccessCondition<TRequest> accessCondition) => default;

        protected virtual Exception ConstructInnerExceptionDetails(BaseAccessCondition<TRequest> accessCondition) => default;
    }
}
