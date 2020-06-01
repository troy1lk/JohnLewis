Feature: MainHeaders
	In order to view mainheaders
	As a math user
	I want be able to click on those

@mainheaders
Scenario Outline:verify mainheaders
	Given I navigato to JohnLewis
	When I click on <headers>
	Then I see the <headers> page
	Examples:
	|headers		|
	|offers			|
	|electricals	|
	|gifts			|


