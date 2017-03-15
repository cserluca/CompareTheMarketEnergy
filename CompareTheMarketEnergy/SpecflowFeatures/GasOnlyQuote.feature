Feature: Quote For Gas Only
As a user of the Compare The Market Energy site
I want to enter supplier, energy and personal details
So that I can get the cheapest price for gas and electricity in my postcode area

Scenario: Gas Only Quote
    Given I am on the your supplier page for a gas only quote
	  And I enter a postcode for a gas only quote
      And I do not have my bill handy for a gas only quote
      And I want to compare price quotes for gas only for a gas only quote
      And I do not know who supplies my gas for a gas only quote
	  And I click next on the your supplier page for a gas only quote
	  And I do not use a prepayment meter for a gas only quote
      And I enter how much I currently spend on gas each month for a gas only quote
	  And I click Next on the your energy page for a gas only quote
	  And I am interested in all tariffs for a gas only quote
      And I am interested in all payment types for a gas only quote
      And I enter my email address for a gas only quote
      And I agree to product and marketing information via email for a gas only quote
      And I have read and understood the website terms and conditions for a gas only quote
     When I click Go to prices for a gas only quote
	 Then I will see the your results page for a gas only quote