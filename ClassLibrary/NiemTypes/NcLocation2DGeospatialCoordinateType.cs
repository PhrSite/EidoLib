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
    /// A data type for a location identified by latitude and longitude.
    /// </summary>
    [DataContract]
    public partial class NcLocation2DGeospatialCoordinateType : IEquatable<NcLocation2DGeospatialCoordinateType>
    { 
        /// <summary>
        /// Gets or Sets GeodeticDatumCoordinateSystemCode
        /// </summary>

        [DataMember(Name="geodeticDatumCoordinateSystemCode")]
        public BiomGeodeticDatumCoordinateSystemCodeType GeodeticDatumCoordinateSystemCode { get; set; }

        /// <summary>
        /// Gets or Sets GeographicDatum
        /// </summary>

        [DataMember(Name="geographicDatum")]
        public NcTextType GeographicDatum { get; set; }

        /// <summary>
        /// Gets or Sets GeographicCoordinateLatitude
        /// </summary>

        [DataMember(Name="geographicCoordinateLatitude")]
        public NcLatitudeCoordinateType GeographicCoordinateLatitude { get; set; }

        /// <summary>
        /// Gets or Sets GeographicCoordinateLongitude
        /// </summary>

        [DataMember(Name="geographicCoordinateLongitude")]
        public NcLongitudeCoordinateType GeographicCoordinateLongitude { get; set; }

        /// <summary>
        /// ncLocation2DGeospatialCoordinateType JSON-LD context
        /// </summary>
        /// <value>ncLocation2DGeospatialCoordinateType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncLocation2DGeospatialCoordinateTypeContextJsonldEnum for ../JSON-LD_Contexts/ncLocation2DGeospatialCoordinateTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncLocation2DGeospatialCoordinateTypeContext.jsonld")]
            JSONLDContextsncLocation2DGeospatialCoordinateTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncLocation2DGeospatialCoordinateType JSON-LD context
        /// </summary>
        /// <value>ncLocation2DGeospatialCoordinateType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcLocation2DGeospatialCoordinateType {\n");
            sb.Append("  GeodeticDatumCoordinateSystemCode: ").Append(GeodeticDatumCoordinateSystemCode).Append("\n");
            sb.Append("  GeographicDatum: ").Append(GeographicDatum).Append("\n");
            sb.Append("  GeographicCoordinateLatitude: ").Append(GeographicCoordinateLatitude).Append("\n");
            sb.Append("  GeographicCoordinateLongitude: ").Append(GeographicCoordinateLongitude).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcLocation2DGeospatialCoordinateType)obj);
        }

        /// <summary>
        /// Returns true if NcLocation2DGeospatialCoordinateType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcLocation2DGeospatialCoordinateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcLocation2DGeospatialCoordinateType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    GeodeticDatumCoordinateSystemCode == other.GeodeticDatumCoordinateSystemCode ||
                    GeodeticDatumCoordinateSystemCode != null &&
                    GeodeticDatumCoordinateSystemCode.Equals(other.GeodeticDatumCoordinateSystemCode)
                ) && 
                (
                    GeographicDatum == other.GeographicDatum ||
                    GeographicDatum != null &&
                    GeographicDatum.Equals(other.GeographicDatum)
                ) && 
                (
                    GeographicCoordinateLatitude == other.GeographicCoordinateLatitude ||
                    GeographicCoordinateLatitude != null &&
                    GeographicCoordinateLatitude.Equals(other.GeographicCoordinateLatitude)
                ) && 
                (
                    GeographicCoordinateLongitude == other.GeographicCoordinateLongitude ||
                    GeographicCoordinateLongitude != null &&
                    GeographicCoordinateLongitude.Equals(other.GeographicCoordinateLongitude)
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
                    if (GeodeticDatumCoordinateSystemCode != null)
                    hashCode = hashCode * 59 + GeodeticDatumCoordinateSystemCode.GetHashCode();
                    if (GeographicDatum != null)
                    hashCode = hashCode * 59 + GeographicDatum.GetHashCode();
                    if (GeographicCoordinateLatitude != null)
                    hashCode = hashCode * 59 + GeographicCoordinateLatitude.GetHashCode();
                    if (GeographicCoordinateLongitude != null)
                    hashCode = hashCode * 59 + GeographicCoordinateLongitude.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcLocation2DGeospatialCoordinateType left, NcLocation2DGeospatialCoordinateType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcLocation2DGeospatialCoordinateType left, NcLocation2DGeospatialCoordinateType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
