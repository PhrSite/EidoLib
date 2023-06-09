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
    /// A data type for a sentencing guideline severity level assigned to a charge by a judge or supervising agency.
    /// </summary>
    [DataContract]
    public partial class JSeverityLevelType : IEquatable<JSeverityLevelType>
    { 
        /// <summary>
        /// A date on which the severity level was assigned. NIEM reference is j:SeverityLevelAssignedDate
        /// </summary>
        /// <value>A date on which the severity level was assigned. NIEM reference is j:SeverityLevelAssignedDate</value>

        [DataMember(Name="assignedDate")]
        public List<NcDateType> AssignedDate { get; set; }

        /// <summary>
        /// A higher court judge assigned the severity level to the referenced charge. NIEM reference is j:SeverityLevelAssignedJudge
        /// </summary>
        /// <value>A higher court judge assigned the severity level to the referenced charge. NIEM reference is j:SeverityLevelAssignedJudge</value>

        [DataMember(Name="assignedJudge")]
        public List<JJudicialOfficialType> AssignedJudge { get; set; }

        /// <summary>
        /// A criminal history score that is assigned. NIEM reference is j:SeverityLevelCriminalHistoryScoreText
        /// </summary>
        /// <value>A criminal history score that is assigned. NIEM reference is j:SeverityLevelCriminalHistoryScoreText</value>

        [DataMember(Name="criminalHistoryScore")]
        public List<NcTextType> CriminalHistoryScore { get; set; }

        /// <summary>
        /// A narrative description of a severity level assigned to a charge. NIEM reference is j:SeverityLevelDescriptionText
        /// </summary>
        /// <value>A narrative description of a severity level assigned to a charge. NIEM reference is j:SeverityLevelDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A unique identification of a Severity Level. NIEM reference is j:SeverityLevelIdentification
        /// </summary>
        /// <value>A unique identification of a Severity Level. NIEM reference is j:SeverityLevelIdentification</value>

        [DataMember(Name="identification")]
        public List<NcIdentificationType> Identification { get; set; }

        /// <summary>
        /// A supervising agency that assigned a severity level to a referenced charge. NIEM reference is j:SeverityLevelIssuingAgency
        /// </summary>
        /// <value>A supervising agency that assigned a severity level to a referenced charge. NIEM reference is j:SeverityLevelIssuingAgency</value>

        [DataMember(Name="issuingAgency")]
        public List<NcOrganizationType> IssuingAgency { get; set; }

        /// <summary>
        /// jSeverityLevelType JSON-LD context
        /// </summary>
        /// <value>jSeverityLevelType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjSeverityLevelTypeContextJsonldEnum for ../JSON-LD_Contexts/jSeverityLevelTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jSeverityLevelTypeContext.jsonld")]
            JSONLDContextsjSeverityLevelTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jSeverityLevelType JSON-LD context
        /// </summary>
        /// <value>jSeverityLevelType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JSeverityLevelType {\n");
            sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
            sb.Append("  AssignedJudge: ").Append(AssignedJudge).Append("\n");
            sb.Append("  CriminalHistoryScore: ").Append(CriminalHistoryScore).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  IssuingAgency: ").Append(IssuingAgency).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JSeverityLevelType)obj);
        }

        /// <summary>
        /// Returns true if JSeverityLevelType instances are equal
        /// </summary>
        /// <param name="other">Instance of JSeverityLevelType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSeverityLevelType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssignedDate == other.AssignedDate ||
                    AssignedDate != null &&
                    AssignedDate.SequenceEqual(other.AssignedDate)
                ) && 
                (
                    AssignedJudge == other.AssignedJudge ||
                    AssignedJudge != null &&
                    AssignedJudge.SequenceEqual(other.AssignedJudge)
                ) && 
                (
                    CriminalHistoryScore == other.CriminalHistoryScore ||
                    CriminalHistoryScore != null &&
                    CriminalHistoryScore.SequenceEqual(other.CriminalHistoryScore)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.SequenceEqual(other.Identification)
                ) && 
                (
                    IssuingAgency == other.IssuingAgency ||
                    IssuingAgency != null &&
                    IssuingAgency.SequenceEqual(other.IssuingAgency)
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
                    if (AssignedDate != null)
                    hashCode = hashCode * 59 + AssignedDate.GetHashCode();
                    if (AssignedJudge != null)
                    hashCode = hashCode * 59 + AssignedJudge.GetHashCode();
                    if (CriminalHistoryScore != null)
                    hashCode = hashCode * 59 + CriminalHistoryScore.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                    if (IssuingAgency != null)
                    hashCode = hashCode * 59 + IssuingAgency.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JSeverityLevelType left, JSeverityLevelType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JSeverityLevelType left, JSeverityLevelType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
