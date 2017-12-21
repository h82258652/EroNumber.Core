using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace EroNumber.Extensions
{
    public static partial class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var type = value.GetType();
            var enumName = Enum.GetName(type, value);
            var displayAttribute = type.GetRuntimeField(enumName)?.GetCustomAttribute<DisplayAttribute>();
            return displayAttribute != null ? displayAttribute.GetName() : enumName;
        }
    }
}