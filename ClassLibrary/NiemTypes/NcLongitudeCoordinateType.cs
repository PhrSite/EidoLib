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
    /// A data type for a measurement of the angular distance between a point on the Earth and the Prime Meridian.
    /// </summary>
    [DataContract]
    public partial class NcLongitudeCoordinateType : IEquatable<NcLongitudeCoordinateType>
    { 
        /// <summary>
        /// A value that specifies the degree of a longitude. The value comes from a restricted range between -180 (inclusive) and +180 (inclusive). NIEM reference is nc:LongitudeDegreeValue
        /// </summary>
        /// <value>A value that specifies the degree of a longitude. The value comes from a restricted range between -180 (inclusive) and +180 (inclusive). NIEM reference is nc:LongitudeDegreeValue</value>

        [DataMember(Name="longitudeDegreeValue")]
        public List<NcLongitudeDegreeType> LongitudeDegreeValue { get; set; }

        /// <summary>
        /// A longitude value that specifies a minute of a degree. The value comes from a restricted range of 0 (inclusive) to 60 (exclusive). NIEM reference is nc:LongitudeMinuteValue
        /// </summary>
        /// <value>A longitude value that specifies a minute of a degree. The value comes from a restricted range of 0 (inclusive) to 60 (exclusive). NIEM reference is nc:LongitudeMinuteValue</value>

        [DataMember(Name="longitudeMinuteValue")]
        public List<NcAngularMinuteType> LongitudeMinuteValue { get; set; }

        /// <summary>
        /// A longitude value that specifies a second of a minute. The value comes from a restricted range of 0 (inclusive) to 60 (exclusive). NIEM reference is nc:LongitudeSecondValue
        /// </summary>
        /// <value>A longitude value that specifies a second of a minute. The value comes from a restricted range of 0 (inclusive) to 60 (exclusive). NIEM reference is nc:LongitudeSecondValue</value>

        [DataMember(Name="longitudeSecondValue")]
        public List<NcAngularSecondType> LongitudeSecondValue { get; set; }

        /// <summary>
        /// ncLongitudeCoordinateType JSON-LD context
        /// </summary>
        /// <value>ncLongitudeCoordinateType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncLongitudeCoordinateTypeContextJsonldEnum for ../JSON-LD_Contexts/ncLongitudeCoordinateTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncLongitudeCoordinateTypeContext.jsonld")]
            JSONLDContextsncLongitudeCoordinateTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncLongitudeCoordinateType JSON-LD context
        /// </summary>
        /// <value>ncLongitudeCoordinateType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcLongitudeCoordinateType {\n");
            sb.Append("  LongitudeDegreeValue: ").Append(LongitudeDegreeValue).Append("\n");
            sb.Append("  LongitudeMinuteValue: ").Append(LongitudeMinuteValue).Append("\n");
            sb.Append("  LongitudeSecondValue: ").Append(LongitudeSecondValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcLongitudeCoordinateType)obj);
        }

        /// <summary>
        /// Returns true if NcLongitudeCoordinateType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcLongitudeCoordinateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcLongitudeCoordinateType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LongitudeDegreeValue == other.LongitudeDegreeValue ||
                    LongitudeDegreeValue != null &&
                    LongitudeDegreeValue.SequenceEqual(other.LongitudeDegreeValue)
                ) && 
                (
                    LongitudeMinuteValue == other.LongitudeMinuteValue ||
                    LongitudeMinuteValue != null &&
                    LongitudeMinuteValue.SequenceEqual(other.LongitudeMinuteValue)
                ) && 
                (
                    LongitudeSecondValue == other.LongitudeSecondValue ||
                    LongitudeSecondValue != null &&
                    LongitudeSecondValue.SequenceEqual(other.LongitudeSecondValue)
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
                    if (LongitudeDegreeValue != null)
                    hashCode = hashCode * 59 + LongitudeDegreeValue.GetHashCode();
                    if (LongitudeMinuteValue != null)
                    hashCode = hashCode * 59 + LongitudeMinuteValue.GetHashCode();
                    if (LongitudeSecondValue != null)
                    hashCode = hashCode * 59 + LongitudeSecondValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcLongitudeCoordinateType left, NcLongitudeCoordinateType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcLongitudeCoordinateType left, NcLongitudeCoordinateType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
