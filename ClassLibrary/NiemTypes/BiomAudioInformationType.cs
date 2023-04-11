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
    /// A data type for a description of specific time segments within a voice recording, and their processing.
    /// </summary>
    [DataContract]
    public partial class BiomAudioInformationType : IEquatable<BiomAudioInformationType>
    { 
        /// <summary>
        /// A Redaction/Discontinuity Indicator Code. NIEM reference is biom:ProcessingIndicatorCode
        /// </summary>
        /// <value>A Redaction/Discontinuity Indicator Code. NIEM reference is biom:ProcessingIndicatorCode</value>

        [DataMember(Name="processingIndicatorCode")]
        public List<BiomProcessingIndicatorCodeType> ProcessingIndicatorCode { get; set; }

        /// <summary>
        /// A text value containing information about the agency that performed post-capture processing. NIEM reference is biom:ProcessingAuthorityText
        /// </summary>
        /// <value>A text value containing information about the agency that performed post-capture processing. NIEM reference is biom:ProcessingAuthorityText</value>

        [DataMember(Name="processingAuthority")]
        public List<NcTextType> ProcessingAuthority { get; set; }

        /// <summary>
        /// A text value containing information about the processing activities undertaken on the post-capture data. NIEM reference is biom:ProcessingCommentText
        /// </summary>
        /// <value>A text value containing information about the processing activities undertaken on the post-capture data. NIEM reference is biom:ProcessingCommentText</value>

        [DataMember(Name="processingComment")]
        public List<NcTextType> ProcessingComment { get; set; }

        /// <summary>
        /// biomAudioInformationType JSON-LD context
        /// </summary>
        /// <value>biomAudioInformationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomAudioInformationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomAudioInformationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomAudioInformationTypeContext.jsonld")]
            JSONLDContextsbiomAudioInformationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomAudioInformationType JSON-LD context
        /// </summary>
        /// <value>biomAudioInformationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomAudioInformationType {\n");
            sb.Append("  ProcessingIndicatorCode: ").Append(ProcessingIndicatorCode).Append("\n");
            sb.Append("  ProcessingAuthority: ").Append(ProcessingAuthority).Append("\n");
            sb.Append("  ProcessingComment: ").Append(ProcessingComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomAudioInformationType)obj);
        }

        /// <summary>
        /// Returns true if BiomAudioInformationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomAudioInformationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomAudioInformationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProcessingIndicatorCode == other.ProcessingIndicatorCode ||
                    ProcessingIndicatorCode != null &&
                    ProcessingIndicatorCode.SequenceEqual(other.ProcessingIndicatorCode)
                ) && 
                (
                    ProcessingAuthority == other.ProcessingAuthority ||
                    ProcessingAuthority != null &&
                    ProcessingAuthority.SequenceEqual(other.ProcessingAuthority)
                ) && 
                (
                    ProcessingComment == other.ProcessingComment ||
                    ProcessingComment != null &&
                    ProcessingComment.SequenceEqual(other.ProcessingComment)
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
                    if (ProcessingIndicatorCode != null)
                    hashCode = hashCode * 59 + ProcessingIndicatorCode.GetHashCode();
                    if (ProcessingAuthority != null)
                    hashCode = hashCode * 59 + ProcessingAuthority.GetHashCode();
                    if (ProcessingComment != null)
                    hashCode = hashCode * 59 + ProcessingComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomAudioInformationType left, BiomAudioInformationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomAudioInformationType left, BiomAudioInformationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}