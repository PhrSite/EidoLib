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
    /// A data type for a DNA sample
    /// </summary>
    [DataContract]
    public partial class BiomDNASampleType : IEquatable<BiomDNASampleType>
    { 
        /// <summary>
        /// A collection of a biometric sample. NIEM reference is biom:BiometricCapture
        /// </summary>
        /// <value>A collection of a biometric sample. NIEM reference is biom:BiometricCapture</value>

        [DataMember(Name="biometricCapture")]
        public List<BiomBiometricCaptureType> BiometricCapture { get; set; }

        /// <summary>
        /// An organization responsible for processing DNA samples NIEM reference is biom:DNALaboratory
        /// </summary>
        /// <value>An organization responsible for processing DNA samples NIEM reference is biom:DNALaboratory</value>

        [DataMember(Name="dnaLaboratory")]
        public List<BiomDNALaboratoryType> DnaLaboratory { get; set; }

        /// <summary>
        /// A number of analyses in this record NIEM reference is biom:DNAAnalysisQuantityCode
        /// </summary>
        /// <value>A number of analyses in this record NIEM reference is biom:DNAAnalysisQuantityCode</value>

        [DataMember(Name="dnaAnalysisQuantityCode")]
        public List<BiomDNAAnalysisQuantityCodeType> DnaAnalysisQuantityCode { get; set; }

        /// <summary>
        /// A description of the subject of a DNA sample NIEM reference is biom:DNADonor
        /// </summary>
        /// <value>A description of the subject of a DNA sample NIEM reference is biom:DNADonor</value>

        [DataMember(Name="dnaDonor")]
        public List<BiomDNADonorType> DnaDonor { get; set; }

        /// <summary>
        /// A claimed or purported relationship to be tested by DNA NIEM reference is biom:DNAClaimedRelationshipCode
        /// </summary>
        /// <value>A claimed or purported relationship to be tested by DNA NIEM reference is biom:DNAClaimedRelationshipCode</value>

        [DataMember(Name="dnaClaimedRelationshipCode")]
        public List<BiomDNARelationshipCodeType> DnaClaimedRelationshipCode { get; set; }

        /// <summary>
        /// A validated relationship established by DNA NIEM reference is biom:DNAValidatedRelationshipCode
        /// </summary>
        /// <value>A validated relationship established by DNA NIEM reference is biom:DNAValidatedRelationshipCode</value>

        [DataMember(Name="dnaValidatedRelationshipCode")]
        public List<BiomDNARelationshipCodeType> DnaValidatedRelationshipCode { get; set; }

        /// <summary>
        /// A description of a pedigree originating and held at a DNA laboratory NIEM reference is biom:DNAPedigree
        /// </summary>
        /// <value>A description of a pedigree originating and held at a DNA laboratory NIEM reference is biom:DNAPedigree</value>

        [DataMember(Name="dnaPedigree")]
        public List<BiomDNAPedigreeType> DnaPedigree { get; set; }

        /// <summary>
        /// A description of the cellular type and origin of a DNA sample NIEM reference is biom:DNASampleOrigin
        /// </summary>
        /// <value>A description of the cellular type and origin of a DNA sample NIEM reference is biom:DNASampleOrigin</value>

        [DataMember(Name="origin")]
        public List<BiomDNASampleOriginType> Origin { get; set; }

        /// <summary>
        /// A kind of typing technology used on a DNA sample NIEM reference is biom:DNATypingTechnologyCategoryCode
        /// </summary>
        /// <value>A kind of typing technology used on a DNA sample NIEM reference is biom:DNATypingTechnologyCategoryCode</value>

        [DataMember(Name="dnaTypingTechnologyCategoryCode")]
        public List<BiomDNATypingTechnologyCategoryCodeType> DnaTypingTechnologyCategoryCode { get; set; }

        /// <summary>
        /// A description of the method used to collect a DNA sample NIEM reference is biom:DNASampleCollectionMethodText
        /// </summary>
        /// <value>A description of the method used to collect a DNA sample NIEM reference is biom:DNASampleCollectionMethodText</value>

        [DataMember(Name="collectionMethod")]
        public List<NcTextType> CollectionMethod { get; set; }

        /// <summary>
        /// A date of the storage of a DNA profile NIEM reference is biom:DNAProfileStorageDate
        /// </summary>
        /// <value>A date of the storage of a DNA profile NIEM reference is biom:DNAProfileStorageDate</value>

        [DataMember(Name="dnaProfileStorageDate")]
        public List<NcDateType> DnaProfileStorageDate { get; set; }

        /// <summary>
        /// A description of a DNA profile NIEM reference is biom:DNAProfile
        /// </summary>
        /// <value>A description of a DNA profile NIEM reference is biom:DNAProfile</value>

        [DataMember(Name="dnaProfile")]
        public List<BiomDNAProfileType> DnaProfile { get; set; }

        /// <summary>
        /// An autosomal STR, X-STR, and Y-STR DNA profile NIEM reference is biom:DNASTRProfile
        /// </summary>
        /// <value>An autosomal STR, X-STR, and Y-STR DNA profile NIEM reference is biom:DNASTRProfile</value>

        [DataMember(Name="dnastrProfile")]
        public List<BiomDNASTRProfileType> DnastrProfile { get; set; }

        /// <summary>
        /// A description of DNA mitochondrial data NIEM reference is biom:DNAMitochondrialData
        /// </summary>
        /// <value>A description of DNA mitochondrial data NIEM reference is biom:DNAMitochondrialData</value>

        [DataMember(Name="dnaMitochondrialData")]
        public List<BiomDNAMitochondrialDataType> DnaMitochondrialData { get; set; }

        /// <summary>
        /// A DNA electropherogram NIEM reference is biom:DNAElectropherogram
        /// </summary>
        /// <value>A DNA electropherogram NIEM reference is biom:DNAElectropherogram</value>

        [DataMember(Name="dnaElectropherogram")]
        public List<BiomDNAElectropherogramType> DnaElectropherogram { get; set; }

        /// <summary>
        /// A ladder/control sample DNA electropherogram NIEM reference is biom:DNAElectropherogramLadder
        /// </summary>
        /// <value>A ladder/control sample DNA electropherogram NIEM reference is biom:DNAElectropherogramLadder</value>

        [DataMember(Name="dnaElectropherogramLadder")]
        public List<BiomDNAElectropherogramType> DnaElectropherogramLadder { get; set; }

        /// <summary>
        /// A kind of DNA genotype distribution NIEM reference is biom:DNAGenotypeDistributionCode
        /// </summary>
        /// <value>A kind of DNA genotype distribution NIEM reference is biom:DNAGenotypeDistributionCode</value>

        [DataMember(Name="dnaGenotypeDistributionCode")]
        public List<BiomDNAGenotypeDistributionCodeType> DnaGenotypeDistributionCode { get; set; }

        /// <summary>
        /// A DNA genotype allele pair NIEM reference is biom:DNAGenotypeAllelePair
        /// </summary>
        /// <value>A DNA genotype allele pair NIEM reference is biom:DNAGenotypeAllelePair</value>

        [DataMember(Name="dnaGenotypeAllelePair")]
        public List<BiomDNAGenotypeAllelePairType> DnaGenotypeAllelePair { get; set; }

        /// <summary>
        /// A kind of comment regarding a DNA sample NIEM reference is biom:DNACommentText
        /// </summary>
        /// <value>A kind of comment regarding a DNA sample NIEM reference is biom:DNACommentText</value>

        [DataMember(Name="dnaComment")]
        public List<NcTextType> DnaComment { get; set; }

        /// <summary>
        /// biomDNASampleType JSON-LD context
        /// </summary>
        /// <value>biomDNASampleType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomDNASampleTypeContextJsonldEnum for ../JSON-LD_Contexts/biomDNASampleTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomDNASampleTypeContext.jsonld")]
            JSONLDContextsbiomDNASampleTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomDNASampleType JSON-LD context
        /// </summary>
        /// <value>biomDNASampleType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomDNASampleType {\n");
            sb.Append("  BiometricCapture: ").Append(BiometricCapture).Append("\n");
            sb.Append("  DnaLaboratory: ").Append(DnaLaboratory).Append("\n");
            sb.Append("  DnaAnalysisQuantityCode: ").Append(DnaAnalysisQuantityCode).Append("\n");
            sb.Append("  DnaDonor: ").Append(DnaDonor).Append("\n");
            sb.Append("  DnaClaimedRelationshipCode: ").Append(DnaClaimedRelationshipCode).Append("\n");
            sb.Append("  DnaValidatedRelationshipCode: ").Append(DnaValidatedRelationshipCode).Append("\n");
            sb.Append("  DnaPedigree: ").Append(DnaPedigree).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  DnaTypingTechnologyCategoryCode: ").Append(DnaTypingTechnologyCategoryCode).Append("\n");
            sb.Append("  CollectionMethod: ").Append(CollectionMethod).Append("\n");
            sb.Append("  DnaProfileStorageDate: ").Append(DnaProfileStorageDate).Append("\n");
            sb.Append("  DnaProfile: ").Append(DnaProfile).Append("\n");
            sb.Append("  DnastrProfile: ").Append(DnastrProfile).Append("\n");
            sb.Append("  DnaMitochondrialData: ").Append(DnaMitochondrialData).Append("\n");
            sb.Append("  DnaElectropherogram: ").Append(DnaElectropherogram).Append("\n");
            sb.Append("  DnaElectropherogramLadder: ").Append(DnaElectropherogramLadder).Append("\n");
            sb.Append("  DnaGenotypeDistributionCode: ").Append(DnaGenotypeDistributionCode).Append("\n");
            sb.Append("  DnaGenotypeAllelePair: ").Append(DnaGenotypeAllelePair).Append("\n");
            sb.Append("  DnaComment: ").Append(DnaComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomDNASampleType)obj);
        }

        /// <summary>
        /// Returns true if BiomDNASampleType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomDNASampleType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomDNASampleType other)
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
                    DnaLaboratory == other.DnaLaboratory ||
                    DnaLaboratory != null &&
                    DnaLaboratory.SequenceEqual(other.DnaLaboratory)
                ) && 
                (
                    DnaAnalysisQuantityCode == other.DnaAnalysisQuantityCode ||
                    DnaAnalysisQuantityCode != null &&
                    DnaAnalysisQuantityCode.SequenceEqual(other.DnaAnalysisQuantityCode)
                ) && 
                (
                    DnaDonor == other.DnaDonor ||
                    DnaDonor != null &&
                    DnaDonor.SequenceEqual(other.DnaDonor)
                ) && 
                (
                    DnaClaimedRelationshipCode == other.DnaClaimedRelationshipCode ||
                    DnaClaimedRelationshipCode != null &&
                    DnaClaimedRelationshipCode.SequenceEqual(other.DnaClaimedRelationshipCode)
                ) && 
                (
                    DnaValidatedRelationshipCode == other.DnaValidatedRelationshipCode ||
                    DnaValidatedRelationshipCode != null &&
                    DnaValidatedRelationshipCode.SequenceEqual(other.DnaValidatedRelationshipCode)
                ) && 
                (
                    DnaPedigree == other.DnaPedigree ||
                    DnaPedigree != null &&
                    DnaPedigree.SequenceEqual(other.DnaPedigree)
                ) && 
                (
                    Origin == other.Origin ||
                    Origin != null &&
                    Origin.SequenceEqual(other.Origin)
                ) && 
                (
                    DnaTypingTechnologyCategoryCode == other.DnaTypingTechnologyCategoryCode ||
                    DnaTypingTechnologyCategoryCode != null &&
                    DnaTypingTechnologyCategoryCode.SequenceEqual(other.DnaTypingTechnologyCategoryCode)
                ) && 
                (
                    CollectionMethod == other.CollectionMethod ||
                    CollectionMethod != null &&
                    CollectionMethod.SequenceEqual(other.CollectionMethod)
                ) && 
                (
                    DnaProfileStorageDate == other.DnaProfileStorageDate ||
                    DnaProfileStorageDate != null &&
                    DnaProfileStorageDate.SequenceEqual(other.DnaProfileStorageDate)
                ) && 
                (
                    DnaProfile == other.DnaProfile ||
                    DnaProfile != null &&
                    DnaProfile.SequenceEqual(other.DnaProfile)
                ) && 
                (
                    DnastrProfile == other.DnastrProfile ||
                    DnastrProfile != null &&
                    DnastrProfile.SequenceEqual(other.DnastrProfile)
                ) && 
                (
                    DnaMitochondrialData == other.DnaMitochondrialData ||
                    DnaMitochondrialData != null &&
                    DnaMitochondrialData.SequenceEqual(other.DnaMitochondrialData)
                ) && 
                (
                    DnaElectropherogram == other.DnaElectropherogram ||
                    DnaElectropherogram != null &&
                    DnaElectropherogram.SequenceEqual(other.DnaElectropherogram)
                ) && 
                (
                    DnaElectropherogramLadder == other.DnaElectropherogramLadder ||
                    DnaElectropherogramLadder != null &&
                    DnaElectropherogramLadder.SequenceEqual(other.DnaElectropherogramLadder)
                ) && 
                (
                    DnaGenotypeDistributionCode == other.DnaGenotypeDistributionCode ||
                    DnaGenotypeDistributionCode != null &&
                    DnaGenotypeDistributionCode.SequenceEqual(other.DnaGenotypeDistributionCode)
                ) && 
                (
                    DnaGenotypeAllelePair == other.DnaGenotypeAllelePair ||
                    DnaGenotypeAllelePair != null &&
                    DnaGenotypeAllelePair.SequenceEqual(other.DnaGenotypeAllelePair)
                ) && 
                (
                    DnaComment == other.DnaComment ||
                    DnaComment != null &&
                    DnaComment.SequenceEqual(other.DnaComment)
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
                    if (DnaLaboratory != null)
                    hashCode = hashCode * 59 + DnaLaboratory.GetHashCode();
                    if (DnaAnalysisQuantityCode != null)
                    hashCode = hashCode * 59 + DnaAnalysisQuantityCode.GetHashCode();
                    if (DnaDonor != null)
                    hashCode = hashCode * 59 + DnaDonor.GetHashCode();
                    if (DnaClaimedRelationshipCode != null)
                    hashCode = hashCode * 59 + DnaClaimedRelationshipCode.GetHashCode();
                    if (DnaValidatedRelationshipCode != null)
                    hashCode = hashCode * 59 + DnaValidatedRelationshipCode.GetHashCode();
                    if (DnaPedigree != null)
                    hashCode = hashCode * 59 + DnaPedigree.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (DnaTypingTechnologyCategoryCode != null)
                    hashCode = hashCode * 59 + DnaTypingTechnologyCategoryCode.GetHashCode();
                    if (CollectionMethod != null)
                    hashCode = hashCode * 59 + CollectionMethod.GetHashCode();
                    if (DnaProfileStorageDate != null)
                    hashCode = hashCode * 59 + DnaProfileStorageDate.GetHashCode();
                    if (DnaProfile != null)
                    hashCode = hashCode * 59 + DnaProfile.GetHashCode();
                    if (DnastrProfile != null)
                    hashCode = hashCode * 59 + DnastrProfile.GetHashCode();
                    if (DnaMitochondrialData != null)
                    hashCode = hashCode * 59 + DnaMitochondrialData.GetHashCode();
                    if (DnaElectropherogram != null)
                    hashCode = hashCode * 59 + DnaElectropherogram.GetHashCode();
                    if (DnaElectropherogramLadder != null)
                    hashCode = hashCode * 59 + DnaElectropherogramLadder.GetHashCode();
                    if (DnaGenotypeDistributionCode != null)
                    hashCode = hashCode * 59 + DnaGenotypeDistributionCode.GetHashCode();
                    if (DnaGenotypeAllelePair != null)
                    hashCode = hashCode * 59 + DnaGenotypeAllelePair.GetHashCode();
                    if (DnaComment != null)
                    hashCode = hashCode * 59 + DnaComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomDNASampleType left, BiomDNASampleType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomDNASampleType left, BiomDNASampleType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
