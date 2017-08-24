using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class UserName
    {
        public String newMember(String[] existingNames, String newName)
        {
            List<long> existingMachedStrings = new List<long>();
            long ok = 0;

            existingMachedStrings = existingNames
                .Where(x => x.StartsWith(newName) && (x.Length==newName.Length || long.TryParse(x.TrimStart(newName.ToCharArray()), out ok)))
                .Select(x =>
                {
                    if (x.TrimStart(newName.ToCharArray()).Length == 0) return 0;
                    else 
                    {
                        return long.Parse(x.TrimStart(newName.ToCharArray()));
                    }

                })
                .OrderBy(x => x)
                .ToList();

            if (existingMachedStrings.Count ==0)
            {
                return newName;
            }


            return newName;

        }
    }
}
