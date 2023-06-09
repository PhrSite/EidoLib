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
    /// A data type for how to contact a person or an organization.
    /// </summary>
    [DataContract]
    public partial class NcContactInformationType : IEquatable<NcContactInformationType>
    { 
        /// <summary>
        /// An electronic mailing address by which a person or organization may be contacted. NIEM reference is nc:ContactEmailID
        /// </summary>
        /// <value>An electronic mailing address by which a person or organization may be contacted. NIEM reference is nc:ContactEmailID</value>

        [DataMember(Name="contactEmailId")]
        public List<NiemXsstring> ContactEmailId { get; set; }

        /// <summary>
        /// A user account for an instant messaging program by which a person or organization may be contacted. NIEM reference is nc:ContactInstantMessenger
        /// </summary>
        /// <value>A user account for an instant messaging program by which a person or organization may be contacted. NIEM reference is nc:ContactInstantMessenger</value>

        [DataMember(Name="contactInstantMessenger")]
        public List<NcInstantMessengerType> ContactInstantMessenger { get; set; }

        /// <summary>
        /// A postal address by which a person or organization may be contacted. NIEM reference is nc:ContactMailingAddress
        /// </summary>
        /// <value>A postal address by which a person or organization may be contacted. NIEM reference is nc:ContactMailingAddress</value>

        [DataMember(Name="contactMailingAddress")]
        public List<NcAddressType> ContactMailingAddress { get; set; }

        /// <summary>
        /// A method of contacting a person or organization by messages over a radio. NIEM reference is nc:ContactRadio
        /// </summary>
        /// <value>A method of contacting a person or organization by messages over a radio. NIEM reference is nc:ContactRadio</value>

        [DataMember(Name="contactRadio")]
        public List<NcContactRadioType> ContactRadio { get; set; }

        /// <summary>
        /// A telephone number for a telecommunication device by which a person or organization may be contacted. NIEM reference is nc:ContactTelephoneNumber
        /// </summary>
        /// <value>A telephone number for a telecommunication device by which a person or organization may be contacted. NIEM reference is nc:ContactTelephoneNumber</value>

        [DataMember(Name="contactTelephoneNumber")]
        public List<NcTelephoneNumberType> ContactTelephoneNumber { get; set; }

        /// <summary>
        /// A website address by which a person or organization may be contacted. NIEM reference is nc:ContactWebsiteURI
        /// </summary>
        /// <value>A website address by which a person or organization may be contacted. NIEM reference is nc:ContactWebsiteURI</value>

        [DataMember(Name="contactWebsiteUri")]
        public List<NiemXsanyURI> ContactWebsiteUri { get; set; }

        /// <summary>
        /// An entity that may be contacted by using the given contact information. NIEM reference is nc:ContactEntity
        /// </summary>
        /// <value>An entity that may be contacted by using the given contact information. NIEM reference is nc:ContactEntity</value>

        [DataMember(Name="contactEntity")]
        public List<NcEntityType> ContactEntity { get; set; }

        /// <summary>
        /// A description of the entity being contacted. NIEM reference is nc:ContactEntityDescriptionText
        /// </summary>
        /// <value>A description of the entity being contacted. NIEM reference is nc:ContactEntityDescriptionText</value>

        [DataMember(Name="contactEntityDescription")]
        public List<NcTextType> ContactEntityDescription { get; set; }

        /// <summary>
        /// A description of the contact information. NIEM reference is nc:ContactInformationDescriptionText
        /// </summary>
        /// <value>A description of the contact information. NIEM reference is nc:ContactInformationDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A third party person who answers a call and connects or directs the caller to the intended person. NIEM reference is nc:ContactResponder
        /// </summary>
        /// <value>A third party person who answers a call and connects or directs the caller to the intended person. NIEM reference is nc:ContactResponder</value>

        [DataMember(Name="contactResponder")]
        public List<NcPersonType> ContactResponder { get; set; }

        /// <summary>
        /// A period of time or a situation in which an entity is available to be contacted with the given contact information. NIEM reference is nc:ContactInformationAvailabilityCode
        /// </summary>
        /// <value>A period of time or a situation in which an entity is available to be contacted with the given contact information. NIEM reference is nc:ContactInformationAvailabilityCode</value>

        [DataMember(Name="availabilityCode")]
        public List<NcContactInformationAvailabilityCodeType> AvailabilityCode { get; set; }

        /// <summary>
        /// A period of time or a situation in which an entity is available to be contacted with the given contact information. NIEM reference is nc:ContactInformationAvailabilityText
        /// </summary>
        /// <value>A period of time or a situation in which an entity is available to be contacted with the given contact information. NIEM reference is nc:ContactInformationAvailabilityText</value>

        [DataMember(Name="availability")]
        public List<NcTextType> Availability { get; set; }

        /// <summary>
        /// Additional information about contact information. NIEM reference is intel:ContactInformationAugmentation
        /// </summary>
        /// <value>Additional information about contact information. NIEM reference is intel:ContactInformationAugmentation</value>

        [DataMember(Name="intelAugmentation")]
        public List<IntelContactInformationAugmentationType> IntelAugmentation { get; set; }

        /// <summary>
        /// Additional information about a nc:Contact. NIEM reference is mo:ContactInformationAugmentation
        /// </summary>
        /// <value>Additional information about a nc:Contact. NIEM reference is mo:ContactInformationAugmentation</value>

        [DataMember(Name="moAugmentation")]
        public List<MoContactInformationAugmentationType> MoAugmentation { get; set; }

        /// <summary>
        /// ncContactInformationType JSON-LD context
        /// </summary>
        /// <value>ncContactInformationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncContactInformationTypeContextJsonldEnum for ../JSON-LD_Contexts/ncContactInformationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncContactInformationTypeContext.jsonld")]
            JSONLDContextsncContactInformationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncContactInformationType JSON-LD context
        /// </summary>
        /// <value>ncContactInformationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcContactInformationType {\n");
            sb.Append("  ContactEmailId: ").Append(ContactEmailId).Append("\n");
            sb.Append("  ContactInstantMessenger: ").Append(ContactInstantMessenger).Append("\n");
            sb.Append("  ContactMailingAddress: ").Append(ContactMailingAddress).Append("\n");
            sb.Append("  ContactRadio: ").Append(ContactRadio).Append("\n");
            sb.Append("  ContactTelephoneNumber: ").Append(ContactTelephoneNumber).Append("\n");
            sb.Append("  ContactWebsiteUri: ").Append(ContactWebsiteUri).Append("\n");
            sb.Append("  ContactEntity: ").Append(ContactEntity).Append("\n");
            sb.Append("  ContactEntityDescription: ").Append(ContactEntityDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ContactResponder: ").Append(ContactResponder).Append("\n");
            sb.Append("  AvailabilityCode: ").Append(AvailabilityCode).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  IntelAugmentation: ").Append(IntelAugmentation).Append("\n");
            sb.Append("  MoAugmentation: ").Append(MoAugmentation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcContactInformationType)obj);
        }

        /// <summary>
        /// Returns true if NcContactInformationType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcContactInformationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcContactInformationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ContactEmailId == other.ContactEmailId ||
                    ContactEmailId != null &&
                    ContactEmailId.SequenceEqual(other.ContactEmailId)
                ) && 
                (
                    ContactInstantMessenger == other.ContactInstantMessenger ||
                    ContactInstantMessenger != null &&
                    ContactInstantMessenger.SequenceEqual(other.ContactInstantMessenger)
                ) && 
                (
                    ContactMailingAddress == other.ContactMailingAddress ||
                    ContactMailingAddress != null &&
                    ContactMailingAddress.SequenceEqual(other.ContactMailingAddress)
                ) && 
                (
                    ContactRadio == other.ContactRadio ||
                    ContactRadio != null &&
                    ContactRadio.SequenceEqual(other.ContactRadio)
                ) && 
                (
                    ContactTelephoneNumber == other.ContactTelephoneNumber ||
                    ContactTelephoneNumber != null &&
                    ContactTelephoneNumber.SequenceEqual(other.ContactTelephoneNumber)
                ) && 
                (
                    ContactWebsiteUri == other.ContactWebsiteUri ||
                    ContactWebsiteUri != null &&
                    ContactWebsiteUri.SequenceEqual(other.ContactWebsiteUri)
                ) && 
                (
                    ContactEntity == other.ContactEntity ||
                    ContactEntity != null &&
                    ContactEntity.SequenceEqual(other.ContactEntity)
                ) && 
                (
                    ContactEntityDescription == other.ContactEntityDescription ||
                    ContactEntityDescription != null &&
                    ContactEntityDescription.SequenceEqual(other.ContactEntityDescription)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    ContactResponder == other.ContactResponder ||
                    ContactResponder != null &&
                    ContactResponder.SequenceEqual(other.ContactResponder)
                ) && 
                (
                    AvailabilityCode == other.AvailabilityCode ||
                    AvailabilityCode != null &&
                    AvailabilityCode.SequenceEqual(other.AvailabilityCode)
                ) && 
                (
                    Availability == other.Availability ||
                    Availability != null &&
                    Availability.SequenceEqual(other.Availability)
                ) && 
                (
                    IntelAugmentation == other.IntelAugmentation ||
                    IntelAugmentation != null &&
                    IntelAugmentation.SequenceEqual(other.IntelAugmentation)
                ) && 
                (
                    MoAugmentation == other.MoAugmentation ||
                    MoAugmentation != null &&
                    MoAugmentation.SequenceEqual(other.MoAugmentation)
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
                    if (ContactEmailId != null)
                    hashCode = hashCode * 59 + ContactEmailId.GetHashCode();
                    if (ContactInstantMessenger != null)
                    hashCode = hashCode * 59 + ContactInstantMessenger.GetHashCode();
                    if (ContactMailingAddress != null)
                    hashCode = hashCode * 59 + ContactMailingAddress.GetHashCode();
                    if (ContactRadio != null)
                    hashCode = hashCode * 59 + ContactRadio.GetHashCode();
                    if (ContactTelephoneNumber != null)
                    hashCode = hashCode * 59 + ContactTelephoneNumber.GetHashCode();
                    if (ContactWebsiteUri != null)
                    hashCode = hashCode * 59 + ContactWebsiteUri.GetHashCode();
                    if (ContactEntity != null)
                    hashCode = hashCode * 59 + ContactEntity.GetHashCode();
                    if (ContactEntityDescription != null)
                    hashCode = hashCode * 59 + ContactEntityDescription.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ContactResponder != null)
                    hashCode = hashCode * 59 + ContactResponder.GetHashCode();
                    if (AvailabilityCode != null)
                    hashCode = hashCode * 59 + AvailabilityCode.GetHashCode();
                    if (Availability != null)
                    hashCode = hashCode * 59 + Availability.GetHashCode();
                    if (IntelAugmentation != null)
                    hashCode = hashCode * 59 + IntelAugmentation.GetHashCode();
                    if (MoAugmentation != null)
                    hashCode = hashCode * 59 + MoAugmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcContactInformationType left, NcContactInformationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcContactInformationType left, NcContactInformationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
