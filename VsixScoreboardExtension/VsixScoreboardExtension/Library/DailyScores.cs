using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsixScoreboardExtension.Library;

namespace VsixScoreboardExtension
{
    class DailyScores
    {
        public DateTime Date = DateTime.Now.Date;
        public string Season { get; set; }
        private List<string> CachedSeasons { get; set; }
        private List<Games> Games { get; set; }
    }
}