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
    /// A data type for additional information about an identification.
    /// </summary>
    [DataContract]
    public partial class IntelIdentificationAugmentationType : IEquatable<IntelIdentificationAugmentationType>
    { 
        /// <summary>
        /// True if something is of undisputed origin or veracity, genuine; false otherwise. NIEM reference is intel:AuthenticIndicator
        /// </summary>
        /// <value>True if something is of undisputed origin or veracity, genuine; false otherwise. NIEM reference is intel:AuthenticIndicator</value>

        [DataMember(Name="isAuthentic")]
        public List<NiemXsboolean> IsAuthentic { get; set; }

        /// <summary>
        /// A GeoPolitical Entity from which this identification was issued. NIEM reference is intel:IdentificationIssuingCountryISO3166Alpha2Code
        /// </summary>
        /// <value>A GeoPolitical Entity from which this identification was issued. NIEM reference is intel:IdentificationIssuingCountryISO3166Alpha2Code</value>

        [DataMember(Name="identificationIssuingCountryIso3166Alpha2Code")]
        public List<Iso3166CountryAlpha2CodeType> IdentificationIssuingCountryIso3166Alpha2Code { get; set; }

        /// <summary>
        /// A name of a GeoPolitical Entity from which this identification was issued. NIEM reference is intel:IdentificationIssuingCountryName
        /// </summary>
        /// <value>A name of a GeoPolitical Entity from which this identification was issued. NIEM reference is intel:IdentificationIssuingCountryName</value>

        [DataMember(Name="identificationIssuingCountryName")]
        public List<NcTextType> IdentificationIssuingCountryName { get; set; }

        /// <summary>
        /// A name of a major administrative district or division of a country from which this identification was issued. NIEM reference is intel:IdentificationIssuingStateName
        /// </summary>
        /// <value>A name of a major administrative district or division of a country from which this identification was issued. NIEM reference is intel:IdentificationIssuingStateName</value>

        [DataMember(Name="identificationIssuingStateName")]
        public List<NcTextType> IdentificationIssuingStateName { get; set; }

        /// <summary>
        /// A Geographic Location from which this identification was issued. NIEM reference is intel:IdentificationIssuingLocalityText
        /// </summary>
        /// <value>A Geographic Location from which this identification was issued. NIEM reference is intel:IdentificationIssuingLocalityText</value>

        [DataMember(Name="identificationIssuingLocality")]
        public List<NcTextType> IdentificationIssuingLocality { get; set; }

        /// <summary>
        /// An identification of the human being referenced in the context of an identification. NIEM reference is intel:PersonInIdentification
        /// </summary>
        /// <value>An identification of the human being referenced in the context of an identification. NIEM reference is intel:PersonInIdentification</value>

        [DataMember(Name="personInIdentification")]
        public List<NcIdentificationType> PersonInIdentification { get; set; }

        /// <summary>
        /// intelIdentificationAugmentationType JSON-LD context
        /// </summary>
        /// <value>intelIdentificationAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsintelIdentificationAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/intelIdentificationAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/intelIdentificationAugmentationTypeContext.jsonld")]
            JSONLDContextsintelIdentificationAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// intelIdentificationAugmentationType JSON-LD context
        /// </summary>
        /// <value>intelIdentificationAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntelIdentificationAugmentationType {\n");
            sb.Append("  IsAuthentic: ").Append(IsAuthentic).Append("\n");
            sb.Append("  IdentificationIssuingCountryIso3166Alpha2Code: ").Append(IdentificationIssuingCountryIso3166Alpha2Code).Append("\n");
            sb.Append("  IdentificationIssuingCountryName: ").Append(IdentificationIssuingCountryName).Append("\n");
            sb.Append("  IdentificationIssuingStateName: ").Append(IdentificationIssuingStateName).Append("\n");
            sb.Append("  IdentificationIssuingLocality: ").Append(IdentificationIssuingLocality).Append("\n");
            sb.Append("  PersonInIdentification: ").Append(PersonInIdentification).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IntelIdentificationAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if IntelIdentificationAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of IntelIdentificationAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntelIdentificationAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsAuthentic == other.IsAuthentic ||
                    IsAuthentic != null &&
                    IsAuthentic.SequenceEqual(other.IsAuthentic)
                ) && 
                (
                    IdentificationIssuingCountryIso3166Alpha2Code == other.IdentificationIssuingCountryIso3166Alpha2Code ||
                    IdentificationIssuingCountryIso3166Alpha2Code != null &&
                    IdentificationIssuingCountryIso3166Alpha2Code.SequenceEqual(other.IdentificationIssuingCountryIso3166Alpha2Code)
                ) && 
                (
                    IdentificationIssuingCountryName == other.IdentificationIssuingCountryName ||
                    IdentificationIssuingCountryName != null &&
                    IdentificationIssuingCountryName.SequenceEqual(other.IdentificationIssuingCountryName)
                ) && 
                (
                    IdentificationIssuingStateName == other.IdentificationIssuingStateName ||
                    IdentificationIssuingStateName != null &&
                    IdentificationIssuingStateName.SequenceEqual(other.IdentificationIssuingStateName)
                ) && 
                (
                    IdentificationIssuingLocality == other.IdentificationIssuingLocality ||
                    IdentificationIssuingLocality != null &&
                    IdentificationIssuingLocality.SequenceEqual(other.IdentificationIssuingLocality)
                ) && 
                (
                    PersonInIdentification == other.PersonInIdentification ||
                    PersonInIdentification != null &&
                    PersonInIdentification.SequenceEqual(other.PersonInIdentification)
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
                    if (IsAuthentic != null)
                    hashCode = hashCode * 59 + IsAuthentic.GetHashCode();
                    if (IdentificationIssuingCountryIso3166Alpha2Code != null)
                    hashCode = hashCode * 59 + IdentificationIssuingCountryIso3166Alpha2Code.GetHashCode();
                    if (IdentificationIssuingCountryName != null)
                    hashCode = hashCode * 59 + IdentificationIssuingCountryName.GetHashCode();
                    if (IdentificationIssuingStateName != null)
                    hashCode = hashCode * 59 + IdentificationIssuingStateName.GetHashCode();
                    if (IdentificationIssuingLocality != null)
                    hashCode = hashCode * 59 + IdentificationIssuingLocality.GetHashCode();
                    if (PersonInIdentification != null)
                    hashCode = hashCode * 59 + PersonInIdentification.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IntelIdentificationAugmentationType left, IntelIdentificationAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntelIdentificationAugmentationType left, IntelIdentificationAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
