Feature: BWMainHeaders
	In order to view headers
	As a math user
	I want to be able to click on those

@bwmainheaders
Scenario Outline: verify main headers
	Given I navigate to betway essports
	When I click on <headers>
	Then I see the <headers> page
	Examples: 
	| headers        |
	| In-Play        |
	| horse-racing   |
	| Virtual Sports |
