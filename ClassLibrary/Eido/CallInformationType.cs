/////////////////////////////////////////////////////////////////////////////////////
//  File: CallInformationType.cs                                    15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for call information about an incident received and collected by an agent.
    /// See Section 2.10 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class CallInformationType : PrologueType
    {
        /// <summary>
        /// CallIdentifier of calls that are related to this call. Eg Callbacks
        /// </summary>
        public List<string> relatedCallIdentifier { get; set; }

        /// <summary>
        /// An identifier of a queue where the call is currently on.
        /// </summary>
        public string queueIdentifier { get; set; }

        /// <summary>
        /// Values limited to those in the LogEvent CallTypes registry with “Primary” classification. 
        /// See Section 10.23 of NENA-STA-010.3.
        /// Required.
        /// </summary>
        public string standardPrimaryCallType { get; set; }

        /// <summary>
        /// Values limited to those in the LogEvent CallTypes registry with “Secondary” classification.
        /// </summary>
        public string standardSecondaryCallType { get; set; }

        /// <summary>
        /// Locally defined call type.
        /// </summary>
        public string localCallType { get; set; }

        /// <summary>
        /// “incoming” means received by the EIDO sender, “outgoing” means sent by the EIDO sender 
        /// and “internal” means both caller and recipient are within the EIDO sender.
        /// Required.
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// Additional information associated with an incident call, location, or person. Linked elements 
        /// type is AdditionalDataType
        /// </summary>
        public List<ReferenceType> additionalDataReference { get; set; }

        /// <summary>
        /// Date and time stamp of when the call was received. Section 2.3 of NENA-STA-010.3 specifies
        /// the format. For example: "2015-08-21T12:58:03.01-05:00"
        /// Required.
        /// </summary>
        public string callStartTimestamp { get; set; }

        /// <summary>
        /// A date and time a which the call was answered by an agent. Section 2.3 of NENA-STA-010.3 
        /// specifies the format. For example: "2015-08-21T12:58:03.01-05:00"
        /// </summary>
        public string answerDate { get; set; }

        /// <summary>
        /// Shall only contain values present in the Call State registry.
        /// See Section 10.24 of NENA-STA-010.3.
        /// Required.
        /// </summary>
        public string callStateRegistryText { get; set; }

        /// <summary>
        /// Reference to a callback data component. Identifies how the caller described in this data 
        /// component can be called back.
        /// </summary>
        public ReferenceType callBackReference { get; set; }

        /// <summary>
        /// Value of the verstat parameter. Required if known.
        /// </summary>
        public string verstat { get; set; }

        /// <summary>
        /// Content of the SIP Identity header. Required if known.
        /// </summary>
        public string sipIdentity { get; set; }

        /// <summary>
        /// Linked elements type is AgentType
        /// </summary>
        public List<ReferenceType> agentReference { get; set; }

        /// <summary>
        /// A location associated with an incident. Linked elements type is LocationInformationType
        /// </summary>
        public List<ReferenceType> locationReference { get; set; }

        /// <summary>
        /// Information about a person associated with an incident. Linked element type is 
        /// PersonInformationType
        /// </summary>
        public List<ReferenceType> personReference { get; set; }

        /// <summary>
        /// Contains optional alphanumeric text further describing the call.  Linked elements type if 
        /// NotesType
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
