using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.mgc.convert.MyGunCollection
{
    public class Registry
    {
        #region "Error Handling"

        /// <summary>
        /// Main Class Name for error dumping.
        /// </summary>
        /// <value>The class location.</value>
        private static string ClassLocation => "BurnSoft.mgc.convert.MyGunCollection.Registry";

        /// <summary>
        /// General Error Message Format getting the ClassLocation property and appending it to the sLocation and also appended it
        /// to the ex.message, this was done to allow you narrow down the location of were the error occurred.
        /// </summary>
        /// <param name="classLocation">The Class that the error Came from</param>
        /// <param name="sLocation">Sub or Function Name</param>
        /// <param name="ex">Exception</param>
        /// <returns>string Class.SubOrFunction - Error Message</returns>
        /// <example>serror = ErrorMessage(ClassLocation,"getDBVersion", ex);</example>
        /// <remarks>copy and fill in the blank - ErrorMessage("", ex);</remarks>
        private static string ErrorMessage(string classLocation, string sLocation, Exception ex)
        {
            return String.Format("{0}.{1} - {2}", classLocation, sLocation, ex.Message);
        }
        #endregion
        public static string DefaultRegPath
        {
            get
            {
                return "Software\\BurnSoft\\BSMGC";
            }
        }

        //public static string GetRegSubKeyValue(string sKey)
    }
}
