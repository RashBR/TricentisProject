Feature: PaymentWorkflow

A short summary of the feature

Background: 
	Given the user in the is the application
	And the user is on login page 
	And the user enters username '123NewUser123@gmail.com' and password 'Testuser1#'
	And the user clicks on the login button

@tag1
Scenario: Payment workflow
	Given the user in Jewelry page
	 And a jewelry product is selected
	 And the user clicks on ShoppingCart
	 And the user click's on checkout
	 And the user selects In Shop Pickup
	 When the Payment method is selected as Cash on Delivery
	 And the user confirms the order
	 Then the confirmation message is 'Your order has been successfully processed!'
	 And the new order number is created

	
