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
    /// A data type for an ability to complete a task or execute a course of action under specified condition and level of performance.
    /// </summary>
    [DataContract]
    public partial class NcCapabilityType : IEquatable<NcCapabilityType>
    { 
        /// <summary>
        /// A date for the start of a capability. NIEM reference is nc:CapabilityStartDate
        /// </summary>
        /// <value>A date for the start of a capability. NIEM reference is nc:CapabilityStartDate</value>

        [DataMember(Name="startDate")]
        public List<NcDateType> StartDate { get; set; }

        /// <summary>
        /// A date that ends the capability NIEM reference is nc:CapabilityEndDate
        /// </summary>
        /// <value>A date that ends the capability NIEM reference is nc:CapabilityEndDate</value>

        [DataMember(Name="endDate")]
        public List<NcDateType> EndDate { get; set; }

        /// <summary>
        /// A general classification of a kind of capacity or ability. NIEM reference is nc:CapabilityGeneralCategoryText
        /// </summary>
        /// <value>A general classification of a kind of capacity or ability. NIEM reference is nc:CapabilityGeneralCategoryText</value>

        [DataMember(Name="generalCategory")]
        public List<NcTextType> GeneralCategory { get; set; }

        /// <summary>
        /// An identification for a capability. NIEM reference is nc:CapabilityIdentification
        /// </summary>
        /// <value>An identification for a capability. NIEM reference is nc:CapabilityIdentification</value>

        [DataMember(Name="identification")]
        public List<NcIdentificationType> Identification { get; set; }

        /// <summary>
        /// A name for a capability. NIEM reference is nc:CapabilityName
        /// </summary>
        /// <value>A name for a capability. NIEM reference is nc:CapabilityName</value>

        [DataMember(Name="name")]
        public List<NcTextType> Name { get; set; }

        /// <summary>
        /// A specific kind of capacity or ability. NIEM reference is nc:CapabilityCategoryText
        /// </summary>
        /// <value>A specific kind of capacity or ability. NIEM reference is nc:CapabilityCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A description of a capacity or ability. NIEM reference is nc:CapabilityDescriptionText
        /// </summary>
        /// <value>A description of a capacity or ability. NIEM reference is nc:CapabilityDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// True if a capability implies an inability to do something; false otherwise. NIEM reference is nc:CapabilityIsLimitationIndicator
        /// </summary>
        /// <value>True if a capability implies an inability to do something; false otherwise. NIEM reference is nc:CapabilityIsLimitationIndicator</value>

        [DataMember(Name="isIsLimitation")]
        public List<NiemXsboolean> IsIsLimitation { get; set; }

        /// <summary>
        /// Additional information about a capability. NIEM reference is intel:CapabilityAugmentation
        /// </summary>
        /// <value>Additional information about a capability. NIEM reference is intel:CapabilityAugmentation</value>

        [DataMember(Name="augmentation")]
        public List<IntelCapabilityAugmentationType> Augmentation { get; set; }

        /// <summary>
        /// ncCapabilityType JSON-LD context
        /// </summary>
        /// <value>ncCapabilityType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncCapabilityTypeContextJsonldEnum for ../JSON-LD_Contexts/ncCapabilityTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncCapabilityTypeContext.jsonld")]
            JSONLDContextsncCapabilityTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncCapabilityType JSON-LD context
        /// </summary>
        /// <value>ncCapabilityType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcCapabilityType {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  GeneralCategory: ").Append(GeneralCategory).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsIsLimitation: ").Append(IsIsLimitation).Append("\n");
            sb.Append("  Augmentation: ").Append(Augmentation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcCapabilityType)obj);
        }

        /// <summary>
        /// Returns true if NcCapabilityType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcCapabilityType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcCapabilityType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.SequenceEqual(other.StartDate)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.SequenceEqual(other.EndDate)
                ) && 
                (
                    GeneralCategory == other.GeneralCategory ||
                    GeneralCategory != null &&
                    GeneralCategory.SequenceEqual(other.GeneralCategory)
                ) && 
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.SequenceEqual(other.Identification)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.SequenceEqual(other.Name)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    IsIsLimitation == other.IsIsLimitation ||
                    IsIsLimitation != null &&
                    IsIsLimitation.SequenceEqual(other.IsIsLimitation)
                ) && 
                (
                    Augmentation == other.Augmentation ||
                    Augmentation != null &&
                    Augmentation.SequenceEqual(other.Augmentation)
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
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (GeneralCategory != null)
                    hashCode = hashCode * 59 + GeneralCategory.GetHashCode();
                    if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (IsIsLimitation != null)
                    hashCode = hashCode * 59 + IsIsLimitation.GetHashCode();
                    if (Augmentation != null)
                    hashCode = hashCode * 59 + Augmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcCapabilityType left, NcCapabilityType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcCapabilityType left, NcCapabilityType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
