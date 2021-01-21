Feature: SpecFlowFeature2
	To perform calculations
	As a user
	I want to be told the Cosinus of a number

@mytag
Scenario: Cosinus of a number
	Given [COS] the first number is 5
	When [COS] the Cosinus calculation is performed
	Then [COS] the result should be 0.28366