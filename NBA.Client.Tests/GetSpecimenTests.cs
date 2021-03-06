using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBA.Client.RequestModels;
using System.Linq;
using System.Threading.Tasks;

namespace NBA.Client.Tests
{
    [TestClass]
    public class GetSpecimenTests
    {
        private INBApi _client;

        public GetSpecimenTests()
        {
            _client = NBAClient.GetClient();
        }

        [TestMethod]
        public async Task GetByScientificName()
        {
            string name = "Urtica dioica";
            var result = await _client.GetSpecimenByScientificName(name);

            Assert.IsTrue(result.TotalSize > 0);
            Assert.IsTrue(result.ResultSet.First().Item.Identifications.Any(x => x.ScientificName.FullScientificName == name));
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
                        Field = "identifications.scientificName.fullScientificName",
                        Operator = Operator.STARTS_WITH,
                         Value = name
                    },
                    new Condition
                    {
                        Field = "identifications.taxonRank",
                        Operator = Operator.EQUALS,
                         Value = "species"
                    }
                },
                LogicalOperator = LogicalOperator.AND
            };
            var result = await _client.GetSpecimen(q);

            Assert.IsTrue(result.TotalSize > 0);
            Assert.IsTrue(result.ResultSet.First().Item.Identifications.Any(x => x.ScientificName.ScientificNameGroup.Equals(name, System.StringComparison.InvariantCultureIgnoreCase)));
        }
    }
}
