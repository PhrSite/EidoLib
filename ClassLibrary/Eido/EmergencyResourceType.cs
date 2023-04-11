/////////////////////////////////////////////////////////////////////////////////////
//  File:   EmergencyResourceType.cs                                16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for a resource (vehicle, person [foot patrol], organizational unit such as a squad 
    /// or strike team, and other emergency responder configurations) that responds to an emergency 
    /// incident.
    /// See Section 2.20 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class EmergencyResourceType
    {
        /// <summary>
        /// Timestamp of when the unit is expected to reach it's destination. Must be in the 
        /// NENA Timestamp format specified in Section 2.3 of NENA-STA-010.3.
        /// </summary>
        public string eta { get; set; }

        /// <summary>
        /// Shall only contain values present in the Emergency Resource Type registry. 
        /// See Section 3.11 of NENA-STA-021.1a-2022.
        /// </summary>
        public string emergencyResourceTypeCommonRegistryText { get; set; }

        /// <summary>
        /// A local code for an emergency resource type.
        /// </summary>
        public string emergencyResourceTypeInternalText { get; set; }

        /// <summary>
        /// Shall only contain values present in the Resource Attribute registry.
        /// See Section 3.12 of NENA-STA-021.1a-2022.
        /// </summary>
        public List<string> resourceAttributeRegistryText { get; set; }

        /// <summary>
        /// Common name of the emergency resource.
        /// </summary>
        public string emergencyResourceName { get; set; }

        /// <summary>
        /// Shall only contain values present in the Primary Unit Status registry.
        /// See Section 3.9 of NENA-STA-021.1a-2022.
        /// </summary>
        public string primaryUnitStatusRegistryText { get; set; }

        /// <summary>
        /// Shall only contain values present in the Secondary Unit Status registry.
        /// See Section 3.10 of NENA-STA-021.1a-2022.
        /// </summary>
        public string secondaryUnitStatusRegistryText { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric text further describing 
        /// the incident.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }

        /// <summary>
        /// A local code for a status of an emergency resource.
        /// </summary>
        public List<string> unitStatusInternal { get; set; }

        /// <summary>
        /// Information about agents (e.g., call takers, dispatchers, supervisors, responding emergency 
        /// resources, etc.) and automated systems acting as agents that are involved in an incident. 
        /// Linked elements type is AgentType.
        /// </summary>
        public List<ReferenceType> agentReference { get; set; }

        /// <summary>
        /// Linked elements type is LocationInformationType
        /// </summary>
        public ReferenceType unitLocationReference { get; set; }

        /// <summary>
        /// Linked elements type is LocationInformationType
        /// </summary>
        public ReferenceType unitDestinationReference { get; set; }

        /// <summary>
        /// Information about a person associated with an incident. Linked elements type is 
        /// PersonInformationType.
        /// </summary>
        public List<ReferenceType> personReference { get; set; }

        /// <summary>
        /// Information about a vehicle associated with an incident. Linked elements type is 
        /// VehicleInformationType.
        /// </summary>
        public List<ReferenceType> vehicleReference { get; set; }
    }
}
