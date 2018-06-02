using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsixScoreboardExtension
{
    class Team
    {
        public string Name { get; private set; }

        public Team(string name)
        {
            this.Name = name;
        }
    }
}
