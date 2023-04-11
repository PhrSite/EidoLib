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
    /// A data type for an assessment process to determine a subject&#x27;s past drug use and/or dependency.
    /// </summary>
    [DataContract]
    public partial class JDrugUseAssessmentType : NcAssessmentType, IEquatable<JDrugUseAssessmentType>
    { 
        /// <summary>
        /// A kind of values for secondary drug of choice. NIEM reference is j:DrugUseAssessmentSecondaryDrugOfChoiceText
        /// </summary>
        /// <value>A kind of values for secondary drug of choice. NIEM reference is j:DrugUseAssessmentSecondaryDrugOfChoiceText</value>

        [DataMember(Name="secondaryDrugOfChoice")]
        public List<NcTextType> SecondaryDrugOfChoice { get; set; }

        /// <summary>
        /// A number of drug treatment programs attended by the subject while incarcerated. NIEM reference is j:DrugUseAssessmentInPrisonDrugTreatmentProgramsAttendedQuantity
        /// </summary>
        /// <value>A number of drug treatment programs attended by the subject while incarcerated. NIEM reference is j:DrugUseAssessmentInPrisonDrugTreatmentProgramsAttendedQuantity</value>

        [DataMember(Name="inPrisonDrugTreatmentProgramsAttendedQuantity")]
        public List<NcQuantityType> InPrisonDrugTreatmentProgramsAttendedQuantity { get; set; }

        /// <summary>
        /// A count for an age when an individual first used drugs. NIEM reference is j:DrugUseAssessmentFirstUsedAgeQuantity
        /// </summary>
        /// <value>A count for an age when an individual first used drugs. NIEM reference is j:DrugUseAssessmentFirstUsedAgeQuantity</value>

        [DataMember(Name="firstUsedAgeQuantity")]
        public List<NcQuantityType> FirstUsedAgeQuantity { get; set; }

        /// <summary>
        /// A drug test used as part of an assessment. NIEM reference is j:DrugUseAssessmentDrugTest
        /// </summary>
        /// <value>A drug test used as part of an assessment. NIEM reference is j:DrugUseAssessmentDrugTest</value>

        [DataMember(Name="drugTest")]
        public List<JDrugTestType> DrugTest { get; set; }

        /// <summary>
        /// True if the subject of assessment has a drug dependency; false otherwise. NIEM reference is j:DrugUseAssessmentDrugDependencyIndicator
        /// </summary>
        /// <value>True if the subject of assessment has a drug dependency; false otherwise. NIEM reference is j:DrugUseAssessmentDrugDependencyIndicator</value>

        [DataMember(Name="isDrugDependency")]
        public List<NiemXsboolean> IsDrugDependency { get; set; }

        /// <summary>
        /// A number of drug treatment programs attended by the subject. NIEM reference is j:DrugUseAssessmentDrugTreatmentProgramsAttendedQuantity
        /// </summary>
        /// <value>A number of drug treatment programs attended by the subject. NIEM reference is j:DrugUseAssessmentDrugTreatmentProgramsAttendedQuantity</value>

        [DataMember(Name="drugTreatmentProgramsAttendedQuantity")]
        public List<NcQuantityType> DrugTreatmentProgramsAttendedQuantity { get; set; }

        /// <summary>
        /// A kind of values for drugs that have been used by the subject in the past. NIEM reference is j:DrugUseAssessmentPrimaryDrugOfChoiceText
        /// </summary>
        /// <value>A kind of values for drugs that have been used by the subject in the past. NIEM reference is j:DrugUseAssessmentPrimaryDrugOfChoiceText</value>

        [DataMember(Name="primaryDrugOfChoice")]
        public List<NcTextType> PrimaryDrugOfChoice { get; set; }

        /// <summary>
        /// True if subject reported use of needles; false otherwise. NIEM reference is j:DrugUseAssessmentUsedNeedleIndicator
        /// </summary>
        /// <value>True if subject reported use of needles; false otherwise. NIEM reference is j:DrugUseAssessmentUsedNeedleIndicator</value>

        [DataMember(Name="isUsedNeedle")]
        public List<NiemXsboolean> IsUsedNeedle { get; set; }

        /// <summary>
        /// A number indicating the years the subject has had drug-related problems. NIEM reference is j:DrugUseAssessmentYearsOfProblemUseQuantity
        /// </summary>
        /// <value>A number indicating the years the subject has had drug-related problems. NIEM reference is j:DrugUseAssessmentYearsOfProblemUseQuantity</value>

        [DataMember(Name="yearsOfProblemUseQuantity")]
        public List<NcQuantityType> YearsOfProblemUseQuantity { get; set; }

        /// <summary>
        /// A type of drug. NIEM reference is j:DrugUseDrug
        /// </summary>
        /// <value>A type of drug. NIEM reference is j:DrugUseDrug</value>

        [DataMember(Name="drugUseDrug")]
        public List<NcDrugType> DrugUseDrug { get; set; }

        /// <summary>
        /// A number of consecutive months an offender was determined to be free of narcotics. NIEM reference is j:DrugUseAssessmentDrugFreeDuration
        /// </summary>
        /// <value>A number of consecutive months an offender was determined to be free of narcotics. NIEM reference is j:DrugUseAssessmentDrugFreeDuration</value>

        [DataMember(Name="drugFreeDuration")]
        public List<NiemXsduration> DrugFreeDuration { get; set; }

        /// <summary>
        /// A date of the assessment subject&#x27;s last drug test. NIEM reference is j:DrugUseAssessmentLastDrugTestDate
        /// </summary>
        /// <value>A date of the assessment subject&#x27;s last drug test. NIEM reference is j:DrugUseAssessmentLastDrugTestDate</value>

        [DataMember(Name="lastDrugTestDate")]
        public List<NcDateType> LastDrugTestDate { get; set; }

        /// <summary>
        /// A relapse trigger that could lead the subject to use drugs. NIEM reference is j:DrugUseAssessmentRelapseTriggerText
        /// </summary>
        /// <value>A relapse trigger that could lead the subject to use drugs. NIEM reference is j:DrugUseAssessmentRelapseTriggerText</value>

        [DataMember(Name="relapseTrigger")]
        public List<NcTextType> RelapseTrigger { get; set; }

        /// <summary>
        /// jDrugUseAssessmentType JSON-LD context
        /// </summary>
        /// <value>jDrugUseAssessmentType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjDrugUseAssessmentTypeContextJsonldEnum for ../JSON-LD_Contexts/jDrugUseAssessmentTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jDrugUseAssessmentTypeContext.jsonld")]
            JSONLDContextsjDrugUseAssessmentTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jDrugUseAssessmentType JSON-LD context
        /// </summary>
        /// <value>jDrugUseAssessmentType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JDrugUseAssessmentType {\n");
            sb.Append("  SecondaryDrugOfChoice: ").Append(SecondaryDrugOfChoice).Append("\n");
            sb.Append("  InPrisonDrugTreatmentProgramsAttendedQuantity: ").Append(InPrisonDrugTreatmentProgramsAttendedQuantity).Append("\n");
            sb.Append("  FirstUsedAgeQuantity: ").Append(FirstUsedAgeQuantity).Append("\n");
            sb.Append("  DrugTest: ").Append(DrugTest).Append("\n");
            sb.Append("  IsDrugDependency: ").Append(IsDrugDependency).Append("\n");
            sb.Append("  DrugTreatmentProgramsAttendedQuantity: ").Append(DrugTreatmentProgramsAttendedQuantity).Append("\n");
            sb.Append("  PrimaryDrugOfChoice: ").Append(PrimaryDrugOfChoice).Append("\n");
            sb.Append("  IsUsedNeedle: ").Append(IsUsedNeedle).Append("\n");
            sb.Append("  YearsOfProblemUseQuantity: ").Append(YearsOfProblemUseQuantity).Append("\n");
            sb.Append("  DrugUseDrug: ").Append(DrugUseDrug).Append("\n");
            sb.Append("  DrugFreeDuration: ").Append(DrugFreeDuration).Append("\n");
            sb.Append("  LastDrugTestDate: ").Append(LastDrugTestDate).Append("\n");
            sb.Append("  RelapseTrigger: ").Append(RelapseTrigger).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JDrugUseAssessmentType)obj);
        }

        /// <summary>
        /// Returns true if JDrugUseAssessmentType instances are equal
        /// </summary>
        /// <param name="other">Instance of JDrugUseAssessmentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JDrugUseAssessmentType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SecondaryDrugOfChoice == other.SecondaryDrugOfChoice ||
                    SecondaryDrugOfChoice != null &&
                    SecondaryDrugOfChoice.SequenceEqual(other.SecondaryDrugOfChoice)
                ) && 
                (
                    InPrisonDrugTreatmentProgramsAttendedQuantity == other.InPrisonDrugTreatmentProgramsAttendedQuantity ||
                    InPrisonDrugTreatmentProgramsAttendedQuantity != null &&
                    InPrisonDrugTreatmentProgramsAttendedQuantity.SequenceEqual(other.InPrisonDrugTreatmentProgramsAttendedQuantity)
                ) && 
                (
                    FirstUsedAgeQuantity == other.FirstUsedAgeQuantity ||
                    FirstUsedAgeQuantity != null &&
                    FirstUsedAgeQuantity.SequenceEqual(other.FirstUsedAgeQuantity)
                ) && 
                (
                    DrugTest == other.DrugTest ||
                    DrugTest != null &&
                    DrugTest.SequenceEqual(other.DrugTest)
                ) && 
                (
                    IsDrugDependency == other.IsDrugDependency ||
                    IsDrugDependency != null &&
                    IsDrugDependency.SequenceEqual(other.IsDrugDependency)
                ) && 
                (
                    DrugTreatmentProgramsAttendedQuantity == other.DrugTreatmentProgramsAttendedQuantity ||
                    DrugTreatmentProgramsAttendedQuantity != null &&
                    DrugTreatmentProgramsAttendedQuantity.SequenceEqual(other.DrugTreatmentProgramsAttendedQuantity)
                ) && 
                (
                    PrimaryDrugOfChoice == other.PrimaryDrugOfChoice ||
                    PrimaryDrugOfChoice != null &&
                    PrimaryDrugOfChoice.SequenceEqual(other.PrimaryDrugOfChoice)
                ) && 
                (
                    IsUsedNeedle == other.IsUsedNeedle ||
                    IsUsedNeedle != null &&
                    IsUsedNeedle.SequenceEqual(other.IsUsedNeedle)
                ) && 
                (
                    YearsOfProblemUseQuantity == other.YearsOfProblemUseQuantity ||
                    YearsOfProblemUseQuantity != null &&
                    YearsOfProblemUseQuantity.SequenceEqual(other.YearsOfProblemUseQuantity)
                ) && 
                (
                    DrugUseDrug == other.DrugUseDrug ||
                    DrugUseDrug != null &&
                    DrugUseDrug.SequenceEqual(other.DrugUseDrug)
                ) && 
                (
                    DrugFreeDuration == other.DrugFreeDuration ||
                    DrugFreeDuration != null &&
                    DrugFreeDuration.SequenceEqual(other.DrugFreeDuration)
                ) && 
                (
                    LastDrugTestDate == other.LastDrugTestDate ||
                    LastDrugTestDate != null &&
                    LastDrugTestDate.SequenceEqual(other.LastDrugTestDate)
                ) && 
                (
                    RelapseTrigger == other.RelapseTrigger ||
                    RelapseTrigger != null &&
                    RelapseTrigger.SequenceEqual(other.RelapseTrigger)
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
                    if (SecondaryDrugOfChoice != null)
                    hashCode = hashCode * 59 + SecondaryDrugOfChoice.GetHashCode();
                    if (InPrisonDrugTreatmentProgramsAttendedQuantity != null)
                    hashCode = hashCode * 59 + InPrisonDrugTreatmentProgramsAttendedQuantity.GetHashCode();
                    if (FirstUsedAgeQuantity != null)
                    hashCode = hashCode * 59 + FirstUsedAgeQuantity.GetHashCode();
                    if (DrugTest != null)
                    hashCode = hashCode * 59 + DrugTest.GetHashCode();
                    if (IsDrugDependency != null)
                    hashCode = hashCode * 59 + IsDrugDependency.GetHashCode();
                    if (DrugTreatmentProgramsAttendedQuantity != null)
                    hashCode = hashCode * 59 + DrugTreatmentProgramsAttendedQuantity.GetHashCode();
                    if (PrimaryDrugOfChoice != null)
                    hashCode = hashCode * 59 + PrimaryDrugOfChoice.GetHashCode();
                    if (IsUsedNeedle != null)
                    hashCode = hashCode * 59 + IsUsedNeedle.GetHashCode();
                    if (YearsOfProblemUseQuantity != null)
                    hashCode = hashCode * 59 + YearsOfProblemUseQuantity.GetHashCode();
                    if (DrugUseDrug != null)
                    hashCode = hashCode * 59 + DrugUseDrug.GetHashCode();
                    if (DrugFreeDuration != null)
                    hashCode = hashCode * 59 + DrugFreeDuration.GetHashCode();
                    if (LastDrugTestDate != null)
                    hashCode = hashCode * 59 + LastDrugTestDate.GetHashCode();
                    if (RelapseTrigger != null)
                    hashCode = hashCode * 59 + RelapseTrigger.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JDrugUseAssessmentType left, JDrugUseAssessmentType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JDrugUseAssessmentType left, JDrugUseAssessmentType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
