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
    /// A data type for a military element whose structure is prescribed by competent authority.
    /// </summary>
    [DataContract]
    public partial class MoUnitType : IEquatable<MoUnitType>
    { 
        /// <summary>
        /// An identifier to uniquely distinguish one DoD organizational element from another, allowing DoD systems to identify an organization individually across the DoD enterprise.  Also known as OUID. NIEM reference is mo:OrganizationUniqueID
        /// </summary>
        /// <value>An identifier to uniquely distinguish one DoD organizational element from another, allowing DoD systems to identify an organization individually across the DoD enterprise.  Also known as OUID. NIEM reference is mo:OrganizationUniqueID</value>

        [DataMember(Name="organizationUniqueId")]
        public List<MoForceManagementIDType> OrganizationUniqueId { get; set; }

        /// <summary>
        /// An identifier with a six-character, alphanumeric code that uniquely identifies each Active, Reserve, and National Guard unit of the Armed Forces. Also called UIC. NIEM reference is mo:UnitIdentificationCodeID
        /// </summary>
        /// <value>An identifier with a six-character, alphanumeric code that uniquely identifies each Active, Reserve, and National Guard unit of the Armed Forces. Also called UIC. NIEM reference is mo:UnitIdentificationCodeID</value>

        [DataMember(Name="identificationCodeId")]
        public List<MoSixAlphaNumericIDType> IdentificationCodeId { get; set; }

        /// <summary>
        /// A character string assigned to represent a unit name. NIEM reference is mo:UnitName
        /// </summary>
        /// <value>A character string assigned to represent a unit name. NIEM reference is mo:UnitName</value>

        [DataMember(Name="name")]
        public List<MoUnitNameType> Name { get; set; }

        /// <summary>
        /// An abbreviated unit name. NIEM reference is mo:UnitAbbreviatedName
        /// </summary>
        /// <value>An abbreviated unit name. NIEM reference is mo:UnitAbbreviatedName</value>

        [DataMember(Name="abbreviatedName")]
        public List<MoAbbreviatedNameType> AbbreviatedName { get; set; }

        /// <summary>
        /// A name used to create derived names and for display with military symbols. NIEM reference is mo:UnitShortName
        /// </summary>
        /// <value>A name used to create derived names and for display with military symbols. NIEM reference is mo:UnitShortName</value>

        [DataMember(Name="shortName")]
        public List<MoUnitShortNameType> ShortName { get; set; }

        /// <summary>
        /// A Joint Chiefs of Staff developed and assigned code, consisting of five characters that uniquely identify a \&quot;type unit.\&quot; NIEM reference is mo:UnitTypeCodeText
        /// </summary>
        /// <value>A Joint Chiefs of Staff developed and assigned code, consisting of five characters that uniquely identify a \&quot;type unit.\&quot; NIEM reference is mo:UnitTypeCodeText</value>

        [DataMember(Name="typeCode")]
        public List<MoUnitTypeCodeTextType> TypeCode { get; set; }

        /// <summary>
        /// A position or site occupied by the unit. NIEM reference is mo:UnitPresentLocation
        /// </summary>
        /// <value>A position or site occupied by the unit. NIEM reference is mo:UnitPresentLocation</value>

        [DataMember(Name="presentLocation")]
        public List<NcLocationType> PresentLocation { get; set; }

        /// <summary>
        /// A person serving as coordinator, action officer, or focal point for an activity. NIEM reference is mo:UnitPointOfContact
        /// </summary>
        /// <value>A person serving as coordinator, action officer, or focal point for an activity. NIEM reference is mo:UnitPointOfContact</value>

        [DataMember(Name="pointOfContact")]
        public List<NcContactInformationType> PointOfContact { get; set; }

        /// <summary>
        /// Information that further qualifies primary data about a unit; data about unit data. NIEM reference is mo:UnitMetadata
        /// </summary>
        /// <value>Information that further qualifies primary data about a unit; data about unit data. NIEM reference is mo:UnitMetadata</value>

        [DataMember(Name="metadata")]
        public List<NcMetadataType> Metadata { get; set; }

        /// <summary>
        /// A designator representing the country affiliation for an object. NIEM reference is mo:UnitGeopoliticalAffiliationCode
        /// </summary>
        /// <value>A designator representing the country affiliation for an object. NIEM reference is mo:UnitGeopoliticalAffiliationCode</value>

        [DataMember(Name="geopoliticalAffiliationCode")]
        public List<Iso3166CountryAlpha2CodeType> GeopoliticalAffiliationCode { get; set; }

        /// <summary>
        /// An angular distance measured in degrees of a direction from a chosen reference direction.  The measured and reference directions are located in the horizontal plane, and the value of the angle is positive in a clockwise direction as viewed from \&quot;above\&quot; the horizontal plane. NIEM reference is mo:CourseAngleDegreesMeasure
        /// </summary>
        /// <value>An angular distance measured in degrees of a direction from a chosen reference direction.  The measured and reference directions are located in the horizontal plane, and the value of the angle is positive in a clockwise direction as viewed from \&quot;above\&quot; the horizontal plane. NIEM reference is mo:CourseAngleDegreesMeasure</value>

        [DataMember(Name="courseAngleDegreesMeasure")]
        public List<MoCourseAngleDegreesMeasureType> CourseAngleDegreesMeasure { get; set; }

        /// <summary>
        /// A designator that describes the operational status of a military entity. NIEM reference is mo:UnitOperationalStatusCode
        /// </summary>
        /// <value>A designator that describes the operational status of a military entity. NIEM reference is mo:UnitOperationalStatusCode</value>

        [DataMember(Name="operationalStatusCode")]
        public List<MoUnitOperationalStatusCodeType> OperationalStatusCode { get; set; }

        /// <summary>
        /// A designator that qualifies the status of a unit. NIEM reference is mo:UnitStatusQualifierCode
        /// </summary>
        /// <value>A designator that qualifies the status of a unit. NIEM reference is mo:UnitStatusQualifierCode</value>

        [DataMember(Name="statusQualifierCode")]
        public List<MoUnitStatusQualifierCodeType> StatusQualifierCode { get; set; }

        /// <summary>
        /// A designator that gives the reinforcement for a unit that has additional or detached strength. NIEM reference is mo:UnitReinforcementCode
        /// </summary>
        /// <value>A designator that gives the reinforcement for a unit that has additional or detached strength. NIEM reference is mo:UnitReinforcementCode</value>

        [DataMember(Name="reinforcementCode")]
        public List<MoUnitReinforcementCodeType> ReinforcementCode { get; set; }

        /// <summary>
        /// A measure of a speed or rate of motion. NIEM reference is nc:SpeedMeasure
        /// </summary>
        /// <value>A measure of a speed or rate of motion. NIEM reference is nc:SpeedMeasure</value>

        [DataMember(Name="speedMeasure")]
        public List<NcSpeedMeasureType> SpeedMeasure { get; set; }

        /// <summary>
        /// moUnitType JSON-LD context
        /// </summary>
        /// <value>moUnitType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsmoUnitTypeContextJsonldEnum for ../JSON-LD_Contexts/moUnitTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/moUnitTypeContext.jsonld")]
            JSONLDContextsmoUnitTypeContextJsonldEnum = 0        }

        /// <summary>
        /// moUnitType JSON-LD context
        /// </summary>
        /// <value>moUnitType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoUnitType {\n");
            sb.Append("  OrganizationUniqueId: ").Append(OrganizationUniqueId).Append("\n");
            sb.Append("  IdentificationCodeId: ").Append(IdentificationCodeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  PresentLocation: ").Append(PresentLocation).Append("\n");
            sb.Append("  PointOfContact: ").Append(PointOfContact).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  GeopoliticalAffiliationCode: ").Append(GeopoliticalAffiliationCode).Append("\n");
            sb.Append("  CourseAngleDegreesMeasure: ").Append(CourseAngleDegreesMeasure).Append("\n");
            sb.Append("  OperationalStatusCode: ").Append(OperationalStatusCode).Append("\n");
            sb.Append("  StatusQualifierCode: ").Append(StatusQualifierCode).Append("\n");
            sb.Append("  ReinforcementCode: ").Append(ReinforcementCode).Append("\n");
            sb.Append("  SpeedMeasure: ").Append(SpeedMeasure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MoUnitType)obj);
        }

        /// <summary>
        /// Returns true if MoUnitType instances are equal
        /// </summary>
        /// <param name="other">Instance of MoUnitType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoUnitType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OrganizationUniqueId == other.OrganizationUniqueId ||
                    OrganizationUniqueId != null &&
                    OrganizationUniqueId.SequenceEqual(other.OrganizationUniqueId)
                ) && 
                (
                    IdentificationCodeId == other.IdentificationCodeId ||
                    IdentificationCodeId != null &&
                    IdentificationCodeId.SequenceEqual(other.IdentificationCodeId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.SequenceEqual(other.Name)
                ) && 
                (
                    AbbreviatedName == other.AbbreviatedName ||
                    AbbreviatedName != null &&
                    AbbreviatedName.SequenceEqual(other.AbbreviatedName)
                ) && 
                (
                    ShortName == other.ShortName ||
                    ShortName != null &&
                    ShortName.SequenceEqual(other.ShortName)
                ) && 
                (
                    TypeCode == other.TypeCode ||
                    TypeCode != null &&
                    TypeCode.SequenceEqual(other.TypeCode)
                ) && 
                (
                    PresentLocation == other.PresentLocation ||
                    PresentLocation != null &&
                    PresentLocation.SequenceEqual(other.PresentLocation)
                ) && 
                (
                    PointOfContact == other.PointOfContact ||
                    PointOfContact != null &&
                    PointOfContact.SequenceEqual(other.PointOfContact)
                ) && 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.SequenceEqual(other.Metadata)
                ) && 
                (
                    GeopoliticalAffiliationCode == other.GeopoliticalAffiliationCode ||
                    GeopoliticalAffiliationCode != null &&
                    GeopoliticalAffiliationCode.SequenceEqual(other.GeopoliticalAffiliationCode)
                ) && 
                (
                    CourseAngleDegreesMeasure == other.CourseAngleDegreesMeasure ||
                    CourseAngleDegreesMeasure != null &&
                    CourseAngleDegreesMeasure.SequenceEqual(other.CourseAngleDegreesMeasure)
                ) && 
                (
                    OperationalStatusCode == other.OperationalStatusCode ||
                    OperationalStatusCode != null &&
                    OperationalStatusCode.SequenceEqual(other.OperationalStatusCode)
                ) && 
                (
                    StatusQualifierCode == other.StatusQualifierCode ||
                    StatusQualifierCode != null &&
                    StatusQualifierCode.SequenceEqual(other.StatusQualifierCode)
                ) && 
                (
                    ReinforcementCode == other.ReinforcementCode ||
                    ReinforcementCode != null &&
                    ReinforcementCode.SequenceEqual(other.ReinforcementCode)
                ) && 
                (
                    SpeedMeasure == other.SpeedMeasure ||
                    SpeedMeasure != null &&
                    SpeedMeasure.SequenceEqual(other.SpeedMeasure)
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
                    if (OrganizationUniqueId != null)
                    hashCode = hashCode * 59 + OrganizationUniqueId.GetHashCode();
                    if (IdentificationCodeId != null)
                    hashCode = hashCode * 59 + IdentificationCodeId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AbbreviatedName != null)
                    hashCode = hashCode * 59 + AbbreviatedName.GetHashCode();
                    if (ShortName != null)
                    hashCode = hashCode * 59 + ShortName.GetHashCode();
                    if (TypeCode != null)
                    hashCode = hashCode * 59 + TypeCode.GetHashCode();
                    if (PresentLocation != null)
                    hashCode = hashCode * 59 + PresentLocation.GetHashCode();
                    if (PointOfContact != null)
                    hashCode = hashCode * 59 + PointOfContact.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                    if (GeopoliticalAffiliationCode != null)
                    hashCode = hashCode * 59 + GeopoliticalAffiliationCode.GetHashCode();
                    if (CourseAngleDegreesMeasure != null)
                    hashCode = hashCode * 59 + CourseAngleDegreesMeasure.GetHashCode();
                    if (OperationalStatusCode != null)
                    hashCode = hashCode * 59 + OperationalStatusCode.GetHashCode();
                    if (StatusQualifierCode != null)
                    hashCode = hashCode * 59 + StatusQualifierCode.GetHashCode();
                    if (ReinforcementCode != null)
                    hashCode = hashCode * 59 + ReinforcementCode.GetHashCode();
                    if (SpeedMeasure != null)
                    hashCode = hashCode * 59 + SpeedMeasure.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MoUnitType left, MoUnitType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MoUnitType left, MoUnitType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}