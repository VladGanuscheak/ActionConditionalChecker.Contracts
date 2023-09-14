using System;

namespace ActionConditionalChecker.Contracts.AccessCondition
{
    /// <summary>
    ///     Defines basic access conditions and the synchronous predicate applied to them.
    /// </summary>
    /// <typeparam name="TRequest">The type of the Request object.</typeparam>
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

        /// <summary>
        ///     Required. The synchronous predicate on the Request object.
        /// </summary>
        public Func<TRequest, bool> Predicate { get; }
    }
}
