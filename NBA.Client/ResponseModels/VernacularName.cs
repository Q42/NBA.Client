using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.ResponseModels
{
    public class VernacularName
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public bool? Preferred { get; set; }
    }
}
