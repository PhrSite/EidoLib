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
    /// A data type for a restriction applicable to a driver permit or license.
    /// </summary>
    [DataContract]
    public partial class JDrivingRestrictionType : IEquatable<JDrivingRestrictionType>
    { 
        /// <summary>
        /// A Restriction assigned to an individuals driver license by the license examiner. NIEM reference is j:CrashDrivingRestrictionCode
        /// </summary>
        /// <value>A Restriction assigned to an individuals driver license by the license examiner. NIEM reference is j:CrashDrivingRestrictionCode</value>

        [DataMember(Name="crashCode")]
        public List<MmuccDrivingRestrictionCodeType> CrashCode { get; set; }

        /// <summary>
        /// A category of a driving restriction. NIEM reference is j:DrivingRestrictionText
        /// </summary>
        /// <value>A category of a driving restriction. NIEM reference is j:DrivingRestrictionText</value>

        [DataMember(Name="text")]
        public List<NcTextType> Text { get; set; }

        /// <summary>
        /// A description of the nature of a restriction NIEM reference is j:DrivingRestrictionDescriptionText
        /// </summary>
        /// <value>A description of the nature of a restriction NIEM reference is j:DrivingRestrictionDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A date on which a special restriction ends. NIEM reference is j:DrivingRestrictionEndDate
        /// </summary>
        /// <value>A date on which a special restriction ends. NIEM reference is j:DrivingRestrictionEndDate</value>

        [DataMember(Name="endDate")]
        public List<NcDateType> EndDate { get; set; }

        /// <summary>
        /// jDrivingRestrictionType JSON-LD context
        /// </summary>
        /// <value>jDrivingRestrictionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjDrivingRestrictionTypeContextJsonldEnum for ../JSON-LD_Contexts/jDrivingRestrictionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jDrivingRestrictionTypeContext.jsonld")]
            JSONLDContextsjDrivingRestrictionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jDrivingRestrictionType JSON-LD context
        /// </summary>
        /// <value>jDrivingRestrictionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JDrivingRestrictionType {\n");
            sb.Append("  CrashCode: ").Append(CrashCode).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JDrivingRestrictionType)obj);
        }

        /// <summary>
        /// Returns true if JDrivingRestrictionType instances are equal
        /// </summary>
        /// <param name="other">Instance of JDrivingRestrictionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JDrivingRestrictionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CrashCode == other.CrashCode ||
                    CrashCode != null &&
                    CrashCode.SequenceEqual(other.CrashCode)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.SequenceEqual(other.Text)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.SequenceEqual(other.EndDate)
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
                    if (CrashCode != null)
                    hashCode = hashCode * 59 + CrashCode.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JDrivingRestrictionType left, JDrivingRestrictionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JDrivingRestrictionType left, JDrivingRestrictionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}