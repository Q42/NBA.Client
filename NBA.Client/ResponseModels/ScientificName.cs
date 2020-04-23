using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.ResponseModels
{
    public class ScientificName
    {
        public string FullScientificName { get; set; }
        public string GenusOrMonomial { get; set; }
        public string SpecificEpithet { get; set; }
        public string AuthorshipVerbatim { get; set; }
        public string ScientificNameGroup { get; set; }

    }
}
