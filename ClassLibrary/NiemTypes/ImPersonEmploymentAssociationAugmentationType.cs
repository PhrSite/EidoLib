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
    /// A data type for additional information about an employment.
    /// </summary>
    [DataContract]
    public partial class ImPersonEmploymentAssociationAugmentationType : IEquatable<ImPersonEmploymentAssociationAugmentationType>
    { 
        /// <summary>
        /// A date through which an alien is authorized by DHS to work for a United States business. NIEM reference is im:EmploymentAuthorizationEndDate
        /// </summary>
        /// <value>A date through which an alien is authorized by DHS to work for a United States business. NIEM reference is im:EmploymentAuthorizationEndDate</value>

        [DataMember(Name="employmentAuthorizationEndDate")]
        public List<NcDateType> EmploymentAuthorizationEndDate { get; set; }

        /// <summary>
        /// A date that an alien is authorized by DHS to start work for a United States business. NIEM reference is im:EmploymentAuthorizationStartDate
        /// </summary>
        /// <value>A date that an alien is authorized by DHS to start work for a United States business. NIEM reference is im:EmploymentAuthorizationStartDate</value>

        [DataMember(Name="employmentAuthorizationStartDate")]
        public List<NcDateType> EmploymentAuthorizationStartDate { get; set; }

        /// <summary>
        /// A description of the alien&#x27;s work authorization by DHS to work for a United States business NIEM reference is im:EmploymentAuthorizationText
        /// </summary>
        /// <value>A description of the alien&#x27;s work authorization by DHS to work for a United States business NIEM reference is im:EmploymentAuthorizationText</value>

        [DataMember(Name="employmentAuthorization")]
        public List<NcTextType> EmploymentAuthorization { get; set; }

        /// <summary>
        /// A unit commonly used by the person in a particular position. NIEM reference is j:EmploymentAssignedUnitEnforcementUnit
        /// </summary>
        /// <value>A unit commonly used by the person in a particular position. NIEM reference is j:EmploymentAssignedUnitEnforcementUnit</value>

        [DataMember(Name="employmentAssignedUnitEnforcementUnit")]
        public List<JEnforcementUnitType> EmploymentAssignedUnitEnforcementUnit { get; set; }

        /// <summary>
        /// A unit commonly used by the person in a particular position. NIEM reference is j:EmploymentAssignedUnitOrganization
        /// </summary>
        /// <value>A unit commonly used by the person in a particular position. NIEM reference is j:EmploymentAssignedUnitOrganization</value>

        [DataMember(Name="employmentAssignedUnitOrganization")]
        public List<NcOrganizationType> EmploymentAssignedUnitOrganization { get; set; }

        /// <summary>
        /// True if the Department of Homeland Security (DHS), Immigration and Customs Enforcement (ICE) has authorized the alien to work for a United States business; false otherwise. NIEM reference is im:EmploymentAuthorizationIndicator
        /// </summary>
        /// <value>True if the Department of Homeland Security (DHS), Immigration and Customs Enforcement (ICE) has authorized the alien to work for a United States business; false otherwise. NIEM reference is im:EmploymentAuthorizationIndicator</value>

        [DataMember(Name="isEmploymentAuthorization")]
        public List<NiemXsboolean> IsEmploymentAuthorization { get; set; }

        /// <summary>
        /// imPersonEmploymentAssociationAugmentationType JSON-LD context
        /// </summary>
        /// <value>imPersonEmploymentAssociationAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsimPersonEmploymentAssociationAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/imPersonEmploymentAssociationAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/imPersonEmploymentAssociationAugmentationTypeContext.jsonld")]
            JSONLDContextsimPersonEmploymentAssociationAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// imPersonEmploymentAssociationAugmentationType JSON-LD context
        /// </summary>
        /// <value>imPersonEmploymentAssociationAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImPersonEmploymentAssociationAugmentationType {\n");
            sb.Append("  EmploymentAuthorizationEndDate: ").Append(EmploymentAuthorizationEndDate).Append("\n");
            sb.Append("  EmploymentAuthorizationStartDate: ").Append(EmploymentAuthorizationStartDate).Append("\n");
            sb.Append("  EmploymentAuthorization: ").Append(EmploymentAuthorization).Append("\n");
            sb.Append("  EmploymentAssignedUnitEnforcementUnit: ").Append(EmploymentAssignedUnitEnforcementUnit).Append("\n");
            sb.Append("  EmploymentAssignedUnitOrganization: ").Append(EmploymentAssignedUnitOrganization).Append("\n");
            sb.Append("  IsEmploymentAuthorization: ").Append(IsEmploymentAuthorization).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImPersonEmploymentAssociationAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if ImPersonEmploymentAssociationAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of ImPersonEmploymentAssociationAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImPersonEmploymentAssociationAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EmploymentAuthorizationEndDate == other.EmploymentAuthorizationEndDate ||
                    EmploymentAuthorizationEndDate != null &&
                    EmploymentAuthorizationEndDate.SequenceEqual(other.EmploymentAuthorizationEndDate)
                ) && 
                (
                    EmploymentAuthorizationStartDate == other.EmploymentAuthorizationStartDate ||
                    EmploymentAuthorizationStartDate != null &&
                    EmploymentAuthorizationStartDate.SequenceEqual(other.EmploymentAuthorizationStartDate)
                ) && 
                (
                    EmploymentAuthorization == other.EmploymentAuthorization ||
                    EmploymentAuthorization != null &&
                    EmploymentAuthorization.SequenceEqual(other.EmploymentAuthorization)
                ) && 
                (
                    EmploymentAssignedUnitEnforcementUnit == other.EmploymentAssignedUnitEnforcementUnit ||
                    EmploymentAssignedUnitEnforcementUnit != null &&
                    EmploymentAssignedUnitEnforcementUnit.SequenceEqual(other.EmploymentAssignedUnitEnforcementUnit)
                ) && 
                (
                    EmploymentAssignedUnitOrganization == other.EmploymentAssignedUnitOrganization ||
                    EmploymentAssignedUnitOrganization != null &&
                    EmploymentAssignedUnitOrganization.SequenceEqual(other.EmploymentAssignedUnitOrganization)
                ) && 
                (
                    IsEmploymentAuthorization == other.IsEmploymentAuthorization ||
                    IsEmploymentAuthorization != null &&
                    IsEmploymentAuthorization.SequenceEqual(other.IsEmploymentAuthorization)
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
                    if (EmploymentAuthorizationEndDate != null)
                    hashCode = hashCode * 59 + EmploymentAuthorizationEndDate.GetHashCode();
                    if (EmploymentAuthorizationStartDate != null)
                    hashCode = hashCode * 59 + EmploymentAuthorizationStartDate.GetHashCode();
                    if (EmploymentAuthorization != null)
                    hashCode = hashCode * 59 + EmploymentAuthorization.GetHashCode();
                    if (EmploymentAssignedUnitEnforcementUnit != null)
                    hashCode = hashCode * 59 + EmploymentAssignedUnitEnforcementUnit.GetHashCode();
                    if (EmploymentAssignedUnitOrganization != null)
                    hashCode = hashCode * 59 + EmploymentAssignedUnitOrganization.GetHashCode();
                    if (IsEmploymentAuthorization != null)
                    hashCode = hashCode * 59 + IsEmploymentAuthorization.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImPersonEmploymentAssociationAugmentationType left, ImPersonEmploymentAssociationAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImPersonEmploymentAssociationAugmentationType left, ImPersonEmploymentAssociationAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
