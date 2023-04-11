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
    /// A data type describing the kinds of jurisdictions issuing Conveyance registrations
    /// </summary>
    [DataContract]
    public partial class ScrConveyanceIDIssuingJurisdictionCategoryCodeType : IEquatable<ScrConveyanceIDIssuingJurisdictionCategoryCodeType>
    { 
        /// <summary>
        /// Gets or Sets SimpleType
        /// </summary>

        [DataMember(Name="simpleType")]
        public ScrConveyanceIDIssuingJurisdictionCategoryCodeSimpleType SimpleType { get; set; }

        /// <summary>
        /// scrConveyanceIDIssuingJurisdictionCategoryCodeType JSON-LD context
        /// </summary>
        /// <value>scrConveyanceIDIssuingJurisdictionCategoryCodeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsscrConveyanceIDIssuingJurisdictionCategoryCodeTypeContextJsonldEnum for ../JSON-LD_Contexts/scrConveyanceIDIssuingJurisdictionCategoryCodeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/scrConveyanceIDIssuingJurisdictionCategoryCodeTypeContext.jsonld")]
            JSONLDContextsscrConveyanceIDIssuingJurisdictionCategoryCodeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// scrConveyanceIDIssuingJurisdictionCategoryCodeType JSON-LD context
        /// </summary>
        /// <value>scrConveyanceIDIssuingJurisdictionCategoryCodeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScrConveyanceIDIssuingJurisdictionCategoryCodeType {\n");
            sb.Append("  SimpleType: ").Append(SimpleType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScrConveyanceIDIssuingJurisdictionCategoryCodeType)obj);
        }

        /// <summary>
        /// Returns true if ScrConveyanceIDIssuingJurisdictionCategoryCodeType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScrConveyanceIDIssuingJurisdictionCategoryCodeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScrConveyanceIDIssuingJurisdictionCategoryCodeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SimpleType == other.SimpleType ||
                    SimpleType != null &&
                    SimpleType.Equals(other.SimpleType)
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
                    if (SimpleType != null)
                    hashCode = hashCode * 59 + SimpleType.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScrConveyanceIDIssuingJurisdictionCategoryCodeType left, ScrConveyanceIDIssuingJurisdictionCategoryCodeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScrConveyanceIDIssuingJurisdictionCategoryCodeType left, ScrConveyanceIDIssuingJurisdictionCategoryCodeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
