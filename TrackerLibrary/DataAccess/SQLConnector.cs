﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    // this has a contract to the IDataConnection and this should have all methods of the contract
    public class SQLConnector : IDataConnection
    {
        /// TODO - Make the CreatePrize metod actually  save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The Prize Information.</param>
        /// <returns>The prize information, including unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // throw new NotImplementedException();
            // 4:43:31 database tables
            // model.Id = 1;
            // return model;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                // 6:05 sql saving procedure
            }
            return null;
        }
    }
}
