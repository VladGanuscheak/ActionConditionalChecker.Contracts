namespace ActionConditionalChecker.Contracts.ActionInfo
{
    public abstract class BaseActionInfo<TRequest>
    {
        public object Lock { get; }

        protected BaseActionInfo(
            object actionLock)
        {
            Lock = actionLock;
        }
    }
}
