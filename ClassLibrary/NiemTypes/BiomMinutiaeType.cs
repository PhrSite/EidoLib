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
    /// A data type for a set of minutiae definitions
    /// </summary>
    [DataContract]
    public partial class BiomMinutiaeType : IEquatable<BiomMinutiaeType>
    { 
        /// <summary>
        /// A set of information regarding the captured (e.g., scanned) image NIEM reference is biom:ImageCaptureDetail
        /// </summary>
        /// <value>A set of information regarding the captured (e.g., scanned) image NIEM reference is biom:ImageCaptureDetail</value>

        [DataMember(Name="imageCaptureDetail")]
        public List<BiomImageCaptureType> ImageCaptureDetail { get; set; }

        /// <summary>
        /// A finger position, segment, offcenter code, and polygon location within an image NIEM reference is biom:MinutiaeFingerLocation
        /// </summary>
        /// <value>A finger position, segment, offcenter code, and polygon location within an image NIEM reference is biom:MinutiaeFingerLocation</value>

        [DataMember(Name="fingerLocation")]
        public List<BiomMinutiaeFingerLocationType> FingerLocation { get; set; }

        /// <summary>
        /// A classification of the manner in which the FINGERPRINT is taken. NIEM reference is biom:FingerprintCaptureTechnique
        /// </summary>
        /// <value>A classification of the manner in which the FINGERPRINT is taken. NIEM reference is biom:FingerprintCaptureTechnique</value>

        [DataMember(Name="fingerprintCaptureTechnique")]
        public List<BiomFingerprintCaptureTechniqueType> FingerprintCaptureTechnique { get; set; }

        /// <summary>
        /// A number of minutiae recorded in a record NIEM reference is biom:MinutiaeQuantity
        /// </summary>
        /// <value>A number of minutiae recorded in a record NIEM reference is biom:MinutiaeQuantity</value>

        [DataMember(Name="quantity")]
        public List<NiemXspositiveInteger> Quantity { get; set; }

        /// <summary>
        /// A set of information required when finger position code is \&quot;19\&quot; complete friction ridge exemplars NIEM reference is biom:FingerprintImageMajorCasePrint
        /// </summary>
        /// <value>A set of information required when finger position code is \&quot;19\&quot; complete friction ridge exemplars NIEM reference is biom:FingerprintImageMajorCasePrint</value>

        [DataMember(Name="fingerprintImageMajorCasePrint")]
        public List<BiomFingerprintImageMajorCasePrintType> FingerprintImageMajorCasePrint { get; set; }

        /// <summary>
        /// A fingerprint image segment position square NIEM reference is biom:FingerprintImageSegmentPositionSquare
        /// </summary>
        /// <value>A fingerprint image segment position square NIEM reference is biom:FingerprintImageSegmentPositionSquare</value>

        [DataMember(Name="fingerprintImageSegmentPositionSquare")]
        public List<BiomFrictionRidgeImageSegmentPositionSquareType> FingerprintImageSegmentPositionSquare { get; set; }

        /// <summary>
        /// A missing finger in a fingerprint image NIEM reference is biom:FingerprintImageFingerMissing
        /// </summary>
        /// <value>A missing finger in a fingerprint image NIEM reference is biom:FingerprintImageFingerMissing</value>

        [DataMember(Name="fingerprintImageFingerMissing")]
        public List<BiomFingerprintImageFingerMissingType> FingerprintImageFingerMissing { get; set; }

        /// <summary>
        /// A radius of position uncertainty (PUM) in the manual or automatic placement of the core in integer units of 10 micrometers NIEM reference is biom:PositionUncertaintyValue
        /// </summary>
        /// <value>A radius of position uncertainty (PUM) in the manual or automatic placement of the core in integer units of 10 micrometers NIEM reference is biom:PositionUncertaintyValue</value>

        [DataMember(Name="positionUncertaintyValue")]
        public List<NiemXsnonNegativeInteger> PositionUncertaintyValue { get; set; }

        /// <summary>
        /// A number representing the distribution of the parameter over thousands of fingerprints approximating a Gaussian distribution. NIEM reference is biom:MinutiaCharacterizationQualityValue
        /// </summary>
        /// <value>A number representing the distribution of the parameter over thousands of fingerprints approximating a Gaussian distribution. NIEM reference is biom:MinutiaCharacterizationQualityValue</value>

        [DataMember(Name="minutiaCharacterizationQualityValue")]
        public List<NiemXsnonNegativeInteger> MinutiaCharacterizationQualityValue { get; set; }

        /// <summary>
        /// A number that indicates the quality or confidence of the automatic classification. NIEM reference is biom:MinutiaClassifierQualityValue
        /// </summary>
        /// <value>A number that indicates the quality or confidence of the automatic classification. NIEM reference is biom:MinutiaClassifierQualityValue</value>

        [DataMember(Name="minutiaClassifierQualityValue")]
        public List<NiemXsdecimal> MinutiaClassifierQualityValue { get; set; }

        /// <summary>
        /// A location of a fingerprint pattern&#x27;s core in a fingerprint image NIEM reference is biom:FingerprintPatternCoreLocation
        /// </summary>
        /// <value>A location of a fingerprint pattern&#x27;s core in a fingerprint image NIEM reference is biom:FingerprintPatternCoreLocation</value>

        [DataMember(Name="fingerprintPatternCoreLocation")]
        public List<BiomFingerprintFeatureLocationType> FingerprintPatternCoreLocation { get; set; }

        /// <summary>
        /// A location of a fingerprint pattern&#x27;s delta in a fingerprint image NIEM reference is biom:FingerprintPatternDeltaLocation
        /// </summary>
        /// <value>A location of a fingerprint pattern&#x27;s delta in a fingerprint image NIEM reference is biom:FingerprintPatternDeltaLocation</value>

        [DataMember(Name="fingerprintPatternDeltaLocation")]
        public List<BiomFingerprintDeltaLocationType> FingerprintPatternDeltaLocation { get; set; }

        /// <summary>
        /// True if a fingerprint biometric was taken; false otherwise. NIEM reference is biom:FingerprintTakenIndicator
        /// </summary>
        /// <value>True if a fingerprint biometric was taken; false otherwise. NIEM reference is biom:FingerprintTakenIndicator</value>

        [DataMember(Name="isFingerprintTaken")]
        public List<NiemXsboolean> IsFingerprintTaken { get; set; }

        /// <summary>
        /// A description of a fingerprint type. NIEM reference is biom:FingerprintCategoryDescriptionText
        /// </summary>
        /// <value>A description of a fingerprint type. NIEM reference is biom:FingerprintCategoryDescriptionText</value>

        [DataMember(Name="fingerprintCategoryDescription")]
        public List<NcTextType> FingerprintCategoryDescription { get; set; }

        /// <summary>
        /// A kind of supplemental proprietary value describing minutiae and related information encoded from a fingerprint image. NIEM reference is biom:FingerprintFeaturesFeedback
        /// </summary>
        /// <value>A kind of supplemental proprietary value describing minutiae and related information encoded from a fingerprint image. NIEM reference is biom:FingerprintFeaturesFeedback</value>

        [DataMember(Name="fingerprintFeaturesFeedback")]
        public List<string> FingerprintFeaturesFeedback { get; set; }

        /// <summary>
        /// A vendor and version of the fingerprint feature extraction software used to encode minutiae. NIEM reference is biom:FingerprintFeaturesVersionText
        /// </summary>
        /// <value>A vendor and version of the fingerprint feature extraction software used to encode minutiae. NIEM reference is biom:FingerprintFeaturesVersionText</value>

        [DataMember(Name="fingerprintFeaturesVersion")]
        public List<NcTextType> FingerprintFeaturesVersion { get; set; }

        /// <summary>
        /// An identification that uniquely identifies a Person&#x27;s fingerprints. NIEM reference is biom:FingerprintIdentification
        /// </summary>
        /// <value>An identification that uniquely identifies a Person&#x27;s fingerprints. NIEM reference is biom:FingerprintIdentification</value>

        [DataMember(Name="fingerprintIdentification")]
        public List<NcIdentificationType> FingerprintIdentification { get; set; }

        /// <summary>
        /// True if the NIST standard format for minutiae is used; false otherwise NIEM reference is biom:MinutiaeFormatNISTStandardIndicator
        /// </summary>
        /// <value>True if the NIST standard format for minutiae is used; false otherwise NIEM reference is biom:MinutiaeFormatNISTStandardIndicator</value>

        [DataMember(Name="isFormatNistStandard")]
        public List<NiemXsboolean> IsFormatNistStandard { get; set; }

        /// <summary>
        /// A minutia in a friction ridge image (Obsolete). NIEM reference is biom:FingerRidgeMinutia
        /// </summary>
        /// <value>A minutia in a friction ridge image (Obsolete). NIEM reference is biom:FingerRidgeMinutia</value>

        [DataMember(Name="fingerRidgeMinutia")]
        public List<BiomMinutiaType> FingerRidgeMinutia { get; set; }

        /// <summary>
        /// A set of elements for the measure and definition of friction ridge detail within a particular region of interest in a fingerprint or palm print image NIEM reference is biom:ExtendedFeatureSetMinutiae
        /// </summary>
        /// <value>A set of elements for the measure and definition of friction ridge detail within a particular region of interest in a fingerprint or palm print image NIEM reference is biom:ExtendedFeatureSetMinutiae</value>

        [DataMember(Name="extendedFeatureSet")]
        public List<BiomExtendedFeatureSetMinutiaeType> ExtendedFeatureSet { get; set; }

        /// <summary>
        /// A set of minutiae definitions conforming to Section 5 of the ANSI INCITS 378-2004 Standard NIEM reference is biom:INCITSMinutiae
        /// </summary>
        /// <value>A set of minutiae definitions conforming to Section 5 of the ANSI INCITS 378-2004 Standard NIEM reference is biom:INCITSMinutiae</value>

        [DataMember(Name="incits")]
        public List<BiomINCITSMinutiaeType> Incits { get; set; }

        /// <summary>
        /// A set of minutiae definitions to be used for a feature set owner or developer other than the ones specifically defined in this standard NIEM reference is biom:OtherMinutiae
        /// </summary>
        /// <value>A set of minutiae definitions to be used for a feature set owner or developer other than the ones specifically defined in this standard NIEM reference is biom:OtherMinutiae</value>

        [DataMember(Name="other")]
        public List<BiomOtherMinutiaeType> Other { get; set; }

        /// <summary>
        /// biomMinutiaeType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomMinutiaeTypeContextJsonldEnum for ../JSON-LD_Contexts/biomMinutiaeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomMinutiaeTypeContext.jsonld")]
            JSONLDContextsbiomMinutiaeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomMinutiaeType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomMinutiaeType {\n");
            sb.Append("  ImageCaptureDetail: ").Append(ImageCaptureDetail).Append("\n");
            sb.Append("  FingerLocation: ").Append(FingerLocation).Append("\n");
            sb.Append("  FingerprintCaptureTechnique: ").Append(FingerprintCaptureTechnique).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  FingerprintImageMajorCasePrint: ").Append(FingerprintImageMajorCasePrint).Append("\n");
            sb.Append("  FingerprintImageSegmentPositionSquare: ").Append(FingerprintImageSegmentPositionSquare).Append("\n");
            sb.Append("  FingerprintImageFingerMissing: ").Append(FingerprintImageFingerMissing).Append("\n");
            sb.Append("  PositionUncertaintyValue: ").Append(PositionUncertaintyValue).Append("\n");
            sb.Append("  MinutiaCharacterizationQualityValue: ").Append(MinutiaCharacterizationQualityValue).Append("\n");
            sb.Append("  MinutiaClassifierQualityValue: ").Append(MinutiaClassifierQualityValue).Append("\n");
            sb.Append("  FingerprintPatternCoreLocation: ").Append(FingerprintPatternCoreLocation).Append("\n");
            sb.Append("  FingerprintPatternDeltaLocation: ").Append(FingerprintPatternDeltaLocation).Append("\n");
            sb.Append("  IsFingerprintTaken: ").Append(IsFingerprintTaken).Append("\n");
            sb.Append("  FingerprintCategoryDescription: ").Append(FingerprintCategoryDescription).Append("\n");
            sb.Append("  FingerprintFeaturesFeedback: ").Append(FingerprintFeaturesFeedback).Append("\n");
            sb.Append("  FingerprintFeaturesVersion: ").Append(FingerprintFeaturesVersion).Append("\n");
            sb.Append("  FingerprintIdentification: ").Append(FingerprintIdentification).Append("\n");
            sb.Append("  IsFormatNistStandard: ").Append(IsFormatNistStandard).Append("\n");
            sb.Append("  FingerRidgeMinutia: ").Append(FingerRidgeMinutia).Append("\n");
            sb.Append("  ExtendedFeatureSet: ").Append(ExtendedFeatureSet).Append("\n");
            sb.Append("  Incits: ").Append(Incits).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomMinutiaeType)obj);
        }

        /// <summary>
        /// Returns true if BiomMinutiaeType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomMinutiaeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomMinutiaeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ImageCaptureDetail == other.ImageCaptureDetail ||
                    ImageCaptureDetail != null &&
                    ImageCaptureDetail.SequenceEqual(other.ImageCaptureDetail)
                ) && 
                (
                    FingerLocation == other.FingerLocation ||
                    FingerLocation != null &&
                    FingerLocation.SequenceEqual(other.FingerLocation)
                ) && 
                (
                    FingerprintCaptureTechnique == other.FingerprintCaptureTechnique ||
                    FingerprintCaptureTechnique != null &&
                    FingerprintCaptureTechnique.SequenceEqual(other.FingerprintCaptureTechnique)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.SequenceEqual(other.Quantity)
                ) && 
                (
                    FingerprintImageMajorCasePrint == other.FingerprintImageMajorCasePrint ||
                    FingerprintImageMajorCasePrint != null &&
                    FingerprintImageMajorCasePrint.SequenceEqual(other.FingerprintImageMajorCasePrint)
                ) && 
                (
                    FingerprintImageSegmentPositionSquare == other.FingerprintImageSegmentPositionSquare ||
                    FingerprintImageSegmentPositionSquare != null &&
                    FingerprintImageSegmentPositionSquare.SequenceEqual(other.FingerprintImageSegmentPositionSquare)
                ) && 
                (
                    FingerprintImageFingerMissing == other.FingerprintImageFingerMissing ||
                    FingerprintImageFingerMissing != null &&
                    FingerprintImageFingerMissing.SequenceEqual(other.FingerprintImageFingerMissing)
                ) && 
                (
                    PositionUncertaintyValue == other.PositionUncertaintyValue ||
                    PositionUncertaintyValue != null &&
                    PositionUncertaintyValue.SequenceEqual(other.PositionUncertaintyValue)
                ) && 
                (
                    MinutiaCharacterizationQualityValue == other.MinutiaCharacterizationQualityValue ||
                    MinutiaCharacterizationQualityValue != null &&
                    MinutiaCharacterizationQualityValue.SequenceEqual(other.MinutiaCharacterizationQualityValue)
                ) && 
                (
                    MinutiaClassifierQualityValue == other.MinutiaClassifierQualityValue ||
                    MinutiaClassifierQualityValue != null &&
                    MinutiaClassifierQualityValue.SequenceEqual(other.MinutiaClassifierQualityValue)
                ) && 
                (
                    FingerprintPatternCoreLocation == other.FingerprintPatternCoreLocation ||
                    FingerprintPatternCoreLocation != null &&
                    FingerprintPatternCoreLocation.SequenceEqual(other.FingerprintPatternCoreLocation)
                ) && 
                (
                    FingerprintPatternDeltaLocation == other.FingerprintPatternDeltaLocation ||
                    FingerprintPatternDeltaLocation != null &&
                    FingerprintPatternDeltaLocation.SequenceEqual(other.FingerprintPatternDeltaLocation)
                ) && 
                (
                    IsFingerprintTaken == other.IsFingerprintTaken ||
                    IsFingerprintTaken != null &&
                    IsFingerprintTaken.SequenceEqual(other.IsFingerprintTaken)
                ) && 
                (
                    FingerprintCategoryDescription == other.FingerprintCategoryDescription ||
                    FingerprintCategoryDescription != null &&
                    FingerprintCategoryDescription.SequenceEqual(other.FingerprintCategoryDescription)
                ) && 
                (
                    FingerprintFeaturesFeedback == other.FingerprintFeaturesFeedback ||
                    FingerprintFeaturesFeedback != null &&
                    FingerprintFeaturesFeedback.SequenceEqual(other.FingerprintFeaturesFeedback)
                ) && 
                (
                    FingerprintFeaturesVersion == other.FingerprintFeaturesVersion ||
                    FingerprintFeaturesVersion != null &&
                    FingerprintFeaturesVersion.SequenceEqual(other.FingerprintFeaturesVersion)
                ) && 
                (
                    FingerprintIdentification == other.FingerprintIdentification ||
                    FingerprintIdentification != null &&
                    FingerprintIdentification.SequenceEqual(other.FingerprintIdentification)
                ) && 
                (
                    IsFormatNistStandard == other.IsFormatNistStandard ||
                    IsFormatNistStandard != null &&
                    IsFormatNistStandard.SequenceEqual(other.IsFormatNistStandard)
                ) && 
                (
                    FingerRidgeMinutia == other.FingerRidgeMinutia ||
                    FingerRidgeMinutia != null &&
                    FingerRidgeMinutia.SequenceEqual(other.FingerRidgeMinutia)
                ) && 
                (
                    ExtendedFeatureSet == other.ExtendedFeatureSet ||
                    ExtendedFeatureSet != null &&
                    ExtendedFeatureSet.SequenceEqual(other.ExtendedFeatureSet)
                ) && 
                (
                    Incits == other.Incits ||
                    Incits != null &&
                    Incits.SequenceEqual(other.Incits)
                ) && 
                (
                    Other == other.Other ||
                    Other != null &&
                    Other.SequenceEqual(other.Other)
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
                    if (ImageCaptureDetail != null)
                    hashCode = hashCode * 59 + ImageCaptureDetail.GetHashCode();
                    if (FingerLocation != null)
                    hashCode = hashCode * 59 + FingerLocation.GetHashCode();
                    if (FingerprintCaptureTechnique != null)
                    hashCode = hashCode * 59 + FingerprintCaptureTechnique.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (FingerprintImageMajorCasePrint != null)
                    hashCode = hashCode * 59 + FingerprintImageMajorCasePrint.GetHashCode();
                    if (FingerprintImageSegmentPositionSquare != null)
                    hashCode = hashCode * 59 + FingerprintImageSegmentPositionSquare.GetHashCode();
                    if (FingerprintImageFingerMissing != null)
                    hashCode = hashCode * 59 + FingerprintImageFingerMissing.GetHashCode();
                    if (PositionUncertaintyValue != null)
                    hashCode = hashCode * 59 + PositionUncertaintyValue.GetHashCode();
                    if (MinutiaCharacterizationQualityValue != null)
                    hashCode = hashCode * 59 + MinutiaCharacterizationQualityValue.GetHashCode();
                    if (MinutiaClassifierQualityValue != null)
                    hashCode = hashCode * 59 + MinutiaClassifierQualityValue.GetHashCode();
                    if (FingerprintPatternCoreLocation != null)
                    hashCode = hashCode * 59 + FingerprintPatternCoreLocation.GetHashCode();
                    if (FingerprintPatternDeltaLocation != null)
                    hashCode = hashCode * 59 + FingerprintPatternDeltaLocation.GetHashCode();
                    if (IsFingerprintTaken != null)
                    hashCode = hashCode * 59 + IsFingerprintTaken.GetHashCode();
                    if (FingerprintCategoryDescription != null)
                    hashCode = hashCode * 59 + FingerprintCategoryDescription.GetHashCode();
                    if (FingerprintFeaturesFeedback != null)
                    hashCode = hashCode * 59 + FingerprintFeaturesFeedback.GetHashCode();
                    if (FingerprintFeaturesVersion != null)
                    hashCode = hashCode * 59 + FingerprintFeaturesVersion.GetHashCode();
                    if (FingerprintIdentification != null)
                    hashCode = hashCode * 59 + FingerprintIdentification.GetHashCode();
                    if (IsFormatNistStandard != null)
                    hashCode = hashCode * 59 + IsFormatNistStandard.GetHashCode();
                    if (FingerRidgeMinutia != null)
                    hashCode = hashCode * 59 + FingerRidgeMinutia.GetHashCode();
                    if (ExtendedFeatureSet != null)
                    hashCode = hashCode * 59 + ExtendedFeatureSet.GetHashCode();
                    if (Incits != null)
                    hashCode = hashCode * 59 + Incits.GetHashCode();
                    if (Other != null)
                    hashCode = hashCode * 59 + Other.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomMinutiaeType left, BiomMinutiaeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomMinutiaeType left, BiomMinutiaeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}