using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker.Utils
{
    internal static class MathUtils
    {
        public static Random Random = new Random();

        public static float BoxMuller(float mean, float stddev)
        {
            var u1 = 1.0f - Random.NextDouble();
            var u2 = 1.0f - Random.NextDouble();
            var randStdNormal = (float)Math.Sqrt(-2.0 * Math.Log(u1)) * (float)Math.Sin(2.0 * Math.PI * u2);
            var result = mean + stddev * randStdNormal;

            return result;
        }
    }
}
