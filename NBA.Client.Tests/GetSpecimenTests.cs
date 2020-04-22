using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var result = await _client.GetSpecimen(name);

            Assert.IsTrue(result.TotalSize > 0);
            Assert.IsTrue(result.ResultSet.First().Item.Identifications.Any(x => x.ScientificName.FullScientificName == name));
        }
    }
}
