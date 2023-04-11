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
    /// A data type for an activity relating to the supervision of a subject based on specific conditions placed upon a subject as imposed by a court or supervising agency.
    /// </summary>
    [DataContract]
    public partial class JSupervisedReleaseType : NcSupervisionType, IEquatable<JSupervisedReleaseType>
    { 
        /// <summary>
        /// A date on which supervised release is projected to end. NIEM reference is j:SupervisedReleaseProjectedEndDate
        /// </summary>
        /// <value>A date on which supervised release is projected to end. NIEM reference is j:SupervisedReleaseProjectedEndDate</value>

        [DataMember(Name="projectedEndDate")]
        public List<NcDateType> ProjectedEndDate { get; set; }

        /// <summary>
        /// True if electronic monitoring is being used on a subject; false otherwise. NIEM reference is j:SupervisedReleaseElectronicMonitoringIndicator
        /// </summary>
        /// <value>True if electronic monitoring is being used on a subject; false otherwise. NIEM reference is j:SupervisedReleaseElectronicMonitoringIndicator</value>

        [DataMember(Name="isElectronicMonitoring")]
        public List<NiemXsboolean> IsElectronicMonitoring { get; set; }

        /// <summary>
        /// A reason for which supervised release was revoked. NIEM reference is j:SupervisedReleaseRevocationReasonText
        /// </summary>
        /// <value>A reason for which supervised release was revoked. NIEM reference is j:SupervisedReleaseRevocationReasonText</value>

        [DataMember(Name="revocationReason")]
        public List<NcTextType> RevocationReason { get; set; }

        /// <summary>
        /// A comment or narrative provided by the supervising official. NIEM reference is j:SupervisedReleaseSupervisingOfficialNarrative
        /// </summary>
        /// <value>A comment or narrative provided by the supervising official. NIEM reference is j:SupervisedReleaseSupervisingOfficialNarrative</value>

        [DataMember(Name="supervisingOfficialNarrative")]
        public List<NcCommentType> SupervisingOfficialNarrative { get; set; }

        /// <summary>
        /// A kind of supervised release. NIEM reference is j:SupervisedReleaseCategoryText
        /// </summary>
        /// <value>A kind of supervised release. NIEM reference is j:SupervisedReleaseCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A date that the supervised release was revoked. NIEM reference is j:SupervisedReleaseRevocationDate
        /// </summary>
        /// <value>A date that the supervised release was revoked. NIEM reference is j:SupervisedReleaseRevocationDate</value>

        [DataMember(Name="revocationDate")]
        public List<NcDateType> RevocationDate { get; set; }

        /// <summary>
        /// True if a subject is presently being supervised by agencies in addition to agency providing the report; false otherwise. NIEM reference is j:SupervisedReleaseMultipleJurisdictionIndicator
        /// </summary>
        /// <value>True if a subject is presently being supervised by agencies in addition to agency providing the report; false otherwise. NIEM reference is j:SupervisedReleaseMultipleJurisdictionIndicator</value>

        [DataMember(Name="isMultipleJurisdiction")]
        public List<NiemXsboolean> IsMultipleJurisdiction { get; set; }

        /// <summary>
        /// A kind of supervised release. NIEM reference is j:SupervisedReleaseCategoryCode
        /// </summary>
        /// <value>A kind of supervised release. NIEM reference is j:SupervisedReleaseCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<NdexSupervisedReleaseCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// A Parole Unit that will supervise the subject on release. NIEM reference is j:SupervisedReleaseParoleUnitText
        /// </summary>
        /// <value>A Parole Unit that will supervise the subject on release. NIEM reference is j:SupervisedReleaseParoleUnitText</value>

        [DataMember(Name="paroleUnit")]
        public List<NcTextType> ParoleUnit { get; set; }

        /// <summary>
        /// jSupervisedReleaseType JSON-LD context
        /// </summary>
        /// <value>jSupervisedReleaseType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjSupervisedReleaseTypeContextJsonldEnum for ../JSON-LD_Contexts/jSupervisedReleaseTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jSupervisedReleaseTypeContext.jsonld")]
            JSONLDContextsjSupervisedReleaseTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jSupervisedReleaseType JSON-LD context
        /// </summary>
        /// <value>jSupervisedReleaseType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JSupervisedReleaseType {\n");
            sb.Append("  ProjectedEndDate: ").Append(ProjectedEndDate).Append("\n");
            sb.Append("  IsElectronicMonitoring: ").Append(IsElectronicMonitoring).Append("\n");
            sb.Append("  RevocationReason: ").Append(RevocationReason).Append("\n");
            sb.Append("  SupervisingOfficialNarrative: ").Append(SupervisingOfficialNarrative).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  RevocationDate: ").Append(RevocationDate).Append("\n");
            sb.Append("  IsMultipleJurisdiction: ").Append(IsMultipleJurisdiction).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  ParoleUnit: ").Append(ParoleUnit).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JSupervisedReleaseType)obj);
        }

        /// <summary>
        /// Returns true if JSupervisedReleaseType instances are equal
        /// </summary>
        /// <param name="other">Instance of JSupervisedReleaseType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSupervisedReleaseType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProjectedEndDate == other.ProjectedEndDate ||
                    ProjectedEndDate != null &&
                    ProjectedEndDate.SequenceEqual(other.ProjectedEndDate)
                ) && 
                (
                    IsElectronicMonitoring == other.IsElectronicMonitoring ||
                    IsElectronicMonitoring != null &&
                    IsElectronicMonitoring.SequenceEqual(other.IsElectronicMonitoring)
                ) && 
                (
                    RevocationReason == other.RevocationReason ||
                    RevocationReason != null &&
                    RevocationReason.SequenceEqual(other.RevocationReason)
                ) && 
                (
                    SupervisingOfficialNarrative == other.SupervisingOfficialNarrative ||
                    SupervisingOfficialNarrative != null &&
                    SupervisingOfficialNarrative.SequenceEqual(other.SupervisingOfficialNarrative)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    RevocationDate == other.RevocationDate ||
                    RevocationDate != null &&
                    RevocationDate.SequenceEqual(other.RevocationDate)
                ) && 
                (
                    IsMultipleJurisdiction == other.IsMultipleJurisdiction ||
                    IsMultipleJurisdiction != null &&
                    IsMultipleJurisdiction.SequenceEqual(other.IsMultipleJurisdiction)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    ParoleUnit == other.ParoleUnit ||
                    ParoleUnit != null &&
                    ParoleUnit.SequenceEqual(other.ParoleUnit)
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
                    if (ProjectedEndDate != null)
                    hashCode = hashCode * 59 + ProjectedEndDate.GetHashCode();
                    if (IsElectronicMonitoring != null)
                    hashCode = hashCode * 59 + IsElectronicMonitoring.GetHashCode();
                    if (RevocationReason != null)
                    hashCode = hashCode * 59 + RevocationReason.GetHashCode();
                    if (SupervisingOfficialNarrative != null)
                    hashCode = hashCode * 59 + SupervisingOfficialNarrative.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (RevocationDate != null)
                    hashCode = hashCode * 59 + RevocationDate.GetHashCode();
                    if (IsMultipleJurisdiction != null)
                    hashCode = hashCode * 59 + IsMultipleJurisdiction.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (ParoleUnit != null)
                    hashCode = hashCode * 59 + ParoleUnit.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JSupervisedReleaseType left, JSupervisedReleaseType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JSupervisedReleaseType left, JSupervisedReleaseType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}