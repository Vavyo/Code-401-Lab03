using System;
using Xunit;
using Challenges;

namespace ChallengesTests
{
    public class UnitTest1
    {
        [Fact]
        public void Product_returns_the_product()
        {
            // arrange
            int[] arr = new int[] { 1, 2, 3 };

            // act
            int result = Program.Product(arr);
        }
    }
}
