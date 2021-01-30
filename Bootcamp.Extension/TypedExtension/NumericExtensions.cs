using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.Extension.TypedExtension
{
    public static class NumericExtensions
    {

        public static bool IsInRange(this int p, int start, int end)
        {
            return p >= start && p <= end;
        }

        public static void ChangeValue(this TestObject obj)
        {
            obj.Id = 9;
            obj.Name = "Kodluyoruz";
        }

        public static int ConvertToCrossRate(this int p)
        {
            // iş kuralları var
            const int crossRate = 7;
            p *= crossRate;
            return p;

        }

    }
}
