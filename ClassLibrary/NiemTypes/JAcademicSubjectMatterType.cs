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
    /// A data type for a specific course content related to core education and academic assessments and programs.
    /// </summary>
    [DataContract]
    public partial class JAcademicSubjectMatterType : IEquatable<JAcademicSubjectMatterType>
    { 
        /// <summary>
        /// A name of an academic course or subject. NIEM reference is j:AcademicSubjectMatterName
        /// </summary>
        /// <value>A name of an academic course or subject. NIEM reference is j:AcademicSubjectMatterName</value>

        [DataMember(Name="name")]
        public List<NcProperNameTextType> Name { get; set; }

        /// <summary>
        /// A number of academic credits associated with a specified subject or course. NIEM reference is j:AcademicSubjectMatterCreditsNumeric
        /// </summary>
        /// <value>A number of academic credits associated with a specified subject or course. NIEM reference is j:AcademicSubjectMatterCreditsNumeric</value>

        [DataMember(Name="creditsNumeric")]
        public List<NcNumericType> CreditsNumeric { get; set; }

        /// <summary>
        /// A description of an academic course or subject. NIEM reference is j:AcademicSubjectMatterText
        /// </summary>
        /// <value>A description of an academic course or subject. NIEM reference is j:AcademicSubjectMatterText</value>

        [DataMember(Name="text")]
        public List<NcTextType> Text { get; set; }

        /// <summary>
        /// jAcademicSubjectMatterType JSON-LD context
        /// </summary>
        /// <value>jAcademicSubjectMatterType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjAcademicSubjectMatterTypeContextJsonldEnum for ../JSON-LD_Contexts/jAcademicSubjectMatterTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jAcademicSubjectMatterTypeContext.jsonld")]
            JSONLDContextsjAcademicSubjectMatterTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jAcademicSubjectMatterType JSON-LD context
        /// </summary>
        /// <value>jAcademicSubjectMatterType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JAcademicSubjectMatterType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreditsNumeric: ").Append(CreditsNumeric).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JAcademicSubjectMatterType)obj);
        }

        /// <summary>
        /// Returns true if JAcademicSubjectMatterType instances are equal
        /// </summary>
        /// <param name="other">Instance of JAcademicSubjectMatterType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JAcademicSubjectMatterType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.SequenceEqual(other.Name)
                ) && 
                (
                    CreditsNumeric == other.CreditsNumeric ||
                    CreditsNumeric != null &&
                    CreditsNumeric.SequenceEqual(other.CreditsNumeric)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.SequenceEqual(other.Text)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (CreditsNumeric != null)
                    hashCode = hashCode * 59 + CreditsNumeric.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JAcademicSubjectMatterType left, JAcademicSubjectMatterType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JAcademicSubjectMatterType left, JAcademicSubjectMatterType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}