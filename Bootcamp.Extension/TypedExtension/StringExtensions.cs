using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.Extension.TypedExtension
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string p )
        {
            return string.IsNullOrWhiteSpace(p);
        }

        public static bool IsFilled(this string p)
        {
            return !IsEmpty(p);
        }

    }
}
