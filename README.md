# NBA.Client
Netherlands Biodiversity API Client

API Documentation: https://docs.biodiversitydata.nl/

Easily communicatie with Netherlands Biodiversity API using C#

Donation address: nano_14ezmbmoj5zqzoj7g99bec1rfr7woe1d7bsa87wmsbfpt4u4mnur8183oqtm

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
