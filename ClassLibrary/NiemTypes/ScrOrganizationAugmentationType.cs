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
    /// A data type for additional information about an organization.
    /// </summary>
    [DataContract]
    public partial class ScrOrganizationAugmentationType : IEquatable<ScrOrganizationAugmentationType>
    { 
        /// <summary>
        /// True if an ORGANIZATION is suspected of illegal activities; false otherwise. NIEM reference is scr:CriminalAffiliationIndicator
        /// </summary>
        /// <value>True if an ORGANIZATION is suspected of illegal activities; false otherwise. NIEM reference is scr:CriminalAffiliationIndicator</value>

        [DataMember(Name="isCriminalAffiliation")]
        public List<NiemXsboolean> IsCriminalAffiliation { get; set; }

        /// <summary>
        /// True if the ORGANIZATION is determined to be fraudulent; false otherwise. NIEM reference is scr:FraudulentIndicator
        /// </summary>
        /// <value>True if the ORGANIZATION is determined to be fraudulent; false otherwise. NIEM reference is scr:FraudulentIndicator</value>

        [DataMember(Name="isFraudulent")]
        public List<NiemXsboolean> IsFraudulent { get; set; }

        /// <summary>
        /// An amount of money (dollars) earned by the ORGANIZATION each year. NIEM reference is scr:GrossAnnualIncomeAmount
        /// </summary>
        /// <value>An amount of money (dollars) earned by the ORGANIZATION each year. NIEM reference is scr:GrossAnnualIncomeAmount</value>

        [DataMember(Name="grossAnnualIncomeAmount")]
        public List<NcAmountType> GrossAnnualIncomeAmount { get; set; }

        /// <summary>
        /// A number of people belonging to the ORGANIZATION. NIEM reference is scr:OrganizationSizeQuantity
        /// </summary>
        /// <value>A number of people belonging to the ORGANIZATION. NIEM reference is scr:OrganizationSizeQuantity</value>

        [DataMember(Name="organizationSizeQuantity")]
        public List<NcQuantityType> OrganizationSizeQuantity { get; set; }

        /// <summary>
        /// True if the ORGANIZATION is determined to be questionable or under suspicion; false otherwise. NIEM reference is scr:SuspiciousIndicator
        /// </summary>
        /// <value>True if the ORGANIZATION is determined to be questionable or under suspicion; false otherwise. NIEM reference is scr:SuspiciousIndicator</value>

        [DataMember(Name="isSuspicious")]
        public List<NiemXsboolean> IsSuspicious { get; set; }

        /// <summary>
        /// A date the ORGANIZATION NAME became  effective. NIEM reference is scr:OrganizationNameEffectiveDate
        /// </summary>
        /// <value>A date the ORGANIZATION NAME became  effective. NIEM reference is scr:OrganizationNameEffectiveDate</value>

        [DataMember(Name="organizationNameEffectiveDate")]
        public List<NcDateType> OrganizationNameEffectiveDate { get; set; }

        /// <summary>
        /// An identification value of the name of the ORGANIZATION. NIEM reference is scr:OrganizationNameIdentification
        /// </summary>
        /// <value>An identification value of the name of the ORGANIZATION. NIEM reference is scr:OrganizationNameIdentification</value>

        [DataMember(Name="organizationNameIdentification")]
        public List<NcIdentificationType> OrganizationNameIdentification { get; set; }

        /// <summary>
        /// A date the ORGANIZATION NAME became invalid. NIEM reference is scr:OrganizationNameTerminationDate
        /// </summary>
        /// <value>A date the ORGANIZATION NAME became invalid. NIEM reference is scr:OrganizationNameTerminationDate</value>

        [DataMember(Name="organizationNameTerminationDate")]
        public List<NcDateType> OrganizationNameTerminationDate { get; set; }

        /// <summary>
        /// A kind of organization status. NIEM reference is scr:OrganizationStatusClassificationCategoryCode
        /// </summary>
        /// <value>A kind of organization status. NIEM reference is scr:OrganizationStatusClassificationCategoryCode</value>

        [DataMember(Name="organizationStatusClassificationCategoryCode")]
        public List<ScrOrganizationStatusCategoryCodeType> OrganizationStatusClassificationCategoryCode { get; set; }

        /// <summary>
        /// A kind of organization. NIEM reference is scr:OrganizationClassificationCategoryCode
        /// </summary>
        /// <value>A kind of organization. NIEM reference is scr:OrganizationClassificationCategoryCode</value>

        [DataMember(Name="organizationClassificationCategoryCode")]
        public List<ScrOrganizationCategoryCodeType> OrganizationClassificationCategoryCode { get; set; }

        /// <summary>
        /// scrOrganizationAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrOrganizationAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsscrOrganizationAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/scrOrganizationAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/scrOrganizationAugmentationTypeContext.jsonld")]
            JSONLDContextsscrOrganizationAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// scrOrganizationAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrOrganizationAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScrOrganizationAugmentationType {\n");
            sb.Append("  IsCriminalAffiliation: ").Append(IsCriminalAffiliation).Append("\n");
            sb.Append("  IsFraudulent: ").Append(IsFraudulent).Append("\n");
            sb.Append("  GrossAnnualIncomeAmount: ").Append(GrossAnnualIncomeAmount).Append("\n");
            sb.Append("  OrganizationSizeQuantity: ").Append(OrganizationSizeQuantity).Append("\n");
            sb.Append("  IsSuspicious: ").Append(IsSuspicious).Append("\n");
            sb.Append("  OrganizationNameEffectiveDate: ").Append(OrganizationNameEffectiveDate).Append("\n");
            sb.Append("  OrganizationNameIdentification: ").Append(OrganizationNameIdentification).Append("\n");
            sb.Append("  OrganizationNameTerminationDate: ").Append(OrganizationNameTerminationDate).Append("\n");
            sb.Append("  OrganizationStatusClassificationCategoryCode: ").Append(OrganizationStatusClassificationCategoryCode).Append("\n");
            sb.Append("  OrganizationClassificationCategoryCode: ").Append(OrganizationClassificationCategoryCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScrOrganizationAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if ScrOrganizationAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScrOrganizationAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScrOrganizationAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsCriminalAffiliation == other.IsCriminalAffiliation ||
                    IsCriminalAffiliation != null &&
                    IsCriminalAffiliation.SequenceEqual(other.IsCriminalAffiliation)
                ) && 
                (
                    IsFraudulent == other.IsFraudulent ||
                    IsFraudulent != null &&
                    IsFraudulent.SequenceEqual(other.IsFraudulent)
                ) && 
                (
                    GrossAnnualIncomeAmount == other.GrossAnnualIncomeAmount ||
                    GrossAnnualIncomeAmount != null &&
                    GrossAnnualIncomeAmount.SequenceEqual(other.GrossAnnualIncomeAmount)
                ) && 
                (
                    OrganizationSizeQuantity == other.OrganizationSizeQuantity ||
                    OrganizationSizeQuantity != null &&
                    OrganizationSizeQuantity.SequenceEqual(other.OrganizationSizeQuantity)
                ) && 
                (
                    IsSuspicious == other.IsSuspicious ||
                    IsSuspicious != null &&
                    IsSuspicious.SequenceEqual(other.IsSuspicious)
                ) && 
                (
                    OrganizationNameEffectiveDate == other.OrganizationNameEffectiveDate ||
                    OrganizationNameEffectiveDate != null &&
                    OrganizationNameEffectiveDate.SequenceEqual(other.OrganizationNameEffectiveDate)
                ) && 
                (
                    OrganizationNameIdentification == other.OrganizationNameIdentification ||
                    OrganizationNameIdentification != null &&
                    OrganizationNameIdentification.SequenceEqual(other.OrganizationNameIdentification)
                ) && 
                (
                    OrganizationNameTerminationDate == other.OrganizationNameTerminationDate ||
                    OrganizationNameTerminationDate != null &&
                    OrganizationNameTerminationDate.SequenceEqual(other.OrganizationNameTerminationDate)
                ) && 
                (
                    OrganizationStatusClassificationCategoryCode == other.OrganizationStatusClassificationCategoryCode ||
                    OrganizationStatusClassificationCategoryCode != null &&
                    OrganizationStatusClassificationCategoryCode.SequenceEqual(other.OrganizationStatusClassificationCategoryCode)
                ) && 
                (
                    OrganizationClassificationCategoryCode == other.OrganizationClassificationCategoryCode ||
                    OrganizationClassificationCategoryCode != null &&
                    OrganizationClassificationCategoryCode.SequenceEqual(other.OrganizationClassificationCategoryCode)
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
                    if (IsCriminalAffiliation != null)
                    hashCode = hashCode * 59 + IsCriminalAffiliation.GetHashCode();
                    if (IsFraudulent != null)
                    hashCode = hashCode * 59 + IsFraudulent.GetHashCode();
                    if (GrossAnnualIncomeAmount != null)
                    hashCode = hashCode * 59 + GrossAnnualIncomeAmount.GetHashCode();
                    if (OrganizationSizeQuantity != null)
                    hashCode = hashCode * 59 + OrganizationSizeQuantity.GetHashCode();
                    if (IsSuspicious != null)
                    hashCode = hashCode * 59 + IsSuspicious.GetHashCode();
                    if (OrganizationNameEffectiveDate != null)
                    hashCode = hashCode * 59 + OrganizationNameEffectiveDate.GetHashCode();
                    if (OrganizationNameIdentification != null)
                    hashCode = hashCode * 59 + OrganizationNameIdentification.GetHashCode();
                    if (OrganizationNameTerminationDate != null)
                    hashCode = hashCode * 59 + OrganizationNameTerminationDate.GetHashCode();
                    if (OrganizationStatusClassificationCategoryCode != null)
                    hashCode = hashCode * 59 + OrganizationStatusClassificationCategoryCode.GetHashCode();
                    if (OrganizationClassificationCategoryCode != null)
                    hashCode = hashCode * 59 + OrganizationClassificationCategoryCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScrOrganizationAugmentationType left, ScrOrganizationAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScrOrganizationAugmentationType left, ScrOrganizationAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
