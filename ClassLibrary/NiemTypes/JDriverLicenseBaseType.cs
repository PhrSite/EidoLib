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
    /// A data type for an authorization issued to a driver granting driving privileges.
    /// </summary>
    [DataContract]
    public partial class JDriverLicenseBaseType : IEquatable<JDriverLicenseBaseType>
    { 
        /// <summary>
        /// An implementation date of the most recent version or modification to the visible design of a jurisdictions driver license or ID card. NIEM reference is j:DriverLicenseCardDesignRevisionDate
        /// </summary>
        /// <value>An implementation date of the most recent version or modification to the visible design of a jurisdictions driver license or ID card. NIEM reference is j:DriverLicenseCardDesignRevisionDate</value>

        [DataMember(Name="driverLicenseCardDesignRevisionDate")]
        public List<NcDateType> DriverLicenseCardDesignRevisionDate { get; set; }

        /// <summary>
        /// A medical certification associated with a driver license. NIEM reference is j:DriverLicenseMedicalCertification
        /// </summary>
        /// <value>A medical certification associated with a driver license. NIEM reference is j:DriverLicenseMedicalCertification</value>

        [DataMember(Name="driverLicenseMedicalCertification")]
        public List<JDriverLicenseMedicalCertificationType> DriverLicenseMedicalCertification { get; set; }

        /// <summary>
        /// A driver license identification or driver license permit identification, including the number and state. NIEM reference is j:DriverLicenseIdentification
        /// </summary>
        /// <value>A driver license identification or driver license permit identification, including the number and state. NIEM reference is j:DriverLicenseIdentification</value>

        [DataMember(Name="driverLicenseIdentification")]
        public List<NcIdentificationType> DriverLicenseIdentification { get; set; }

        /// <summary>
        /// True if a driver license or identification card is classified by DHS regulations as a temporary or limited-term document (i.e. the expiration date of the card is limited to the duration of an aliens legal stay in the U.S.); false otherwise. NIEM reference is j:DriverLicenseLimitedTermIndicator
        /// </summary>
        /// <value>True if a driver license or identification card is classified by DHS regulations as a temporary or limited-term document (i.e. the expiration date of the card is limited to the duration of an aliens legal stay in the U.S.); false otherwise. NIEM reference is j:DriverLicenseLimitedTermIndicator</value>

        [DataMember(Name="isDriverLicenseLimitedTerm")]
        public List<NiemXsboolean> IsDriverLicenseLimitedTerm { get; set; }

        /// <summary>
        /// A date after which a driver license or driver license permit is no longer valid. NIEM reference is j:DriverLicenseExpirationDate
        /// </summary>
        /// <value>A date after which a driver license or driver license permit is no longer valid. NIEM reference is j:DriverLicenseExpirationDate</value>

        [DataMember(Name="driverLicenseExpirationDate")]
        public List<NcDateType> DriverLicenseExpirationDate { get; set; }

        /// <summary>
        /// A date when a driver license or driver license permit is issued or renewed. NIEM reference is j:DriverLicenseIssueDate
        /// </summary>
        /// <value>A date when a driver license or driver license permit is issued or renewed. NIEM reference is j:DriverLicenseIssueDate</value>

        [DataMember(Name="driverLicenseIssueDate")]
        public List<NcDateType> DriverLicenseIssueDate { get; set; }

        /// <summary>
        /// A person to which a driver license or driver license permit is assigned. NIEM reference is j:DriverLicensePerson
        /// </summary>
        /// <value>A person to which a driver license or driver license permit is assigned. NIEM reference is j:DriverLicensePerson</value>

        [DataMember(Name="driverLicensePerson")]
        public List<NcPersonType> DriverLicensePerson { get; set; }

        /// <summary>
        /// An identifier of the country in which an identity document was issued. NIEM reference is j:DriverLicenseIssuingCountryCode
        /// </summary>
        /// <value>An identifier of the country in which an identity document was issued. NIEM reference is j:DriverLicenseIssuingCountryCode</value>

        [DataMember(Name="driverLicenseIssuingCountryCode")]
        public List<JDHSDriverLicenseIssuingCountryCodeType> DriverLicenseIssuingCountryCode { get; set; }

        /// <summary>
        /// jDriverLicenseBaseType JSON-LD context
        /// </summary>
        /// <value>jDriverLicenseBaseType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjDriverLicenseBaseTypeContextJsonldEnum for ../JSON-LD_Contexts/jDriverLicenseBaseTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jDriverLicenseBaseTypeContext.jsonld")]
            JSONLDContextsjDriverLicenseBaseTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jDriverLicenseBaseType JSON-LD context
        /// </summary>
        /// <value>jDriverLicenseBaseType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JDriverLicenseBaseType {\n");
            sb.Append("  DriverLicenseCardDesignRevisionDate: ").Append(DriverLicenseCardDesignRevisionDate).Append("\n");
            sb.Append("  DriverLicenseMedicalCertification: ").Append(DriverLicenseMedicalCertification).Append("\n");
            sb.Append("  DriverLicenseIdentification: ").Append(DriverLicenseIdentification).Append("\n");
            sb.Append("  IsDriverLicenseLimitedTerm: ").Append(IsDriverLicenseLimitedTerm).Append("\n");
            sb.Append("  DriverLicenseExpirationDate: ").Append(DriverLicenseExpirationDate).Append("\n");
            sb.Append("  DriverLicenseIssueDate: ").Append(DriverLicenseIssueDate).Append("\n");
            sb.Append("  DriverLicensePerson: ").Append(DriverLicensePerson).Append("\n");
            sb.Append("  DriverLicenseIssuingCountryCode: ").Append(DriverLicenseIssuingCountryCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JDriverLicenseBaseType)obj);
        }

        /// <summary>
        /// Returns true if JDriverLicenseBaseType instances are equal
        /// </summary>
        /// <param name="other">Instance of JDriverLicenseBaseType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JDriverLicenseBaseType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DriverLicenseCardDesignRevisionDate == other.DriverLicenseCardDesignRevisionDate ||
                    DriverLicenseCardDesignRevisionDate != null &&
                    DriverLicenseCardDesignRevisionDate.SequenceEqual(other.DriverLicenseCardDesignRevisionDate)
                ) && 
                (
                    DriverLicenseMedicalCertification == other.DriverLicenseMedicalCertification ||
                    DriverLicenseMedicalCertification != null &&
                    DriverLicenseMedicalCertification.SequenceEqual(other.DriverLicenseMedicalCertification)
                ) && 
                (
                    DriverLicenseIdentification == other.DriverLicenseIdentification ||
                    DriverLicenseIdentification != null &&
                    DriverLicenseIdentification.SequenceEqual(other.DriverLicenseIdentification)
                ) && 
                (
                    IsDriverLicenseLimitedTerm == other.IsDriverLicenseLimitedTerm ||
                    IsDriverLicenseLimitedTerm != null &&
                    IsDriverLicenseLimitedTerm.SequenceEqual(other.IsDriverLicenseLimitedTerm)
                ) && 
                (
                    DriverLicenseExpirationDate == other.DriverLicenseExpirationDate ||
                    DriverLicenseExpirationDate != null &&
                    DriverLicenseExpirationDate.SequenceEqual(other.DriverLicenseExpirationDate)
                ) && 
                (
                    DriverLicenseIssueDate == other.DriverLicenseIssueDate ||
                    DriverLicenseIssueDate != null &&
                    DriverLicenseIssueDate.SequenceEqual(other.DriverLicenseIssueDate)
                ) && 
                (
                    DriverLicensePerson == other.DriverLicensePerson ||
                    DriverLicensePerson != null &&
                    DriverLicensePerson.SequenceEqual(other.DriverLicensePerson)
                ) && 
                (
                    DriverLicenseIssuingCountryCode == other.DriverLicenseIssuingCountryCode ||
                    DriverLicenseIssuingCountryCode != null &&
                    DriverLicenseIssuingCountryCode.SequenceEqual(other.DriverLicenseIssuingCountryCode)
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
                    if (DriverLicenseCardDesignRevisionDate != null)
                    hashCode = hashCode * 59 + DriverLicenseCardDesignRevisionDate.GetHashCode();
                    if (DriverLicenseMedicalCertification != null)
                    hashCode = hashCode * 59 + DriverLicenseMedicalCertification.GetHashCode();
                    if (DriverLicenseIdentification != null)
                    hashCode = hashCode * 59 + DriverLicenseIdentification.GetHashCode();
                    if (IsDriverLicenseLimitedTerm != null)
                    hashCode = hashCode * 59 + IsDriverLicenseLimitedTerm.GetHashCode();
                    if (DriverLicenseExpirationDate != null)
                    hashCode = hashCode * 59 + DriverLicenseExpirationDate.GetHashCode();
                    if (DriverLicenseIssueDate != null)
                    hashCode = hashCode * 59 + DriverLicenseIssueDate.GetHashCode();
                    if (DriverLicensePerson != null)
                    hashCode = hashCode * 59 + DriverLicensePerson.GetHashCode();
                    if (DriverLicenseIssuingCountryCode != null)
                    hashCode = hashCode * 59 + DriverLicenseIssuingCountryCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JDriverLicenseBaseType left, JDriverLicenseBaseType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JDriverLicenseBaseType left, JDriverLicenseBaseType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
