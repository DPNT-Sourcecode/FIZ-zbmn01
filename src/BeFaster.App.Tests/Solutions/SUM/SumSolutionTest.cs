using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(1, -1, ExpectedResult = 0)]
        [TestCase(-60, 65, ExpectedResult = 5)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
    }
}

