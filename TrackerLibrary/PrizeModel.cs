using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// THe numeric identifier for the place (2 for second place, etc.)
        /// </summary>
        public int PrizeNumber { get; set; }

        /// <summary>
        /// The friendly name for the place (second place, first runner up, etc.)
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// The fixed amount this place cares or zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The numnenr that represents this percentage of  overall take or
        /// zero if it is not used. the percentage is a fraction of 1(o.5 for 50%)
        /// </summary>
        public double PrizePercentage { get; set; }


    }
}
