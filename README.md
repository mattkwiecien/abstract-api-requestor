# Abstract API Requestor
A common task in web development is to make requests to external APIs and create business objects from the response data. This is easy enough, until the external API has some version change that may change the definition of the objects it returns. To account for this we create version independent DTOs and use those version independent DTOs to create the business objects for the application. This project utilizes an abstract factory to accomplish this task.

## Overview

* The client can use the `MyRepo` class to get business objects that are populated with data from an external API. 
* When instantiating the repository, a version is provided to the constructor. 
* Based on this version, the repository will instantiate an implementation of an `IApiDtoFactory` and an `IWebClient` which will be responsible for making requests to the external API and creating version independent DTOs based on the API's response.
* The `IApiDtoFactory` and `IWebClient` are provided to an `IRestService` class, which will use the web client to get some response from an API, and then pass that response into the `IApiDtoFactory` which will return the version independent DTO objects. 
* `MyRepo` will then pass these DTO objects into business objects which can be used by the system.

## Adding a new API Version

The benefits of this structure is that if there was ever a V3 of this API (V1 and V2 are mocked), none of the existing code would need to change.  The client would need to create a new `CompanyV3`, `ApiDtoFactoryV3`, `WebClientV3`, and lastly account for this new version in the constructor of the repository (which would also be abstracted in real world projects). 

## Protection from breaking changes

Version 1 of our mock API has an `Address` property that contains the company's entire address.  But in Version 2 the address has been broken into 4 different parts: `StAddress`, `City`, `St`, and `Zip`. 

However, as long as we ensure our `CompanyV2` DTO implements `ICompanyDto`, we are still protected. In this example, we can just make `Address` return the concatenated string of the 4 new properties. Now even though Version 2 of the API changed properties of it's own DTOs, our business object which accepts a DTO won't need to change as we always conform to the version independent DTO interface, and can let each implementation adjust it's details.

## Abstract Factory

This is a good application of an abstract factory because:
* We need some abstract product (The `ICompanyDto`, or any other dto)
* Which may have different version (`CompanyV1`, `CompanyV2`, etc)
* But we also need an abstract creator (`IApiDtoFactory`) 
* As the implementation details of creating `ICompanyDto` objects may change version to version (`ApiDtoFactoryV1`, `ApiDtoFactoryV2`).



