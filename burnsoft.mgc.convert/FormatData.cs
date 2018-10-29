using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.mgc.convert
{
    public class FormatData
    {
        #region "Error Handling"

        /// <summary>
        /// Main Class Name for error dumping.
        /// </summary>
        /// <value>The class location.</value>
        private static string ClassLocation => "BurnSoft.mgc.convert.FormatData";

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
        /// <summary>
        /// Formats the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string FormatString(string value)
        {
            string sAns = "";
            sAns = value.Replace("\\", "").Replace("\"", "").Trim();
            return sAns;
        }
        /// <summary>
        /// Gets the value that has value.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>System.String.</returns>
        public static string GetValueThatHasValue(string value1, string value2)
        {
            string sAns = "";
            value1 = FormatString(value1);
            value2 = FormatString(value2);

            if (value1.Length > 0 && value2.Length == 0)
            {
                sAns = value1;
            }
            else if (value1.Length == 0 && value2.Length > 0)
            {
                sAns = value2;
            }
            else if (value1.Length > 0 && value2.Length > 0)
            {
                sAns = String.Format("{0} ( {1} )", value1, value2);
            }
            return sAns;
        }
    }
}
