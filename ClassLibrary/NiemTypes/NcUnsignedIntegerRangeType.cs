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
    /// A data type for a range of unsigned integer values.
    /// </summary>
    [DataContract]
    public partial class NcUnsignedIntegerRangeType : IEquatable<NcUnsignedIntegerRangeType>
    { 
        /// <summary>
        /// A minimum value of a range. NIEM reference is nc:RangeMinimumUnsignedIntegerValue
        /// </summary>
        /// <value>A minimum value of a range. NIEM reference is nc:RangeMinimumUnsignedIntegerValue</value>

        [DataMember(Name="rangeMinimumUnsignedIntegerValue")]
        public List<NiemXsunsignedInt> RangeMinimumUnsignedIntegerValue { get; set; }

        /// <summary>
        /// A maximum value of a range. NIEM reference is nc:RangeMaximumUnsignedIntegerValue
        /// </summary>
        /// <value>A maximum value of a range. NIEM reference is nc:RangeMaximumUnsignedIntegerValue</value>

        [DataMember(Name="rangeMaximumUnsignedIntegerValue")]
        public List<NiemXsunsignedInt> RangeMaximumUnsignedIntegerValue { get; set; }

        /// <summary>
        /// ncUnsignedIntegerRangeType JSON-LD context
        /// </summary>
        /// <value>ncUnsignedIntegerRangeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncUnsignedIntegerRangeTypeContextJsonldEnum for ../JSON-LD_Contexts/ncUnsignedIntegerRangeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncUnsignedIntegerRangeTypeContext.jsonld")]
            JSONLDContextsncUnsignedIntegerRangeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncUnsignedIntegerRangeType JSON-LD context
        /// </summary>
        /// <value>ncUnsignedIntegerRangeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcUnsignedIntegerRangeType {\n");
            sb.Append("  RangeMinimumUnsignedIntegerValue: ").Append(RangeMinimumUnsignedIntegerValue).Append("\n");
            sb.Append("  RangeMaximumUnsignedIntegerValue: ").Append(RangeMaximumUnsignedIntegerValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcUnsignedIntegerRangeType)obj);
        }

        /// <summary>
        /// Returns true if NcUnsignedIntegerRangeType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcUnsignedIntegerRangeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcUnsignedIntegerRangeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RangeMinimumUnsignedIntegerValue == other.RangeMinimumUnsignedIntegerValue ||
                    RangeMinimumUnsignedIntegerValue != null &&
                    RangeMinimumUnsignedIntegerValue.SequenceEqual(other.RangeMinimumUnsignedIntegerValue)
                ) && 
                (
                    RangeMaximumUnsignedIntegerValue == other.RangeMaximumUnsignedIntegerValue ||
                    RangeMaximumUnsignedIntegerValue != null &&
                    RangeMaximumUnsignedIntegerValue.SequenceEqual(other.RangeMaximumUnsignedIntegerValue)
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
                    if (RangeMinimumUnsignedIntegerValue != null)
                    hashCode = hashCode * 59 + RangeMinimumUnsignedIntegerValue.GetHashCode();
                    if (RangeMaximumUnsignedIntegerValue != null)
                    hashCode = hashCode * 59 + RangeMaximumUnsignedIntegerValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcUnsignedIntegerRangeType left, NcUnsignedIntegerRangeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcUnsignedIntegerRangeType left, NcUnsignedIntegerRangeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
