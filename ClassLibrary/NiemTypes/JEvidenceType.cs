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
    /// A data type for an item received by or submitted to an agency for use in ascertaining the truth of a matter.
    /// </summary>
    [DataContract]
    public partial class JEvidenceType : IEquatable<JEvidenceType>
    { 
        /// <summary>
        /// A biometric object of which the role object is a function. NIEM reference is j:RoleOfBiometric
        /// </summary>
        /// <value>A biometric object of which the role object is a function. NIEM reference is j:RoleOfBiometric</value>

        [DataMember(Name="roleOfBiometric")]
        public List<BiomBiometricDataType> RoleOfBiometric { get; set; }

        /// <summary>
        /// An entity of whom the role object is a function. NIEM reference is nc:RoleOfItem
        /// </summary>
        /// <value>An entity of whom the role object is a function. NIEM reference is nc:RoleOfItem</value>

        [DataMember(Name="roleOfItem")]
        public List<NcItemType> RoleOfItem { get; set; }

        /// <summary>
        /// A piece of evidence. NIEM reference is j:EvidenceItemText
        /// </summary>
        /// <value>A piece of evidence. NIEM reference is j:EvidenceItemText</value>

        [DataMember(Name="item")]
        public List<NcTextType> Item { get; set; }

        /// <summary>
        /// An estimated or actual monetary value of a piece of evidence. NIEM reference is j:EvidenceAmount
        /// </summary>
        /// <value>An estimated or actual monetary value of a piece of evidence. NIEM reference is j:EvidenceAmount</value>

        [DataMember(Name="amount")]
        public List<NcAmountType> Amount { get; set; }

        /// <summary>
        /// A set of contact information for a piece of evidence. NIEM reference is j:EvidenceItemContactInformation
        /// </summary>
        /// <value>A set of contact information for a piece of evidence. NIEM reference is j:EvidenceItemContactInformation</value>

        [DataMember(Name="itemContactInformation")]
        public List<NcContactInformationType> ItemContactInformation { get; set; }

        /// <summary>
        /// An evidentiary document encoded in binary relating to the evidence. NIEM reference is j:EvidenceDocumentationBinary
        /// </summary>
        /// <value>An evidentiary document encoded in binary relating to the evidence. NIEM reference is j:EvidenceDocumentationBinary</value>

        [DataMember(Name="documentationBinary")]
        public List<NcBinaryType> DocumentationBinary { get; set; }

        /// <summary>
        /// A number assigned by the Integrated Ballistic Identification System (IBIS) to a bullet or cartridge casing image maintained in the IBIS System which is maintained by the Bureau of Alcohol, Tobacco, and Firearms. NIEM reference is j:IBISNumberText
        /// </summary>
        /// <value>A number assigned by the Integrated Ballistic Identification System (IBIS) to a bullet or cartridge casing image maintained in the IBIS System which is maintained by the Bureau of Alcohol, Tobacco, and Firearms. NIEM reference is j:IBISNumberText</value>

        [DataMember(Name="ibisNumber")]
        public List<NcTextType> IbisNumber { get; set; }

        /// <summary>
        /// A binary object of which the role object is a function. NIEM reference is j:RoleOfBinary
        /// </summary>
        /// <value>A binary object of which the role object is a function. NIEM reference is j:RoleOfBinary</value>

        [DataMember(Name="roleOfBinary")]
        public List<NcBinaryType> RoleOfBinary { get; set; }

        /// <summary>
        /// A person who collected a particular piece of evidence. NIEM reference is j:EvidenceCollector
        /// </summary>
        /// <value>A person who collected a particular piece of evidence. NIEM reference is j:EvidenceCollector</value>

        [DataMember(Name="collector")]
        public List<NcPersonType> Collector { get; set; }

        /// <summary>
        /// A transfer of custody of evidence from one agency to another. NIEM reference is j:EvidenceCustodyTransfer
        /// </summary>
        /// <value>A transfer of custody of evidence from one agency to another. NIEM reference is j:EvidenceCustodyTransfer</value>

        [DataMember(Name="custodyTransfer")]
        public List<JCustodyTransferType> CustodyTransfer { get; set; }

        /// <summary>
        /// A kit used to collect evidence. NIEM reference is j:EvidenceKit
        /// </summary>
        /// <value>A kit used to collect evidence. NIEM reference is j:EvidenceKit</value>

        [DataMember(Name="kit")]
        public List<NcItemType> Kit { get; set; }

        /// <summary>
        /// An identification number that identifies a piece of evidence. NIEM reference is j:EvidenceNumberIdentification
        /// </summary>
        /// <value>An identification number that identifies a piece of evidence. NIEM reference is j:EvidenceNumberIdentification</value>

        [DataMember(Name="numberIdentification")]
        public List<NcIdentificationType> NumberIdentification { get; set; }

        /// <summary>
        /// An identification of an item associated with evidence not explicitly referenced. NIEM reference is j:EvidenceOtherIdentification
        /// </summary>
        /// <value>An identification of an item associated with evidence not explicitly referenced. NIEM reference is j:EvidenceOtherIdentification</value>

        [DataMember(Name="otherIdentification")]
        public List<NcIdentificationType> OtherIdentification { get; set; }

        /// <summary>
        /// A previous location of a piece of evidence. NIEM reference is j:EvidencePreviousLocation
        /// </summary>
        /// <value>A previous location of a piece of evidence. NIEM reference is j:EvidencePreviousLocation</value>

        [DataMember(Name="previousLocation")]
        public List<NcLocationType> PreviousLocation { get; set; }

        /// <summary>
        /// A number of individual items that represent a piece of evidence. NIEM reference is j:EvidenceQuantityText
        /// </summary>
        /// <value>A number of individual items that represent a piece of evidence. NIEM reference is j:EvidenceQuantityText</value>

        [DataMember(Name="quantity")]
        public List<NcTextType> Quantity { get; set; }

        /// <summary>
        /// An identification for a receipt issued for collection, analysis, and movement of Evidence. NIEM reference is j:EvidenceReceiptIdentification
        /// </summary>
        /// <value>An identification for a receipt issued for collection, analysis, and movement of Evidence. NIEM reference is j:EvidenceReceiptIdentification</value>

        [DataMember(Name="receiptIdentification")]
        public List<NcIdentificationType> ReceiptIdentification { get; set; }

        /// <summary>
        /// True if a piece of evidence was returned to its owner; false otherwise. NIEM reference is j:EvidenceReturnedIndicator
        /// </summary>
        /// <value>True if a piece of evidence was returned to its owner; false otherwise. NIEM reference is j:EvidenceReturnedIndicator</value>

        [DataMember(Name="isReturned")]
        public List<NiemXsboolean> IsReturned { get; set; }

        /// <summary>
        /// A location where a particular piece of evidence was taken, collected, or removed. NIEM reference is j:EvidenceTakenLocation
        /// </summary>
        /// <value>A location where a particular piece of evidence was taken, collected, or removed. NIEM reference is j:EvidenceTakenLocation</value>

        [DataMember(Name="takenLocation")]
        public List<NcLocationType> TakenLocation { get; set; }

        /// <summary>
        /// An entity to which a particular piece of property was returned NIEM reference is j:EvidenceReturnRecipientEntity
        /// </summary>
        /// <value>An entity to which a particular piece of property was returned NIEM reference is j:EvidenceReturnRecipientEntity</value>

        [DataMember(Name="returnRecipientEntity")]
        public List<NcEntityType> ReturnRecipientEntity { get; set; }

        /// <summary>
        /// An entity from which a particular piece of evidence was taken or seized from. NIEM reference is j:EvidenceTakenFromEntity
        /// </summary>
        /// <value>An entity from which a particular piece of evidence was taken or seized from. NIEM reference is j:EvidenceTakenFromEntity</value>

        [DataMember(Name="takenFromEntity")]
        public List<NcEntityType> TakenFromEntity { get; set; }

        /// <summary>
        /// jEvidenceType JSON-LD context
        /// </summary>
        /// <value>jEvidenceType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjEvidenceTypeContextJsonldEnum for ../JSON-LD_Contexts/jEvidenceTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jEvidenceTypeContext.jsonld")]
            JSONLDContextsjEvidenceTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jEvidenceType JSON-LD context
        /// </summary>
        /// <value>jEvidenceType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JEvidenceType {\n");
            sb.Append("  RoleOfBiometric: ").Append(RoleOfBiometric).Append("\n");
            sb.Append("  RoleOfItem: ").Append(RoleOfItem).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ItemContactInformation: ").Append(ItemContactInformation).Append("\n");
            sb.Append("  DocumentationBinary: ").Append(DocumentationBinary).Append("\n");
            sb.Append("  IbisNumber: ").Append(IbisNumber).Append("\n");
            sb.Append("  RoleOfBinary: ").Append(RoleOfBinary).Append("\n");
            sb.Append("  Collector: ").Append(Collector).Append("\n");
            sb.Append("  CustodyTransfer: ").Append(CustodyTransfer).Append("\n");
            sb.Append("  Kit: ").Append(Kit).Append("\n");
            sb.Append("  NumberIdentification: ").Append(NumberIdentification).Append("\n");
            sb.Append("  OtherIdentification: ").Append(OtherIdentification).Append("\n");
            sb.Append("  PreviousLocation: ").Append(PreviousLocation).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReceiptIdentification: ").Append(ReceiptIdentification).Append("\n");
            sb.Append("  IsReturned: ").Append(IsReturned).Append("\n");
            sb.Append("  TakenLocation: ").Append(TakenLocation).Append("\n");
            sb.Append("  ReturnRecipientEntity: ").Append(ReturnRecipientEntity).Append("\n");
            sb.Append("  TakenFromEntity: ").Append(TakenFromEntity).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JEvidenceType)obj);
        }

        /// <summary>
        /// Returns true if JEvidenceType instances are equal
        /// </summary>
        /// <param name="other">Instance of JEvidenceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JEvidenceType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RoleOfBiometric == other.RoleOfBiometric ||
                    RoleOfBiometric != null &&
                    RoleOfBiometric.SequenceEqual(other.RoleOfBiometric)
                ) && 
                (
                    RoleOfItem == other.RoleOfItem ||
                    RoleOfItem != null &&
                    RoleOfItem.SequenceEqual(other.RoleOfItem)
                ) && 
                (
                    Item == other.Item ||
                    Item != null &&
                    Item.SequenceEqual(other.Item)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.SequenceEqual(other.Amount)
                ) && 
                (
                    ItemContactInformation == other.ItemContactInformation ||
                    ItemContactInformation != null &&
                    ItemContactInformation.SequenceEqual(other.ItemContactInformation)
                ) && 
                (
                    DocumentationBinary == other.DocumentationBinary ||
                    DocumentationBinary != null &&
                    DocumentationBinary.SequenceEqual(other.DocumentationBinary)
                ) && 
                (
                    IbisNumber == other.IbisNumber ||
                    IbisNumber != null &&
                    IbisNumber.SequenceEqual(other.IbisNumber)
                ) && 
                (
                    RoleOfBinary == other.RoleOfBinary ||
                    RoleOfBinary != null &&
                    RoleOfBinary.SequenceEqual(other.RoleOfBinary)
                ) && 
                (
                    Collector == other.Collector ||
                    Collector != null &&
                    Collector.SequenceEqual(other.Collector)
                ) && 
                (
                    CustodyTransfer == other.CustodyTransfer ||
                    CustodyTransfer != null &&
                    CustodyTransfer.SequenceEqual(other.CustodyTransfer)
                ) && 
                (
                    Kit == other.Kit ||
                    Kit != null &&
                    Kit.SequenceEqual(other.Kit)
                ) && 
                (
                    NumberIdentification == other.NumberIdentification ||
                    NumberIdentification != null &&
                    NumberIdentification.SequenceEqual(other.NumberIdentification)
                ) && 
                (
                    OtherIdentification == other.OtherIdentification ||
                    OtherIdentification != null &&
                    OtherIdentification.SequenceEqual(other.OtherIdentification)
                ) && 
                (
                    PreviousLocation == other.PreviousLocation ||
                    PreviousLocation != null &&
                    PreviousLocation.SequenceEqual(other.PreviousLocation)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.SequenceEqual(other.Quantity)
                ) && 
                (
                    ReceiptIdentification == other.ReceiptIdentification ||
                    ReceiptIdentification != null &&
                    ReceiptIdentification.SequenceEqual(other.ReceiptIdentification)
                ) && 
                (
                    IsReturned == other.IsReturned ||
                    IsReturned != null &&
                    IsReturned.SequenceEqual(other.IsReturned)
                ) && 
                (
                    TakenLocation == other.TakenLocation ||
                    TakenLocation != null &&
                    TakenLocation.SequenceEqual(other.TakenLocation)
                ) && 
                (
                    ReturnRecipientEntity == other.ReturnRecipientEntity ||
                    ReturnRecipientEntity != null &&
                    ReturnRecipientEntity.SequenceEqual(other.ReturnRecipientEntity)
                ) && 
                (
                    TakenFromEntity == other.TakenFromEntity ||
                    TakenFromEntity != null &&
                    TakenFromEntity.SequenceEqual(other.TakenFromEntity)
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
                    if (RoleOfBiometric != null)
                    hashCode = hashCode * 59 + RoleOfBiometric.GetHashCode();
                    if (RoleOfItem != null)
                    hashCode = hashCode * 59 + RoleOfItem.GetHashCode();
                    if (Item != null)
                    hashCode = hashCode * 59 + Item.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (ItemContactInformation != null)
                    hashCode = hashCode * 59 + ItemContactInformation.GetHashCode();
                    if (DocumentationBinary != null)
                    hashCode = hashCode * 59 + DocumentationBinary.GetHashCode();
                    if (IbisNumber != null)
                    hashCode = hashCode * 59 + IbisNumber.GetHashCode();
                    if (RoleOfBinary != null)
                    hashCode = hashCode * 59 + RoleOfBinary.GetHashCode();
                    if (Collector != null)
                    hashCode = hashCode * 59 + Collector.GetHashCode();
                    if (CustodyTransfer != null)
                    hashCode = hashCode * 59 + CustodyTransfer.GetHashCode();
                    if (Kit != null)
                    hashCode = hashCode * 59 + Kit.GetHashCode();
                    if (NumberIdentification != null)
                    hashCode = hashCode * 59 + NumberIdentification.GetHashCode();
                    if (OtherIdentification != null)
                    hashCode = hashCode * 59 + OtherIdentification.GetHashCode();
                    if (PreviousLocation != null)
                    hashCode = hashCode * 59 + PreviousLocation.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (ReceiptIdentification != null)
                    hashCode = hashCode * 59 + ReceiptIdentification.GetHashCode();
                    if (IsReturned != null)
                    hashCode = hashCode * 59 + IsReturned.GetHashCode();
                    if (TakenLocation != null)
                    hashCode = hashCode * 59 + TakenLocation.GetHashCode();
                    if (ReturnRecipientEntity != null)
                    hashCode = hashCode * 59 + ReturnRecipientEntity.GetHashCode();
                    if (TakenFromEntity != null)
                    hashCode = hashCode * 59 + TakenFromEntity.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JEvidenceType left, JEvidenceType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JEvidenceType left, JEvidenceType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
