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
    /// A data type for a blockage in a face image
    /// </summary>
    [DataContract]
    public partial class BiomFaceImageOcclusionType : IEquatable<BiomFaceImageOcclusionType>
    { 
        /// <summary>
        /// A level of opacity of a blockage in this face image NIEM reference is biom:FaceImageOcclusionOpacityCode
        /// </summary>
        /// <value>A level of opacity of a blockage in this face image NIEM reference is biom:FaceImageOcclusionOpacityCode</value>

        [DataMember(Name="opacityCode")]
        public List<BiomImageOcclusionOpacityCodeType> OpacityCode { get; set; }

        /// <summary>
        /// A kind of a blockage in a face image NIEM reference is biom:FaceImageOcclusionCategoryCode
        /// </summary>
        /// <value>A kind of a blockage in a face image NIEM reference is biom:FaceImageOcclusionCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<BiomImageOcclusionCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// A number of vertices in a position polygon NIEM reference is biom:PositionPolygonVertexQuantity
        /// </summary>
        /// <value>A number of vertices in a position polygon NIEM reference is biom:PositionPolygonVertexQuantity</value>

        [DataMember(Name="positionPolygonVertexQuantity")]
        public List<BiomImageFeatureVertexQuantityType> PositionPolygonVertexQuantity { get; set; }

        /// <summary>
        /// A vertex in a position polygon NIEM reference is biom:PositionPolygonVertex
        /// </summary>
        /// <value>A vertex in a position polygon NIEM reference is biom:PositionPolygonVertex</value>

        [DataMember(Name="positionPolygonVertex")]
        public List<BiomVertexType> PositionPolygonVertex { get; set; }

        /// <summary>
        /// biomFaceImageOcclusionType JSON-LD context
        /// </summary>
        /// <value>biomFaceImageOcclusionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFaceImageOcclusionTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFaceImageOcclusionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFaceImageOcclusionTypeContext.jsonld")]
            JSONLDContextsbiomFaceImageOcclusionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFaceImageOcclusionType JSON-LD context
        /// </summary>
        /// <value>biomFaceImageOcclusionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFaceImageOcclusionType {\n");
            sb.Append("  OpacityCode: ").Append(OpacityCode).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  PositionPolygonVertexQuantity: ").Append(PositionPolygonVertexQuantity).Append("\n");
            sb.Append("  PositionPolygonVertex: ").Append(PositionPolygonVertex).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFaceImageOcclusionType)obj);
        }

        /// <summary>
        /// Returns true if BiomFaceImageOcclusionType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFaceImageOcclusionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFaceImageOcclusionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OpacityCode == other.OpacityCode ||
                    OpacityCode != null &&
                    OpacityCode.SequenceEqual(other.OpacityCode)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    PositionPolygonVertexQuantity == other.PositionPolygonVertexQuantity ||
                    PositionPolygonVertexQuantity != null &&
                    PositionPolygonVertexQuantity.SequenceEqual(other.PositionPolygonVertexQuantity)
                ) && 
                (
                    PositionPolygonVertex == other.PositionPolygonVertex ||
                    PositionPolygonVertex != null &&
                    PositionPolygonVertex.SequenceEqual(other.PositionPolygonVertex)
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
                    if (OpacityCode != null)
                    hashCode = hashCode * 59 + OpacityCode.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (PositionPolygonVertexQuantity != null)
                    hashCode = hashCode * 59 + PositionPolygonVertexQuantity.GetHashCode();
                    if (PositionPolygonVertex != null)
                    hashCode = hashCode * 59 + PositionPolygonVertex.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFaceImageOcclusionType left, BiomFaceImageOcclusionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFaceImageOcclusionType left, BiomFaceImageOcclusionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
