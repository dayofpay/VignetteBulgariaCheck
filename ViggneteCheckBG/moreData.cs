using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViggneteCheckBG
{
    class moreData
    {
        public static string emisions
        {
            get;
            set;
        }
        public static List<string> lastChecked = new List<string>();
        public static string totalChecks { get; set; }
        public static String[] htmlTag = { "<br />" };
    }
}
