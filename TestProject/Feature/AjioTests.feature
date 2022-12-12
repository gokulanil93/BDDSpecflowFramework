Feature: Ajio Tests
	Tests to verify the product name and value falls in range

@smokeTest
Scenario: Tests to verify the first product name and value falls in range
	Given user navigates to website and select clothing section 
	When user selects the brand of product
	Then user selects the "2" product 
	And verify the product name is "AAZING LONDON" and price ranges between "400" and "2000"

	@smokeTest
Scenario: Tests to verify the Third product name and value falls in range
	Given user navigates to website and select clothing section 
	When user selects the brand of product
	Then user selects the "3" product 
	And verify the product name is "AAZING LONDON" and price ranges between "400" and "2000"
	