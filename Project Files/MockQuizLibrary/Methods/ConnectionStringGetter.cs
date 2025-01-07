using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace MockQuizLibrary.Methods
{
    internal static class ConnectionStringGetter
    {

        /* this method utilizes the System.Configuration.Configuration Manager third-party package; please see the Credits.txt file for 
         * licensing and copyright information in compliance with 
        third-party package license agreements. */

        internal static string GetConnectionString(string databaseName)
        {
            return ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
        }
    }
}
