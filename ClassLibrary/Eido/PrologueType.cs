/////////////////////////////////////////////////////////////////////////////////////
//  File: PrologueType.cs                                           16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json;

namespace Eido
{
    /// <summary>
    /// A common prologue on each data component. This is the base class for each data component
    /// class.
    /// </summary>
    public class PrologueType
    {
        /// <summary>
        /// Globally unique identifier of the data component.
        /// Required
        /// </summary>
        [JsonProperty("$id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Timestamp of the last time the data component was modified
        /// Required.
        /// </summary>
        public string lastUpdateTimestamp { get; set; } = EidoHelper.GetNenaTimestamp();

        /// <summary>
        /// Owning Agency Identifier. This includes private and public providers.
        /// Agencies are globally unique.
        /// Required.
        /// </summary>
        public ReferenceType updatedByAgencyReference { get; set; }

        /// <summary>
        /// A globally unique identifier of the agent or automaton that updated the 
        /// data component last
        /// </summary>
        public ReferenceType updatedByAgentReference { get; set; } = null;
    }
}
