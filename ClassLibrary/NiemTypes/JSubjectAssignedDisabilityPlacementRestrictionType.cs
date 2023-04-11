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
    /// A data type for a restriction on placement for a subject due to a disability.
    /// </summary>
    [DataContract]
    public partial class JSubjectAssignedDisabilityPlacementRestrictionType : NcActivityType, IEquatable<JSubjectAssignedDisabilityPlacementRestrictionType>
    { 
        /// <summary>
        /// True if the placement restriction is temporary; false otherwise. NIEM reference is j:SubjectAssignedDisabilityPlacementRestrictionTemporaryIndicator
        /// </summary>
        /// <value>True if the placement restriction is temporary; false otherwise. NIEM reference is j:SubjectAssignedDisabilityPlacementRestrictionTemporaryIndicator</value>

        [DataMember(Name="isTemporary")]
        public List<NiemXsboolean> IsTemporary { get; set; }

        /// <summary>
        /// A date a placement restriction due to a disability was recorded. NIEM reference is j:SubjectAssignedDisabilityPlacementRestrictionRecordedDate
        /// </summary>
        /// <value>A date a placement restriction due to a disability was recorded. NIEM reference is j:SubjectAssignedDisabilityPlacementRestrictionRecordedDate</value>

        [DataMember(Name="recordedDate")]
        public List<NcDateType> RecordedDate { get; set; }

        /// <summary>
        /// A kind of subject placement restriction due to a disability. NIEM reference is j:SubjectAssignedDisabilityPlacementRestrictionCategoryText
        /// </summary>
        /// <value>A kind of subject placement restriction due to a disability. NIEM reference is j:SubjectAssignedDisabilityPlacementRestrictionCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// jSubjectAssignedDisabilityPlacementRestrictionType JSON-LD context
        /// </summary>
        /// <value>jSubjectAssignedDisabilityPlacementRestrictionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjSubjectAssignedDisabilityPlacementRestrictionTypeContextJsonldEnum for ../JSON-LD_Contexts/jSubjectAssignedDisabilityPlacementRestrictionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jSubjectAssignedDisabilityPlacementRestrictionTypeContext.jsonld")]
            JSONLDContextsjSubjectAssignedDisabilityPlacementRestrictionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jSubjectAssignedDisabilityPlacementRestrictionType JSON-LD context
        /// </summary>
        /// <value>jSubjectAssignedDisabilityPlacementRestrictionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JSubjectAssignedDisabilityPlacementRestrictionType {\n");
            sb.Append("  IsTemporary: ").Append(IsTemporary).Append("\n");
            sb.Append("  RecordedDate: ").Append(RecordedDate).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JSubjectAssignedDisabilityPlacementRestrictionType)obj);
        }

        /// <summary>
        /// Returns true if JSubjectAssignedDisabilityPlacementRestrictionType instances are equal
        /// </summary>
        /// <param name="other">Instance of JSubjectAssignedDisabilityPlacementRestrictionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSubjectAssignedDisabilityPlacementRestrictionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsTemporary == other.IsTemporary ||
                    IsTemporary != null &&
                    IsTemporary.SequenceEqual(other.IsTemporary)
                ) && 
                (
                    RecordedDate == other.RecordedDate ||
                    RecordedDate != null &&
                    RecordedDate.SequenceEqual(other.RecordedDate)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
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
                    if (IsTemporary != null)
                    hashCode = hashCode * 59 + IsTemporary.GetHashCode();
                    if (RecordedDate != null)
                    hashCode = hashCode * 59 + RecordedDate.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JSubjectAssignedDisabilityPlacementRestrictionType left, JSubjectAssignedDisabilityPlacementRestrictionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JSubjectAssignedDisabilityPlacementRestrictionType left, JSubjectAssignedDisabilityPlacementRestrictionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
