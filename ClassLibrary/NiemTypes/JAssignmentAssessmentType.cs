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
    /// A data type for a process of determining whether a subject is fit for a particular assignment (program or service).
    /// </summary>
    [DataContract]
    public partial class JAssignmentAssessmentType : IEquatable<JAssignmentAssessmentType>
    { 
        /// <summary>
        /// A description of the special housing requirements based on assignment assessment. NIEM reference is j:AssignmentAssessmentRequiresSpecialHousingDetailsText
        /// </summary>
        /// <value>A description of the special housing requirements based on assignment assessment. NIEM reference is j:AssignmentAssessmentRequiresSpecialHousingDetailsText</value>

        [DataMember(Name="requiresSpecialHousingDetails")]
        public List<NcTextType> RequiresSpecialHousingDetails { get; set; }

        /// <summary>
        /// An initial request for assignment. NIEM reference is j:AssignmentAssessmentAssignmentRequest
        /// </summary>
        /// <value>An initial request for assignment. NIEM reference is j:AssignmentAssessmentAssignmentRequest</value>

        [DataMember(Name="assignmentRequest")]
        public List<NcActivityType> AssignmentRequest { get; set; }

        /// <summary>
        /// A comment about the assignment assessment. NIEM reference is j:AssignmentAssessmentComment
        /// </summary>
        /// <value>A comment about the assignment assessment. NIEM reference is j:AssignmentAssessmentComment</value>

        [DataMember(Name="comment")]
        public List<NcCommentType> Comment { get; set; }

        /// <summary>
        /// A decision regarding assignment after completion of the assessment. NIEM reference is j:AssignmentAssessmentDecision
        /// </summary>
        /// <value>A decision regarding assignment after completion of the assessment. NIEM reference is j:AssignmentAssessmentDecision</value>

        [DataMember(Name="decision")]
        public List<NcActivityType> Decision { get; set; }

        /// <summary>
        /// A determination of any developmental disability issues as a part of the assessment. NIEM reference is j:AssignmentAssessmentDevelopmentalDisability
        /// </summary>
        /// <value>A determination of any developmental disability issues as a part of the assessment. NIEM reference is j:AssignmentAssessmentDevelopmentalDisability</value>

        [DataMember(Name="developmentalDisability")]
        public List<JDevelopmentalDisabilityType> DevelopmentalDisability { get; set; }

        /// <summary>
        /// A comment regarding a health condition recorded as part of an assignment assessment. NIEM reference is j:AssignmentAssessmentHealthConditionComment
        /// </summary>
        /// <value>A comment regarding a health condition recorded as part of an assignment assessment. NIEM reference is j:AssignmentAssessmentHealthConditionComment</value>

        [DataMember(Name="healthConditionComment")]
        public List<NcCommentType> HealthConditionComment { get; set; }

        /// <summary>
        /// A description of the details of other health issues. NIEM reference is j:AssignmentAssessmentHealthOtherConditionDetailsText
        /// </summary>
        /// <value>A description of the details of other health issues. NIEM reference is j:AssignmentAssessmentHealthOtherConditionDetailsText</value>

        [DataMember(Name="healthOtherConditionDetails")]
        public List<NcTextType> HealthOtherConditionDetails { get; set; }

        /// <summary>
        /// A kind of health condition recorded as part of an assignment assessment. NIEM reference is j:AssignmentAssessmentHealthConditionText
        /// </summary>
        /// <value>A kind of health condition recorded as part of an assignment assessment. NIEM reference is j:AssignmentAssessmentHealthConditionText</value>

        [DataMember(Name="healthCondition")]
        public List<NcTextType> HealthCondition { get; set; }

        /// <summary>
        /// A kind of mental health care assessment or condition. NIEM reference is j:AssignmentAssessmentMentalHealthCareText
        /// </summary>
        /// <value>A kind of mental health care assessment or condition. NIEM reference is j:AssignmentAssessmentMentalHealthCareText</value>

        [DataMember(Name="mentalHealthCare")]
        public List<NcTextType> MentalHealthCare { get; set; }

        /// <summary>
        /// True if special housing is required; false otherwise. NIEM reference is j:AssignmentAssessmentRequiresSpecialHousingIndicator
        /// </summary>
        /// <value>True if special housing is required; false otherwise. NIEM reference is j:AssignmentAssessmentRequiresSpecialHousingIndicator</value>

        [DataMember(Name="isRequiresSpecialHousing")]
        public List<NiemXsboolean> IsRequiresSpecialHousing { get; set; }

        /// <summary>
        /// A description of a risk identified in the assignment assessment. NIEM reference is j:AssignmentAssessmentRiskDescriptionText
        /// </summary>
        /// <value>A description of a risk identified in the assignment assessment. NIEM reference is j:AssignmentAssessmentRiskDescriptionText</value>

        [DataMember(Name="riskDescription")]
        public List<NcTextType> RiskDescription { get; set; }

        /// <summary>
        /// A description of an assignment security level determined thru assignment assessment. NIEM reference is j:AssignmentAssessmentSecurityLevelText
        /// </summary>
        /// <value>A description of an assignment security level determined thru assignment assessment. NIEM reference is j:AssignmentAssessmentSecurityLevelText</value>

        [DataMember(Name="securityLevel")]
        public List<NcTextType> SecurityLevel { get; set; }

        /// <summary>
        /// A comment about a disability program related to an assignment assessment. NIEM reference is j:AssignmentAssessmentDisabilityProgramComment
        /// </summary>
        /// <value>A comment about a disability program related to an assignment assessment. NIEM reference is j:AssignmentAssessmentDisabilityProgramComment</value>

        [DataMember(Name="disabilityProgramComment")]
        public List<NcCommentType> DisabilityProgramComment { get; set; }

        /// <summary>
        /// A type of assignment determined to be required for a subject. NIEM reference is j:AssignmentAssessmentRequiredAssignment
        /// </summary>
        /// <value>A type of assignment determined to be required for a subject. NIEM reference is j:AssignmentAssessmentRequiredAssignment</value>

        [DataMember(Name="requiredAssignment")]
        public List<JAssignmentType> RequiredAssignment { get; set; }

        /// <summary>
        /// A comment related to a subject&#x27;s history of suicide. NIEM reference is j:AssignmentAssessmentPriorSuicideAttemptsComment
        /// </summary>
        /// <value>A comment related to a subject&#x27;s history of suicide. NIEM reference is j:AssignmentAssessmentPriorSuicideAttemptsComment</value>

        [DataMember(Name="priorSuicideAttemptsComment")]
        public List<NcCommentType> PriorSuicideAttemptsComment { get; set; }

        /// <summary>
        /// jAssignmentAssessmentType JSON-LD context
        /// </summary>
        /// <value>jAssignmentAssessmentType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjAssignmentAssessmentTypeContextJsonldEnum for ../JSON-LD_Contexts/jAssignmentAssessmentTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jAssignmentAssessmentTypeContext.jsonld")]
            JSONLDContextsjAssignmentAssessmentTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jAssignmentAssessmentType JSON-LD context
        /// </summary>
        /// <value>jAssignmentAssessmentType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JAssignmentAssessmentType {\n");
            sb.Append("  RequiresSpecialHousingDetails: ").Append(RequiresSpecialHousingDetails).Append("\n");
            sb.Append("  AssignmentRequest: ").Append(AssignmentRequest).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Decision: ").Append(Decision).Append("\n");
            sb.Append("  DevelopmentalDisability: ").Append(DevelopmentalDisability).Append("\n");
            sb.Append("  HealthConditionComment: ").Append(HealthConditionComment).Append("\n");
            sb.Append("  HealthOtherConditionDetails: ").Append(HealthOtherConditionDetails).Append("\n");
            sb.Append("  HealthCondition: ").Append(HealthCondition).Append("\n");
            sb.Append("  MentalHealthCare: ").Append(MentalHealthCare).Append("\n");
            sb.Append("  IsRequiresSpecialHousing: ").Append(IsRequiresSpecialHousing).Append("\n");
            sb.Append("  RiskDescription: ").Append(RiskDescription).Append("\n");
            sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("  DisabilityProgramComment: ").Append(DisabilityProgramComment).Append("\n");
            sb.Append("  RequiredAssignment: ").Append(RequiredAssignment).Append("\n");
            sb.Append("  PriorSuicideAttemptsComment: ").Append(PriorSuicideAttemptsComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JAssignmentAssessmentType)obj);
        }

        /// <summary>
        /// Returns true if JAssignmentAssessmentType instances are equal
        /// </summary>
        /// <param name="other">Instance of JAssignmentAssessmentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JAssignmentAssessmentType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RequiresSpecialHousingDetails == other.RequiresSpecialHousingDetails ||
                    RequiresSpecialHousingDetails != null &&
                    RequiresSpecialHousingDetails.SequenceEqual(other.RequiresSpecialHousingDetails)
                ) && 
                (
                    AssignmentRequest == other.AssignmentRequest ||
                    AssignmentRequest != null &&
                    AssignmentRequest.SequenceEqual(other.AssignmentRequest)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.SequenceEqual(other.Comment)
                ) && 
                (
                    Decision == other.Decision ||
                    Decision != null &&
                    Decision.SequenceEqual(other.Decision)
                ) && 
                (
                    DevelopmentalDisability == other.DevelopmentalDisability ||
                    DevelopmentalDisability != null &&
                    DevelopmentalDisability.SequenceEqual(other.DevelopmentalDisability)
                ) && 
                (
                    HealthConditionComment == other.HealthConditionComment ||
                    HealthConditionComment != null &&
                    HealthConditionComment.SequenceEqual(other.HealthConditionComment)
                ) && 
                (
                    HealthOtherConditionDetails == other.HealthOtherConditionDetails ||
                    HealthOtherConditionDetails != null &&
                    HealthOtherConditionDetails.SequenceEqual(other.HealthOtherConditionDetails)
                ) && 
                (
                    HealthCondition == other.HealthCondition ||
                    HealthCondition != null &&
                    HealthCondition.SequenceEqual(other.HealthCondition)
                ) && 
                (
                    MentalHealthCare == other.MentalHealthCare ||
                    MentalHealthCare != null &&
                    MentalHealthCare.SequenceEqual(other.MentalHealthCare)
                ) && 
                (
                    IsRequiresSpecialHousing == other.IsRequiresSpecialHousing ||
                    IsRequiresSpecialHousing != null &&
                    IsRequiresSpecialHousing.SequenceEqual(other.IsRequiresSpecialHousing)
                ) && 
                (
                    RiskDescription == other.RiskDescription ||
                    RiskDescription != null &&
                    RiskDescription.SequenceEqual(other.RiskDescription)
                ) && 
                (
                    SecurityLevel == other.SecurityLevel ||
                    SecurityLevel != null &&
                    SecurityLevel.SequenceEqual(other.SecurityLevel)
                ) && 
                (
                    DisabilityProgramComment == other.DisabilityProgramComment ||
                    DisabilityProgramComment != null &&
                    DisabilityProgramComment.SequenceEqual(other.DisabilityProgramComment)
                ) && 
                (
                    RequiredAssignment == other.RequiredAssignment ||
                    RequiredAssignment != null &&
                    RequiredAssignment.SequenceEqual(other.RequiredAssignment)
                ) && 
                (
                    PriorSuicideAttemptsComment == other.PriorSuicideAttemptsComment ||
                    PriorSuicideAttemptsComment != null &&
                    PriorSuicideAttemptsComment.SequenceEqual(other.PriorSuicideAttemptsComment)
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
                    if (RequiresSpecialHousingDetails != null)
                    hashCode = hashCode * 59 + RequiresSpecialHousingDetails.GetHashCode();
                    if (AssignmentRequest != null)
                    hashCode = hashCode * 59 + AssignmentRequest.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Decision != null)
                    hashCode = hashCode * 59 + Decision.GetHashCode();
                    if (DevelopmentalDisability != null)
                    hashCode = hashCode * 59 + DevelopmentalDisability.GetHashCode();
                    if (HealthConditionComment != null)
                    hashCode = hashCode * 59 + HealthConditionComment.GetHashCode();
                    if (HealthOtherConditionDetails != null)
                    hashCode = hashCode * 59 + HealthOtherConditionDetails.GetHashCode();
                    if (HealthCondition != null)
                    hashCode = hashCode * 59 + HealthCondition.GetHashCode();
                    if (MentalHealthCare != null)
                    hashCode = hashCode * 59 + MentalHealthCare.GetHashCode();
                    if (IsRequiresSpecialHousing != null)
                    hashCode = hashCode * 59 + IsRequiresSpecialHousing.GetHashCode();
                    if (RiskDescription != null)
                    hashCode = hashCode * 59 + RiskDescription.GetHashCode();
                    if (SecurityLevel != null)
                    hashCode = hashCode * 59 + SecurityLevel.GetHashCode();
                    if (DisabilityProgramComment != null)
                    hashCode = hashCode * 59 + DisabilityProgramComment.GetHashCode();
                    if (RequiredAssignment != null)
                    hashCode = hashCode * 59 + RequiredAssignment.GetHashCode();
                    if (PriorSuicideAttemptsComment != null)
                    hashCode = hashCode * 59 + PriorSuicideAttemptsComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JAssignmentAssessmentType left, JAssignmentAssessmentType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JAssignmentAssessmentType left, JAssignmentAssessmentType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
