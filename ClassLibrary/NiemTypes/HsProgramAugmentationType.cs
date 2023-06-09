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
    /// A data type for additional information about a program.
    /// </summary>
    [DataContract]
    public partial class HsProgramAugmentationType : IEquatable<HsProgramAugmentationType>
    { 
        /// <summary>
        /// A date a person became eligible to enroll in a program (e.g., receive financial assistance, treatment, or some other social service). NIEM reference is hs:ProgramEligibleStartDate
        /// </summary>
        /// <value>A date a person became eligible to enroll in a program (e.g., receive financial assistance, treatment, or some other social service). NIEM reference is hs:ProgramEligibleStartDate</value>

        [DataMember(Name="programEligibleStartDate")]
        public List<NcDateType> ProgramEligibleStartDate { get; set; }

        /// <summary>
        /// A date a person lost eligibility for a program (e.g., exceeded income limits, violated a program rule, or otherwise failed to satisfy a requirement). NIEM reference is hs:ProgramEligibleEndDate
        /// </summary>
        /// <value>A date a person lost eligibility for a program (e.g., exceeded income limits, violated a program rule, or otherwise failed to satisfy a requirement). NIEM reference is hs:ProgramEligibleEndDate</value>

        [DataMember(Name="programEligibleEndDate")]
        public List<NcDateType> ProgramEligibleEndDate { get; set; }

        /// <summary>
        /// An evaluation of the monetary worth of the program provided. NIEM reference is hs:ProgramMonetaryValue
        /// </summary>
        /// <value>An evaluation of the monetary worth of the program provided. NIEM reference is hs:ProgramMonetaryValue</value>

        [DataMember(Name="programMonetaryValue")]
        public List<NcItemValueType> ProgramMonetaryValue { get; set; }

        /// <summary>
        /// hsProgramAugmentationType JSON-LD context
        /// </summary>
        /// <value>hsProgramAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextshsProgramAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/hsProgramAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/hsProgramAugmentationTypeContext.jsonld")]
            JSONLDContextshsProgramAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// hsProgramAugmentationType JSON-LD context
        /// </summary>
        /// <value>hsProgramAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HsProgramAugmentationType {\n");
            sb.Append("  ProgramEligibleStartDate: ").Append(ProgramEligibleStartDate).Append("\n");
            sb.Append("  ProgramEligibleEndDate: ").Append(ProgramEligibleEndDate).Append("\n");
            sb.Append("  ProgramMonetaryValue: ").Append(ProgramMonetaryValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HsProgramAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if HsProgramAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of HsProgramAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HsProgramAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProgramEligibleStartDate == other.ProgramEligibleStartDate ||
                    ProgramEligibleStartDate != null &&
                    ProgramEligibleStartDate.SequenceEqual(other.ProgramEligibleStartDate)
                ) && 
                (
                    ProgramEligibleEndDate == other.ProgramEligibleEndDate ||
                    ProgramEligibleEndDate != null &&
                    ProgramEligibleEndDate.SequenceEqual(other.ProgramEligibleEndDate)
                ) && 
                (
                    ProgramMonetaryValue == other.ProgramMonetaryValue ||
                    ProgramMonetaryValue != null &&
                    ProgramMonetaryValue.SequenceEqual(other.ProgramMonetaryValue)
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
                    if (ProgramEligibleStartDate != null)
                    hashCode = hashCode * 59 + ProgramEligibleStartDate.GetHashCode();
                    if (ProgramEligibleEndDate != null)
                    hashCode = hashCode * 59 + ProgramEligibleEndDate.GetHashCode();
                    if (ProgramMonetaryValue != null)
                    hashCode = hashCode * 59 + ProgramMonetaryValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HsProgramAugmentationType left, HsProgramAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HsProgramAugmentationType left, HsProgramAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
