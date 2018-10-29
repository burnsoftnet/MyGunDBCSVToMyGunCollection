using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BurnSoft.mgc.convert;

namespace BurnSoft.mgc.convert
{
    public class MyGunDB
    {
        #region "Error Handling"

        /// <summary>
        /// Main Class Name for error dumping.
        /// </summary>
        /// <value>The class location.</value>
        private static string ClassLocation => "BurnSoft.mgc.convert.MyGunDB";

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
        /// Lists my gun database data.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="errMsg">The error MSG.</param>
        /// <returns>List&lt;Types.MyGunDBFields&gt;.</returns>
        public static List<Types.MyGunDBFields> ListMyGunDBData(string fileName, out string errMsg)
        {
            List<Types.MyGunDBFields> myResults = new List<Types.MyGunDBFields>();
            errMsg = @"";
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] values = line.Split(',');

                        bool isCAndR = false;
                        if (values[9].Contains("yes"))
                        {
                            isCAndR = true;
                        }

                        myResults.Add(new Types.MyGunDBFields()
                        {
                            manufacturer = FormatData.FormatString(values[0]),
                            importer = FormatData.FormatString(values[1]),
                            model = FormatData.FormatString(values[2]),
                            YearOfPurchase = FormatData.FormatString(values[3]),
                            SerialNumber = FormatData.FormatString(values[4]),
                            Description = FormatData.FormatString(values[5]),
                            Caliber = FormatData.FormatString(values[6]),
                            Condition = FormatData.FormatString(values[7]),
                            Finish = FormatData.FormatString(values[8]),
                            isCAndR = isCAndR,
                            FirearmAction = FormatData.FormatString(values[10]),
                            Location = FormatData.FormatString(values[11]),
                            appriasedDate = FormatData.FormatString(values[14]),
                            appraisedPrice = FormatData.FormatString(values[15]),
                            insuredBy = FormatData.FormatString(values[17]),
                            insuredPrice = FormatData.FormatString(values[18]),
                            purchasedFrom = FormatData.GetValueThatHasValue(values[24], values[25]),
                            purchaseAddress = FormatData.GetValueThatHasValue(values[26], values[27]),
                            purchaseCity = FormatData.FormatString(values[29]),
                            purcahseState = FormatData.FormatString(values[30]),
                            purchaseZip = FormatData.FormatString(values[31]),
                            purchasedDate = FormatData.FormatString(values[32]),
                            purchasePrice = FormatData.FormatString(values[33]),
                            soldBusinessName = FormatData.FormatString(values[34]),
                            soldIndName = FormatData.FormatString(values[35]),
                            soldAddress = FormatData.FormatString(values[37]),
                            soldCity = FormatData.FormatString(values[39]),
                            soldState = FormatData.FormatString(values[40]),
                            soldZipCode = FormatData.FormatString(values[41]),
                            dataSold = FormatData.FormatString(values[42]),
                            countryOfOrigin = FormatData.FormatString(values[58])

                        });
                    }
                }
            }
            catch (Exception e)
            {
                errMsg = ErrorMessage(ClassLocation, "ListMyGunDBData", e);
            }
            return myResults;
        }
    }
}
