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
    /// A data type for a set of details about actions or events involving involuntary medication of a subject.
    /// </summary>
    [DataContract]
    public partial class JInvoluntaryMedicationActionType : NcActivityType, IEquatable<JInvoluntaryMedicationActionType>
    { 
        /// <summary>
        /// A kind of reason a subject was placed on involuntary medication. NIEM reference is j:InvoluntaryMedicationActionMedicationReasonText
        /// </summary>
        /// <value>A kind of reason a subject was placed on involuntary medication. NIEM reference is j:InvoluntaryMedicationActionMedicationReasonText</value>

        [DataMember(Name="medicationReason")]
        public List<NcTextType> MedicationReason { get; set; }

        /// <summary>
        /// True if evidence included additional documents; false otherwise. NIEM reference is j:InvoluntaryMedicationActionEvidenceIncludedIndicator
        /// </summary>
        /// <value>True if evidence included additional documents; false otherwise. NIEM reference is j:InvoluntaryMedicationActionEvidenceIncludedIndicator</value>

        [DataMember(Name="isEvidenceIncluded")]
        public List<NiemXsboolean> IsEvidenceIncluded { get; set; }

        /// <summary>
        /// A date when a schedule of involuntary medication for a subject will end. NIEM reference is j:InvoluntaryMedicationActionEndDate
        /// </summary>
        /// <value>A date when a schedule of involuntary medication for a subject will end. NIEM reference is j:InvoluntaryMedicationActionEndDate</value>

        [DataMember(Name="endDate")]
        public List<NcDateType> EndDate { get; set; }

        /// <summary>
        /// jInvoluntaryMedicationActionType JSON-LD context
        /// </summary>
        /// <value>jInvoluntaryMedicationActionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjInvoluntaryMedicationActionTypeContextJsonldEnum for ../JSON-LD_Contexts/jInvoluntaryMedicationActionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jInvoluntaryMedicationActionTypeContext.jsonld")]
            JSONLDContextsjInvoluntaryMedicationActionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jInvoluntaryMedicationActionType JSON-LD context
        /// </summary>
        /// <value>jInvoluntaryMedicationActionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JInvoluntaryMedicationActionType {\n");
            sb.Append("  MedicationReason: ").Append(MedicationReason).Append("\n");
            sb.Append("  IsEvidenceIncluded: ").Append(IsEvidenceIncluded).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JInvoluntaryMedicationActionType)obj);
        }

        /// <summary>
        /// Returns true if JInvoluntaryMedicationActionType instances are equal
        /// </summary>
        /// <param name="other">Instance of JInvoluntaryMedicationActionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JInvoluntaryMedicationActionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MedicationReason == other.MedicationReason ||
                    MedicationReason != null &&
                    MedicationReason.SequenceEqual(other.MedicationReason)
                ) && 
                (
                    IsEvidenceIncluded == other.IsEvidenceIncluded ||
                    IsEvidenceIncluded != null &&
                    IsEvidenceIncluded.SequenceEqual(other.IsEvidenceIncluded)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.SequenceEqual(other.EndDate)
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
                    if (MedicationReason != null)
                    hashCode = hashCode * 59 + MedicationReason.GetHashCode();
                    if (IsEvidenceIncluded != null)
                    hashCode = hashCode * 59 + IsEvidenceIncluded.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JInvoluntaryMedicationActionType left, JInvoluntaryMedicationActionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JInvoluntaryMedicationActionType left, JInvoluntaryMedicationActionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}