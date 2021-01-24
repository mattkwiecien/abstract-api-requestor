# abstract-api-requestor
A common task in web development is to make requests to external APIs and create business objects from the response data.

This is easy enough, until the external API has some version change that may change the definition of the objects it returns.  

To account for this we create version independent DTOs and use those version independent DTOs to create the business objects for the application.

This project is practicing using an abstract factory to accomplish this task.

