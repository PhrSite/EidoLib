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
    /// A data type for a set of details about a subject&#x27;s supervision history.
    /// </summary>
    [DataContract]
    public partial class JSupervisionHistoryType : IEquatable<JSupervisionHistoryType>
    { 
        /// <summary>
        /// True if the offender has been continuously held in minimum custody during the review period; false otherwise. NIEM reference is j:SupervisionHistoryContinuousMinimumCustodyIndicator
        /// </summary>
        /// <value>True if the offender has been continuously held in minimum custody during the review period; false otherwise. NIEM reference is j:SupervisionHistoryContinuousMinimumCustodyIndicator</value>

        [DataMember(Name="isContinuousMinimumCustody")]
        public List<NiemXsboolean> IsContinuousMinimumCustody { get; set; }

        /// <summary>
        /// A set of details about a subject&#x27;s supervision offense. NIEM reference is j:SupervisionHistorySupervisionOffense
        /// </summary>
        /// <value>A set of details about a subject&#x27;s supervision offense. NIEM reference is j:SupervisionHistorySupervisionOffense</value>

        [DataMember(Name="supervisionOffense")]
        public List<JOffenseType> SupervisionOffense { get; set; }

        /// <summary>
        /// A narrative detailing the subject&#x27;s history of aggression. NIEM reference is j:SupervisionHistoryAggressionNarrativeText
        /// </summary>
        /// <value>A narrative detailing the subject&#x27;s history of aggression. NIEM reference is j:SupervisionHistoryAggressionNarrativeText</value>

        [DataMember(Name="aggressionNarrative")]
        public List<NcTextType> AggressionNarrative { get; set; }

        /// <summary>
        /// True if the offender has had no serious disciplinary violations during the review period; false otherwise. NIEM reference is j:SupervisionHistoryNoSeriousDisciplinaryViolationsIndicator
        /// </summary>
        /// <value>True if the offender has had no serious disciplinary violations during the review period; false otherwise. NIEM reference is j:SupervisionHistoryNoSeriousDisciplinaryViolationsIndicator</value>

        [DataMember(Name="isNoSeriousDisciplinaryViolations")]
        public List<NiemXsboolean> IsNoSeriousDisciplinaryViolations { get; set; }

        /// <summary>
        /// A numerical score based on an instrument or assessment tool (e.g. Vera Institute) for the purpose of classification and assignment. NIEM reference is j:SupervisionHistoryClassificationScore
        /// </summary>
        /// <value>A numerical score based on an instrument or assessment tool (e.g. Vera Institute) for the purpose of classification and assignment. NIEM reference is j:SupervisionHistoryClassificationScore</value>

        [DataMember(Name="classificationScore")]
        public List<NcAmountType> ClassificationScore { get; set; }

        /// <summary>
        /// A kind of aggression classification of subject based of their supervision history. NIEM reference is j:SupervisionHistoryAggressionText
        /// </summary>
        /// <value>A kind of aggression classification of subject based of their supervision history. NIEM reference is j:SupervisionHistoryAggressionText</value>

        [DataMember(Name="aggression")]
        public List<NcTextType> Aggression { get; set; }

        /// <summary>
        /// A number of total unfavorable incarceration behavior points based on the period since the last classification review. NIEM reference is j:SupervisionHistoryTotalUnfavorablePointsNumeric
        /// </summary>
        /// <value>A number of total unfavorable incarceration behavior points based on the period since the last classification review. NIEM reference is j:SupervisionHistoryTotalUnfavorablePointsNumeric</value>

        [DataMember(Name="totalUnfavorablePointsNumeric")]
        public List<NcNumericType> TotalUnfavorablePointsNumeric { get; set; }

        /// <summary>
        /// A number of total favorable incarceration behavior points based on the review period. NIEM reference is j:SupervisionHistoryTotalFavorablePointsNumeric
        /// </summary>
        /// <value>A number of total favorable incarceration behavior points based on the review period. NIEM reference is j:SupervisionHistoryTotalFavorablePointsNumeric</value>

        [DataMember(Name="totalFavorablePointsNumeric")]
        public List<NcNumericType> TotalFavorablePointsNumeric { get; set; }

        /// <summary>
        /// jSupervisionHistoryType JSON-LD context
        /// </summary>
        /// <value>jSupervisionHistoryType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjSupervisionHistoryTypeContextJsonldEnum for ../JSON-LD_Contexts/jSupervisionHistoryTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jSupervisionHistoryTypeContext.jsonld")]
            JSONLDContextsjSupervisionHistoryTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jSupervisionHistoryType JSON-LD context
        /// </summary>
        /// <value>jSupervisionHistoryType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JSupervisionHistoryType {\n");
            sb.Append("  IsContinuousMinimumCustody: ").Append(IsContinuousMinimumCustody).Append("\n");
            sb.Append("  SupervisionOffense: ").Append(SupervisionOffense).Append("\n");
            sb.Append("  AggressionNarrative: ").Append(AggressionNarrative).Append("\n");
            sb.Append("  IsNoSeriousDisciplinaryViolations: ").Append(IsNoSeriousDisciplinaryViolations).Append("\n");
            sb.Append("  ClassificationScore: ").Append(ClassificationScore).Append("\n");
            sb.Append("  Aggression: ").Append(Aggression).Append("\n");
            sb.Append("  TotalUnfavorablePointsNumeric: ").Append(TotalUnfavorablePointsNumeric).Append("\n");
            sb.Append("  TotalFavorablePointsNumeric: ").Append(TotalFavorablePointsNumeric).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JSupervisionHistoryType)obj);
        }

        /// <summary>
        /// Returns true if JSupervisionHistoryType instances are equal
        /// </summary>
        /// <param name="other">Instance of JSupervisionHistoryType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSupervisionHistoryType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsContinuousMinimumCustody == other.IsContinuousMinimumCustody ||
                    IsContinuousMinimumCustody != null &&
                    IsContinuousMinimumCustody.SequenceEqual(other.IsContinuousMinimumCustody)
                ) && 
                (
                    SupervisionOffense == other.SupervisionOffense ||
                    SupervisionOffense != null &&
                    SupervisionOffense.SequenceEqual(other.SupervisionOffense)
                ) && 
                (
                    AggressionNarrative == other.AggressionNarrative ||
                    AggressionNarrative != null &&
                    AggressionNarrative.SequenceEqual(other.AggressionNarrative)
                ) && 
                (
                    IsNoSeriousDisciplinaryViolations == other.IsNoSeriousDisciplinaryViolations ||
                    IsNoSeriousDisciplinaryViolations != null &&
                    IsNoSeriousDisciplinaryViolations.SequenceEqual(other.IsNoSeriousDisciplinaryViolations)
                ) && 
                (
                    ClassificationScore == other.ClassificationScore ||
                    ClassificationScore != null &&
                    ClassificationScore.SequenceEqual(other.ClassificationScore)
                ) && 
                (
                    Aggression == other.Aggression ||
                    Aggression != null &&
                    Aggression.SequenceEqual(other.Aggression)
                ) && 
                (
                    TotalUnfavorablePointsNumeric == other.TotalUnfavorablePointsNumeric ||
                    TotalUnfavorablePointsNumeric != null &&
                    TotalUnfavorablePointsNumeric.SequenceEqual(other.TotalUnfavorablePointsNumeric)
                ) && 
                (
                    TotalFavorablePointsNumeric == other.TotalFavorablePointsNumeric ||
                    TotalFavorablePointsNumeric != null &&
                    TotalFavorablePointsNumeric.SequenceEqual(other.TotalFavorablePointsNumeric)
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
                    if (IsContinuousMinimumCustody != null)
                    hashCode = hashCode * 59 + IsContinuousMinimumCustody.GetHashCode();
                    if (SupervisionOffense != null)
                    hashCode = hashCode * 59 + SupervisionOffense.GetHashCode();
                    if (AggressionNarrative != null)
                    hashCode = hashCode * 59 + AggressionNarrative.GetHashCode();
                    if (IsNoSeriousDisciplinaryViolations != null)
                    hashCode = hashCode * 59 + IsNoSeriousDisciplinaryViolations.GetHashCode();
                    if (ClassificationScore != null)
                    hashCode = hashCode * 59 + ClassificationScore.GetHashCode();
                    if (Aggression != null)
                    hashCode = hashCode * 59 + Aggression.GetHashCode();
                    if (TotalUnfavorablePointsNumeric != null)
                    hashCode = hashCode * 59 + TotalUnfavorablePointsNumeric.GetHashCode();
                    if (TotalFavorablePointsNumeric != null)
                    hashCode = hashCode * 59 + TotalFavorablePointsNumeric.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JSupervisionHistoryType left, JSupervisionHistoryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JSupervisionHistoryType left, JSupervisionHistoryType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
