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
    /// A data type for a summary of a type of offense.
    /// </summary>
    [DataContract]
    public partial class JOffenseSummaryType : IEquatable<JOffenseSummaryType>
    { 
        /// <summary>
        /// A number of arrests for a summary offense type. NIEM reference is j:OffenseSummaryArrestQuantity
        /// </summary>
        /// <value>A number of arrests for a summary offense type. NIEM reference is j:OffenseSummaryArrestQuantity</value>

        [DataMember(Name="arrestQuantity")]
        public List<NiemXsnonNegativeInteger> ArrestQuantity { get; set; }

        /// <summary>
        /// A kind of offense being summarized. NIEM reference is j:OffenseSummaryCategoryText
        /// </summary>
        /// <value>A kind of offense being summarized. NIEM reference is j:OffenseSummaryCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A number of convictions for a summary offense type. NIEM reference is j:OffenseSummaryConvictionQuantity
        /// </summary>
        /// <value>A number of convictions for a summary offense type. NIEM reference is j:OffenseSummaryConvictionQuantity</value>

        [DataMember(Name="convictionQuantity")]
        public List<NiemXsnonNegativeInteger> ConvictionQuantity { get; set; }

        /// <summary>
        /// A kind of offense being summarized. NIEM reference is j:OffenseSummaryCategoryCode
        /// </summary>
        /// <value>A kind of offense being summarized. NIEM reference is j:OffenseSummaryCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<NdexOffenseSummaryCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// jOffenseSummaryType JSON-LD context
        /// </summary>
        /// <value>jOffenseSummaryType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjOffenseSummaryTypeContextJsonldEnum for ../JSON-LD_Contexts/jOffenseSummaryTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jOffenseSummaryTypeContext.jsonld")]
            JSONLDContextsjOffenseSummaryTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jOffenseSummaryType JSON-LD context
        /// </summary>
        /// <value>jOffenseSummaryType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JOffenseSummaryType {\n");
            sb.Append("  ArrestQuantity: ").Append(ArrestQuantity).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ConvictionQuantity: ").Append(ConvictionQuantity).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JOffenseSummaryType)obj);
        }

        /// <summary>
        /// Returns true if JOffenseSummaryType instances are equal
        /// </summary>
        /// <param name="other">Instance of JOffenseSummaryType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JOffenseSummaryType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ArrestQuantity == other.ArrestQuantity ||
                    ArrestQuantity != null &&
                    ArrestQuantity.SequenceEqual(other.ArrestQuantity)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    ConvictionQuantity == other.ConvictionQuantity ||
                    ConvictionQuantity != null &&
                    ConvictionQuantity.SequenceEqual(other.ConvictionQuantity)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
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
                    if (ArrestQuantity != null)
                    hashCode = hashCode * 59 + ArrestQuantity.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (ConvictionQuantity != null)
                    hashCode = hashCode * 59 + ConvictionQuantity.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JOffenseSummaryType left, JOffenseSummaryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JOffenseSummaryType left, JOffenseSummaryType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
