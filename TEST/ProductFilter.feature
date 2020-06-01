Feature: ProductFilter
	In order to find a specific product
	As a user
	I want to be able to filter products

@productfilter
Scenario: filter camera products
	Given I navigate to johnlewis
	And I search for cameras
	When I select the filter options
	Then I see the filtered results 
