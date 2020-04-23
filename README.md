# NBA.Client
Netherlands Biodiversity API Client

API Documentation: http://docs.biodiversitydata.nl/en/latest/   
Swagger: https://docs.biodiversitydata.nl/endpoints-reference/

Easily communicate with Netherlands Biodiversity API using C#

## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [NBA.Client on NuGet](https://nuget.org/packages/NBA.Client).

## Example Usage

```cs
var client = NBAClient.GetClient();

var specimen = await _client.GetSpecimen("Urtica dioica");
```


## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

### Open Source Project Credits
This library uses RestEase https://github.com/canton7/RestEase
