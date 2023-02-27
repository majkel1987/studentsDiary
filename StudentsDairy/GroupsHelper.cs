using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDairy
{
    class GroupsHelper
    {
        public static List<Group> GetGroups(string defaultGroup)
        {
            return new List<Group>
            {
            new Group { Id = 0, Name = defaultGroup },
            new Group { Id = 1, Name = "1a" },
            new Group { Id = 2, Name = "1b" },
            new Group { Id = 3, Name = "2a" },
            new Group { Id = 4, Name = "2b" },
            new Group { Id = 5, Name = "3a" },
            new Group { Id = 6, Name = "3b" }
            };
            
        }
    }
}
