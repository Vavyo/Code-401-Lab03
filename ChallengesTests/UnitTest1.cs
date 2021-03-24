using System;
using Xunit;
using Challenges;

namespace ChallengesTests
{
    public class Product
    {
        [Fact]
        public void Product_returns_the_product()
        {
            // arrange
            int[] arr = new int[] { 1, 2, 3 };

            // act
            int result = Program.Product(arr);

            // assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void Product_returns_the_product_with_more_than_3()
        {
            // arrange
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            // act
            int result = Program.Product(arr);

            // assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void Product_returns_0_when_given_less_than_3()
        {
            // arrange
            int[] arr = new int[] { 1, 2 };

            // act
            int result = Program.Product(arr);

            // assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void Product_returns_the_product_with_negatives()
        {
            // arrange
            int[] arr = new int[] { -1, 2, 3 };

            // act
            int result = Program.Product(arr);

            // assert
            Assert.Equal(-6, result);
        }
        public class Average
        {
            [Theory]
            [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, int )]
            [InlineData(new int[] { 1, 2, 3, 4 })]
            [InlineData(new int[] { 1, 2 })]
            public void Average_returns_the_average_for_different_sets_of_nums(int[] arr, int expected)
            {
                // arrange
                int[] arr = new int[] { 1, 2, 3 };

                // act
                int result = Program.Product(arr);

                // assert
                Assert.Equal(6, result);
            }

        }
    }
}
