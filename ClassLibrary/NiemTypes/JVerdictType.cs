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
    /// A data type for a finding related to a charge.
    /// </summary>
    [DataContract]
    public partial class JVerdictType : NcActivityType, IEquatable<JVerdictType>
    { 
        /// <summary>
        /// A date a verdict was given. NIEM reference is j:VerdictDate
        /// </summary>
        /// <value>A date a verdict was given. NIEM reference is j:VerdictDate</value>

        [DataMember(Name="date")]
        public List<NcDateType> Date { get; set; }

        /// <summary>
        /// A description of a verdict. NIEM reference is j:VerdictDescriptionText
        /// </summary>
        /// <value>A description of a verdict. NIEM reference is j:VerdictDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A date of a verdict disposition. NIEM reference is j:VerdictDispositionDate
        /// </summary>
        /// <value>A date of a verdict disposition. NIEM reference is j:VerdictDispositionDate</value>

        [DataMember(Name="dispositionDate")]
        public List<NcDateType> DispositionDate { get; set; }

        /// <summary>
        /// A name of a disposition of a verdict. NIEM reference is j:VerdictDispositionName
        /// </summary>
        /// <value>A name of a disposition of a verdict. NIEM reference is j:VerdictDispositionName</value>

        [DataMember(Name="dispositionName")]
        public List<NcTextType> DispositionName { get; set; }

        /// <summary>
        /// A court which issued a verdict. NIEM reference is j:VerdictIssuingCourt
        /// </summary>
        /// <value>A court which issued a verdict. NIEM reference is j:VerdictIssuingCourt</value>

        [DataMember(Name="issuingCourt")]
        public List<JCourtType> IssuingCourt { get; set; }

        /// <summary>
        /// A judge which issued a verdict. NIEM reference is j:VerdictIssuingJudge
        /// </summary>
        /// <value>A judge which issued a verdict. NIEM reference is j:VerdictIssuingJudge</value>

        [DataMember(Name="issuingJudge")]
        public List<JJudicialOfficialType> IssuingJudge { get; set; }

        /// <summary>
        /// True if a verdict was issued by a judge or a jury; false otherwise. NIEM reference is j:VerdictIssuingJudgeIndicator
        /// </summary>
        /// <value>True if a verdict was issued by a judge or a jury; false otherwise. NIEM reference is j:VerdictIssuingJudgeIndicator</value>

        [DataMember(Name="isIssuingJudge")]
        public List<NiemXsboolean> IsIssuingJudge { get; set; }

        /// <summary>
        /// A person who received a verdict. NIEM reference is j:VerdictSubject
        /// </summary>
        /// <value>A person who received a verdict. NIEM reference is j:VerdictSubject</value>

        [DataMember(Name="subject")]
        public List<JSubjectType> Subject { get; set; }

        /// <summary>
        /// jVerdictType JSON-LD context
        /// </summary>
        /// <value>jVerdictType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjVerdictTypeContextJsonldEnum for ../JSON-LD_Contexts/jVerdictTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jVerdictTypeContext.jsonld")]
            JSONLDContextsjVerdictTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jVerdictType JSON-LD context
        /// </summary>
        /// <value>jVerdictType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JVerdictType {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DispositionDate: ").Append(DispositionDate).Append("\n");
            sb.Append("  DispositionName: ").Append(DispositionName).Append("\n");
            sb.Append("  IssuingCourt: ").Append(IssuingCourt).Append("\n");
            sb.Append("  IssuingJudge: ").Append(IssuingJudge).Append("\n");
            sb.Append("  IsIssuingJudge: ").Append(IsIssuingJudge).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JVerdictType)obj);
        }

        /// <summary>
        /// Returns true if JVerdictType instances are equal
        /// </summary>
        /// <param name="other">Instance of JVerdictType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JVerdictType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.SequenceEqual(other.Date)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    DispositionDate == other.DispositionDate ||
                    DispositionDate != null &&
                    DispositionDate.SequenceEqual(other.DispositionDate)
                ) && 
                (
                    DispositionName == other.DispositionName ||
                    DispositionName != null &&
                    DispositionName.SequenceEqual(other.DispositionName)
                ) && 
                (
                    IssuingCourt == other.IssuingCourt ||
                    IssuingCourt != null &&
                    IssuingCourt.SequenceEqual(other.IssuingCourt)
                ) && 
                (
                    IssuingJudge == other.IssuingJudge ||
                    IssuingJudge != null &&
                    IssuingJudge.SequenceEqual(other.IssuingJudge)
                ) && 
                (
                    IsIssuingJudge == other.IsIssuingJudge ||
                    IsIssuingJudge != null &&
                    IsIssuingJudge.SequenceEqual(other.IsIssuingJudge)
                ) && 
                (
                    Subject == other.Subject ||
                    Subject != null &&
                    Subject.SequenceEqual(other.Subject)
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
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DispositionDate != null)
                    hashCode = hashCode * 59 + DispositionDate.GetHashCode();
                    if (DispositionName != null)
                    hashCode = hashCode * 59 + DispositionName.GetHashCode();
                    if (IssuingCourt != null)
                    hashCode = hashCode * 59 + IssuingCourt.GetHashCode();
                    if (IssuingJudge != null)
                    hashCode = hashCode * 59 + IssuingJudge.GetHashCode();
                    if (IsIssuingJudge != null)
                    hashCode = hashCode * 59 + IsIssuingJudge.GetHashCode();
                    if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JVerdictType left, JVerdictType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JVerdictType left, JVerdictType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
