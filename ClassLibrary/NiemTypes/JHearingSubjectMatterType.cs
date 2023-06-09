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
    /// A data type for a set of details and subject matter central to a hearing process.
    /// </summary>
    [DataContract]
    public partial class JHearingSubjectMatterType : IEquatable<JHearingSubjectMatterType>
    { 
        /// <summary>
        /// A description of the reason a subject matter is off the calendar. NIEM reference is j:HearingSubjectOffMatterReasonText
        /// </summary>
        /// <value>A description of the reason a subject matter is off the calendar. NIEM reference is j:HearingSubjectOffMatterReasonText</value>

        [DataMember(Name="hearingSubjectOffMatterReason")]
        public List<NcTextType> HearingSubjectOffMatterReason { get; set; }

        /// <summary>
        /// A kind of regarded subject matter for a hearing. NIEM reference is j:HearingSubjectMatterCategoryText
        /// </summary>
        /// <value>A kind of regarded subject matter for a hearing. NIEM reference is j:HearingSubjectMatterCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A period of time in which another off matter subject can be continued. NIEM reference is j:HearingSubjectOffMatterNotToExceedTimeText
        /// </summary>
        /// <value>A period of time in which another off matter subject can be continued. NIEM reference is j:HearingSubjectOffMatterNotToExceedTimeText</value>

        [DataMember(Name="hearingSubjectOffMatterNotToExceedTime")]
        public List<NcTextType> HearingSubjectOffMatterNotToExceedTime { get; set; }

        /// <summary>
        /// A set of details on the other issue that is keeping this matter off calendar. NIEM reference is j:HearingSubjectOffMatterOtherReasonText
        /// </summary>
        /// <value>A set of details on the other issue that is keeping this matter off calendar. NIEM reference is j:HearingSubjectOffMatterOtherReasonText</value>

        [DataMember(Name="hearingSubjectOffMatterOtherReason")]
        public List<NcTextType> HearingSubjectOffMatterOtherReason { get; set; }

        /// <summary>
        /// True if a matter is off calendar; false otherwise. NIEM reference is j:HearingSubjectMatterOffCalendarIndicator
        /// </summary>
        /// <value>True if a matter is off calendar; false otherwise. NIEM reference is j:HearingSubjectMatterOffCalendarIndicator</value>

        [DataMember(Name="isOffCalendar")]
        public List<NiemXsboolean> IsOffCalendar { get; set; }

        /// <summary>
        /// jHearingSubjectMatterType JSON-LD context
        /// </summary>
        /// <value>jHearingSubjectMatterType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjHearingSubjectMatterTypeContextJsonldEnum for ../JSON-LD_Contexts/jHearingSubjectMatterTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jHearingSubjectMatterTypeContext.jsonld")]
            JSONLDContextsjHearingSubjectMatterTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jHearingSubjectMatterType JSON-LD context
        /// </summary>
        /// <value>jHearingSubjectMatterType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JHearingSubjectMatterType {\n");
            sb.Append("  HearingSubjectOffMatterReason: ").Append(HearingSubjectOffMatterReason).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  HearingSubjectOffMatterNotToExceedTime: ").Append(HearingSubjectOffMatterNotToExceedTime).Append("\n");
            sb.Append("  HearingSubjectOffMatterOtherReason: ").Append(HearingSubjectOffMatterOtherReason).Append("\n");
            sb.Append("  IsOffCalendar: ").Append(IsOffCalendar).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JHearingSubjectMatterType)obj);
        }

        /// <summary>
        /// Returns true if JHearingSubjectMatterType instances are equal
        /// </summary>
        /// <param name="other">Instance of JHearingSubjectMatterType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JHearingSubjectMatterType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HearingSubjectOffMatterReason == other.HearingSubjectOffMatterReason ||
                    HearingSubjectOffMatterReason != null &&
                    HearingSubjectOffMatterReason.SequenceEqual(other.HearingSubjectOffMatterReason)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    HearingSubjectOffMatterNotToExceedTime == other.HearingSubjectOffMatterNotToExceedTime ||
                    HearingSubjectOffMatterNotToExceedTime != null &&
                    HearingSubjectOffMatterNotToExceedTime.SequenceEqual(other.HearingSubjectOffMatterNotToExceedTime)
                ) && 
                (
                    HearingSubjectOffMatterOtherReason == other.HearingSubjectOffMatterOtherReason ||
                    HearingSubjectOffMatterOtherReason != null &&
                    HearingSubjectOffMatterOtherReason.SequenceEqual(other.HearingSubjectOffMatterOtherReason)
                ) && 
                (
                    IsOffCalendar == other.IsOffCalendar ||
                    IsOffCalendar != null &&
                    IsOffCalendar.SequenceEqual(other.IsOffCalendar)
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
                    if (HearingSubjectOffMatterReason != null)
                    hashCode = hashCode * 59 + HearingSubjectOffMatterReason.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (HearingSubjectOffMatterNotToExceedTime != null)
                    hashCode = hashCode * 59 + HearingSubjectOffMatterNotToExceedTime.GetHashCode();
                    if (HearingSubjectOffMatterOtherReason != null)
                    hashCode = hashCode * 59 + HearingSubjectOffMatterOtherReason.GetHashCode();
                    if (IsOffCalendar != null)
                    hashCode = hashCode * 59 + IsOffCalendar.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JHearingSubjectMatterType left, JHearingSubjectMatterType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JHearingSubjectMatterType left, JHearingSubjectMatterType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
