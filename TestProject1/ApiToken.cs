using TwistedFizzBuzz;

namespace TestProject1
{
    [TestFixture]
    class ApiToken
    {
        [TestCase]
        public void ApiTokenFizzBuzz()
        {

            var res = GetApiToken.GetToken().Result;

            Assert.IsTrue(true);

            Assert.That(res, Is.TypeOf<Dictionary<int, string>>());

        }
    }
}