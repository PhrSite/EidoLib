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
    /// A data type for an entity which conveys a vehicle by way of a lease.
    /// </summary>
    [DataContract]
    public partial class JLessorType : IEquatable<JLessorType>
    { 
        /// <summary>
        /// An identification of an entity which conveys vehicles by way of a lease. NIEM reference is j:LessorIdentification
        /// </summary>
        /// <value>An identification of an entity which conveys vehicles by way of a lease. NIEM reference is j:LessorIdentification</value>

        [DataMember(Name="identification")]
        public List<NcIdentificationType> Identification { get; set; }

        /// <summary>
        /// An organization of whom the role object is a function. NIEM reference is nc:RoleOfOrganization
        /// </summary>
        /// <value>An organization of whom the role object is a function. NIEM reference is nc:RoleOfOrganization</value>

        [DataMember(Name="roleOfOrganization")]
        public List<NcOrganizationType> RoleOfOrganization { get; set; }

        /// <summary>
        /// A person of whom the role object is a function. NIEM reference is nc:RoleOfPerson
        /// </summary>
        /// <value>A person of whom the role object is a function. NIEM reference is nc:RoleOfPerson</value>

        [DataMember(Name="roleOfPerson")]
        public List<NcPersonType> RoleOfPerson { get; set; }

        /// <summary>
        /// jLessorType JSON-LD context
        /// </summary>
        /// <value>jLessorType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjLessorTypeContextJsonldEnum for ../JSON-LD_Contexts/jLessorTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jLessorTypeContext.jsonld")]
            JSONLDContextsjLessorTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jLessorType JSON-LD context
        /// </summary>
        /// <value>jLessorType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JLessorType {\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  RoleOfOrganization: ").Append(RoleOfOrganization).Append("\n");
            sb.Append("  RoleOfPerson: ").Append(RoleOfPerson).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return obj.GetType() == GetType() && Equals((JLessorType)obj);
        }

        /// <summary>
        /// Returns true if JLessorType instances are equal
        /// </summary>
        /// <param name="other">Instance of JLessorType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JLessorType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.SequenceEqual(other.Identification)
                ) && 
                (
                    RoleOfOrganization == other.RoleOfOrganization ||
                    RoleOfOrganization != null &&
                    RoleOfOrganization.SequenceEqual(other.RoleOfOrganization)
                ) && 
                (
                    RoleOfPerson == other.RoleOfPerson ||
                    RoleOfPerson != null &&
                    RoleOfPerson.SequenceEqual(other.RoleOfPerson)
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
                    if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                    if (RoleOfOrganization != null)
                    hashCode = hashCode * 59 + RoleOfOrganization.GetHashCode();
                    if (RoleOfPerson != null)
                    hashCode = hashCode * 59 + RoleOfPerson.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JLessorType left, JLessorType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JLessorType left, JLessorType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
