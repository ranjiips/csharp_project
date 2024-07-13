Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecflowBDDAutomation/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	And the test case is "PASSED"

@tag1
Scenario: Working with Tables
	Given I input the following the numbers in the calculator
		| Numbers |
		| 50      |
		| 70      |
	When the two numbers are added
	Then I should see the below details
		| Results | Operator |
		| 120     | plus     |
	And the test case is "PASSED"