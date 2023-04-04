#Tags structure: [Base url*] [Application/path*] [Token] [Environment1*] [Env2] [Env3]
#Feature name
Feature: Base working tests

#Example scenario on MX API Status endpoint for GET method, no token needed
@MX-API
Scenario: Get mx API status
	When A GET call is made to /health endpoint
	Then I'll get 200 response

#Example scenario on Liberis API for GET Merchant Profile, with Token and Query Params
@LiberisAPI @GenericLiberisAPI
Scenario: Verify Merchant's preapproval status to Eligible
	Given I set query params
	| param     | value      |
	| Reference | PO00000006 |
	When A GET call is made to /api/Profile/prefund endpoint
	Then I'll get 200 response

# Example scenario on Liberis API for POST method with a generated body
@LiberisAPI @GenericLiberisAPI
Scenario: User login
	Given Login request
	When A POST call is made to /api/Authentication/Auth0 endpoint
	Then I'll get 200 response