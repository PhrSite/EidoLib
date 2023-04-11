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
    /// A data type for a square segment position for a particular friction ridge
    /// </summary>
    [DataContract]
    public partial class BiomFrictionRidgeImageSegmentPositionSquareType : IEquatable<BiomFrictionRidgeImageSegmentPositionSquareType>
    { 
        /// <summary>
        /// A finger position code NIEM reference is biom:FingerPositionCode
        /// </summary>
        /// <value>A finger position code NIEM reference is biom:FingerPositionCode</value>

        [DataMember(Name="fingerPositionCode")]
        public List<BiomFingerPositionCodeType> FingerPositionCode { get; set; }

        /// <summary>
        /// A location on the palm that a print represents NIEM reference is biom:PalmPositionCode
        /// </summary>
        /// <value>A location on the palm that a print represents NIEM reference is biom:PalmPositionCode</value>

        [DataMember(Name="palmPositionCode")]
        public List<BiomPalmPositionCodeType> PalmPositionCode { get; set; }

        /// <summary>
        /// A location on the foot that a print represents NIEM reference is biom:PlantarPositionCode
        /// </summary>
        /// <value>A location on the foot that a print represents NIEM reference is biom:PlantarPositionCode</value>

        [DataMember(Name="plantarPositionCode")]
        public List<BiomPlantarPositionCodeType> PlantarPositionCode { get; set; }

        /// <summary>
        /// A bottom vertical offset of a segment box within an image in pixels NIEM reference is biom:SegmentBottomVerticalCoordinateValue
        /// </summary>
        /// <value>A bottom vertical offset of a segment box within an image in pixels NIEM reference is biom:SegmentBottomVerticalCoordinateValue</value>

        [DataMember(Name="segmentBottomVerticalCoordinateValue")]
        public List<NiemXsnonNegativeInteger> SegmentBottomVerticalCoordinateValue { get; set; }

        /// <summary>
        /// A left horizontal offset of a segment box within an image in pixels NIEM reference is biom:SegmentLeftHorizontalCoordinateValue
        /// </summary>
        /// <value>A left horizontal offset of a segment box within an image in pixels NIEM reference is biom:SegmentLeftHorizontalCoordinateValue</value>

        [DataMember(Name="segmentLeftHorizontalCoordinateValue")]
        public List<NiemXsnonNegativeInteger> SegmentLeftHorizontalCoordinateValue { get; set; }

        /// <summary>
        /// A right horizontal offset of a segment box within an image in pixels NIEM reference is biom:SegmentRightHorizontalCoordinateValue
        /// </summary>
        /// <value>A right horizontal offset of a segment box within an image in pixels NIEM reference is biom:SegmentRightHorizontalCoordinateValue</value>

        [DataMember(Name="segmentRightHorizontalCoordinateValue")]
        public List<NiemXsnonNegativeInteger> SegmentRightHorizontalCoordinateValue { get; set; }

        /// <summary>
        /// A top vertical offset of a segment box within an image in pixels NIEM reference is biom:SegmentTopVerticalCoordinateValue
        /// </summary>
        /// <value>A top vertical offset of a segment box within an image in pixels NIEM reference is biom:SegmentTopVerticalCoordinateValue</value>

        [DataMember(Name="segmentTopVerticalCoordinateValue")]
        public List<NiemXsnonNegativeInteger> SegmentTopVerticalCoordinateValue { get; set; }

        /// <summary>
        /// biomFrictionRidgeImageSegmentPositionSquareType JSON-LD context
        /// </summary>
        /// <value>biomFrictionRidgeImageSegmentPositionSquareType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFrictionRidgeImageSegmentPositionSquareTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFrictionRidgeImageSegmentPositionSquareTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFrictionRidgeImageSegmentPositionSquareTypeContext.jsonld")]
            JSONLDContextsbiomFrictionRidgeImageSegmentPositionSquareTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFrictionRidgeImageSegmentPositionSquareType JSON-LD context
        /// </summary>
        /// <value>biomFrictionRidgeImageSegmentPositionSquareType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFrictionRidgeImageSegmentPositionSquareType {\n");
            sb.Append("  FingerPositionCode: ").Append(FingerPositionCode).Append("\n");
            sb.Append("  PalmPositionCode: ").Append(PalmPositionCode).Append("\n");
            sb.Append("  PlantarPositionCode: ").Append(PlantarPositionCode).Append("\n");
            sb.Append("  SegmentBottomVerticalCoordinateValue: ").Append(SegmentBottomVerticalCoordinateValue).Append("\n");
            sb.Append("  SegmentLeftHorizontalCoordinateValue: ").Append(SegmentLeftHorizontalCoordinateValue).Append("\n");
            sb.Append("  SegmentRightHorizontalCoordinateValue: ").Append(SegmentRightHorizontalCoordinateValue).Append("\n");
            sb.Append("  SegmentTopVerticalCoordinateValue: ").Append(SegmentTopVerticalCoordinateValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFrictionRidgeImageSegmentPositionSquareType)obj);
        }

        /// <summary>
        /// Returns true if BiomFrictionRidgeImageSegmentPositionSquareType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFrictionRidgeImageSegmentPositionSquareType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFrictionRidgeImageSegmentPositionSquareType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FingerPositionCode == other.FingerPositionCode ||
                    FingerPositionCode != null &&
                    FingerPositionCode.SequenceEqual(other.FingerPositionCode)
                ) && 
                (
                    PalmPositionCode == other.PalmPositionCode ||
                    PalmPositionCode != null &&
                    PalmPositionCode.SequenceEqual(other.PalmPositionCode)
                ) && 
                (
                    PlantarPositionCode == other.PlantarPositionCode ||
                    PlantarPositionCode != null &&
                    PlantarPositionCode.SequenceEqual(other.PlantarPositionCode)
                ) && 
                (
                    SegmentBottomVerticalCoordinateValue == other.SegmentBottomVerticalCoordinateValue ||
                    SegmentBottomVerticalCoordinateValue != null &&
                    SegmentBottomVerticalCoordinateValue.SequenceEqual(other.SegmentBottomVerticalCoordinateValue)
                ) && 
                (
                    SegmentLeftHorizontalCoordinateValue == other.SegmentLeftHorizontalCoordinateValue ||
                    SegmentLeftHorizontalCoordinateValue != null &&
                    SegmentLeftHorizontalCoordinateValue.SequenceEqual(other.SegmentLeftHorizontalCoordinateValue)
                ) && 
                (
                    SegmentRightHorizontalCoordinateValue == other.SegmentRightHorizontalCoordinateValue ||
                    SegmentRightHorizontalCoordinateValue != null &&
                    SegmentRightHorizontalCoordinateValue.SequenceEqual(other.SegmentRightHorizontalCoordinateValue)
                ) && 
                (
                    SegmentTopVerticalCoordinateValue == other.SegmentTopVerticalCoordinateValue ||
                    SegmentTopVerticalCoordinateValue != null &&
                    SegmentTopVerticalCoordinateValue.SequenceEqual(other.SegmentTopVerticalCoordinateValue)
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
                    if (FingerPositionCode != null)
                    hashCode = hashCode * 59 + FingerPositionCode.GetHashCode();
                    if (PalmPositionCode != null)
                    hashCode = hashCode * 59 + PalmPositionCode.GetHashCode();
                    if (PlantarPositionCode != null)
                    hashCode = hashCode * 59 + PlantarPositionCode.GetHashCode();
                    if (SegmentBottomVerticalCoordinateValue != null)
                    hashCode = hashCode * 59 + SegmentBottomVerticalCoordinateValue.GetHashCode();
                    if (SegmentLeftHorizontalCoordinateValue != null)
                    hashCode = hashCode * 59 + SegmentLeftHorizontalCoordinateValue.GetHashCode();
                    if (SegmentRightHorizontalCoordinateValue != null)
                    hashCode = hashCode * 59 + SegmentRightHorizontalCoordinateValue.GetHashCode();
                    if (SegmentTopVerticalCoordinateValue != null)
                    hashCode = hashCode * 59 + SegmentTopVerticalCoordinateValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFrictionRidgeImageSegmentPositionSquareType left, BiomFrictionRidgeImageSegmentPositionSquareType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFrictionRidgeImageSegmentPositionSquareType left, BiomFrictionRidgeImageSegmentPositionSquareType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}