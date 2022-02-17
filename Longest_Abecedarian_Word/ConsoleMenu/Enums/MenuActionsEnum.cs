using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace InternshipProject.ConsoleMenu.Enums
{
    public static class MenuActionsEnum
    {
        public enum MenuActions
        {
            [Description("FindLongestAbecedarianWord")]
            FindLongestAbecedarianWord = 1,
            [Description("ReverseAndNot")]
            ReverseAndNot,
            [Description("Circle")]
            Circle,
            [Description("Tests")]
            Tests,
            [Description("CloseTask")]
            CloseTask,
            [Description("Exit")]
            Exit
        }

        public static string GetDescription(this Enum genericEnum)
        {
            var genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());

            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if ((attribs != null && attribs.Count() > 0))
                {
                    return ((DescriptionAttribute)attribs.ElementAt(0)).Description;
                }
            }

            return genericEnum.ToString();
        }
    }
}