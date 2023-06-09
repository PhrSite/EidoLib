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
    /// A data type for a unit of an agency responsible for enforcing the law and maintaining peace.
    /// </summary>
    [DataContract]
    public partial class JEnforcementUnitType : NcOrganizationType, IEquatable<JEnforcementUnitType>
    { 
        /// <summary>
        /// An identification of a local area for which an enforcement unit is responsible. NIEM reference is j:EnforcementUnitBeatIdentification
        /// </summary>
        /// <value>An identification of a local area for which an enforcement unit is responsible. NIEM reference is j:EnforcementUnitBeatIdentification</value>

        [DataMember(Name="beatIdentification")]
        public List<NcIdentificationType> BeatIdentification { get; set; }

        /// <summary>
        /// An identification of an enforcement unit. NIEM reference is j:EnforcementUnitIdentification
        /// </summary>
        /// <value>An identification of an enforcement unit. NIEM reference is j:EnforcementUnitIdentification</value>

        [DataMember(Name="identification")]
        public List<NcIdentificationType> Identification { get; set; }

        /// <summary>
        /// A name of an enforcement unit. NIEM reference is j:EnforcementUnitName
        /// </summary>
        /// <value>A name of an enforcement unit. NIEM reference is j:EnforcementUnitName</value>

        [DataMember(Name="name")]
        public List<NcTextType> Name { get; set; }

        /// <summary>
        /// An identification of an enforcement unit. NIEM reference is j:EnforcementUnitNumberIdentification
        /// </summary>
        /// <value>An identification of an enforcement unit. NIEM reference is j:EnforcementUnitNumberIdentification</value>

        [DataMember(Name="numberIdentification")]
        public List<NcIdentificationType> NumberIdentification { get; set; }

        /// <summary>
        /// An identification of a section of an enforcement unit. NIEM reference is j:EnforcementUnitSectionIdentification
        /// </summary>
        /// <value>An identification of a section of an enforcement unit. NIEM reference is j:EnforcementUnitSectionIdentification</value>

        [DataMember(Name="sectionIdentification")]
        public List<NcIdentificationType> SectionIdentification { get; set; }

        /// <summary>
        /// jEnforcementUnitType JSON-LD context
        /// </summary>
        /// <value>jEnforcementUnitType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjEnforcementUnitTypeContextJsonldEnum for ../JSON-LD_Contexts/jEnforcementUnitTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jEnforcementUnitTypeContext.jsonld")]
            JSONLDContextsjEnforcementUnitTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jEnforcementUnitType JSON-LD context
        /// </summary>
        /// <value>jEnforcementUnitType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JEnforcementUnitType {\n");
            sb.Append("  BeatIdentification: ").Append(BeatIdentification).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberIdentification: ").Append(NumberIdentification).Append("\n");
            sb.Append("  SectionIdentification: ").Append(SectionIdentification).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JEnforcementUnitType)obj);
        }

        /// <summary>
        /// Returns true if JEnforcementUnitType instances are equal
        /// </summary>
        /// <param name="other">Instance of JEnforcementUnitType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JEnforcementUnitType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BeatIdentification == other.BeatIdentification ||
                    BeatIdentification != null &&
                    BeatIdentification.SequenceEqual(other.BeatIdentification)
                ) && 
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.SequenceEqual(other.Identification)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.SequenceEqual(other.Name)
                ) && 
                (
                    NumberIdentification == other.NumberIdentification ||
                    NumberIdentification != null &&
                    NumberIdentification.SequenceEqual(other.NumberIdentification)
                ) && 
                (
                    SectionIdentification == other.SectionIdentification ||
                    SectionIdentification != null &&
                    SectionIdentification.SequenceEqual(other.SectionIdentification)
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
                    if (BeatIdentification != null)
                    hashCode = hashCode * 59 + BeatIdentification.GetHashCode();
                    if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (NumberIdentification != null)
                    hashCode = hashCode * 59 + NumberIdentification.GetHashCode();
                    if (SectionIdentification != null)
                    hashCode = hashCode * 59 + SectionIdentification.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JEnforcementUnitType left, JEnforcementUnitType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JEnforcementUnitType left, JEnforcementUnitType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
