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
    /// A data type for an organization responsible for processing DNA samples
    /// </summary>
    [DataContract]
    public partial class BiomDNALaboratoryType : NcOrganizationType, IEquatable<BiomDNALaboratoryType>
    { 
        /// <summary>
        /// A kind of DNA laboratory unit NIEM reference is biom:DNALaboratoryUnitCategoryCode
        /// </summary>
        /// <value>A kind of DNA laboratory unit NIEM reference is biom:DNALaboratoryUnitCategoryCode</value>

        [DataMember(Name="unitCategoryCode")]
        public List<BiomDNALaboratoryUnitCategoryCodeType> UnitCategoryCode { get; set; }

        /// <summary>
        /// A kind of DNA laboratory NIEM reference is biom:DNALaboratoryCategoryCode
        /// </summary>
        /// <value>A kind of DNA laboratory NIEM reference is biom:DNALaboratoryCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<BiomDNALaboratoryCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// A DNA laboratory accreditation NIEM reference is biom:DNALaboratoryAccreditation
        /// </summary>
        /// <value>A DNA laboratory accreditation NIEM reference is biom:DNALaboratoryAccreditation</value>

        [DataMember(Name="accreditation")]
        public List<BiomDNALaboratoryAccreditationType> Accreditation { get; set; }

        /// <summary>
        /// A country code, describing where DNA sample was processed. NIEM reference is biom:DNALaboratoryProcessingCountry
        /// </summary>
        /// <value>A country code, describing where DNA sample was processed. NIEM reference is biom:DNALaboratoryProcessingCountry</value>

        [DataMember(Name="processingCountry")]
        public List<NcCountryType> ProcessingCountry { get; set; }

        /// <summary>
        /// A name of an international affiliation of the DNA submitting organization NIEM reference is biom:DNALaboratoryInternationalOrganizationName
        /// </summary>
        /// <value>A name of an international affiliation of the DNA submitting organization NIEM reference is biom:DNALaboratoryInternationalOrganizationName</value>

        [DataMember(Name="internationalOrganizationName")]
        public List<NcTextType> InternationalOrganizationName { get; set; }

        /// <summary>
        /// biomDNALaboratoryType JSON-LD context
        /// </summary>
        /// <value>biomDNALaboratoryType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomDNALaboratoryTypeContextJsonldEnum for ../JSON-LD_Contexts/biomDNALaboratoryTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomDNALaboratoryTypeContext.jsonld")]
            JSONLDContextsbiomDNALaboratoryTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomDNALaboratoryType JSON-LD context
        /// </summary>
        /// <value>biomDNALaboratoryType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomDNALaboratoryType {\n");
            sb.Append("  UnitCategoryCode: ").Append(UnitCategoryCode).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  Accreditation: ").Append(Accreditation).Append("\n");
            sb.Append("  ProcessingCountry: ").Append(ProcessingCountry).Append("\n");
            sb.Append("  InternationalOrganizationName: ").Append(InternationalOrganizationName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomDNALaboratoryType)obj);
        }

        /// <summary>
        /// Returns true if BiomDNALaboratoryType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomDNALaboratoryType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomDNALaboratoryType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UnitCategoryCode == other.UnitCategoryCode ||
                    UnitCategoryCode != null &&
                    UnitCategoryCode.SequenceEqual(other.UnitCategoryCode)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    Accreditation == other.Accreditation ||
                    Accreditation != null &&
                    Accreditation.SequenceEqual(other.Accreditation)
                ) && 
                (
                    ProcessingCountry == other.ProcessingCountry ||
                    ProcessingCountry != null &&
                    ProcessingCountry.SequenceEqual(other.ProcessingCountry)
                ) && 
                (
                    InternationalOrganizationName == other.InternationalOrganizationName ||
                    InternationalOrganizationName != null &&
                    InternationalOrganizationName.SequenceEqual(other.InternationalOrganizationName)
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
                    if (UnitCategoryCode != null)
                    hashCode = hashCode * 59 + UnitCategoryCode.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (Accreditation != null)
                    hashCode = hashCode * 59 + Accreditation.GetHashCode();
                    if (ProcessingCountry != null)
                    hashCode = hashCode * 59 + ProcessingCountry.GetHashCode();
                    if (InternationalOrganizationName != null)
                    hashCode = hashCode * 59 + InternationalOrganizationName.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomDNALaboratoryType left, BiomDNALaboratoryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomDNALaboratoryType left, BiomDNALaboratoryType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
