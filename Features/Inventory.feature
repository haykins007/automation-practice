Feature: Inventory

A short summary of the feature

@tag1
Scenario: User can sort products by price low to high
	Given I am logged into the application
    When I sort the products by "Price (low to high)"
    Then the first product price should be "$7.99"

Scenario Outline: User sees correct number of products on inventory page
    Given I am logged into the application
    Then the number of products displayed should be "<ProductCount>"

Examples:
  | ProductCount |
  | 6            |