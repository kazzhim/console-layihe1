using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    public static class Lists
    {
        internal static List<Group> Groups { get; set; }

        public static class Lists
        {
            public static List<Group> Groups = ListsHelpers.groups;

        }
    }
}
