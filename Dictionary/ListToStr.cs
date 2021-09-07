using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public static class ListToStr
    {
        private static string ReturnStr(IList<string> list)
        {
            StringBuilder result = new StringBuilder("");
            foreach (var item in list)
            {
                var tmp = list.Last();
                result.Append(item);
                if (item != tmp)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
        public static string _ToString(this IList<string> list)
        {
            return list.Count switch
            {
                0 => null,
                1 => list[0],
                _ => ReturnStr(list)
            };
        }
    }
}