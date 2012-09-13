Feature: Palindromes
	As a simple string example
	So that I can demonstrate SpecFlow
	I want to know whether a given word is a palindrome

Scenario: Valid palindrome
	Given the input word "redder"
	When I ask whether the input word is a palindrome
	Then I should get the response "Yes"

Scenario: Invalid palindrome
	Given the input word "rudder"
	When I ask whether the input word is a palindrome
	Then I should get the response "No"