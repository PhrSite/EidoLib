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
    /// A data type for additional information about a Address.
    /// </summary>
    [DataContract]
    public partial class JAddressAugmentationType : IEquatable<JAddressAugmentationType>
    { 
        /// <summary>
        /// A date on which the address was verified. NIEM reference is j:AddressVerifiedDate
        /// </summary>
        /// <value>A date on which the address was verified. NIEM reference is j:AddressVerifiedDate</value>

        [DataMember(Name="addressVerifiedDate")]
        public List<NcDateType> AddressVerifiedDate { get; set; }

        /// <summary>
        /// A comment about an address. NIEM reference is j:AddressCommentText
        /// </summary>
        /// <value>A comment about an address. NIEM reference is j:AddressCommentText</value>

        [DataMember(Name="addressComment")]
        public List<NcTextType> AddressComment { get; set; }

        /// <summary>
        /// jAddressAugmentationType JSON-LD context
        /// </summary>
        /// <value>jAddressAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjAddressAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/jAddressAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jAddressAugmentationTypeContext.jsonld")]
            JSONLDContextsjAddressAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jAddressAugmentationType JSON-LD context
        /// </summary>
        /// <value>jAddressAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JAddressAugmentationType {\n");
            sb.Append("  AddressVerifiedDate: ").Append(AddressVerifiedDate).Append("\n");
            sb.Append("  AddressComment: ").Append(AddressComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JAddressAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if JAddressAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of JAddressAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JAddressAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AddressVerifiedDate == other.AddressVerifiedDate ||
                    AddressVerifiedDate != null &&
                    AddressVerifiedDate.SequenceEqual(other.AddressVerifiedDate)
                ) && 
                (
                    AddressComment == other.AddressComment ||
                    AddressComment != null &&
                    AddressComment.SequenceEqual(other.AddressComment)
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
                    if (AddressVerifiedDate != null)
                    hashCode = hashCode * 59 + AddressVerifiedDate.GetHashCode();
                    if (AddressComment != null)
                    hashCode = hashCode * 59 + AddressComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JAddressAugmentationType left, JAddressAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JAddressAugmentationType left, JAddressAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
