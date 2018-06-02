using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsixScoreboardExtension
{
    class DailyScores
    {
        public DateTime Date = DateTime.Now.Date;
        public string Season { get; set; }
        private List<string> CachedSeasons { get; set; }
    }
}