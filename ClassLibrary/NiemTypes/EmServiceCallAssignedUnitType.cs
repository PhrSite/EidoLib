/*
 * NiemTypes
 *
 * NIEM Types for the EIDO
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NiemTypes
{ 
    /// <summary>
    /// A data type for a service call assigned unit detail.
    /// </summary>
    [DataContract]
    public partial class EmServiceCallAssignedUnitType : NcOrganizationType, IEquatable<EmServiceCallAssignedUnitType>
    { 
        /// <summary>
        /// A structure that contains date information about when a unit was assigned to an incident NIEM reference is em:UnitAssignedDate
        /// </summary>
        /// <value>A structure that contains date information about when a unit was assigned to an incident NIEM reference is em:UnitAssignedDate</value>

        [DataMember(Name="unitAssignedDate")]
        public List<NcDateType> UnitAssignedDate { get; set; }

        /// <summary>
        /// A structure that contains date information about when a unit was unassigned from an incident NIEM reference is em:UnitUnassignedDate
        /// </summary>
        /// <value>A structure that contains date information about when a unit was unassigned from an incident NIEM reference is em:UnitUnassignedDate</value>

        [DataMember(Name="unitUnassignedDate")]
        public List<NcDateType> UnitUnassignedDate { get; set; }

        /// <summary>
        /// emServiceCallAssignedUnitType JSON-LD context
        /// </summary>
        /// <value>emServiceCallAssignedUnitType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsemServiceCallAssignedUnitTypeContextJsonldEnum for ../JSON-LD_Contexts/emServiceCallAssignedUnitTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/emServiceCallAssignedUnitTypeContext.jsonld")]
            JSONLDContextsemServiceCallAssignedUnitTypeContextJsonldEnum = 0        }

        /// <summary>
        /// emServiceCallAssignedUnitType JSON-LD context
        /// </summary>
        /// <value>emServiceCallAssignedUnitType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmServiceCallAssignedUnitType {\n");
            sb.Append("  UnitAssignedDate: ").Append(UnitAssignedDate).Append("\n");
            sb.Append("  UnitUnassignedDate: ").Append(UnitUnassignedDate).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((EmServiceCallAssignedUnitType)obj);
        }

        /// <summary>
        /// Returns true if EmServiceCallAssignedUnitType instances are equal
        /// </summary>
        /// <param name="other">Instance of EmServiceCallAssignedUnitType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmServiceCallAssignedUnitType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UnitAssignedDate == other.UnitAssignedDate ||
                    UnitAssignedDate != null &&
                    UnitAssignedDate.SequenceEqual(other.UnitAssignedDate)
                ) && 
                (
                    UnitUnassignedDate == other.UnitUnassignedDate ||
                    UnitUnassignedDate != null &&
                    UnitUnassignedDate.SequenceEqual(other.UnitUnassignedDate)
                ) && 
                (
                    Context == other.Context ||
                    Context != null &&
                    Context.Equals(other.Context)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (UnitAssignedDate != null)
                    hashCode = hashCode * 59 + UnitAssignedDate.GetHashCode();
                    if (UnitUnassignedDate != null)
                    hashCode = hashCode * 59 + UnitUnassignedDate.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EmServiceCallAssignedUnitType left, EmServiceCallAssignedUnitType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmServiceCallAssignedUnitType left, EmServiceCallAssignedUnitType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
