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
    /// A data type for a schedule where the hours are the same for all weekdays.
    /// </summary>
    [DataContract]
    public partial class CbrnScheduleByWeekType : CbrnRemarksComplexObjectType, IEquatable<CbrnScheduleByWeekType>
    { 
        /// <summary>
        /// A text description of the normal weekend operating hours. NIEM reference is cbrn:WeekEndHoursText
        /// </summary>
        /// <value>A text description of the normal weekend operating hours. NIEM reference is cbrn:WeekEndHoursText</value>

        [DataMember(Name="weekEndHours")]
        public List<NcTextType> WeekEndHours { get; set; }

        /// <summary>
        /// A text description of the normal weekday operating hours. NIEM reference is cbrn:WeekDayHoursText
        /// </summary>
        /// <value>A text description of the normal weekday operating hours. NIEM reference is cbrn:WeekDayHoursText</value>

        [DataMember(Name="weekDayHours")]
        public List<NcTextType> WeekDayHours { get; set; }

        /// <summary>
        /// cbrnScheduleByWeekType JSON-LD context
        /// </summary>
        /// <value>cbrnScheduleByWeekType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextscbrnScheduleByWeekTypeContextJsonldEnum for ../JSON-LD_Contexts/cbrnScheduleByWeekTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/cbrnScheduleByWeekTypeContext.jsonld")]
            JSONLDContextscbrnScheduleByWeekTypeContextJsonldEnum = 0        }

        /// <summary>
        /// cbrnScheduleByWeekType JSON-LD context
        /// </summary>
        /// <value>cbrnScheduleByWeekType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbrnScheduleByWeekType {\n");
            sb.Append("  WeekEndHours: ").Append(WeekEndHours).Append("\n");
            sb.Append("  WeekDayHours: ").Append(WeekDayHours).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CbrnScheduleByWeekType)obj);
        }

        /// <summary>
        /// Returns true if CbrnScheduleByWeekType instances are equal
        /// </summary>
        /// <param name="other">Instance of CbrnScheduleByWeekType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CbrnScheduleByWeekType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    WeekEndHours == other.WeekEndHours ||
                    WeekEndHours != null &&
                    WeekEndHours.SequenceEqual(other.WeekEndHours)
                ) && 
                (
                    WeekDayHours == other.WeekDayHours ||
                    WeekDayHours != null &&
                    WeekDayHours.SequenceEqual(other.WeekDayHours)
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
                    if (WeekEndHours != null)
                    hashCode = hashCode * 59 + WeekEndHours.GetHashCode();
                    if (WeekDayHours != null)
                    hashCode = hashCode * 59 + WeekDayHours.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CbrnScheduleByWeekType left, CbrnScheduleByWeekType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CbrnScheduleByWeekType left, CbrnScheduleByWeekType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
