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
    /// A data type for a non-photographic imagery details. This contains imagery information that is not standard 2D photography captured with a camera using visible light.
    /// </summary>
    [DataContract]
    public partial class BiomNonPhotographicImageryDetailType : IEquatable<BiomNonPhotographicImageryDetailType>
    { 
        /// <summary>
        /// A collection of a biometric sample. NIEM reference is biom:BiometricCapture
        /// </summary>
        /// <value>A collection of a biometric sample. NIEM reference is biom:BiometricCapture</value>

        [DataMember(Name="biometricCapture")]
        public List<BiomBiometricCaptureType> BiometricCapture { get; set; }

        /// <summary>
        /// An imagery data block for the image NIEM reference is biom:MedicalImageryDataBlockBinaryObject
        /// </summary>
        /// <value>An imagery data block for the image NIEM reference is biom:MedicalImageryDataBlockBinaryObject</value>

        [DataMember(Name="medicalImageryDataBlockBinaryObject")]
        public List<NiemXsbase64Binary> MedicalImageryDataBlockBinaryObject { get; set; }

        /// <summary>
        /// A URI, URL or other unique reference to a storage location for an analog source representation. NIEM reference is biom:SourceExternalAnalogFileReferenceText
        /// </summary>
        /// <value>A URI, URL or other unique reference to a storage location for an analog source representation. NIEM reference is biom:SourceExternalAnalogFileReferenceText</value>

        [DataMember(Name="sourceExternalAnalogFileReference")]
        public List<NcTextType> SourceExternalAnalogFileReference { get; set; }

        /// <summary>
        /// A URI, URL or other unique reference to a storage location for a digital audio source representation. NIEM reference is biom:SourceExternalDigitalAudioReferenceText
        /// </summary>
        /// <value>A URI, URL or other unique reference to a storage location for a digital audio source representation. NIEM reference is biom:SourceExternalDigitalAudioReferenceText</value>

        [DataMember(Name="sourceExternalDigitalAudioReference")]
        public List<NcTextType> SourceExternalDigitalAudioReference { get; set; }

        /// <summary>
        /// A URI, URL or other unique reference to a storage location for a digital image source representation. NIEM reference is biom:SourceExternalDigitalImageReferenceText
        /// </summary>
        /// <value>A URI, URL or other unique reference to a storage location for a digital image source representation. NIEM reference is biom:SourceExternalDigitalImageReferenceText</value>

        [DataMember(Name="sourceExternalDigitalImageReference")]
        public List<NcTextType> SourceExternalDigitalImageReference { get; set; }

        /// <summary>
        /// A URI, URL or other unique reference to a storage location for a digital video source representation. NIEM reference is biom:SourceExternalDigitalVideoReferenceText
        /// </summary>
        /// <value>A URI, URL or other unique reference to a storage location for a digital video source representation. NIEM reference is biom:SourceExternalDigitalVideoReferenceText</value>

        [DataMember(Name="sourceExternalDigitalVideoReference")]
        public List<NcTextType> SourceExternalDigitalVideoReference { get; set; }

        /// <summary>
        /// A URI, URL or other unique reference to a storage location for a source representation. NIEM reference is biom:SourceExternalFileReferenceText
        /// </summary>
        /// <value>A URI, URL or other unique reference to a storage location for a source representation. NIEM reference is biom:SourceExternalFileReferenceText</value>

        [DataMember(Name="sourceExternalFileReference")]
        public List<NcTextType> SourceExternalFileReference { get; set; }

        /// <summary>
        /// An optional field. It is entered in the format as YyyyyMmmDdd. It is possible to enter only a year, month and/or day range, such as P5D, meaning that the actual date of collection is estimated to be 5 days plus or minus that specified in Field 10.00 NIEM reference is biom:ImageCaptureDateEstimateRangeDuration
        /// </summary>
        /// <value>An optional field. It is entered in the format as YyyyyMmmDdd. It is possible to enter only a year, month and/or day range, such as P5D, meaning that the actual date of collection is estimated to be 5 days plus or minus that specified in Field 10.00 NIEM reference is biom:ImageCaptureDateEstimateRangeDuration</value>

        [DataMember(Name="imageCaptureDateEstimateRangeDuration")]
        public List<NiemXsduration> ImageCaptureDateEstimateRangeDuration { get; set; }

        /// <summary>
        /// A kind of image of a person NIEM reference is biom:ImageCategoryCode
        /// </summary>
        /// <value>A kind of image of a person NIEM reference is biom:ImageCategoryCode</value>

        [DataMember(Name="imageCategoryCode")]
        public List<BiomPersonImageCategoryCodeType> ImageCategoryCode { get; set; }

        /// <summary>
        /// An optional field. This field is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. Note that Field 10.041: SMT size or size of injury or iden NIEM reference is biom:SubjectExistentialDetails
        /// </summary>
        /// <value>An optional field. This field is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances. Note that Field 10.041: SMT size or size of injury or iden NIEM reference is biom:SubjectExistentialDetails</value>

        [DataMember(Name="subjectExistentialDetails")]
        public List<BiomSubjectExistentialDetailsType> SubjectExistentialDetails { get; set; }

        /// <summary>
        /// A container for information specific to dental radiographic imagery NIEM reference is biom:DentalRadiographImageInformation
        /// </summary>
        /// <value>A container for information specific to dental radiographic imagery NIEM reference is biom:DentalRadiographImageInformation</value>

        [DataMember(Name="dentalRadiographImageInformation")]
        public List<BiomDentalRadiographImageInformationType> DentalRadiographImageInformation { get; set; }

        /// <summary>
        /// An Image Type Code for a kind of Non-photographic image NIEM reference is biom:NonPhotographicImageCategoryCode
        /// </summary>
        /// <value>An Image Type Code for a kind of Non-photographic image NIEM reference is biom:NonPhotographicImageCategoryCode</value>

        [DataMember(Name="nonPhotographicImageCategoryCode")]
        public List<BiomNonPhotographicImageCategoryCodeType> NonPhotographicImageCategoryCode { get; set; }

        /// <summary>
        /// A kind of Image Type for the Non-photographic image category NIEM reference is biom:NonPhotographicImageCategoryText
        /// </summary>
        /// <value>A kind of Image Type for the Non-photographic image category NIEM reference is biom:NonPhotographicImageCategoryText</value>

        [DataMember(Name="nonPhotographicImageCategory")]
        public List<NcTextType> NonPhotographicImageCategory { get; set; }

        /// <summary>
        /// A Non-photographic Image Format code NIEM reference is biom:NonPhotographicImageFormatCode
        /// </summary>
        /// <value>A Non-photographic Image Format code NIEM reference is biom:NonPhotographicImageFormatCode</value>

        [DataMember(Name="nonPhotographicImageFormatCode")]
        public List<NcTextType> NonPhotographicImageFormatCode { get; set; }

        /// <summary>
        /// A comment regarding a Non-photographic Imagery sample NIEM reference is biom:NonPhotographicImageryCommentText
        /// </summary>
        /// <value>A comment regarding a Non-photographic Imagery sample NIEM reference is biom:NonPhotographicImageryCommentText</value>

        [DataMember(Name="nonPhotographicImageryComment")]
        public List<NcTextType> NonPhotographicImageryComment { get; set; }

        /// <summary>
        /// biomNonPhotographicImageryDetailType JSON-LD context
        /// </summary>
        /// <value>biomNonPhotographicImageryDetailType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomNonPhotographicImageryDetailTypeContextJsonldEnum for ../JSON-LD_Contexts/biomNonPhotographicImageryDetailTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomNonPhotographicImageryDetailTypeContext.jsonld")]
            JSONLDContextsbiomNonPhotographicImageryDetailTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomNonPhotographicImageryDetailType JSON-LD context
        /// </summary>
        /// <value>biomNonPhotographicImageryDetailType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomNonPhotographicImageryDetailType {\n");
            sb.Append("  BiometricCapture: ").Append(BiometricCapture).Append("\n");
            sb.Append("  MedicalImageryDataBlockBinaryObject: ").Append(MedicalImageryDataBlockBinaryObject).Append("\n");
            sb.Append("  SourceExternalAnalogFileReference: ").Append(SourceExternalAnalogFileReference).Append("\n");
            sb.Append("  SourceExternalDigitalAudioReference: ").Append(SourceExternalDigitalAudioReference).Append("\n");
            sb.Append("  SourceExternalDigitalImageReference: ").Append(SourceExternalDigitalImageReference).Append("\n");
            sb.Append("  SourceExternalDigitalVideoReference: ").Append(SourceExternalDigitalVideoReference).Append("\n");
            sb.Append("  SourceExternalFileReference: ").Append(SourceExternalFileReference).Append("\n");
            sb.Append("  ImageCaptureDateEstimateRangeDuration: ").Append(ImageCaptureDateEstimateRangeDuration).Append("\n");
            sb.Append("  ImageCategoryCode: ").Append(ImageCategoryCode).Append("\n");
            sb.Append("  SubjectExistentialDetails: ").Append(SubjectExistentialDetails).Append("\n");
            sb.Append("  DentalRadiographImageInformation: ").Append(DentalRadiographImageInformation).Append("\n");
            sb.Append("  NonPhotographicImageCategoryCode: ").Append(NonPhotographicImageCategoryCode).Append("\n");
            sb.Append("  NonPhotographicImageCategory: ").Append(NonPhotographicImageCategory).Append("\n");
            sb.Append("  NonPhotographicImageFormatCode: ").Append(NonPhotographicImageFormatCode).Append("\n");
            sb.Append("  NonPhotographicImageryComment: ").Append(NonPhotographicImageryComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomNonPhotographicImageryDetailType)obj);
        }

        /// <summary>
        /// Returns true if BiomNonPhotographicImageryDetailType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomNonPhotographicImageryDetailType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomNonPhotographicImageryDetailType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BiometricCapture == other.BiometricCapture ||
                    BiometricCapture != null &&
                    BiometricCapture.SequenceEqual(other.BiometricCapture)
                ) && 
                (
                    MedicalImageryDataBlockBinaryObject == other.MedicalImageryDataBlockBinaryObject ||
                    MedicalImageryDataBlockBinaryObject != null &&
                    MedicalImageryDataBlockBinaryObject.SequenceEqual(other.MedicalImageryDataBlockBinaryObject)
                ) && 
                (
                    SourceExternalAnalogFileReference == other.SourceExternalAnalogFileReference ||
                    SourceExternalAnalogFileReference != null &&
                    SourceExternalAnalogFileReference.SequenceEqual(other.SourceExternalAnalogFileReference)
                ) && 
                (
                    SourceExternalDigitalAudioReference == other.SourceExternalDigitalAudioReference ||
                    SourceExternalDigitalAudioReference != null &&
                    SourceExternalDigitalAudioReference.SequenceEqual(other.SourceExternalDigitalAudioReference)
                ) && 
                (
                    SourceExternalDigitalImageReference == other.SourceExternalDigitalImageReference ||
                    SourceExternalDigitalImageReference != null &&
                    SourceExternalDigitalImageReference.SequenceEqual(other.SourceExternalDigitalImageReference)
                ) && 
                (
                    SourceExternalDigitalVideoReference == other.SourceExternalDigitalVideoReference ||
                    SourceExternalDigitalVideoReference != null &&
                    SourceExternalDigitalVideoReference.SequenceEqual(other.SourceExternalDigitalVideoReference)
                ) && 
                (
                    SourceExternalFileReference == other.SourceExternalFileReference ||
                    SourceExternalFileReference != null &&
                    SourceExternalFileReference.SequenceEqual(other.SourceExternalFileReference)
                ) && 
                (
                    ImageCaptureDateEstimateRangeDuration == other.ImageCaptureDateEstimateRangeDuration ||
                    ImageCaptureDateEstimateRangeDuration != null &&
                    ImageCaptureDateEstimateRangeDuration.SequenceEqual(other.ImageCaptureDateEstimateRangeDuration)
                ) && 
                (
                    ImageCategoryCode == other.ImageCategoryCode ||
                    ImageCategoryCode != null &&
                    ImageCategoryCode.SequenceEqual(other.ImageCategoryCode)
                ) && 
                (
                    SubjectExistentialDetails == other.SubjectExistentialDetails ||
                    SubjectExistentialDetails != null &&
                    SubjectExistentialDetails.SequenceEqual(other.SubjectExistentialDetails)
                ) && 
                (
                    DentalRadiographImageInformation == other.DentalRadiographImageInformation ||
                    DentalRadiographImageInformation != null &&
                    DentalRadiographImageInformation.SequenceEqual(other.DentalRadiographImageInformation)
                ) && 
                (
                    NonPhotographicImageCategoryCode == other.NonPhotographicImageCategoryCode ||
                    NonPhotographicImageCategoryCode != null &&
                    NonPhotographicImageCategoryCode.SequenceEqual(other.NonPhotographicImageCategoryCode)
                ) && 
                (
                    NonPhotographicImageCategory == other.NonPhotographicImageCategory ||
                    NonPhotographicImageCategory != null &&
                    NonPhotographicImageCategory.SequenceEqual(other.NonPhotographicImageCategory)
                ) && 
                (
                    NonPhotographicImageFormatCode == other.NonPhotographicImageFormatCode ||
                    NonPhotographicImageFormatCode != null &&
                    NonPhotographicImageFormatCode.SequenceEqual(other.NonPhotographicImageFormatCode)
                ) && 
                (
                    NonPhotographicImageryComment == other.NonPhotographicImageryComment ||
                    NonPhotographicImageryComment != null &&
                    NonPhotographicImageryComment.SequenceEqual(other.NonPhotographicImageryComment)
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
                    if (BiometricCapture != null)
                    hashCode = hashCode * 59 + BiometricCapture.GetHashCode();
                    if (MedicalImageryDataBlockBinaryObject != null)
                    hashCode = hashCode * 59 + MedicalImageryDataBlockBinaryObject.GetHashCode();
                    if (SourceExternalAnalogFileReference != null)
                    hashCode = hashCode * 59 + SourceExternalAnalogFileReference.GetHashCode();
                    if (SourceExternalDigitalAudioReference != null)
                    hashCode = hashCode * 59 + SourceExternalDigitalAudioReference.GetHashCode();
                    if (SourceExternalDigitalImageReference != null)
                    hashCode = hashCode * 59 + SourceExternalDigitalImageReference.GetHashCode();
                    if (SourceExternalDigitalVideoReference != null)
                    hashCode = hashCode * 59 + SourceExternalDigitalVideoReference.GetHashCode();
                    if (SourceExternalFileReference != null)
                    hashCode = hashCode * 59 + SourceExternalFileReference.GetHashCode();
                    if (ImageCaptureDateEstimateRangeDuration != null)
                    hashCode = hashCode * 59 + ImageCaptureDateEstimateRangeDuration.GetHashCode();
                    if (ImageCategoryCode != null)
                    hashCode = hashCode * 59 + ImageCategoryCode.GetHashCode();
                    if (SubjectExistentialDetails != null)
                    hashCode = hashCode * 59 + SubjectExistentialDetails.GetHashCode();
                    if (DentalRadiographImageInformation != null)
                    hashCode = hashCode * 59 + DentalRadiographImageInformation.GetHashCode();
                    if (NonPhotographicImageCategoryCode != null)
                    hashCode = hashCode * 59 + NonPhotographicImageCategoryCode.GetHashCode();
                    if (NonPhotographicImageCategory != null)
                    hashCode = hashCode * 59 + NonPhotographicImageCategory.GetHashCode();
                    if (NonPhotographicImageFormatCode != null)
                    hashCode = hashCode * 59 + NonPhotographicImageFormatCode.GetHashCode();
                    if (NonPhotographicImageryComment != null)
                    hashCode = hashCode * 59 + NonPhotographicImageryComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomNonPhotographicImageryDetailType left, BiomNonPhotographicImageryDetailType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomNonPhotographicImageryDetailType left, BiomNonPhotographicImageryDetailType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}