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
    /// A data type for an image of a physical feature
    /// </summary>
    [DataContract]
    public partial class BiomPhysicalFeatureImageType : BiomImageType, IEquatable<BiomPhysicalFeatureImageType>
    { 
        /// <summary>
        /// A size of a scar, mark, or tattoo NIEM reference is biom:PhysicalFeatureSize
        /// </summary>
        /// <value>A size of a scar, mark, or tattoo NIEM reference is biom:PhysicalFeatureSize</value>

        [DataMember(Name="physicalFeatureSize")]
        public List<BiomPhysicalFeatureSizeType> PhysicalFeatureSize { get; set; }

        /// <summary>
        /// An identifier for an image reference number that correlates type 10 images of the same feature, such as an full SMT image and a close up image NIEM reference is biom:Type10CrossReferenceID
        /// </summary>
        /// <value>An identifier for an image reference number that correlates type 10 images of the same feature, such as an full SMT image and a close up image NIEM reference is biom:Type10CrossReferenceID</value>

        [DataMember(Name="type10CrossReferenceId")]
        public List<BiomInteger0to99Type> Type10CrossReferenceId { get; set; }

        /// <summary>
        /// A kind of transformation of an image NIEM reference is biom:ImageTransformationCode
        /// </summary>
        /// <value>A kind of transformation of an image NIEM reference is biom:ImageTransformationCode</value>

        [DataMember(Name="imageTransformationCode")]
        public List<BiomImageTransformationCodeType> ImageTransformationCode { get; set; }

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
        /// A data field that is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. SMT size or size of injury or identifying characteristic / SMS should NIEM reference is biom:CheiloscopicImageInformation
        /// </summary>
        /// <value>A data field that is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. SMT size or size of injury or identifying characteristic / SMS should NIEM reference is biom:CheiloscopicImageInformation</value>

        [DataMember(Name="cheiloscopicImageInformation")]
        public List<BiomCheiloscopicImageInformationType> CheiloscopicImageInformation { get; set; }

        /// <summary>
        /// An optional field allows the entry of information concerning suspected patterned injuries. NIEM reference is biom:PatternedInjuryDetail
        /// </summary>
        /// <value>An optional field allows the entry of information concerning suspected patterned injuries. NIEM reference is biom:PatternedInjuryDetail</value>

        [DataMember(Name="patternedInjuryDetail")]
        public List<BiomPatternedInjuryDetailType> PatternedInjuryDetail { get; set; }

        /// <summary>
        /// An optional field allows the user to state whether a ruler or other known scale is present in the image. NIEM reference is biom:RulerScalePresenceInformation
        /// </summary>
        /// <value>An optional field allows the user to state whether a ruler or other known scale is present in the image. NIEM reference is biom:RulerScalePresenceInformation</value>

        [DataMember(Name="rulerScalePresenceInformation")]
        public List<BiomRulerScalePresenceInformationType> RulerScalePresenceInformation { get; set; }

        /// <summary>
        /// An optional field allows the entry of information concerning type-10 images of the mouth. NIEM reference is biom:DentalVisualImageDataInformation
        /// </summary>
        /// <value>An optional field allows the entry of information concerning type-10 images of the mouth. NIEM reference is biom:DentalVisualImageDataInformation</value>

        [DataMember(Name="dentalVisualImageDataInformation")]
        public List<BiomDentalVisualImageDataInformationType> DentalVisualImageDataInformation { get; set; }

        /// <summary>
        /// A description of a physical feature from the NCIC codes. NIEM reference is biom:PhysicalFeatureNCICCode
        /// </summary>
        /// <value>A description of a physical feature from the NCIC codes. NIEM reference is biom:PhysicalFeatureNCICCode</value>

        [DataMember(Name="physicalFeatureNcicCode")]
        public List<NcicSMTCodeType> PhysicalFeatureNcicCode { get; set; }

        /// <summary>
        /// A description of scars, marks, or tattoos visible in a transmitted image NIEM reference is biom:PhysicalFeatureDescriptionDetail
        /// </summary>
        /// <value>A description of scars, marks, or tattoos visible in a transmitted image NIEM reference is biom:PhysicalFeatureDescriptionDetail</value>

        [DataMember(Name="physicalFeatureDescriptionDetail")]
        public List<BiomPhysicalFeatureDescriptionType> PhysicalFeatureDescriptionDetail { get; set; }

        /// <summary>
        /// A contour feature in a face image NIEM reference is biom:FaceImageContour
        /// </summary>
        /// <value>A contour feature in a face image NIEM reference is biom:FaceImageContour</value>

        [DataMember(Name="faceImageContour")]
        public List<BiomFaceImageContourType> FaceImageContour { get; set; }

        /// <summary>
        /// A set of attributes describing 2D, MPEG4 facial feature points and their locations NIEM reference is biom:FaceImage2DFeaturePoint
        /// </summary>
        /// <value>A set of attributes describing 2D, MPEG4 facial feature points and their locations NIEM reference is biom:FaceImage2DFeaturePoint</value>

        [DataMember(Name="faceImage2DFeaturePoint")]
        public List<BiomFaceImageFeaturePointType> FaceImage2DFeaturePoint { get; set; }

        /// <summary>
        /// A face feature point that includes a Z-coordinate NIEM reference is biom:FaceImage3DFeaturePoint
        /// </summary>
        /// <value>A face feature point that includes a Z-coordinate NIEM reference is biom:FaceImage3DFeaturePoint</value>

        [DataMember(Name="faceImage3DFeaturePoint")]
        public List<BiomFaceImage3DFeaturePointType> FaceImage3DFeaturePoint { get; set; }

        /// <summary>
        /// biomPhysicalFeatureImageType JSON-LD context
        /// </summary>
        /// <value>biomPhysicalFeatureImageType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomPhysicalFeatureImageTypeContextJsonldEnum for ../JSON-LD_Contexts/biomPhysicalFeatureImageTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomPhysicalFeatureImageTypeContext.jsonld")]
            JSONLDContextsbiomPhysicalFeatureImageTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomPhysicalFeatureImageType JSON-LD context
        /// </summary>
        /// <value>biomPhysicalFeatureImageType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomPhysicalFeatureImageType {\n");
            sb.Append("  PhysicalFeatureSize: ").Append(PhysicalFeatureSize).Append("\n");
            sb.Append("  Type10CrossReferenceId: ").Append(Type10CrossReferenceId).Append("\n");
            sb.Append("  ImageTransformationCode: ").Append(ImageTransformationCode).Append("\n");
            sb.Append("  SubjectExistentialDetails: ").Append(SubjectExistentialDetails).Append("\n");
            sb.Append("  ResolutionMethodInformation: ").Append(ResolutionMethodInformation).Append("\n");
            sb.Append("  CheiloscopicImageInformation: ").Append(CheiloscopicImageInformation).Append("\n");
            sb.Append("  PatternedInjuryDetail: ").Append(PatternedInjuryDetail).Append("\n");
            sb.Append("  RulerScalePresenceInformation: ").Append(RulerScalePresenceInformation).Append("\n");
            sb.Append("  DentalVisualImageDataInformation: ").Append(DentalVisualImageDataInformation).Append("\n");
            sb.Append("  PhysicalFeatureNcicCode: ").Append(PhysicalFeatureNcicCode).Append("\n");
            sb.Append("  PhysicalFeatureDescriptionDetail: ").Append(PhysicalFeatureDescriptionDetail).Append("\n");
            sb.Append("  FaceImageContour: ").Append(FaceImageContour).Append("\n");
            sb.Append("  FaceImage2DFeaturePoint: ").Append(FaceImage2DFeaturePoint).Append("\n");
            sb.Append("  FaceImage3DFeaturePoint: ").Append(FaceImage3DFeaturePoint).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomPhysicalFeatureImageType)obj);
        }

        /// <summary>
        /// Returns true if BiomPhysicalFeatureImageType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomPhysicalFeatureImageType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomPhysicalFeatureImageType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PhysicalFeatureSize == other.PhysicalFeatureSize ||
                    PhysicalFeatureSize != null &&
                    PhysicalFeatureSize.SequenceEqual(other.PhysicalFeatureSize)
                ) && 
                (
                    Type10CrossReferenceId == other.Type10CrossReferenceId ||
                    Type10CrossReferenceId != null &&
                    Type10CrossReferenceId.SequenceEqual(other.Type10CrossReferenceId)
                ) && 
                (
                    ImageTransformationCode == other.ImageTransformationCode ||
                    ImageTransformationCode != null &&
                    ImageTransformationCode.SequenceEqual(other.ImageTransformationCode)
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
                    CheiloscopicImageInformation == other.CheiloscopicImageInformation ||
                    CheiloscopicImageInformation != null &&
                    CheiloscopicImageInformation.SequenceEqual(other.CheiloscopicImageInformation)
                ) && 
                (
                    PatternedInjuryDetail == other.PatternedInjuryDetail ||
                    PatternedInjuryDetail != null &&
                    PatternedInjuryDetail.SequenceEqual(other.PatternedInjuryDetail)
                ) && 
                (
                    RulerScalePresenceInformation == other.RulerScalePresenceInformation ||
                    RulerScalePresenceInformation != null &&
                    RulerScalePresenceInformation.SequenceEqual(other.RulerScalePresenceInformation)
                ) && 
                (
                    DentalVisualImageDataInformation == other.DentalVisualImageDataInformation ||
                    DentalVisualImageDataInformation != null &&
                    DentalVisualImageDataInformation.SequenceEqual(other.DentalVisualImageDataInformation)
                ) && 
                (
                    PhysicalFeatureNcicCode == other.PhysicalFeatureNcicCode ||
                    PhysicalFeatureNcicCode != null &&
                    PhysicalFeatureNcicCode.SequenceEqual(other.PhysicalFeatureNcicCode)
                ) && 
                (
                    PhysicalFeatureDescriptionDetail == other.PhysicalFeatureDescriptionDetail ||
                    PhysicalFeatureDescriptionDetail != null &&
                    PhysicalFeatureDescriptionDetail.SequenceEqual(other.PhysicalFeatureDescriptionDetail)
                ) && 
                (
                    FaceImageContour == other.FaceImageContour ||
                    FaceImageContour != null &&
                    FaceImageContour.SequenceEqual(other.FaceImageContour)
                ) && 
                (
                    FaceImage2DFeaturePoint == other.FaceImage2DFeaturePoint ||
                    FaceImage2DFeaturePoint != null &&
                    FaceImage2DFeaturePoint.SequenceEqual(other.FaceImage2DFeaturePoint)
                ) && 
                (
                    FaceImage3DFeaturePoint == other.FaceImage3DFeaturePoint ||
                    FaceImage3DFeaturePoint != null &&
                    FaceImage3DFeaturePoint.SequenceEqual(other.FaceImage3DFeaturePoint)
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
                    if (PhysicalFeatureSize != null)
                    hashCode = hashCode * 59 + PhysicalFeatureSize.GetHashCode();
                    if (Type10CrossReferenceId != null)
                    hashCode = hashCode * 59 + Type10CrossReferenceId.GetHashCode();
                    if (ImageTransformationCode != null)
                    hashCode = hashCode * 59 + ImageTransformationCode.GetHashCode();
                    if (SubjectExistentialDetails != null)
                    hashCode = hashCode * 59 + SubjectExistentialDetails.GetHashCode();
                    if (ResolutionMethodInformation != null)
                    hashCode = hashCode * 59 + ResolutionMethodInformation.GetHashCode();
                    if (CheiloscopicImageInformation != null)
                    hashCode = hashCode * 59 + CheiloscopicImageInformation.GetHashCode();
                    if (PatternedInjuryDetail != null)
                    hashCode = hashCode * 59 + PatternedInjuryDetail.GetHashCode();
                    if (RulerScalePresenceInformation != null)
                    hashCode = hashCode * 59 + RulerScalePresenceInformation.GetHashCode();
                    if (DentalVisualImageDataInformation != null)
                    hashCode = hashCode * 59 + DentalVisualImageDataInformation.GetHashCode();
                    if (PhysicalFeatureNcicCode != null)
                    hashCode = hashCode * 59 + PhysicalFeatureNcicCode.GetHashCode();
                    if (PhysicalFeatureDescriptionDetail != null)
                    hashCode = hashCode * 59 + PhysicalFeatureDescriptionDetail.GetHashCode();
                    if (FaceImageContour != null)
                    hashCode = hashCode * 59 + FaceImageContour.GetHashCode();
                    if (FaceImage2DFeaturePoint != null)
                    hashCode = hashCode * 59 + FaceImage2DFeaturePoint.GetHashCode();
                    if (FaceImage3DFeaturePoint != null)
                    hashCode = hashCode * 59 + FaceImage3DFeaturePoint.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomPhysicalFeatureImageType left, BiomPhysicalFeatureImageType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomPhysicalFeatureImageType left, BiomPhysicalFeatureImageType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
