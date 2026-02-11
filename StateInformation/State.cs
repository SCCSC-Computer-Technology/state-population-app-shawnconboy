using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateInformation
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public string Flag_Description { get; set; }

        public string Flower { get; set; }

        public string Bird { get; set; }

        public string Colors { get; set; }

        public string Three_Largest_Cities { get; set; }

        public string Capitol { get; set; }

        public decimal Median_Income { get; set; }
        public decimal Percent_Tech_Jobs { get; set; }
    }
}
