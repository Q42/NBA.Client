using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.ResponseModels
{
    public partial class SpecimenResponse
    {
        public long? TotalSize { get; set; }
        public List<SpecimenResultSet> ResultSet { get; set; }
    }

    public partial class SpecimenResultSet
    {
        public double? Score { get; set; }
        public SpecimenItem Item { get; set; }
    }

    public partial class SpecimenItem
    {
        public ItemSourceSystem SourceSystem { get; set; }
        public string SourceSystemId { get; set; }
        public string Id { get; set; }
        public string UnitId { get; set; }
        public Uri UnitGuid { get; set; }
        public string? SourceInstitutionId { get; set; }
        public string? SourceId { get; set; }
        public List<string> PreviousSourceId { get; set; }
        public string? Owner { get; set; }
        public string? LicenseType { get; set; }
        public string? License { get; set; }
        public string? RecordBasis { get; set; }
        public string KindOfUnit { get; set; }
        public string? CollectionType { get; set; }
        public Sex? Sex { get; set; }
        public string? PreparationType { get; set; }
        public long? NumberOfSpecimen { get; set; }
        public bool? FromCaptivity { get; set; }
        public bool? ObjectPublic { get; set; }
        public bool? MultiMediaPublic { get; set; }
        public GatheringEvent GatheringEvent { get; set; }
        public string Modified { get; set; }
        public List<Identification> Identifications { get; set; }
        public string? PhaseOrStage { get; set; }
        public List<string> Theme { get; set; }
        public string Title { get; set; }
        public List<AssociatedMultiMediaUris> AssociatedMultiMediaUris { get; set; }
    }

    public enum Sex { Female, Male, Mixed };

    public partial class AssociatedMultiMediaUris
    {
        public Uri AccessUri { get; set; }
        public string Format { get; set; }
        public string Variant { get; set; }
    }

    public partial class GatheringEvent
    {
        public string Continent { get; set; }
        public string? Country { get; set; }
        public string Iso3166Code { get; set; }
        public string ProvinceState { get; set; }
        public string Locality { get; set; }
        public string DateTimeBegin { get; set; }
        public string DateTimeEnd { get; set; }
        public List<SiteCoordinate>? SiteCoordinates { get; set; }
        public List<GatheringPerson>? GatheringPersons { get; set; }
        public string BiotopeText { get; set; }
        public string LocalityText { get; set; }
    }

    public partial class SiteCoordinate
    {
        public double? LongitudeDecimal { get; set; }
        public double? LatitudeDecimal { get; set; }
        public long? CoordinateErrorDistanceInMeters { get; set; }
        public string SpatialDatum { get; set; }
    }

    public partial class GatheringPerson
    {
        public string FullName { get; set; }
    }

    public partial class Identification
    {
        public string? TaxonRank { get; set; }
        public ScientificName? ScientificName { get; set; }
        public DefaultClassification? DefaultClassification { get; set; }
        public List<VernacularName>? VernacularNames { get; set; }
        public bool? Preferred { get; set; }
    }

}
