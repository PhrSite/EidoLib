/////////////////////////////////////////////////////////////////////////////////////
//  File: AdditionalDataType.cs                                     15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for additional information associated with an incident call, location, or person.
    /// See Section 2.19  NENA-STA-021.1a-2022.
    /// </summary>
    public class AdditionalDataType : PrologueType
    {
        /// <summary>
        /// A URL that references additional data associated with a call.
        /// </summary>
        public string additionalDataByReferenceUrl { get; set; }

        /// <summary>
        /// Additional data associated with a call.
        /// </summary>
        public string additionalDataByValue { get; set; }

        /// <summary>
        /// Purpose that accompanied the URL. For example, the purpose parameter sent with the URL in the 
        /// Call-Info headers. The value in this string indicates the type of additional data contained in
        /// the additionalDataByValue field or the type of data that will be retrieved by de-referencing the
        /// URL in the additionalDataByReferenceUrl field.
        /// <para>
        /// Example: EmergencyCallData.ServiceInfo
        /// </para>
        /// </summary>
        public string urlPurpose { get; set; }

        /// <summary>
        /// Notes and comments associated with an incident. Linked elements type are NotesType
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
