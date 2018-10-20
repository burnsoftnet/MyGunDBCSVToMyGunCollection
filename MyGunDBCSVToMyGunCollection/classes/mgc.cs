using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace MyGunDBCSVToMyGunCollection.classes
{
    public class mgc
    {
        public static OdbcConnection Conn;

        private static string ClassLocation = "MyGunDBCSVToMyGunCollection.classes.mgc";
        private static string mgcPassword => "";
        private static string sConnection => String.Format("Driver={Microsoft Access Driver (*.mdb)};dbq={0}\\{1}; Pwd={2}","APPLICATION_PATH_DATA","DATABASE_NAME",mgcPassword);

        private static string ErrorMessage(string location, string function, Exception e) => string.Format("ERROR @ {0}.{1} - {2}", location, function, e.Message);
    
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
