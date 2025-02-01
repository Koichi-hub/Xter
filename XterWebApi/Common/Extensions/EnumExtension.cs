using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace XterWebApi.Common.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumType)
        {
            return enumType.GetType().GetMember(enumType.ToString()).FirstOrDefault()?
                .GetCustomAttribute<DisplayAttribute>()?.GetName() ?? string.Empty;
        }
    }
}
