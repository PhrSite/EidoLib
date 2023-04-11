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
    public partial class CbrnOperatingScheduleType : IEquatable<CbrnOperatingScheduleType>
    { 
        /// <summary>
        /// A date when a schedule is effective. NIEM reference is cbrn:ScheduleStartDateTime
        /// </summary>
        /// <value>A date when a schedule is effective. NIEM reference is cbrn:ScheduleStartDateTime</value>

        [DataMember(Name="scheduleStartDateTime")]
        public List<NiemXsdateTime> ScheduleStartDateTime { get; set; }

        /// <summary>
        /// A date when the schedule is no longer effective. If not provided, then the end date is considered to be indefinite. The end date, if provided, must be later than the start date. NIEM reference is cbrn:ScheduleEndDateTime
        /// </summary>
        /// <value>A date when the schedule is no longer effective. If not provided, then the end date is considered to be indefinite. The end date, if provided, must be later than the start date. NIEM reference is cbrn:ScheduleEndDateTime</value>

        [DataMember(Name="scheduleEndDateTime")]
        public List<NiemXsdateTime> ScheduleEndDateTime { get; set; }

        /// <summary>
        /// A text identification of the time zone that applies to a schedule. NIEM reference is cbrn:ScheduleTimeZoneText
        /// </summary>
        /// <value>A text identification of the time zone that applies to a schedule. NIEM reference is cbrn:ScheduleTimeZoneText</value>

        [DataMember(Name="scheduleTimeZone")]
        public List<NcTextType> ScheduleTimeZone { get; set; }

        /// <summary>
        /// cbrnOperatingScheduleType JSON-LD context
        /// </summary>
        /// <value>cbrnOperatingScheduleType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextscbrnOperatingScheduleTypeContextJsonldEnum for ../JSON-LD_Contexts/cbrnOperatingScheduleTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/cbrnOperatingScheduleTypeContext.jsonld")]
            JSONLDContextscbrnOperatingScheduleTypeContextJsonldEnum = 0        }

        /// <summary>
        /// cbrnOperatingScheduleType JSON-LD context
        /// </summary>
        /// <value>cbrnOperatingScheduleType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbrnOperatingScheduleType {\n");
            sb.Append("  ScheduleStartDateTime: ").Append(ScheduleStartDateTime).Append("\n");
            sb.Append("  ScheduleEndDateTime: ").Append(ScheduleEndDateTime).Append("\n");
            sb.Append("  ScheduleTimeZone: ").Append(ScheduleTimeZone).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CbrnOperatingScheduleType)obj);
        }

        /// <summary>
        /// Returns true if CbrnOperatingScheduleType instances are equal
        /// </summary>
        /// <param name="other">Instance of CbrnOperatingScheduleType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CbrnOperatingScheduleType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ScheduleStartDateTime == other.ScheduleStartDateTime ||
                    ScheduleStartDateTime != null &&
                    ScheduleStartDateTime.SequenceEqual(other.ScheduleStartDateTime)
                ) && 
                (
                    ScheduleEndDateTime == other.ScheduleEndDateTime ||
                    ScheduleEndDateTime != null &&
                    ScheduleEndDateTime.SequenceEqual(other.ScheduleEndDateTime)
                ) && 
                (
                    ScheduleTimeZone == other.ScheduleTimeZone ||
                    ScheduleTimeZone != null &&
                    ScheduleTimeZone.SequenceEqual(other.ScheduleTimeZone)
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
                    if (ScheduleStartDateTime != null)
                    hashCode = hashCode * 59 + ScheduleStartDateTime.GetHashCode();
                    if (ScheduleEndDateTime != null)
                    hashCode = hashCode * 59 + ScheduleEndDateTime.GetHashCode();
                    if (ScheduleTimeZone != null)
                    hashCode = hashCode * 59 + ScheduleTimeZone.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CbrnOperatingScheduleType left, CbrnOperatingScheduleType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CbrnOperatingScheduleType left, CbrnOperatingScheduleType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
