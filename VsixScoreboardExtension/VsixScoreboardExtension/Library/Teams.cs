using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsixScoreboardExtension
{
    class Teams
    {
        public string Name { get; private set; }
        public string Location { get; set; }
        public string League { get; set; }
        public string Sport { get; set; }

        public Teams(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
