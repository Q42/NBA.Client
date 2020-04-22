using NBA.Client.ResponseModels;
using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Client
{
    public interface INBApi
    {
        [Get("specimen/query")]
        Task<SpecimenResponse> GetSpecimen([Query(Name = "identifications.scientificName.fullScientificName")]string? fullScientificName);
    }
}
