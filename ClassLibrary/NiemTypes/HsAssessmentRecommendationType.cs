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
    /// A data type for the recommendation of an assessment.
    /// </summary>
    [DataContract]
    public partial class HsAssessmentRecommendationType : NcActivityType, IEquatable<HsAssessmentRecommendationType>
    { 
        /// <summary>
        /// A recommended course of action arising from an assessment. NIEM reference is hs:AssessmentRecommendedCourseOfAction
        /// </summary>
        /// <value>A recommended course of action arising from an assessment. NIEM reference is hs:AssessmentRecommendedCourseOfAction</value>

        [DataMember(Name="assessmentRecommendedCourseOfAction")]
        public List<HsAssessmentRecommendedCourseOfActionType> AssessmentRecommendedCourseOfAction { get; set; }

        /// <summary>
        /// hsAssessmentRecommendationType JSON-LD context
        /// </summary>
        /// <value>hsAssessmentRecommendationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextshsAssessmentRecommendationTypeContextJsonldEnum for ../JSON-LD_Contexts/hsAssessmentRecommendationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/hsAssessmentRecommendationTypeContext.jsonld")]
            JSONLDContextshsAssessmentRecommendationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// hsAssessmentRecommendationType JSON-LD context
        /// </summary>
        /// <value>hsAssessmentRecommendationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HsAssessmentRecommendationType {\n");
            sb.Append("  AssessmentRecommendedCourseOfAction: ").Append(AssessmentRecommendedCourseOfAction).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HsAssessmentRecommendationType)obj);
        }

        /// <summary>
        /// Returns true if HsAssessmentRecommendationType instances are equal
        /// </summary>
        /// <param name="other">Instance of HsAssessmentRecommendationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HsAssessmentRecommendationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssessmentRecommendedCourseOfAction == other.AssessmentRecommendedCourseOfAction ||
                    AssessmentRecommendedCourseOfAction != null &&
                    AssessmentRecommendedCourseOfAction.SequenceEqual(other.AssessmentRecommendedCourseOfAction)
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
                    if (AssessmentRecommendedCourseOfAction != null)
                    hashCode = hashCode * 59 + AssessmentRecommendedCourseOfAction.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HsAssessmentRecommendationType left, HsAssessmentRecommendationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HsAssessmentRecommendationType left, HsAssessmentRecommendationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
