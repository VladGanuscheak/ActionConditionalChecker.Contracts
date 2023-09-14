using ActionConditionalChecker.Contracts.ActionInfo;
using OperationResult;
using System;

namespace ActionConditionalChecker.Contracts
{
    public interface IActionConditionalChecker
    {
        /// <summary>
        ///     Verifies if the request with the corresponding predicate will not be blocked
        /// </summary>
        /// <typeparam name="TRequest">The request type</typeparam>
        /// <param name="accessCondition">Required. Access Condition</param>
        /// <returns>Operation result which contains true or false value or any exception info</returns>
        OperationResult<bool> CanExecute<TRequest>(AccessCondition.AccessCondition<TRequest> accessCondition);

        /// <summary>
        ///     Ensures if the request with the specified predicate can be executed.
        ///     Throws an exception, if the corresponding request cannot be executed.
        /// </summary>
        /// <typeparam name="TRequest">The request type</typeparam>
        /// <param name="accessCondition">Required. Access Condition</param>
        void EnsureCanExecute<TRequest>(AccessCondition.AccessCondition<TRequest> accessCondition);

        /// <summary>
        ///     Executes the request or throws an exception, if the corresponding one is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action.</returns>
        OperationResult<ActionState> ExecuteOrThrowException<TRequest>(ActionInfo<TRequest> actionInfo);

        /// <summary>
        ///     Executes the request or simply skips it, if the request is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Access info</param>
        /// <returns>Operation result which contains the state of the action.</returns>
        OperationResult<ActionState> ExecuteOrSkip<TRequest>(ActionInfo<TRequest> actionInfo);

        /// <summary>
        ///     Executes the request.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action.</returns>
        OperationResult<ActionState> Execute<TRequest>(ActionInfo<TRequest> actionInfo);


        /// <summary>
        ///     Executes the request or throws an exception, if the corresponding one is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action and the response to the request</returns>
        OperationResult<Tuple<ActionState, TResponse>> ExecuteOrThrowException<TRequest, TResponse>(ActionInfo<TRequest, TResponse> actionInfo);

        /// <summary>
        ///     Executes the request or simply skips it, if the request is blocked.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Access info</param>
        /// <returns>Operation result which contains the state of the action and the response to the request</returns>
        OperationResult<Tuple<ActionState, TResponse>> ExecuteOrSkip<TRequest, TResponse>(ActionInfo<TRequest, TResponse> actionInfo);

        /// <summary>
        ///     Executes the request.
        /// </summary>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="actionInfo">Required. Action info</param>
        /// <returns>Operation result which contains the state of the action and the response to the request</returns>
        OperationResult<Tuple<ActionState, TResponse>> Execute<TRequest, TResponse>(ActionInfo<TRequest, TResponse> actionInfo);
    }
}
