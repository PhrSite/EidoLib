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
    /// A data type for an angle measured in degrees used to identify the intended direction of movement in the horizontal plane.  The value of the angle is positive in a clockwise direction as viewed from \&quot;above\&quot; the horizontal plane.
    /// </summary>
    [DataContract]
    public partial class MoCourseAngleDegreesMeasureType : IEquatable<MoCourseAngleDegreesMeasureType>
    { 
        /// <summary>
        /// An angle in two dimensions measured in degrees (the angle between two half-lines terminating at the same point). NIEM reference is mo:AngleDegreesMeasure
        /// </summary>
        /// <value>An angle in two dimensions measured in degrees (the angle between two half-lines terminating at the same point). NIEM reference is mo:AngleDegreesMeasure</value>

        [DataMember(Name="angleDegreesMeasure")]
        public List<NcAngularMeasureType> AngleDegreesMeasure { get; set; }

        /// <summary>
        /// A designator for a reference direction as determined by the means by which it is established (e.g., by the direction of a geographic or magnetic pole of the Earth). NIEM reference is mo:DirectionDatumCode
        /// </summary>
        /// <value>A designator for a reference direction as determined by the means by which it is established (e.g., by the direction of a geographic or magnetic pole of the Earth). NIEM reference is mo:DirectionDatumCode</value>

        [DataMember(Name="directionDatumCode")]
        public List<NgaDirectionDatumCodeType> DirectionDatumCode { get; set; }

        /// <summary>
        /// A decimal value for a measurement of an angle. NIEM reference is mo:AngularMeasureDecimalValue
        /// </summary>
        /// <value>A decimal value for a measurement of an angle. NIEM reference is mo:AngularMeasureDecimalValue</value>

        [DataMember(Name="angularMeasureDecimalValue")]
        public List<NiemXsdecimal> AngularMeasureDecimalValue { get; set; }

        /// <summary>
        /// moCourseAngleDegreesMeasureType JSON-LD context
        /// </summary>
        /// <value>moCourseAngleDegreesMeasureType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsmoCourseAngleDegreesMeasureTypeContextJsonldEnum for ../JSON-LD_Contexts/moCourseAngleDegreesMeasureTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/moCourseAngleDegreesMeasureTypeContext.jsonld")]
            JSONLDContextsmoCourseAngleDegreesMeasureTypeContextJsonldEnum = 0        }

        /// <summary>
        /// moCourseAngleDegreesMeasureType JSON-LD context
        /// </summary>
        /// <value>moCourseAngleDegreesMeasureType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoCourseAngleDegreesMeasureType {\n");
            sb.Append("  AngleDegreesMeasure: ").Append(AngleDegreesMeasure).Append("\n");
            sb.Append("  DirectionDatumCode: ").Append(DirectionDatumCode).Append("\n");
            sb.Append("  AngularMeasureDecimalValue: ").Append(AngularMeasureDecimalValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MoCourseAngleDegreesMeasureType)obj);
        }

        /// <summary>
        /// Returns true if MoCourseAngleDegreesMeasureType instances are equal
        /// </summary>
        /// <param name="other">Instance of MoCourseAngleDegreesMeasureType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoCourseAngleDegreesMeasureType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AngleDegreesMeasure == other.AngleDegreesMeasure ||
                    AngleDegreesMeasure != null &&
                    AngleDegreesMeasure.SequenceEqual(other.AngleDegreesMeasure)
                ) && 
                (
                    DirectionDatumCode == other.DirectionDatumCode ||
                    DirectionDatumCode != null &&
                    DirectionDatumCode.SequenceEqual(other.DirectionDatumCode)
                ) && 
                (
                    AngularMeasureDecimalValue == other.AngularMeasureDecimalValue ||
                    AngularMeasureDecimalValue != null &&
                    AngularMeasureDecimalValue.SequenceEqual(other.AngularMeasureDecimalValue)
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
                    if (AngleDegreesMeasure != null)
                    hashCode = hashCode * 59 + AngleDegreesMeasure.GetHashCode();
                    if (DirectionDatumCode != null)
                    hashCode = hashCode * 59 + DirectionDatumCode.GetHashCode();
                    if (AngularMeasureDecimalValue != null)
                    hashCode = hashCode * 59 + AngularMeasureDecimalValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MoCourseAngleDegreesMeasureType left, MoCourseAngleDegreesMeasureType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MoCourseAngleDegreesMeasureType left, MoCourseAngleDegreesMeasureType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}