# Netherlands Biodiversity API Client
NBA.Client

API Documentation: http://docs.biodiversitydata.nl/en/latest/   
Swagger: https://docs.biodiversitydata.nl/endpoints-reference/

Easily communicate with Naturalis / Netherlands Biodiversity API using C#

## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [NBA.Client on NuGet](https://nuget.org/packages/NBA.Client).

## Example Usage

```cs
QuerySpec q = new QuerySpec
{
    Conditions = new System.Collections.Generic.List<Condition>
    {
        new Condition
        {
            Field = "acceptedName.fullScientificName",
            Operator = Operator.STARTS_WITH,
            Value = "Urtica dioica"
        },
        new Condition
        {
            Field = "taxonRank",
            Operator = Operator.EQUALS,
            Value = "species"
        }
    },
    LogicalOperator = LogicalOperator.AND
};
var result = await _client.GetTaxon(q);
```


## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

### Open Source Project Credits
This library uses RestEase https://github.com/canton7/RestEase
