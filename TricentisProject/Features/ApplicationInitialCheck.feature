Feature: ApplicationInitialCheck
To validated if the automation setup is running correctly and able to load the application

Scenario: Open the wesite and check the top menu and the content in the home page
	When the user in the is the application
	Then the header in the homepage is 'Welcome to our store'
	Then the following group of icons is displayed
	| icons             |
	| BOOKS             |
	| COMPUTERS         |
	| ELECTRONICS       |
	| APPAREL & SHOES   |
	| DIGITAL DOWNLOADS |
	| JEWELRY           |
	| GIFT CARDS        |

