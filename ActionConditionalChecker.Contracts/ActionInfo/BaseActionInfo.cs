namespace ActionConditionalChecker.Contracts.ActionInfo
{
    /// <summary>
    ///     Contains base info about the action
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    public abstract class BaseActionInfo<TRequest>
    {
        /// <summary>
        ///     The lock which has to be applied in order to find out if the desired action may be executed
        /// </summary>
        public object Lock { get; }

        protected BaseActionInfo(
            object actionLock)
        {
            Lock = actionLock;
        }
    }
}
