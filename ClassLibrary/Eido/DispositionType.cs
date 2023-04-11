/////////////////////////////////////////////////////////////////////////////////////
//  File: DispositionType.cs                                        16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for incident disposition information entered or updated by a dispatch agent and/or a 
    /// responding emergency resource.
    /// See Section 2.14 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class DispositionType : PrologueType
    {
        /// <summary>
        /// An agency assigns a disposition to an Incident when its participation in the Incident
        /// ends.
        /// Shall only contain code values present "Public Safety Communications Common Disposition Codes 
        /// for Data Exchange" (APCO ANS 1.111.2-2018) or in the Common Disposition Code registry.
        /// See Section 3.5 of NENA-STA-021.1a-2022.
        /// Required.
        /// </summary>
        public string dispositionCommonRegistryCode { get; set; }

        /// <summary>
        /// True if the common disposition is the primary disposition for an agency for an incident; 
        /// false otherwise.
        /// </summary>
        public bool dispositionPrimaryIndicator { get; set; }

        /// <summary>
        /// An agency-specific, alphanumeric code that indicates how the Incident was closed. The Common 
        /// Disposition Code (Section 3.5 of NENA-STA-021.1a-2022) should be mapped to the closest value of 
        /// this data element.
        /// </summary>
        public string dispositionCategoryText { get; set; }

        /// <summary>
        /// Descriptive text describing the Disposition Code Internal. Disposition codes may be agency 
        /// specific and this field explains the meaning of the internal disposition code.
        /// </summary>
        public string dispositionDescriptionText { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric text further describing 
        /// the incident.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
