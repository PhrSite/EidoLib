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
    /// A data type for a delta in a friction ridge image
    /// </summary>
    [DataContract]
    public partial class BiomMinutiaeDeltaType : IEquatable<BiomMinutiaeDeltaType>
    { 
        /// <summary>
        /// A vertex in a position path NIEM reference is biom:ImageFeatureVertex
        /// </summary>
        /// <value>A vertex in a position path NIEM reference is biom:ImageFeatureVertex</value>

        [DataMember(Name="imageFeatureVertex")]
        public List<BiomVertexType> ImageFeatureVertex { get; set; }

        /// <summary>
        /// An up direction of a delta NIEM reference is biom:MinutiaeDeltaDirectionUpMeasure
        /// </summary>
        /// <value>An up direction of a delta NIEM reference is biom:MinutiaeDeltaDirectionUpMeasure</value>

        [DataMember(Name="directionUpMeasure")]
        public List<BiomDeltaDirectionMeasureType> DirectionUpMeasure { get; set; }

        /// <summary>
        /// A left direction of a delta NIEM reference is biom:MinutiaeDeltaDirectionLeftMeasure
        /// </summary>
        /// <value>A left direction of a delta NIEM reference is biom:MinutiaeDeltaDirectionLeftMeasure</value>

        [DataMember(Name="directionLeftMeasure")]
        public List<BiomDeltaDirectionMeasureType> DirectionLeftMeasure { get; set; }

        /// <summary>
        /// A right direction of a delta NIEM reference is biom:MinutiaeDeltaDirectionRightMeasure
        /// </summary>
        /// <value>A right direction of a delta NIEM reference is biom:MinutiaeDeltaDirectionRightMeasure</value>

        [DataMember(Name="directionRightMeasure")]
        public List<BiomDeltaDirectionMeasureType> DirectionRightMeasure { get; set; }

        /// <summary>
        /// A kind of delta NIEM reference is biom:MinutiaeDeltaCategoryCode
        /// </summary>
        /// <value>A kind of delta NIEM reference is biom:MinutiaeDeltaCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<BiomMinutiaeDeltaCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// A distance in 10 micrometer units (0.01mm) from a particular X,Ycoordinate NIEM reference is biom:ImageLocationUncertaintyRadiusMeasure
        /// </summary>
        /// <value>A distance in 10 micrometer units (0.01mm) from a particular X,Ycoordinate NIEM reference is biom:ImageLocationUncertaintyRadiusMeasure</value>

        [DataMember(Name="imageLocationUncertaintyRadiusMeasure")]
        public List<BiomInteger0to999Type> ImageLocationUncertaintyRadiusMeasure { get; set; }

        /// <summary>
        /// A value indicating the uncertainty of the delta up direction measure NIEM reference is biom:MinutiaeDeltaDirectionUpUncertaintyValue
        /// </summary>
        /// <value>A value indicating the uncertainty of the delta up direction measure NIEM reference is biom:MinutiaeDeltaDirectionUpUncertaintyValue</value>

        [DataMember(Name="directionUpUncertaintyValue")]
        public List<BiomUncertaintyValueType> DirectionUpUncertaintyValue { get; set; }

        /// <summary>
        /// A value indicating the uncertainty of the delta left direction measure NIEM reference is biom:MinutiaeDeltaDirectionLeftUncertaintyValue
        /// </summary>
        /// <value>A value indicating the uncertainty of the delta left direction measure NIEM reference is biom:MinutiaeDeltaDirectionLeftUncertaintyValue</value>

        [DataMember(Name="directionLeftUncertaintyValue")]
        public List<BiomUncertaintyValueType> DirectionLeftUncertaintyValue { get; set; }

        /// <summary>
        /// A value indicating the uncertainty of the delta right direction measure NIEM reference is biom:MinutiaeDeltaDirectionRightUncertaintyValue
        /// </summary>
        /// <value>A value indicating the uncertainty of the delta right direction measure NIEM reference is biom:MinutiaeDeltaDirectionRightUncertaintyValue</value>

        [DataMember(Name="directionRightUncertaintyValue")]
        public List<BiomUncertaintyValueType> DirectionRightUncertaintyValue { get; set; }

        /// <summary>
        /// biomMinutiaeDeltaType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeDeltaType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomMinutiaeDeltaTypeContextJsonldEnum for ../JSON-LD_Contexts/biomMinutiaeDeltaTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomMinutiaeDeltaTypeContext.jsonld")]
            JSONLDContextsbiomMinutiaeDeltaTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomMinutiaeDeltaType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeDeltaType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomMinutiaeDeltaType {\n");
            sb.Append("  ImageFeatureVertex: ").Append(ImageFeatureVertex).Append("\n");
            sb.Append("  DirectionUpMeasure: ").Append(DirectionUpMeasure).Append("\n");
            sb.Append("  DirectionLeftMeasure: ").Append(DirectionLeftMeasure).Append("\n");
            sb.Append("  DirectionRightMeasure: ").Append(DirectionRightMeasure).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  ImageLocationUncertaintyRadiusMeasure: ").Append(ImageLocationUncertaintyRadiusMeasure).Append("\n");
            sb.Append("  DirectionUpUncertaintyValue: ").Append(DirectionUpUncertaintyValue).Append("\n");
            sb.Append("  DirectionLeftUncertaintyValue: ").Append(DirectionLeftUncertaintyValue).Append("\n");
            sb.Append("  DirectionRightUncertaintyValue: ").Append(DirectionRightUncertaintyValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomMinutiaeDeltaType)obj);
        }

        /// <summary>
        /// Returns true if BiomMinutiaeDeltaType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomMinutiaeDeltaType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomMinutiaeDeltaType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ImageFeatureVertex == other.ImageFeatureVertex ||
                    ImageFeatureVertex != null &&
                    ImageFeatureVertex.SequenceEqual(other.ImageFeatureVertex)
                ) && 
                (
                    DirectionUpMeasure == other.DirectionUpMeasure ||
                    DirectionUpMeasure != null &&
                    DirectionUpMeasure.SequenceEqual(other.DirectionUpMeasure)
                ) && 
                (
                    DirectionLeftMeasure == other.DirectionLeftMeasure ||
                    DirectionLeftMeasure != null &&
                    DirectionLeftMeasure.SequenceEqual(other.DirectionLeftMeasure)
                ) && 
                (
                    DirectionRightMeasure == other.DirectionRightMeasure ||
                    DirectionRightMeasure != null &&
                    DirectionRightMeasure.SequenceEqual(other.DirectionRightMeasure)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    ImageLocationUncertaintyRadiusMeasure == other.ImageLocationUncertaintyRadiusMeasure ||
                    ImageLocationUncertaintyRadiusMeasure != null &&
                    ImageLocationUncertaintyRadiusMeasure.SequenceEqual(other.ImageLocationUncertaintyRadiusMeasure)
                ) && 
                (
                    DirectionUpUncertaintyValue == other.DirectionUpUncertaintyValue ||
                    DirectionUpUncertaintyValue != null &&
                    DirectionUpUncertaintyValue.SequenceEqual(other.DirectionUpUncertaintyValue)
                ) && 
                (
                    DirectionLeftUncertaintyValue == other.DirectionLeftUncertaintyValue ||
                    DirectionLeftUncertaintyValue != null &&
                    DirectionLeftUncertaintyValue.SequenceEqual(other.DirectionLeftUncertaintyValue)
                ) && 
                (
                    DirectionRightUncertaintyValue == other.DirectionRightUncertaintyValue ||
                    DirectionRightUncertaintyValue != null &&
                    DirectionRightUncertaintyValue.SequenceEqual(other.DirectionRightUncertaintyValue)
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
                    if (ImageFeatureVertex != null)
                    hashCode = hashCode * 59 + ImageFeatureVertex.GetHashCode();
                    if (DirectionUpMeasure != null)
                    hashCode = hashCode * 59 + DirectionUpMeasure.GetHashCode();
                    if (DirectionLeftMeasure != null)
                    hashCode = hashCode * 59 + DirectionLeftMeasure.GetHashCode();
                    if (DirectionRightMeasure != null)
                    hashCode = hashCode * 59 + DirectionRightMeasure.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (ImageLocationUncertaintyRadiusMeasure != null)
                    hashCode = hashCode * 59 + ImageLocationUncertaintyRadiusMeasure.GetHashCode();
                    if (DirectionUpUncertaintyValue != null)
                    hashCode = hashCode * 59 + DirectionUpUncertaintyValue.GetHashCode();
                    if (DirectionLeftUncertaintyValue != null)
                    hashCode = hashCode * 59 + DirectionLeftUncertaintyValue.GetHashCode();
                    if (DirectionRightUncertaintyValue != null)
                    hashCode = hashCode * 59 + DirectionRightUncertaintyValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomMinutiaeDeltaType left, BiomMinutiaeDeltaType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomMinutiaeDeltaType left, BiomMinutiaeDeltaType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
