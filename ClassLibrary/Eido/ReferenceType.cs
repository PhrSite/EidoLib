/////////////////////////////////////////////////////////////////////////////////////
//  File: ReferenceType.cs                                          15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json;

namespace Eido
{
    /// <summary>
    /// Class for referencing another data component.
    /// </summary>
    public class ReferenceType
    {
        /// <summary>
        /// The $ref value of the referenced data component. Must match the $id of some other
        /// component in the EIDO.
        /// Required.
        /// </summary>
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }
}
