using ActionConditionalChecker.Contracts.AccessCondition;
using System;

namespace ActionConditionalChecker.Contracts.ActionInfo
{
    public abstract class ActionInfo<TRequest> : BaseActionInfo<TRequest>
    {
        public Action<TRequest> Action { get; }

        public AccessCondition<TRequest> AccessCondition { get; }

        protected ActionInfo(
            Action<TRequest> action,
            AccessCondition<TRequest> accessCondition,
            object actionLock)
            : base(actionLock)
        {
            Action = action;
            AccessCondition = accessCondition;
        }
    }

    public abstract class ActionInfo<TRequest, TResponse> : BaseActionInfo<TRequest>
    {
        public Func<TRequest, TResponse> Action { get; }

        public AccessCondition<TRequest> AccessCondition { get; }

        protected ActionInfo(
            Func<TRequest, TResponse> action, 
            AccessCondition<TRequest> accessCondition, 
            object actionLock) 
            : base(actionLock)
        {
            Action = action;
            AccessCondition = accessCondition;
        }
    }
}
