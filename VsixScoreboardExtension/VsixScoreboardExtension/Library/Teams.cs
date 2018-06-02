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

        public Teams(string name)
        {
            this.Name = name;
        }
    }
}
