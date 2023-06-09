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
    /// A data type lists highly-detailed timings within the voice recording of specific audio segments of interest.
    /// </summary>
    [DataContract]
    public partial class BiomContentDiaryInformationType : BiomDiaryInformationType, IEquatable<BiomContentDiaryInformationType>
    { 
        /// <summary>
        /// A start date/time tagged on the original, contemporaneous capture of the voice recording in the segment identified. NIEM reference is biom:TagStartDateTime
        /// </summary>
        /// <value>A start date/time tagged on the original, contemporaneous capture of the voice recording in the segment identified. NIEM reference is biom:TagStartDateTime</value>

        [DataMember(Name="tagStartDateTime")]
        public List<NcDateType> TagStartDateTime { get; set; }

        /// <summary>
        /// An end date/time tagged on the original, contemporaneous capture of the voice data at the end of the segment identified. NIEM reference is biom:TagEndDateTime
        /// </summary>
        /// <value>An end date/time tagged on the original, contemporaneous capture of the voice data at the end of the segment identified. NIEM reference is biom:TagEndDateTime</value>

        [DataMember(Name="tagEndDateTime")]
        public List<NiemXsdateTime> TagEndDateTime { get; set; }

        /// <summary>
        /// A date for the original, contemporaneous capture of the voice data in the segment identified NIEM reference is biom:OriginalRecordingDate
        /// </summary>
        /// <value>A date for the original, contemporaneous capture of the voice data in the segment identified NIEM reference is biom:OriginalRecordingDate</value>

        [DataMember(Name="originalRecordingDate")]
        public List<NcDateType> OriginalRecordingDate { get; set; }

        /// <summary>
        /// A local start time of the original, contemporaneous capture of the voice recording in the segment identified. NIEM reference is biom:SegmentRecordingStartDateTime
        /// </summary>
        /// <value>A local start time of the original, contemporaneous capture of the voice recording in the segment identified. NIEM reference is biom:SegmentRecordingStartDateTime</value>

        [DataMember(Name="segmentRecordingStartDateTime")]
        public List<NiemXsdateTime> SegmentRecordingStartDateTime { get; set; }

        /// <summary>
        /// A local end time of the original, contemporaneous capture of the voice recording in the segment identified. NIEM reference is biom:SegmentRecordingEndDateTime
        /// </summary>
        /// <value>A local end time of the original, contemporaneous capture of the voice recording in the segment identified. NIEM reference is biom:SegmentRecordingEndDateTime</value>

        [DataMember(Name="segmentRecordingEndDateTime")]
        public List<NiemXsdateTime> SegmentRecordingEndDateTime { get; set; }

        /// <summary>
        /// A description of the source of the date and time values used for the contemporaneous capture of the recording. NIEM reference is biom:TimeSourceDescriptionText
        /// </summary>
        /// <value>A description of the source of the date and time values used for the contemporaneous capture of the recording. NIEM reference is biom:TimeSourceDescriptionText</value>

        [DataMember(Name="timeSourceDescription")]
        public List<NcTextType> TimeSourceDescription { get; set; }

        /// <summary>
        /// A comment on the timings of the segment recording, including the perceived accuracy of the contemporaneous capture time values. NIEM reference is biom:TimeCommentText
        /// </summary>
        /// <value>A comment on the timings of the segment recording, including the perceived accuracy of the contemporaneous capture time values. NIEM reference is biom:TimeCommentText</value>

        [DataMember(Name="timeComment")]
        public List<NcTextType> TimeComment { get; set; }

        /// <summary>
        /// biomContentDiaryInformationType JSON-LD context
        /// </summary>
        /// <value>biomContentDiaryInformationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomContentDiaryInformationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomContentDiaryInformationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomContentDiaryInformationTypeContext.jsonld")]
            JSONLDContextsbiomContentDiaryInformationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomContentDiaryInformationType JSON-LD context
        /// </summary>
        /// <value>biomContentDiaryInformationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomContentDiaryInformationType {\n");
            sb.Append("  TagStartDateTime: ").Append(TagStartDateTime).Append("\n");
            sb.Append("  TagEndDateTime: ").Append(TagEndDateTime).Append("\n");
            sb.Append("  OriginalRecordingDate: ").Append(OriginalRecordingDate).Append("\n");
            sb.Append("  SegmentRecordingStartDateTime: ").Append(SegmentRecordingStartDateTime).Append("\n");
            sb.Append("  SegmentRecordingEndDateTime: ").Append(SegmentRecordingEndDateTime).Append("\n");
            sb.Append("  TimeSourceDescription: ").Append(TimeSourceDescription).Append("\n");
            sb.Append("  TimeComment: ").Append(TimeComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomContentDiaryInformationType)obj);
        }

        /// <summary>
        /// Returns true if BiomContentDiaryInformationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomContentDiaryInformationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomContentDiaryInformationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TagStartDateTime == other.TagStartDateTime ||
                    TagStartDateTime != null &&
                    TagStartDateTime.SequenceEqual(other.TagStartDateTime)
                ) && 
                (
                    TagEndDateTime == other.TagEndDateTime ||
                    TagEndDateTime != null &&
                    TagEndDateTime.SequenceEqual(other.TagEndDateTime)
                ) && 
                (
                    OriginalRecordingDate == other.OriginalRecordingDate ||
                    OriginalRecordingDate != null &&
                    OriginalRecordingDate.SequenceEqual(other.OriginalRecordingDate)
                ) && 
                (
                    SegmentRecordingStartDateTime == other.SegmentRecordingStartDateTime ||
                    SegmentRecordingStartDateTime != null &&
                    SegmentRecordingStartDateTime.SequenceEqual(other.SegmentRecordingStartDateTime)
                ) && 
                (
                    SegmentRecordingEndDateTime == other.SegmentRecordingEndDateTime ||
                    SegmentRecordingEndDateTime != null &&
                    SegmentRecordingEndDateTime.SequenceEqual(other.SegmentRecordingEndDateTime)
                ) && 
                (
                    TimeSourceDescription == other.TimeSourceDescription ||
                    TimeSourceDescription != null &&
                    TimeSourceDescription.SequenceEqual(other.TimeSourceDescription)
                ) && 
                (
                    TimeComment == other.TimeComment ||
                    TimeComment != null &&
                    TimeComment.SequenceEqual(other.TimeComment)
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
                    if (TagStartDateTime != null)
                    hashCode = hashCode * 59 + TagStartDateTime.GetHashCode();
                    if (TagEndDateTime != null)
                    hashCode = hashCode * 59 + TagEndDateTime.GetHashCode();
                    if (OriginalRecordingDate != null)
                    hashCode = hashCode * 59 + OriginalRecordingDate.GetHashCode();
                    if (SegmentRecordingStartDateTime != null)
                    hashCode = hashCode * 59 + SegmentRecordingStartDateTime.GetHashCode();
                    if (SegmentRecordingEndDateTime != null)
                    hashCode = hashCode * 59 + SegmentRecordingEndDateTime.GetHashCode();
                    if (TimeSourceDescription != null)
                    hashCode = hashCode * 59 + TimeSourceDescription.GetHashCode();
                    if (TimeComment != null)
                    hashCode = hashCode * 59 + TimeComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomContentDiaryInformationType left, BiomContentDiaryInformationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomContentDiaryInformationType left, BiomContentDiaryInformationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
