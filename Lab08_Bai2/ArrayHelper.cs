using System;

namespace ArrayUtils
{
    public static class ArrayHelper
    {
        public static int Max(int[] arr)
        {
            if (arr == null) throw new ArgumentNullException(nameof(arr));
            if (arr.Length == 0) throw new ArgumentException("Array cannot be empty.");
            int max = arr[0];
            foreach (var n in arr)
                if (n > max) max = n;
            return max;
        }

        public static int Min(int[] arr)
        {
            if (arr == null) throw new ArgumentNullException(nameof(arr));
            if (arr.Length == 0) throw new ArgumentException("Array cannot be empty.");
            int min = arr[0];
            foreach (var n in arr)
                if (n < min) min = n;
            return min;
        }
    }
}
