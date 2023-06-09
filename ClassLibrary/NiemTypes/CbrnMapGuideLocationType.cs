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
    /// A data type for location information based on a Guide map published by a vendor.
    /// </summary>
    [DataContract]
    public partial class CbrnMapGuideLocationType : CbrnRemarksComplexObjectType, IEquatable<CbrnMapGuideLocationType>
    { 
        /// <summary>
        /// A code for the Brand name of a Map Guide document that provides maps of a locale with a vendor-unique grid reference system. NIEM reference is cbrn:MapGuideBrandCode
        /// </summary>
        /// <value>A code for the Brand name of a Map Guide document that provides maps of a locale with a vendor-unique grid reference system. NIEM reference is cbrn:MapGuideBrandCode</value>

        [DataMember(Name="mapGuideBrandCode")]
        public List<CbrnclMapGuideBrandCodeType> MapGuideBrandCode { get; set; }

        /// <summary>
        /// A Name of a Map Guide document providing maps of a locale. NIEM reference is cbrn:MapGuideName
        /// </summary>
        /// <value>A Name of a Map Guide document providing maps of a locale. NIEM reference is cbrn:MapGuideName</value>

        [DataMember(Name="mapGuideName")]
        public List<NcTextType> MapGuideName { get; set; }

        /// <summary>
        /// An identifier that refers to a page in a Map Guide document. NIEM reference is cbrn:MapGuidePageNumberID
        /// </summary>
        /// <value>An identifier that refers to a page in a Map Guide document. NIEM reference is cbrn:MapGuidePageNumberID</value>

        [DataMember(Name="mapGuidePageNumberId")]
        public List<NiemXsstring> MapGuidePageNumberId { get; set; }

        /// <summary>
        /// An identifier that refers to a map grid in a Map Guide document NIEM reference is cbrn:MapGuideGridNumberID
        /// </summary>
        /// <value>An identifier that refers to a map grid in a Map Guide document NIEM reference is cbrn:MapGuideGridNumberID</value>

        [DataMember(Name="mapGuideGridNumberId")]
        public List<NiemXsstring> MapGuideGridNumberId { get; set; }

        /// <summary>
        /// cbrnMapGuideLocationType JSON-LD context
        /// </summary>
        /// <value>cbrnMapGuideLocationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextscbrnMapGuideLocationTypeContextJsonldEnum for ../JSON-LD_Contexts/cbrnMapGuideLocationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/cbrnMapGuideLocationTypeContext.jsonld")]
            JSONLDContextscbrnMapGuideLocationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// cbrnMapGuideLocationType JSON-LD context
        /// </summary>
        /// <value>cbrnMapGuideLocationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbrnMapGuideLocationType {\n");
            sb.Append("  MapGuideBrandCode: ").Append(MapGuideBrandCode).Append("\n");
            sb.Append("  MapGuideName: ").Append(MapGuideName).Append("\n");
            sb.Append("  MapGuidePageNumberId: ").Append(MapGuidePageNumberId).Append("\n");
            sb.Append("  MapGuideGridNumberId: ").Append(MapGuideGridNumberId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CbrnMapGuideLocationType)obj);
        }

        /// <summary>
        /// Returns true if CbrnMapGuideLocationType instances are equal
        /// </summary>
        /// <param name="other">Instance of CbrnMapGuideLocationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CbrnMapGuideLocationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MapGuideBrandCode == other.MapGuideBrandCode ||
                    MapGuideBrandCode != null &&
                    MapGuideBrandCode.SequenceEqual(other.MapGuideBrandCode)
                ) && 
                (
                    MapGuideName == other.MapGuideName ||
                    MapGuideName != null &&
                    MapGuideName.SequenceEqual(other.MapGuideName)
                ) && 
                (
                    MapGuidePageNumberId == other.MapGuidePageNumberId ||
                    MapGuidePageNumberId != null &&
                    MapGuidePageNumberId.SequenceEqual(other.MapGuidePageNumberId)
                ) && 
                (
                    MapGuideGridNumberId == other.MapGuideGridNumberId ||
                    MapGuideGridNumberId != null &&
                    MapGuideGridNumberId.SequenceEqual(other.MapGuideGridNumberId)
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
                    if (MapGuideBrandCode != null)
                    hashCode = hashCode * 59 + MapGuideBrandCode.GetHashCode();
                    if (MapGuideName != null)
                    hashCode = hashCode * 59 + MapGuideName.GetHashCode();
                    if (MapGuidePageNumberId != null)
                    hashCode = hashCode * 59 + MapGuidePageNumberId.GetHashCode();
                    if (MapGuideGridNumberId != null)
                    hashCode = hashCode * 59 + MapGuideGridNumberId.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CbrnMapGuideLocationType left, CbrnMapGuideLocationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CbrnMapGuideLocationType left, CbrnMapGuideLocationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
