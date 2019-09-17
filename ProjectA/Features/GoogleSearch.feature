Feature: GoogleSearch
	So that I can search for Items on Google search 
@mytag
Scenario: Perform a search on google search 
	
	Given user is on Google homepage 
	When user searches for "Selenium Testing" 
	Then correct results are returned 