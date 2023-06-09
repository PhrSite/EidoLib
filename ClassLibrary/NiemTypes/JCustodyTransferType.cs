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
    /// A data type for a transfer of custody or a transfer of a subject or property from one enforcement party to another.
    /// </summary>
    [DataContract]
    public partial class JCustodyTransferType : NcActivityType, IEquatable<JCustodyTransferType>
    { 
        /// <summary>
        /// An action taken in the transfer of custody. NIEM reference is j:CustodyTransferActionText
        /// </summary>
        /// <value>An action taken in the transfer of custody. NIEM reference is j:CustodyTransferActionText</value>

        [DataMember(Name="action")]
        public List<NcTextType> Action { get; set; }

        /// <summary>
        /// A location where transfer of custody occurs. NIEM reference is j:CustodyTransferLocation
        /// </summary>
        /// <value>A location where transfer of custody occurs. NIEM reference is j:CustodyTransferLocation</value>

        [DataMember(Name="location")]
        public List<NcLocationType> Location { get; set; }

        /// <summary>
        /// A piece of property which is being transferred from one custody to another. NIEM reference is j:CustodyTransferItem
        /// </summary>
        /// <value>A piece of property which is being transferred from one custody to another. NIEM reference is j:CustodyTransferItem</value>

        [DataMember(Name="item")]
        public List<NcItemType> Item { get; set; }

        /// <summary>
        /// An enforcement agency that receives custody of a subject or property. NIEM reference is j:CustodyTransferReceivingEnforcementAgency
        /// </summary>
        /// <value>An enforcement agency that receives custody of a subject or property. NIEM reference is j:CustodyTransferReceivingEnforcementAgency</value>

        [DataMember(Name="receivingEnforcementAgency")]
        public List<NcOrganizationType> ReceivingEnforcementAgency { get; set; }

        /// <summary>
        /// An enforcement facility that receives custody of a subject or property. NIEM reference is j:CustodyTransferReceivingEnforcementFacility
        /// </summary>
        /// <value>An enforcement facility that receives custody of a subject or property. NIEM reference is j:CustodyTransferReceivingEnforcementFacility</value>

        [DataMember(Name="receivingEnforcementFacility")]
        public List<NcFacilityType> ReceivingEnforcementFacility { get; set; }

        /// <summary>
        /// A peace official that receives custody of a subject or property. NIEM reference is j:CustodyTransferReceivingEnforcementOfficial
        /// </summary>
        /// <value>A peace official that receives custody of a subject or property. NIEM reference is j:CustodyTransferReceivingEnforcementOfficial</value>

        [DataMember(Name="receivingEnforcementOfficial")]
        public List<JEnforcementOfficialType> ReceivingEnforcementOfficial { get; set; }

        /// <summary>
        /// An enforcement agency that releases custody of a subject or property. NIEM reference is j:CustodyTransferReleasingEnforcementAgency
        /// </summary>
        /// <value>An enforcement agency that releases custody of a subject or property. NIEM reference is j:CustodyTransferReleasingEnforcementAgency</value>

        [DataMember(Name="releasingEnforcementAgency")]
        public List<NcOrganizationType> ReleasingEnforcementAgency { get; set; }

        /// <summary>
        /// An enforcement facility that releases custody of a subject or property. NIEM reference is j:CustodyTransferReleasingEnforcementFacility
        /// </summary>
        /// <value>An enforcement facility that releases custody of a subject or property. NIEM reference is j:CustodyTransferReleasingEnforcementFacility</value>

        [DataMember(Name="releasingEnforcementFacility")]
        public List<NcFacilityType> ReleasingEnforcementFacility { get; set; }

        /// <summary>
        /// A peace official that releases custody of a subject or property. NIEM reference is j:CustodyTransferReleasingEnforcementOfficial
        /// </summary>
        /// <value>A peace official that releases custody of a subject or property. NIEM reference is j:CustodyTransferReleasingEnforcementOfficial</value>

        [DataMember(Name="releasingEnforcementOfficial")]
        public List<JEnforcementOfficialType> ReleasingEnforcementOfficial { get; set; }

        /// <summary>
        /// A person who is being transferred from one custody to another. NIEM reference is j:CustodyTransferSubject
        /// </summary>
        /// <value>A person who is being transferred from one custody to another. NIEM reference is j:CustodyTransferSubject</value>

        [DataMember(Name="subject")]
        public List<JSubjectType> Subject { get; set; }

        /// <summary>
        /// jCustodyTransferType JSON-LD context
        /// </summary>
        /// <value>jCustodyTransferType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjCustodyTransferTypeContextJsonldEnum for ../JSON-LD_Contexts/jCustodyTransferTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jCustodyTransferTypeContext.jsonld")]
            JSONLDContextsjCustodyTransferTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jCustodyTransferType JSON-LD context
        /// </summary>
        /// <value>jCustodyTransferType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JCustodyTransferType {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  ReceivingEnforcementAgency: ").Append(ReceivingEnforcementAgency).Append("\n");
            sb.Append("  ReceivingEnforcementFacility: ").Append(ReceivingEnforcementFacility).Append("\n");
            sb.Append("  ReceivingEnforcementOfficial: ").Append(ReceivingEnforcementOfficial).Append("\n");
            sb.Append("  ReleasingEnforcementAgency: ").Append(ReleasingEnforcementAgency).Append("\n");
            sb.Append("  ReleasingEnforcementFacility: ").Append(ReleasingEnforcementFacility).Append("\n");
            sb.Append("  ReleasingEnforcementOfficial: ").Append(ReleasingEnforcementOfficial).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JCustodyTransferType)obj);
        }

        /// <summary>
        /// Returns true if JCustodyTransferType instances are equal
        /// </summary>
        /// <param name="other">Instance of JCustodyTransferType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JCustodyTransferType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.SequenceEqual(other.Action)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.SequenceEqual(other.Location)
                ) && 
                (
                    Item == other.Item ||
                    Item != null &&
                    Item.SequenceEqual(other.Item)
                ) && 
                (
                    ReceivingEnforcementAgency == other.ReceivingEnforcementAgency ||
                    ReceivingEnforcementAgency != null &&
                    ReceivingEnforcementAgency.SequenceEqual(other.ReceivingEnforcementAgency)
                ) && 
                (
                    ReceivingEnforcementFacility == other.ReceivingEnforcementFacility ||
                    ReceivingEnforcementFacility != null &&
                    ReceivingEnforcementFacility.SequenceEqual(other.ReceivingEnforcementFacility)
                ) && 
                (
                    ReceivingEnforcementOfficial == other.ReceivingEnforcementOfficial ||
                    ReceivingEnforcementOfficial != null &&
                    ReceivingEnforcementOfficial.SequenceEqual(other.ReceivingEnforcementOfficial)
                ) && 
                (
                    ReleasingEnforcementAgency == other.ReleasingEnforcementAgency ||
                    ReleasingEnforcementAgency != null &&
                    ReleasingEnforcementAgency.SequenceEqual(other.ReleasingEnforcementAgency)
                ) && 
                (
                    ReleasingEnforcementFacility == other.ReleasingEnforcementFacility ||
                    ReleasingEnforcementFacility != null &&
                    ReleasingEnforcementFacility.SequenceEqual(other.ReleasingEnforcementFacility)
                ) && 
                (
                    ReleasingEnforcementOfficial == other.ReleasingEnforcementOfficial ||
                    ReleasingEnforcementOfficial != null &&
                    ReleasingEnforcementOfficial.SequenceEqual(other.ReleasingEnforcementOfficial)
                ) && 
                (
                    Subject == other.Subject ||
                    Subject != null &&
                    Subject.SequenceEqual(other.Subject)
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
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (Item != null)
                    hashCode = hashCode * 59 + Item.GetHashCode();
                    if (ReceivingEnforcementAgency != null)
                    hashCode = hashCode * 59 + ReceivingEnforcementAgency.GetHashCode();
                    if (ReceivingEnforcementFacility != null)
                    hashCode = hashCode * 59 + ReceivingEnforcementFacility.GetHashCode();
                    if (ReceivingEnforcementOfficial != null)
                    hashCode = hashCode * 59 + ReceivingEnforcementOfficial.GetHashCode();
                    if (ReleasingEnforcementAgency != null)
                    hashCode = hashCode * 59 + ReleasingEnforcementAgency.GetHashCode();
                    if (ReleasingEnforcementFacility != null)
                    hashCode = hashCode * 59 + ReleasingEnforcementFacility.GetHashCode();
                    if (ReleasingEnforcementOfficial != null)
                    hashCode = hashCode * 59 + ReleasingEnforcementOfficial.GetHashCode();
                    if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JCustodyTransferType left, JCustodyTransferType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JCustodyTransferType left, JCustodyTransferType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
