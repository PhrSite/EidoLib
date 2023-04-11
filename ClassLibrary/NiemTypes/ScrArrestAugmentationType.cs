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
    /// A data type for additional information about an arrest.
    /// </summary>
    [DataContract]
    public partial class ScrArrestAugmentationType : IEquatable<ScrArrestAugmentationType>
    { 
        /// <summary>
        /// True if the person arrested has requested a court hearing; false otherwise. NIEM reference is scr:HearingRequestIndicator
        /// </summary>
        /// <value>True if the person arrested has requested a court hearing; false otherwise. NIEM reference is scr:HearingRequestIndicator</value>

        [DataMember(Name="isHearingRequest")]
        public List<NiemXsboolean> IsHearingRequest { get; set; }

        /// <summary>
        /// A classification of the manner of ARREST NIEM reference is scr:ArrestMethod
        /// </summary>
        /// <value>A classification of the manner of ARREST NIEM reference is scr:ArrestMethod</value>

        [DataMember(Name="arrestMethod")]
        public List<ScrArrestMethodType> ArrestMethod { get; set; }

        /// <summary>
        /// A formal allegation that a specific person has committed a specific offense. NIEM reference is j:Charge
        /// </summary>
        /// <value>A formal allegation that a specific person has committed a specific offense. NIEM reference is j:Charge</value>

        [DataMember(Name="charge")]
        public List<JChargeType> Charge { get; set; }

        /// <summary>
        /// True if the alien was informed of his or her right to be represented by counsel; false otherwise. NIEM reference is im:AttorneyRightsIndicator
        /// </summary>
        /// <value>True if the alien was informed of his or her right to be represented by counsel; false otherwise. NIEM reference is im:AttorneyRightsIndicator</value>

        [DataMember(Name="isAttorneyRights")]
        public List<NiemXsboolean> IsAttorneyRights { get; set; }

        /// <summary>
        /// True if  the alien was arrested as a pedestrian; false otherwise NIEM reference is im:PedestrianIndicator
        /// </summary>
        /// <value>True if  the alien was arrested as a pedestrian; false otherwise NIEM reference is im:PedestrianIndicator</value>

        [DataMember(Name="isPedestrian")]
        public List<NiemXsboolean> IsPedestrian { get; set; }

        /// <summary>
        /// True if a juvenile individual should be treated as an adult in this specific ENFORCEMENT ENCOUNTER; false otherwise. NIEM reference is scr:TreatAsAdultIndicator
        /// </summary>
        /// <value>True if a juvenile individual should be treated as an adult in this specific ENFORCEMENT ENCOUNTER; false otherwise. NIEM reference is scr:TreatAsAdultIndicator</value>

        [DataMember(Name="isTreatAsAdult")]
        public List<NiemXsboolean> IsTreatAsAdult { get; set; }

        /// <summary>
        /// True if the alien was made aware of his/her right to use a telephone; false otherwise NIEM reference is im:PhoneUseRightsIndicator
        /// </summary>
        /// <value>True if the alien was made aware of his/her right to use a telephone; false otherwise NIEM reference is im:PhoneUseRightsIndicator</value>

        [DataMember(Name="isPhoneUseRights")]
        public List<NiemXsboolean> IsPhoneUseRights { get; set; }

        /// <summary>
        /// A number indicating the number of attempts made by telephone to contact the party responsible for the juvenile alien. NIEM reference is im:PhoneAttemptsQuantity
        /// </summary>
        /// <value>A number indicating the number of attempts made by telephone to contact the party responsible for the juvenile alien. NIEM reference is im:PhoneAttemptsQuantity</value>

        [DataMember(Name="phoneAttemptsQuantity")]
        public List<NcQuantityType> PhoneAttemptsQuantity { get; set; }

        /// <summary>
        /// True if  the officer assisted the alien in using a phone; false otherwise NIEM reference is im:PhoneAssistIndicator
        /// </summary>
        /// <value>True if  the officer assisted the alien in using a phone; false otherwise NIEM reference is im:PhoneAssistIndicator</value>

        [DataMember(Name="isPhoneAssist")]
        public List<NiemXsboolean> IsPhoneAssist { get; set; }

        /// <summary>
        /// True if the alien requested a hearing before a judge; false otherwise NIEM reference is im:HearingRightsIndicator
        /// </summary>
        /// <value>True if the alien requested a hearing before a judge; false otherwise NIEM reference is im:HearingRightsIndicator</value>

        [DataMember(Name="isHearingRights")]
        public List<NiemXsboolean> IsHearingRights { get; set; }

        /// <summary>
        /// True if the alien faces harm by returning to his/her country; false otherwise NIEM reference is im:FacingHarmIndicator
        /// </summary>
        /// <value>True if the alien faces harm by returning to his/her country; false otherwise NIEM reference is im:FacingHarmIndicator</value>

        [DataMember(Name="isFacingHarm")]
        public List<NiemXsboolean> IsFacingHarm { get; set; }

        /// <summary>
        /// True if the alien was informed of his/her right to contact his or her consulate; false otherwise. NIEM reference is im:ConsulateRightsIndicator
        /// </summary>
        /// <value>True if the alien was informed of his/her right to contact his or her consulate; false otherwise. NIEM reference is im:ConsulateRightsIndicator</value>

        [DataMember(Name="isConsulateRights")]
        public List<NiemXsboolean> IsConsulateRights { get; set; }

        /// <summary>
        /// True if  the alien exercised his or her right to request for counse; false otherwise NIEM reference is im:AttorneyRequestIndicator
        /// </summary>
        /// <value>True if  the alien exercised his or her right to request for counse; false otherwise NIEM reference is im:AttorneyRequestIndicator</value>

        [DataMember(Name="isAttorneyRequest")]
        public List<NiemXsboolean> IsAttorneyRequest { get; set; }

        /// <summary>
        /// A number indicating the distance in miles from a landmark to where the alien&#x27;s ARREST occurred. NIEM reference is im:DistanceFromLandmarkMeasure
        /// </summary>
        /// <value>A number indicating the distance in miles from a landmark to where the alien&#x27;s ARREST occurred. NIEM reference is im:DistanceFromLandmarkMeasure</value>

        [DataMember(Name="distanceFromLandmarkMeasure")]
        public List<NcLengthMeasureType> DistanceFromLandmarkMeasure { get; set; }

        /// <summary>
        /// scrArrestAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrArrestAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsscrArrestAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/scrArrestAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/scrArrestAugmentationTypeContext.jsonld")]
            JSONLDContextsscrArrestAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// scrArrestAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrArrestAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScrArrestAugmentationType {\n");
            sb.Append("  IsHearingRequest: ").Append(IsHearingRequest).Append("\n");
            sb.Append("  ArrestMethod: ").Append(ArrestMethod).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  IsAttorneyRights: ").Append(IsAttorneyRights).Append("\n");
            sb.Append("  IsPedestrian: ").Append(IsPedestrian).Append("\n");
            sb.Append("  IsTreatAsAdult: ").Append(IsTreatAsAdult).Append("\n");
            sb.Append("  IsPhoneUseRights: ").Append(IsPhoneUseRights).Append("\n");
            sb.Append("  PhoneAttemptsQuantity: ").Append(PhoneAttemptsQuantity).Append("\n");
            sb.Append("  IsPhoneAssist: ").Append(IsPhoneAssist).Append("\n");
            sb.Append("  IsHearingRights: ").Append(IsHearingRights).Append("\n");
            sb.Append("  IsFacingHarm: ").Append(IsFacingHarm).Append("\n");
            sb.Append("  IsConsulateRights: ").Append(IsConsulateRights).Append("\n");
            sb.Append("  IsAttorneyRequest: ").Append(IsAttorneyRequest).Append("\n");
            sb.Append("  DistanceFromLandmarkMeasure: ").Append(DistanceFromLandmarkMeasure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScrArrestAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if ScrArrestAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScrArrestAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScrArrestAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsHearingRequest == other.IsHearingRequest ||
                    IsHearingRequest != null &&
                    IsHearingRequest.SequenceEqual(other.IsHearingRequest)
                ) && 
                (
                    ArrestMethod == other.ArrestMethod ||
                    ArrestMethod != null &&
                    ArrestMethod.SequenceEqual(other.ArrestMethod)
                ) && 
                (
                    Charge == other.Charge ||
                    Charge != null &&
                    Charge.SequenceEqual(other.Charge)
                ) && 
                (
                    IsAttorneyRights == other.IsAttorneyRights ||
                    IsAttorneyRights != null &&
                    IsAttorneyRights.SequenceEqual(other.IsAttorneyRights)
                ) && 
                (
                    IsPedestrian == other.IsPedestrian ||
                    IsPedestrian != null &&
                    IsPedestrian.SequenceEqual(other.IsPedestrian)
                ) && 
                (
                    IsTreatAsAdult == other.IsTreatAsAdult ||
                    IsTreatAsAdult != null &&
                    IsTreatAsAdult.SequenceEqual(other.IsTreatAsAdult)
                ) && 
                (
                    IsPhoneUseRights == other.IsPhoneUseRights ||
                    IsPhoneUseRights != null &&
                    IsPhoneUseRights.SequenceEqual(other.IsPhoneUseRights)
                ) && 
                (
                    PhoneAttemptsQuantity == other.PhoneAttemptsQuantity ||
                    PhoneAttemptsQuantity != null &&
                    PhoneAttemptsQuantity.SequenceEqual(other.PhoneAttemptsQuantity)
                ) && 
                (
                    IsPhoneAssist == other.IsPhoneAssist ||
                    IsPhoneAssist != null &&
                    IsPhoneAssist.SequenceEqual(other.IsPhoneAssist)
                ) && 
                (
                    IsHearingRights == other.IsHearingRights ||
                    IsHearingRights != null &&
                    IsHearingRights.SequenceEqual(other.IsHearingRights)
                ) && 
                (
                    IsFacingHarm == other.IsFacingHarm ||
                    IsFacingHarm != null &&
                    IsFacingHarm.SequenceEqual(other.IsFacingHarm)
                ) && 
                (
                    IsConsulateRights == other.IsConsulateRights ||
                    IsConsulateRights != null &&
                    IsConsulateRights.SequenceEqual(other.IsConsulateRights)
                ) && 
                (
                    IsAttorneyRequest == other.IsAttorneyRequest ||
                    IsAttorneyRequest != null &&
                    IsAttorneyRequest.SequenceEqual(other.IsAttorneyRequest)
                ) && 
                (
                    DistanceFromLandmarkMeasure == other.DistanceFromLandmarkMeasure ||
                    DistanceFromLandmarkMeasure != null &&
                    DistanceFromLandmarkMeasure.SequenceEqual(other.DistanceFromLandmarkMeasure)
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
                    if (IsHearingRequest != null)
                    hashCode = hashCode * 59 + IsHearingRequest.GetHashCode();
                    if (ArrestMethod != null)
                    hashCode = hashCode * 59 + ArrestMethod.GetHashCode();
                    if (Charge != null)
                    hashCode = hashCode * 59 + Charge.GetHashCode();
                    if (IsAttorneyRights != null)
                    hashCode = hashCode * 59 + IsAttorneyRights.GetHashCode();
                    if (IsPedestrian != null)
                    hashCode = hashCode * 59 + IsPedestrian.GetHashCode();
                    if (IsTreatAsAdult != null)
                    hashCode = hashCode * 59 + IsTreatAsAdult.GetHashCode();
                    if (IsPhoneUseRights != null)
                    hashCode = hashCode * 59 + IsPhoneUseRights.GetHashCode();
                    if (PhoneAttemptsQuantity != null)
                    hashCode = hashCode * 59 + PhoneAttemptsQuantity.GetHashCode();
                    if (IsPhoneAssist != null)
                    hashCode = hashCode * 59 + IsPhoneAssist.GetHashCode();
                    if (IsHearingRights != null)
                    hashCode = hashCode * 59 + IsHearingRights.GetHashCode();
                    if (IsFacingHarm != null)
                    hashCode = hashCode * 59 + IsFacingHarm.GetHashCode();
                    if (IsConsulateRights != null)
                    hashCode = hashCode * 59 + IsConsulateRights.GetHashCode();
                    if (IsAttorneyRequest != null)
                    hashCode = hashCode * 59 + IsAttorneyRequest.GetHashCode();
                    if (DistanceFromLandmarkMeasure != null)
                    hashCode = hashCode * 59 + DistanceFromLandmarkMeasure.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScrArrestAugmentationType left, ScrArrestAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScrArrestAugmentationType left, ScrArrestAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
