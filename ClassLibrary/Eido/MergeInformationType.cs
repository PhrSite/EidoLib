/////////////////////////////////////////////////////////////////////////////////////
//  File:   MergeInformationType.cs                                 16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Eido
{
    /// <summary>
    /// A data type for a code list for a direction of a merge or split.
    /// </summary>
    public enum IncidentMergeDirectionCodeSimpleType
    {
        /// <summary>
        /// Replacing
        /// </summary>
        REPLACING,
        /// <summary>
        /// Replaced
        /// </summary>
        REPLACED,
        /// <summary>
        /// Split
        /// </summary>
        SPLIT
    }

    /// <summary>
    /// A data type for information about a merged or split incident.
    /// See Section 2.7 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class MergeInformationType : PrologueType
    {
        /// <summary>
        /// The Incident Tracking Identification of the Incident that is being merged with, or split from 
        /// the Incident.
        /// Required.
        /// </summary>
        public string incidentTrackingIdentifier { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public IncidentMergeDirectionCodeSimpleType incidentMergeDirectionCode
        { get; set; }
    }
}
