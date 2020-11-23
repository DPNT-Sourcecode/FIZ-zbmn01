using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    class HelloSolutionTests
    {
        [Test]
        [TestCase("Ian", ExpectedResult = "Hello Ian!")]
        public string TestHello(string friendName)
        {
            return HelloSolution.Hello(friendName);
        }
    }
}

