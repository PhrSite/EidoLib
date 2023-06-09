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
    /// A data type for an activity of reviewing and assessing a subject&#x27;s medical condition.
    /// </summary>
    [DataContract]
    public partial class JMedicalAssessmentType : NcAssessmentType, IEquatable<JMedicalAssessmentType>
    { 
        /// <summary>
        /// A kind of subject clearance eligibility identified during a medical assessment. NIEM reference is j:MedicalAssessmentClearanceEligibilityText
        /// </summary>
        /// <value>A kind of subject clearance eligibility identified during a medical assessment. NIEM reference is j:MedicalAssessmentClearanceEligibilityText</value>

        [DataMember(Name="clearanceEligibility")]
        public List<NcTextType> ClearanceEligibility { get; set; }

        /// <summary>
        /// A dental priority classification for the subject. NIEM reference is j:MedicalAssessmentClearanceDentalText
        /// </summary>
        /// <value>A dental priority classification for the subject. NIEM reference is j:MedicalAssessmentClearanceDentalText</value>

        [DataMember(Name="clearanceDental")]
        public List<NcTextType> ClearanceDental { get; set; }

        /// <summary>
        /// A comment for each time medicine is dispensed. NIEM reference is j:MedicationUseComment
        /// </summary>
        /// <value>A comment for each time medicine is dispensed. NIEM reference is j:MedicationUseComment</value>

        [DataMember(Name="medicationUseComment")]
        public List<NcCommentType> MedicationUseComment { get; set; }

        /// <summary>
        /// A number indicating the routine usage of a medication by a subject. NIEM reference is j:MedicationUseFrequencyNumeric
        /// </summary>
        /// <value>A number indicating the routine usage of a medication by a subject. NIEM reference is j:MedicationUseFrequencyNumeric</value>

        [DataMember(Name="medicationUseFrequencyNumeric")]
        public List<NcNumericType> MedicationUseFrequencyNumeric { get; set; }

        /// <summary>
        /// A kind of level of care required by a subject. NIEM reference is j:MedicalAssessmentLevelOfCareText
        /// </summary>
        /// <value>A kind of level of care required by a subject. NIEM reference is j:MedicalAssessmentLevelOfCareText</value>

        [DataMember(Name="levelOfCare")]
        public List<NcTextType> LevelOfCare { get; set; }

        /// <summary>
        /// A kind of medical risk for the subject. NIEM reference is j:MedicalAssessmentMedicalRiskText
        /// </summary>
        /// <value>A kind of medical risk for the subject. NIEM reference is j:MedicalAssessmentMedicalRiskText</value>

        [DataMember(Name="medicalRisk")]
        public List<NcTextType> MedicalRisk { get; set; }

        /// <summary>
        /// A kind of required or recommended nursing care level required by the subject. NIEM reference is j:MedicalAssessmentNursingCareLevelText
        /// </summary>
        /// <value>A kind of required or recommended nursing care level required by the subject. NIEM reference is j:MedicalAssessmentNursingCareLevelText</value>

        [DataMember(Name="nursingCareLevel")]
        public List<NcTextType> NursingCareLevel { get; set; }

        /// <summary>
        /// A kind of required specialized medical care required by the subject. NIEM reference is j:MedicalAssessmentSpecializedServiceText
        /// </summary>
        /// <value>A kind of required specialized medical care required by the subject. NIEM reference is j:MedicalAssessmentSpecializedServiceText</value>

        [DataMember(Name="specializedService")]
        public List<NcTextType> SpecializedService { get; set; }

        /// <summary>
        /// A document pertaining to a medical event, incident, evaluation or examination of a subject. NIEM reference is j:MedicalReport
        /// </summary>
        /// <value>A document pertaining to a medical event, incident, evaluation or examination of a subject. NIEM reference is j:MedicalReport</value>

        [DataMember(Name="medicalReport")]
        public List<NcDocumentType> MedicalReport { get; set; }

        /// <summary>
        /// An alert comment specific to a subject with tuberculosis. NIEM reference is j:MedicalAssessmentTuberculosisAlertText
        /// </summary>
        /// <value>An alert comment specific to a subject with tuberculosis. NIEM reference is j:MedicalAssessmentTuberculosisAlertText</value>

        [DataMember(Name="tuberculosisAlert")]
        public List<NcTextType> TuberculosisAlert { get; set; }

        /// <summary>
        /// True if the classification is permanent; false otherwise. NIEM reference is j:MedicalAssessmentPermanentIndicator
        /// </summary>
        /// <value>True if the classification is permanent; false otherwise. NIEM reference is j:MedicalAssessmentPermanentIndicator</value>

        [DataMember(Name="isPermanent")]
        public List<NiemXsboolean> IsPermanent { get; set; }

        /// <summary>
        /// A medication that is required by a subject during medical assessment. NIEM reference is j:MedicalAssessmentRequiredMedication
        /// </summary>
        /// <value>A medication that is required by a subject during medical assessment. NIEM reference is j:MedicalAssessmentRequiredMedication</value>

        [DataMember(Name="requiredMedication")]
        public List<NcDrugType> RequiredMedication { get; set; }

        /// <summary>
        /// An activity involving medical care of a subject. NIEM reference is j:MedicalTreatment
        /// </summary>
        /// <value>An activity involving medical care of a subject. NIEM reference is j:MedicalTreatment</value>

        [DataMember(Name="medicalTreatment")]
        public List<NcTreatmentType> MedicalTreatment { get; set; }

        /// <summary>
        /// True if the subject has restrictions and an urgent follow-up is needed; false otherwise. NIEM reference is j:MedicalAssessmentClearanceRestrictionsUrgentIndicator
        /// </summary>
        /// <value>True if the subject has restrictions and an urgent follow-up is needed; false otherwise. NIEM reference is j:MedicalAssessmentClearanceRestrictionsUrgentIndicator</value>

        [DataMember(Name="isClearanceRestrictionsUrgent")]
        public List<NiemXsboolean> IsClearanceRestrictionsUrgent { get; set; }

        /// <summary>
        /// A date of the last seizure disorder. NIEM reference is j:MedicalAssessmentClearanceSeizureLastDate
        /// </summary>
        /// <value>A date of the last seizure disorder. NIEM reference is j:MedicalAssessmentClearanceSeizureLastDate</value>

        [DataMember(Name="clearanceSeizureLastDate")]
        public List<NcDateType> ClearanceSeizureLastDate { get; set; }

        /// <summary>
        /// A comment about the medical assessment clearance of a corrections subject. NIEM reference is j:MedicalAssessmentClearanceText
        /// </summary>
        /// <value>A comment about the medical assessment clearance of a corrections subject. NIEM reference is j:MedicalAssessmentClearanceText</value>

        [DataMember(Name="clearance")]
        public List<NcTextType> Clearance { get; set; }

        /// <summary>
        /// A comment about the psychiatric medications needed for a subject. NIEM reference is j:MedicalAssessmentComment
        /// </summary>
        /// <value>A comment about the psychiatric medications needed for a subject. NIEM reference is j:MedicalAssessmentComment</value>

        [DataMember(Name="comment")]
        public List<NcCommentType> Comment { get; set; }

        /// <summary>
        /// True if the classification is temporary; false otherwise. NIEM reference is j:MedicalAssessmentTemporaryIndicator
        /// </summary>
        /// <value>True if the classification is temporary; false otherwise. NIEM reference is j:MedicalAssessmentTemporaryIndicator</value>

        [DataMember(Name="isTemporary")]
        public List<NiemXsboolean> IsTemporary { get; set; }

        /// <summary>
        /// A functional capacity of the subject. NIEM reference is j:MedicalAssessmentFunctionalText
        /// </summary>
        /// <value>A functional capacity of the subject. NIEM reference is j:MedicalAssessmentFunctionalText</value>

        [DataMember(Name="functional")]
        public List<NcTextType> Functional { get; set; }

        /// <summary>
        /// A proximity to consultation required for the subject. NIEM reference is j:MedicalAssessmentConsultationText
        /// </summary>
        /// <value>A proximity to consultation required for the subject. NIEM reference is j:MedicalAssessmentConsultationText</value>

        [DataMember(Name="consultation")]
        public List<NcTextType> Consultation { get; set; }

        /// <summary>
        /// A date on which the temporary classification expires. NIEM reference is j:MedicalAssessmentTemporaryAssessmentExpirationDate
        /// </summary>
        /// <value>A date on which the temporary classification expires. NIEM reference is j:MedicalAssessmentTemporaryAssessmentExpirationDate</value>

        [DataMember(Name="temporaryAssessmentExpirationDate")]
        public List<NcDateType> TemporaryAssessmentExpirationDate { get; set; }

        /// <summary>
        /// True if the temporary classification is to be reviewed in six months; false otherwise. NIEM reference is j:MedicalAssessmentTemporaryAssessmentReviewIndicator
        /// </summary>
        /// <value>True if the temporary classification is to be reviewed in six months; false otherwise. NIEM reference is j:MedicalAssessmentTemporaryAssessmentReviewIndicator</value>

        [DataMember(Name="isTemporaryAssessmentReview")]
        public List<NiemXsboolean> IsTemporaryAssessmentReview { get; set; }

        /// <summary>
        /// A pregnancy trimester. NIEM reference is j:MedicalAssessmentClearancePregnantSubjectTrimesterNumeric
        /// </summary>
        /// <value>A pregnancy trimester. NIEM reference is j:MedicalAssessmentClearancePregnantSubjectTrimesterNumeric</value>

        [DataMember(Name="clearancePregnantSubjectTrimesterNumeric")]
        public List<NcNumericType> ClearancePregnantSubjectTrimesterNumeric { get; set; }

        /// <summary>
        /// jMedicalAssessmentType JSON-LD context
        /// </summary>
        /// <value>jMedicalAssessmentType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjMedicalAssessmentTypeContextJsonldEnum for ../JSON-LD_Contexts/jMedicalAssessmentTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jMedicalAssessmentTypeContext.jsonld")]
            JSONLDContextsjMedicalAssessmentTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jMedicalAssessmentType JSON-LD context
        /// </summary>
        /// <value>jMedicalAssessmentType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JMedicalAssessmentType {\n");
            sb.Append("  ClearanceEligibility: ").Append(ClearanceEligibility).Append("\n");
            sb.Append("  ClearanceDental: ").Append(ClearanceDental).Append("\n");
            sb.Append("  MedicationUseComment: ").Append(MedicationUseComment).Append("\n");
            sb.Append("  MedicationUseFrequencyNumeric: ").Append(MedicationUseFrequencyNumeric).Append("\n");
            sb.Append("  LevelOfCare: ").Append(LevelOfCare).Append("\n");
            sb.Append("  MedicalRisk: ").Append(MedicalRisk).Append("\n");
            sb.Append("  NursingCareLevel: ").Append(NursingCareLevel).Append("\n");
            sb.Append("  SpecializedService: ").Append(SpecializedService).Append("\n");
            sb.Append("  MedicalReport: ").Append(MedicalReport).Append("\n");
            sb.Append("  TuberculosisAlert: ").Append(TuberculosisAlert).Append("\n");
            sb.Append("  IsPermanent: ").Append(IsPermanent).Append("\n");
            sb.Append("  RequiredMedication: ").Append(RequiredMedication).Append("\n");
            sb.Append("  MedicalTreatment: ").Append(MedicalTreatment).Append("\n");
            sb.Append("  IsClearanceRestrictionsUrgent: ").Append(IsClearanceRestrictionsUrgent).Append("\n");
            sb.Append("  ClearanceSeizureLastDate: ").Append(ClearanceSeizureLastDate).Append("\n");
            sb.Append("  Clearance: ").Append(Clearance).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  IsTemporary: ").Append(IsTemporary).Append("\n");
            sb.Append("  Functional: ").Append(Functional).Append("\n");
            sb.Append("  Consultation: ").Append(Consultation).Append("\n");
            sb.Append("  TemporaryAssessmentExpirationDate: ").Append(TemporaryAssessmentExpirationDate).Append("\n");
            sb.Append("  IsTemporaryAssessmentReview: ").Append(IsTemporaryAssessmentReview).Append("\n");
            sb.Append("  ClearancePregnantSubjectTrimesterNumeric: ").Append(ClearancePregnantSubjectTrimesterNumeric).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JMedicalAssessmentType)obj);
        }

        /// <summary>
        /// Returns true if JMedicalAssessmentType instances are equal
        /// </summary>
        /// <param name="other">Instance of JMedicalAssessmentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JMedicalAssessmentType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClearanceEligibility == other.ClearanceEligibility ||
                    ClearanceEligibility != null &&
                    ClearanceEligibility.SequenceEqual(other.ClearanceEligibility)
                ) && 
                (
                    ClearanceDental == other.ClearanceDental ||
                    ClearanceDental != null &&
                    ClearanceDental.SequenceEqual(other.ClearanceDental)
                ) && 
                (
                    MedicationUseComment == other.MedicationUseComment ||
                    MedicationUseComment != null &&
                    MedicationUseComment.SequenceEqual(other.MedicationUseComment)
                ) && 
                (
                    MedicationUseFrequencyNumeric == other.MedicationUseFrequencyNumeric ||
                    MedicationUseFrequencyNumeric != null &&
                    MedicationUseFrequencyNumeric.SequenceEqual(other.MedicationUseFrequencyNumeric)
                ) && 
                (
                    LevelOfCare == other.LevelOfCare ||
                    LevelOfCare != null &&
                    LevelOfCare.SequenceEqual(other.LevelOfCare)
                ) && 
                (
                    MedicalRisk == other.MedicalRisk ||
                    MedicalRisk != null &&
                    MedicalRisk.SequenceEqual(other.MedicalRisk)
                ) && 
                (
                    NursingCareLevel == other.NursingCareLevel ||
                    NursingCareLevel != null &&
                    NursingCareLevel.SequenceEqual(other.NursingCareLevel)
                ) && 
                (
                    SpecializedService == other.SpecializedService ||
                    SpecializedService != null &&
                    SpecializedService.SequenceEqual(other.SpecializedService)
                ) && 
                (
                    MedicalReport == other.MedicalReport ||
                    MedicalReport != null &&
                    MedicalReport.SequenceEqual(other.MedicalReport)
                ) && 
                (
                    TuberculosisAlert == other.TuberculosisAlert ||
                    TuberculosisAlert != null &&
                    TuberculosisAlert.SequenceEqual(other.TuberculosisAlert)
                ) && 
                (
                    IsPermanent == other.IsPermanent ||
                    IsPermanent != null &&
                    IsPermanent.SequenceEqual(other.IsPermanent)
                ) && 
                (
                    RequiredMedication == other.RequiredMedication ||
                    RequiredMedication != null &&
                    RequiredMedication.SequenceEqual(other.RequiredMedication)
                ) && 
                (
                    MedicalTreatment == other.MedicalTreatment ||
                    MedicalTreatment != null &&
                    MedicalTreatment.SequenceEqual(other.MedicalTreatment)
                ) && 
                (
                    IsClearanceRestrictionsUrgent == other.IsClearanceRestrictionsUrgent ||
                    IsClearanceRestrictionsUrgent != null &&
                    IsClearanceRestrictionsUrgent.SequenceEqual(other.IsClearanceRestrictionsUrgent)
                ) && 
                (
                    ClearanceSeizureLastDate == other.ClearanceSeizureLastDate ||
                    ClearanceSeizureLastDate != null &&
                    ClearanceSeizureLastDate.SequenceEqual(other.ClearanceSeizureLastDate)
                ) && 
                (
                    Clearance == other.Clearance ||
                    Clearance != null &&
                    Clearance.SequenceEqual(other.Clearance)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.SequenceEqual(other.Comment)
                ) && 
                (
                    IsTemporary == other.IsTemporary ||
                    IsTemporary != null &&
                    IsTemporary.SequenceEqual(other.IsTemporary)
                ) && 
                (
                    Functional == other.Functional ||
                    Functional != null &&
                    Functional.SequenceEqual(other.Functional)
                ) && 
                (
                    Consultation == other.Consultation ||
                    Consultation != null &&
                    Consultation.SequenceEqual(other.Consultation)
                ) && 
                (
                    TemporaryAssessmentExpirationDate == other.TemporaryAssessmentExpirationDate ||
                    TemporaryAssessmentExpirationDate != null &&
                    TemporaryAssessmentExpirationDate.SequenceEqual(other.TemporaryAssessmentExpirationDate)
                ) && 
                (
                    IsTemporaryAssessmentReview == other.IsTemporaryAssessmentReview ||
                    IsTemporaryAssessmentReview != null &&
                    IsTemporaryAssessmentReview.SequenceEqual(other.IsTemporaryAssessmentReview)
                ) && 
                (
                    ClearancePregnantSubjectTrimesterNumeric == other.ClearancePregnantSubjectTrimesterNumeric ||
                    ClearancePregnantSubjectTrimesterNumeric != null &&
                    ClearancePregnantSubjectTrimesterNumeric.SequenceEqual(other.ClearancePregnantSubjectTrimesterNumeric)
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
                    if (ClearanceEligibility != null)
                    hashCode = hashCode * 59 + ClearanceEligibility.GetHashCode();
                    if (ClearanceDental != null)
                    hashCode = hashCode * 59 + ClearanceDental.GetHashCode();
                    if (MedicationUseComment != null)
                    hashCode = hashCode * 59 + MedicationUseComment.GetHashCode();
                    if (MedicationUseFrequencyNumeric != null)
                    hashCode = hashCode * 59 + MedicationUseFrequencyNumeric.GetHashCode();
                    if (LevelOfCare != null)
                    hashCode = hashCode * 59 + LevelOfCare.GetHashCode();
                    if (MedicalRisk != null)
                    hashCode = hashCode * 59 + MedicalRisk.GetHashCode();
                    if (NursingCareLevel != null)
                    hashCode = hashCode * 59 + NursingCareLevel.GetHashCode();
                    if (SpecializedService != null)
                    hashCode = hashCode * 59 + SpecializedService.GetHashCode();
                    if (MedicalReport != null)
                    hashCode = hashCode * 59 + MedicalReport.GetHashCode();
                    if (TuberculosisAlert != null)
                    hashCode = hashCode * 59 + TuberculosisAlert.GetHashCode();
                    if (IsPermanent != null)
                    hashCode = hashCode * 59 + IsPermanent.GetHashCode();
                    if (RequiredMedication != null)
                    hashCode = hashCode * 59 + RequiredMedication.GetHashCode();
                    if (MedicalTreatment != null)
                    hashCode = hashCode * 59 + MedicalTreatment.GetHashCode();
                    if (IsClearanceRestrictionsUrgent != null)
                    hashCode = hashCode * 59 + IsClearanceRestrictionsUrgent.GetHashCode();
                    if (ClearanceSeizureLastDate != null)
                    hashCode = hashCode * 59 + ClearanceSeizureLastDate.GetHashCode();
                    if (Clearance != null)
                    hashCode = hashCode * 59 + Clearance.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (IsTemporary != null)
                    hashCode = hashCode * 59 + IsTemporary.GetHashCode();
                    if (Functional != null)
                    hashCode = hashCode * 59 + Functional.GetHashCode();
                    if (Consultation != null)
                    hashCode = hashCode * 59 + Consultation.GetHashCode();
                    if (TemporaryAssessmentExpirationDate != null)
                    hashCode = hashCode * 59 + TemporaryAssessmentExpirationDate.GetHashCode();
                    if (IsTemporaryAssessmentReview != null)
                    hashCode = hashCode * 59 + IsTemporaryAssessmentReview.GetHashCode();
                    if (ClearancePregnantSubjectTrimesterNumeric != null)
                    hashCode = hashCode * 59 + ClearancePregnantSubjectTrimesterNumeric.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JMedicalAssessmentType left, JMedicalAssessmentType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JMedicalAssessmentType left, JMedicalAssessmentType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
