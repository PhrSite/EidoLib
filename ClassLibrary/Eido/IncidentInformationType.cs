/////////////////////////////////////////////////////////////////////////////////////
//  File: IncidentInformationType.cs                                16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for general information about emergency incidents gathered by emergency agents, 
    /// responding emergency resources, from reporting parties(callers), and devices reporting 
    /// emergency incidents.
    /// See Section 2.9 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class IncidentInformationType : PrologueType
    {
        /// <summary>
        /// An alphanumeric code indicating the category of the incident. This is the internal code 
        /// used by the local agencies involved in the incident.
        /// </summary>
        public string incidentTypeInternalCode { get; set; }

        /// <summary>
        /// Textual description indicating the category of the incident. This is 
        /// the internal text used by the local agencies involved in the incident.
        /// </summary>
        public string incidentTypeInternalText { get; set; }

        /// <summary>
        /// Incident type code. Shall only contains values present in the Incident Type registry.
        /// See Section 3.2 of NENA-STA-021.1.
        /// Required.
        /// </summary>
        public string incidentTypeCommonRegistryText { get; set; }

        /// <summary>
        /// An internal code used by a local agency for a status of an incident.
        /// </summary>
        public List<string> incidentStatusInternalText { get; set; }

        /// <summary>
        /// Incident status code. Shall only contain values present in the Incident Status registry
        /// See Section 3.3 of NENA-STA-021.1a-2022.
        /// </summary>
        public List<string> incidentStatusCommonRegistryText { get; set; }

        /// <summary>
        /// Internal incident ID
        /// </summary>
        public string internalIncidentId { get; set; }

        /// <summary>
        /// Linked elements type is AgentType.
        /// </summary>
        public List<ReferenceType> agentReference { get; set; }

        /// <summary>
        /// A location associated with an incident. Linked elements type is LocationInformationType.
        /// </summary>
        public List<ReferenceType> locationReference { get; set; }

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

        /// <summary>
        /// The Document Identification connects the Incident to one or more associated follow-up
        /// reports and investigations. Each responding agency may have its own Document Identification.
        /// Also used by agency supervisor and other personnel to track the status of reports.
        /// </summary>
        public string documentIdentification { get; set; }

        /// <summary>
        /// Report number type codes that are available in the EIDO Registries(see Section 3.4,
        /// in NENA-021.1a-2022, for the registry description); may be New or Reopened.
        /// </summary>
        public string reportNumberType { get; set; }

        /// <summary>
        /// An internal value used by a local agency for the priority of an incident.
        /// </summary>
        public string incidentPriorityInternalText { get; set; }

        /// <summary>
        /// Globally understood numeric Incident priority that ranges from 0 to 10, with 10 being the 
        /// highest priority and 0 being the lowest priority.
        /// </summary>
        public int incidentCommonPriorityNumber { get; set; }

        /// <summary>
        /// A beat or dispatch group that contains an incident.
        /// </summary>
        public string beatOrDispatchGroupText { get; set; }

        /// <summary>
        /// Incident disposition information entered or updated by a dispatch agent and/or a responding 
        /// emergency resource.
        /// </summary>
        public List<DispositionType> dispositionComponent { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric 
        /// text further describing the incident.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
