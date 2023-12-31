﻿using System;

namespace ActionConditionalChecker.Contracts
{
    public class ActionState
    {
        /// <summary>
        ///     Indicates when the lock above the action will be removed for the similar requests.
        /// </summary>
        public DateTime? ExpiresAtUtc { get; }

        /// <summary>
        ///     Indicates if the similar requests cannot be executed till the current one isn't finished
        /// </summary>
        public bool ShoultWaitTillCompletion { get; }

        /// <summary>
        ///     Verifies if the current request have been completed
        /// </summary>
        public bool Completed => !ShoultWaitTillCompletion && (!ExpiresAtUtc.HasValue || ExpiresAtUtc < DateTime.UtcNow);

        /// <summary>
        ///     Verifies if the corresponding request had to be already expired
        /// </summary>
        public bool Expired => ExpiresAtUtc.HasValue && ExpiresAtUtc < DateTime.UtcNow;

        public ActionState(DateTime? expiresAtUtc, bool shoultWaitTillCompletion)
        {
            ExpiresAtUtc = expiresAtUtc;
            ShoultWaitTillCompletion = shoultWaitTillCompletion;
        }
    }
}
