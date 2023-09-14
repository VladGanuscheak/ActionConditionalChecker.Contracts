using System;

namespace ActionConditionalChecker.Contracts.AccessCondition
{
    /// <summary>
    ///     Declares the base properties for access condition checking.
    /// </summary>
    /// <typeparam name="TRequest">The type of the Request object.</typeparam>
    public abstract class BaseAccessCondition<TRequest>
    {
        /// <summary>
        ///     Required. The request which has to be executed
        /// </summary>
        public TRequest Request { get; }

        /// <summary>
        ///     Optional. Date time in the UTC format when the lock expires for the same actions on the similar requests
        ///     (the type of request, its predicate and the content of the Request's object all combined form the criteria).
        /// </summary>
        public DateTime? ExpiresAtUtc { get; }

        /// <summary>
        ///     Indicates that the lock on the similar requests will not be erased till the current request is not finished.
        /// </summary>
        public bool WaitTillActionCompletion { get; }

        protected BaseAccessCondition(TRequest request, 
            DateTime expiresAtUtc, 
            bool waitTillActionCompletion)
        {
            Request = request;
            ExpiresAtUtc = expiresAtUtc;
            WaitTillActionCompletion = waitTillActionCompletion;
        }

        protected BaseAccessCondition(TRequest request, DateTime expiresAtUtc)
            : this(request, expiresAtUtc, false)
        {
        }

        protected BaseAccessCondition(TRequest request, TimeSpan timeSpan)
            : this(request, DateTime.UtcNow.Add(timeSpan), false)
        {
        }

        protected BaseAccessCondition(TRequest request)
        {
            Request = request;
            ExpiresAtUtc = null;
            WaitTillActionCompletion = true;
        }
    }
}
