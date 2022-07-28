using System;
using System.Collections.Generic;
using System.Linq;
namespace RZEngine.Core.Utilities
{
    public class MathUtil
    {
        public static int Clamp(int val, int min, int max)
        {
            return Math.Max(min, Math.Min(max, val));
        }

        public static float Clamp(float val, float min, float max)
        {
            return MathF.Max(min, MathF.Min(max, val));
        }
    }
}
