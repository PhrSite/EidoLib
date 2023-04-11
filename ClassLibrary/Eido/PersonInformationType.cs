/////////////////////////////////////////////////////////////////////////////////////
//  File: PersonInformationType.cs                                  16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using NiemTypes;

namespace Eido
{
    /// <summary>
    /// A data type for information about a person associated with an incident.
    /// See Section 2.16 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class PersonInformationType : PrologueType
    {
        /// <summary>
        /// NIEM Core Person Type, a data type for a human being.
        /// </summary>
        public NcPersonType ncPersonComponent { get; set; }

        /// <summary>
        /// Describes the relationship (Caller, Victim, suspect, etc.) of a person to the Incident.
        /// Shall only contain values present in the Person Role registry. See Section 3.6 of 
        /// NENA-021.1.
        /// Required.
        /// </summary>
        public List<string> personIncidentRoleRegistryText { get; set; }

        /// <summary>
        /// Call Identifier of the calls this person was involved on.Must be provided if this person was
        /// involved in a call. Must be a Call Identifier as specified in Section 2.16 of NENA-STA-010.3
        /// </summary>
        public List<string> callIdentifier { get; set; }

        /// <summary>
        /// Additional information associated with an incident call, location, or person. Linked elements 
        /// type are AdditionalDataType
        /// </summary>
        public List<ReferenceType> additionalDataReference { get; set; }

        /// <summary>
        /// A location associated with an Person. Linked elements type is LocationInformationType
        /// </summary>
        public List<ReferenceType> locationReference { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric text further describing 
        /// the person.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }

        /// <summary>
        /// Reference to a call back data component. Identifies how the person described in this data 
        /// component can be called back. Referenced type is a CallbackType.
        /// </summary>
        public ReferenceType callBackReference { get; set; }
    }
}
