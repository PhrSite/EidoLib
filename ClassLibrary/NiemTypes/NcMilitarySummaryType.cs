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
    /// A data type for a service of a person in a military.
    /// </summary>
    [DataContract]
    public partial class NcMilitarySummaryType : IEquatable<NcMilitarySummaryType>
    { 
        /// <summary>
        /// A name of a military branch in which a person served. NIEM reference is nc:MilitaryBranchName
        /// </summary>
        /// <value>A name of a military branch in which a person served. NIEM reference is nc:MilitaryBranchName</value>

        [DataMember(Name="militaryBranchName")]
        public List<NcTextType> MilitaryBranchName { get; set; }

        /// <summary>
        /// A date a person was released from further military obligations. NIEM reference is nc:MilitaryDischargeDate
        /// </summary>
        /// <value>A date a person was released from further military obligations. NIEM reference is nc:MilitaryDischargeDate</value>

        [DataMember(Name="militaryDischargeDate")]
        public List<NcDateType> MilitaryDischargeDate { get; set; }

        /// <summary>
        /// A kind of discharge a person received from military service. NIEM reference is nc:MilitaryDischargeCategoryCode
        /// </summary>
        /// <value>A kind of discharge a person received from military service. NIEM reference is nc:MilitaryDischargeCategoryCode</value>

        [DataMember(Name="militaryDischargeCategoryCode")]
        public List<NcMilitaryDischargeCategoryCodeType> MilitaryDischargeCategoryCode { get; set; }

        /// <summary>
        /// A kind of discharge a person received from military service. NIEM reference is nc:MilitaryDischargeCategoryText
        /// </summary>
        /// <value>A kind of discharge a person received from military service. NIEM reference is nc:MilitaryDischargeCategoryText</value>

        [DataMember(Name="militaryDischargeCategory")]
        public List<NcTextType> MilitaryDischargeCategory { get; set; }

        /// <summary>
        /// A description of why a person was excused from military service. NIEM reference is nc:MilitaryExemptionDescriptionText
        /// </summary>
        /// <value>A description of why a person was excused from military service. NIEM reference is nc:MilitaryExemptionDescriptionText</value>

        [DataMember(Name="militaryExemptionDescription")]
        public List<NcTextType> MilitaryExemptionDescription { get; set; }

        /// <summary>
        /// True if a person has some form of military experience; false otherwise. NIEM reference is nc:MilitaryExperienceIndicator
        /// </summary>
        /// <value>True if a person has some form of military experience; false otherwise. NIEM reference is nc:MilitaryExperienceIndicator</value>

        [DataMember(Name="isMilitaryExperience")]
        public List<NiemXsboolean> IsMilitaryExperience { get; set; }

        /// <summary>
        /// A date a person was released from active service in a military. NIEM reference is nc:MilitaryReleaseDate
        /// </summary>
        /// <value>A date a person was released from active service in a military. NIEM reference is nc:MilitaryReleaseDate</value>

        [DataMember(Name="militaryReleaseDate")]
        public List<NcDateType> MilitaryReleaseDate { get; set; }

        /// <summary>
        /// A kind of release a person received from military service. NIEM reference is nc:MilitaryReleaseCategoryText
        /// </summary>
        /// <value>A kind of release a person received from military service. NIEM reference is nc:MilitaryReleaseCategoryText</value>

        [DataMember(Name="militaryReleaseCategory")]
        public List<NcTextType> MilitaryReleaseCategory { get; set; }

        /// <summary>
        /// True if a person is currently serving in the military; false otherwise. NIEM reference is nc:MilitaryServiceActiveIndicator
        /// </summary>
        /// <value>True if a person is currently serving in the military; false otherwise. NIEM reference is nc:MilitaryServiceActiveIndicator</value>

        [DataMember(Name="isMilitaryServiceActive")]
        public List<NiemXsboolean> IsMilitaryServiceActive { get; set; }

        /// <summary>
        /// A quantity of time a person spent in military service. NIEM reference is nc:MilitaryServiceTimeMeasure
        /// </summary>
        /// <value>A quantity of time a person spent in military service. NIEM reference is nc:MilitaryServiceTimeMeasure</value>

        [DataMember(Name="militaryServiceTimeMeasure")]
        public List<NcTimeMeasureType> MilitaryServiceTimeMeasure { get; set; }

        /// <summary>
        /// A status of military service of a person. NIEM reference is nc:MilitaryStatus
        /// </summary>
        /// <value>A status of military service of a person. NIEM reference is nc:MilitaryStatus</value>

        [DataMember(Name="militaryStatus")]
        public List<NcStatusType> MilitaryStatus { get; set; }

        /// <summary>
        /// A country in whose military a person served. NIEM reference is nc:MilitaryCountry
        /// </summary>
        /// <value>A country in whose military a person served. NIEM reference is nc:MilitaryCountry</value>

        [DataMember(Name="militaryCountry")]
        public List<NcCountryType> MilitaryCountry { get; set; }

        /// <summary>
        /// Additional information about a person&#x27;s military service. NIEM reference is hs:MilitarySummaryAugmentation
        /// </summary>
        /// <value>Additional information about a person&#x27;s military service. NIEM reference is hs:MilitarySummaryAugmentation</value>

        [DataMember(Name="hsAugmentation")]
        public List<HsMilitarySummaryAugmentationType> HsAugmentation { get; set; }

        /// <summary>
        /// Additional information about a military summary. NIEM reference is j:MilitarySummaryAugmentation
        /// </summary>
        /// <value>Additional information about a military summary. NIEM reference is j:MilitarySummaryAugmentation</value>

        [DataMember(Name="jAugmentation")]
        public List<JMilitarySummaryAugmentationType> JAugmentation { get; set; }

        /// <summary>
        /// ncMilitarySummaryType JSON-LD context
        /// </summary>
        /// <value>ncMilitarySummaryType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncMilitarySummaryTypeContextJsonldEnum for ../JSON-LD_Contexts/ncMilitarySummaryTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncMilitarySummaryTypeContext.jsonld")]
            JSONLDContextsncMilitarySummaryTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncMilitarySummaryType JSON-LD context
        /// </summary>
        /// <value>ncMilitarySummaryType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcMilitarySummaryType {\n");
            sb.Append("  MilitaryBranchName: ").Append(MilitaryBranchName).Append("\n");
            sb.Append("  MilitaryDischargeDate: ").Append(MilitaryDischargeDate).Append("\n");
            sb.Append("  MilitaryDischargeCategoryCode: ").Append(MilitaryDischargeCategoryCode).Append("\n");
            sb.Append("  MilitaryDischargeCategory: ").Append(MilitaryDischargeCategory).Append("\n");
            sb.Append("  MilitaryExemptionDescription: ").Append(MilitaryExemptionDescription).Append("\n");
            sb.Append("  IsMilitaryExperience: ").Append(IsMilitaryExperience).Append("\n");
            sb.Append("  MilitaryReleaseDate: ").Append(MilitaryReleaseDate).Append("\n");
            sb.Append("  MilitaryReleaseCategory: ").Append(MilitaryReleaseCategory).Append("\n");
            sb.Append("  IsMilitaryServiceActive: ").Append(IsMilitaryServiceActive).Append("\n");
            sb.Append("  MilitaryServiceTimeMeasure: ").Append(MilitaryServiceTimeMeasure).Append("\n");
            sb.Append("  MilitaryStatus: ").Append(MilitaryStatus).Append("\n");
            sb.Append("  MilitaryCountry: ").Append(MilitaryCountry).Append("\n");
            sb.Append("  HsAugmentation: ").Append(HsAugmentation).Append("\n");
            sb.Append("  JAugmentation: ").Append(JAugmentation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcMilitarySummaryType)obj);
        }

        /// <summary>
        /// Returns true if NcMilitarySummaryType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcMilitarySummaryType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcMilitarySummaryType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MilitaryBranchName == other.MilitaryBranchName ||
                    MilitaryBranchName != null &&
                    MilitaryBranchName.SequenceEqual(other.MilitaryBranchName)
                ) && 
                (
                    MilitaryDischargeDate == other.MilitaryDischargeDate ||
                    MilitaryDischargeDate != null &&
                    MilitaryDischargeDate.SequenceEqual(other.MilitaryDischargeDate)
                ) && 
                (
                    MilitaryDischargeCategoryCode == other.MilitaryDischargeCategoryCode ||
                    MilitaryDischargeCategoryCode != null &&
                    MilitaryDischargeCategoryCode.SequenceEqual(other.MilitaryDischargeCategoryCode)
                ) && 
                (
                    MilitaryDischargeCategory == other.MilitaryDischargeCategory ||
                    MilitaryDischargeCategory != null &&
                    MilitaryDischargeCategory.SequenceEqual(other.MilitaryDischargeCategory)
                ) && 
                (
                    MilitaryExemptionDescription == other.MilitaryExemptionDescription ||
                    MilitaryExemptionDescription != null &&
                    MilitaryExemptionDescription.SequenceEqual(other.MilitaryExemptionDescription)
                ) && 
                (
                    IsMilitaryExperience == other.IsMilitaryExperience ||
                    IsMilitaryExperience != null &&
                    IsMilitaryExperience.SequenceEqual(other.IsMilitaryExperience)
                ) && 
                (
                    MilitaryReleaseDate == other.MilitaryReleaseDate ||
                    MilitaryReleaseDate != null &&
                    MilitaryReleaseDate.SequenceEqual(other.MilitaryReleaseDate)
                ) && 
                (
                    MilitaryReleaseCategory == other.MilitaryReleaseCategory ||
                    MilitaryReleaseCategory != null &&
                    MilitaryReleaseCategory.SequenceEqual(other.MilitaryReleaseCategory)
                ) && 
                (
                    IsMilitaryServiceActive == other.IsMilitaryServiceActive ||
                    IsMilitaryServiceActive != null &&
                    IsMilitaryServiceActive.SequenceEqual(other.IsMilitaryServiceActive)
                ) && 
                (
                    MilitaryServiceTimeMeasure == other.MilitaryServiceTimeMeasure ||
                    MilitaryServiceTimeMeasure != null &&
                    MilitaryServiceTimeMeasure.SequenceEqual(other.MilitaryServiceTimeMeasure)
                ) && 
                (
                    MilitaryStatus == other.MilitaryStatus ||
                    MilitaryStatus != null &&
                    MilitaryStatus.SequenceEqual(other.MilitaryStatus)
                ) && 
                (
                    MilitaryCountry == other.MilitaryCountry ||
                    MilitaryCountry != null &&
                    MilitaryCountry.SequenceEqual(other.MilitaryCountry)
                ) && 
                (
                    HsAugmentation == other.HsAugmentation ||
                    HsAugmentation != null &&
                    HsAugmentation.SequenceEqual(other.HsAugmentation)
                ) && 
                (
                    JAugmentation == other.JAugmentation ||
                    JAugmentation != null &&
                    JAugmentation.SequenceEqual(other.JAugmentation)
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
                    if (MilitaryBranchName != null)
                    hashCode = hashCode * 59 + MilitaryBranchName.GetHashCode();
                    if (MilitaryDischargeDate != null)
                    hashCode = hashCode * 59 + MilitaryDischargeDate.GetHashCode();
                    if (MilitaryDischargeCategoryCode != null)
                    hashCode = hashCode * 59 + MilitaryDischargeCategoryCode.GetHashCode();
                    if (MilitaryDischargeCategory != null)
                    hashCode = hashCode * 59 + MilitaryDischargeCategory.GetHashCode();
                    if (MilitaryExemptionDescription != null)
                    hashCode = hashCode * 59 + MilitaryExemptionDescription.GetHashCode();
                    if (IsMilitaryExperience != null)
                    hashCode = hashCode * 59 + IsMilitaryExperience.GetHashCode();
                    if (MilitaryReleaseDate != null)
                    hashCode = hashCode * 59 + MilitaryReleaseDate.GetHashCode();
                    if (MilitaryReleaseCategory != null)
                    hashCode = hashCode * 59 + MilitaryReleaseCategory.GetHashCode();
                    if (IsMilitaryServiceActive != null)
                    hashCode = hashCode * 59 + IsMilitaryServiceActive.GetHashCode();
                    if (MilitaryServiceTimeMeasure != null)
                    hashCode = hashCode * 59 + MilitaryServiceTimeMeasure.GetHashCode();
                    if (MilitaryStatus != null)
                    hashCode = hashCode * 59 + MilitaryStatus.GetHashCode();
                    if (MilitaryCountry != null)
                    hashCode = hashCode * 59 + MilitaryCountry.GetHashCode();
                    if (HsAugmentation != null)
                    hashCode = hashCode * 59 + HsAugmentation.GetHashCode();
                    if (JAugmentation != null)
                    hashCode = hashCode * 59 + JAugmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcMilitarySummaryType left, NcMilitarySummaryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcMilitarySummaryType left, NcMilitarySummaryType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
