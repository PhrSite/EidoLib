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
    /// A data type for a picture or visual representation of something.
    /// </summary>
    [DataContract]
    public partial class NcImageType : NcBinaryType, IEquatable<NcImageType>
    { 
        /// <summary>
        /// A height of an image in pixels. NIEM reference is nc:ImageHeightValue
        /// </summary>
        /// <value>A height of an image in pixels. NIEM reference is nc:ImageHeightValue</value>

        [DataMember(Name="heightValue")]
        public List<NiemXsnonNegativeInteger> HeightValue { get; set; }

        /// <summary>
        /// A physical location where an image is stored. NIEM reference is nc:ImageLocation
        /// </summary>
        /// <value>A physical location where an image is stored. NIEM reference is nc:ImageLocation</value>

        [DataMember(Name="location")]
        public List<NcLocationType> Location { get; set; }

        /// <summary>
        /// A width of an image in pixels. NIEM reference is nc:ImageWidthValue
        /// </summary>
        /// <value>A width of an image in pixels. NIEM reference is nc:ImageWidthValue</value>

        [DataMember(Name="widthValue")]
        public List<NiemXsnonNegativeInteger> WidthValue { get; set; }

        /// <summary>
        /// Additional information about supplements Biometric Image and specifies the additional Image NIEM reference is biom:ImageAugmentation
        /// </summary>
        /// <value>Additional information about supplements Biometric Image and specifies the additional Image NIEM reference is biom:ImageAugmentation</value>

        [DataMember(Name="biomAugmentation")]
        public List<BiomImageAugmentationType> BiomAugmentation { get; set; }

        /// <summary>
        /// Additional information about an image. NIEM reference is j:ImageAugmentation
        /// </summary>
        /// <value>Additional information about an image. NIEM reference is j:ImageAugmentation</value>

        [DataMember(Name="jAugmentation")]
        public List<JImageAugmentationType> JAugmentation { get; set; }

        /// <summary>
        /// Additional information about an image NIEM reference is mo:ImageAugmentation
        /// </summary>
        /// <value>Additional information about an image NIEM reference is mo:ImageAugmentation</value>

        [DataMember(Name="moAugmentation")]
        public List<MoImageAugmentationType> MoAugmentation { get; set; }

        /// <summary>
        /// ncImageType JSON-LD context
        /// </summary>
        /// <value>ncImageType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncImageTypeContextJsonldEnum for ../JSON-LD_Contexts/ncImageTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncImageTypeContext.jsonld")]
            JSONLDContextsncImageTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncImageType JSON-LD context
        /// </summary>
        /// <value>ncImageType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcImageType {\n");
            sb.Append("  HeightValue: ").Append(HeightValue).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  WidthValue: ").Append(WidthValue).Append("\n");
            sb.Append("  BiomAugmentation: ").Append(BiomAugmentation).Append("\n");
            sb.Append("  JAugmentation: ").Append(JAugmentation).Append("\n");
            sb.Append("  MoAugmentation: ").Append(MoAugmentation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcImageType)obj);
        }

        /// <summary>
        /// Returns true if NcImageType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcImageType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcImageType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HeightValue == other.HeightValue ||
                    HeightValue != null &&
                    HeightValue.SequenceEqual(other.HeightValue)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.SequenceEqual(other.Location)
                ) && 
                (
                    WidthValue == other.WidthValue ||
                    WidthValue != null &&
                    WidthValue.SequenceEqual(other.WidthValue)
                ) && 
                (
                    BiomAugmentation == other.BiomAugmentation ||
                    BiomAugmentation != null &&
                    BiomAugmentation.SequenceEqual(other.BiomAugmentation)
                ) && 
                (
                    JAugmentation == other.JAugmentation ||
                    JAugmentation != null &&
                    JAugmentation.SequenceEqual(other.JAugmentation)
                ) && 
                (
                    MoAugmentation == other.MoAugmentation ||
                    MoAugmentation != null &&
                    MoAugmentation.SequenceEqual(other.MoAugmentation)
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
                    if (HeightValue != null)
                    hashCode = hashCode * 59 + HeightValue.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (WidthValue != null)
                    hashCode = hashCode * 59 + WidthValue.GetHashCode();
                    if (BiomAugmentation != null)
                    hashCode = hashCode * 59 + BiomAugmentation.GetHashCode();
                    if (JAugmentation != null)
                    hashCode = hashCode * 59 + JAugmentation.GetHashCode();
                    if (MoAugmentation != null)
                    hashCode = hashCode * 59 + MoAugmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcImageType left, NcImageType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcImageType left, NcImageType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}