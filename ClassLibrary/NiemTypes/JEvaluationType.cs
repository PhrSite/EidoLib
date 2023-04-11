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
    /// A data type for an activity resulting in a mental and/or physical diagnosis
    /// </summary>
    [DataContract]
    public partial class JEvaluationType : NcActivityType, IEquatable<JEvaluationType>
    { 
        /// <summary>
        /// A description of a Person&#x27;s evaluation NIEM reference is j:EvaluationDescriptionText
        /// </summary>
        /// <value>A description of a Person&#x27;s evaluation NIEM reference is j:EvaluationDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A description of a diagnosis determined as a result of an Person&#x27;s evaluation NIEM reference is j:EvaluationDiagnosisDescriptionText
        /// </summary>
        /// <value>A description of a diagnosis determined as a result of an Person&#x27;s evaluation NIEM reference is j:EvaluationDiagnosisDescriptionText</value>

        [DataMember(Name="diagnosisDescription")]
        public List<NcTextType> DiagnosisDescription { get; set; }

        /// <summary>
        /// A description of a disorder determined as a result of an Person&#x27;s evaluation NIEM reference is j:EvaluationDisorderDescriptionText
        /// </summary>
        /// <value>A description of a disorder determined as a result of an Person&#x27;s evaluation NIEM reference is j:EvaluationDisorderDescriptionText</value>

        [DataMember(Name="disorderDescription")]
        public List<NcTextType> DisorderDescription { get; set; }

        /// <summary>
        /// True if an Person is currently undergoing an evaluation; false otherwise. NIEM reference is j:CurrentEvaluationIndicator
        /// </summary>
        /// <value>True if an Person is currently undergoing an evaluation; false otherwise. NIEM reference is j:CurrentEvaluationIndicator</value>

        [DataMember(Name="isCurrent")]
        public List<NiemXsboolean> IsCurrent { get; set; }

        /// <summary>
        /// An entity who provides a service to a Person to determine physical or mental state NIEM reference is j:EvaluationProvider
        /// </summary>
        /// <value>An entity who provides a service to a Person to determine physical or mental state NIEM reference is j:EvaluationProvider</value>

        [DataMember(Name="provider")]
        public List<NcEntityType> Provider { get; set; }

        /// <summary>
        /// A description of an established association with a disorder determined as a result of an Person&#x27;s evaluation NIEM reference is j:EvaluationRelatedDisorderDescriptionText
        /// </summary>
        /// <value>A description of an established association with a disorder determined as a result of an Person&#x27;s evaluation NIEM reference is j:EvaluationRelatedDisorderDescriptionText</value>

        [DataMember(Name="relatedDisorderDescription")]
        public List<NcTextType> RelatedDisorderDescription { get; set; }

        /// <summary>
        /// True if it has been determined that an Person has a medical disorder; false otherwise. NIEM reference is j:MedicalDisorderIndicator
        /// </summary>
        /// <value>True if it has been determined that an Person has a medical disorder; false otherwise. NIEM reference is j:MedicalDisorderIndicator</value>

        [DataMember(Name="isMedicalDisorder")]
        public List<NiemXsboolean> IsMedicalDisorder { get; set; }

        /// <summary>
        /// jEvaluationType JSON-LD context
        /// </summary>
        /// <value>jEvaluationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjEvaluationTypeContextJsonldEnum for ../JSON-LD_Contexts/jEvaluationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jEvaluationTypeContext.jsonld")]
            JSONLDContextsjEvaluationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jEvaluationType JSON-LD context
        /// </summary>
        /// <value>jEvaluationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JEvaluationType {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiagnosisDescription: ").Append(DiagnosisDescription).Append("\n");
            sb.Append("  DisorderDescription: ").Append(DisorderDescription).Append("\n");
            sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  RelatedDisorderDescription: ").Append(RelatedDisorderDescription).Append("\n");
            sb.Append("  IsMedicalDisorder: ").Append(IsMedicalDisorder).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JEvaluationType)obj);
        }

        /// <summary>
        /// Returns true if JEvaluationType instances are equal
        /// </summary>
        /// <param name="other">Instance of JEvaluationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JEvaluationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    DiagnosisDescription == other.DiagnosisDescription ||
                    DiagnosisDescription != null &&
                    DiagnosisDescription.SequenceEqual(other.DiagnosisDescription)
                ) && 
                (
                    DisorderDescription == other.DisorderDescription ||
                    DisorderDescription != null &&
                    DisorderDescription.SequenceEqual(other.DisorderDescription)
                ) && 
                (
                    IsCurrent == other.IsCurrent ||
                    IsCurrent != null &&
                    IsCurrent.SequenceEqual(other.IsCurrent)
                ) && 
                (
                    Provider == other.Provider ||
                    Provider != null &&
                    Provider.SequenceEqual(other.Provider)
                ) && 
                (
                    RelatedDisorderDescription == other.RelatedDisorderDescription ||
                    RelatedDisorderDescription != null &&
                    RelatedDisorderDescription.SequenceEqual(other.RelatedDisorderDescription)
                ) && 
                (
                    IsMedicalDisorder == other.IsMedicalDisorder ||
                    IsMedicalDisorder != null &&
                    IsMedicalDisorder.SequenceEqual(other.IsMedicalDisorder)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DiagnosisDescription != null)
                    hashCode = hashCode * 59 + DiagnosisDescription.GetHashCode();
                    if (DisorderDescription != null)
                    hashCode = hashCode * 59 + DisorderDescription.GetHashCode();
                    if (IsCurrent != null)
                    hashCode = hashCode * 59 + IsCurrent.GetHashCode();
                    if (Provider != null)
                    hashCode = hashCode * 59 + Provider.GetHashCode();
                    if (RelatedDisorderDescription != null)
                    hashCode = hashCode * 59 + RelatedDisorderDescription.GetHashCode();
                    if (IsMedicalDisorder != null)
                    hashCode = hashCode * 59 + IsMedicalDisorder.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JEvaluationType left, JEvaluationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JEvaluationType left, JEvaluationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}