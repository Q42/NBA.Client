using NBA.Client.RequestModels;
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
        Task<SpecimenResponse> GetSpecimenByScientificName([Query(Name = "identifications.scientificName.fullScientificName")]string? fullScientificName);

        [Post("specimen/query")]
        Task<SpecimenResponse> GetSpecimen([Body]QuerySpec querySpec);

        [Post("taxon/query")]
        Task<TaxonResponse> GetTaxon([Body]QuerySpec querySpec);

        [Post("multimedia/query")]
        Task<MultimediaResponse> GetMultimedia([Body]QuerySpec querySpec);


    }
}
