Feature: Quote For Electricity Only
As a user of the Compare The Market Energy site
I want to enter supplier, energy and personal details
So that I can get the cheapest price for electricity in my postcode area

Scenario: Electricity Only Quote
    Given I am on the your supplier page for an electricity only quote
	  And I enter a postcode for an electricity only quote
      And I do not have my bill handy for an electricity only quote
      And I want to compare price quotes for an electricity only quote
      And I do not know who supplies my electricity for an electricity only quote
	  And I click next on the your supplier page for an electricity only quote
	  And I do not use a prepayment meter for an electricity only quote
	  And I do not have an EconomySeven meter for an electricity only quote
      And I enter how much I currently spend on electricity each month for an electricity only quote
	  And I click Next on the your energy page for an electricity only quote
	  And I am interested in all tariffs for an electricity only quote
      And I am interested in all payment types for an electricity only quote
      And I enter my email address for an electricity only quote
      And I agree to product and marketing information via email for an electricity only quote
      And I have read and understood the website terms and conditions for an electricity only quote
     When I click Go to prices for an electricity only quote
	 Then I will see the your results page for an electricity only quote