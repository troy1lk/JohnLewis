Feature: SubHeaderOffers
	In order to view subheader offers links
	As a math user
	I want to be able to click on those

@subheaderoffers
Scenario Outline: Verify Subheader Offers Links 
	Given I navigate to johnlewis 
	And I move the cousor to offers
	When I click on sub <headers>
	Then I see the <headers> page
	Examples: 
	|headers													|
	|Womenswear Offers											|
	|20% off Men's Shoes										|
	|3 year guaranteee on selected Windows laptops over £499	|
	