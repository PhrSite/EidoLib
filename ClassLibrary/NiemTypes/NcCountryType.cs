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
    /// A data type for a country, territory, dependency, or other such geopolitical subdivision of a location.
    /// </summary>
    [DataContract]
    public partial class NcCountryType : IEquatable<NcCountryType>
    { 
        /// <summary>
        /// A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:CountryCode
        /// </summary>
        /// <value>A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:CountryCode</value>

        [DataMember(Name="code")]
        public List<NcCodeType> Code { get; set; }

        /// <summary>
        /// A union of additional country codes managed by NCTC and the FIPS 10-4 country codes. NIEM reference is intel:LocationCountryFIPS10-4PlusNCTCCodeText
        /// </summary>
        /// <value>A union of additional country codes managed by NCTC and the FIPS 10-4 country codes. NIEM reference is intel:LocationCountryFIPS10-4PlusNCTCCodeText</value>

        [DataMember(Name="locationFips10-4PlusNctcCode")]
        public List<NcTextType> LocationFips104PlusNctcCode { get; set; }

        /// <summary>
        /// An identification value that represents a country. NIEM reference is scr:LocationCountryIdentification
        /// </summary>
        /// <value>An identification value that represents a country. NIEM reference is scr:LocationCountryIdentification</value>

        [DataMember(Name="locationIdentification")]
        public List<NcIdentificationType> LocationIdentification { get; set; }

        /// <summary>
        /// A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryISO3166Alpha2Code
        /// </summary>
        /// <value>A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryISO3166Alpha2Code</value>

        [DataMember(Name="locationIso3166Alpha2Code")]
        public List<Iso3166CountryAlpha2CodeType> LocationIso3166Alpha2Code { get; set; }

        /// <summary>
        /// A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryISO3166Alpha3Code
        /// </summary>
        /// <value>A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryISO3166Alpha3Code</value>

        [DataMember(Name="locationIso3166Alpha3Code")]
        public List<Iso3166CountryAlpha3CodeType> LocationIso3166Alpha3Code { get; set; }

        /// <summary>
        /// A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryISO3166NumericCode
        /// </summary>
        /// <value>A country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryISO3166NumericCode</value>

        [DataMember(Name="locationIso3166NumericCode")]
        public List<Iso3166CountryNumericCodeType> LocationIso3166NumericCode { get; set; }

        /// <summary>
        /// A name of a country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryName
        /// </summary>
        /// <value>A name of a country, territory, dependency, or other such geopolitical subdivision of a location. NIEM reference is nc:LocationCountryName</value>

        [DataMember(Name="locationName")]
        public List<NcProperNameTextType> LocationName { get; set; }

        /// <summary>
        /// ncCountryType JSON-LD context
        /// </summary>
        /// <value>ncCountryType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncCountryTypeContextJsonldEnum for ../JSON-LD_Contexts/ncCountryTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncCountryTypeContext.jsonld")]
            JSONLDContextsncCountryTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncCountryType JSON-LD context
        /// </summary>
        /// <value>ncCountryType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcCountryType {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  LocationFips104PlusNctcCode: ").Append(LocationFips104PlusNctcCode).Append("\n");
            sb.Append("  LocationIdentification: ").Append(LocationIdentification).Append("\n");
            sb.Append("  LocationIso3166Alpha2Code: ").Append(LocationIso3166Alpha2Code).Append("\n");
            sb.Append("  LocationIso3166Alpha3Code: ").Append(LocationIso3166Alpha3Code).Append("\n");
            sb.Append("  LocationIso3166NumericCode: ").Append(LocationIso3166NumericCode).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcCountryType)obj);
        }

        /// <summary>
        /// Returns true if NcCountryType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcCountryType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcCountryType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.SequenceEqual(other.Code)
                ) && 
                (
                    LocationFips104PlusNctcCode == other.LocationFips104PlusNctcCode ||
                    LocationFips104PlusNctcCode != null &&
                    LocationFips104PlusNctcCode.SequenceEqual(other.LocationFips104PlusNctcCode)
                ) && 
                (
                    LocationIdentification == other.LocationIdentification ||
                    LocationIdentification != null &&
                    LocationIdentification.SequenceEqual(other.LocationIdentification)
                ) && 
                (
                    LocationIso3166Alpha2Code == other.LocationIso3166Alpha2Code ||
                    LocationIso3166Alpha2Code != null &&
                    LocationIso3166Alpha2Code.SequenceEqual(other.LocationIso3166Alpha2Code)
                ) && 
                (
                    LocationIso3166Alpha3Code == other.LocationIso3166Alpha3Code ||
                    LocationIso3166Alpha3Code != null &&
                    LocationIso3166Alpha3Code.SequenceEqual(other.LocationIso3166Alpha3Code)
                ) && 
                (
                    LocationIso3166NumericCode == other.LocationIso3166NumericCode ||
                    LocationIso3166NumericCode != null &&
                    LocationIso3166NumericCode.SequenceEqual(other.LocationIso3166NumericCode)
                ) && 
                (
                    LocationName == other.LocationName ||
                    LocationName != null &&
                    LocationName.SequenceEqual(other.LocationName)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (LocationFips104PlusNctcCode != null)
                    hashCode = hashCode * 59 + LocationFips104PlusNctcCode.GetHashCode();
                    if (LocationIdentification != null)
                    hashCode = hashCode * 59 + LocationIdentification.GetHashCode();
                    if (LocationIso3166Alpha2Code != null)
                    hashCode = hashCode * 59 + LocationIso3166Alpha2Code.GetHashCode();
                    if (LocationIso3166Alpha3Code != null)
                    hashCode = hashCode * 59 + LocationIso3166Alpha3Code.GetHashCode();
                    if (LocationIso3166NumericCode != null)
                    hashCode = hashCode * 59 + LocationIso3166NumericCode.GetHashCode();
                    if (LocationName != null)
                    hashCode = hashCode * 59 + LocationName.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcCountryType left, NcCountryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcCountryType left, NcCountryType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}