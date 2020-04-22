using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.ResponseModels
{
    public partial class SpecimenResponse
    {
        public long? TotalSize { get; set; }
        public List<ResultSet> ResultSet { get; set; }
    }

    public partial class ResultSet
    {
        public double? Score { get; set; }
        public Item Item { get; set; }
    }

    public partial class Item
    {
        public SourceSystem SourceSystem { get; set; }
        public string SourceSystemId { get; set; }
        public Uri RecordUri { get; set; }
        public string Id { get; set; }
        public string UnitId { get; set; }
        public Uri UnitGuid { get; set; }
        public string? SourceInstitutionId { get; set; }
        public string? SourceId { get; set; }
        public string? Owner { get; set; }
        public string? LicenseType { get; set; }
        public string? License { get; set; }
        public string? RecordBasis { get; set; }
        public string? CollectionType { get; set; }
        public string Sex { get; set; }
        public string PhaseOrStage { get; set; }
        public long? NumberOfSpecimen { get; set; }
        public bool? ObjectPublic { get; set; }
        public GatheringEvent GatheringEvent { get; set; }
        public string DataGeneralizations { get; set; }
        public string Modified { get; set; }
        public List<Identification> Identifications { get; set; }
        public string KindOfUnit { get; set; }
        public string PreparationType { get; set; }
        public bool? FromCaptivity { get; set; }
        public bool? MultiMediaPublic { get; set; }
        public List<string> Theme { get; set; }
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
        public List<SiteCoordinate> SiteCoordinates { get; set; }
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

    public partial class Identification
    {
        public string? TaxonRank { get; set; }
        public ScientificName ScientificName { get; set; }
        public DefaultClassification DefaultClassification { get; set; }
        public List<VernacularName> VernacularNames { get; set; }
        public bool? Preferred { get; set; }
    }

    public partial class DefaultClassification
    {
        public string Kingdom { get; set; }
        public string? Family { get; set; }
        public string Genus { get; set; }
        public string SpecificEpithet { get; set; }
    }

    public partial class ScientificName
    {
        public string? FullScientificName { get; set; }
        public string GenusOrMonomial { get; set; }
        public string SpecificEpithet { get; set; }
        public string ScientificNameGroup { get; set; }
    }

    public partial class VernacularName
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public bool? Preferred { get; set; }
    }

    public partial class SourceSystem
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }

}
