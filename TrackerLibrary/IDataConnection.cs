﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    // contract
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
         
    }
}
