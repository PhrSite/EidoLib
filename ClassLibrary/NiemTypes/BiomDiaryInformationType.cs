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
    /// A data type that lists basic information and timings within the voice recording of interest.
    /// </summary>
    [DataContract]
    public partial class BiomDiaryInformationType : IEquatable<BiomDiaryInformationType>
    { 
        /// <summary>
        /// An identifier for a specific time segment. NIEM reference is biom:SegmentID
        /// </summary>
        /// <value>An identifier for a specific time segment. NIEM reference is biom:SegmentID</value>

        [DataMember(Name="segmentId")]
        public List<NiemXspositiveInteger> SegmentId { get; set; }

        /// <summary>
        /// A list of track IDs for track and channel number list NIEM reference is biom:TrackChannelList
        /// </summary>
        /// <value>A list of track IDs for track and channel number list NIEM reference is biom:TrackChannelList</value>

        [DataMember(Name="trackChannelList")]
        public List<BiomTrackListType> TrackChannelList { get; set; }

        /// <summary>
        /// An indication in microseconds the time of the start of the redaction relative to the beginning of the voice recording NIEM reference is biom:RelativeStartTimeInMSValue
        /// </summary>
        /// <value>An indication in microseconds the time of the start of the redaction relative to the beginning of the voice recording NIEM reference is biom:RelativeStartTimeInMSValue</value>

        [DataMember(Name="relativeStartTimeInMsValue")]
        public List<NiemXspositiveInteger> RelativeStartTimeInMsValue { get; set; }

        /// <summary>
        /// An indication in microseconds the time of the end of the redaction relative to the beginning of the voice recording NIEM reference is biom:RelativeEndTimeInMSValue
        /// </summary>
        /// <value>An indication in microseconds the time of the end of the redaction relative to the beginning of the voice recording NIEM reference is biom:RelativeEndTimeInMSValue</value>

        [DataMember(Name="relativeEndTimeInMsValue")]
        public List<NiemXspositiveInteger> RelativeEndTimeInMsValue { get; set; }

        /// <summary>
        /// A comment to contain additional information about the diarization. NIEM reference is biom:DiaryCommentText
        /// </summary>
        /// <value>A comment to contain additional information about the diarization. NIEM reference is biom:DiaryCommentText</value>

        [DataMember(Name="diaryComment")]
        public List<NcTextType> DiaryComment { get; set; }

        /// <summary>
        /// biomDiaryInformationType JSON-LD context
        /// </summary>
        /// <value>biomDiaryInformationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomDiaryInformationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomDiaryInformationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomDiaryInformationTypeContext.jsonld")]
            JSONLDContextsbiomDiaryInformationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomDiaryInformationType JSON-LD context
        /// </summary>
        /// <value>biomDiaryInformationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomDiaryInformationType {\n");
            sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
            sb.Append("  TrackChannelList: ").Append(TrackChannelList).Append("\n");
            sb.Append("  RelativeStartTimeInMsValue: ").Append(RelativeStartTimeInMsValue).Append("\n");
            sb.Append("  RelativeEndTimeInMsValue: ").Append(RelativeEndTimeInMsValue).Append("\n");
            sb.Append("  DiaryComment: ").Append(DiaryComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomDiaryInformationType)obj);
        }

        /// <summary>
        /// Returns true if BiomDiaryInformationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomDiaryInformationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomDiaryInformationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SegmentId == other.SegmentId ||
                    SegmentId != null &&
                    SegmentId.SequenceEqual(other.SegmentId)
                ) && 
                (
                    TrackChannelList == other.TrackChannelList ||
                    TrackChannelList != null &&
                    TrackChannelList.SequenceEqual(other.TrackChannelList)
                ) && 
                (
                    RelativeStartTimeInMsValue == other.RelativeStartTimeInMsValue ||
                    RelativeStartTimeInMsValue != null &&
                    RelativeStartTimeInMsValue.SequenceEqual(other.RelativeStartTimeInMsValue)
                ) && 
                (
                    RelativeEndTimeInMsValue == other.RelativeEndTimeInMsValue ||
                    RelativeEndTimeInMsValue != null &&
                    RelativeEndTimeInMsValue.SequenceEqual(other.RelativeEndTimeInMsValue)
                ) && 
                (
                    DiaryComment == other.DiaryComment ||
                    DiaryComment != null &&
                    DiaryComment.SequenceEqual(other.DiaryComment)
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
                    if (SegmentId != null)
                    hashCode = hashCode * 59 + SegmentId.GetHashCode();
                    if (TrackChannelList != null)
                    hashCode = hashCode * 59 + TrackChannelList.GetHashCode();
                    if (RelativeStartTimeInMsValue != null)
                    hashCode = hashCode * 59 + RelativeStartTimeInMsValue.GetHashCode();
                    if (RelativeEndTimeInMsValue != null)
                    hashCode = hashCode * 59 + RelativeEndTimeInMsValue.GetHashCode();
                    if (DiaryComment != null)
                    hashCode = hashCode * 59 + DiaryComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomDiaryInformationType left, BiomDiaryInformationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomDiaryInformationType left, BiomDiaryInformationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
