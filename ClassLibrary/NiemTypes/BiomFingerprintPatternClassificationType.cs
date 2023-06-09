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
    /// A data type for a classification and sub-classification of a fingerprint pattern
    /// </summary>
    [DataContract]
    public partial class BiomFingerprintPatternClassificationType : IEquatable<BiomFingerprintPatternClassificationType>
    { 
        /// <summary>
        /// A class of fingerprint pattern used by most automated fingerprint information systems NIEM reference is biom:FingerprintPatternGeneralClassCode
        /// </summary>
        /// <value>A class of fingerprint pattern used by most automated fingerprint information systems NIEM reference is biom:FingerprintPatternGeneralClassCode</value>

        [DataMember(Name="fingerprintPatternGeneralClassCode")]
        public List<BiomFingerprintPatternGeneralClassCodeType> FingerprintPatternGeneralClassCode { get; set; }

        /// <summary>
        /// A subclass of fingerprint pattern that is an arch or whorl NIEM reference is biom:FingerprintPatternSubClassCode
        /// </summary>
        /// <value>A subclass of fingerprint pattern that is an arch or whorl NIEM reference is biom:FingerprintPatternSubClassCode</value>

        [DataMember(Name="fingerprintPatternSubClassCode")]
        public List<BiomFingerprintPatternSubClassCodeType> FingerprintPatternSubClassCode { get; set; }

        /// <summary>
        /// A relationship between a whorl and a delta in a fingerprint pattern NIEM reference is biom:FingerprintPatternWhorlDeltaRelationshipCode
        /// </summary>
        /// <value>A relationship between a whorl and a delta in a fingerprint pattern NIEM reference is biom:FingerprintPatternWhorlDeltaRelationshipCode</value>

        [DataMember(Name="fingerprintPatternWhorlDeltaRelationshipCode")]
        public List<BiomFingerprintPatternWhorlDeltaRelationshipCodeType> FingerprintPatternWhorlDeltaRelationshipCode { get; set; }

        /// <summary>
        /// biomFingerprintPatternClassificationType JSON-LD context
        /// </summary>
        /// <value>biomFingerprintPatternClassificationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFingerprintPatternClassificationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFingerprintPatternClassificationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFingerprintPatternClassificationTypeContext.jsonld")]
            JSONLDContextsbiomFingerprintPatternClassificationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFingerprintPatternClassificationType JSON-LD context
        /// </summary>
        /// <value>biomFingerprintPatternClassificationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFingerprintPatternClassificationType {\n");
            sb.Append("  FingerprintPatternGeneralClassCode: ").Append(FingerprintPatternGeneralClassCode).Append("\n");
            sb.Append("  FingerprintPatternSubClassCode: ").Append(FingerprintPatternSubClassCode).Append("\n");
            sb.Append("  FingerprintPatternWhorlDeltaRelationshipCode: ").Append(FingerprintPatternWhorlDeltaRelationshipCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFingerprintPatternClassificationType)obj);
        }

        /// <summary>
        /// Returns true if BiomFingerprintPatternClassificationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFingerprintPatternClassificationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFingerprintPatternClassificationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FingerprintPatternGeneralClassCode == other.FingerprintPatternGeneralClassCode ||
                    FingerprintPatternGeneralClassCode != null &&
                    FingerprintPatternGeneralClassCode.SequenceEqual(other.FingerprintPatternGeneralClassCode)
                ) && 
                (
                    FingerprintPatternSubClassCode == other.FingerprintPatternSubClassCode ||
                    FingerprintPatternSubClassCode != null &&
                    FingerprintPatternSubClassCode.SequenceEqual(other.FingerprintPatternSubClassCode)
                ) && 
                (
                    FingerprintPatternWhorlDeltaRelationshipCode == other.FingerprintPatternWhorlDeltaRelationshipCode ||
                    FingerprintPatternWhorlDeltaRelationshipCode != null &&
                    FingerprintPatternWhorlDeltaRelationshipCode.SequenceEqual(other.FingerprintPatternWhorlDeltaRelationshipCode)
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
                    if (FingerprintPatternGeneralClassCode != null)
                    hashCode = hashCode * 59 + FingerprintPatternGeneralClassCode.GetHashCode();
                    if (FingerprintPatternSubClassCode != null)
                    hashCode = hashCode * 59 + FingerprintPatternSubClassCode.GetHashCode();
                    if (FingerprintPatternWhorlDeltaRelationshipCode != null)
                    hashCode = hashCode * 59 + FingerprintPatternWhorlDeltaRelationshipCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFingerprintPatternClassificationType left, BiomFingerprintPatternClassificationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFingerprintPatternClassificationType left, BiomFingerprintPatternClassificationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
