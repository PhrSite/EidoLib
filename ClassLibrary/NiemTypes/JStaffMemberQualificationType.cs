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
    /// A data type for a description of specific training, education or experience of a staff member.
    /// </summary>
    [DataContract]
    public partial class JStaffMemberQualificationType : IEquatable<JStaffMemberQualificationType>
    { 
        /// <summary>
        /// True if of compliance for education credentials; false otherwise. NIEM reference is j:StaffMemberQualificationHighlyQualifiedTeacherIndicator
        /// </summary>
        /// <value>True if of compliance for education credentials; false otherwise. NIEM reference is j:StaffMemberQualificationHighlyQualifiedTeacherIndicator</value>

        [DataMember(Name="isHighlyQualifiedTeacher")]
        public List<NiemXsboolean> IsHighlyQualifiedTeacher { get; set; }

        /// <summary>
        /// True if of whether the staff member has a felony in the last 3 years; false otherwise. NIEM reference is j:StaffMemberQualificationFelonyInLast3YearsIndicator
        /// </summary>
        /// <value>True if of whether the staff member has a felony in the last 3 years; false otherwise. NIEM reference is j:StaffMemberQualificationFelonyInLast3YearsIndicator</value>

        [DataMember(Name="isFelonyInLast3Years")]
        public List<NiemXsboolean> IsFelonyInLast3Years { get; set; }

        /// <summary>
        /// A kind of staff member experience as it relates to their qualifications. NIEM reference is j:StaffMemberQualificationExperienceCategoryText
        /// </summary>
        /// <value>A kind of staff member experience as it relates to their qualifications. NIEM reference is j:StaffMemberQualificationExperienceCategoryText</value>

        [DataMember(Name="experienceCategory")]
        public List<NcTextType> ExperienceCategory { get; set; }

        /// <summary>
        /// True if the staff member has a history of serious or violent or felony activity; false otherwise. NIEM reference is j:StaffMemberQualificationsHistoryOfSeriousOrViolentFelonyIndicator
        /// </summary>
        /// <value>True if the staff member has a history of serious or violent or felony activity; false otherwise. NIEM reference is j:StaffMemberQualificationsHistoryOfSeriousOrViolentFelonyIndicator</value>

        [DataMember(Name="isSHistoryOfSeriousOrViolentFelony")]
        public List<NiemXsboolean> IsSHistoryOfSeriousOrViolentFelony { get; set; }

        /// <summary>
        /// A kind of staff member qualification. NIEM reference is j:StaffMemberQualificationCategoryText
        /// </summary>
        /// <value>A kind of staff member qualification. NIEM reference is j:StaffMemberQualificationCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// True if the staff member has earned a social sciences degree; false otherwise. NIEM reference is j:StaffMemberSocialScienceDegreeIndicator
        /// </summary>
        /// <value>True if the staff member has earned a social sciences degree; false otherwise. NIEM reference is j:StaffMemberSocialScienceDegreeIndicator</value>

        [DataMember(Name="isStaffMemberSocialScienceDegree")]
        public List<NiemXsboolean> IsStaffMemberSocialScienceDegree { get; set; }

        /// <summary>
        /// True if staff counselor has certification required under the Affordable Care Act (ACA) for enrolling individuals in health care programs, where appropriate; false otherwise. NIEM reference is j:StaffMemberQualificationsAffordableCareActIndicator
        /// </summary>
        /// <value>True if staff counselor has certification required under the Affordable Care Act (ACA) for enrolling individuals in health care programs, where appropriate; false otherwise. NIEM reference is j:StaffMemberQualificationsAffordableCareActIndicator</value>

        [DataMember(Name="isSAffordableCareAct")]
        public List<NiemXsboolean> IsSAffordableCareAct { get; set; }

        /// <summary>
        /// A statement that indicates how a provider staff member satisfies the qualification statements of a key position within a rehabilitation program or a service delivery program. NIEM reference is j:StaffMemberQualificationSatisfactionStatementText
        /// </summary>
        /// <value>A statement that indicates how a provider staff member satisfies the qualification statements of a key position within a rehabilitation program or a service delivery program. NIEM reference is j:StaffMemberQualificationSatisfactionStatementText</value>

        [DataMember(Name="satisfactionStatement")]
        public List<NcTextType> SatisfactionStatement { get; set; }

        /// <summary>
        /// A text field used to define a qualification required of a staff member assigned to a key position on a contract for rehabilitation services. NIEM reference is j:StaffMemberQualificationStatementText
        /// </summary>
        /// <value>A text field used to define a qualification required of a staff member assigned to a key position on a contract for rehabilitation services. NIEM reference is j:StaffMemberQualificationStatementText</value>

        [DataMember(Name="statement")]
        public List<NcTextType> Statement { get; set; }

        /// <summary>
        /// A kind of certifications for clinicians if applicable. NIEM reference is j:StaffMemberQualificationsTXProfessionalCertificationText
        /// </summary>
        /// <value>A kind of certifications for clinicians if applicable. NIEM reference is j:StaffMemberQualificationsTXProfessionalCertificationText</value>

        [DataMember(Name="sTxProfessionalCertification")]
        public List<NcTextType> STxProfessionalCertification { get; set; }

        /// <summary>
        /// A number indicating the years that a staff member has been employed. NIEM reference is j:StaffMemberServiceYearsOfServiceNumeric
        /// </summary>
        /// <value>A number indicating the years that a staff member has been employed. NIEM reference is j:StaffMemberServiceYearsOfServiceNumeric</value>

        [DataMember(Name="staffMemberServiceYearsOfServiceNumeric")]
        public List<NcNumericType> StaffMemberServiceYearsOfServiceNumeric { get; set; }

        /// <summary>
        /// A kind of security clearance. NIEM reference is j:StaffMemberSecurityClearanceResultsText
        /// </summary>
        /// <value>A kind of security clearance. NIEM reference is j:StaffMemberSecurityClearanceResultsText</value>

        [DataMember(Name="staffMemberSecurityClearanceResults")]
        public List<NcTextType> StaffMemberSecurityClearanceResults { get; set; }

        /// <summary>
        /// True if of whether a security clearance was conducted; false otherwise. NIEM reference is j:StaffMemberSecurityClearanceCompletedIndicator
        /// </summary>
        /// <value>True if of whether a security clearance was conducted; false otherwise. NIEM reference is j:StaffMemberSecurityClearanceCompletedIndicator</value>

        [DataMember(Name="isStaffMemberSecurityClearanceCompleted")]
        public List<NiemXsboolean> IsStaffMemberSecurityClearanceCompleted { get; set; }

        /// <summary>
        /// A number indicating the months that a staff member has been employed. NIEM reference is j:StaffMemberServiceMonthsOfServiceNumeric
        /// </summary>
        /// <value>A number indicating the months that a staff member has been employed. NIEM reference is j:StaffMemberServiceMonthsOfServiceNumeric</value>

        [DataMember(Name="staffMemberServiceMonthsOfServiceNumeric")]
        public List<NcNumericType> StaffMemberServiceMonthsOfServiceNumeric { get; set; }

        /// <summary>
        /// A date that the security clearance was completed. NIEM reference is j:StaffMemberQualificationSecurityClearanceCompletionDate
        /// </summary>
        /// <value>A date that the security clearance was completed. NIEM reference is j:StaffMemberQualificationSecurityClearanceCompletionDate</value>

        [DataMember(Name="securityClearanceCompletionDate")]
        public List<NcDateType> SecurityClearanceCompletionDate { get; set; }

        /// <summary>
        /// jStaffMemberQualificationType JSON-LD context
        /// </summary>
        /// <value>jStaffMemberQualificationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjStaffMemberQualificationTypeContextJsonldEnum for ../JSON-LD_Contexts/jStaffMemberQualificationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jStaffMemberQualificationTypeContext.jsonld")]
            JSONLDContextsjStaffMemberQualificationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jStaffMemberQualificationType JSON-LD context
        /// </summary>
        /// <value>jStaffMemberQualificationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JStaffMemberQualificationType {\n");
            sb.Append("  IsHighlyQualifiedTeacher: ").Append(IsHighlyQualifiedTeacher).Append("\n");
            sb.Append("  IsFelonyInLast3Years: ").Append(IsFelonyInLast3Years).Append("\n");
            sb.Append("  ExperienceCategory: ").Append(ExperienceCategory).Append("\n");
            sb.Append("  IsSHistoryOfSeriousOrViolentFelony: ").Append(IsSHistoryOfSeriousOrViolentFelony).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsStaffMemberSocialScienceDegree: ").Append(IsStaffMemberSocialScienceDegree).Append("\n");
            sb.Append("  IsSAffordableCareAct: ").Append(IsSAffordableCareAct).Append("\n");
            sb.Append("  SatisfactionStatement: ").Append(SatisfactionStatement).Append("\n");
            sb.Append("  Statement: ").Append(Statement).Append("\n");
            sb.Append("  STxProfessionalCertification: ").Append(STxProfessionalCertification).Append("\n");
            sb.Append("  StaffMemberServiceYearsOfServiceNumeric: ").Append(StaffMemberServiceYearsOfServiceNumeric).Append("\n");
            sb.Append("  StaffMemberSecurityClearanceResults: ").Append(StaffMemberSecurityClearanceResults).Append("\n");
            sb.Append("  IsStaffMemberSecurityClearanceCompleted: ").Append(IsStaffMemberSecurityClearanceCompleted).Append("\n");
            sb.Append("  StaffMemberServiceMonthsOfServiceNumeric: ").Append(StaffMemberServiceMonthsOfServiceNumeric).Append("\n");
            sb.Append("  SecurityClearanceCompletionDate: ").Append(SecurityClearanceCompletionDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JStaffMemberQualificationType)obj);
        }

        /// <summary>
        /// Returns true if JStaffMemberQualificationType instances are equal
        /// </summary>
        /// <param name="other">Instance of JStaffMemberQualificationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JStaffMemberQualificationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsHighlyQualifiedTeacher == other.IsHighlyQualifiedTeacher ||
                    IsHighlyQualifiedTeacher != null &&
                    IsHighlyQualifiedTeacher.SequenceEqual(other.IsHighlyQualifiedTeacher)
                ) && 
                (
                    IsFelonyInLast3Years == other.IsFelonyInLast3Years ||
                    IsFelonyInLast3Years != null &&
                    IsFelonyInLast3Years.SequenceEqual(other.IsFelonyInLast3Years)
                ) && 
                (
                    ExperienceCategory == other.ExperienceCategory ||
                    ExperienceCategory != null &&
                    ExperienceCategory.SequenceEqual(other.ExperienceCategory)
                ) && 
                (
                    IsSHistoryOfSeriousOrViolentFelony == other.IsSHistoryOfSeriousOrViolentFelony ||
                    IsSHistoryOfSeriousOrViolentFelony != null &&
                    IsSHistoryOfSeriousOrViolentFelony.SequenceEqual(other.IsSHistoryOfSeriousOrViolentFelony)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    IsStaffMemberSocialScienceDegree == other.IsStaffMemberSocialScienceDegree ||
                    IsStaffMemberSocialScienceDegree != null &&
                    IsStaffMemberSocialScienceDegree.SequenceEqual(other.IsStaffMemberSocialScienceDegree)
                ) && 
                (
                    IsSAffordableCareAct == other.IsSAffordableCareAct ||
                    IsSAffordableCareAct != null &&
                    IsSAffordableCareAct.SequenceEqual(other.IsSAffordableCareAct)
                ) && 
                (
                    SatisfactionStatement == other.SatisfactionStatement ||
                    SatisfactionStatement != null &&
                    SatisfactionStatement.SequenceEqual(other.SatisfactionStatement)
                ) && 
                (
                    Statement == other.Statement ||
                    Statement != null &&
                    Statement.SequenceEqual(other.Statement)
                ) && 
                (
                    STxProfessionalCertification == other.STxProfessionalCertification ||
                    STxProfessionalCertification != null &&
                    STxProfessionalCertification.SequenceEqual(other.STxProfessionalCertification)
                ) && 
                (
                    StaffMemberServiceYearsOfServiceNumeric == other.StaffMemberServiceYearsOfServiceNumeric ||
                    StaffMemberServiceYearsOfServiceNumeric != null &&
                    StaffMemberServiceYearsOfServiceNumeric.SequenceEqual(other.StaffMemberServiceYearsOfServiceNumeric)
                ) && 
                (
                    StaffMemberSecurityClearanceResults == other.StaffMemberSecurityClearanceResults ||
                    StaffMemberSecurityClearanceResults != null &&
                    StaffMemberSecurityClearanceResults.SequenceEqual(other.StaffMemberSecurityClearanceResults)
                ) && 
                (
                    IsStaffMemberSecurityClearanceCompleted == other.IsStaffMemberSecurityClearanceCompleted ||
                    IsStaffMemberSecurityClearanceCompleted != null &&
                    IsStaffMemberSecurityClearanceCompleted.SequenceEqual(other.IsStaffMemberSecurityClearanceCompleted)
                ) && 
                (
                    StaffMemberServiceMonthsOfServiceNumeric == other.StaffMemberServiceMonthsOfServiceNumeric ||
                    StaffMemberServiceMonthsOfServiceNumeric != null &&
                    StaffMemberServiceMonthsOfServiceNumeric.SequenceEqual(other.StaffMemberServiceMonthsOfServiceNumeric)
                ) && 
                (
                    SecurityClearanceCompletionDate == other.SecurityClearanceCompletionDate ||
                    SecurityClearanceCompletionDate != null &&
                    SecurityClearanceCompletionDate.SequenceEqual(other.SecurityClearanceCompletionDate)
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
                    if (IsHighlyQualifiedTeacher != null)
                    hashCode = hashCode * 59 + IsHighlyQualifiedTeacher.GetHashCode();
                    if (IsFelonyInLast3Years != null)
                    hashCode = hashCode * 59 + IsFelonyInLast3Years.GetHashCode();
                    if (ExperienceCategory != null)
                    hashCode = hashCode * 59 + ExperienceCategory.GetHashCode();
                    if (IsSHistoryOfSeriousOrViolentFelony != null)
                    hashCode = hashCode * 59 + IsSHistoryOfSeriousOrViolentFelony.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (IsStaffMemberSocialScienceDegree != null)
                    hashCode = hashCode * 59 + IsStaffMemberSocialScienceDegree.GetHashCode();
                    if (IsSAffordableCareAct != null)
                    hashCode = hashCode * 59 + IsSAffordableCareAct.GetHashCode();
                    if (SatisfactionStatement != null)
                    hashCode = hashCode * 59 + SatisfactionStatement.GetHashCode();
                    if (Statement != null)
                    hashCode = hashCode * 59 + Statement.GetHashCode();
                    if (STxProfessionalCertification != null)
                    hashCode = hashCode * 59 + STxProfessionalCertification.GetHashCode();
                    if (StaffMemberServiceYearsOfServiceNumeric != null)
                    hashCode = hashCode * 59 + StaffMemberServiceYearsOfServiceNumeric.GetHashCode();
                    if (StaffMemberSecurityClearanceResults != null)
                    hashCode = hashCode * 59 + StaffMemberSecurityClearanceResults.GetHashCode();
                    if (IsStaffMemberSecurityClearanceCompleted != null)
                    hashCode = hashCode * 59 + IsStaffMemberSecurityClearanceCompleted.GetHashCode();
                    if (StaffMemberServiceMonthsOfServiceNumeric != null)
                    hashCode = hashCode * 59 + StaffMemberServiceMonthsOfServiceNumeric.GetHashCode();
                    if (SecurityClearanceCompletionDate != null)
                    hashCode = hashCode * 59 + SecurityClearanceCompletionDate.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JStaffMemberQualificationType left, JStaffMemberQualificationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JStaffMemberQualificationType left, JStaffMemberQualificationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
