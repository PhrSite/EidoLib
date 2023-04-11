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
    /// A data type for a specific location into which a person is placed, such as an office, dormitory, barracks, etc.
    /// </summary>
    [DataContract]
    public partial class JAssignmentLocationDetailType : IEquatable<JAssignmentLocationDetailType>
    { 
        /// <summary>
        /// A specific section or wing or block for a building in a facility. NIEM reference is j:LocationSectionText
        /// </summary>
        /// <value>A specific section or wing or block for a building in a facility. NIEM reference is j:LocationSectionText</value>

        [DataMember(Name="locationSection")]
        public List<NcTextType> LocationSection { get; set; }

        /// <summary>
        /// A specific bed to which a person has been assigned. NIEM reference is j:LocationBedText
        /// </summary>
        /// <value>A specific bed to which a person has been assigned. NIEM reference is j:LocationBedText</value>

        [DataMember(Name="locationBed")]
        public List<NcTextType> LocationBed { get; set; }

        /// <summary>
        /// A specific building in a facility. NIEM reference is j:LocationBuildingText
        /// </summary>
        /// <value>A specific building in a facility. NIEM reference is j:LocationBuildingText</value>

        [DataMember(Name="locationBuilding")]
        public List<NcTextType> LocationBuilding { get; set; }

        /// <summary>
        /// A location in a facility when the location cannot be broken down into separate components such as building and section and cell or bed. NIEM reference is j:LocationText
        /// </summary>
        /// <value>A location in a facility when the location cannot be broken down into separate components such as building and section and cell or bed. NIEM reference is j:LocationText</value>

        [DataMember(Name="location")]
        public List<NcTextType> Location { get; set; }

        /// <summary>
        /// A specific suite in which a person is housed. NIEM reference is j:LocationSuiteText
        /// </summary>
        /// <value>A specific suite in which a person is housed. NIEM reference is j:LocationSuiteText</value>

        [DataMember(Name="locationSuite")]
        public List<NcTextType> LocationSuite { get; set; }

        /// <summary>
        /// A specific room in which a person is housed. NIEM reference is j:LocationRoomText
        /// </summary>
        /// <value>A specific room in which a person is housed. NIEM reference is j:LocationRoomText</value>

        [DataMember(Name="locationRoom")]
        public List<NcTextType> LocationRoom { get; set; }

        /// <summary>
        /// jAssignmentLocationDetailType JSON-LD context
        /// </summary>
        /// <value>jAssignmentLocationDetailType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjAssignmentLocationDetailTypeContextJsonldEnum for ../JSON-LD_Contexts/jAssignmentLocationDetailTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jAssignmentLocationDetailTypeContext.jsonld")]
            JSONLDContextsjAssignmentLocationDetailTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jAssignmentLocationDetailType JSON-LD context
        /// </summary>
        /// <value>jAssignmentLocationDetailType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JAssignmentLocationDetailType {\n");
            sb.Append("  LocationSection: ").Append(LocationSection).Append("\n");
            sb.Append("  LocationBed: ").Append(LocationBed).Append("\n");
            sb.Append("  LocationBuilding: ").Append(LocationBuilding).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LocationSuite: ").Append(LocationSuite).Append("\n");
            sb.Append("  LocationRoom: ").Append(LocationRoom).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JAssignmentLocationDetailType)obj);
        }

        /// <summary>
        /// Returns true if JAssignmentLocationDetailType instances are equal
        /// </summary>
        /// <param name="other">Instance of JAssignmentLocationDetailType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JAssignmentLocationDetailType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LocationSection == other.LocationSection ||
                    LocationSection != null &&
                    LocationSection.SequenceEqual(other.LocationSection)
                ) && 
                (
                    LocationBed == other.LocationBed ||
                    LocationBed != null &&
                    LocationBed.SequenceEqual(other.LocationBed)
                ) && 
                (
                    LocationBuilding == other.LocationBuilding ||
                    LocationBuilding != null &&
                    LocationBuilding.SequenceEqual(other.LocationBuilding)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.SequenceEqual(other.Location)
                ) && 
                (
                    LocationSuite == other.LocationSuite ||
                    LocationSuite != null &&
                    LocationSuite.SequenceEqual(other.LocationSuite)
                ) && 
                (
                    LocationRoom == other.LocationRoom ||
                    LocationRoom != null &&
                    LocationRoom.SequenceEqual(other.LocationRoom)
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
                    if (LocationSection != null)
                    hashCode = hashCode * 59 + LocationSection.GetHashCode();
                    if (LocationBed != null)
                    hashCode = hashCode * 59 + LocationBed.GetHashCode();
                    if (LocationBuilding != null)
                    hashCode = hashCode * 59 + LocationBuilding.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (LocationSuite != null)
                    hashCode = hashCode * 59 + LocationSuite.GetHashCode();
                    if (LocationRoom != null)
                    hashCode = hashCode * 59 + LocationRoom.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JAssignmentLocationDetailType left, JAssignmentLocationDetailType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JAssignmentLocationDetailType left, JAssignmentLocationDetailType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}