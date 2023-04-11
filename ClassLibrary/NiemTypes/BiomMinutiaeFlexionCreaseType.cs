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
    /// A data type for a permanent flexion crease
    /// </summary>
    [DataContract]
    public partial class BiomMinutiaeFlexionCreaseType : IEquatable<BiomMinutiaeFlexionCreaseType>
    { 
        /// <summary>
        /// A vertex in a position path NIEM reference is biom:ImageFeatureVertex
        /// </summary>
        /// <value>A vertex in a position path NIEM reference is biom:ImageFeatureVertex</value>

        [DataMember(Name="imageFeatureVertex")]
        public List<BiomVertexType> ImageFeatureVertex { get; set; }

        /// <summary>
        /// A kind of flexion crease NIEM reference is biom:MinutiaeFlexionCreaseCategoryCode
        /// </summary>
        /// <value>A kind of flexion crease NIEM reference is biom:MinutiaeFlexionCreaseCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<BiomMinutiaeFlexionCreaseCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// biomMinutiaeFlexionCreaseType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeFlexionCreaseType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomMinutiaeFlexionCreaseTypeContextJsonldEnum for ../JSON-LD_Contexts/biomMinutiaeFlexionCreaseTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomMinutiaeFlexionCreaseTypeContext.jsonld")]
            JSONLDContextsbiomMinutiaeFlexionCreaseTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomMinutiaeFlexionCreaseType JSON-LD context
        /// </summary>
        /// <value>biomMinutiaeFlexionCreaseType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomMinutiaeFlexionCreaseType {\n");
            sb.Append("  ImageFeatureVertex: ").Append(ImageFeatureVertex).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomMinutiaeFlexionCreaseType)obj);
        }

        /// <summary>
        /// Returns true if BiomMinutiaeFlexionCreaseType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomMinutiaeFlexionCreaseType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomMinutiaeFlexionCreaseType other)
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
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
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
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomMinutiaeFlexionCreaseType left, BiomMinutiaeFlexionCreaseType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomMinutiaeFlexionCreaseType left, BiomMinutiaeFlexionCreaseType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}