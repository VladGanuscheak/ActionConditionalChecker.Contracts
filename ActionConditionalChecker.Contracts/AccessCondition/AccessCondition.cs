using System;

namespace ActionConditionalChecker.Contracts.AccessCondition
{
    /// <inheritdoc/>
    public class AccessCondition<TRequest> : BaseAccessCondition<TRequest>
    {
        protected AccessCondition(TRequest request, 
            Func<TRequest, bool> predicate) 
            : base(request)
        {
            Predicate = predicate;
        }

        protected AccessCondition(
            TRequest request,
            Func<TRequest, bool> predicate,
            DateTime expiresAtUtc) 
            : base(request, expiresAtUtc)
        {
            Predicate = predicate;
        }

        protected AccessCondition(
            TRequest request,
            Func<TRequest, bool> predicate,
            TimeSpan timeSpan) 
            : base(request, timeSpan)
        {
            Predicate = predicate;
        }

        protected AccessCondition(
            TRequest request,
            Func<TRequest, bool> predicate,
            DateTime expiresAtUtc, 
            bool waitTillActionCompletion) 
            : base(request, expiresAtUtc, waitTillActionCompletion)
        {
            Predicate = predicate;
        }

        /// <inheritdoc/>
        public Func<TRequest, bool> Predicate { get; }
    }
}
