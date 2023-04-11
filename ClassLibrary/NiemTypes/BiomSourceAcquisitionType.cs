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
    /// A data type for an acquisition method for the source representation
    /// </summary>
    [DataContract]
    public partial class BiomSourceAcquisitionType : IEquatable<BiomSourceAcquisitionType>
    { 
        /// <summary>
        /// A kind of acquisition method for the source representation NIEM reference is biom:AcquisitionSourceCode
        /// </summary>
        /// <value>A kind of acquisition method for the source representation NIEM reference is biom:AcquisitionSourceCode</value>

        [DataMember(Name="acquisitionSourceCode")]
        public List<BiomAcquisitionSourceCodeType> AcquisitionSourceCode { get; set; }

        /// <summary>
        /// A kind of biometric capture source (system name etc.). NIEM reference is biom:AcquisitionSourceCategoryText
        /// </summary>
        /// <value>A kind of biometric capture source (system name etc.). NIEM reference is biom:AcquisitionSourceCategoryText</value>

        [DataMember(Name="acquisitionSourceCategory")]
        public List<NcTextType> AcquisitionSourceCategory { get; set; }

        /// <summary>
        /// An element to capture source or location information from which a biometric sample was collected. NIEM reference is biom:AcquisitionSourceText
        /// </summary>
        /// <value>An element to capture source or location information from which a biometric sample was collected. NIEM reference is biom:AcquisitionSourceText</value>

        [DataMember(Name="acquisitionSource")]
        public List<NcTextType> AcquisitionSource { get; set; }

        /// <summary>
        /// A description of a vendor-specified source of an image NIEM reference is biom:AcquisitionSourceDescriptionText
        /// </summary>
        /// <value>A description of a vendor-specified source of an image NIEM reference is biom:AcquisitionSourceDescriptionText</value>

        [DataMember(Name="acquisitionSourceDescription")]
        public List<NcTextType> AcquisitionSourceDescription { get; set; }

        /// <summary>
        /// A description of the analog to digital equipment used to store a representation of the source NIEM reference is biom:AcquisitionDigitalConversionDescriptionText
        /// </summary>
        /// <value>A description of the analog to digital equipment used to store a representation of the source NIEM reference is biom:AcquisitionDigitalConversionDescriptionText</value>

        [DataMember(Name="acquisitionDigitalConversionDescription")]
        public List<NcTextType> AcquisitionDigitalConversionDescription { get; set; }

        /// <summary>
        /// An acquisition radio transmission format description. NIEM reference is biom:AcquisitionRadioTransmissionFormatDescriptionText
        /// </summary>
        /// <value>An acquisition radio transmission format description. NIEM reference is biom:AcquisitionRadioTransmissionFormatDescriptionText</value>

        [DataMember(Name="acquisitionRadioTransmissionFormatDescription")]
        public List<NcTextType> AcquisitionRadioTransmissionFormatDescription { get; set; }

        /// <summary>
        /// A description of any specific conditions. An example would be a near-infrared camera outputting images in visible wavelengths NIEM reference is biom:AcquisitionSpecialCharacteristicsText
        /// </summary>
        /// <value>A description of any specific conditions. An example would be a near-infrared camera outputting images in visible wavelengths NIEM reference is biom:AcquisitionSpecialCharacteristicsText</value>

        [DataMember(Name="acquisitionSpecialCharacteristics")]
        public List<NcTextType> AcquisitionSpecialCharacteristics { get; set; }

        /// <summary>
        /// biomSourceAcquisitionType JSON-LD context
        /// </summary>
        /// <value>biomSourceAcquisitionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomSourceAcquisitionTypeContextJsonldEnum for ../JSON-LD_Contexts/biomSourceAcquisitionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomSourceAcquisitionTypeContext.jsonld")]
            JSONLDContextsbiomSourceAcquisitionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomSourceAcquisitionType JSON-LD context
        /// </summary>
        /// <value>biomSourceAcquisitionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomSourceAcquisitionType {\n");
            sb.Append("  AcquisitionSourceCode: ").Append(AcquisitionSourceCode).Append("\n");
            sb.Append("  AcquisitionSourceCategory: ").Append(AcquisitionSourceCategory).Append("\n");
            sb.Append("  AcquisitionSource: ").Append(AcquisitionSource).Append("\n");
            sb.Append("  AcquisitionSourceDescription: ").Append(AcquisitionSourceDescription).Append("\n");
            sb.Append("  AcquisitionDigitalConversionDescription: ").Append(AcquisitionDigitalConversionDescription).Append("\n");
            sb.Append("  AcquisitionRadioTransmissionFormatDescription: ").Append(AcquisitionRadioTransmissionFormatDescription).Append("\n");
            sb.Append("  AcquisitionSpecialCharacteristics: ").Append(AcquisitionSpecialCharacteristics).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomSourceAcquisitionType)obj);
        }

        /// <summary>
        /// Returns true if BiomSourceAcquisitionType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomSourceAcquisitionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomSourceAcquisitionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AcquisitionSourceCode == other.AcquisitionSourceCode ||
                    AcquisitionSourceCode != null &&
                    AcquisitionSourceCode.SequenceEqual(other.AcquisitionSourceCode)
                ) && 
                (
                    AcquisitionSourceCategory == other.AcquisitionSourceCategory ||
                    AcquisitionSourceCategory != null &&
                    AcquisitionSourceCategory.SequenceEqual(other.AcquisitionSourceCategory)
                ) && 
                (
                    AcquisitionSource == other.AcquisitionSource ||
                    AcquisitionSource != null &&
                    AcquisitionSource.SequenceEqual(other.AcquisitionSource)
                ) && 
                (
                    AcquisitionSourceDescription == other.AcquisitionSourceDescription ||
                    AcquisitionSourceDescription != null &&
                    AcquisitionSourceDescription.SequenceEqual(other.AcquisitionSourceDescription)
                ) && 
                (
                    AcquisitionDigitalConversionDescription == other.AcquisitionDigitalConversionDescription ||
                    AcquisitionDigitalConversionDescription != null &&
                    AcquisitionDigitalConversionDescription.SequenceEqual(other.AcquisitionDigitalConversionDescription)
                ) && 
                (
                    AcquisitionRadioTransmissionFormatDescription == other.AcquisitionRadioTransmissionFormatDescription ||
                    AcquisitionRadioTransmissionFormatDescription != null &&
                    AcquisitionRadioTransmissionFormatDescription.SequenceEqual(other.AcquisitionRadioTransmissionFormatDescription)
                ) && 
                (
                    AcquisitionSpecialCharacteristics == other.AcquisitionSpecialCharacteristics ||
                    AcquisitionSpecialCharacteristics != null &&
                    AcquisitionSpecialCharacteristics.SequenceEqual(other.AcquisitionSpecialCharacteristics)
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
                    if (AcquisitionSourceCode != null)
                    hashCode = hashCode * 59 + AcquisitionSourceCode.GetHashCode();
                    if (AcquisitionSourceCategory != null)
                    hashCode = hashCode * 59 + AcquisitionSourceCategory.GetHashCode();
                    if (AcquisitionSource != null)
                    hashCode = hashCode * 59 + AcquisitionSource.GetHashCode();
                    if (AcquisitionSourceDescription != null)
                    hashCode = hashCode * 59 + AcquisitionSourceDescription.GetHashCode();
                    if (AcquisitionDigitalConversionDescription != null)
                    hashCode = hashCode * 59 + AcquisitionDigitalConversionDescription.GetHashCode();
                    if (AcquisitionRadioTransmissionFormatDescription != null)
                    hashCode = hashCode * 59 + AcquisitionRadioTransmissionFormatDescription.GetHashCode();
                    if (AcquisitionSpecialCharacteristics != null)
                    hashCode = hashCode * 59 + AcquisitionSpecialCharacteristics.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomSourceAcquisitionType left, BiomSourceAcquisitionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomSourceAcquisitionType left, BiomSourceAcquisitionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
