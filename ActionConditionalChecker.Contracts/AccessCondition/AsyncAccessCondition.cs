using System;
using System.Threading.Tasks;

namespace ActionConditionalChecker.Contracts.AccessCondition
{
    /// <inheritdoc/>
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

        /// <inheritdoc/>
        public Func<TRequest, Task<bool>> Predicate { get; }
    }
}
