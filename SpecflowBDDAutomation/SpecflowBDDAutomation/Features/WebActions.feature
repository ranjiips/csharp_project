Feature: WebActions

Feature file to demonstrate the basic web actions

Background: 
	Given I navigate to the url https://www.demoblaze.com/
@tag1
Scenario: Launch and Verify the page	
	When I see the home page loaded with title STORE
	Then I should see the PRODUCT STORE logo
	And I close the browser
