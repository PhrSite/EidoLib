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
    /// A data type for a details that describe an additional person-categorization system that groups of people by the reason they are of interest to intelligence.
    /// </summary>
    [DataContract]
    public partial class IntelAgencyInterestOtherCategoryType : IEquatable<IntelAgencyInterestOtherCategoryType>
    { 
        /// <summary>
        /// A kind of source of the code and/or description used to detail groups of people by the reason they are of interest to intelligence. NIEM reference is intel:AgencyInterestCategoryText
        /// </summary>
        /// <value>A kind of source of the code and/or description used to detail groups of people by the reason they are of interest to intelligence. NIEM reference is intel:AgencyInterestCategoryText</value>

        [DataMember(Name="agencyInterestCategory")]
        public List<NcTextType> AgencyInterestCategory { get; set; }

        /// <summary>
        /// A reason that a group of people are of interest to intelligence. NIEM reference is intel:AgencyInterestCategoryCodeText
        /// </summary>
        /// <value>A reason that a group of people are of interest to intelligence. NIEM reference is intel:AgencyInterestCategoryCodeText</value>

        [DataMember(Name="agencyInterestCategoryCode")]
        public List<NcTextType> AgencyInterestCategoryCode { get; set; }

        /// <summary>
        /// A description of the reason that a group of people are of interest to intelligence. NIEM reference is intel:AgencyInterestCategoryDescriptionText
        /// </summary>
        /// <value>A description of the reason that a group of people are of interest to intelligence. NIEM reference is intel:AgencyInterestCategoryDescriptionText</value>

        [DataMember(Name="agencyInterestCategoryDescription")]
        public List<NcTextType> AgencyInterestCategoryDescription { get; set; }

        /// <summary>
        /// intelAgencyInterestOtherCategoryType JSON-LD context
        /// </summary>
        /// <value>intelAgencyInterestOtherCategoryType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsintelAgencyInterestOtherCategoryTypeContextJsonldEnum for ../JSON-LD_Contexts/intelAgencyInterestOtherCategoryTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/intelAgencyInterestOtherCategoryTypeContext.jsonld")]
            JSONLDContextsintelAgencyInterestOtherCategoryTypeContextJsonldEnum = 0        }

        /// <summary>
        /// intelAgencyInterestOtherCategoryType JSON-LD context
        /// </summary>
        /// <value>intelAgencyInterestOtherCategoryType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntelAgencyInterestOtherCategoryType {\n");
            sb.Append("  AgencyInterestCategory: ").Append(AgencyInterestCategory).Append("\n");
            sb.Append("  AgencyInterestCategoryCode: ").Append(AgencyInterestCategoryCode).Append("\n");
            sb.Append("  AgencyInterestCategoryDescription: ").Append(AgencyInterestCategoryDescription).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IntelAgencyInterestOtherCategoryType)obj);
        }

        /// <summary>
        /// Returns true if IntelAgencyInterestOtherCategoryType instances are equal
        /// </summary>
        /// <param name="other">Instance of IntelAgencyInterestOtherCategoryType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntelAgencyInterestOtherCategoryType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AgencyInterestCategory == other.AgencyInterestCategory ||
                    AgencyInterestCategory != null &&
                    AgencyInterestCategory.SequenceEqual(other.AgencyInterestCategory)
                ) && 
                (
                    AgencyInterestCategoryCode == other.AgencyInterestCategoryCode ||
                    AgencyInterestCategoryCode != null &&
                    AgencyInterestCategoryCode.SequenceEqual(other.AgencyInterestCategoryCode)
                ) && 
                (
                    AgencyInterestCategoryDescription == other.AgencyInterestCategoryDescription ||
                    AgencyInterestCategoryDescription != null &&
                    AgencyInterestCategoryDescription.SequenceEqual(other.AgencyInterestCategoryDescription)
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
                    if (AgencyInterestCategory != null)
                    hashCode = hashCode * 59 + AgencyInterestCategory.GetHashCode();
                    if (AgencyInterestCategoryCode != null)
                    hashCode = hashCode * 59 + AgencyInterestCategoryCode.GetHashCode();
                    if (AgencyInterestCategoryDescription != null)
                    hashCode = hashCode * 59 + AgencyInterestCategoryDescription.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IntelAgencyInterestOtherCategoryType left, IntelAgencyInterestOtherCategoryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntelAgencyInterestOtherCategoryType left, IntelAgencyInterestOtherCategoryType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
