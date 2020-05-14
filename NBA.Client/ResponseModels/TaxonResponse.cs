using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.ResponseModels
{
    public partial class TaxonResponse
    {
        public long? TotalSize { get; set; }
        public List<TaxonResultSet> ResultSet { get; set; }
    }

    public partial class TaxonResultSet
    {
        public double? Score { get; set; }
        public TaxonItem Item { get; set; }
    }

    public partial class TaxonItem
    {
        public SourceSystem SourceSystem { get; set; }
        public string SourceSystemId { get; set; }
        public Uri RecordUri { get; set; }
        public string Id { get; set; }
        public string TaxonRank { get; set; }
        public AcceptedName AcceptedName { get; set; }
        public DefaultClassification DefaultClassification { get; set; }
        public List<SystemClassification> SystemClassification { get; set; }
        public List<VernacularName> VernacularNames { get; set; }
        public List<Reference> References { get; set; }
        public string SourceSystemParentId { get; set; }
        public string OccurrenceStatusVerbatim { get; set; }
        public List<TaxonDescription> Descriptions { get; set; } = new List<TaxonDescription>();
    }

    public partial class AcceptedName
    {
        public string FullScientificName { get; set; }
        public string TaxonomicStatus { get; set; }
        public string GenusOrMonomial { get; set; }
        public string SpecificEpithet { get; set; }
        public string AuthorshipVerbatim { get; set; }
        public string ScientificNameGroup { get; set; }
    }

    public partial class Reference
    {
        public string CitationDetail { get; set; }
        public Author Author { get; set; }
        public string PublicationDate { get; set; }
    }

    public partial class Author
    {
        public string FullName { get; set; }
    }

   

    public partial class SystemClassification
    {
        public string Rank { get; set; }
        public string Name { get; set; }
    }

    public partial class TaxonDescription
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public List<string> Author { get; set; }
        public string License { get; set; }
        public string PublicationDate { get; set; }
    }

}
