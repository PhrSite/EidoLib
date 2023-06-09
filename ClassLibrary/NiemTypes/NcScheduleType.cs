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
    /// A data type for a schedule providing the beginning and ending hours of operation by weekday, for a designated time period.
    /// </summary>
    [DataContract]
    public partial class NcScheduleType : IEquatable<NcScheduleType>
    { 
        /// <summary>
        /// An overall status for the schedule. NIEM reference is nc:ScheduleStatus
        /// </summary>
        /// <value>An overall status for the schedule. NIEM reference is nc:ScheduleStatus</value>

        [DataMember(Name="status")]
        public List<NcStatusType> Status { get; set; }

        /// <summary>
        /// A description of the schedule. NIEM reference is nc:ScheduleDescriptionText
        /// </summary>
        /// <value>A description of the schedule. NIEM reference is nc:ScheduleDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A description of special exceptions to the given schedule, such as holiday hours or closings. NIEM reference is nc:ScheduleExceptionsDescriptionText
        /// </summary>
        /// <value>A description of special exceptions to the given schedule, such as holiday hours or closings. NIEM reference is nc:ScheduleExceptionsDescriptionText</value>

        [DataMember(Name="exceptionsDescription")]
        public List<NcTextType> ExceptionsDescription { get; set; }

        /// <summary>
        /// True if the schedule applies 24 hours a day, 7 days a week; false otherwise. NIEM reference is nc:ScheduleNonStopIndicator
        /// </summary>
        /// <value>True if the schedule applies 24 hours a day, 7 days a week; false otherwise. NIEM reference is nc:ScheduleNonStopIndicator</value>

        [DataMember(Name="isNonStop")]
        public List<NiemXsboolean> IsNonStop { get; set; }

        /// <summary>
        /// A plan or agenda for the activities of a day or dates. NIEM reference is nc:ScheduleDay
        /// </summary>
        /// <value>A plan or agenda for the activities of a day or dates. NIEM reference is nc:ScheduleDay</value>

        [DataMember(Name="day")]
        public List<NcScheduleDayType> Day { get; set; }

        /// <summary>
        /// A schedule providing the beginning and ending hours of operation by weekday, for a designated time period. NIEM reference is cbrn:OperatingSchedule
        /// </summary>
        /// <value>A schedule providing the beginning and ending hours of operation by weekday, for a designated time period. NIEM reference is cbrn:OperatingSchedule</value>

        [DataMember(Name="operating")]
        public List<CbrnOperatingScheduleType> Operating { get; set; }

        /// <summary>
        /// ncScheduleType JSON-LD context
        /// </summary>
        /// <value>ncScheduleType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncScheduleTypeContextJsonldEnum for ../JSON-LD_Contexts/ncScheduleTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncScheduleTypeContext.jsonld")]
            JSONLDContextsncScheduleTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncScheduleType JSON-LD context
        /// </summary>
        /// <value>ncScheduleType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcScheduleType {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExceptionsDescription: ").Append(ExceptionsDescription).Append("\n");
            sb.Append("  IsNonStop: ").Append(IsNonStop).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Operating: ").Append(Operating).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcScheduleType)obj);
        }

        /// <summary>
        /// Returns true if NcScheduleType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcScheduleType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcScheduleType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.SequenceEqual(other.Status)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    ExceptionsDescription == other.ExceptionsDescription ||
                    ExceptionsDescription != null &&
                    ExceptionsDescription.SequenceEqual(other.ExceptionsDescription)
                ) && 
                (
                    IsNonStop == other.IsNonStop ||
                    IsNonStop != null &&
                    IsNonStop.SequenceEqual(other.IsNonStop)
                ) && 
                (
                    Day == other.Day ||
                    Day != null &&
                    Day.SequenceEqual(other.Day)
                ) && 
                (
                    Operating == other.Operating ||
                    Operating != null &&
                    Operating.SequenceEqual(other.Operating)
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
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ExceptionsDescription != null)
                    hashCode = hashCode * 59 + ExceptionsDescription.GetHashCode();
                    if (IsNonStop != null)
                    hashCode = hashCode * 59 + IsNonStop.GetHashCode();
                    if (Day != null)
                    hashCode = hashCode * 59 + Day.GetHashCode();
                    if (Operating != null)
                    hashCode = hashCode * 59 + Operating.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcScheduleType left, NcScheduleType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcScheduleType left, NcScheduleType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
