using System;

namespace RZEngine.Core.Utilities
{
    public static class SeededRandom
    {
        private static Random instance = null;
        public static int CurrentSeed = 0;

        public static int GenerateSeed()
        {
            return new Random().Next(1_000_000, 9_999_999);
        }

        public static int Range(int min, int max)
        {
            if (instance == null)
                instance = new Random(CurrentSeed);

            return instance.Next(min, max);
        }

        public static int Range(int min, int max, int seed)
        {
            return new Random(seed).Next(min, max);
        }

        public static int Range(int min, int max, Random randomInstance)
        {
            return randomInstance.Next(min, max);
        }

        public static int RangeW(int min, int max)
        {
            if (instance == null)
                instance = new Random(CurrentSeed);

            return instance.Next(min, max + 1);
        }

        public static int RangeW(int min, int max, int seed)
        {
            return new Random(seed).Next(min, max + 1);
        }

        public static float Range(float min, float max)
        {
            if (instance == null)
                instance = new Random(CurrentSeed);

            return (float)(instance.NextDouble()) * (max - min) + min;
        }

        public static float Range(float min, float max, int seed)
        {
            return (float)(new Random(seed).NextDouble()) * (max - min) + min;
        }

        public static void Reset()
        {
            instance = null;
        }
    }
}
