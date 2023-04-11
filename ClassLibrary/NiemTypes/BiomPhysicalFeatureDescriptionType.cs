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
    /// A data type for a description of a physical feature
    /// </summary>
    [DataContract]
    public partial class BiomPhysicalFeatureDescriptionType : IEquatable<BiomPhysicalFeatureDescriptionType>
    { 
        /// <summary>
        /// A color of the eyes of a person. NIEM reference is j:PersonEyeColorCode
        /// </summary>
        /// <value>A color of the eyes of a person. NIEM reference is j:PersonEyeColorCode</value>

        [DataMember(Name="personEyeColorCode")]
        public List<NcicEYECodeType> PersonEyeColorCode { get; set; }

        /// <summary>
        /// A code set identifying an eye color of a person. NIEM reference is j:PersonEyeColorRapSheetCode
        /// </summary>
        /// <value>A code set identifying an eye color of a person. NIEM reference is j:PersonEyeColorRapSheetCode</value>

        [DataMember(Name="personEyeColorRapSheetCode")]
        public List<JPersonEyeColorCodeType> PersonEyeColorRapSheetCode { get; set; }

        /// <summary>
        /// A color of the eyes of a person. NIEM reference is nc:PersonEyeColorText
        /// </summary>
        /// <value>A color of the eyes of a person. NIEM reference is nc:PersonEyeColorText</value>

        [DataMember(Name="personEyeColor")]
        public List<NcTextType> PersonEyeColor { get; set; }

        /// <summary>
        /// An overall appearance of the hair of a person. NIEM reference is biom:PersonHairAppearanceText
        /// </summary>
        /// <value>An overall appearance of the hair of a person. NIEM reference is biom:PersonHairAppearanceText</value>

        [DataMember(Name="personHairAppearance")]
        public List<NcTextType> PersonHairAppearance { get; set; }

        /// <summary>
        /// A kind of hair of a person. NIEM reference is biom:PersonHairCategoryText
        /// </summary>
        /// <value>A kind of hair of a person. NIEM reference is biom:PersonHairCategoryText</value>

        [DataMember(Name="personHairCategory")]
        public List<NcTextType> PersonHairCategory { get; set; }

        /// <summary>
        /// A set of colors of a physical feature NIEM reference is biom:PhysicalFeatureColorDetail
        /// </summary>
        /// <value>A set of colors of a physical feature NIEM reference is biom:PhysicalFeatureColorDetail</value>

        [DataMember(Name="physicalFeatureColorDetail")]
        public List<BiomPhysicalFeatureColorDetailType> PhysicalFeatureColorDetail { get; set; }

        /// <summary>
        /// A specific kind of physical feature NIEM reference is biom:PhysicalFeatureCategoryCode
        /// </summary>
        /// <value>A specific kind of physical feature NIEM reference is biom:PhysicalFeatureCategoryCode</value>

        [DataMember(Name="physicalFeatureCategoryCode")]
        public List<BiomPhysicalFeatureCategoryCodeType> PhysicalFeatureCategoryCode { get; set; }

        /// <summary>
        /// A specific kind of physical feature. NIEM reference is biom:PhysicalFeatureCategoryText
        /// </summary>
        /// <value>A specific kind of physical feature. NIEM reference is biom:PhysicalFeatureCategoryText</value>

        [DataMember(Name="physicalFeatureCategory")]
        public List<NcTextType> PhysicalFeatureCategory { get; set; }

        /// <summary>
        /// A human tattoo class of an SMT, OTHER if not tattoo NIEM reference is biom:PhysicalFeatureClassCode
        /// </summary>
        /// <value>A human tattoo class of an SMT, OTHER if not tattoo NIEM reference is biom:PhysicalFeatureClassCode</value>

        [DataMember(Name="physicalFeatureClassCode")]
        public List<BiomPhysicalFeatureClassCodeType> PhysicalFeatureClassCode { get; set; }

        /// <summary>
        /// A human tattoo subclass of an SMT, MISC if not tattoo NIEM reference is biom:PhysicalFeatureSubClassCode
        /// </summary>
        /// <value>A human tattoo subclass of an SMT, MISC if not tattoo NIEM reference is biom:PhysicalFeatureSubClassCode</value>

        [DataMember(Name="physicalFeatureSubClassCode")]
        public List<BiomPhysicalFeatureSubClassCodeType> PhysicalFeatureSubClassCode { get; set; }

        /// <summary>
        /// A location of a physical feature. NIEM reference is biom:PhysicalFeatureLocationText
        /// </summary>
        /// <value>A location of a physical feature. NIEM reference is biom:PhysicalFeatureLocationText</value>

        [DataMember(Name="physicalFeatureLocation")]
        public List<NcTextType> PhysicalFeatureLocation { get; set; }

        /// <summary>
        /// A general kind of physical feature. NIEM reference is biom:PhysicalFeatureGeneralCategoryText
        /// </summary>
        /// <value>A general kind of physical feature. NIEM reference is biom:PhysicalFeatureGeneralCategoryText</value>

        [DataMember(Name="physicalFeatureGeneralCategory")]
        public List<NcTextType> PhysicalFeatureGeneralCategory { get; set; }

        /// <summary>
        /// A description of a physical feature NIEM reference is biom:PhysicalFeatureDescriptionText
        /// </summary>
        /// <value>A description of a physical feature NIEM reference is biom:PhysicalFeatureDescriptionText</value>

        [DataMember(Name="text")]
        public List<NcTextType> Text { get; set; }

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
        /// biomPhysicalFeatureDescriptionType JSON-LD context
        /// </summary>
        /// <value>biomPhysicalFeatureDescriptionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomPhysicalFeatureDescriptionTypeContextJsonldEnum for ../JSON-LD_Contexts/biomPhysicalFeatureDescriptionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomPhysicalFeatureDescriptionTypeContext.jsonld")]
            JSONLDContextsbiomPhysicalFeatureDescriptionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomPhysicalFeatureDescriptionType JSON-LD context
        /// </summary>
        /// <value>biomPhysicalFeatureDescriptionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomPhysicalFeatureDescriptionType {\n");
            sb.Append("  PersonEyeColorCode: ").Append(PersonEyeColorCode).Append("\n");
            sb.Append("  PersonEyeColorRapSheetCode: ").Append(PersonEyeColorRapSheetCode).Append("\n");
            sb.Append("  PersonEyeColor: ").Append(PersonEyeColor).Append("\n");
            sb.Append("  PersonHairAppearance: ").Append(PersonHairAppearance).Append("\n");
            sb.Append("  PersonHairCategory: ").Append(PersonHairCategory).Append("\n");
            sb.Append("  PhysicalFeatureColorDetail: ").Append(PhysicalFeatureColorDetail).Append("\n");
            sb.Append("  PhysicalFeatureCategoryCode: ").Append(PhysicalFeatureCategoryCode).Append("\n");
            sb.Append("  PhysicalFeatureCategory: ").Append(PhysicalFeatureCategory).Append("\n");
            sb.Append("  PhysicalFeatureClassCode: ").Append(PhysicalFeatureClassCode).Append("\n");
            sb.Append("  PhysicalFeatureSubClassCode: ").Append(PhysicalFeatureSubClassCode).Append("\n");
            sb.Append("  PhysicalFeatureLocation: ").Append(PhysicalFeatureLocation).Append("\n");
            sb.Append("  PhysicalFeatureGeneralCategory: ").Append(PhysicalFeatureGeneralCategory).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  MedicalImageryDataBlockBinaryObject: ").Append(MedicalImageryDataBlockBinaryObject).Append("\n");
            sb.Append("  SourceExternalAnalogFileReference: ").Append(SourceExternalAnalogFileReference).Append("\n");
            sb.Append("  SourceExternalDigitalAudioReference: ").Append(SourceExternalDigitalAudioReference).Append("\n");
            sb.Append("  SourceExternalDigitalImageReference: ").Append(SourceExternalDigitalImageReference).Append("\n");
            sb.Append("  SourceExternalDigitalVideoReference: ").Append(SourceExternalDigitalVideoReference).Append("\n");
            sb.Append("  SourceExternalFileReference: ").Append(SourceExternalFileReference).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomPhysicalFeatureDescriptionType)obj);
        }

        /// <summary>
        /// Returns true if BiomPhysicalFeatureDescriptionType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomPhysicalFeatureDescriptionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomPhysicalFeatureDescriptionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PersonEyeColorCode == other.PersonEyeColorCode ||
                    PersonEyeColorCode != null &&
                    PersonEyeColorCode.SequenceEqual(other.PersonEyeColorCode)
                ) && 
                (
                    PersonEyeColorRapSheetCode == other.PersonEyeColorRapSheetCode ||
                    PersonEyeColorRapSheetCode != null &&
                    PersonEyeColorRapSheetCode.SequenceEqual(other.PersonEyeColorRapSheetCode)
                ) && 
                (
                    PersonEyeColor == other.PersonEyeColor ||
                    PersonEyeColor != null &&
                    PersonEyeColor.SequenceEqual(other.PersonEyeColor)
                ) && 
                (
                    PersonHairAppearance == other.PersonHairAppearance ||
                    PersonHairAppearance != null &&
                    PersonHairAppearance.SequenceEqual(other.PersonHairAppearance)
                ) && 
                (
                    PersonHairCategory == other.PersonHairCategory ||
                    PersonHairCategory != null &&
                    PersonHairCategory.SequenceEqual(other.PersonHairCategory)
                ) && 
                (
                    PhysicalFeatureColorDetail == other.PhysicalFeatureColorDetail ||
                    PhysicalFeatureColorDetail != null &&
                    PhysicalFeatureColorDetail.SequenceEqual(other.PhysicalFeatureColorDetail)
                ) && 
                (
                    PhysicalFeatureCategoryCode == other.PhysicalFeatureCategoryCode ||
                    PhysicalFeatureCategoryCode != null &&
                    PhysicalFeatureCategoryCode.SequenceEqual(other.PhysicalFeatureCategoryCode)
                ) && 
                (
                    PhysicalFeatureCategory == other.PhysicalFeatureCategory ||
                    PhysicalFeatureCategory != null &&
                    PhysicalFeatureCategory.SequenceEqual(other.PhysicalFeatureCategory)
                ) && 
                (
                    PhysicalFeatureClassCode == other.PhysicalFeatureClassCode ||
                    PhysicalFeatureClassCode != null &&
                    PhysicalFeatureClassCode.SequenceEqual(other.PhysicalFeatureClassCode)
                ) && 
                (
                    PhysicalFeatureSubClassCode == other.PhysicalFeatureSubClassCode ||
                    PhysicalFeatureSubClassCode != null &&
                    PhysicalFeatureSubClassCode.SequenceEqual(other.PhysicalFeatureSubClassCode)
                ) && 
                (
                    PhysicalFeatureLocation == other.PhysicalFeatureLocation ||
                    PhysicalFeatureLocation != null &&
                    PhysicalFeatureLocation.SequenceEqual(other.PhysicalFeatureLocation)
                ) && 
                (
                    PhysicalFeatureGeneralCategory == other.PhysicalFeatureGeneralCategory ||
                    PhysicalFeatureGeneralCategory != null &&
                    PhysicalFeatureGeneralCategory.SequenceEqual(other.PhysicalFeatureGeneralCategory)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.SequenceEqual(other.Text)
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
                    if (PersonEyeColorCode != null)
                    hashCode = hashCode * 59 + PersonEyeColorCode.GetHashCode();
                    if (PersonEyeColorRapSheetCode != null)
                    hashCode = hashCode * 59 + PersonEyeColorRapSheetCode.GetHashCode();
                    if (PersonEyeColor != null)
                    hashCode = hashCode * 59 + PersonEyeColor.GetHashCode();
                    if (PersonHairAppearance != null)
                    hashCode = hashCode * 59 + PersonHairAppearance.GetHashCode();
                    if (PersonHairCategory != null)
                    hashCode = hashCode * 59 + PersonHairCategory.GetHashCode();
                    if (PhysicalFeatureColorDetail != null)
                    hashCode = hashCode * 59 + PhysicalFeatureColorDetail.GetHashCode();
                    if (PhysicalFeatureCategoryCode != null)
                    hashCode = hashCode * 59 + PhysicalFeatureCategoryCode.GetHashCode();
                    if (PhysicalFeatureCategory != null)
                    hashCode = hashCode * 59 + PhysicalFeatureCategory.GetHashCode();
                    if (PhysicalFeatureClassCode != null)
                    hashCode = hashCode * 59 + PhysicalFeatureClassCode.GetHashCode();
                    if (PhysicalFeatureSubClassCode != null)
                    hashCode = hashCode * 59 + PhysicalFeatureSubClassCode.GetHashCode();
                    if (PhysicalFeatureLocation != null)
                    hashCode = hashCode * 59 + PhysicalFeatureLocation.GetHashCode();
                    if (PhysicalFeatureGeneralCategory != null)
                    hashCode = hashCode * 59 + PhysicalFeatureGeneralCategory.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
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
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomPhysicalFeatureDescriptionType left, BiomPhysicalFeatureDescriptionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomPhysicalFeatureDescriptionType left, BiomPhysicalFeatureDescriptionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
