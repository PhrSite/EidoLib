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
    /// A data type for a set of information regarding the captured biometric information
    /// </summary>
    [DataContract]
    public partial class BiomBiometricCaptureType : IEquatable<BiomBiometricCaptureType>
    { 
        /// <summary>
        /// An identification of the activity of capturing the image; can be used to link images that were obtained simultaneously NIEM reference is biom:CaptureIdentification
        /// </summary>
        /// <value>An identification of the activity of capturing the image; can be used to link images that were obtained simultaneously NIEM reference is biom:CaptureIdentification</value>

        [DataMember(Name="captureIdentification")]
        public List<NcIdentificationType> CaptureIdentification { get; set; }

        /// <summary>
        /// A geospatial coordinate system for datum values NIEM reference is biom:GeographicSampleAcquisitionLocation
        /// </summary>
        /// <value>A geospatial coordinate system for datum values NIEM reference is biom:GeographicSampleAcquisitionLocation</value>

        [DataMember(Name="geographicSampleAcquisitionLocation")]
        public List<BiomGeographicSampleAcquisitionLocationType> GeographicSampleAcquisitionLocation { get; set; }

        /// <summary>
        /// A UTC date and time for the capture of a biometric sample NIEM reference is biom:CaptureUTCDateTime
        /// </summary>
        /// <value>A UTC date and time for the capture of a biometric sample NIEM reference is biom:CaptureUTCDateTime</value>

        [DataMember(Name="captureUtcDateTime")]
        public List<NiemXsdateTime> CaptureUtcDateTime { get; set; }

        /// <summary>
        /// A date that an image was captured NIEM reference is biom:CaptureDate
        /// </summary>
        /// <value>A date that an image was captured NIEM reference is biom:CaptureDate</value>

        [DataMember(Name="captureDate")]
        public List<NcDateType> CaptureDate { get; set; }

        /// <summary>
        /// A range of uncertainty as to when the image was captured NIEM reference is biom:CaptureDateEstimateRangeDuration
        /// </summary>
        /// <value>A range of uncertainty as to when the image was captured NIEM reference is biom:CaptureDateEstimateRangeDuration</value>

        [DataMember(Name="captureDateEstimateRangeDuration")]
        public List<NiemXsduration> CaptureDateEstimateRangeDuration { get; set; }

        /// <summary>
        /// A data type for a set of information regarding the captured device information NIEM reference is biom:CaptureDevice
        /// </summary>
        /// <value>A data type for a set of information regarding the captured device information NIEM reference is biom:CaptureDevice</value>

        [DataMember(Name="captureDevice")]
        public List<BiomDeviceType> CaptureDevice { get; set; }

        /// <summary>
        /// A description of how a biometric sample was collected. NIEM reference is biom:BiometricCaptureDescriptionText
        /// </summary>
        /// <value>A description of how a biometric sample was collected. NIEM reference is biom:BiometricCaptureDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A duration of total calculated time to send and receive transactions to capture each Biometric Image NIEM reference is biom:BiometricCaptureDuration
        /// </summary>
        /// <value>A duration of total calculated time to send and receive transactions to capture each Biometric Image NIEM reference is biom:BiometricCaptureDuration</value>

        [DataMember(Name="duration")]
        public List<NiemXsduration> Duration { get; set; }

        /// <summary>
        /// A source of a biometric item NIEM reference is biom:BiometricCaptureSource
        /// </summary>
        /// <value>A source of a biometric item NIEM reference is biom:BiometricCaptureSource</value>

        [DataMember(Name="source")]
        public List<BiomSourceAcquisitionType> Source { get; set; }

        /// <summary>
        /// An organization that originally captured an image NIEM reference is biom:CaptureOrganization
        /// </summary>
        /// <value>An organization that originally captured an image NIEM reference is biom:CaptureOrganization</value>

        [DataMember(Name="captureOrganization")]
        public List<NcOrganizationType> CaptureOrganization { get; set; }

        /// <summary>
        /// A quality metrics for the captured biometric image NIEM reference is biom:BiometricCaptureMetric
        /// </summary>
        /// <value>A quality metrics for the captured biometric image NIEM reference is biom:BiometricCaptureMetric</value>

        [DataMember(Name="metric")]
        public List<BiomBiometricCaptureMetricType> Metric { get; set; }

        /// <summary>
        /// Additional information about a biometric. NIEM reference is intel:BiometricAugmentation
        /// </summary>
        /// <value>Additional information about a biometric. NIEM reference is intel:BiometricAugmentation</value>

        [DataMember(Name="biometricAugmentation")]
        public List<IntelBiometricAugmentationType> BiometricAugmentation { get; set; }

        /// <summary>
        /// biomBiometricCaptureType JSON-LD context
        /// </summary>
        /// <value>biomBiometricCaptureType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomBiometricCaptureTypeContextJsonldEnum for ../JSON-LD_Contexts/biomBiometricCaptureTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomBiometricCaptureTypeContext.jsonld")]
            JSONLDContextsbiomBiometricCaptureTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomBiometricCaptureType JSON-LD context
        /// </summary>
        /// <value>biomBiometricCaptureType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomBiometricCaptureType {\n");
            sb.Append("  CaptureIdentification: ").Append(CaptureIdentification).Append("\n");
            sb.Append("  GeographicSampleAcquisitionLocation: ").Append(GeographicSampleAcquisitionLocation).Append("\n");
            sb.Append("  CaptureUtcDateTime: ").Append(CaptureUtcDateTime).Append("\n");
            sb.Append("  CaptureDate: ").Append(CaptureDate).Append("\n");
            sb.Append("  CaptureDateEstimateRangeDuration: ").Append(CaptureDateEstimateRangeDuration).Append("\n");
            sb.Append("  CaptureDevice: ").Append(CaptureDevice).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CaptureOrganization: ").Append(CaptureOrganization).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  BiometricAugmentation: ").Append(BiometricAugmentation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomBiometricCaptureType)obj);
        }

        /// <summary>
        /// Returns true if BiomBiometricCaptureType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomBiometricCaptureType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomBiometricCaptureType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CaptureIdentification == other.CaptureIdentification ||
                    CaptureIdentification != null &&
                    CaptureIdentification.SequenceEqual(other.CaptureIdentification)
                ) && 
                (
                    GeographicSampleAcquisitionLocation == other.GeographicSampleAcquisitionLocation ||
                    GeographicSampleAcquisitionLocation != null &&
                    GeographicSampleAcquisitionLocation.SequenceEqual(other.GeographicSampleAcquisitionLocation)
                ) && 
                (
                    CaptureUtcDateTime == other.CaptureUtcDateTime ||
                    CaptureUtcDateTime != null &&
                    CaptureUtcDateTime.SequenceEqual(other.CaptureUtcDateTime)
                ) && 
                (
                    CaptureDate == other.CaptureDate ||
                    CaptureDate != null &&
                    CaptureDate.SequenceEqual(other.CaptureDate)
                ) && 
                (
                    CaptureDateEstimateRangeDuration == other.CaptureDateEstimateRangeDuration ||
                    CaptureDateEstimateRangeDuration != null &&
                    CaptureDateEstimateRangeDuration.SequenceEqual(other.CaptureDateEstimateRangeDuration)
                ) && 
                (
                    CaptureDevice == other.CaptureDevice ||
                    CaptureDevice != null &&
                    CaptureDevice.SequenceEqual(other.CaptureDevice)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    Duration == other.Duration ||
                    Duration != null &&
                    Duration.SequenceEqual(other.Duration)
                ) && 
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.SequenceEqual(other.Source)
                ) && 
                (
                    CaptureOrganization == other.CaptureOrganization ||
                    CaptureOrganization != null &&
                    CaptureOrganization.SequenceEqual(other.CaptureOrganization)
                ) && 
                (
                    Metric == other.Metric ||
                    Metric != null &&
                    Metric.SequenceEqual(other.Metric)
                ) && 
                (
                    BiometricAugmentation == other.BiometricAugmentation ||
                    BiometricAugmentation != null &&
                    BiometricAugmentation.SequenceEqual(other.BiometricAugmentation)
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
                    if (CaptureIdentification != null)
                    hashCode = hashCode * 59 + CaptureIdentification.GetHashCode();
                    if (GeographicSampleAcquisitionLocation != null)
                    hashCode = hashCode * 59 + GeographicSampleAcquisitionLocation.GetHashCode();
                    if (CaptureUtcDateTime != null)
                    hashCode = hashCode * 59 + CaptureUtcDateTime.GetHashCode();
                    if (CaptureDate != null)
                    hashCode = hashCode * 59 + CaptureDate.GetHashCode();
                    if (CaptureDateEstimateRangeDuration != null)
                    hashCode = hashCode * 59 + CaptureDateEstimateRangeDuration.GetHashCode();
                    if (CaptureDevice != null)
                    hashCode = hashCode * 59 + CaptureDevice.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                    if (CaptureOrganization != null)
                    hashCode = hashCode * 59 + CaptureOrganization.GetHashCode();
                    if (Metric != null)
                    hashCode = hashCode * 59 + Metric.GetHashCode();
                    if (BiometricAugmentation != null)
                    hashCode = hashCode * 59 + BiometricAugmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomBiometricCaptureType left, BiomBiometricCaptureType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomBiometricCaptureType left, BiomBiometricCaptureType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
