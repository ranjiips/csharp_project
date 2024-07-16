Feature: ProductStore

Automate the workflow from the application "Product Store" 
and perform the signup, signin, product selection and checkin

Background: 
Given I navigate to the url https://www.demoblaze.com/index.html

@error
Scenario: Signup the user
	When I select the Sign up option from the Navigation Bar
	Then I should see the Sign up popup appear
	When I fill the new username and password and click the Sign up button
		| Username   | Password  |
		| ranji_ips1 | July@2024 |
	Then I should see the Sign up successful. popup message

@negative
Scenario: Signup with Existing user
	When I select the Sign up option from the Navigation Bar
	Then I should see the Sign up popup appear
	When I enter the credentials ranji_ips1 and July@2024
	And I click the Sign up button
	Then I should see the This user already exist. popup message

@positive
Scenario: Signin with Existing user
	When I select the Log in option from the Navigation Bar
	Then I should see the Log in popup appear
	When I enter the credentials ranji_ips1 and July@2024
	And I click the Log in button
	Then I should see the home page with user name ranji_ips1
	When I select the Log out option from the Navigation Bar
	Then I should the user signed out successfully

