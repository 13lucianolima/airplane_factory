using System;
using System.ComponentModel;
using System.Reflection;

namespace AirplaneFactory.Common
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            if (value == null) return null;

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            if (fieldInfo == null) return string.Empty;
            DescriptionAttribute[] attributes =
               (DescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }
            return description;
        }
    }
}
