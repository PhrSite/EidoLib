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
    /// A data type for a relative overall rotation necessary for two prints to be compared
    /// </summary>
    [DataContract]
    public partial class BiomFrictionRidgeImageRelativeRotationType : IEquatable<BiomFrictionRidgeImageRelativeRotationType>
    { 
        /// <summary>
        /// An identification of a particular record in a transaction. (Obsolete, use ImageReferenceID) NIEM reference is biom:ImageReferenceIdentification
        /// </summary>
        /// <value>An identification of a particular record in a transaction. (Obsolete, use ImageReferenceID) NIEM reference is biom:ImageReferenceIdentification</value>

        [DataMember(Name="imageReferenceIdentification")]
        public List<NcIdentificationType> ImageReferenceIdentification { get; set; }

        /// <summary>
        /// An identifier for denoting (or indexing together) instances of a particular record in a transaction NIEM reference is biom:ImageReferenceID
        /// </summary>
        /// <value>An identifier for denoting (or indexing together) instances of a particular record in a transaction NIEM reference is biom:ImageReferenceID</value>

        [DataMember(Name="imageReferenceId")]
        public List<BiomInteger0to99Type> ImageReferenceId { get; set; }

        /// <summary>
        /// A measure of rotation of an image NIEM reference is biom:ImageRelativeOverallRotationValue
        /// </summary>
        /// <value>A measure of rotation of an image NIEM reference is biom:ImageRelativeOverallRotationValue</value>

        [DataMember(Name="imageRelativeOverallRotationValue")]
        public List<BiomRelativeRotationMeasureType> ImageRelativeOverallRotationValue { get; set; }

        /// <summary>
        /// biomFrictionRidgeImageRelativeRotationType JSON-LD context
        /// </summary>
        /// <value>biomFrictionRidgeImageRelativeRotationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomFrictionRidgeImageRelativeRotationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomFrictionRidgeImageRelativeRotationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomFrictionRidgeImageRelativeRotationTypeContext.jsonld")]
            JSONLDContextsbiomFrictionRidgeImageRelativeRotationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomFrictionRidgeImageRelativeRotationType JSON-LD context
        /// </summary>
        /// <value>biomFrictionRidgeImageRelativeRotationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomFrictionRidgeImageRelativeRotationType {\n");
            sb.Append("  ImageReferenceIdentification: ").Append(ImageReferenceIdentification).Append("\n");
            sb.Append("  ImageReferenceId: ").Append(ImageReferenceId).Append("\n");
            sb.Append("  ImageRelativeOverallRotationValue: ").Append(ImageRelativeOverallRotationValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomFrictionRidgeImageRelativeRotationType)obj);
        }

        /// <summary>
        /// Returns true if BiomFrictionRidgeImageRelativeRotationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomFrictionRidgeImageRelativeRotationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomFrictionRidgeImageRelativeRotationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ImageReferenceIdentification == other.ImageReferenceIdentification ||
                    ImageReferenceIdentification != null &&
                    ImageReferenceIdentification.SequenceEqual(other.ImageReferenceIdentification)
                ) && 
                (
                    ImageReferenceId == other.ImageReferenceId ||
                    ImageReferenceId != null &&
                    ImageReferenceId.SequenceEqual(other.ImageReferenceId)
                ) && 
                (
                    ImageRelativeOverallRotationValue == other.ImageRelativeOverallRotationValue ||
                    ImageRelativeOverallRotationValue != null &&
                    ImageRelativeOverallRotationValue.SequenceEqual(other.ImageRelativeOverallRotationValue)
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
                    if (ImageReferenceIdentification != null)
                    hashCode = hashCode * 59 + ImageReferenceIdentification.GetHashCode();
                    if (ImageReferenceId != null)
                    hashCode = hashCode * 59 + ImageReferenceId.GetHashCode();
                    if (ImageRelativeOverallRotationValue != null)
                    hashCode = hashCode * 59 + ImageRelativeOverallRotationValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomFrictionRidgeImageRelativeRotationType left, BiomFrictionRidgeImageRelativeRotationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomFrictionRidgeImageRelativeRotationType left, BiomFrictionRidgeImageRelativeRotationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}