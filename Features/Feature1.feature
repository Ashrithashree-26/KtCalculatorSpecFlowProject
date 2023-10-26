Feature: Calculator Operation

working of classic Calculator

@tag1
Scenario: Calculator Operations
	Given i close all instances
	When i open calculator
		And i perform some addition operation
	Then i should get the result
