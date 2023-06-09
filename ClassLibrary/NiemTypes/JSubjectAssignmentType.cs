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
    /// A data type for an event or activity involving the assignment of a corrections subject.
    /// </summary>
    [DataContract]
    public partial class JSubjectAssignmentType : JAssignmentType, IEquatable<JSubjectAssignmentType>
    { 
        /// <summary>
        /// A comment indicating a temporary status for a single cell request for a subject. NIEM reference is j:SubjectAssignmentSingleCellRequestsTemporaryStatusText
        /// </summary>
        /// <value>A comment indicating a temporary status for a single cell request for a subject. NIEM reference is j:SubjectAssignmentSingleCellRequestsTemporaryStatusText</value>

        [DataMember(Name="singleCellRequestsTemporaryStatus")]
        public List<NcTextType> SingleCellRequestsTemporaryStatus { get; set; }

        /// <summary>
        /// A program that exists as part of a rehabilitation program and constitutes a significant scope of work most often defined as evidence-based, such as: Substance Abuse Training, Education, etc. NIEM reference is j:ServiceDeliveryProgram
        /// </summary>
        /// <value>A program that exists as part of a rehabilitation program and constitutes a significant scope of work most often defined as evidence-based, such as: Substance Abuse Training, Education, etc. NIEM reference is j:ServiceDeliveryProgram</value>

        [DataMember(Name="serviceDeliveryProgram")]
        public List<NcProgramType> ServiceDeliveryProgram { get; set; }

        /// <summary>
        /// A kind of assignment. NIEM reference is j:SubjectAssignmentCategoryCode
        /// </summary>
        /// <value>A kind of assignment. NIEM reference is j:SubjectAssignmentCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<NdexAssignmentCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// A kind of assignment. NIEM reference is j:SubjectAssignmentCategoryText
        /// </summary>
        /// <value>A kind of assignment. NIEM reference is j:SubjectAssignmentCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A set of details describing activities and infractions of a subject in a program. NIEM reference is j:ProgramViolation
        /// </summary>
        /// <value>A set of details describing activities and infractions of a subject in a program. NIEM reference is j:ProgramViolation</value>

        [DataMember(Name="programViolation")]
        public List<JOffenseType> ProgramViolation { get; set; }

        /// <summary>
        /// A comment indicating the reason for approving a subject&#x27;s single cell assignment. NIEM reference is j:SubjectAssignmentSingleCellApprovalReasonText
        /// </summary>
        /// <value>A comment indicating the reason for approving a subject&#x27;s single cell assignment. NIEM reference is j:SubjectAssignmentSingleCellApprovalReasonText</value>

        [DataMember(Name="singleCellApprovalReason")]
        public List<NcTextType> SingleCellApprovalReason { get; set; }

        /// <summary>
        /// A document detailing the assessment and assignment of a subject. NIEM reference is j:SubjectAssignmentDocument
        /// </summary>
        /// <value>A document detailing the assessment and assignment of a subject. NIEM reference is j:SubjectAssignmentDocument</value>

        [DataMember(Name="document")]
        public List<NcDocumentType> Document { get; set; }

        /// <summary>
        /// A date that a subject&#x27;s placement was approved. NIEM reference is j:SubjectAssignmentApprovalDate
        /// </summary>
        /// <value>A date that a subject&#x27;s placement was approved. NIEM reference is j:SubjectAssignmentApprovalDate</value>

        [DataMember(Name="approvalDate")]
        public List<NcDateType> ApprovalDate { get; set; }

        /// <summary>
        /// A staff member who approves a subject&#x27;s assignment. NIEM reference is j:SubjectAssignmentApprover
        /// </summary>
        /// <value>A staff member who approves a subject&#x27;s assignment. NIEM reference is j:SubjectAssignmentApprover</value>

        [DataMember(Name="approver")]
        public List<NcEntityType> Approver { get; set; }

        /// <summary>
        /// A comment indicating the reason(s) for segregation assignment of a subject. NIEM reference is j:SubjectAssignmentSegregationReasonText
        /// </summary>
        /// <value>A comment indicating the reason(s) for segregation assignment of a subject. NIEM reference is j:SubjectAssignmentSegregationReasonText</value>

        [DataMember(Name="segregationReason")]
        public List<NcTextType> SegregationReason { get; set; }

        /// <summary>
        /// A comment regarding the current condition of the approval of a subject&#x27;s single cell assignment. NIEM reference is j:SubjectAssignmentSingleCellApprovalStatusText
        /// </summary>
        /// <value>A comment regarding the current condition of the approval of a subject&#x27;s single cell assignment. NIEM reference is j:SubjectAssignmentSingleCellApprovalStatusText</value>

        [DataMember(Name="singleCellApprovalStatus")]
        public List<NcTextType> SingleCellApprovalStatus { get; set; }

        /// <summary>
        /// jSubjectAssignmentType JSON-LD context
        /// </summary>
        /// <value>jSubjectAssignmentType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjSubjectAssignmentTypeContextJsonldEnum for ../JSON-LD_Contexts/jSubjectAssignmentTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jSubjectAssignmentTypeContext.jsonld")]
            JSONLDContextsjSubjectAssignmentTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jSubjectAssignmentType JSON-LD context
        /// </summary>
        /// <value>jSubjectAssignmentType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JSubjectAssignmentType {\n");
            sb.Append("  SingleCellRequestsTemporaryStatus: ").Append(SingleCellRequestsTemporaryStatus).Append("\n");
            sb.Append("  ServiceDeliveryProgram: ").Append(ServiceDeliveryProgram).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ProgramViolation: ").Append(ProgramViolation).Append("\n");
            sb.Append("  SingleCellApprovalReason: ").Append(SingleCellApprovalReason).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  ApprovalDate: ").Append(ApprovalDate).Append("\n");
            sb.Append("  Approver: ").Append(Approver).Append("\n");
            sb.Append("  SegregationReason: ").Append(SegregationReason).Append("\n");
            sb.Append("  SingleCellApprovalStatus: ").Append(SingleCellApprovalStatus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JSubjectAssignmentType)obj);
        }

        /// <summary>
        /// Returns true if JSubjectAssignmentType instances are equal
        /// </summary>
        /// <param name="other">Instance of JSubjectAssignmentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSubjectAssignmentType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SingleCellRequestsTemporaryStatus == other.SingleCellRequestsTemporaryStatus ||
                    SingleCellRequestsTemporaryStatus != null &&
                    SingleCellRequestsTemporaryStatus.SequenceEqual(other.SingleCellRequestsTemporaryStatus)
                ) && 
                (
                    ServiceDeliveryProgram == other.ServiceDeliveryProgram ||
                    ServiceDeliveryProgram != null &&
                    ServiceDeliveryProgram.SequenceEqual(other.ServiceDeliveryProgram)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    ProgramViolation == other.ProgramViolation ||
                    ProgramViolation != null &&
                    ProgramViolation.SequenceEqual(other.ProgramViolation)
                ) && 
                (
                    SingleCellApprovalReason == other.SingleCellApprovalReason ||
                    SingleCellApprovalReason != null &&
                    SingleCellApprovalReason.SequenceEqual(other.SingleCellApprovalReason)
                ) && 
                (
                    Document == other.Document ||
                    Document != null &&
                    Document.SequenceEqual(other.Document)
                ) && 
                (
                    ApprovalDate == other.ApprovalDate ||
                    ApprovalDate != null &&
                    ApprovalDate.SequenceEqual(other.ApprovalDate)
                ) && 
                (
                    Approver == other.Approver ||
                    Approver != null &&
                    Approver.SequenceEqual(other.Approver)
                ) && 
                (
                    SegregationReason == other.SegregationReason ||
                    SegregationReason != null &&
                    SegregationReason.SequenceEqual(other.SegregationReason)
                ) && 
                (
                    SingleCellApprovalStatus == other.SingleCellApprovalStatus ||
                    SingleCellApprovalStatus != null &&
                    SingleCellApprovalStatus.SequenceEqual(other.SingleCellApprovalStatus)
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
                    if (SingleCellRequestsTemporaryStatus != null)
                    hashCode = hashCode * 59 + SingleCellRequestsTemporaryStatus.GetHashCode();
                    if (ServiceDeliveryProgram != null)
                    hashCode = hashCode * 59 + ServiceDeliveryProgram.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (ProgramViolation != null)
                    hashCode = hashCode * 59 + ProgramViolation.GetHashCode();
                    if (SingleCellApprovalReason != null)
                    hashCode = hashCode * 59 + SingleCellApprovalReason.GetHashCode();
                    if (Document != null)
                    hashCode = hashCode * 59 + Document.GetHashCode();
                    if (ApprovalDate != null)
                    hashCode = hashCode * 59 + ApprovalDate.GetHashCode();
                    if (Approver != null)
                    hashCode = hashCode * 59 + Approver.GetHashCode();
                    if (SegregationReason != null)
                    hashCode = hashCode * 59 + SegregationReason.GetHashCode();
                    if (SingleCellApprovalStatus != null)
                    hashCode = hashCode * 59 + SingleCellApprovalStatus.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JSubjectAssignmentType left, JSubjectAssignmentType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JSubjectAssignmentType left, JSubjectAssignmentType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
