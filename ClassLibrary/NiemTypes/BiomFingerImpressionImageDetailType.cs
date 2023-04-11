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
    /// A data type for the details about a fingerprint image
    /// </summary>
    [DataContract]
    public partial class BiomFingerImpressionImageDetailType : BiomImageType, IEquatable<BiomFingerImpressionImageDetailType>
    { 
        /// <summary>
        /// A kind of impression capture by which a fingerprint image information was obtained NIEM reference is biom:FingerprintImageImpressionCaptureCategoryCode
        /// </summary>
        /// <value>A kind of impression capture by which a fingerprint image information was obtained NIEM reference is biom:FingerprintImageImpressionCaptureCategoryCode</value>

        [DataMember(Name="fingerprintImageImpressionCaptureCategoryCode")]
        public List<BiomImpressionCaptureCategoryCodeType> FingerprintImageImpressionCaptureCategoryCode { get; set; }

        /// <summary>
        /// A kind of impression capture by which friction ridge image information was obtained NIEM reference is biom:FrictionRidgeImageImpressionCaptureCategoryCode
        /// </summary>
        /// <value>A kind of impression capture by which friction ridge image information was obtained NIEM reference is biom:FrictionRidgeImageImpressionCaptureCategoryCode</value>

        [DataMember(Name="frictionRidgeImageImpressionCaptureCategoryCode")]
        public List<BiomImpressionCaptureCategoryCodeType> FrictionRidgeImageImpressionCaptureCategoryCode { get; set; }

        /// <summary>
        /// A method used to capture a friction ridge impression. Conforms to ITL 2015. NIEM reference is biom:FrictionRidgeImpressionCaptureCode
        /// </summary>
        /// <value>A method used to capture a friction ridge impression. Conforms to ITL 2015. NIEM reference is biom:FrictionRidgeImpressionCaptureCode</value>

        [DataMember(Name="frictionRidgeImpressionCaptureCode")]
        public List<BiomImpressionCaptureCodeType> FrictionRidgeImpressionCaptureCode { get; set; }

        /// <summary>
        /// A technology used to capture friction ridge data NIEM reference is biom:FrictionRidgeCaptureTechnologyCode
        /// </summary>
        /// <value>A technology used to capture friction ridge data NIEM reference is biom:FrictionRidgeCaptureTechnologyCode</value>

        [DataMember(Name="frictionRidgeCaptureTechnologyCode")]
        public List<BiomFrictionRidgeCaptureTechnologyCodeType> FrictionRidgeCaptureTechnologyCode { get; set; }

        /// <summary>
        /// An element for basic finger positions and slap captures, standardly used for tenprint exemplar capture NIEM reference is biom:ExemplarFingerPositionCode
        /// </summary>
        /// <value>An element for basic finger positions and slap captures, standardly used for tenprint exemplar capture NIEM reference is biom:ExemplarFingerPositionCode</value>

        [DataMember(Name="exemplarFingerPositionCode")]
        public List<string> ExemplarFingerPositionCode { get; set; }

        /// <summary>
        /// A set of information required when finger position code is \&quot;19\&quot; complete friction ridge exemplars NIEM reference is biom:FingerprintImageMajorCasePrint
        /// </summary>
        /// <value>A set of information required when finger position code is \&quot;19\&quot; complete friction ridge exemplars NIEM reference is biom:FingerprintImageMajorCasePrint</value>

        [DataMember(Name="fingerprintImageMajorCasePrint")]
        public List<BiomFingerprintImageMajorCasePrintType> FingerprintImageMajorCasePrint { get; set; }

        /// <summary>
        /// A missing finger in a fingerprint image NIEM reference is biom:FingerprintImageFingerMissing
        /// </summary>
        /// <value>A missing finger in a fingerprint image NIEM reference is biom:FingerprintImageFingerMissing</value>

        [DataMember(Name="fingerprintImageFingerMissing")]
        public List<BiomFingerprintImageFingerMissingType> FingerprintImageFingerMissing { get; set; }

        /// <summary>
        /// A fingerprint image segment position square NIEM reference is biom:FingerprintImageSegmentPositionSquare
        /// </summary>
        /// <value>A fingerprint image segment position square NIEM reference is biom:FingerprintImageSegmentPositionSquare</value>

        [DataMember(Name="fingerprintImageSegmentPositionSquare")]
        public List<BiomFrictionRidgeImageSegmentPositionSquareType> FingerprintImageSegmentPositionSquare { get; set; }

        /// <summary>
        /// A quality measure of a fingerprint, as defined by NIST NIEM reference is biom:FingerprintImageNISTQuality
        /// </summary>
        /// <value>A quality measure of a fingerprint, as defined by NIST NIEM reference is biom:FingerprintImageNISTQuality</value>

        [DataMember(Name="fingerprintImageNistQuality")]
        public List<BiomFingerprintImageNISTQualityType> FingerprintImageNistQuality { get; set; }

        /// <summary>
        /// A fingerprint image quality NIEM reference is biom:FingerprintImageQuality
        /// </summary>
        /// <value>A fingerprint image quality NIEM reference is biom:FingerprintImageQuality</value>

        [DataMember(Name="fingerprintImageQuality")]
        public List<BiomFingerprintImageQualityType> FingerprintImageQuality { get; set; }

        /// <summary>
        /// A measure of accuracy of a slap print segmentation NIEM reference is biom:FingerprintImageSegmentationQuality
        /// </summary>
        /// <value>A measure of accuracy of a slap print segmentation NIEM reference is biom:FingerprintImageSegmentationQuality</value>

        [DataMember(Name="fingerprintImageSegmentationQuality")]
        public List<BiomFingerprintImageQualityType> FingerprintImageSegmentationQuality { get; set; }

        /// <summary>
        /// An index identifier to reference a set of prints captured simultaneously on adjacent platens. NIEM reference is biom:FingerprintSimultaneousCaptureID
        /// </summary>
        /// <value>An index identifier to reference a set of prints captured simultaneously on adjacent platens. NIEM reference is biom:FingerprintSimultaneousCaptureID</value>

        [DataMember(Name="fingerprintSimultaneousCaptureId")]
        public List<BiomInteger1to255Type> FingerprintSimultaneousCaptureId { get; set; }

        /// <summary>
        /// True if the image was formed by stitching together separately captured images; false otherwise. NIEM reference is biom:FingerprintImageStitchedIndicator
        /// </summary>
        /// <value>True if the image was formed by stitching together separately captured images; false otherwise. NIEM reference is biom:FingerprintImageStitchedIndicator</value>

        [DataMember(Name="isFingerprintImageStitched")]
        public List<NiemXsboolean> IsFingerprintImageStitched { get; set; }

        /// <summary>
        /// An optional field. This field is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. Note that Field 10.041: SMT size or size of injury or iden NIEM reference is biom:SubjectExistentialDetails
        /// </summary>
        /// <value>An optional field. This field is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. Note that Field 10.041: SMT size or size of injury or iden NIEM reference is biom:SubjectExistentialDetails</value>

        [DataMember(Name="subjectExistentialDetails")]
        public List<BiomSubjectExistentialDetailsType> SubjectExistentialDetails { get; set; }

        /// <summary>
        /// An optional field states the method used for determining the pixel density of the image. NIEM reference is biom:ResolutionMethodInformation
        /// </summary>
        /// <value>An optional field states the method used for determining the pixel density of the image. NIEM reference is biom:ResolutionMethodInformation</value>

        [DataMember(Name="resolutionMethodInformation")]
        public List<BiomResolutionMethodInformationType> ResolutionMethodInformation { get; set; }

        /// <summary>
        /// A fingerprint image segment position polygon NIEM reference is biom:FingerprintImageSegmentPositionPolygon
        /// </summary>
        /// <value>A fingerprint image segment position polygon NIEM reference is biom:FingerprintImageSegmentPositionPolygon</value>

        [DataMember(Name="fingerprintImageSegmentPositionPolygon")]
        public List<BiomFingerprintImageSegmentPositionPolygonType> FingerprintImageSegmentPositionPolygon { get; set; }

        /// <summary>
        /// An optional field allows the user to state whether a ruler or other known scale is present in the image. NIEM reference is biom:RulerScalePresenceInformation
        /// </summary>
        /// <value>An optional field allows the user to state whether a ruler or other known scale is present in the image. NIEM reference is biom:RulerScalePresenceInformation</value>

        [DataMember(Name="rulerScalePresenceInformation")]
        public List<BiomRulerScalePresenceInformationType> RulerScalePresenceInformation { get; set; }

        /// <summary>
        /// A standard fingerprint form number NIEM reference is biom:StandardFingerprintFormNumberText
        /// </summary>
        /// <value>A standard fingerprint form number NIEM reference is biom:StandardFingerprintFormNumberText</value>

        [DataMember(Name="standardFingerprintFormNumber")]
        public List<NcTextType> StandardFingerprintFormNumber { get; set; }

        /// <summary>
        /// A set of criteria under which the fingerprint image was captured NIEM reference is biom:FingerprintImageAcquisitionProfileCode
        /// </summary>
        /// <value>A set of criteria under which the fingerprint image was captured NIEM reference is biom:FingerprintImageAcquisitionProfileCode</value>

        [DataMember(Name="fingerprintImageAcquisitionProfileCode")]
        public List<BiomFingerprintImageAcquisitionProfileCodeType> FingerprintImageAcquisitionProfileCode { get; set; }

        /// <summary>
        /// biomFingerImpressionImageDetailType JSON-LD context
        /// </summary>
        /// <value>biomFingerImpressionImageDetailType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFingerImpressionImageDetailTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFingerImpressionImageDetailTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFingerImpressionImageDetailTypeContext.jsonld")]
            JSONLDContextsbiomFingerImpressionImageDetailTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFingerImpressionImageDetailType JSON-LD context
        /// </summary>
        /// <value>biomFingerImpressionImageDetailType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFingerImpressionImageDetailType {\n");
            sb.Append("  FingerprintImageImpressionCaptureCategoryCode: ").Append(FingerprintImageImpressionCaptureCategoryCode).Append("\n");
            sb.Append("  FrictionRidgeImageImpressionCaptureCategoryCode: ").Append(FrictionRidgeImageImpressionCaptureCategoryCode).Append("\n");
            sb.Append("  FrictionRidgeImpressionCaptureCode: ").Append(FrictionRidgeImpressionCaptureCode).Append("\n");
            sb.Append("  FrictionRidgeCaptureTechnologyCode: ").Append(FrictionRidgeCaptureTechnologyCode).Append("\n");
            sb.Append("  ExemplarFingerPositionCode: ").Append(ExemplarFingerPositionCode).Append("\n");
            sb.Append("  FingerprintImageMajorCasePrint: ").Append(FingerprintImageMajorCasePrint).Append("\n");
            sb.Append("  FingerprintImageFingerMissing: ").Append(FingerprintImageFingerMissing).Append("\n");
            sb.Append("  FingerprintImageSegmentPositionSquare: ").Append(FingerprintImageSegmentPositionSquare).Append("\n");
            sb.Append("  FingerprintImageNistQuality: ").Append(FingerprintImageNistQuality).Append("\n");
            sb.Append("  FingerprintImageQuality: ").Append(FingerprintImageQuality).Append("\n");
            sb.Append("  FingerprintImageSegmentationQuality: ").Append(FingerprintImageSegmentationQuality).Append("\n");
            sb.Append("  FingerprintSimultaneousCaptureId: ").Append(FingerprintSimultaneousCaptureId).Append("\n");
            sb.Append("  IsFingerprintImageStitched: ").Append(IsFingerprintImageStitched).Append("\n");
            sb.Append("  SubjectExistentialDetails: ").Append(SubjectExistentialDetails).Append("\n");
            sb.Append("  ResolutionMethodInformation: ").Append(ResolutionMethodInformation).Append("\n");
            sb.Append("  FingerprintImageSegmentPositionPolygon: ").Append(FingerprintImageSegmentPositionPolygon).Append("\n");
            sb.Append("  RulerScalePresenceInformation: ").Append(RulerScalePresenceInformation).Append("\n");
            sb.Append("  StandardFingerprintFormNumber: ").Append(StandardFingerprintFormNumber).Append("\n");
            sb.Append("  FingerprintImageAcquisitionProfileCode: ").Append(FingerprintImageAcquisitionProfileCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFingerImpressionImageDetailType)obj);
        }

        /// <summary>
        /// Returns true if BiomFingerImpressionImageDetailType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFingerImpressionImageDetailType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFingerImpressionImageDetailType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FingerprintImageImpressionCaptureCategoryCode == other.FingerprintImageImpressionCaptureCategoryCode ||
                    FingerprintImageImpressionCaptureCategoryCode != null &&
                    FingerprintImageImpressionCaptureCategoryCode.SequenceEqual(other.FingerprintImageImpressionCaptureCategoryCode)
                ) && 
                (
                    FrictionRidgeImageImpressionCaptureCategoryCode == other.FrictionRidgeImageImpressionCaptureCategoryCode ||
                    FrictionRidgeImageImpressionCaptureCategoryCode != null &&
                    FrictionRidgeImageImpressionCaptureCategoryCode.SequenceEqual(other.FrictionRidgeImageImpressionCaptureCategoryCode)
                ) && 
                (
                    FrictionRidgeImpressionCaptureCode == other.FrictionRidgeImpressionCaptureCode ||
                    FrictionRidgeImpressionCaptureCode != null &&
                    FrictionRidgeImpressionCaptureCode.SequenceEqual(other.FrictionRidgeImpressionCaptureCode)
                ) && 
                (
                    FrictionRidgeCaptureTechnologyCode == other.FrictionRidgeCaptureTechnologyCode ||
                    FrictionRidgeCaptureTechnologyCode != null &&
                    FrictionRidgeCaptureTechnologyCode.SequenceEqual(other.FrictionRidgeCaptureTechnologyCode)
                ) && 
                (
                    ExemplarFingerPositionCode == other.ExemplarFingerPositionCode ||
                    ExemplarFingerPositionCode != null &&
                    ExemplarFingerPositionCode.SequenceEqual(other.ExemplarFingerPositionCode)
                ) && 
                (
                    FingerprintImageMajorCasePrint == other.FingerprintImageMajorCasePrint ||
                    FingerprintImageMajorCasePrint != null &&
                    FingerprintImageMajorCasePrint.SequenceEqual(other.FingerprintImageMajorCasePrint)
                ) && 
                (
                    FingerprintImageFingerMissing == other.FingerprintImageFingerMissing ||
                    FingerprintImageFingerMissing != null &&
                    FingerprintImageFingerMissing.SequenceEqual(other.FingerprintImageFingerMissing)
                ) && 
                (
                    FingerprintImageSegmentPositionSquare == other.FingerprintImageSegmentPositionSquare ||
                    FingerprintImageSegmentPositionSquare != null &&
                    FingerprintImageSegmentPositionSquare.SequenceEqual(other.FingerprintImageSegmentPositionSquare)
                ) && 
                (
                    FingerprintImageNistQuality == other.FingerprintImageNistQuality ||
                    FingerprintImageNistQuality != null &&
                    FingerprintImageNistQuality.SequenceEqual(other.FingerprintImageNistQuality)
                ) && 
                (
                    FingerprintImageQuality == other.FingerprintImageQuality ||
                    FingerprintImageQuality != null &&
                    FingerprintImageQuality.SequenceEqual(other.FingerprintImageQuality)
                ) && 
                (
                    FingerprintImageSegmentationQuality == other.FingerprintImageSegmentationQuality ||
                    FingerprintImageSegmentationQuality != null &&
                    FingerprintImageSegmentationQuality.SequenceEqual(other.FingerprintImageSegmentationQuality)
                ) && 
                (
                    FingerprintSimultaneousCaptureId == other.FingerprintSimultaneousCaptureId ||
                    FingerprintSimultaneousCaptureId != null &&
                    FingerprintSimultaneousCaptureId.SequenceEqual(other.FingerprintSimultaneousCaptureId)
                ) && 
                (
                    IsFingerprintImageStitched == other.IsFingerprintImageStitched ||
                    IsFingerprintImageStitched != null &&
                    IsFingerprintImageStitched.SequenceEqual(other.IsFingerprintImageStitched)
                ) && 
                (
                    SubjectExistentialDetails == other.SubjectExistentialDetails ||
                    SubjectExistentialDetails != null &&
                    SubjectExistentialDetails.SequenceEqual(other.SubjectExistentialDetails)
                ) && 
                (
                    ResolutionMethodInformation == other.ResolutionMethodInformation ||
                    ResolutionMethodInformation != null &&
                    ResolutionMethodInformation.SequenceEqual(other.ResolutionMethodInformation)
                ) && 
                (
                    FingerprintImageSegmentPositionPolygon == other.FingerprintImageSegmentPositionPolygon ||
                    FingerprintImageSegmentPositionPolygon != null &&
                    FingerprintImageSegmentPositionPolygon.SequenceEqual(other.FingerprintImageSegmentPositionPolygon)
                ) && 
                (
                    RulerScalePresenceInformation == other.RulerScalePresenceInformation ||
                    RulerScalePresenceInformation != null &&
                    RulerScalePresenceInformation.SequenceEqual(other.RulerScalePresenceInformation)
                ) && 
                (
                    StandardFingerprintFormNumber == other.StandardFingerprintFormNumber ||
                    StandardFingerprintFormNumber != null &&
                    StandardFingerprintFormNumber.SequenceEqual(other.StandardFingerprintFormNumber)
                ) && 
                (
                    FingerprintImageAcquisitionProfileCode == other.FingerprintImageAcquisitionProfileCode ||
                    FingerprintImageAcquisitionProfileCode != null &&
                    FingerprintImageAcquisitionProfileCode.SequenceEqual(other.FingerprintImageAcquisitionProfileCode)
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
                    if (FingerprintImageImpressionCaptureCategoryCode != null)
                    hashCode = hashCode * 59 + FingerprintImageImpressionCaptureCategoryCode.GetHashCode();
                    if (FrictionRidgeImageImpressionCaptureCategoryCode != null)
                    hashCode = hashCode * 59 + FrictionRidgeImageImpressionCaptureCategoryCode.GetHashCode();
                    if (FrictionRidgeImpressionCaptureCode != null)
                    hashCode = hashCode * 59 + FrictionRidgeImpressionCaptureCode.GetHashCode();
                    if (FrictionRidgeCaptureTechnologyCode != null)
                    hashCode = hashCode * 59 + FrictionRidgeCaptureTechnologyCode.GetHashCode();
                    if (ExemplarFingerPositionCode != null)
                    hashCode = hashCode * 59 + ExemplarFingerPositionCode.GetHashCode();
                    if (FingerprintImageMajorCasePrint != null)
                    hashCode = hashCode * 59 + FingerprintImageMajorCasePrint.GetHashCode();
                    if (FingerprintImageFingerMissing != null)
                    hashCode = hashCode * 59 + FingerprintImageFingerMissing.GetHashCode();
                    if (FingerprintImageSegmentPositionSquare != null)
                    hashCode = hashCode * 59 + FingerprintImageSegmentPositionSquare.GetHashCode();
                    if (FingerprintImageNistQuality != null)
                    hashCode = hashCode * 59 + FingerprintImageNistQuality.GetHashCode();
                    if (FingerprintImageQuality != null)
                    hashCode = hashCode * 59 + FingerprintImageQuality.GetHashCode();
                    if (FingerprintImageSegmentationQuality != null)
                    hashCode = hashCode * 59 + FingerprintImageSegmentationQuality.GetHashCode();
                    if (FingerprintSimultaneousCaptureId != null)
                    hashCode = hashCode * 59 + FingerprintSimultaneousCaptureId.GetHashCode();
                    if (IsFingerprintImageStitched != null)
                    hashCode = hashCode * 59 + IsFingerprintImageStitched.GetHashCode();
                    if (SubjectExistentialDetails != null)
                    hashCode = hashCode * 59 + SubjectExistentialDetails.GetHashCode();
                    if (ResolutionMethodInformation != null)
                    hashCode = hashCode * 59 + ResolutionMethodInformation.GetHashCode();
                    if (FingerprintImageSegmentPositionPolygon != null)
                    hashCode = hashCode * 59 + FingerprintImageSegmentPositionPolygon.GetHashCode();
                    if (RulerScalePresenceInformation != null)
                    hashCode = hashCode * 59 + RulerScalePresenceInformation.GetHashCode();
                    if (StandardFingerprintFormNumber != null)
                    hashCode = hashCode * 59 + StandardFingerprintFormNumber.GetHashCode();
                    if (FingerprintImageAcquisitionProfileCode != null)
                    hashCode = hashCode * 59 + FingerprintImageAcquisitionProfileCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFingerImpressionImageDetailType left, BiomFingerImpressionImageDetailType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFingerImpressionImageDetailType left, BiomFingerImpressionImageDetailType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
