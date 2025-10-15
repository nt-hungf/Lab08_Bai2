using System;
using Xunit;
using ArrayUtils;

namespace ArrayUtils.Tests
{
    public class ArrayHelperTests
    {
        [Fact]
        public void Max_ShouldReturnLargest()
        {
            int[] arr = { 1, 3, 9, 2 };
            Assert.Equal(9, ArrayHelper.Max(arr));
        }

        [Fact]
        public void Min_ShouldReturnSmallest()
        {
            int[] arr = { 1, 3, -5, 2 };
            Assert.Equal(-5, ArrayHelper.Min(arr));
        }

        [Fact]
        public void Max_ThrowsIfEmpty()
        {
            Assert.Throws<ArgumentException>(() => ArrayHelper.Max(Array.Empty<int>()));
        }

        [Fact]
        public void Min_ThrowsIfNull()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.Min(null));
        }
    }
}
