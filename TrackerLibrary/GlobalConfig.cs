using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    // you dont need to call this, its always available to everyone
    public static class GlobalConfig
    {
        // every one can get data but cant change or set
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        //
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create the SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
