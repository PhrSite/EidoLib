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
    /// A data type that enables a latent print examiner to annotate individual features with color for display and / or comment. It consists of multiple subfields, each containing four information items.
    /// </summary>
    [DataContract]
    public partial class BiomEFSFeatureColorType : IEquatable<BiomEFSFeatureColorType>
    { 
        /// <summary>
        /// A data for one or both of the third or fourth information items shall be present in each subfield. The first two information items are mandatory. The first information item, feature - field number / FTF, indicates the field which is annotated with c NIEM reference is biom:FeatureColorFieldReferencedCode
        /// </summary>
        /// <value>A data for one or both of the third or fourth information items shall be present in each subfield. The first two information items are mandatory. The first information item, feature - field number / FTF, indicates the field which is annotated with c NIEM reference is biom:FeatureColorFieldReferencedCode</value>

        [DataMember(Name="featureColorFieldReferencedCode")]
        public List<BiomEFSFieldNumberCodeType> FeatureColorFieldReferencedCode { get; set; }

        /// <summary>
        /// A second information item, feature _ field occurrence / FTO, indicates which repeating subfield of the specified field the label is applied to. Note that this is a 1-based index, not a 0-based index. Occurrences are numbered starting with 1. NIEM reference is biom:FeatureColorFieldOccurenceReferencedValue
        /// </summary>
        /// <value>A second information item, feature _ field occurrence / FTO, indicates which repeating subfield of the specified field the label is applied to. Note that this is a 1-based index, not a 0-based index. Occurrences are numbered starting with 1. NIEM reference is biom:FeatureColorFieldOccurenceReferencedValue</value>

        [DataMember(Name="featureColorFieldOccurenceReferencedValue")]
        public List<NiemXspositiveInteger> FeatureColorFieldOccurenceReferencedValue { get; set; }

        /// <summary>
        /// A third information item, feature _ color / FTC, is an RGB color value expressed as a hexadecimal number.Some basic colors are red (FF0000), yellow (FFFF00), blue (0000FF), green (008000), black (000000) and white (FFFFFF). Leading zeros are require NIEM reference is biom:FeatureColorHexidecimalValue
        /// </summary>
        /// <value>A third information item, feature _ color / FTC, is an RGB color value expressed as a hexadecimal number.Some basic colors are red (FF0000), yellow (FFFF00), blue (0000FF), green (008000), black (000000) and white (FFFFFF). Leading zeros are require NIEM reference is biom:FeatureColorHexidecimalValue</value>

        [DataMember(Name="featureColorHexidecimalValue")]
        public List<BiomHexTripleByteType> FeatureColorHexidecimalValue { get; set; }

        /// <summary>
        /// A fourth information item, feature _ comment / COM, allows a free text comment or description to be provided by the examiner about the referenced field and subfield in this instance of a Type-9 record. NIEM reference is biom:FeatureColorCommentText
        /// </summary>
        /// <value>A fourth information item, feature _ comment / COM, allows a free text comment or description to be provided by the examiner about the referenced field and subfield in this instance of a Type-9 record. NIEM reference is biom:FeatureColorCommentText</value>

        [DataMember(Name="featureColorComment")]
        public List<NcTextType> FeatureColorComment { get; set; }

        /// <summary>
        /// biomEFSFeatureColorType JSON-LD context
        /// </summary>
        /// <value>biomEFSFeatureColorType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomEFSFeatureColorTypeContextJsonldEnum for ../JSON-LD_Contexts/biomEFSFeatureColorTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomEFSFeatureColorTypeContext.jsonld")]
            JSONLDContextsbiomEFSFeatureColorTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomEFSFeatureColorType JSON-LD context
        /// </summary>
        /// <value>biomEFSFeatureColorType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomEFSFeatureColorType {\n");
            sb.Append("  FeatureColorFieldReferencedCode: ").Append(FeatureColorFieldReferencedCode).Append("\n");
            sb.Append("  FeatureColorFieldOccurenceReferencedValue: ").Append(FeatureColorFieldOccurenceReferencedValue).Append("\n");
            sb.Append("  FeatureColorHexidecimalValue: ").Append(FeatureColorHexidecimalValue).Append("\n");
            sb.Append("  FeatureColorComment: ").Append(FeatureColorComment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomEFSFeatureColorType)obj);
        }

        /// <summary>
        /// Returns true if BiomEFSFeatureColorType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomEFSFeatureColorType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomEFSFeatureColorType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FeatureColorFieldReferencedCode == other.FeatureColorFieldReferencedCode ||
                    FeatureColorFieldReferencedCode != null &&
                    FeatureColorFieldReferencedCode.SequenceEqual(other.FeatureColorFieldReferencedCode)
                ) && 
                (
                    FeatureColorFieldOccurenceReferencedValue == other.FeatureColorFieldOccurenceReferencedValue ||
                    FeatureColorFieldOccurenceReferencedValue != null &&
                    FeatureColorFieldOccurenceReferencedValue.SequenceEqual(other.FeatureColorFieldOccurenceReferencedValue)
                ) && 
                (
                    FeatureColorHexidecimalValue == other.FeatureColorHexidecimalValue ||
                    FeatureColorHexidecimalValue != null &&
                    FeatureColorHexidecimalValue.SequenceEqual(other.FeatureColorHexidecimalValue)
                ) && 
                (
                    FeatureColorComment == other.FeatureColorComment ||
                    FeatureColorComment != null &&
                    FeatureColorComment.SequenceEqual(other.FeatureColorComment)
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
                    if (FeatureColorFieldReferencedCode != null)
                    hashCode = hashCode * 59 + FeatureColorFieldReferencedCode.GetHashCode();
                    if (FeatureColorFieldOccurenceReferencedValue != null)
                    hashCode = hashCode * 59 + FeatureColorFieldOccurenceReferencedValue.GetHashCode();
                    if (FeatureColorHexidecimalValue != null)
                    hashCode = hashCode * 59 + FeatureColorHexidecimalValue.GetHashCode();
                    if (FeatureColorComment != null)
                    hashCode = hashCode * 59 + FeatureColorComment.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomEFSFeatureColorType left, BiomEFSFeatureColorType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomEFSFeatureColorType left, BiomEFSFeatureColorType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
