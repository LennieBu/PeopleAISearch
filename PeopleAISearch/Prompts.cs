using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAISearch
{
    public class Prompts
    {
        public string FindByName(string input, string name)
        {
            return $"{input} Give me a list of every person in the list that has {name} as a name";
        }

        public string FindRecord(string input, object filter) 
        {
            return $"{input} Give me a list of every record in the list that has {filter} as a part of it, sort the list alphabetically";
        }
    }
}
