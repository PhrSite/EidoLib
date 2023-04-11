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
    /// A data type for a core in a friction ridge image
    /// </summary>
    [DataContract]
    public partial class BiomMinutiaeCoreType : IEquatable<BiomMinutiaeCoreType>
    { 
        /// <summary>
        /// A vertex in a position path NIEM reference is biom:ImageFeatureVertex
        /// </summary>
        /// <value>A vertex in a position path NIEM reference is biom:ImageFeatureVertex</value>

        [DataMember(Name="imageFeatureVertex")]
        public List<BiomVertexType> ImageFeatureVertex { get; set; }

        /// <summary>
        /// An average tangent direction of the two closest ridges to the core NIEM reference is biom:MinutiaeCoreDirectionMeasure
        /// </summary>
        /// <value>An average tangent direction of the two closest ridges to the core NIEM reference is biom:MinutiaeCoreDirectionMeasure</value>

        [DataMember(Name="directionMeasure")]
        public List<BiomDirectionMeasureType> DirectionMeasure { get; set; }

        /// <summary>
        /// A distance in 10 micrometer units (0.01mm) from a particular X,Ycoordinate NIEM reference is biom:ImageLocationUncertaintyRadiusMeasure
        /// </summary>
        /// <value>A distance in 10 micrometer units (0.01mm) from a particular X,Ycoordinate NIEM reference is biom:ImageLocationUncertaintyRadiusMeasure</value>

        [DataMember(Name="imageLocationUncertaintyRadiusMeasure")]
        public List<BiomInteger0to999Type> ImageLocationUncertaintyRadiusMeasure { get; set; }

        /// <summary>
        /// A value indicating the uncertainty of the core direction measure NIEM reference is biom:MinutiaeCoreDirectionUncertaintyValue
        /// </summary>
        /// <value>A value indicating the uncertainty of the core direction measure NIEM reference is biom:MinutiaeCoreDirectionUncertaintyValue</value>

        [DataMember(Name="directionUncertaintyValue")]
        public List<BiomUncertaintyValueType> DirectionUncertaintyValue { get; set; }

        /// <summary>
        /// biomMinutiaeCoreType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeCoreType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomMinutiaeCoreTypeContextJsonldEnum for ../JSON-LD_Contexts/biomMinutiaeCoreTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomMinutiaeCoreTypeContext.jsonld")]
            JSONLDContextsbiomMinutiaeCoreTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomMinutiaeCoreType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeCoreType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomMinutiaeCoreType {\n");
            sb.Append("  ImageFeatureVertex: ").Append(ImageFeatureVertex).Append("\n");
            sb.Append("  DirectionMeasure: ").Append(DirectionMeasure).Append("\n");
            sb.Append("  ImageLocationUncertaintyRadiusMeasure: ").Append(ImageLocationUncertaintyRadiusMeasure).Append("\n");
            sb.Append("  DirectionUncertaintyValue: ").Append(DirectionUncertaintyValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomMinutiaeCoreType)obj);
        }

        /// <summary>
        /// Returns true if BiomMinutiaeCoreType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomMinutiaeCoreType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomMinutiaeCoreType other)
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
                    DirectionMeasure == other.DirectionMeasure ||
                    DirectionMeasure != null &&
                    DirectionMeasure.SequenceEqual(other.DirectionMeasure)
                ) && 
                (
                    ImageLocationUncertaintyRadiusMeasure == other.ImageLocationUncertaintyRadiusMeasure ||
                    ImageLocationUncertaintyRadiusMeasure != null &&
                    ImageLocationUncertaintyRadiusMeasure.SequenceEqual(other.ImageLocationUncertaintyRadiusMeasure)
                ) && 
                (
                    DirectionUncertaintyValue == other.DirectionUncertaintyValue ||
                    DirectionUncertaintyValue != null &&
                    DirectionUncertaintyValue.SequenceEqual(other.DirectionUncertaintyValue)
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
                    if (DirectionMeasure != null)
                    hashCode = hashCode * 59 + DirectionMeasure.GetHashCode();
                    if (ImageLocationUncertaintyRadiusMeasure != null)
                    hashCode = hashCode * 59 + ImageLocationUncertaintyRadiusMeasure.GetHashCode();
                    if (DirectionUncertaintyValue != null)
                    hashCode = hashCode * 59 + DirectionUncertaintyValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomMinutiaeCoreType left, BiomMinutiaeCoreType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomMinutiaeCoreType left, BiomMinutiaeCoreType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
