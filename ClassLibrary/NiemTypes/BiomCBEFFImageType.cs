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
    /// A data type for a CBEFF record
    /// </summary>
    [DataContract]
    public partial class BiomCBEFFImageType : BiomImageType, IEquatable<BiomCBEFFImageType>
    { 
        /// <summary>
        /// An assigned identifier specifying a biometric format NIEM reference is biom:CBEFFFormatOwnerID
        /// </summary>
        /// <value>An assigned identifier specifying a biometric format NIEM reference is biom:CBEFFFormatOwnerID</value>

        [DataMember(Name="cbeffFormatOwnerId")]
        public List<BiomHexDoubleByteType> CbeffFormatOwnerId { get; set; }

        /// <summary>
        /// An identifier of a format designated by the owner NIEM reference is biom:CBEFFFormatCategoryID
        /// </summary>
        /// <value>An identifier of a format designated by the owner NIEM reference is biom:CBEFFFormatCategoryID</value>

        [DataMember(Name="cbeffFormatCategoryId")]
        public List<BiomHexDoubleByteType> CbeffFormatCategoryId { get; set; }

        /// <summary>
        /// A identifier for the version number of the CBEFF specification that this record conforms to NIEM reference is biom:CBEFFVersionID
        /// </summary>
        /// <value>A identifier for the version number of the CBEFF specification that this record conforms to NIEM reference is biom:CBEFFVersionID</value>

        [DataMember(Name="cbeffVersionId")]
        public List<NcTextType> CbeffVersionId { get; set; }

        /// <summary>
        /// A kind of biometric modality as described by CBEFF NIEM reference is biom:CBEFFCategoryCode
        /// </summary>
        /// <value>A kind of biometric modality as described by CBEFF NIEM reference is biom:CBEFFCategoryCode</value>

        [DataMember(Name="cbeffCategoryCode")]
        public List<BiomCBEFFCategoryCodeType> CbeffCategoryCode { get; set; }

        /// <summary>
        /// An optional field states the method used for determining the pixel density of the image. NIEM reference is biom:ResolutionMethodInformation
        /// </summary>
        /// <value>An optional field states the method used for determining the pixel density of the image. NIEM reference is biom:ResolutionMethodInformation</value>

        [DataMember(Name="resolutionMethodInformation")]
        public List<BiomResolutionMethodInformationType> ResolutionMethodInformation { get; set; }

        /// <summary>
        /// biomCBEFFImageType JSON-LD context
        /// </summary>
        /// <value>biomCBEFFImageType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomCBEFFImageTypeContextJsonldEnum for ../JSON-LD_Contexts/biomCBEFFImageTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomCBEFFImageTypeContext.jsonld")]
            JSONLDContextsbiomCBEFFImageTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomCBEFFImageType JSON-LD context
        /// </summary>
        /// <value>biomCBEFFImageType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomCBEFFImageType {\n");
            sb.Append("  CbeffFormatOwnerId: ").Append(CbeffFormatOwnerId).Append("\n");
            sb.Append("  CbeffFormatCategoryId: ").Append(CbeffFormatCategoryId).Append("\n");
            sb.Append("  CbeffVersionId: ").Append(CbeffVersionId).Append("\n");
            sb.Append("  CbeffCategoryCode: ").Append(CbeffCategoryCode).Append("\n");
            sb.Append("  ResolutionMethodInformation: ").Append(ResolutionMethodInformation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomCBEFFImageType)obj);
        }

        /// <summary>
        /// Returns true if BiomCBEFFImageType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomCBEFFImageType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomCBEFFImageType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CbeffFormatOwnerId == other.CbeffFormatOwnerId ||
                    CbeffFormatOwnerId != null &&
                    CbeffFormatOwnerId.SequenceEqual(other.CbeffFormatOwnerId)
                ) && 
                (
                    CbeffFormatCategoryId == other.CbeffFormatCategoryId ||
                    CbeffFormatCategoryId != null &&
                    CbeffFormatCategoryId.SequenceEqual(other.CbeffFormatCategoryId)
                ) && 
                (
                    CbeffVersionId == other.CbeffVersionId ||
                    CbeffVersionId != null &&
                    CbeffVersionId.SequenceEqual(other.CbeffVersionId)
                ) && 
                (
                    CbeffCategoryCode == other.CbeffCategoryCode ||
                    CbeffCategoryCode != null &&
                    CbeffCategoryCode.SequenceEqual(other.CbeffCategoryCode)
                ) && 
                (
                    ResolutionMethodInformation == other.ResolutionMethodInformation ||
                    ResolutionMethodInformation != null &&
                    ResolutionMethodInformation.SequenceEqual(other.ResolutionMethodInformation)
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
                    if (CbeffFormatOwnerId != null)
                    hashCode = hashCode * 59 + CbeffFormatOwnerId.GetHashCode();
                    if (CbeffFormatCategoryId != null)
                    hashCode = hashCode * 59 + CbeffFormatCategoryId.GetHashCode();
                    if (CbeffVersionId != null)
                    hashCode = hashCode * 59 + CbeffVersionId.GetHashCode();
                    if (CbeffCategoryCode != null)
                    hashCode = hashCode * 59 + CbeffCategoryCode.GetHashCode();
                    if (ResolutionMethodInformation != null)
                    hashCode = hashCode * 59 + ResolutionMethodInformation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomCBEFFImageType left, BiomCBEFFImageType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomCBEFFImageType left, BiomCBEFFImageType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
