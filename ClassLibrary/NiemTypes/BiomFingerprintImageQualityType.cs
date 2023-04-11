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
    /// A data type for a quality measure for a particular fingerprint
    /// </summary>
    [DataContract]
    public partial class BiomFingerprintImageQualityType : IEquatable<BiomFingerprintImageQualityType>
    { 
        /// <summary>
        /// A finger position code NIEM reference is biom:FingerPositionCode
        /// </summary>
        /// <value>A finger position code NIEM reference is biom:FingerPositionCode</value>

        [DataMember(Name="fingerPositionCode")]
        public List<BiomFingerPositionCodeType> FingerPositionCode { get; set; }

        /// <summary>
        /// A unique identifier for a quality-algorithm product, assigned by the vendor NIEM reference is biom:QualityAlgorithmProductID
        /// </summary>
        /// <value>A unique identifier for a quality-algorithm product, assigned by the vendor NIEM reference is biom:QualityAlgorithmProductID</value>

        [DataMember(Name="qualityAlgorithmProductId")]
        public List<NiemXsunsignedShort> QualityAlgorithmProductId { get; set; }

        /// <summary>
        /// A unique identifier for the vendor of a quality-algorithm product NIEM reference is biom:QualityAlgorithmVendorID
        /// </summary>
        /// <value>A unique identifier for the vendor of a quality-algorithm product NIEM reference is biom:QualityAlgorithmVendorID</value>

        [DataMember(Name="qualityAlgorithmVendorId")]
        public List<BiomHexDoubleByteType> QualityAlgorithmVendorId { get; set; }

        /// <summary>
        /// A value of the quality of a particular sample NIEM reference is biom:QualityValue
        /// </summary>
        /// <value>A value of the quality of a particular sample NIEM reference is biom:QualityValue</value>

        [DataMember(Name="qualityValue")]
        public List<string> QualityValue { get; set; }

        /// <summary>
        /// biomFingerprintImageQualityType JSON-LD context
        /// </summary>
        /// <value>biomFingerprintImageQualityType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFingerprintImageQualityTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFingerprintImageQualityTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFingerprintImageQualityTypeContext.jsonld")]
            JSONLDContextsbiomFingerprintImageQualityTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFingerprintImageQualityType JSON-LD context
        /// </summary>
        /// <value>biomFingerprintImageQualityType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFingerprintImageQualityType {\n");
            sb.Append("  FingerPositionCode: ").Append(FingerPositionCode).Append("\n");
            sb.Append("  QualityAlgorithmProductId: ").Append(QualityAlgorithmProductId).Append("\n");
            sb.Append("  QualityAlgorithmVendorId: ").Append(QualityAlgorithmVendorId).Append("\n");
            sb.Append("  QualityValue: ").Append(QualityValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFingerprintImageQualityType)obj);
        }

        /// <summary>
        /// Returns true if BiomFingerprintImageQualityType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFingerprintImageQualityType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFingerprintImageQualityType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FingerPositionCode == other.FingerPositionCode ||
                    FingerPositionCode != null &&
                    FingerPositionCode.SequenceEqual(other.FingerPositionCode)
                ) && 
                (
                    QualityAlgorithmProductId == other.QualityAlgorithmProductId ||
                    QualityAlgorithmProductId != null &&
                    QualityAlgorithmProductId.SequenceEqual(other.QualityAlgorithmProductId)
                ) && 
                (
                    QualityAlgorithmVendorId == other.QualityAlgorithmVendorId ||
                    QualityAlgorithmVendorId != null &&
                    QualityAlgorithmVendorId.SequenceEqual(other.QualityAlgorithmVendorId)
                ) && 
                (
                    QualityValue == other.QualityValue ||
                    QualityValue != null &&
                    QualityValue.SequenceEqual(other.QualityValue)
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
                    if (FingerPositionCode != null)
                    hashCode = hashCode * 59 + FingerPositionCode.GetHashCode();
                    if (QualityAlgorithmProductId != null)
                    hashCode = hashCode * 59 + QualityAlgorithmProductId.GetHashCode();
                    if (QualityAlgorithmVendorId != null)
                    hashCode = hashCode * 59 + QualityAlgorithmVendorId.GetHashCode();
                    if (QualityValue != null)
                    hashCode = hashCode * 59 + QualityValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFingerprintImageQualityType left, BiomFingerprintImageQualityType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFingerprintImageQualityType left, BiomFingerprintImageQualityType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
