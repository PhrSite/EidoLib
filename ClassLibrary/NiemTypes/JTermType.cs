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
    /// A data type for a duration length either in specific terms or as a range.
    /// </summary>
    [DataContract]
    public partial class JTermType : NcActivityType, IEquatable<JTermType>
    { 
        /// <summary>
        /// A specific range or duration of a term. NIEM reference is j:TermDuration
        /// </summary>
        /// <value>A specific range or duration of a term. NIEM reference is j:TermDuration</value>

        [DataMember(Name="duration")]
        public List<NiemXsduration> Duration { get; set; }

        /// <summary>
        /// True if the term is not for a set duration length but for life; false otherwise. NIEM reference is j:TermLifeIndicator
        /// </summary>
        /// <value>True if the term is not for a set duration length but for life; false otherwise. NIEM reference is j:TermLifeIndicator</value>

        [DataMember(Name="isLife")]
        public List<NiemXsboolean> IsLife { get; set; }

        /// <summary>
        /// A maximum range or duration for a term. NIEM reference is j:TermMaximumDuration
        /// </summary>
        /// <value>A maximum range or duration for a term. NIEM reference is j:TermMaximumDuration</value>

        [DataMember(Name="maximumDuration")]
        public List<NiemXsduration> MaximumDuration { get; set; }

        /// <summary>
        /// A minimum range or duration for a term. NIEM reference is j:TermMinimumDuration
        /// </summary>
        /// <value>A minimum range or duration for a term. NIEM reference is j:TermMinimumDuration</value>

        [DataMember(Name="minimumDuration")]
        public List<NiemXsduration> MinimumDuration { get; set; }

        /// <summary>
        /// jTermType JSON-LD context
        /// </summary>
        /// <value>jTermType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjTermTypeContextJsonldEnum for ../JSON-LD_Contexts/jTermTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jTermTypeContext.jsonld")]
            JSONLDContextsjTermTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jTermType JSON-LD context
        /// </summary>
        /// <value>jTermType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JTermType {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  IsLife: ").Append(IsLife).Append("\n");
            sb.Append("  MaximumDuration: ").Append(MaximumDuration).Append("\n");
            sb.Append("  MinimumDuration: ").Append(MinimumDuration).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JTermType)obj);
        }

        /// <summary>
        /// Returns true if JTermType instances are equal
        /// </summary>
        /// <param name="other">Instance of JTermType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JTermType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Duration == other.Duration ||
                    Duration != null &&
                    Duration.SequenceEqual(other.Duration)
                ) && 
                (
                    IsLife == other.IsLife ||
                    IsLife != null &&
                    IsLife.SequenceEqual(other.IsLife)
                ) && 
                (
                    MaximumDuration == other.MaximumDuration ||
                    MaximumDuration != null &&
                    MaximumDuration.SequenceEqual(other.MaximumDuration)
                ) && 
                (
                    MinimumDuration == other.MinimumDuration ||
                    MinimumDuration != null &&
                    MinimumDuration.SequenceEqual(other.MinimumDuration)
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
                    if (Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();
                    if (IsLife != null)
                    hashCode = hashCode * 59 + IsLife.GetHashCode();
                    if (MaximumDuration != null)
                    hashCode = hashCode * 59 + MaximumDuration.GetHashCode();
                    if (MinimumDuration != null)
                    hashCode = hashCode * 59 + MinimumDuration.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JTermType left, JTermType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JTermType left, JTermType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}