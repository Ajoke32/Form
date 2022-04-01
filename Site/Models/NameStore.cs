using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Site.Models
{
    public class NameStore
    {
        private static List<UserName> storname = new List<UserName>();
        public static IEnumerable<UserName> Storenam
        {
            get
            {
                return storname;
            }
        }
        public static void AddName(UserName name)
        {
            
            storname.Add(name);
        }
    }
}
