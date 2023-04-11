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
    /// A data type for a set of details about a circumstance or factor that has an effect on an offense.
    /// </summary>
    [DataContract]
    public partial class JOffenseFactorType : IEquatable<JOffenseFactorType>
    { 
        /// <summary>
        /// A description of an offense factor. NIEM reference is j:OffenseFactorDescriptionText
        /// </summary>
        /// <value>A description of an offense factor. NIEM reference is j:OffenseFactorDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// True if a factor for an offense is known to be true; false if it is suspected, estimated, or otherwise. NIEM reference is j:OffenseFactorKnownIndicator
        /// </summary>
        /// <value>True if a factor for an offense is known to be true; false if it is suspected, estimated, or otherwise. NIEM reference is j:OffenseFactorKnownIndicator</value>

        [DataMember(Name="isKnown")]
        public List<NiemXsboolean> IsKnown { get; set; }

        /// <summary>
        /// A kind of specific detail or aspect of an incident factor or circumstance. NIEM reference is j:IncidentFactorSubCategoryText
        /// </summary>
        /// <value>A kind of specific detail or aspect of an incident factor or circumstance. NIEM reference is j:IncidentFactorSubCategoryText</value>

        [DataMember(Name="incidentFactorSubCategory")]
        public List<NcTextType> IncidentFactorSubCategory { get; set; }

        /// <summary>
        /// An offense factor designation. NIEM reference is j:OffenseFactorCode
        /// </summary>
        /// <value>An offense factor designation. NIEM reference is j:OffenseFactorCode</value>

        [DataMember(Name="code")]
        public List<UcrIncidentFactorCodeType> Code { get; set; }

        /// <summary>
        /// A designation of a justifiable homicide offense factor. NIEM reference is j:OffenseFactorJustifiableHomicideCode
        /// </summary>
        /// <value>A designation of a justifiable homicide offense factor. NIEM reference is j:OffenseFactorJustifiableHomicideCode</value>

        [DataMember(Name="justifiableHomicideCode")]
        public List<UcrJustifiableHomicideFactorsCodeType> JustifiableHomicideCode { get; set; }

        /// <summary>
        /// A designation for an aggravated assault or homicide offense factor. NIEM reference is j:OffenseFactorNIBRSAggravatedAssaultHomicideCode
        /// </summary>
        /// <value>A designation for an aggravated assault or homicide offense factor. NIEM reference is j:OffenseFactorNIBRSAggravatedAssaultHomicideCode</value>

        [DataMember(Name="nibrsAggravatedAssaultHomicideCode")]
        public List<UcrAggravatedAssaultHomicideFactorsCodeType> NibrsAggravatedAssaultHomicideCode { get; set; }

        /// <summary>
        /// An offense factor designation. NIEM reference is j:OffenseFactorText
        /// </summary>
        /// <value>An offense factor designation. NIEM reference is j:OffenseFactorText</value>

        [DataMember(Name="text")]
        public List<NcTextType> Text { get; set; }

        /// <summary>
        /// jOffenseFactorType JSON-LD context
        /// </summary>
        /// <value>jOffenseFactorType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjOffenseFactorTypeContextJsonldEnum for ../JSON-LD_Contexts/jOffenseFactorTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jOffenseFactorTypeContext.jsonld")]
            JSONLDContextsjOffenseFactorTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jOffenseFactorType JSON-LD context
        /// </summary>
        /// <value>jOffenseFactorType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JOffenseFactorType {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsKnown: ").Append(IsKnown).Append("\n");
            sb.Append("  IncidentFactorSubCategory: ").Append(IncidentFactorSubCategory).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  JustifiableHomicideCode: ").Append(JustifiableHomicideCode).Append("\n");
            sb.Append("  NibrsAggravatedAssaultHomicideCode: ").Append(NibrsAggravatedAssaultHomicideCode).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JOffenseFactorType)obj);
        }

        /// <summary>
        /// Returns true if JOffenseFactorType instances are equal
        /// </summary>
        /// <param name="other">Instance of JOffenseFactorType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JOffenseFactorType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    IsKnown == other.IsKnown ||
                    IsKnown != null &&
                    IsKnown.SequenceEqual(other.IsKnown)
                ) && 
                (
                    IncidentFactorSubCategory == other.IncidentFactorSubCategory ||
                    IncidentFactorSubCategory != null &&
                    IncidentFactorSubCategory.SequenceEqual(other.IncidentFactorSubCategory)
                ) && 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.SequenceEqual(other.Code)
                ) && 
                (
                    JustifiableHomicideCode == other.JustifiableHomicideCode ||
                    JustifiableHomicideCode != null &&
                    JustifiableHomicideCode.SequenceEqual(other.JustifiableHomicideCode)
                ) && 
                (
                    NibrsAggravatedAssaultHomicideCode == other.NibrsAggravatedAssaultHomicideCode ||
                    NibrsAggravatedAssaultHomicideCode != null &&
                    NibrsAggravatedAssaultHomicideCode.SequenceEqual(other.NibrsAggravatedAssaultHomicideCode)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.SequenceEqual(other.Text)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (IsKnown != null)
                    hashCode = hashCode * 59 + IsKnown.GetHashCode();
                    if (IncidentFactorSubCategory != null)
                    hashCode = hashCode * 59 + IncidentFactorSubCategory.GetHashCode();
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (JustifiableHomicideCode != null)
                    hashCode = hashCode * 59 + JustifiableHomicideCode.GetHashCode();
                    if (NibrsAggravatedAssaultHomicideCode != null)
                    hashCode = hashCode * 59 + NibrsAggravatedAssaultHomicideCode.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JOffenseFactorType left, JOffenseFactorType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JOffenseFactorType left, JOffenseFactorType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}