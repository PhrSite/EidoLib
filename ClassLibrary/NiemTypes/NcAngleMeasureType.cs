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
    /// A data type for a measure of an angular value.
    /// </summary>
    [DataContract]
    public partial class NcAngleMeasureType : NcMeasureType, IEquatable<NcAngleMeasureType>
    { 
        /// <summary>
        /// A unit of measure of an angle value. NIEM reference is mo:AngleUnitCode
        /// </summary>
        /// <value>A unit of measure of an angle value. NIEM reference is mo:AngleUnitCode</value>

        [DataMember(Name="angleUnitCode")]
        public List<MoAngleUnitCodeType> AngleUnitCode { get; set; }

        /// <summary>
        /// ncAngleMeasureType JSON-LD context
        /// </summary>
        /// <value>ncAngleMeasureType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncAngleMeasureTypeContextJsonldEnum for ../JSON-LD_Contexts/ncAngleMeasureTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncAngleMeasureTypeContext.jsonld")]
            JSONLDContextsncAngleMeasureTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncAngleMeasureType JSON-LD context
        /// </summary>
        /// <value>ncAngleMeasureType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcAngleMeasureType {\n");
            sb.Append("  AngleUnitCode: ").Append(AngleUnitCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcAngleMeasureType)obj);
        }

        /// <summary>
        /// Returns true if NcAngleMeasureType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcAngleMeasureType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcAngleMeasureType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AngleUnitCode == other.AngleUnitCode ||
                    AngleUnitCode != null &&
                    AngleUnitCode.SequenceEqual(other.AngleUnitCode)
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
                    if (AngleUnitCode != null)
                    hashCode = hashCode * 59 + AngleUnitCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcAngleMeasureType left, NcAngleMeasureType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcAngleMeasureType left, NcAngleMeasureType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
