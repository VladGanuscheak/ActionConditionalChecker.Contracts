using ActionConditionalChecker.Contracts.ActionInfo;
using OperationResult;
using System;
using System.Threading.Tasks;

namespace ActionConditionalChecker.Contracts
{
    public interface IAsyncActionConditionalChecker
    {
        /// <summary>
        ///     Verifies if the request with the corresponding predicate will not be blocked
        /// </summary>
        /// <typeparam name="TRequest">The request type</typeparam>
        /// <param name="accessCondition">Required. Access Condition</param>
        /// <returns>Operation result which contains true or false value or any exception info</returns>
        Task<OperationResult<bool>> CanExecuteAsync<TRequest>(AccessCondition.AsyncAccessCondition<TRequest> accessCondition);

        /// <summary>
        ///     Ensures if the request with the specified predicate can be executed.
        ///     Throws an exception, if the corresponding request cannot be executed.
        /// </summary>
        /// <typeparam name="TRequest">The request type</typeparam>
        /// <param name="accessCondition">Required. Access Condition</param>
        Task EnsureCanExecuteAsync<TRequest>(AccessCondition.AsyncAccessCondition<TRequest> accessCondition);

        /// <summary>
        ///     Executes the request or throws an exception, if the corresponding one is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action.</returns>
        Task<OperationResult<ActionState>> ExecuteOrThrowExceptionAsync<TRequest>(AsyncActionInfo<TRequest> actionInfo);

        /// <summary>
        ///     Executes the request or simply skips it, if the request is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Access info</param>
        /// <returns>Operation result which contains the state of the action.</returns>
        Task<OperationResult<ActionState>> ExecuteOrSkipAsync<TRequest>(AsyncActionInfo<TRequest> actionInfo);

        /// <summary>
        ///     Executes the request.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action.</returns>
        Task<OperationResult<ActionState>> ExecuteAsync<TRequest>(AsyncActionInfo<TRequest> actionInfo);

        /// <summary>
        ///     Executes the request or throws an exception, if the corresponding one is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action and the response to the request</returns>
        Task<OperationResult<Tuple<ActionState, TResponse>>> ExecuteOrThrowExceptionAsync<TRequest, TResponse>(AsyncActionInfo<TRequest, TResponse> actionInfo);

        /// <summary>
        ///     Executes the request or simply skips it, if the request is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Access info</param>
        /// <returns>Operation result which contains the state of the action and the response to the request</returns>
        Task<OperationResult<Tuple<ActionState, TResponse>>> ExecuteOrSkipAsync<TRequest, TResponse>(AsyncActionInfo<TRequest, TResponse> actionInfo);

        /// <summary>
        ///     Executes the request.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action and the response to the request</returns>
        Task<OperationResult<Tuple<ActionState, TResponse>>> ExecuteAsync<TRequest, TResponse>(AsyncActionInfo<TRequest, TResponse> actionInfo);
    }
}
