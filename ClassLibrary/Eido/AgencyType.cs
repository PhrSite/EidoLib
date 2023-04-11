/////////////////////////////////////////////////////////////////////////////////////
//  File: AgencyType.cs                                             15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for an organization that owns or is otherwise related to an emergency incident.
    /// See Section 2.6 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class AgencyType : PrologueType
    {
        /// <summary>
        /// The agency’s contact information.
        /// </summary>
        public string agencyJcard { get; set; }

        /// <summary>
        /// Shall only contain values present in the Agency Role registry.
        /// See Section 3.1 of NENA-STA-021.1a-2022.
        /// </summary>
        public List<string> agencyRoleDescriptionRegistryText { get; set; }

        /// <summary>
        /// True if an agency owns the emergency incident; false otherwise
        /// </summary>
        public bool incidentOwningAgencyIndicator { get; set; }

        /// <summary>
        /// One or more members of a list of available provider and agency types such as Law Enforcement, 
        /// Fire, EMS, Consolidated Dispatch, Ambulance Company, etc. Agency Types are are defined in the 
        /// IANA urn:emergency:service:responder registry.
        /// See Section 10.5 of NENA-STA-010.3.
        /// Required.
        /// </summary>
        public List<string> agencyType { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric text further describing 
        /// the agency.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
