/////////////////////////////////////////////////////////////////////////////////////
//  File: EidoType.cs                                               16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for an information exchange containing emergency incident related data.
    /// This class is for the EmergencyIncidentDataObjectType specified in the YAML for the EIDO.
    /// See See Section 2.4 of NENA-STA-021.1a-2022
    /// </summary>
    public partial class EidoType : PrologueType
    {
        /// <summary>
        /// Version of the EIDO structure.
        /// </summary>
        public string eidoVersion { get; set; } = "1.0";

        /// <summary>
        /// An identifier of a functional element that created the EIDO instance. Must be a NENA 
        /// identifier in the format specified in Section 2.1 of NENA-STA-010.3.
        /// Example: police.allegheny.pa.us
        /// Required.
        /// </summary>
        public string issuingElementIdentification { get; set; }

        /// <summary>
        /// Information about a merged or split incident.
        /// </summary>
        public List<MergeInformationType> mergeComponent { get; set; }

        /// <summary>
        /// Information about a linked incident.
        /// </summary>
        public List<LinkInformationType> linkComponent { get; set; }

        /// <summary>
        /// General information about the emergency incident gathered by emergency agents, responding 
        /// emergency resources, from reporting parties(callers), and devices reporting emergency 
        /// incidents. 
        /// </summary>
        public IncidentInformationType incidentComponent { get; set; }

        /// <summary>
        /// Call information about an incident received and collected by an agent.
        /// </summary>
        public List<CallInformationType> callComponent { get; set; }

        /// <summary>
        /// Contains information about how to call a person.
        /// </summary>
        public List<CallbackType> callbackComponent { get; set; }

        /// <summary>
        /// Dispatch information related to an incident.
        /// </summary>
        public List<DispatchInformationType> dispatchComponent { get; set; }

        /// <summary>
        /// Alarms and sensors information associated with an incident.
        /// </summary>
        public List<AlarmsSensorsType> alarmsSensorsComponent { get; set; }

        /// <summary>
        /// All agencies referenced in this document are listed here
        /// </summary>
        public List<AgencyType> agencyComponent { get; set; }

        /// <summary>
        /// All agents referenced in this document are listed here
        /// </summary>
        public List<AgentType> agentComponent { get; set; }

        /// <summary>
        /// All notes referenced in this document are listed here
        /// </summary>
        public List<NotesType> notesComponent { get; set; }

        /// <summary>
        /// All additional data referenced in this document are listed here
        /// </summary>
        public List<AdditionalDataType> additionalDataComponent { get; set; }

        /// <summary>
        /// All location information referenced in this document are listed here
        /// </summary>
        public List<LocationInformationType> locationComponent { get; set; }

        /// <summary>
        /// All person informations referenced in this document are listed here
        /// </summary>
        public List<PersonInformationType> personComponent { get; set; }

        /// <summary>
        /// All vehicle informations referenced in this document are listed here
        /// </summary>
        public List<VehicleInformationType> vehicleComponent { get; set; }

        /// <summary>
        /// All emergency resources information referenced in this document are 
        /// listed here
        /// </summary>
        public List<EmergencyResourceType> emergencyResourceComponent { get; set; }
    }
}
