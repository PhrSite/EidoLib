/////////////////////////////////////////////////////////////////////////////////////
//  File: CallbackType.cs                                           15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// This data component is used to exchange information about how to contact the Incident’s 
    /// reporting parties.
    /// See Section 2.11 NENA-STA-021.1a-2022
    /// </summary>
    public partial class CallbackType : PrologueType
    {
        /// <summary>
        /// Information that enables agents and responders to call back.URI(s) found in the 
        /// P-Asserted-Identity header if provided, else the URI in the From header.
        /// </summary>
        public List<string> callBackInformationUri { get; set; }

        /// <summary>
        /// Content of the device contact header. Information that enables agents and responders to 
        /// possibly reach (call back) the device that initiated the call.
        /// </summary>
        public string deviceContactHeader { get; set; }

        /// <summary>
        /// Identifies additional telephone numbers and SIP equivalents that can be used to contact.
        /// </summary>
        public UpdatedCBNType updatedCbn { get; set; }
    }
}
