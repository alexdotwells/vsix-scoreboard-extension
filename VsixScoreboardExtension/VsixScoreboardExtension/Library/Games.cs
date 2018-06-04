using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsixScoreboardExtension.Library
{
    class Games
    {
        public Teams HomeTeam { get; set; }
        public Teams AwayTeam { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
    }
}
