Feature: Ajio 
	Tests to verify the product name and value falls in range

@smokeTest
Scenario Outline: verify the first product name and value falls in range
	Given user navigates to website and select clothing section 
	When user selects the brand of product
	Then  verify user selects the <productToBeSelected> product and verify the product name is <productName> and price ranges between <min> and <max>

	Examples: 
        | productToBeSelected | productName   | min | max  |
        | 3                   | AAZING LONDON | 400 | 2000 |
        | 2                   | AAZING LONDON | 400 | 2000 |
		| 4                   | AAZING LONDON | 400 | 2000 |
    