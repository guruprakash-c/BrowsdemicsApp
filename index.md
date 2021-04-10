# BrowsdemicsSync v1.0.0

## Let's add some notes for review.

### Software tool to fetch articles from most popular news websites and push to our Browsdemics server.
### ================================== W O R K F L O W ====================================================



```c#
1 - Configuration Management
	i. API/Service Provider Registeration
		i.a. Store access key
	ii. API/Service Endpoints
		ii.a. Input Paramaters
		ii.b. HTTP State(GET,POST, etc.,)
2 - User Management
	i. User Account Registration
		i.a. Once account can be registered with multiple API/Service Providers.
	ii. Authentication & Authorization
3 - Article Management
	i. Each API/Service Provider has a separate window(if all has common parameter names then neglect separate windows, instead use cascading).
		i.a. Select the API/Service Provider
		i.b. Auto-bind Endpoint URL, parameters and HTTP States.
		i.c. Submit
	ii. API/Service Provider Response
		ii.a. Successful response
			ii.a.1. Fetch the response objects from DB and bind to a CheckBox list
			ii.a.2. Manual verification
				ii.a.2.i. Correct the missing/mistakes and change the status of the selected Article.
			ii.a.3. In a new window(Staging Window)
				ii.a.3.i. Push to Browsdemics Server.(**STOP**).	
		ii.b. Failure response 
			ii.b.1. Collect the failed endpoints to a SQL table
			ii.b.2. Manual verification
				ii.b.2.i. Correct the mistakes and restart the service.
	iii. Display elements
		iii.a. API/Service Provider List (all users)
			iii.a.1. Endpoint details only for the Administrator.
		iii.b. User List
		iii.c. Article List 
			iii.c.1. Specific to user account(if the logged in user is administrator then he/she has privilege to view all articles).
```
