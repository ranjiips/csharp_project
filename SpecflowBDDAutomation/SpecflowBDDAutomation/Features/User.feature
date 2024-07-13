Feature: User

To test the user functionality

@tag1
Scenario: Test Scenario for user data entry
	Given I enter random user data
	When I enter random user data with static email
	And I input dynamic domain for Test@gmail.com email
	And I input dynamic domain for Test@gmail.com email
	And I input dynamic domain for Test@gmail.com email
	And I input dynamic domain for Test@gmail.com email
	Then I get the random user data