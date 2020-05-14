using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.ResponseModels
{
    public partial class MultimediaResponse
    {
        public long? TotalSize { get; set; }
        public List<MultimediaResultSet> ResultSet { get; set; }
    }

    public partial class MultimediaResultSet
    {
        public double? Score { get; set; }
        public MultimediaItem Item { get; set; }
    }

    public partial class MultimediaItem
    {
        public ItemSourceSystem SourceSystem { get; set; }
        public string SourceSystemId { get; set; }
        public string Id { get; set; }
        public string SourceInstitutionId { get; set; }
        public string SourceId { get; set; }
        public string Owner { get; set; }
        public string LicenseType { get; set; }
        public string License { get; set; }
        public string UnitId { get; set; }
        public string CollectionType { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public List<ServiceAccessPoint> ServiceAccessPoints { get; set; }
        public string AssociatedSpecimenReference { get; set; }
        public bool? MultiMediaPublic { get; set; }
        public string Modified { get; set; }
        public List<string> PhasesOrStages { get; set; }
        public List<GatheringEvent> GatheringEvents { get; set; }
        public List<MultimediaIdentification> Identifications { get; set; }
    }

    public partial class MultimediaIdentification
    {
        public ScientificName ScientificName { get; set; }
        public IdentificationDefaultClassification DefaultClassification { get; set; }
        public List<TaxonomicEnrichment> TaxonomicEnrichments { get; set; }
    }

    public partial class IdentificationDefaultClassification
    {
        public string Genus { get; set; }
        public string SpecificEpithet { get; set; }
    }

    

    public partial class TaxonomicEnrichment
    {
        public List<VernacularName> VernacularNames { get; set; }
        public TaxonomicEnrichmentDefaultClassification DefaultClassification { get; set; }
        public TaxonomicEnrichmentSourceSystem SourceSystem { get; set; }
        public string TaxonId { get; set; }
    }

    public partial class TaxonomicEnrichmentDefaultClassification
    {
        public string Kingdom { get; set; }
        public string Phylum { get; set; }
        public string ClassName { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string SpecificEpithet { get; set; }
    }

    public partial class TaxonomicEnrichmentSourceSystem
    {
        public string Code { get; set; }
    }

    public partial class ServiceAccessPoint
    {
        public Uri AccessUri { get; set; }
        public string Format { get; set; }
        public string Variant { get; set; }
    }

    public partial class ItemSourceSystem
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

}
