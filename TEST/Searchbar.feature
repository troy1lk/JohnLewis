Feature: Searchbar
	In order to search for an item 
	As a math user
	I want to be able to search for an item using searchbar

@searchbar
Scenario: search for an item
	Given I navigate to johnlewis
	When I search for an item using searchbar
	Then I see the search results
