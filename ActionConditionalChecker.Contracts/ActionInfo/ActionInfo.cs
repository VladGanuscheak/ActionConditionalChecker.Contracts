using ActionConditionalChecker.Contracts.AccessCondition;
using System;

namespace ActionConditionalChecker.Contracts.ActionInfo
{
    /// <summary>
    ///     Contains information about the current action
    /// </summary>
    /// <typeparam name="TRequest">Request type</typeparam>
    public abstract class ActionInfo<TRequest> : BaseActionInfo<TRequest>
    {
        /// <summary>
        ///     The Action
        /// </summary>
        public Action<TRequest> Action { get; }

        /// <summary>
        ///     The Predicate
        /// </summary>
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

    /// <summary>
    ///     Contains information about the current action
    /// </summary>
    /// <typeparam name="TRequest">Request type</typeparam>
    public abstract class ActionInfo<TRequest, TResponse> : BaseActionInfo<TRequest>
    {
        /// <summary>
        ///     The Action
        /// </summary>
        public Func<TRequest, TResponse> Action { get; }

        /// <summary>
        ///     The Predicate
        /// </summary>
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
