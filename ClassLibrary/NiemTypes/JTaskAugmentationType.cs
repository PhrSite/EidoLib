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
    /// A data type for additional information about a task.
    /// </summary>
    [DataContract]
    public partial class JTaskAugmentationType : IEquatable<JTaskAugmentationType>
    { 
        /// <summary>
        /// A count reflecting the estimated number of hours dedicated each day to an assigned task. NIEM reference is j:TaskHoursPerDayQuantity
        /// </summary>
        /// <value>A count reflecting the estimated number of hours dedicated each day to an assigned task. NIEM reference is j:TaskHoursPerDayQuantity</value>

        [DataMember(Name="taskHoursPerDayQuantity")]
        public List<NcQuantityType> TaskHoursPerDayQuantity { get; set; }

        /// <summary>
        /// A date that the subject was referred to a provider to receive help in completing the Task. NIEM reference is j:TaskReferralDate
        /// </summary>
        /// <value>A date that the subject was referred to a provider to receive help in completing the Task. NIEM reference is j:TaskReferralDate</value>

        [DataMember(Name="taskReferralDate")]
        public List<NcDateType> TaskReferralDate { get; set; }

        /// <summary>
        /// A count reflecting the estimated number of days prior to the completion of a task. NIEM reference is j:TaskEstimatedDaysToCompletedQuantity
        /// </summary>
        /// <value>A count reflecting the estimated number of days prior to the completion of a task. NIEM reference is j:TaskEstimatedDaysToCompletedQuantity</value>

        [DataMember(Name="taskEstimatedDaysToCompletedQuantity")]
        public List<NcQuantityType> TaskEstimatedDaysToCompletedQuantity { get; set; }

        /// <summary>
        /// A description of a kind of outcome of a completed task. NIEM reference is j:TaskCompletionDescriptionText
        /// </summary>
        /// <value>A description of a kind of outcome of a completed task. NIEM reference is j:TaskCompletionDescriptionText</value>

        [DataMember(Name="taskCompletionDescription")]
        public List<NcTextType> TaskCompletionDescription { get; set; }

        /// <summary>
        /// A name of a person or entity providing assistance to an assigned task. NIEM reference is j:TaskAssistanceProvider
        /// </summary>
        /// <value>A name of a person or entity providing assistance to an assigned task. NIEM reference is j:TaskAssistanceProvider</value>

        [DataMember(Name="taskAssistanceProvider")]
        public List<NcEntityType> TaskAssistanceProvider { get; set; }

        /// <summary>
        /// An identifier for a task. NIEM reference is nc:TaskID
        /// </summary>
        /// <value>An identifier for a task. NIEM reference is nc:TaskID</value>

        [DataMember(Name="taskId")]
        public List<NiemXsstring> TaskId { get; set; }

        /// <summary>
        /// jTaskAugmentationType JSON-LD context
        /// </summary>
        /// <value>jTaskAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjTaskAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/jTaskAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jTaskAugmentationTypeContext.jsonld")]
            JSONLDContextsjTaskAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jTaskAugmentationType JSON-LD context
        /// </summary>
        /// <value>jTaskAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JTaskAugmentationType {\n");
            sb.Append("  TaskHoursPerDayQuantity: ").Append(TaskHoursPerDayQuantity).Append("\n");
            sb.Append("  TaskReferralDate: ").Append(TaskReferralDate).Append("\n");
            sb.Append("  TaskEstimatedDaysToCompletedQuantity: ").Append(TaskEstimatedDaysToCompletedQuantity).Append("\n");
            sb.Append("  TaskCompletionDescription: ").Append(TaskCompletionDescription).Append("\n");
            sb.Append("  TaskAssistanceProvider: ").Append(TaskAssistanceProvider).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JTaskAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if JTaskAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of JTaskAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JTaskAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TaskHoursPerDayQuantity == other.TaskHoursPerDayQuantity ||
                    TaskHoursPerDayQuantity != null &&
                    TaskHoursPerDayQuantity.SequenceEqual(other.TaskHoursPerDayQuantity)
                ) && 
                (
                    TaskReferralDate == other.TaskReferralDate ||
                    TaskReferralDate != null &&
                    TaskReferralDate.SequenceEqual(other.TaskReferralDate)
                ) && 
                (
                    TaskEstimatedDaysToCompletedQuantity == other.TaskEstimatedDaysToCompletedQuantity ||
                    TaskEstimatedDaysToCompletedQuantity != null &&
                    TaskEstimatedDaysToCompletedQuantity.SequenceEqual(other.TaskEstimatedDaysToCompletedQuantity)
                ) && 
                (
                    TaskCompletionDescription == other.TaskCompletionDescription ||
                    TaskCompletionDescription != null &&
                    TaskCompletionDescription.SequenceEqual(other.TaskCompletionDescription)
                ) && 
                (
                    TaskAssistanceProvider == other.TaskAssistanceProvider ||
                    TaskAssistanceProvider != null &&
                    TaskAssistanceProvider.SequenceEqual(other.TaskAssistanceProvider)
                ) && 
                (
                    TaskId == other.TaskId ||
                    TaskId != null &&
                    TaskId.SequenceEqual(other.TaskId)
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
                    if (TaskHoursPerDayQuantity != null)
                    hashCode = hashCode * 59 + TaskHoursPerDayQuantity.GetHashCode();
                    if (TaskReferralDate != null)
                    hashCode = hashCode * 59 + TaskReferralDate.GetHashCode();
                    if (TaskEstimatedDaysToCompletedQuantity != null)
                    hashCode = hashCode * 59 + TaskEstimatedDaysToCompletedQuantity.GetHashCode();
                    if (TaskCompletionDescription != null)
                    hashCode = hashCode * 59 + TaskCompletionDescription.GetHashCode();
                    if (TaskAssistanceProvider != null)
                    hashCode = hashCode * 59 + TaskAssistanceProvider.GetHashCode();
                    if (TaskId != null)
                    hashCode = hashCode * 59 + TaskId.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JTaskAugmentationType left, JTaskAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JTaskAugmentationType left, JTaskAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}