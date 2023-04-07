using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject
{
    public class SeleniumSettings
    {
        public string Browser { get; set; } 
        public int? microtimeout { get; set; }
        public int? shorttimeout { get; set; }
        public string Language { get; set; }
    }
}
