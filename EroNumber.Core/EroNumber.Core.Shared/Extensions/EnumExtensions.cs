using System;
using System.Linq;

namespace EroNumber.Extensions
{
    public static partial class EnumExtensions
    {
        public static TEnumType[] GetValues<TEnumType>(Func<TEnumType, bool> condition = null)
        {
            var enumValues = Enum.GetValues(typeof(TEnumType)).Cast<TEnumType>();
            if (condition != null)
            {
                enumValues = enumValues.Where(condition);
            }
            return enumValues.ToArray();
        }
    }
}