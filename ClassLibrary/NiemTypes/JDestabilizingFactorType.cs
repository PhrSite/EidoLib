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
    /// A data type for a risk the may heighten testability in a subject.
    /// </summary>
    [DataContract]
    public partial class JDestabilizingFactorType : IEquatable<JDestabilizingFactorType>
    { 
        /// <summary>
        /// A kind of risk the may heighten testability in a subject. NIEM reference is j:DestabilizingFactorCategoryText
        /// </summary>
        /// <value>A kind of risk the may heighten testability in a subject. NIEM reference is j:DestabilizingFactorCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A detail description about an other factor that tends to heighten offender risk. NIEM reference is j:DestabilizingFactorOtherFactorDetailsText
        /// </summary>
        /// <value>A detail description about an other factor that tends to heighten offender risk. NIEM reference is j:DestabilizingFactorOtherFactorDetailsText</value>

        [DataMember(Name="otherFactorDetails")]
        public List<NcTextType> OtherFactorDetails { get; set; }

        /// <summary>
        /// A comment regarding additional information regarding destabilizing factors. NIEM reference is j:DestabilizingFactorComment
        /// </summary>
        /// <value>A comment regarding additional information regarding destabilizing factors. NIEM reference is j:DestabilizingFactorComment</value>

        [DataMember(Name="comment")]
        public List<NcCommentType> Comment { get; set; }

        /// <summary>
        /// jDestabilizingFactorType JSON-LD context
        /// </summary>
        /// <value>jDestabilizingFactorType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjDestabilizingFactorTypeContextJsonldEnum for ../JSON-LD_Contexts/jDestabilizingFactorTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jDestabilizingFactorTypeContext.jsonld")]
            JSONLDContextsjDestabilizingFactorTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jDestabilizingFactorType JSON-LD context
        /// </summary>
        /// <value>jDestabilizingFactorType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JDestabilizingFactorType {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  OtherFactorDetails: ").Append(OtherFactorDetails).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JDestabilizingFactorType)obj);
        }

        /// <summary>
        /// Returns true if JDestabilizingFactorType instances are equal
        /// </summary>
        /// <param name="other">Instance of JDestabilizingFactorType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JDestabilizingFactorType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    OtherFactorDetails == other.OtherFactorDetails ||
                    OtherFactorDetails != null &&
                    OtherFactorDetails.SequenceEqual(other.OtherFactorDetails)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.SequenceEqual(other.Comment)
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
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (OtherFactorDetails != null)
                    hashCode = hashCode * 59 + OtherFactorDetails.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JDestabilizingFactorType left, JDestabilizingFactorType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JDestabilizingFactorType left, JDestabilizingFactorType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
