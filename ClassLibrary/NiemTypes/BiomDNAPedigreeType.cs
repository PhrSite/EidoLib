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
    /// A data type for a description of a pedigree originating and held at a DNA laboratory
    /// </summary>
    [DataContract]
    public partial class BiomDNAPedigreeType : IEquatable<BiomDNAPedigreeType>
    { 
        /// <summary>
        /// An identifier (i.e., file number) of a DNA pedigree NIEM reference is biom:DNAPedigreeID
        /// </summary>
        /// <value>An identifier (i.e., file number) of a DNA pedigree NIEM reference is biom:DNAPedigreeID</value>

        [DataMember(Name="dnaPedigreeId")]
        public List<NcTextType> DnaPedigreeId { get; set; }

        /// <summary>
        /// An index that refers to the DNA subject of the transaction and provides the ability to link pedigree information. NIEM reference is biom:DNAPedigreeMemberIndexNumeric
        /// </summary>
        /// <value>An index that refers to the DNA subject of the transaction and provides the ability to link pedigree information. NIEM reference is biom:DNAPedigreeMemberIndexNumeric</value>

        [DataMember(Name="memberIndexNumeric")]
        public List<NcTextType> MemberIndexNumeric { get; set; }

        /// <summary>
        /// A status of a subject of a DNA pedigree NIEM reference is biom:DNAPedigreeMemberStatusCode
        /// </summary>
        /// <value>A status of a subject of a DNA pedigree NIEM reference is biom:DNAPedigreeMemberStatusCode</value>

        [DataMember(Name="memberStatusCode")]
        public List<BiomDNAPedigreeMemberStatusCodeType> MemberStatusCode { get; set; }

        /// <summary>
        /// An Identifier for a DNA sample linking it to this related pedigree NIEM reference is biom:DNAPedigreeSampleID
        /// </summary>
        /// <value>An Identifier for a DNA sample linking it to this related pedigree NIEM reference is biom:DNAPedigreeSampleID</value>

        [DataMember(Name="sampleId")]
        public List<NcTextType> SampleId { get; set; }

        /// <summary>
        /// An index number that refers to the father of the subject of this DNA pedigree NIEM reference is biom:DNAPedigreeFatherIndexNumeric
        /// </summary>
        /// <value>An index number that refers to the father of the subject of this DNA pedigree NIEM reference is biom:DNAPedigreeFatherIndexNumeric</value>

        [DataMember(Name="fatherIndexNumeric")]
        public List<BiomInteger0to999Type> FatherIndexNumeric { get; set; }

        /// <summary>
        /// An index number that refers to the mother of a subject of this DNA pedigree NIEM reference is biom:DNAPedigreeMotherIndexNumeric
        /// </summary>
        /// <value>An index number that refers to the mother of a subject of this DNA pedigree NIEM reference is biom:DNAPedigreeMotherIndexNumeric</value>

        [DataMember(Name="motherIndexNumeric")]
        public List<BiomInteger0to999Type> MotherIndexNumeric { get; set; }

        /// <summary>
        /// A descriptive comment about a DNA pedigree NIEM reference is biom:DNAPedigreeCommentText
        /// </summary>
        /// <value>A descriptive comment about a DNA pedigree NIEM reference is biom:DNAPedigreeCommentText</value>

        [DataMember(Name="comment")]
        public List<NcTextType> Comment { get; set; }

        /// <summary>
        /// biomDNAPedigreeType JSON-LD context
        /// </summary>
        /// <value>biomDNAPedigreeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomDNAPedigreeTypeContextJsonldEnum for ../JSON-LD_Contexts/biomDNAPedigreeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomDNAPedigreeTypeContext.jsonld")]
            JSONLDContextsbiomDNAPedigreeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomDNAPedigreeType JSON-LD context
        /// </summary>
        /// <value>biomDNAPedigreeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomDNAPedigreeType {\n");
            sb.Append("  DnaPedigreeId: ").Append(DnaPedigreeId).Append("\n");
            sb.Append("  MemberIndexNumeric: ").Append(MemberIndexNumeric).Append("\n");
            sb.Append("  MemberStatusCode: ").Append(MemberStatusCode).Append("\n");
            sb.Append("  SampleId: ").Append(SampleId).Append("\n");
            sb.Append("  FatherIndexNumeric: ").Append(FatherIndexNumeric).Append("\n");
            sb.Append("  MotherIndexNumeric: ").Append(MotherIndexNumeric).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomDNAPedigreeType)obj);
        }

        /// <summary>
        /// Returns true if BiomDNAPedigreeType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomDNAPedigreeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomDNAPedigreeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DnaPedigreeId == other.DnaPedigreeId ||
                    DnaPedigreeId != null &&
                    DnaPedigreeId.SequenceEqual(other.DnaPedigreeId)
                ) && 
                (
                    MemberIndexNumeric == other.MemberIndexNumeric ||
                    MemberIndexNumeric != null &&
                    MemberIndexNumeric.SequenceEqual(other.MemberIndexNumeric)
                ) && 
                (
                    MemberStatusCode == other.MemberStatusCode ||
                    MemberStatusCode != null &&
                    MemberStatusCode.SequenceEqual(other.MemberStatusCode)
                ) && 
                (
                    SampleId == other.SampleId ||
                    SampleId != null &&
                    SampleId.SequenceEqual(other.SampleId)
                ) && 
                (
                    FatherIndexNumeric == other.FatherIndexNumeric ||
                    FatherIndexNumeric != null &&
                    FatherIndexNumeric.SequenceEqual(other.FatherIndexNumeric)
                ) && 
                (
                    MotherIndexNumeric == other.MotherIndexNumeric ||
                    MotherIndexNumeric != null &&
                    MotherIndexNumeric.SequenceEqual(other.MotherIndexNumeric)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.SequenceEqual(other.Comment)
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
                    if (DnaPedigreeId != null)
                    hashCode = hashCode * 59 + DnaPedigreeId.GetHashCode();
                    if (MemberIndexNumeric != null)
                    hashCode = hashCode * 59 + MemberIndexNumeric.GetHashCode();
                    if (MemberStatusCode != null)
                    hashCode = hashCode * 59 + MemberStatusCode.GetHashCode();
                    if (SampleId != null)
                    hashCode = hashCode * 59 + SampleId.GetHashCode();
                    if (FatherIndexNumeric != null)
                    hashCode = hashCode * 59 + FatherIndexNumeric.GetHashCode();
                    if (MotherIndexNumeric != null)
                    hashCode = hashCode * 59 + MotherIndexNumeric.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomDNAPedigreeType left, BiomDNAPedigreeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomDNAPedigreeType left, BiomDNAPedigreeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}