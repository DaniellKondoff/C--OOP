using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Enums_and_Attributes
{
    public static class EnumExtensions
    {
        public static IEnumerable<string> ToStringValues<TEnum>()
        {
            return Enum.GetValues(typeof(TEnum))
                .OfType<TEnum>()
                .Select(c => c.ToString());
        }
    }
}
