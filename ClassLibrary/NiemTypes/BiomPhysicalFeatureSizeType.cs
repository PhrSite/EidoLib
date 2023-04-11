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
    /// A data type for a size of a physical feature
    /// </summary>
    [DataContract]
    public partial class BiomPhysicalFeatureSizeType : IEquatable<BiomPhysicalFeatureSizeType>
    { 
        /// <summary>
        /// A feature&#x27;s height in whole centimeters NIEM reference is biom:PhysicalFeatureHeightMeasure
        /// </summary>
        /// <value>A feature&#x27;s height in whole centimeters NIEM reference is biom:PhysicalFeatureHeightMeasure</value>

        [DataMember(Name="physicalFeatureHeightMeasure")]
        public List<NiemXspositiveInteger> PhysicalFeatureHeightMeasure { get; set; }

        /// <summary>
        /// A feature&#x27;s width in whole centimeters NIEM reference is biom:PhysicalFeatureWidthMeasure
        /// </summary>
        /// <value>A feature&#x27;s width in whole centimeters NIEM reference is biom:PhysicalFeatureWidthMeasure</value>

        [DataMember(Name="physicalFeatureWidthMeasure")]
        public List<NiemXspositiveInteger> PhysicalFeatureWidthMeasure { get; set; }

        /// <summary>
        /// biomPhysicalFeatureSizeType JSON-LD context
        /// </summary>
        /// <value>biomPhysicalFeatureSizeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomPhysicalFeatureSizeTypeContextJsonldEnum for ../JSON-LD_Contexts/biomPhysicalFeatureSizeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomPhysicalFeatureSizeTypeContext.jsonld")]
            JSONLDContextsbiomPhysicalFeatureSizeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomPhysicalFeatureSizeType JSON-LD context
        /// </summary>
        /// <value>biomPhysicalFeatureSizeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomPhysicalFeatureSizeType {\n");
            sb.Append("  PhysicalFeatureHeightMeasure: ").Append(PhysicalFeatureHeightMeasure).Append("\n");
            sb.Append("  PhysicalFeatureWidthMeasure: ").Append(PhysicalFeatureWidthMeasure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomPhysicalFeatureSizeType)obj);
        }

        /// <summary>
        /// Returns true if BiomPhysicalFeatureSizeType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomPhysicalFeatureSizeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomPhysicalFeatureSizeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PhysicalFeatureHeightMeasure == other.PhysicalFeatureHeightMeasure ||
                    PhysicalFeatureHeightMeasure != null &&
                    PhysicalFeatureHeightMeasure.SequenceEqual(other.PhysicalFeatureHeightMeasure)
                ) && 
                (
                    PhysicalFeatureWidthMeasure == other.PhysicalFeatureWidthMeasure ||
                    PhysicalFeatureWidthMeasure != null &&
                    PhysicalFeatureWidthMeasure.SequenceEqual(other.PhysicalFeatureWidthMeasure)
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
                    if (PhysicalFeatureHeightMeasure != null)
                    hashCode = hashCode * 59 + PhysicalFeatureHeightMeasure.GetHashCode();
                    if (PhysicalFeatureWidthMeasure != null)
                    hashCode = hashCode * 59 + PhysicalFeatureWidthMeasure.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomPhysicalFeatureSizeType left, BiomPhysicalFeatureSizeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomPhysicalFeatureSizeType left, BiomPhysicalFeatureSizeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
