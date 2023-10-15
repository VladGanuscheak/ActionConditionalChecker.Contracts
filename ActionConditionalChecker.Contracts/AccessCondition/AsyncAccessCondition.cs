using System;
using System.Threading.Tasks;

namespace ActionConditionalChecker.Contracts.AccessCondition
{
    /// <summary>
    ///     Defines basic access conditions and the asynchronous predicate applied to them.
    /// </summary>
    /// <typeparam name="TRequest">The type of the Request object.</typeparam>
    public class AsyncAccessCondition<TRequest> : BaseAccessCondition<TRequest>
    {
        protected AsyncAccessCondition(
            TRequest request,
            Func<TRequest, Task<bool>> predicate) 
            : base(request)
        {
            Predicate = predicate;
        }

        protected AsyncAccessCondition(
            TRequest request,
            Func<TRequest, Task<bool>> predicate,
            DateTime expiresAtUtc) 
            : base(request, expiresAtUtc)
        {
            Predicate = predicate;
        }

        protected AsyncAccessCondition(
            TRequest request,
            Func<TRequest, Task<bool>> predicate,
            TimeSpan timeSpan) 
            : base(request, timeSpan)
        {
            Predicate = predicate;
        }

        protected AsyncAccessCondition(
            TRequest request,
            Func<TRequest, Task<bool>> predicate, 
            DateTime expiresAtUtc, 
            bool waitTillActionCompletion) 
            : base(request, expiresAtUtc, waitTillActionCompletion)
        {
            Predicate = predicate;
        }

        /// <summary>
        ///     Required. The asynchronous predicate on the Request object.
        /// </summary>
        public Func<TRequest, Task<bool>> Predicate { get; }
    }
}
