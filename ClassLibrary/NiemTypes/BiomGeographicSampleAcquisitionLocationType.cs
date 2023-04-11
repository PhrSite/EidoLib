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
    /// A data type to contain the location where the biometric sample/original source/context information was acquired.
    /// </summary>
    [DataContract]
    public partial class BiomGeographicSampleAcquisitionLocationType : IEquatable<BiomGeographicSampleAcquisitionLocationType>
    { 
        /// <summary>
        /// A UTC date and time for the capture of a biometric sample NIEM reference is biom:CaptureUTCDateTime
        /// </summary>
        /// <value>A UTC date and time for the capture of a biometric sample NIEM reference is biom:CaptureUTCDateTime</value>

        [DataMember(Name="captureUtcDateTime")]
        public List<NiemXsdateTime> CaptureUtcDateTime { get; set; }

        /// <summary>
        /// A location identified by latitude, longitude, and height. NIEM reference is nc:Location3DGeospatialCoordinate
        /// </summary>
        /// <value>A location identified by latitude, longitude, and height. NIEM reference is nc:Location3DGeospatialCoordinate</value>

        [DataMember(Name="location3DGeospatialCoordinate")]
        public List<NcLocation3DGeospatialCoordinateType> Location3DGeospatialCoordinate { get; set; }

        /// <summary>
        /// A coordinate from the Universal Transverse Mercator (UTM) Coordinate System, which represents a location with a hemisphere, zone, an easting value, and a northing value. NIEM reference is nc:LocationUTMCoordinateValue
        /// </summary>
        /// <value>A coordinate from the Universal Transverse Mercator (UTM) Coordinate System, which represents a location with a hemisphere, zone, an easting value, and a northing value. NIEM reference is nc:LocationUTMCoordinateValue</value>

        [DataMember(Name="locationUtmCoordinateValue")]
        public List<NcUTMCoordinateType> LocationUtmCoordinateValue { get; set; }

        /// <summary>
        /// A complete coordinate string from the Military Grid Reference System (MGRS) which represents a location with a Universal Transverse Mercator (UTM) or Univeral Polar Steriographic (UPS) coordinate and a unique military grid square. NIEM reference is mo:MGRSCoordinateStringText
        /// </summary>
        /// <value>A complete coordinate string from the Military Grid Reference System (MGRS) which represents a location with a Universal Transverse Mercator (UTM) or Univeral Polar Steriographic (UPS) coordinate and a unique military grid square. NIEM reference is mo:MGRSCoordinateStringText</value>

        [DataMember(Name="mgrsCoordinateString")]
        public List<MoMGRSCoordinateStringType> MgrsCoordinateString { get; set; }

        /// <summary>
        /// A geographic location NIEM reference is biom:GeographicLocationText
        /// </summary>
        /// <value>A geographic location NIEM reference is biom:GeographicLocationText</value>

        [DataMember(Name="geographicLocation")]
        public List<NcTextType> GeographicLocation { get; set; }

        /// <summary>
        /// A name of a geographic coordinate system NIEM reference is biom:GeographicLocationSystemName
        /// </summary>
        /// <value>A name of a geographic coordinate system NIEM reference is biom:GeographicLocationSystemName</value>

        [DataMember(Name="geographicLocationSystemName")]
        public List<NcTextType> GeographicLocationSystemName { get; set; }

        /// <summary>
        /// A description of a location. NIEM reference is nc:LocationDescriptionText
        /// </summary>
        /// <value>A description of a location. NIEM reference is nc:LocationDescriptionText</value>

        [DataMember(Name="locationDescription")]
        public List<NcTextType> LocationDescription { get; set; }

        /// <summary>
        /// biomGeographicSampleAcquisitionLocationType JSON-LD context
        /// </summary>
        /// <value>biomGeographicSampleAcquisitionLocationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomGeographicSampleAcquisitionLocationTypeContextJsonldEnum for ../JSON-LD_Contexts/biomGeographicSampleAcquisitionLocationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomGeographicSampleAcquisitionLocationTypeContext.jsonld")]
            JSONLDContextsbiomGeographicSampleAcquisitionLocationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomGeographicSampleAcquisitionLocationType JSON-LD context
        /// </summary>
        /// <value>biomGeographicSampleAcquisitionLocationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomGeographicSampleAcquisitionLocationType {\n");
            sb.Append("  CaptureUtcDateTime: ").Append(CaptureUtcDateTime).Append("\n");
            sb.Append("  Location3DGeospatialCoordinate: ").Append(Location3DGeospatialCoordinate).Append("\n");
            sb.Append("  LocationUtmCoordinateValue: ").Append(LocationUtmCoordinateValue).Append("\n");
            sb.Append("  MgrsCoordinateString: ").Append(MgrsCoordinateString).Append("\n");
            sb.Append("  GeographicLocation: ").Append(GeographicLocation).Append("\n");
            sb.Append("  GeographicLocationSystemName: ").Append(GeographicLocationSystemName).Append("\n");
            sb.Append("  LocationDescription: ").Append(LocationDescription).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomGeographicSampleAcquisitionLocationType)obj);
        }

        /// <summary>
        /// Returns true if BiomGeographicSampleAcquisitionLocationType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomGeographicSampleAcquisitionLocationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomGeographicSampleAcquisitionLocationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CaptureUtcDateTime == other.CaptureUtcDateTime ||
                    CaptureUtcDateTime != null &&
                    CaptureUtcDateTime.SequenceEqual(other.CaptureUtcDateTime)
                ) && 
                (
                    Location3DGeospatialCoordinate == other.Location3DGeospatialCoordinate ||
                    Location3DGeospatialCoordinate != null &&
                    Location3DGeospatialCoordinate.SequenceEqual(other.Location3DGeospatialCoordinate)
                ) && 
                (
                    LocationUtmCoordinateValue == other.LocationUtmCoordinateValue ||
                    LocationUtmCoordinateValue != null &&
                    LocationUtmCoordinateValue.SequenceEqual(other.LocationUtmCoordinateValue)
                ) && 
                (
                    MgrsCoordinateString == other.MgrsCoordinateString ||
                    MgrsCoordinateString != null &&
                    MgrsCoordinateString.SequenceEqual(other.MgrsCoordinateString)
                ) && 
                (
                    GeographicLocation == other.GeographicLocation ||
                    GeographicLocation != null &&
                    GeographicLocation.SequenceEqual(other.GeographicLocation)
                ) && 
                (
                    GeographicLocationSystemName == other.GeographicLocationSystemName ||
                    GeographicLocationSystemName != null &&
                    GeographicLocationSystemName.SequenceEqual(other.GeographicLocationSystemName)
                ) && 
                (
                    LocationDescription == other.LocationDescription ||
                    LocationDescription != null &&
                    LocationDescription.SequenceEqual(other.LocationDescription)
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
                    if (CaptureUtcDateTime != null)
                    hashCode = hashCode * 59 + CaptureUtcDateTime.GetHashCode();
                    if (Location3DGeospatialCoordinate != null)
                    hashCode = hashCode * 59 + Location3DGeospatialCoordinate.GetHashCode();
                    if (LocationUtmCoordinateValue != null)
                    hashCode = hashCode * 59 + LocationUtmCoordinateValue.GetHashCode();
                    if (MgrsCoordinateString != null)
                    hashCode = hashCode * 59 + MgrsCoordinateString.GetHashCode();
                    if (GeographicLocation != null)
                    hashCode = hashCode * 59 + GeographicLocation.GetHashCode();
                    if (GeographicLocationSystemName != null)
                    hashCode = hashCode * 59 + GeographicLocationSystemName.GetHashCode();
                    if (LocationDescription != null)
                    hashCode = hashCode * 59 + LocationDescription.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomGeographicSampleAcquisitionLocationType left, BiomGeographicSampleAcquisitionLocationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomGeographicSampleAcquisitionLocationType left, BiomGeographicSampleAcquisitionLocationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}