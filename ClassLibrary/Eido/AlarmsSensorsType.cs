/////////////////////////////////////////////////////////////////////////////////////
//  File: AlarmsSensorsType.cs                                      15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for alarms and sensors information associated with an incident.
    /// See Section 2.21 of NENA-STA-021.1a-2022.
    /// </summary>
    public class AlarmsSensorsType : PrologueType
    {
        /// <summary>
        /// Central Station Alarm Association (CSAA) data associated with an incident.
        /// Read in NIEM schema Alarm and Sensor data. For Alarms this would be the 
        /// APCO/CSAA ANS 2.101.2-2014 standard.
        /// </summary>
        public string csaaAlarmInformation { get; set; }

        /// <summary>
        /// A URL that references Central Station Alarm Association (CSAA) data associated with an incident.
        /// </summary>
        public string alarmUrl { get; set; }

        /// <summary>
        /// Linked elements type is AgentType
        /// </summary>
        public ReferenceType agentReference { get; set; }

        /// <summary>
        /// Contains optional alphanumeric text further describing the dispatch. Linked elements type 
        /// are NotesType
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
