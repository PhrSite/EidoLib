/////////////////////////////////////////////////////////////////////////////////////
//  File: DispatchInformationType.cs                                15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for dispatch information related to an incident.
    /// See Section 13 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class DispatchInformationType : PrologueType
    {
        /// <summary>
        /// Reference to an AgencyType. Agency that was dispatched through action performed in this 
        /// data component.
        /// </summary>
        public ReferenceType agencyReference { get; set; }

        /// <summary>
        /// Linked element type is AgentType. Identifies the agent that completed the dispatch 
        /// operation described.
        /// </summary>
        public ReferenceType agentReference { get; set; }

        /// <summary>
        /// A resource (vehicle, person [foot patrol], organizational unit such as a squad or strike 
        /// team, and other emergency responder configurations) that responds to an emergency incident.
        /// Linked element type is EmergencyResourceType
        /// </summary>
        public List<ReferenceType> emergencyResourceReference { get; set; }

        /// <summary>
        /// Contains optional alphanumeric text further describing the dispatch. Linked element type 
        /// is NotesType
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
