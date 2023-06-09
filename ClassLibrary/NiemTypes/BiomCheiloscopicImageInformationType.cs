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
    /// A data type that is particularly useful if the image contained in this record is of an injury or latent image on a person. However, its use is not limited to such circumstances.
    /// </summary>
    [DataContract]
    public partial class BiomCheiloscopicImageInformationType : IEquatable<BiomCheiloscopicImageInformationType>
    { 
        /// <summary>
        /// A lip print width. NIEM reference is biom:LipPrintWidthValue
        /// </summary>
        /// <value>A lip print width. NIEM reference is biom:LipPrintWidthValue</value>

        [DataMember(Name="lipPrintWidthValue")]
        public List<NiemXspositiveInteger> LipPrintWidthValue { get; set; }

        /// <summary>
        /// A lip print height NIEM reference is biom:LipPrintHeightValue
        /// </summary>
        /// <value>A lip print height NIEM reference is biom:LipPrintHeightValue</value>

        [DataMember(Name="lipPrintHeightValue")]
        public List<NiemXspositiveInteger> LipPrintHeightValue { get; set; }

        /// <summary>
        /// A philtrum width. NIEM reference is biom:PhiltrumWidthValue
        /// </summary>
        /// <value>A philtrum width. NIEM reference is biom:PhiltrumWidthValue</value>

        [DataMember(Name="philtrumWidthValue")]
        public List<NiemXspositiveInteger> PhiltrumWidthValue { get; set; }

        /// <summary>
        /// A philtrum height NIEM reference is biom:PhiltrumHeightValue
        /// </summary>
        /// <value>A philtrum height NIEM reference is biom:PhiltrumHeightValue</value>

        [DataMember(Name="philtrumHeightValue")]
        public List<NiemXspositiveInteger> PhiltrumHeightValue { get; set; }

        /// <summary>
        /// An upper lip print characterization code list NIEM reference is biom:UpperLipCharacterizationCodeList
        /// </summary>
        /// <value>An upper lip print characterization code list NIEM reference is biom:UpperLipCharacterizationCodeList</value>

        [DataMember(Name="upperLipCharacterizationCodeList")]
        public List<BiomLipCharacterizationCodeListType> UpperLipCharacterizationCodeList { get; set; }

        /// <summary>
        /// A lower lip print characterization code list NIEM reference is biom:LowerLipCharacterizationCodeList
        /// </summary>
        /// <value>A lower lip print characterization code list NIEM reference is biom:LowerLipCharacterizationCodeList</value>

        [DataMember(Name="lowerLipCharacterizationCodeList")]
        public List<BiomLipCharacterizationCodeListType> LowerLipCharacterizationCodeList { get; set; }

        /// <summary>
        /// A lip contact line descriptor NIEM reference is biom:LipContactLineDescriptorCode
        /// </summary>
        /// <value>A lip contact line descriptor NIEM reference is biom:LipContactLineDescriptorCode</value>

        [DataMember(Name="lipContactLineDescriptorCode")]
        public List<BiomLipContactLineDescriptorCodeType> LipContactLineDescriptorCode { get; set; }

        /// <summary>
        /// A kind of lip print characterization descriptive text NIEM reference is biom:LipPrintCharacterizationText
        /// </summary>
        /// <value>A kind of lip print characterization descriptive text NIEM reference is biom:LipPrintCharacterizationText</value>

        [DataMember(Name="lipPrintCharacterization")]
        public List<NcTextType> LipPrintCharacterization { get; set; }

        /// <summary>
        /// A lip pathologies and peculiarities code list NIEM reference is biom:LipPrintPathologiesPeculiaritiesCodeList
        /// </summary>
        /// <value>A lip pathologies and peculiarities code list NIEM reference is biom:LipPrintPathologiesPeculiaritiesCodeList</value>

        [DataMember(Name="lipPrintPathologiesPeculiaritiesCodeList")]
        public List<BiomLipPrintPathologiesPeculiaritiesCodeListType> LipPrintPathologiesPeculiaritiesCodeList { get; set; }

        /// <summary>
        /// A kind of lip print pathologies peculiarities descriptive text NIEM reference is biom:LipPrintPathologiesPeculiaritiesText
        /// </summary>
        /// <value>A kind of lip print pathologies peculiarities descriptive text NIEM reference is biom:LipPrintPathologiesPeculiaritiesText</value>

        [DataMember(Name="lipPrintPathologiesPeculiarities")]
        public List<NcTextType> LipPrintPathologiesPeculiarities { get; set; }

        /// <summary>
        /// A lip print surface code list NIEM reference is biom:LipPrintSurfaceCodeList
        /// </summary>
        /// <value>A lip print surface code list NIEM reference is biom:LipPrintSurfaceCodeList</value>

        [DataMember(Name="lipPrintSurfaceCodeList")]
        public List<BiomLipPrintSurfaceCodeListType> LipPrintSurfaceCodeList { get; set; }

        /// <summary>
        /// A kind of lip print surface descriptive text NIEM reference is biom:LipPrintSurfaceText
        /// </summary>
        /// <value>A kind of lip print surface descriptive text NIEM reference is biom:LipPrintSurfaceText</value>

        [DataMember(Name="lipPrintSurface")]
        public List<NcTextType> LipPrintSurface { get; set; }

        /// <summary>
        /// A lip print medium code list NIEM reference is biom:LipPrintMediumCode
        /// </summary>
        /// <value>A lip print medium code list NIEM reference is biom:LipPrintMediumCode</value>

        [DataMember(Name="lipPrintMediumCode")]
        public List<BiomLipPrintMediumCodeType> LipPrintMediumCode { get; set; }

        /// <summary>
        /// A kind of lip print medium descriptive text NIEM reference is biom:LipPrintMediumText
        /// </summary>
        /// <value>A kind of lip print medium descriptive text NIEM reference is biom:LipPrintMediumText</value>

        [DataMember(Name="lipPrintMedium")]
        public List<NcTextType> LipPrintMedium { get; set; }

        /// <summary>
        /// A kind of facial hair of a person. NIEM reference is nc:PersonFacialHairText
        /// </summary>
        /// <value>A kind of facial hair of a person. NIEM reference is nc:PersonFacialHairText</value>

        [DataMember(Name="personFacialHair")]
        public List<NcTextType> PersonFacialHair { get; set; }

        /// <summary>
        /// A kind of lip position tension descriptive text NIEM reference is biom:LipPositionTensionDescriptiveText
        /// </summary>
        /// <value>A kind of lip position tension descriptive text NIEM reference is biom:LipPositionTensionDescriptiveText</value>

        [DataMember(Name="lipPositionTensionDescriptive")]
        public List<NcTextType> LipPositionTensionDescriptive { get; set; }

        /// <summary>
        /// A kind of lip print additional descriptive text NIEM reference is biom:LipPrintDescriptiveText
        /// </summary>
        /// <value>A kind of lip print additional descriptive text NIEM reference is biom:LipPrintDescriptiveText</value>

        [DataMember(Name="lipPrintDescriptive")]
        public List<NcTextType> LipPrintDescriptive { get; set; }

        /// <summary>
        /// A kind of lip print comparison descriptive text NIEM reference is biom:LipPrintComparisonDescriptiveText
        /// </summary>
        /// <value>A kind of lip print comparison descriptive text NIEM reference is biom:LipPrintComparisonDescriptiveText</value>

        [DataMember(Name="lipPrintComparisonDescriptive")]
        public List<NcTextType> LipPrintComparisonDescriptive { get; set; }

        /// <summary>
        /// biomCheiloscopicImageInformationType JSON-LD context
        /// </summary>
        /// <value>biomCheiloscopicImageInformationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomCheiloscopicImageInformationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomCheiloscopicImageInformationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomCheiloscopicImageInformationTypeContext.jsonld")]
            JSONLDContextsbiomCheiloscopicImageInformationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomCheiloscopicImageInformationType JSON-LD context
        /// </summary>
        /// <value>biomCheiloscopicImageInformationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomCheiloscopicImageInformationType {\n");
            sb.Append("  LipPrintWidthValue: ").Append(LipPrintWidthValue).Append("\n");
            sb.Append("  LipPrintHeightValue: ").Append(LipPrintHeightValue).Append("\n");
            sb.Append("  PhiltrumWidthValue: ").Append(PhiltrumWidthValue).Append("\n");
            sb.Append("  PhiltrumHeightValue: ").Append(PhiltrumHeightValue).Append("\n");
            sb.Append("  UpperLipCharacterizationCodeList: ").Append(UpperLipCharacterizationCodeList).Append("\n");
            sb.Append("  LowerLipCharacterizationCodeList: ").Append(LowerLipCharacterizationCodeList).Append("\n");
            sb.Append("  LipContactLineDescriptorCode: ").Append(LipContactLineDescriptorCode).Append("\n");
            sb.Append("  LipPrintCharacterization: ").Append(LipPrintCharacterization).Append("\n");
            sb.Append("  LipPrintPathologiesPeculiaritiesCodeList: ").Append(LipPrintPathologiesPeculiaritiesCodeList).Append("\n");
            sb.Append("  LipPrintPathologiesPeculiarities: ").Append(LipPrintPathologiesPeculiarities).Append("\n");
            sb.Append("  LipPrintSurfaceCodeList: ").Append(LipPrintSurfaceCodeList).Append("\n");
            sb.Append("  LipPrintSurface: ").Append(LipPrintSurface).Append("\n");
            sb.Append("  LipPrintMediumCode: ").Append(LipPrintMediumCode).Append("\n");
            sb.Append("  LipPrintMedium: ").Append(LipPrintMedium).Append("\n");
            sb.Append("  PersonFacialHair: ").Append(PersonFacialHair).Append("\n");
            sb.Append("  LipPositionTensionDescriptive: ").Append(LipPositionTensionDescriptive).Append("\n");
            sb.Append("  LipPrintDescriptive: ").Append(LipPrintDescriptive).Append("\n");
            sb.Append("  LipPrintComparisonDescriptive: ").Append(LipPrintComparisonDescriptive).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomCheiloscopicImageInformationType)obj);
        }

        /// <summary>
        /// Returns true if BiomCheiloscopicImageInformationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomCheiloscopicImageInformationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomCheiloscopicImageInformationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LipPrintWidthValue == other.LipPrintWidthValue ||
                    LipPrintWidthValue != null &&
                    LipPrintWidthValue.SequenceEqual(other.LipPrintWidthValue)
                ) && 
                (
                    LipPrintHeightValue == other.LipPrintHeightValue ||
                    LipPrintHeightValue != null &&
                    LipPrintHeightValue.SequenceEqual(other.LipPrintHeightValue)
                ) && 
                (
                    PhiltrumWidthValue == other.PhiltrumWidthValue ||
                    PhiltrumWidthValue != null &&
                    PhiltrumWidthValue.SequenceEqual(other.PhiltrumWidthValue)
                ) && 
                (
                    PhiltrumHeightValue == other.PhiltrumHeightValue ||
                    PhiltrumHeightValue != null &&
                    PhiltrumHeightValue.SequenceEqual(other.PhiltrumHeightValue)
                ) && 
                (
                    UpperLipCharacterizationCodeList == other.UpperLipCharacterizationCodeList ||
                    UpperLipCharacterizationCodeList != null &&
                    UpperLipCharacterizationCodeList.SequenceEqual(other.UpperLipCharacterizationCodeList)
                ) && 
                (
                    LowerLipCharacterizationCodeList == other.LowerLipCharacterizationCodeList ||
                    LowerLipCharacterizationCodeList != null &&
                    LowerLipCharacterizationCodeList.SequenceEqual(other.LowerLipCharacterizationCodeList)
                ) && 
                (
                    LipContactLineDescriptorCode == other.LipContactLineDescriptorCode ||
                    LipContactLineDescriptorCode != null &&
                    LipContactLineDescriptorCode.SequenceEqual(other.LipContactLineDescriptorCode)
                ) && 
                (
                    LipPrintCharacterization == other.LipPrintCharacterization ||
                    LipPrintCharacterization != null &&
                    LipPrintCharacterization.SequenceEqual(other.LipPrintCharacterization)
                ) && 
                (
                    LipPrintPathologiesPeculiaritiesCodeList == other.LipPrintPathologiesPeculiaritiesCodeList ||
                    LipPrintPathologiesPeculiaritiesCodeList != null &&
                    LipPrintPathologiesPeculiaritiesCodeList.SequenceEqual(other.LipPrintPathologiesPeculiaritiesCodeList)
                ) && 
                (
                    LipPrintPathologiesPeculiarities == other.LipPrintPathologiesPeculiarities ||
                    LipPrintPathologiesPeculiarities != null &&
                    LipPrintPathologiesPeculiarities.SequenceEqual(other.LipPrintPathologiesPeculiarities)
                ) && 
                (
                    LipPrintSurfaceCodeList == other.LipPrintSurfaceCodeList ||
                    LipPrintSurfaceCodeList != null &&
                    LipPrintSurfaceCodeList.SequenceEqual(other.LipPrintSurfaceCodeList)
                ) && 
                (
                    LipPrintSurface == other.LipPrintSurface ||
                    LipPrintSurface != null &&
                    LipPrintSurface.SequenceEqual(other.LipPrintSurface)
                ) && 
                (
                    LipPrintMediumCode == other.LipPrintMediumCode ||
                    LipPrintMediumCode != null &&
                    LipPrintMediumCode.SequenceEqual(other.LipPrintMediumCode)
                ) && 
                (
                    LipPrintMedium == other.LipPrintMedium ||
                    LipPrintMedium != null &&
                    LipPrintMedium.SequenceEqual(other.LipPrintMedium)
                ) && 
                (
                    PersonFacialHair == other.PersonFacialHair ||
                    PersonFacialHair != null &&
                    PersonFacialHair.SequenceEqual(other.PersonFacialHair)
                ) && 
                (
                    LipPositionTensionDescriptive == other.LipPositionTensionDescriptive ||
                    LipPositionTensionDescriptive != null &&
                    LipPositionTensionDescriptive.SequenceEqual(other.LipPositionTensionDescriptive)
                ) && 
                (
                    LipPrintDescriptive == other.LipPrintDescriptive ||
                    LipPrintDescriptive != null &&
                    LipPrintDescriptive.SequenceEqual(other.LipPrintDescriptive)
                ) && 
                (
                    LipPrintComparisonDescriptive == other.LipPrintComparisonDescriptive ||
                    LipPrintComparisonDescriptive != null &&
                    LipPrintComparisonDescriptive.SequenceEqual(other.LipPrintComparisonDescriptive)
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
                    if (LipPrintWidthValue != null)
                    hashCode = hashCode * 59 + LipPrintWidthValue.GetHashCode();
                    if (LipPrintHeightValue != null)
                    hashCode = hashCode * 59 + LipPrintHeightValue.GetHashCode();
                    if (PhiltrumWidthValue != null)
                    hashCode = hashCode * 59 + PhiltrumWidthValue.GetHashCode();
                    if (PhiltrumHeightValue != null)
                    hashCode = hashCode * 59 + PhiltrumHeightValue.GetHashCode();
                    if (UpperLipCharacterizationCodeList != null)
                    hashCode = hashCode * 59 + UpperLipCharacterizationCodeList.GetHashCode();
                    if (LowerLipCharacterizationCodeList != null)
                    hashCode = hashCode * 59 + LowerLipCharacterizationCodeList.GetHashCode();
                    if (LipContactLineDescriptorCode != null)
                    hashCode = hashCode * 59 + LipContactLineDescriptorCode.GetHashCode();
                    if (LipPrintCharacterization != null)
                    hashCode = hashCode * 59 + LipPrintCharacterization.GetHashCode();
                    if (LipPrintPathologiesPeculiaritiesCodeList != null)
                    hashCode = hashCode * 59 + LipPrintPathologiesPeculiaritiesCodeList.GetHashCode();
                    if (LipPrintPathologiesPeculiarities != null)
                    hashCode = hashCode * 59 + LipPrintPathologiesPeculiarities.GetHashCode();
                    if (LipPrintSurfaceCodeList != null)
                    hashCode = hashCode * 59 + LipPrintSurfaceCodeList.GetHashCode();
                    if (LipPrintSurface != null)
                    hashCode = hashCode * 59 + LipPrintSurface.GetHashCode();
                    if (LipPrintMediumCode != null)
                    hashCode = hashCode * 59 + LipPrintMediumCode.GetHashCode();
                    if (LipPrintMedium != null)
                    hashCode = hashCode * 59 + LipPrintMedium.GetHashCode();
                    if (PersonFacialHair != null)
                    hashCode = hashCode * 59 + PersonFacialHair.GetHashCode();
                    if (LipPositionTensionDescriptive != null)
                    hashCode = hashCode * 59 + LipPositionTensionDescriptive.GetHashCode();
                    if (LipPrintDescriptive != null)
                    hashCode = hashCode * 59 + LipPrintDescriptive.GetHashCode();
                    if (LipPrintComparisonDescriptive != null)
                    hashCode = hashCode * 59 + LipPrintComparisonDescriptive.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomCheiloscopicImageInformationType left, BiomCheiloscopicImageInformationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomCheiloscopicImageInformationType left, BiomCheiloscopicImageInformationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
