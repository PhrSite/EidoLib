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
    /// A data type for a information on the manner of ARREST
    /// </summary>
    [DataContract]
    public partial class ScrArrestMethodType : IEquatable<ScrArrestMethodType>
    { 
        /// <summary>
        /// A description of the values used for the ARREST METHOD. NIEM reference is scr:ArrestMethodDescriptionText
        /// </summary>
        /// <value>A description of the values used for the ARREST METHOD. NIEM reference is scr:ArrestMethodDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// An ARREST METHOD TYPE NIEM reference is scr:ArrestMethodCode
        /// </summary>
        /// <value>An ARREST METHOD TYPE NIEM reference is scr:ArrestMethodCode</value>

        [DataMember(Name="code")]
        public List<ScrArrestMethodCategoryCodeType> Code { get; set; }

        /// <summary>
        /// scrArrestMethodType JSON-LD context
        /// </summary>
        /// <value>scrArrestMethodType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsscrArrestMethodTypeContextJsonldEnum for ../JSON-LD_Contexts/scrArrestMethodTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/scrArrestMethodTypeContext.jsonld")]
            JSONLDContextsscrArrestMethodTypeContextJsonldEnum = 0        }

        /// <summary>
        /// scrArrestMethodType JSON-LD context
        /// </summary>
        /// <value>scrArrestMethodType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScrArrestMethodType {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScrArrestMethodType)obj);
        }

        /// <summary>
        /// Returns true if ScrArrestMethodType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScrArrestMethodType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScrArrestMethodType other)
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
                    Code == other.Code ||
                    Code != null &&
                    Code.SequenceEqual(other.Code)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScrArrestMethodType left, ScrArrestMethodType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScrArrestMethodType left, ScrArrestMethodType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}