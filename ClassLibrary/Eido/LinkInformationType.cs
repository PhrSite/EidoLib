/////////////////////////////////////////////////////////////////////////////////////
//  File: LinkInformationType.cs                                    16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Eido
{
    /// <summary>
    /// A data type for a code list for a kind of link performed.
    /// </summary>
    public enum LinkDirectionCodeSimpleType
    {
        /// <summary>
        /// Parent
        /// </summary>
        PARENT,
        /// <summary>
        /// Child
        /// </summary>
        CHILD,
        /// <summary>
        /// Related
        /// </summary>
        RELATED,
        /// <summary>
        /// Unlink
        /// </summary>
        UNLINK
    }

    /// <summary>
    /// A data type for information about a linked incident.
    /// See Section 2.8 of NENA-STA-021a-2022.
    /// </summary>
    public partial class LinkInformationType : PrologueType
    {
        /// <summary>
        /// A globally unique emergency incident identifier. 
        /// Required.
        /// </summary>
        public string incidentTrackingIdentifier { get; set; }

        /// <summary>
        /// Free format narrative description of the reason for the link
        /// </summary>
        public string transactionReasonText { get; set; }

        /// <summary>
        /// Agencies involved with the linked incident. Must be populated if the agency sending the 
        /// EIDO is not involved with the linked incident. 
        /// </summary>
        public ReferenceType involvedAgencyReference { get; set; }

        /// <summary>
        /// Direction. Required.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LinkDirectionCodeSimpleType linkDirectionCode { get; set; }
    }
}
