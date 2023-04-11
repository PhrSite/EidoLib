/////////////////////////////////////////////////////////////////////////////////////
//  File: AgentType.cs                                              15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for information about agents (e.g., call takers, dispatchers, supervisors, 
    /// responding emergency resources, etc.) and automated systems acting as agents that are involved 
    /// in an incident.
    /// See Section 2.5 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class AgentType : PrologueType
    {
        /// <summary>
        /// The agent’s contact information.
        /// </summary>
        public string agentJcard { get; set; }

        /// <summary>
        /// The workstation position ID within the agent’s agency.
        /// </summary>
        public string agentWorkstationPositionIdentification { get; set; }

        /// <summary>
        /// Shall only contain values present in the Agent Role registry.
        /// See Section 10.28 of NENA-STA-010.3.
        /// </summary>
        public List<string> agentRoleRegistryText { get; set; }

        /// <summary>
        /// Linked element type is AgencyType
        /// </summary>
        public ReferenceType agencyReference { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric text further 
        /// describing the agent.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
