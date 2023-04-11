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
    /// A data type for a deed or other official document showing the legal ownership of a property item.
    /// </summary>
    [DataContract]
    public partial class JItemTitleType : IEquatable<JItemTitleType>
    { 
        /// <summary>
        /// An identification of a certificate of title to a property item. NIEM reference is j:TitleIdentification
        /// </summary>
        /// <value>An identification of a certificate of title to a property item. NIEM reference is j:TitleIdentification</value>

        [DataMember(Name="titleIdentification")]
        public List<NcIdentificationType> TitleIdentification { get; set; }

        /// <summary>
        /// A total number of title documents issued where the titling information is unchanged by the current titling jurisdiction. NIEM reference is j:TitleDuplicateQuantity
        /// </summary>
        /// <value>A total number of title documents issued where the titling information is unchanged by the current titling jurisdiction. NIEM reference is j:TitleDuplicateQuantity</value>

        [DataMember(Name="titleDuplicateQuantity")]
        public List<NiemXsnonNegativeInteger> TitleDuplicateQuantity { get; set; }

        /// <summary>
        /// A date on which a jurisdictional titling authority issued a title to the owner of a property item. NIEM reference is j:TitleIssueDate
        /// </summary>
        /// <value>A date on which a jurisdictional titling authority issued a title to the owner of a property item. NIEM reference is j:TitleIssueDate</value>

        [DataMember(Name="titleIssueDate")]
        public List<NcDateType> TitleIssueDate { get; set; }

        /// <summary>
        /// A name of an authority which issued a title. NIEM reference is j:TitleIssuingAuthorityName
        /// </summary>
        /// <value>A name of an authority which issued a title. NIEM reference is j:TitleIssuingAuthorityName</value>

        [DataMember(Name="titleIssuingAuthorityName")]
        public List<NcTextType> TitleIssuingAuthorityName { get; set; }

        /// <summary>
        /// True if a lien exists on the titled property; false otherwise. NIEM reference is j:TitleLienIndicator
        /// </summary>
        /// <value>True if a lien exists on the titled property; false otherwise. NIEM reference is j:TitleLienIndicator</value>

        [DataMember(Name="isTitleLien")]
        public List<NiemXsboolean> IsTitleLien { get; set; }

        /// <summary>
        /// A property item for which a title is issued. NIEM reference is j:TitleItem
        /// </summary>
        /// <value>A property item for which a title is issued. NIEM reference is j:TitleItem</value>

        [DataMember(Name="titleItem")]
        public List<NcItemType> TitleItem { get; set; }

        /// <summary>
        /// A status of a property title. NIEM reference is j:TitleStatus
        /// </summary>
        /// <value>A status of a property title. NIEM reference is j:TitleStatus</value>

        [DataMember(Name="titleStatus")]
        public List<JTitleStatusType> TitleStatus { get; set; }

        /// <summary>
        /// An entity to whom a title is issued. NIEM reference is j:TitleHolder
        /// </summary>
        /// <value>An entity to whom a title is issued. NIEM reference is j:TitleHolder</value>

        [DataMember(Name="titleHolder")]
        public List<NcEntityType> TitleHolder { get; set; }

        /// <summary>
        /// A kind of title issued. NIEM reference is j:TitleCategoryText
        /// </summary>
        /// <value>A kind of title issued. NIEM reference is j:TitleCategoryText</value>

        [DataMember(Name="titleCategory")]
        public List<NcTextType> TitleCategory { get; set; }

        /// <summary>
        /// A legal encumbrance placed on a property item. NIEM reference is j:Lien
        /// </summary>
        /// <value>A legal encumbrance placed on a property item. NIEM reference is j:Lien</value>

        [DataMember(Name="lien")]
        public List<JLienType> Lien { get; set; }

        /// <summary>
        /// A kind of individual title document. NIEM reference is j:ItemTitleDocumentCategoryCode
        /// </summary>
        /// <value>A kind of individual title document. NIEM reference is j:ItemTitleDocumentCategoryCode</value>

        [DataMember(Name="documentCategoryCode")]
        public List<AamvaD20VehicleTitleDocumentCategoryCodeType> DocumentCategoryCode { get; set; }

        /// <summary>
        /// A date a current owner purchased a vehicle. NIEM reference is j:ItemTitlePurchaseDate
        /// </summary>
        /// <value>A date a current owner purchased a vehicle. NIEM reference is j:ItemTitlePurchaseDate</value>

        [DataMember(Name="purchaseDate")]
        public List<NcDateType> PurchaseDate { get; set; }

        /// <summary>
        /// A price a current owner paid to purchase a vehicle. NIEM reference is j:ItemTitlePurchasePriceAmount
        /// </summary>
        /// <value>A price a current owner paid to purchase a vehicle. NIEM reference is j:ItemTitlePurchasePriceAmount</value>

        [DataMember(Name="purchasePriceAmount")]
        public List<NcAmountType> PurchasePriceAmount { get; set; }

        /// <summary>
        /// A sales tax charged on a purchase of a vehicle. NIEM reference is j:ItemTitleSalesTaxAmount
        /// </summary>
        /// <value>A sales tax charged on a purchase of a vehicle. NIEM reference is j:ItemTitleSalesTaxAmount</value>

        [DataMember(Name="salesTaxAmount")]
        public List<NcAmountType> SalesTaxAmount { get; set; }

        /// <summary>
        /// A tax rate used for computing sales tax on a vehicle. NIEM reference is j:ItemTitleSalesTaxPercent
        /// </summary>
        /// <value>A tax rate used for computing sales tax on a vehicle. NIEM reference is j:ItemTitleSalesTaxPercent</value>

        [DataMember(Name="salesTaxPercent")]
        public List<NiemXsdecimal> SalesTaxPercent { get; set; }

        /// <summary>
        /// A dollar value used to compute the taxes on a vehicle. NIEM reference is j:ItemTitleTaxableValue
        /// </summary>
        /// <value>A dollar value used to compute the taxes on a vehicle. NIEM reference is j:ItemTitleTaxableValue</value>

        [DataMember(Name="taxableValue")]
        public List<NcItemValueType> TaxableValue { get; set; }

        /// <summary>
        /// A jurisdiction which issued a title. NIEM reference is j:TitleIssuingJurisdiction
        /// </summary>
        /// <value>A jurisdiction which issued a title. NIEM reference is j:TitleIssuingJurisdiction</value>

        [DataMember(Name="titleIssuingJurisdiction")]
        public List<NcJurisdictionType> TitleIssuingJurisdiction { get; set; }

        /// <summary>
        /// jItemTitleType JSON-LD context
        /// </summary>
        /// <value>jItemTitleType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjItemTitleTypeContextJsonldEnum for ../JSON-LD_Contexts/jItemTitleTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jItemTitleTypeContext.jsonld")]
            JSONLDContextsjItemTitleTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jItemTitleType JSON-LD context
        /// </summary>
        /// <value>jItemTitleType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JItemTitleType {\n");
            sb.Append("  TitleIdentification: ").Append(TitleIdentification).Append("\n");
            sb.Append("  TitleDuplicateQuantity: ").Append(TitleDuplicateQuantity).Append("\n");
            sb.Append("  TitleIssueDate: ").Append(TitleIssueDate).Append("\n");
            sb.Append("  TitleIssuingAuthorityName: ").Append(TitleIssuingAuthorityName).Append("\n");
            sb.Append("  IsTitleLien: ").Append(IsTitleLien).Append("\n");
            sb.Append("  TitleItem: ").Append(TitleItem).Append("\n");
            sb.Append("  TitleStatus: ").Append(TitleStatus).Append("\n");
            sb.Append("  TitleHolder: ").Append(TitleHolder).Append("\n");
            sb.Append("  TitleCategory: ").Append(TitleCategory).Append("\n");
            sb.Append("  Lien: ").Append(Lien).Append("\n");
            sb.Append("  DocumentCategoryCode: ").Append(DocumentCategoryCode).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  PurchasePriceAmount: ").Append(PurchasePriceAmount).Append("\n");
            sb.Append("  SalesTaxAmount: ").Append(SalesTaxAmount).Append("\n");
            sb.Append("  SalesTaxPercent: ").Append(SalesTaxPercent).Append("\n");
            sb.Append("  TaxableValue: ").Append(TaxableValue).Append("\n");
            sb.Append("  TitleIssuingJurisdiction: ").Append(TitleIssuingJurisdiction).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JItemTitleType)obj);
        }

        /// <summary>
        /// Returns true if JItemTitleType instances are equal
        /// </summary>
        /// <param name="other">Instance of JItemTitleType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JItemTitleType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TitleIdentification == other.TitleIdentification ||
                    TitleIdentification != null &&
                    TitleIdentification.SequenceEqual(other.TitleIdentification)
                ) && 
                (
                    TitleDuplicateQuantity == other.TitleDuplicateQuantity ||
                    TitleDuplicateQuantity != null &&
                    TitleDuplicateQuantity.SequenceEqual(other.TitleDuplicateQuantity)
                ) && 
                (
                    TitleIssueDate == other.TitleIssueDate ||
                    TitleIssueDate != null &&
                    TitleIssueDate.SequenceEqual(other.TitleIssueDate)
                ) && 
                (
                    TitleIssuingAuthorityName == other.TitleIssuingAuthorityName ||
                    TitleIssuingAuthorityName != null &&
                    TitleIssuingAuthorityName.SequenceEqual(other.TitleIssuingAuthorityName)
                ) && 
                (
                    IsTitleLien == other.IsTitleLien ||
                    IsTitleLien != null &&
                    IsTitleLien.SequenceEqual(other.IsTitleLien)
                ) && 
                (
                    TitleItem == other.TitleItem ||
                    TitleItem != null &&
                    TitleItem.SequenceEqual(other.TitleItem)
                ) && 
                (
                    TitleStatus == other.TitleStatus ||
                    TitleStatus != null &&
                    TitleStatus.SequenceEqual(other.TitleStatus)
                ) && 
                (
                    TitleHolder == other.TitleHolder ||
                    TitleHolder != null &&
                    TitleHolder.SequenceEqual(other.TitleHolder)
                ) && 
                (
                    TitleCategory == other.TitleCategory ||
                    TitleCategory != null &&
                    TitleCategory.SequenceEqual(other.TitleCategory)
                ) && 
                (
                    Lien == other.Lien ||
                    Lien != null &&
                    Lien.SequenceEqual(other.Lien)
                ) && 
                (
                    DocumentCategoryCode == other.DocumentCategoryCode ||
                    DocumentCategoryCode != null &&
                    DocumentCategoryCode.SequenceEqual(other.DocumentCategoryCode)
                ) && 
                (
                    PurchaseDate == other.PurchaseDate ||
                    PurchaseDate != null &&
                    PurchaseDate.SequenceEqual(other.PurchaseDate)
                ) && 
                (
                    PurchasePriceAmount == other.PurchasePriceAmount ||
                    PurchasePriceAmount != null &&
                    PurchasePriceAmount.SequenceEqual(other.PurchasePriceAmount)
                ) && 
                (
                    SalesTaxAmount == other.SalesTaxAmount ||
                    SalesTaxAmount != null &&
                    SalesTaxAmount.SequenceEqual(other.SalesTaxAmount)
                ) && 
                (
                    SalesTaxPercent == other.SalesTaxPercent ||
                    SalesTaxPercent != null &&
                    SalesTaxPercent.SequenceEqual(other.SalesTaxPercent)
                ) && 
                (
                    TaxableValue == other.TaxableValue ||
                    TaxableValue != null &&
                    TaxableValue.SequenceEqual(other.TaxableValue)
                ) && 
                (
                    TitleIssuingJurisdiction == other.TitleIssuingJurisdiction ||
                    TitleIssuingJurisdiction != null &&
                    TitleIssuingJurisdiction.SequenceEqual(other.TitleIssuingJurisdiction)
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
                    if (TitleIdentification != null)
                    hashCode = hashCode * 59 + TitleIdentification.GetHashCode();
                    if (TitleDuplicateQuantity != null)
                    hashCode = hashCode * 59 + TitleDuplicateQuantity.GetHashCode();
                    if (TitleIssueDate != null)
                    hashCode = hashCode * 59 + TitleIssueDate.GetHashCode();
                    if (TitleIssuingAuthorityName != null)
                    hashCode = hashCode * 59 + TitleIssuingAuthorityName.GetHashCode();
                    if (IsTitleLien != null)
                    hashCode = hashCode * 59 + IsTitleLien.GetHashCode();
                    if (TitleItem != null)
                    hashCode = hashCode * 59 + TitleItem.GetHashCode();
                    if (TitleStatus != null)
                    hashCode = hashCode * 59 + TitleStatus.GetHashCode();
                    if (TitleHolder != null)
                    hashCode = hashCode * 59 + TitleHolder.GetHashCode();
                    if (TitleCategory != null)
                    hashCode = hashCode * 59 + TitleCategory.GetHashCode();
                    if (Lien != null)
                    hashCode = hashCode * 59 + Lien.GetHashCode();
                    if (DocumentCategoryCode != null)
                    hashCode = hashCode * 59 + DocumentCategoryCode.GetHashCode();
                    if (PurchaseDate != null)
                    hashCode = hashCode * 59 + PurchaseDate.GetHashCode();
                    if (PurchasePriceAmount != null)
                    hashCode = hashCode * 59 + PurchasePriceAmount.GetHashCode();
                    if (SalesTaxAmount != null)
                    hashCode = hashCode * 59 + SalesTaxAmount.GetHashCode();
                    if (SalesTaxPercent != null)
                    hashCode = hashCode * 59 + SalesTaxPercent.GetHashCode();
                    if (TaxableValue != null)
                    hashCode = hashCode * 59 + TaxableValue.GetHashCode();
                    if (TitleIssuingJurisdiction != null)
                    hashCode = hashCode * 59 + TitleIssuingJurisdiction.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JItemTitleType left, JItemTitleType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JItemTitleType left, JItemTitleType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
