using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBA.Client.RequestModels;
using System.Linq;
using System.Threading.Tasks;

namespace NBA.Client.Tests
{
    [TestClass]
    public class GetMultimediaTests
    {
        private INBApi _client;

        public GetMultimediaTests()
        {
            _client = NBAClient.GetClient();
        }


        [TestMethod]
        public async Task GetWithQuerySpec()
        {
            string name = "Panthera tigris (Linnaeus, 1758)";
            QuerySpec q = new QuerySpec
            {
                Conditions = new System.Collections.Generic.List<Condition>
                {
                    new Condition
                    {
                        Field = "identifications.scientificName.fullScientificName",
                        Operator = Operator.EQUALS,
                         Value = name
                    }
                },
                LogicalOperator = LogicalOperator.AND
            };
            var result = await _client.GetMultimedia(q);

            Assert.IsTrue(result.TotalSize > 0);
            Assert.IsTrue(result.ResultSet.First().Item.Identifications.Any(x => x.ScientificName.FullScientificName.Equals(name, System.StringComparison.InvariantCultureIgnoreCase)));
        }
    }
}
