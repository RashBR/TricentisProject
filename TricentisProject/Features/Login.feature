Feature: Login

Background: 
	Given the user in the is the application

@logoutteardown
Scenario: Login with valid credentials
	Given the user is on login page 
	When the user enters username '123NewUser123@gmail.com' and password 'Testuser1#'
	 And the user clicks on the login button
	Then the user logged in to the account '123NewUser123@gmail.com'

Scenario: Login with invalid credentials
	Given the user is on login page 
	When the user enters username '123@gmail.com' and password 'Testuser1#'
	 And the user clicks on the login button
	Then the user gets a error message as 'The credentials provided are incorrect'
	 
		