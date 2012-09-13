Feature: Factorials
	As a maths idiot
	So that I can calculate factorials
	I want to be told the factorial of a given number

Scenario Outline: Calculating a factorial
	Given I have an input of <input>
	When I calculate the factorial of the input
	Then the result should be <result>

	Examples:
	| input | result |
	| 1     | 1      |
	| 2     | 2      |
	| 3     | 6      |
	| 4     | 24     |
	| 5     | 120    |
	| 6     | 720    |
	| 7     | 5040   |