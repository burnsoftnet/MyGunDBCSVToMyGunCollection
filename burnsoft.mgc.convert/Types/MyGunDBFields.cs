using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.mgc.convert.Types
{
    public class MyGunDBFields
    {
        /// <summary>
        /// A manufacturer
        /// </summary>
        public string manufacturer { get; set; }
        /// <summary>Gets or sets the importer - B some purchase place here (JG Sales) , and sometimes manufacturers name is spilled over..</summary>
        /// <value>The importer.</value>
        public string importer { get; set; }
        /// <summary>
        /// Gets or sets the model - C model number I.E. 7400
        /// </summary>
        /// <value>The model.</value>
        public string model { get; set; }
        /// <summary>
        /// Gets or sets the year of purchase. - D year of purchase
        /// </summary>
        /// <value>The year of purchase.</value>
        public string YearOfPurchase { get; set; }
        /// <summary>
        /// Gets or sets the year manufactured.
        /// </summary>
        /// <value>The year manufactured.</value>
        public string YearManufactured { get; set; }
        /// <summary>
        /// Gets or sets the serial number. - E serial number
        /// </summary>
        /// <value>The serial number.</value>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Gets or sets the description. - F notes
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the caliber. - G caliber
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the condition. - H condition percentage
        /// </summary>
        /// <value>The condition.</value>
        public string Condition { get; set; }
        /// <summary>
        /// Gets or sets the stock. - I finish (both metal and stocks)
        /// </summary>
        /// <value>The stock.</value>
        public string Stock { get; set; }
        /// <summary>
        /// Gets or sets the finish. - I finish (both metal and stocks)
        /// </summary>
        /// <value>The finish.</value>
        public string Finish { get; set; }
        /// <summary>
        /// Gets or sets the firearm action. - K action type
        /// </summary>
        /// <value>The firearm action.</value>
        public string FirearmAction { get; set; }
        /// <summary>
        /// Gets or sets the location. - L location I.E. safe
        /// </summary>
        /// <value>The location.</value>
        public string Location { get; set; }
        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin.</value>
        public string Origin { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is c and r. - J C&R yes or no
        /// </summary>
        /// <value><c>true</c> if this instance is c and r; otherwise, <c>false</c>.</value>
        public bool isCAndR { get; set; }
        /// <summary>
        /// Gets or sets the appriased by. - M not sure...might be appraised by
        /// </summary>
        /// <value>The appriased by.</value>
        public string appriasedBy { get; set; }
        /// <summary>
        /// Gets or sets the appriased date. - O apprasial date? 
        /// </summary>
        /// <value>The appriased date.</value>
        public string appriasedDate { get; set; }
        /// <summary>
        /// Gets or sets the appraised price. - P apprasial price?
        /// </summary>
        /// <value>The appraised price.</value>
        public string appraisedPrice { get; set; }
        /// <summary>
        /// Gets or sets the purchased date. - Q purchase date?
        /// </summary>
        /// <value>The purchased date.</value>
        public string purchasedDate { get; set; }
        /// <summary>
        /// Gets or sets the insured by. - R insured by
        /// </summary>
        /// <value>The insured by.</value>
        public string insuredBy { get; set; }
        /// <summary>
        /// Gets or sets the insured price. - S insured value
        /// </summary>
        /// <value>The insured price.</value>
        public string insuredPrice { get; set; }
        /// <summary>
        /// Gets or sets the purchased from. - Y-Z purchased from
        /// </summary>
        /// <value>The purchased from.</value>
        public string purchasedFrom { get; set; }
        /// <summary>
        /// Gets or sets the purchase address. - AA-AC sellers street address
        /// </summary>
        /// <value>The purchase address.</value>
        public string purchaseAddress { get; set; }
        /// <summary>
        /// Gets or sets the purchase city. - AD City or town of seller
        /// </summary>
        /// <value>The purchase city.</value>
        public string purchaseCity { get; set; }
        /// <summary>
        /// Gets or sets the state of the purcahse. - AE state of seller
        /// </summary>
        /// <value>The state of the purcahse.</value>
        public string purcahseState { get; set; }
        /// <summary>
        /// Gets or sets the purchase zip. - AF zip code of seller
        /// </summary>
        /// <value>The purchase zip.</value>
        public string purchaseZip { get; set; }
        /// <summary>
        /// Gets or sets the purchase price. - AH purchase price
        /// </summary>
        /// <value>The purchase price.</value>
        public string purchasePrice { get; set; }
        /// <summary>
        /// Gets or sets the name of the sold business. - AI Sold to business name
        /// </summary>
        /// <value>The name of the sold business.</value>
        public string soldBusinessName { get; set; }
        /// <summary>
        /// Gets or sets the name of the sold ind. - AJ sold to individuals name...(either private or business person)
        /// </summary>
        /// <value>The name of the sold ind.</value>
        public string soldIndName { get; set; }
        /// <summary>
        /// Gets or sets the sold address. - AK-AM?  buyers street address
        /// </summary>
        /// <value>The sold address.</value>
        public string soldAddress { get; set; }
        /// <summary>
        /// Gets or sets the sold city. - AN buyers town
        /// </summary>
        /// <value>The sold city.</value>
        public string soldCity { get; set; }
        /// <summary>
        /// Gets or sets the state of the sold. - AO buyers state
        /// </summary>
        /// <value>The state of the sold.</value>
        public string soldState { get; set; }
        /// <summary>
        /// Gets or sets the sold zip code. - AP buyers zip code
        /// </summary>
        /// <value>The sold zip code.</value>
        public string soldZipCode { get; set; }
        /// <summary>
        /// Gets or sets the data sold. - AQ date of sale
        /// </summary>
        /// <value>The data sold.</value>
        public string dataSold { get; set; }
        /// <summary>
        /// Gets or sets the country of origin. - BG is country of origin
        /// </summary>
        /// <value>The country of origin.</value>
        public string countryOfOrigin { get; set; }
    }
}
