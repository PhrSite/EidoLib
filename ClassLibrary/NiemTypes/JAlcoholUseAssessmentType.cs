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
    /// A data type for an assessment specific to a subject&#x27;s alcohol use.
    /// </summary>
    [DataContract]
    public partial class JAlcoholUseAssessmentType : NcAssessmentType, IEquatable<JAlcoholUseAssessmentType>
    { 
        /// <summary>
        /// A number of the quantity of alcohol the subject reported consuming. NIEM reference is j:AlcoholUseAssessmentAlcoholUseConsumptionQuantity
        /// </summary>
        /// <value>A number of the quantity of alcohol the subject reported consuming. NIEM reference is j:AlcoholUseAssessmentAlcoholUseConsumptionQuantity</value>

        [DataMember(Name="alcoholUseConsumptionQuantity")]
        public List<NcQuantityType> AlcoholUseConsumptionQuantity { get; set; }

        /// <summary>
        /// A number indicating the longest period of time subject reported abstaining from alcohol use. NIEM reference is j:AlcoholUseAssessmentAlcoholAbuseMaximumDurationAbstainedNumeric
        /// </summary>
        /// <value>A number indicating the longest period of time subject reported abstaining from alcohol use. NIEM reference is j:AlcoholUseAssessmentAlcoholAbuseMaximumDurationAbstainedNumeric</value>

        [DataMember(Name="alcoholAbuseMaximumDurationAbstainedNumeric")]
        public List<NcNumericType> AlcoholAbuseMaximumDurationAbstainedNumeric { get; set; }

        /// <summary>
        /// A number of the length of an alcohol treatment program. NIEM reference is j:AlcoholUseAssessmentAlcoholAbuseLengthOfTreatmentNumeric
        /// </summary>
        /// <value>A number of the length of an alcohol treatment program. NIEM reference is j:AlcoholUseAssessmentAlcoholAbuseLengthOfTreatmentNumeric</value>

        [DataMember(Name="alcoholAbuseLengthOfTreatmentNumeric")]
        public List<NcNumericType> AlcoholAbuseLengthOfTreatmentNumeric { get; set; }

        /// <summary>
        /// A summary on the alcohol use of a subject. NIEM reference is j:AlcoholUseAssessmentSummaryText
        /// </summary>
        /// <value>A summary on the alcohol use of a subject. NIEM reference is j:AlcoholUseAssessmentSummaryText</value>

        [DataMember(Name="summary")]
        public List<NcTextType> Summary { get; set; }

        /// <summary>
        /// A comment on the frequency a subject reported consuming alcohol. NIEM reference is j:AlcoholUseAssessmentAlcoholConsumptionFrequencyText
        /// </summary>
        /// <value>A comment on the frequency a subject reported consuming alcohol. NIEM reference is j:AlcoholUseAssessmentAlcoholConsumptionFrequencyText</value>

        [DataMember(Name="alcoholConsumptionFrequency")]
        public List<NcTextType> AlcoholConsumptionFrequency { get; set; }

        /// <summary>
        /// A number of the recorded age a subject reported first using alcohol. NIEM reference is j:AlcoholUseAssessmentAlcoholAbuseFirstAgeUsedNumeric
        /// </summary>
        /// <value>A number of the recorded age a subject reported first using alcohol. NIEM reference is j:AlcoholUseAssessmentAlcoholAbuseFirstAgeUsedNumeric</value>

        [DataMember(Name="alcoholAbuseFirstAgeUsedNumeric")]
        public List<NcNumericType> AlcoholAbuseFirstAgeUsedNumeric { get; set; }

        /// <summary>
        /// A comment about the subject&#x27;s use of alcohol. NIEM reference is j:AlcoholUseAssessmentComment
        /// </summary>
        /// <value>A comment about the subject&#x27;s use of alcohol. NIEM reference is j:AlcoholUseAssessmentComment</value>

        [DataMember(Name="comment")]
        public List<NcCommentType> Comment { get; set; }

        /// <summary>
        /// jAlcoholUseAssessmentType JSON-LD context
        /// </summary>
        /// <value>jAlcoholUseAssessmentType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjAlcoholUseAssessmentTypeContextJsonldEnum for ../JSON-LD_Contexts/jAlcoholUseAssessmentTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jAlcoholUseAssessmentTypeContext.jsonld")]
            JSONLDContextsjAlcoholUseAssessmentTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jAlcoholUseAssessmentType JSON-LD context
        /// </summary>
        /// <value>jAlcoholUseAssessmentType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JAlcoholUseAssessmentType {\n");
            sb.Append("  AlcoholUseConsumptionQuantity: ").Append(AlcoholUseConsumptionQuantity).Append("\n");
            sb.Append("  AlcoholAbuseMaximumDurationAbstainedNumeric: ").Append(AlcoholAbuseMaximumDurationAbstainedNumeric).Append("\n");
            sb.Append("  AlcoholAbuseLengthOfTreatmentNumeric: ").Append(AlcoholAbuseLengthOfTreatmentNumeric).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  AlcoholConsumptionFrequency: ").Append(AlcoholConsumptionFrequency).Append("\n");
            sb.Append("  AlcoholAbuseFirstAgeUsedNumeric: ").Append(AlcoholAbuseFirstAgeUsedNumeric).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JAlcoholUseAssessmentType)obj);
        }

        /// <summary>
        /// Returns true if JAlcoholUseAssessmentType instances are equal
        /// </summary>
        /// <param name="other">Instance of JAlcoholUseAssessmentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JAlcoholUseAssessmentType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AlcoholUseConsumptionQuantity == other.AlcoholUseConsumptionQuantity ||
                    AlcoholUseConsumptionQuantity != null &&
                    AlcoholUseConsumptionQuantity.SequenceEqual(other.AlcoholUseConsumptionQuantity)
                ) && 
                (
                    AlcoholAbuseMaximumDurationAbstainedNumeric == other.AlcoholAbuseMaximumDurationAbstainedNumeric ||
                    AlcoholAbuseMaximumDurationAbstainedNumeric != null &&
                    AlcoholAbuseMaximumDurationAbstainedNumeric.SequenceEqual(other.AlcoholAbuseMaximumDurationAbstainedNumeric)
                ) && 
                (
                    AlcoholAbuseLengthOfTreatmentNumeric == other.AlcoholAbuseLengthOfTreatmentNumeric ||
                    AlcoholAbuseLengthOfTreatmentNumeric != null &&
                    AlcoholAbuseLengthOfTreatmentNumeric.SequenceEqual(other.AlcoholAbuseLengthOfTreatmentNumeric)
                ) && 
                (
                    Summary == other.Summary ||
                    Summary != null &&
                    Summary.SequenceEqual(other.Summary)
                ) && 
                (
                    AlcoholConsumptionFrequency == other.AlcoholConsumptionFrequency ||
                    AlcoholConsumptionFrequency != null &&
                    AlcoholConsumptionFrequency.SequenceEqual(other.AlcoholConsumptionFrequency)
                ) && 
                (
                    AlcoholAbuseFirstAgeUsedNumeric == other.AlcoholAbuseFirstAgeUsedNumeric ||
                    AlcoholAbuseFirstAgeUsedNumeric != null &&
                    AlcoholAbuseFirstAgeUsedNumeric.SequenceEqual(other.AlcoholAbuseFirstAgeUsedNumeric)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.SequenceEqual(other.Comment)
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
                    if (AlcoholUseConsumptionQuantity != null)
                    hashCode = hashCode * 59 + AlcoholUseConsumptionQuantity.GetHashCode();
                    if (AlcoholAbuseMaximumDurationAbstainedNumeric != null)
                    hashCode = hashCode * 59 + AlcoholAbuseMaximumDurationAbstainedNumeric.GetHashCode();
                    if (AlcoholAbuseLengthOfTreatmentNumeric != null)
                    hashCode = hashCode * 59 + AlcoholAbuseLengthOfTreatmentNumeric.GetHashCode();
                    if (Summary != null)
                    hashCode = hashCode * 59 + Summary.GetHashCode();
                    if (AlcoholConsumptionFrequency != null)
                    hashCode = hashCode * 59 + AlcoholConsumptionFrequency.GetHashCode();
                    if (AlcoholAbuseFirstAgeUsedNumeric != null)
                    hashCode = hashCode * 59 + AlcoholAbuseFirstAgeUsedNumeric.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JAlcoholUseAssessmentType left, JAlcoholUseAssessmentType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JAlcoholUseAssessmentType left, JAlcoholUseAssessmentType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
