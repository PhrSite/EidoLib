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
    /// A data type for the details about a friction ridge image
    /// </summary>
    [DataContract]
    public partial class BiomFrictionRidgeDetailType : BiomImageType, IEquatable<BiomFrictionRidgeDetailType>
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
        /// A code for latent friction ridge positions NIEM reference is biom:LatentFrictionRidgePositionCode
        /// </summary>
        /// <value>A code for latent friction ridge positions NIEM reference is biom:LatentFrictionRidgePositionCode</value>

        [DataMember(Name="latentFrictionRidgePositionCode")]
        public List<string> LatentFrictionRidgePositionCode { get; set; }

        /// <summary>
        /// A set of information required when finger position code is \&quot;19\&quot; complete friction ridge exemplars NIEM reference is biom:FingerprintImageMajorCasePrint
        /// </summary>
        /// <value>A set of information required when finger position code is \&quot;19\&quot; complete friction ridge exemplars NIEM reference is biom:FingerprintImageMajorCasePrint</value>

        [DataMember(Name="fingerprintImageMajorCasePrint")]
        public List<BiomFingerprintImageMajorCasePrintType> FingerprintImageMajorCasePrint { get; set; }

        /// <summary>
        /// A quality metric for a friction ridge image NIEM reference is biom:FrictionRidgeImageQuality
        /// </summary>
        /// <value>A quality metric for a friction ridge image NIEM reference is biom:FrictionRidgeImageQuality</value>

        [DataMember(Name="frictionRidgeImageQuality")]
        public List<BiomFrictionRidgeImageQualityType> FrictionRidgeImageQuality { get; set; }

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
        /// An optional field states the method used for determining the pixel density of the image. NIEM reference is biom:ResolutionMethodInformation
        /// </summary>
        /// <value>An optional field states the method used for determining the pixel density of the image. NIEM reference is biom:ResolutionMethodInformation</value>

        [DataMember(Name="resolutionMethodInformation")]
        public List<BiomResolutionMethodInformationType> ResolutionMethodInformation { get; set; }

        /// <summary>
        /// An optional field. This field is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. Note that Field 10.041: SMT size or size of injury or iden NIEM reference is biom:SubjectExistentialDetails
        /// </summary>
        /// <value>An optional field. This field is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. Note that Field 10.041: SMT size or size of injury or iden NIEM reference is biom:SubjectExistentialDetails</value>

        [DataMember(Name="subjectExistentialDetails")]
        public List<BiomSubjectExistentialDetailsType> SubjectExistentialDetails { get; set; }

        /// <summary>
        /// biomFrictionRidgeDetailType JSON-LD context
        /// </summary>
        /// <value>biomFrictionRidgeDetailType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFrictionRidgeDetailTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFrictionRidgeDetailTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFrictionRidgeDetailTypeContext.jsonld")]
            JSONLDContextsbiomFrictionRidgeDetailTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFrictionRidgeDetailType JSON-LD context
        /// </summary>
        /// <value>biomFrictionRidgeDetailType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFrictionRidgeDetailType {\n");
            sb.Append("  FingerprintImageImpressionCaptureCategoryCode: ").Append(FingerprintImageImpressionCaptureCategoryCode).Append("\n");
            sb.Append("  FrictionRidgeImageImpressionCaptureCategoryCode: ").Append(FrictionRidgeImageImpressionCaptureCategoryCode).Append("\n");
            sb.Append("  FrictionRidgeImpressionCaptureCode: ").Append(FrictionRidgeImpressionCaptureCode).Append("\n");
            sb.Append("  FrictionRidgeCaptureTechnologyCode: ").Append(FrictionRidgeCaptureTechnologyCode).Append("\n");
            sb.Append("  LatentFrictionRidgePositionCode: ").Append(LatentFrictionRidgePositionCode).Append("\n");
            sb.Append("  FingerprintImageMajorCasePrint: ").Append(FingerprintImageMajorCasePrint).Append("\n");
            sb.Append("  FrictionRidgeImageQuality: ").Append(FrictionRidgeImageQuality).Append("\n");
            sb.Append("  RulerScalePresenceInformation: ").Append(RulerScalePresenceInformation).Append("\n");
            sb.Append("  StandardFingerprintFormNumber: ").Append(StandardFingerprintFormNumber).Append("\n");
            sb.Append("  ResolutionMethodInformation: ").Append(ResolutionMethodInformation).Append("\n");
            sb.Append("  SubjectExistentialDetails: ").Append(SubjectExistentialDetails).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFrictionRidgeDetailType)obj);
        }

        /// <summary>
        /// Returns true if BiomFrictionRidgeDetailType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFrictionRidgeDetailType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFrictionRidgeDetailType other)
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
                    LatentFrictionRidgePositionCode == other.LatentFrictionRidgePositionCode ||
                    LatentFrictionRidgePositionCode != null &&
                    LatentFrictionRidgePositionCode.SequenceEqual(other.LatentFrictionRidgePositionCode)
                ) && 
                (
                    FingerprintImageMajorCasePrint == other.FingerprintImageMajorCasePrint ||
                    FingerprintImageMajorCasePrint != null &&
                    FingerprintImageMajorCasePrint.SequenceEqual(other.FingerprintImageMajorCasePrint)
                ) && 
                (
                    FrictionRidgeImageQuality == other.FrictionRidgeImageQuality ||
                    FrictionRidgeImageQuality != null &&
                    FrictionRidgeImageQuality.SequenceEqual(other.FrictionRidgeImageQuality)
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
                    ResolutionMethodInformation == other.ResolutionMethodInformation ||
                    ResolutionMethodInformation != null &&
                    ResolutionMethodInformation.SequenceEqual(other.ResolutionMethodInformation)
                ) && 
                (
                    SubjectExistentialDetails == other.SubjectExistentialDetails ||
                    SubjectExistentialDetails != null &&
                    SubjectExistentialDetails.SequenceEqual(other.SubjectExistentialDetails)
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
                    if (LatentFrictionRidgePositionCode != null)
                    hashCode = hashCode * 59 + LatentFrictionRidgePositionCode.GetHashCode();
                    if (FingerprintImageMajorCasePrint != null)
                    hashCode = hashCode * 59 + FingerprintImageMajorCasePrint.GetHashCode();
                    if (FrictionRidgeImageQuality != null)
                    hashCode = hashCode * 59 + FrictionRidgeImageQuality.GetHashCode();
                    if (RulerScalePresenceInformation != null)
                    hashCode = hashCode * 59 + RulerScalePresenceInformation.GetHashCode();
                    if (StandardFingerprintFormNumber != null)
                    hashCode = hashCode * 59 + StandardFingerprintFormNumber.GetHashCode();
                    if (ResolutionMethodInformation != null)
                    hashCode = hashCode * 59 + ResolutionMethodInformation.GetHashCode();
                    if (SubjectExistentialDetails != null)
                    hashCode = hashCode * 59 + SubjectExistentialDetails.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFrictionRidgeDetailType left, BiomFrictionRidgeDetailType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFrictionRidgeDetailType left, BiomFrictionRidgeDetailType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
