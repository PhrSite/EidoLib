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
    /// A data type for a sentencing guideline used for determining a sanction.
    /// </summary>
    [DataContract]
    public partial class JSentencingGuidelineType : IEquatable<JSentencingGuidelineType>
    { 
        /// <summary>
        /// A sentencing guideline severity level assigned to a charge by a judge or supervising agency. NIEM reference is j:SentencingGuidelineChargeSeverityLevelText
        /// </summary>
        /// <value>A sentencing guideline severity level assigned to a charge by a judge or supervising agency. NIEM reference is j:SentencingGuidelineChargeSeverityLevelText</value>

        [DataMember(Name="chargeSeverityLevel")]
        public List<NcTextType> ChargeSeverityLevel { get; set; }

        /// <summary>
        /// A maximum sentence, in months, called for by sentencing guidelines. NIEM reference is j:SentencingGuidelineMonthsMaximumText
        /// </summary>
        /// <value>A maximum sentence, in months, called for by sentencing guidelines. NIEM reference is j:SentencingGuidelineMonthsMaximumText</value>

        [DataMember(Name="monthsMaximum")]
        public List<NcTextType> MonthsMaximum { get; set; }

        /// <summary>
        /// A minimum sentence in months, outlined by sentencing guidelines, which can be imposed by a judge without indicating a reason for departure. NIEM reference is j:SentencingGuidelineMonthsMinimumText
        /// </summary>
        /// <value>A minimum sentence in months, outlined by sentencing guidelines, which can be imposed by a judge without indicating a reason for departure. NIEM reference is j:SentencingGuidelineMonthsMinimumText</value>

        [DataMember(Name="monthsMinimum")]
        public List<NcTextType> MonthsMinimum { get; set; }

        /// <summary>
        /// A recommended sentence, in months, called for by sentencing guidelines. NIEM reference is j:SentencingGuidelineRecommendationMonthsText
        /// </summary>
        /// <value>A recommended sentence, in months, called for by sentencing guidelines. NIEM reference is j:SentencingGuidelineRecommendationMonthsText</value>

        [DataMember(Name="recommendationMonths")]
        public List<NcTextType> RecommendationMonths { get; set; }

        /// <summary>
        /// jSentencingGuidelineType JSON-LD context
        /// </summary>
        /// <value>jSentencingGuidelineType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjSentencingGuidelineTypeContextJsonldEnum for ../JSON-LD_Contexts/jSentencingGuidelineTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jSentencingGuidelineTypeContext.jsonld")]
            JSONLDContextsjSentencingGuidelineTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jSentencingGuidelineType JSON-LD context
        /// </summary>
        /// <value>jSentencingGuidelineType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JSentencingGuidelineType {\n");
            sb.Append("  ChargeSeverityLevel: ").Append(ChargeSeverityLevel).Append("\n");
            sb.Append("  MonthsMaximum: ").Append(MonthsMaximum).Append("\n");
            sb.Append("  MonthsMinimum: ").Append(MonthsMinimum).Append("\n");
            sb.Append("  RecommendationMonths: ").Append(RecommendationMonths).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JSentencingGuidelineType)obj);
        }

        /// <summary>
        /// Returns true if JSentencingGuidelineType instances are equal
        /// </summary>
        /// <param name="other">Instance of JSentencingGuidelineType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSentencingGuidelineType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ChargeSeverityLevel == other.ChargeSeverityLevel ||
                    ChargeSeverityLevel != null &&
                    ChargeSeverityLevel.SequenceEqual(other.ChargeSeverityLevel)
                ) && 
                (
                    MonthsMaximum == other.MonthsMaximum ||
                    MonthsMaximum != null &&
                    MonthsMaximum.SequenceEqual(other.MonthsMaximum)
                ) && 
                (
                    MonthsMinimum == other.MonthsMinimum ||
                    MonthsMinimum != null &&
                    MonthsMinimum.SequenceEqual(other.MonthsMinimum)
                ) && 
                (
                    RecommendationMonths == other.RecommendationMonths ||
                    RecommendationMonths != null &&
                    RecommendationMonths.SequenceEqual(other.RecommendationMonths)
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
                    if (ChargeSeverityLevel != null)
                    hashCode = hashCode * 59 + ChargeSeverityLevel.GetHashCode();
                    if (MonthsMaximum != null)
                    hashCode = hashCode * 59 + MonthsMaximum.GetHashCode();
                    if (MonthsMinimum != null)
                    hashCode = hashCode * 59 + MonthsMinimum.GetHashCode();
                    if (RecommendationMonths != null)
                    hashCode = hashCode * 59 + RecommendationMonths.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JSentencingGuidelineType left, JSentencingGuidelineType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JSentencingGuidelineType left, JSentencingGuidelineType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
