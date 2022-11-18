﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents what the prize is for given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Numeric identifier for the place(2 for second place,etc)
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The friendly name for the place(second place,first runner up,etc.)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The fixed amount this place earns or zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of overall take or zero if it is not used.
        /// the percentage is fraction of 1(0.5 for 50%)
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName,string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber,out placeNumberValue);
            PlaceNumber=placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount,out prizeAmountValue);
            PrizeAmount=prizeAmountValue;
          
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage=prizePercentageValue;
        }
    }

}
