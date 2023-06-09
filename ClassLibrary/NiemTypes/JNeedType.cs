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
    /// A data type for a need that is characteristically defined within a need category from assessments that drive the purpose for rehabilitation programs that address subject needs.
    /// </summary>
    [DataContract]
    public partial class JNeedType : IEquatable<JNeedType>
    { 
        /// <summary>
        /// A numeric score for the need based on assessment. NIEM reference is j:NeedScoreNumeric
        /// </summary>
        /// <value>A numeric score for the need based on assessment. NIEM reference is j:NeedScoreNumeric</value>

        [DataMember(Name="scoreNumeric")]
        public List<NcNumericType> ScoreNumeric { get; set; }

        /// <summary>
        /// True if is set when parties believe that the Goals have been achieved and each Need or Risk has been adequately addressed; false otherwise. NIEM reference is j:NeedAddressedIndicator
        /// </summary>
        /// <value>True if is set when parties believe that the Goals have been achieved and each Need or Risk has been adequately addressed; false otherwise. NIEM reference is j:NeedAddressedIndicator</value>

        [DataMember(Name="isAddressed")]
        public List<NiemXsboolean> IsAddressed { get; set; }

        /// <summary>
        /// A kind of categories that Subject Assessments are based upon to help organize the assessments the subject has taken. NIEM reference is j:NeedCategoryText
        /// </summary>
        /// <value>A kind of categories that Subject Assessments are based upon to help organize the assessments the subject has taken. NIEM reference is j:NeedCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A kind of values to identify the source of the Need or Risk. NIEM reference is j:NeedSourceText
        /// </summary>
        /// <value>A kind of values to identify the source of the Need or Risk. NIEM reference is j:NeedSourceText</value>

        [DataMember(Name="source")]
        public List<NcTextType> Source { get; set; }

        /// <summary>
        /// A descriptor used to describe how serious a subject has needs of a specific type. NIEM reference is j:NeedIntensityLevelText
        /// </summary>
        /// <value>A descriptor used to describe how serious a subject has needs of a specific type. NIEM reference is j:NeedIntensityLevelText</value>

        [DataMember(Name="intensityLevel")]
        public List<NcTextType> IntensityLevel { get; set; }

        /// <summary>
        /// An identifier of a need that a subject has been assessed with. NIEM reference is j:NeedID
        /// </summary>
        /// <value>An identifier of a need that a subject has been assessed with. NIEM reference is j:NeedID</value>

        [DataMember(Name="needId")]
        public List<NiemXsstring> NeedId { get; set; }

        /// <summary>
        /// jNeedType JSON-LD context
        /// </summary>
        /// <value>jNeedType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjNeedTypeContextJsonldEnum for ../JSON-LD_Contexts/jNeedTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jNeedTypeContext.jsonld")]
            JSONLDContextsjNeedTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jNeedType JSON-LD context
        /// </summary>
        /// <value>jNeedType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JNeedType {\n");
            sb.Append("  ScoreNumeric: ").Append(ScoreNumeric).Append("\n");
            sb.Append("  IsAddressed: ").Append(IsAddressed).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  IntensityLevel: ").Append(IntensityLevel).Append("\n");
            sb.Append("  NeedId: ").Append(NeedId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JNeedType)obj);
        }

        /// <summary>
        /// Returns true if JNeedType instances are equal
        /// </summary>
        /// <param name="other">Instance of JNeedType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JNeedType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ScoreNumeric == other.ScoreNumeric ||
                    ScoreNumeric != null &&
                    ScoreNumeric.SequenceEqual(other.ScoreNumeric)
                ) && 
                (
                    IsAddressed == other.IsAddressed ||
                    IsAddressed != null &&
                    IsAddressed.SequenceEqual(other.IsAddressed)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.SequenceEqual(other.Source)
                ) && 
                (
                    IntensityLevel == other.IntensityLevel ||
                    IntensityLevel != null &&
                    IntensityLevel.SequenceEqual(other.IntensityLevel)
                ) && 
                (
                    NeedId == other.NeedId ||
                    NeedId != null &&
                    NeedId.SequenceEqual(other.NeedId)
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
                    if (ScoreNumeric != null)
                    hashCode = hashCode * 59 + ScoreNumeric.GetHashCode();
                    if (IsAddressed != null)
                    hashCode = hashCode * 59 + IsAddressed.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                    if (IntensityLevel != null)
                    hashCode = hashCode * 59 + IntensityLevel.GetHashCode();
                    if (NeedId != null)
                    hashCode = hashCode * 59 + NeedId.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JNeedType left, JNeedType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JNeedType left, JNeedType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
