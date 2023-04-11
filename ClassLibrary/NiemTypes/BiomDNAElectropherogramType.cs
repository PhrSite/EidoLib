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
    /// A data type for a DNA electropherogram
    /// </summary>
    [DataContract]
    public partial class BiomDNAElectropherogramType : IEquatable<BiomDNAElectropherogramType>
    { 
        /// <summary>
        /// An identifier for a DNA electropherogram image NIEM reference is biom:DNAElectropherogramID
        /// </summary>
        /// <value>An identifier for a DNA electropherogram image NIEM reference is biom:DNAElectropherogramID</value>

        [DataMember(Name="dnaElectropherogramId")]
        public List<NcTextType> DnaElectropherogramId { get; set; }

        /// <summary>
        /// A kind of file type suffix for a DNA electropherogram NIEM reference is biom:DNAElectropherogramFileStorageText
        /// </summary>
        /// <value>A kind of file type suffix for a DNA electropherogram NIEM reference is biom:DNAElectropherogramFileStorageText</value>

        [DataMember(Name="fileStorage")]
        public List<NcTextType> FileStorage { get; set; }

        /// <summary>
        /// A description of DNA electropherogram data, or a filename if data is stored externally NIEM reference is biom:DNAElectropherogramDataDescriptionText
        /// </summary>
        /// <value>A description of DNA electropherogram data, or a filename if data is stored externally NIEM reference is biom:DNAElectropherogramDataDescriptionText</value>

        [DataMember(Name="dataDescription")]
        public List<NcTextType> DataDescription { get; set; }

        /// <summary>
        /// A base-64 representation of a DNA electropherogram NIEM reference is biom:DNAElectropherogramBinaryObject
        /// </summary>
        /// <value>A base-64 representation of a DNA electropherogram NIEM reference is biom:DNAElectropherogramBinaryObject</value>

        [DataMember(Name="binaryObject")]
        public List<NiemXsbase64Binary> BinaryObject { get; set; }

        /// <summary>
        /// An image of screenshot of a DNA electropherogram NIEM reference is biom:DNAElectropherogramScreenshotImage
        /// </summary>
        /// <value>An image of screenshot of a DNA electropherogram NIEM reference is biom:DNAElectropherogramScreenshotImage</value>

        [DataMember(Name="screenshotImage")]
        public List<BiomImageType> ScreenshotImage { get; set; }

        /// <summary>
        /// biomDNAElectropherogramType JSON-LD context
        /// </summary>
        /// <value>biomDNAElectropherogramType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomDNAElectropherogramTypeContextJsonldEnum for ../JSON-LD_Contexts/biomDNAElectropherogramTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomDNAElectropherogramTypeContext.jsonld")]
            JSONLDContextsbiomDNAElectropherogramTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomDNAElectropherogramType JSON-LD context
        /// </summary>
        /// <value>biomDNAElectropherogramType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomDNAElectropherogramType {\n");
            sb.Append("  DnaElectropherogramId: ").Append(DnaElectropherogramId).Append("\n");
            sb.Append("  FileStorage: ").Append(FileStorage).Append("\n");
            sb.Append("  DataDescription: ").Append(DataDescription).Append("\n");
            sb.Append("  BinaryObject: ").Append(BinaryObject).Append("\n");
            sb.Append("  ScreenshotImage: ").Append(ScreenshotImage).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomDNAElectropherogramType)obj);
        }

        /// <summary>
        /// Returns true if BiomDNAElectropherogramType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomDNAElectropherogramType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomDNAElectropherogramType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DnaElectropherogramId == other.DnaElectropherogramId ||
                    DnaElectropherogramId != null &&
                    DnaElectropherogramId.SequenceEqual(other.DnaElectropherogramId)
                ) && 
                (
                    FileStorage == other.FileStorage ||
                    FileStorage != null &&
                    FileStorage.SequenceEqual(other.FileStorage)
                ) && 
                (
                    DataDescription == other.DataDescription ||
                    DataDescription != null &&
                    DataDescription.SequenceEqual(other.DataDescription)
                ) && 
                (
                    BinaryObject == other.BinaryObject ||
                    BinaryObject != null &&
                    BinaryObject.SequenceEqual(other.BinaryObject)
                ) && 
                (
                    ScreenshotImage == other.ScreenshotImage ||
                    ScreenshotImage != null &&
                    ScreenshotImage.SequenceEqual(other.ScreenshotImage)
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
                    if (DnaElectropherogramId != null)
                    hashCode = hashCode * 59 + DnaElectropherogramId.GetHashCode();
                    if (FileStorage != null)
                    hashCode = hashCode * 59 + FileStorage.GetHashCode();
                    if (DataDescription != null)
                    hashCode = hashCode * 59 + DataDescription.GetHashCode();
                    if (BinaryObject != null)
                    hashCode = hashCode * 59 + BinaryObject.GetHashCode();
                    if (ScreenshotImage != null)
                    hashCode = hashCode * 59 + ScreenshotImage.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomDNAElectropherogramType left, BiomDNAElectropherogramType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomDNAElectropherogramType left, BiomDNAElectropherogramType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}