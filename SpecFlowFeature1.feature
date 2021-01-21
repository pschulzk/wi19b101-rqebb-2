Feature: SpecFlowFeature1
	To perform calculations
	As a user
	I want to be told the Sinus of a number

@mytag
Scenario: Sinus of a number
	Given [SIN] the first number is 5
	When [SIN] the Sinus calculation is performed
	Then [SIN] the result should be -0.95892