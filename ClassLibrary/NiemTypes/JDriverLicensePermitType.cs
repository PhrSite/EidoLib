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
    /// A data type for a driver license permit issued to a driver granting conditional or limited driving privileges.
    /// </summary>
    [DataContract]
    public partial class JDriverLicensePermitType : JDriverLicenseBaseType, IEquatable<JDriverLicensePermitType>
    { 
        /// <summary>
        /// A kind of commercial or non-commercial vehicle that a licensed driver has been examined on and approved to operate subject to a permit. NIEM reference is j:DriverLicensePermitClassificationText
        /// </summary>
        /// <value>A kind of commercial or non-commercial vehicle that a licensed driver has been examined on and approved to operate subject to a permit. NIEM reference is j:DriverLicensePermitClassificationText</value>

        [DataMember(Name="classification")]
        public List<NcTextType> Classification { get; set; }

        /// <summary>
        /// A current status of an individuals driver license at the time of the crash. NIEM reference is j:CrashDriverLicensePermitStatusCode
        /// </summary>
        /// <value>A current status of an individuals driver license at the time of the crash. NIEM reference is j:CrashDriverLicensePermitStatusCode</value>

        [DataMember(Name="crashStatusCode")]
        public List<MmuccDriverLicensePermitStatusCodeType> CrashStatusCode { get; set; }

        /// <summary>
        /// A current status of an individuals driver license permit. NIEM reference is j:DriverLicensePermitStatusCode
        /// </summary>
        /// <value>A current status of an individuals driver license permit. NIEM reference is j:DriverLicensePermitStatusCode</value>

        [DataMember(Name="statusCode")]
        public List<AamvaD20DrivingStatusCodeType> StatusCode { get; set; }

        /// <summary>
        /// A current status of an individuals driver license permit. NIEM reference is j:DriverLicensePermitStatusText
        /// </summary>
        /// <value>A current status of an individuals driver license permit. NIEM reference is j:DriverLicensePermitStatusText</value>

        [DataMember(Name="status")]
        public List<NcTextType> Status { get; set; }

        /// <summary>
        /// A restriction on a driver license permit. NIEM reference is j:DriverLicensePermitRestriction
        /// </summary>
        /// <value>A restriction on a driver license permit. NIEM reference is j:DriverLicensePermitRestriction</value>

        [DataMember(Name="restriction")]
        public List<JDriverLicensePermitRestrictionType> Restriction { get; set; }

        /// <summary>
        /// An endorsement on a driver license which authorizes the operation of specified types of vehicles carrying specified loads. NIEM reference is j:DriverLicensePermitEndorsement
        /// </summary>
        /// <value>An endorsement on a driver license which authorizes the operation of specified types of vehicles carrying specified loads. NIEM reference is j:DriverLicensePermitEndorsement</value>

        [DataMember(Name="endorsement")]
        public List<JDriverLicensePermitEndorsementType> Endorsement { get; set; }

        /// <summary>
        /// jDriverLicensePermitType JSON-LD context
        /// </summary>
        /// <value>jDriverLicensePermitType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjDriverLicensePermitTypeContextJsonldEnum for ../JSON-LD_Contexts/jDriverLicensePermitTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jDriverLicensePermitTypeContext.jsonld")]
            JSONLDContextsjDriverLicensePermitTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jDriverLicensePermitType JSON-LD context
        /// </summary>
        /// <value>jDriverLicensePermitType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JDriverLicensePermitType {\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  CrashStatusCode: ").Append(CrashStatusCode).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Restriction: ").Append(Restriction).Append("\n");
            sb.Append("  Endorsement: ").Append(Endorsement).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JDriverLicensePermitType)obj);
        }

        /// <summary>
        /// Returns true if JDriverLicensePermitType instances are equal
        /// </summary>
        /// <param name="other">Instance of JDriverLicensePermitType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JDriverLicensePermitType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Classification == other.Classification ||
                    Classification != null &&
                    Classification.SequenceEqual(other.Classification)
                ) && 
                (
                    CrashStatusCode == other.CrashStatusCode ||
                    CrashStatusCode != null &&
                    CrashStatusCode.SequenceEqual(other.CrashStatusCode)
                ) && 
                (
                    StatusCode == other.StatusCode ||
                    StatusCode != null &&
                    StatusCode.SequenceEqual(other.StatusCode)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.SequenceEqual(other.Status)
                ) && 
                (
                    Restriction == other.Restriction ||
                    Restriction != null &&
                    Restriction.SequenceEqual(other.Restriction)
                ) && 
                (
                    Endorsement == other.Endorsement ||
                    Endorsement != null &&
                    Endorsement.SequenceEqual(other.Endorsement)
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
                    if (Classification != null)
                    hashCode = hashCode * 59 + Classification.GetHashCode();
                    if (CrashStatusCode != null)
                    hashCode = hashCode * 59 + CrashStatusCode.GetHashCode();
                    if (StatusCode != null)
                    hashCode = hashCode * 59 + StatusCode.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Restriction != null)
                    hashCode = hashCode * 59 + Restriction.GetHashCode();
                    if (Endorsement != null)
                    hashCode = hashCode * 59 + Endorsement.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JDriverLicensePermitType left, JDriverLicensePermitType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JDriverLicensePermitType left, JDriverLicensePermitType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
