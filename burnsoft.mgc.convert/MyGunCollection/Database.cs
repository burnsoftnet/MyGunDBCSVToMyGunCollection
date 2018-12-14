using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace BurnSoft.mgc.convert.MyGunCollection
{
    public class Database
    {
        /// <summary>
        /// The connection
        /// </summary>
        public static OdbcConnection Conn;
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.mgc.convert.MyGunCollection.Database";
        /// <summary>
        /// Gets the MGC password.
        /// </summary>
        /// <value>The MGC password.</value>
        private static string mgcPassword => "";
        /// <summary>
        /// Gets the s connection.
        /// </summary>
        /// <value>The s connection.</value>
        private static string sConnection => String.Format("Driver={Microsoft Access Driver (*.mdb)};dbq={0}\\{1}; Pwd={2}", "APPLICATION_PATH_DATA", "DATABASE_NAME", mgcPassword);
        /// <summary>
        /// Errors the message.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="function">The function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string location, string function, Exception e) => string.Format("ERROR @ {0}.{1} - {2}", location, function, e.Message);
        /// <summary>
        /// Connects the database.
        /// </summary>
        /// <param name="errMsg">The error MSG.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool ConnectDB(out string errMsg)
        {
            bool bAns = false;
            errMsg = @"";
            try
            {
                Conn = new OdbcConnection(sConnection);
                Conn.Open();
                bAns = true;
            }
            catch (Exception e)
            {
                errMsg = ErrorMessage(ClassLocation, "ConnectDB", e);
            }
            return bAns;
        }
    }
}
