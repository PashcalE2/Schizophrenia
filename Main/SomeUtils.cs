using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schizophrenia {
    public static class SomeUtils {
        public static bool DoubleEqauals(double d1, double d2, double accuracy) {
            return d1 == d2 || Math.Abs(Math.Abs(d1 / d2) - 1) < accuracy || Math.Abs(d1 - d2) < accuracy;
        }
    }
}
