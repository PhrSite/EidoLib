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
    /// A data type for a container of descriptive information about the encoding of a digital media data file.
    /// </summary>
    [DataContract]
    public partial class BiomCodecDetailsType : IEquatable<BiomCodecDetailsType>
    { 
        /// <summary>
        /// A CODEC used to encode a digital data stream or signal. NIEM reference is biom:CodecCategoryCode
        /// </summary>
        /// <value>A CODEC used to encode a digital data stream or signal. NIEM reference is biom:CodecCategoryCode</value>

        [DataMember(Name="codecCategoryCode")]
        public List<BiomCodecCategoryCodeType> CodecCategoryCode { get; set; }

        /// <summary>
        /// A ratio of digital samples per second of analog data upon conversion to an acoustic signal NIEM reference is biom:SamplingRate
        /// </summary>
        /// <value>A ratio of digital samples per second of analog data upon conversion to an acoustic signal NIEM reference is biom:SamplingRate</value>

        [DataMember(Name="samplingRate")]
        public List<NiemXsnonNegativeInteger> SamplingRate { get; set; }

        /// <summary>
        /// A total number of bits that are used to represent a single sample of digital media. NIEM reference is biom:RecordingBitDepthValue
        /// </summary>
        /// <value>A total number of bits that are used to represent a single sample of digital media. NIEM reference is biom:RecordingBitDepthValue</value>

        [DataMember(Name="recordingBitDepthValue")]
        public List<BiomInteger0to1024Type> RecordingBitDepthValue { get; set; }

        /// <summary>
        /// An ordering of individually addressable sub-components (bytes) within the representation of a recording. NIEM reference is biom:RecordingEndianCode
        /// </summary>
        /// <value>An ordering of individually addressable sub-components (bytes) within the representation of a recording. NIEM reference is biom:RecordingEndianCode</value>

        [DataMember(Name="recordingEndianCode")]
        public List<BiomEndianCodeType> RecordingEndianCode { get; set; }

        /// <summary>
        /// A kind of numeric format that contains Integer and floating point representations NIEM reference is biom:NumericFormatText
        /// </summary>
        /// <value>A kind of numeric format that contains Integer and floating point representations NIEM reference is biom:NumericFormatText</value>

        [DataMember(Name="numericFormat")]
        public List<NcTextType> NumericFormat { get; set; }

        /// <summary>
        /// A count of the channels of data represented in a digital media data file. NIEM reference is biom:RecordingChannelsQuantity
        /// </summary>
        /// <value>A count of the channels of data represented in a digital media data file. NIEM reference is biom:RecordingChannelsQuantity</value>

        [DataMember(Name="recordingChannelsQuantity")]
        public List<BiomInteger1to9999Type> RecordingChannelsQuantity { get; set; }

        /// <summary>
        /// A kind of code that contains the &#x27;reference code&#x27; from the table of codecs available at http://www.nist.gov/itl/iad/ig/ansi_standard.cfm NIEM reference is biom:CodecExternalReferenceCodeText
        /// </summary>
        /// <value>A kind of code that contains the &#x27;reference code&#x27; from the table of codecs available at http://www.nist.gov/itl/iad/ig/ansi_standard.cfm NIEM reference is biom:CodecExternalReferenceCodeText</value>

        [DataMember(Name="codecExternalReferenceCode")]
        public List<NcTextType> CodecExternalReferenceCode { get; set; }

        /// <summary>
        /// A comment to contain additional information about the codec or additional instructions for reconstruction of the original digital media data file. NIEM reference is biom:CodecCommentText
        /// </summary>
        /// <value>A comment to contain additional information about the codec or additional instructions for reconstruction of the original digital media data file. NIEM reference is biom:CodecCommentText</value>

        [DataMember(Name="codecComment")]
        public List<NcTextType> CodecComment { get; set; }

        /// <summary>
        /// biomCodecDetailsType JSON-LD context
        /// </summary>
        /// <value>biomCodecDetailsType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomCodecDetailsTypeContextJsonldEnum for ../JSON-LD_Contexts/biomCodecDetailsTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomCodecDetailsTypeContext.jsonld")]
            JSONLDContextsbiomCodecDetailsTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomCodecDetailsType JSON-LD context
        /// </summary>
        /// <value>biomCodecDetailsType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomCodecDetailsType {\n");
            sb.Append("  CodecCategoryCode: ").Append(CodecCategoryCode).Append("\n");
            sb.Append("  SamplingRate: ").Append(SamplingRate).Append("\n");
            sb.Append("  RecordingBitDepthValue: ").Append(RecordingBitDepthValue).Append("\n");
            sb.Append("  RecordingEndianCode: ").Append(RecordingEndianCode).Append("\n");
            sb.Append("  NumericFormat: ").Append(NumericFormat).Append("\n");
            sb.Append("  RecordingChannelsQuantity: ").Append(RecordingChannelsQuantity).Append("\n");
            sb.Append("  CodecExternalReferenceCode: ").Append(CodecExternalReferenceCode).Append("\n");
            sb.Append("  CodecComment: ").Append(CodecComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomCodecDetailsType)obj);
        }

        /// <summary>
        /// Returns true if BiomCodecDetailsType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomCodecDetailsType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomCodecDetailsType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CodecCategoryCode == other.CodecCategoryCode ||
                    CodecCategoryCode != null &&
                    CodecCategoryCode.SequenceEqual(other.CodecCategoryCode)
                ) && 
                (
                    SamplingRate == other.SamplingRate ||
                    SamplingRate != null &&
                    SamplingRate.SequenceEqual(other.SamplingRate)
                ) && 
                (
                    RecordingBitDepthValue == other.RecordingBitDepthValue ||
                    RecordingBitDepthValue != null &&
                    RecordingBitDepthValue.SequenceEqual(other.RecordingBitDepthValue)
                ) && 
                (
                    RecordingEndianCode == other.RecordingEndianCode ||
                    RecordingEndianCode != null &&
                    RecordingEndianCode.SequenceEqual(other.RecordingEndianCode)
                ) && 
                (
                    NumericFormat == other.NumericFormat ||
                    NumericFormat != null &&
                    NumericFormat.SequenceEqual(other.NumericFormat)
                ) && 
                (
                    RecordingChannelsQuantity == other.RecordingChannelsQuantity ||
                    RecordingChannelsQuantity != null &&
                    RecordingChannelsQuantity.SequenceEqual(other.RecordingChannelsQuantity)
                ) && 
                (
                    CodecExternalReferenceCode == other.CodecExternalReferenceCode ||
                    CodecExternalReferenceCode != null &&
                    CodecExternalReferenceCode.SequenceEqual(other.CodecExternalReferenceCode)
                ) && 
                (
                    CodecComment == other.CodecComment ||
                    CodecComment != null &&
                    CodecComment.SequenceEqual(other.CodecComment)
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
                    if (CodecCategoryCode != null)
                    hashCode = hashCode * 59 + CodecCategoryCode.GetHashCode();
                    if (SamplingRate != null)
                    hashCode = hashCode * 59 + SamplingRate.GetHashCode();
                    if (RecordingBitDepthValue != null)
                    hashCode = hashCode * 59 + RecordingBitDepthValue.GetHashCode();
                    if (RecordingEndianCode != null)
                    hashCode = hashCode * 59 + RecordingEndianCode.GetHashCode();
                    if (NumericFormat != null)
                    hashCode = hashCode * 59 + NumericFormat.GetHashCode();
                    if (RecordingChannelsQuantity != null)
                    hashCode = hashCode * 59 + RecordingChannelsQuantity.GetHashCode();
                    if (CodecExternalReferenceCode != null)
                    hashCode = hashCode * 59 + CodecExternalReferenceCode.GetHashCode();
                    if (CodecComment != null)
                    hashCode = hashCode * 59 + CodecComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomCodecDetailsType left, BiomCodecDetailsType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomCodecDetailsType left, BiomCodecDetailsType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}