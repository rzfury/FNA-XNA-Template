using Microsoft.Xna.Framework;
using System;

namespace RZEngine.Core.Utilities
{
    public class CollisionHelper
    {
        public static bool RectCircleOverlap(Vector2 circlePos, float circleRad, Rectangle rect)
        {
            float xn = MathF.Max(rect.X, MathF.Min(circlePos.X, rect.Width));
            float yn = MathF.Max(rect.Y, MathF.Min(circlePos.Y, rect.Height));

            float distX = xn - circlePos.X;
            float distY = yn - circlePos.Y;

            return (distX * distX + distY * distY) <= circleRad * circleRad;
        }
    }
}
