using System;

namespace ActionConditionalChecker.Contracts.AccessCondition
{
    /// <inheritdoc/>
    public abstract class BaseAccessCondition<TRequest>
    {
        /// <inheritdoc/>
        public TRequest Request { get; }

        /// <inheritdoc/>
        public DateTime? ExpiresAtUtc { get; }

        /// <inheritdoc/>
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
