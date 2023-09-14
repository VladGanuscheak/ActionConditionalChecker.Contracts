using ActionConditionalChecker.Contracts.AccessCondition;
using System;
using System.Threading.Tasks;

namespace ActionConditionalChecker.Contracts.ActionInfo
{
    public abstract class AsyncActionInfo<TRequest> : BaseActionInfo<TRequest>
    {
        public Func<TRequest, Task> Action { get; }

        public AsyncAccessCondition<TRequest> AccessCondition { get; }

        protected AsyncActionInfo(
            Func<TRequest, Task> action, 
            AsyncAccessCondition<TRequest> accessCondition,
            object actionLock) 
            : base(actionLock)
        {
            Action = action;
            AccessCondition = accessCondition;
        }
    }

    public abstract class AsyncActionInfo<TRequest, TResponse> : BaseActionInfo<TRequest>
    {
        public Func<TRequest, Task<TResponse>> Action { get; }

        public AsyncAccessCondition<TRequest> AccessCondition { get; }

        protected AsyncActionInfo(
            Func<TRequest, Task<TResponse>> action,
            AsyncAccessCondition<TRequest> accessCondition,
            object actionLock) 
            : base(actionLock)
        {
            Action = action;
            AccessCondition = accessCondition;
        }
    }
}
