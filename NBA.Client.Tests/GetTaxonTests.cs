using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBA.Client.RequestModels;
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
    }
}
