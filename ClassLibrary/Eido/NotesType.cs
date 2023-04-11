/////////////////////////////////////////////////////////////////////////////////////
//  File: NotesType.cs                                              16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for notes and comments associated with an incident.
    /// See Section 2.15 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class NotesType : PrologueType
    {
        /// <summary>
        /// A note about an incident created by an agent; in HTML5 format.
        /// Required.
        /// </summary>
        public string notesActionComments { get; set; }

        /// <summary>
        /// Identifies the agent and agency that entered the note contained in this data component.
        /// Linked element type is AgentType
        /// </summary>
        public ReferenceType agentReference { get; set; }
    }
}
