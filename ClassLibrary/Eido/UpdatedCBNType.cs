/////////////////////////////////////////////////////////////////////////////////////
//  File: UpdatedCBNType.cs                                         17 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for additional telephone numbers and SIP equivalents that can be used to contact the 
    /// individual that made a call associated with an incident.
    /// See Section 2.12 of NENA-STA-021.1a-2022.
    /// </summary>
    public class UpdatedCBNType : PrologueType
    {
        /// <summary>
        /// A telephone number or SIP equivalent of a reporting party described in the parent call.
        /// Required.
        /// </summary>
        public string updatedCbnIdentifierUri { get; set; }

        /// <summary>
        /// Additional descriptive text about an updated caller call back number such as the days and 
        /// hours to use it and the type of number(e.g., work, home, friend, etc.).
        /// </summary>
        public string updatedCbnCallerDescription { get; set; }
    }
}
