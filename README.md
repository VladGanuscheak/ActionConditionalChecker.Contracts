# ActionConditionalChecker.Contracts

Defines the contracts for both synchronous and asynchronous condition checkers in order to find out if the action may be executed under specific circumstances. This will help to eliminate idmpotent duplicated requests (the rule also may be aplied for non idempotent ones) and can help to eliminate concurrent issues on accessing a specified resource (in a conditional way).

![General picture](https://raw.githubusercontent.com/VladGanuscheak/ActionConditionalChecker.Contracts/documentation/ActionConditionalCheckerContracts.svg)
