using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBA.Client.RequestModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBA.Client.Tests
{
    [TestClass]
    public class GetTaxonTests
    {
        private INBApi _client;

        public GetTaxonTests()
        {
            _client = NBAClient.GetClient();
        }


        [TestMethod]
        public async Task GetWithQuerySpec()
        {
            string name = "Panthera tigris";
            QuerySpec q = new QuerySpec
            {
                Conditions = new System.Collections.Generic.List<Condition>
                {
                    new Condition
                    {
                        Field = "acceptedName.fullScientificName",
                        Operator = Operator.STARTS_WITH,
                         Value = name
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

            Assert.IsTrue(result.TotalSize > 0);
            Assert.IsTrue(result.ResultSet.First().Item.AcceptedName.ScientificNameGroup.Equals(name, System.StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public async Task GetWithQuerySpecDutchName()
        {
            string name = "merel";
            string scientificName = "Turdus merula Linnaeus, 1758";
            QuerySpec q = new QuerySpec
            {
                Fields = new List<string> { "acceptedName" },
                Conditions = new System.Collections.Generic.List<Condition>
                {
                    new Condition
                    {
                        Field = "vernacularNames.name",
                        Operator = Operator.MATCHES,
                        Value = name
                    },
                },
            };
            var result = await _client.GetTaxon(q);

            Assert.IsTrue(result.TotalSize > 0);
            Assert.IsTrue(result.ResultSet.First().Item.AcceptedName.FullScientificName.Equals(scientificName, System.StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
