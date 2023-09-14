using ActionConditionalChecker.Contracts.AccessCondition;
using System;
using System.Threading.Tasks;

namespace ActionConditionalChecker.Contracts.ActionInfo
{
    /// <summary>
    ///     Contains information about the current asynchronous action
    /// </summary>
    /// <typeparam name="TRequest">Request type</typeparam>
    public abstract class AsyncActionInfo<TRequest> : BaseActionInfo<TRequest>
    {
        /// <summary>
        ///     The Async Action
        /// </summary>
        public Func<TRequest, Task> Action { get; }

        /// <summary>
        ///     The Predicate
        /// </summary>
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

    /// <summary>
    ///     Contains information about the current asynchronous action
    /// </summary>
    /// <typeparam name="TRequest">Request type</typeparam>
    /// <typeparam name="TResponse">Response type</typeparam>
    public abstract class AsyncActionInfo<TRequest, TResponse> : BaseActionInfo<TRequest>
    {
        /// <summary>
        ///     The async Action
        /// </summary>
        public Func<TRequest, Task<TResponse>> Action { get; }

        /// <summary>
        ///     The async Predicate
        /// </summary>
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
