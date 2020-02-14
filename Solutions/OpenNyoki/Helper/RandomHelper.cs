using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OpenNyoki.Helper
{
    public static class RandomHelper
    {
        public static int GetInt(int rangeMin, int rangeMax)
        {
            return new Random().Next(rangeMin, rangeMax);
        }

    }
}
