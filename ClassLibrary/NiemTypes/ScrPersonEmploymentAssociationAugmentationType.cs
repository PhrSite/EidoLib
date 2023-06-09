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
    /// A data type for additional information about a person employment association.
    /// </summary>
    [DataContract]
    public partial class ScrPersonEmploymentAssociationAugmentationType : IEquatable<ScrPersonEmploymentAssociationAugmentationType>
    { 
        /// <summary>
        /// A human being. NIEM reference is nc:Person
        /// </summary>
        /// <value>A human being. NIEM reference is nc:Person</value>

        [DataMember(Name="person")]
        public List<NcPersonType> Person { get; set; }

        /// <summary>
        /// A unit which conducts some sort of business or operations. NIEM reference is nc:Organization
        /// </summary>
        /// <value>A unit which conducts some sort of business or operations. NIEM reference is nc:Organization</value>

        [DataMember(Name="organization")]
        public List<NcOrganizationType> Organization { get; set; }

        /// <summary>
        /// An amount of remuneration resulting from PERSON EMPLOYMENT. NIEM reference is scr:PayRateAmount
        /// </summary>
        /// <value>An amount of remuneration resulting from PERSON EMPLOYMENT. NIEM reference is scr:PayRateAmount</value>

        [DataMember(Name="payRateAmount")]
        public List<NcAmountType> PayRateAmount { get; set; }

        /// <summary>
        /// A remuneration amount for Person&#x27;s starting salary. NIEM reference is scr:BeginSalaryAmount
        /// </summary>
        /// <value>A remuneration amount for Person&#x27;s starting salary. NIEM reference is scr:BeginSalaryAmount</value>

        [DataMember(Name="beginSalaryAmount")]
        public List<NcAmountType> BeginSalaryAmount { get; set; }

        /// <summary>
        /// A date when the remuneration for PERSON EMPLOYMENT ended. NIEM reference is scr:EndSalaryAmount
        /// </summary>
        /// <value>A date when the remuneration for PERSON EMPLOYMENT ended. NIEM reference is scr:EndSalaryAmount</value>

        [DataMember(Name="endSalaryAmount")]
        public List<NcAmountType> EndSalaryAmount { get; set; }

        /// <summary>
        /// An identifier for a number representing the call number of an EMPLOYEE. NIEM reference is scr:EmployeeStarNumberID
        /// </summary>
        /// <value>An identifier for a number representing the call number of an EMPLOYEE. NIEM reference is scr:EmployeeStarNumberID</value>

        [DataMember(Name="employeeStarNumberId")]
        public List<NiemXsstring> EmployeeStarNumberId { get; set; }

        /// <summary>
        /// An identifier number for the the badge of the EMPLOYEE NIEM reference is scr:EmployeeBadgeNumberID
        /// </summary>
        /// <value>An identifier number for the the badge of the EMPLOYEE NIEM reference is scr:EmployeeBadgeNumberID</value>

        [DataMember(Name="employeeBadgeNumberId")]
        public List<NiemXsstring> EmployeeBadgeNumberId { get; set; }

        /// <summary>
        /// An identifier for the call number of the EMPLOYEE NIEM reference is scr:EmployeeCallNumberID
        /// </summary>
        /// <value>An identifier for the call number of the EMPLOYEE NIEM reference is scr:EmployeeCallNumberID</value>

        [DataMember(Name="employeeCallNumberId")]
        public List<NiemXsstring> EmployeeCallNumberId { get; set; }

        /// <summary>
        /// scrPersonEmploymentAssociationAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrPersonEmploymentAssociationAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsscrPersonEmploymentAssociationAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/scrPersonEmploymentAssociationAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/scrPersonEmploymentAssociationAugmentationTypeContext.jsonld")]
            JSONLDContextsscrPersonEmploymentAssociationAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// scrPersonEmploymentAssociationAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrPersonEmploymentAssociationAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScrPersonEmploymentAssociationAugmentationType {\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  PayRateAmount: ").Append(PayRateAmount).Append("\n");
            sb.Append("  BeginSalaryAmount: ").Append(BeginSalaryAmount).Append("\n");
            sb.Append("  EndSalaryAmount: ").Append(EndSalaryAmount).Append("\n");
            sb.Append("  EmployeeStarNumberId: ").Append(EmployeeStarNumberId).Append("\n");
            sb.Append("  EmployeeBadgeNumberId: ").Append(EmployeeBadgeNumberId).Append("\n");
            sb.Append("  EmployeeCallNumberId: ").Append(EmployeeCallNumberId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScrPersonEmploymentAssociationAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if ScrPersonEmploymentAssociationAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScrPersonEmploymentAssociationAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScrPersonEmploymentAssociationAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Person == other.Person ||
                    Person != null &&
                    Person.SequenceEqual(other.Person)
                ) && 
                (
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.SequenceEqual(other.Organization)
                ) && 
                (
                    PayRateAmount == other.PayRateAmount ||
                    PayRateAmount != null &&
                    PayRateAmount.SequenceEqual(other.PayRateAmount)
                ) && 
                (
                    BeginSalaryAmount == other.BeginSalaryAmount ||
                    BeginSalaryAmount != null &&
                    BeginSalaryAmount.SequenceEqual(other.BeginSalaryAmount)
                ) && 
                (
                    EndSalaryAmount == other.EndSalaryAmount ||
                    EndSalaryAmount != null &&
                    EndSalaryAmount.SequenceEqual(other.EndSalaryAmount)
                ) && 
                (
                    EmployeeStarNumberId == other.EmployeeStarNumberId ||
                    EmployeeStarNumberId != null &&
                    EmployeeStarNumberId.SequenceEqual(other.EmployeeStarNumberId)
                ) && 
                (
                    EmployeeBadgeNumberId == other.EmployeeBadgeNumberId ||
                    EmployeeBadgeNumberId != null &&
                    EmployeeBadgeNumberId.SequenceEqual(other.EmployeeBadgeNumberId)
                ) && 
                (
                    EmployeeCallNumberId == other.EmployeeCallNumberId ||
                    EmployeeCallNumberId != null &&
                    EmployeeCallNumberId.SequenceEqual(other.EmployeeCallNumberId)
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
                    if (Person != null)
                    hashCode = hashCode * 59 + Person.GetHashCode();
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                    if (PayRateAmount != null)
                    hashCode = hashCode * 59 + PayRateAmount.GetHashCode();
                    if (BeginSalaryAmount != null)
                    hashCode = hashCode * 59 + BeginSalaryAmount.GetHashCode();
                    if (EndSalaryAmount != null)
                    hashCode = hashCode * 59 + EndSalaryAmount.GetHashCode();
                    if (EmployeeStarNumberId != null)
                    hashCode = hashCode * 59 + EmployeeStarNumberId.GetHashCode();
                    if (EmployeeBadgeNumberId != null)
                    hashCode = hashCode * 59 + EmployeeBadgeNumberId.GetHashCode();
                    if (EmployeeCallNumberId != null)
                    hashCode = hashCode * 59 + EmployeeCallNumberId.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScrPersonEmploymentAssociationAugmentationType left, ScrPersonEmploymentAssociationAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScrPersonEmploymentAssociationAugmentationType left, ScrPersonEmploymentAssociationAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
