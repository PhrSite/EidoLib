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
    /// A data type for additional information about an item.
    /// </summary>
    [DataContract]
    public partial class JItemAugmentationType : IEquatable<JItemAugmentationType>
    { 
        /// <summary>
        /// A feature or characteristic of a property item. NIEM reference is j:ItemDetailCode
        /// </summary>
        /// <value>A feature or characteristic of a property item. NIEM reference is j:ItemDetailCode</value>

        [DataMember(Name="itemDetailCode")]
        public List<NcicTYPAECodeType> ItemDetailCode { get; set; }

        /// <summary>
        /// A feature or characteristic of a property item. NIEM reference is j:ItemDetailText
        /// </summary>
        /// <value>A feature or characteristic of a property item. NIEM reference is j:ItemDetailText</value>

        [DataMember(Name="itemDetail")]
        public List<NcTextType> ItemDetail { get; set; }

        /// <summary>
        /// A market-based estimate of the value of an item (e.g. Kelly Blue Book for automotive vehicles) NIEM reference is j:ItemBookValue
        /// </summary>
        /// <value>A market-based estimate of the value of an item (e.g. Kelly Blue Book for automotive vehicles) NIEM reference is j:ItemBookValue</value>

        [DataMember(Name="itemBookValue")]
        public List<NcItemValueType> ItemBookValue { get; set; }

        /// <summary>
        /// A monetary value or worth of damage that occurred to a property item. NIEM reference is j:ItemTotalDamageValue
        /// </summary>
        /// <value>A monetary value or worth of damage that occurred to a property item. NIEM reference is j:ItemTotalDamageValue</value>

        [DataMember(Name="itemTotalDamageValue")]
        public List<NcItemValueType> ItemTotalDamageValue { get; set; }

        /// <summary>
        /// An entity which has a contract or lease to use a vehicle. NIEM reference is j:Lessee
        /// </summary>
        /// <value>An entity which has a contract or lease to use a vehicle. NIEM reference is j:Lessee</value>

        [DataMember(Name="lessee")]
        public List<JLesseeType> Lessee { get; set; }

        /// <summary>
        /// An amount of money a previously missing item is worth after having been found. NIEM reference is nc:ItemRecoveredValue
        /// </summary>
        /// <value>An amount of money a previously missing item is worth after having been found. NIEM reference is nc:ItemRecoveredValue</value>

        [DataMember(Name="itemRecoveredValue")]
        public List<NcItemValueType> ItemRecoveredValue { get; set; }

        /// <summary>
        /// A description of a feature or characteristic of a property item. NIEM reference is j:ItemDetailDescriptionText
        /// </summary>
        /// <value>A description of a feature or characteristic of a property item. NIEM reference is j:ItemDetailDescriptionText</value>

        [DataMember(Name="itemDetailDescription")]
        public List<NcTextType> ItemDetailDescription { get; set; }

        /// <summary>
        /// A federal identification number assigned to a property item. NIEM reference is j:ItemFederalIdentification
        /// </summary>
        /// <value>A federal identification number assigned to a property item. NIEM reference is j:ItemFederalIdentification</value>

        [DataMember(Name="itemFederalIdentification")]
        public List<NcIdentificationType> ItemFederalIdentification { get; set; }

        /// <summary>
        /// An identification of an item which is self-checking  and consists of an alphabetic character followed by nine numeric characters automatically assigned by the National Crime Information Center System to each accepted record. NIEM reference is j:ItemNCICIdentification
        /// </summary>
        /// <value>An identification of an item which is self-checking  and consists of an alphabetic character followed by nine numeric characters automatically assigned by the National Crime Information Center System to each accepted record. NIEM reference is j:ItemNCICIdentification</value>

        [DataMember(Name="itemNcicIdentification")]
        public List<NcIdentificationType> ItemNcicIdentification { get; set; }

        /// <summary>
        /// An entity which conveys vehicles by way of a lease. NIEM reference is j:Lessor
        /// </summary>
        /// <value>An entity which conveys vehicles by way of a lease. NIEM reference is j:Lessor</value>

        [DataMember(Name="lessor")]
        public List<JLessorType> Lessor { get; set; }

        /// <summary>
        /// A value the asset had in the previous year. NIEM reference is j:ItemPreviousYearValue
        /// </summary>
        /// <value>A value the asset had in the previous year. NIEM reference is j:ItemPreviousYearValue</value>

        [DataMember(Name="itemPreviousYearValue")]
        public List<NcItemValueType> ItemPreviousYearValue { get; set; }

        /// <summary>
        /// A monetary value or worth of a property item that is lost, stolen, being held, or is otherwise missing. NIEM reference is j:ItemMissingValue
        /// </summary>
        /// <value>A monetary value or worth of a property item that is lost, stolen, being held, or is otherwise missing. NIEM reference is j:ItemMissingValue</value>

        [DataMember(Name="itemMissingValue")]
        public List<NcItemValueType> ItemMissingValue { get; set; }

        /// <summary>
        /// True if the animal is livestock; false otherwise. NIEM reference is j:LivestockIndicator
        /// </summary>
        /// <value>True if the animal is livestock; false otherwise. NIEM reference is j:LivestockIndicator</value>

        [DataMember(Name="isLivestock")]
        public List<NiemXsboolean> IsLivestock { get; set; }

        /// <summary>
        /// An event or activity involving the maintenance of an item. NIEM reference is j:ItemMaintenanceActivity
        /// </summary>
        /// <value>An event or activity involving the maintenance of an item. NIEM reference is j:ItemMaintenanceActivity</value>

        [DataMember(Name="itemMaintenanceActivity")]
        public List<NcActivityType> ItemMaintenanceActivity { get; set; }

        /// <summary>
        /// A number assigned to a shipment that an item is a part of. NIEM reference is j:ItemLotNumberText
        /// </summary>
        /// <value>A number assigned to a shipment that an item is a part of. NIEM reference is j:ItemLotNumberText</value>

        [DataMember(Name="itemLotNumber")]
        public List<NcTextType> ItemLotNumber { get; set; }

        /// <summary>
        /// A brand, tattoo or tag number placed on livestock and its location. NIEM reference is j:LivestockTagText
        /// </summary>
        /// <value>A brand, tattoo or tag number placed on livestock and its location. NIEM reference is j:LivestockTagText</value>

        [DataMember(Name="livestockTag")]
        public List<NcTextType> LivestockTag { get; set; }

        /// <summary>
        /// True if the item is pending inventory; false otherwise. NIEM reference is j:ItemPendingInventoryIndicator
        /// </summary>
        /// <value>True if the item is pending inventory; false otherwise. NIEM reference is j:ItemPendingInventoryIndicator</value>

        [DataMember(Name="isItemPendingInventory")]
        public List<NiemXsboolean> IsItemPendingInventory { get; set; }

        /// <summary>
        /// True if the item held for sale; false otherwise. NIEM reference is j:MerchandiseIndicator
        /// </summary>
        /// <value>True if the item held for sale; false otherwise. NIEM reference is j:MerchandiseIndicator</value>

        [DataMember(Name="isMerchandise")]
        public List<NiemXsboolean> IsMerchandise { get; set; }

        /// <summary>
        /// True if a piece of property has been sighted; false otherwise. NIEM reference is j:ItemSightedIndicator
        /// </summary>
        /// <value>True if a piece of property has been sighted; false otherwise. NIEM reference is j:ItemSightedIndicator</value>

        [DataMember(Name="isItemSighted")]
        public List<NiemXsboolean> IsItemSighted { get; set; }

        /// <summary>
        /// True if the tool is operated by a procedure in which manual effort is supplemented or replaced by hydraulic, mechanical or electrical means; false otherwise. NIEM reference is j:ToolPowerIndicator
        /// </summary>
        /// <value>True if the tool is operated by a procedure in which manual effort is supplemented or replaced by hydraulic, mechanical or electrical means; false otherwise. NIEM reference is j:ToolPowerIndicator</value>

        [DataMember(Name="isToolPower")]
        public List<NiemXsboolean> IsToolPower { get; set; }

        /// <summary>
        /// True if the property is an antique; false otherwise. NIEM reference is j:ItemAntiqueIndicator
        /// </summary>
        /// <value>True if the property is an antique; false otherwise. NIEM reference is j:ItemAntiqueIndicator</value>

        [DataMember(Name="isItemAntique")]
        public List<NiemXsboolean> IsItemAntique { get; set; }

        /// <summary>
        /// A scheduled and ad-hoc inspections of the physical condition of, and a record of the work performed on, armory items (firearms, restraints etc.) to increase their useful lifespan, ensure they are ready for use, and that they will perform a NIEM reference is j:ItemMaintenanceSchedule
        /// </summary>
        /// <value>A scheduled and ad-hoc inspections of the physical condition of, and a record of the work performed on, armory items (firearms, restraints etc.) to increase their useful lifespan, ensure they are ready for use, and that they will perform a NIEM reference is j:ItemMaintenanceSchedule</value>

        [DataMember(Name="itemMaintenanceSchedule")]
        public List<NcScheduleType> ItemMaintenanceSchedule { get; set; }

        /// <summary>
        /// An identification a Lot of Stolen Property. NIEM reference is j:ItemLotIdentification
        /// </summary>
        /// <value>An identification a Lot of Stolen Property. NIEM reference is j:ItemLotIdentification</value>

        [DataMember(Name="itemLotIdentification")]
        public List<NcIdentificationType> ItemLotIdentification { get; set; }

        /// <summary>
        /// A set of identifying numbers inscribed on or attached to a consecutive lot of parts, collection of parts, or complete units.  Assigned by the manufacturer. NIEM reference is j:ItemSerialIdentificationRange
        /// </summary>
        /// <value>A set of identifying numbers inscribed on or attached to a consecutive lot of parts, collection of parts, or complete units.  Assigned by the manufacturer. NIEM reference is j:ItemSerialIdentificationRange</value>

        [DataMember(Name="itemSerialIdentificationRange")]
        public List<JIdentificationRangeType> ItemSerialIdentificationRange { get; set; }

        /// <summary>
        /// A stolen chemical container. NIEM reference is j:ItemHazardousMaterialsContainerText
        /// </summary>
        /// <value>A stolen chemical container. NIEM reference is j:ItemHazardousMaterialsContainerText</value>

        [DataMember(Name="itemHazardousMaterialsContainer")]
        public List<NcTextType> ItemHazardousMaterialsContainer { get; set; }

        /// <summary>
        /// A fair market value in whole dollars of other property recovered in addition to the property of record NIEM reference is j:ItemRecoveredAdditionalValue
        /// </summary>
        /// <value>A fair market value in whole dollars of other property recovered in addition to the property of record NIEM reference is j:ItemRecoveredAdditionalValue</value>

        [DataMember(Name="itemRecoveredAdditionalValue")]
        public List<NcItemValueType> ItemRecoveredAdditionalValue { get; set; }

        /// <summary>
        /// A fair market value in whole dollars of any contraband recovered as a result of recovering the property of record NIEM reference is j:ItemRecoveredContrabandValue
        /// </summary>
        /// <value>A fair market value in whole dollars of any contraband recovered as a result of recovering the property of record NIEM reference is j:ItemRecoveredContrabandValue</value>

        [DataMember(Name="itemRecoveredContrabandValue")]
        public List<NcItemValueType> ItemRecoveredContrabandValue { get; set; }

        /// <summary>
        /// A gender for which the item is intended, such as a girl&#x27;s bicycle or a man&#x27;s jacket. NIEM reference is j:ItemGenderUseCode
        /// </summary>
        /// <value>A gender for which the item is intended, such as a girl&#x27;s bicycle or a man&#x27;s jacket. NIEM reference is j:ItemGenderUseCode</value>

        [DataMember(Name="itemGenderUseCode")]
        public List<NdexItemGenderUseCodeType> ItemGenderUseCode { get; set; }

        /// <summary>
        /// A removal of property from the possession of a person or organization and placed in custody of the justice system. NIEM reference is j:ItemSeizure
        /// </summary>
        /// <value>A removal of property from the possession of a person or organization and placed in custody of the justice system. NIEM reference is j:ItemSeizure</value>

        [DataMember(Name="itemSeizure")]
        public List<JItemSeizureType> ItemSeizure { get; set; }

        /// <summary>
        /// An indicates whether a stolen chemical represents a partial or complete shipment. NIEM reference is j:ItemPartialLotText
        /// </summary>
        /// <value>An indicates whether a stolen chemical represents a partial or complete shipment. NIEM reference is j:ItemPartialLotText</value>

        [DataMember(Name="itemPartialLot")]
        public List<NcTextType> ItemPartialLot { get; set; }

        /// <summary>
        /// A gender or sex of an animal. NIEM reference is j:LivestockSexCode
        /// </summary>
        /// <value>A gender or sex of an animal. NIEM reference is j:LivestockSexCode</value>

        [DataMember(Name="livestockSexCode")]
        public List<NcicSEXCodeType> LivestockSexCode { get; set; }

        /// <summary>
        /// jItemAugmentationType JSON-LD context
        /// </summary>
        /// <value>jItemAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjItemAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/jItemAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jItemAugmentationTypeContext.jsonld")]
            JSONLDContextsjItemAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jItemAugmentationType JSON-LD context
        /// </summary>
        /// <value>jItemAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JItemAugmentationType {\n");
            sb.Append("  ItemDetailCode: ").Append(ItemDetailCode).Append("\n");
            sb.Append("  ItemDetail: ").Append(ItemDetail).Append("\n");
            sb.Append("  ItemBookValue: ").Append(ItemBookValue).Append("\n");
            sb.Append("  ItemTotalDamageValue: ").Append(ItemTotalDamageValue).Append("\n");
            sb.Append("  Lessee: ").Append(Lessee).Append("\n");
            sb.Append("  ItemRecoveredValue: ").Append(ItemRecoveredValue).Append("\n");
            sb.Append("  ItemDetailDescription: ").Append(ItemDetailDescription).Append("\n");
            sb.Append("  ItemFederalIdentification: ").Append(ItemFederalIdentification).Append("\n");
            sb.Append("  ItemNcicIdentification: ").Append(ItemNcicIdentification).Append("\n");
            sb.Append("  Lessor: ").Append(Lessor).Append("\n");
            sb.Append("  ItemPreviousYearValue: ").Append(ItemPreviousYearValue).Append("\n");
            sb.Append("  ItemMissingValue: ").Append(ItemMissingValue).Append("\n");
            sb.Append("  IsLivestock: ").Append(IsLivestock).Append("\n");
            sb.Append("  ItemMaintenanceActivity: ").Append(ItemMaintenanceActivity).Append("\n");
            sb.Append("  ItemLotNumber: ").Append(ItemLotNumber).Append("\n");
            sb.Append("  LivestockTag: ").Append(LivestockTag).Append("\n");
            sb.Append("  IsItemPendingInventory: ").Append(IsItemPendingInventory).Append("\n");
            sb.Append("  IsMerchandise: ").Append(IsMerchandise).Append("\n");
            sb.Append("  IsItemSighted: ").Append(IsItemSighted).Append("\n");
            sb.Append("  IsToolPower: ").Append(IsToolPower).Append("\n");
            sb.Append("  IsItemAntique: ").Append(IsItemAntique).Append("\n");
            sb.Append("  ItemMaintenanceSchedule: ").Append(ItemMaintenanceSchedule).Append("\n");
            sb.Append("  ItemLotIdentification: ").Append(ItemLotIdentification).Append("\n");
            sb.Append("  ItemSerialIdentificationRange: ").Append(ItemSerialIdentificationRange).Append("\n");
            sb.Append("  ItemHazardousMaterialsContainer: ").Append(ItemHazardousMaterialsContainer).Append("\n");
            sb.Append("  ItemRecoveredAdditionalValue: ").Append(ItemRecoveredAdditionalValue).Append("\n");
            sb.Append("  ItemRecoveredContrabandValue: ").Append(ItemRecoveredContrabandValue).Append("\n");
            sb.Append("  ItemGenderUseCode: ").Append(ItemGenderUseCode).Append("\n");
            sb.Append("  ItemSeizure: ").Append(ItemSeizure).Append("\n");
            sb.Append("  ItemPartialLot: ").Append(ItemPartialLot).Append("\n");
            sb.Append("  LivestockSexCode: ").Append(LivestockSexCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JItemAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if JItemAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of JItemAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JItemAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ItemDetailCode == other.ItemDetailCode ||
                    ItemDetailCode != null &&
                    ItemDetailCode.SequenceEqual(other.ItemDetailCode)
                ) && 
                (
                    ItemDetail == other.ItemDetail ||
                    ItemDetail != null &&
                    ItemDetail.SequenceEqual(other.ItemDetail)
                ) && 
                (
                    ItemBookValue == other.ItemBookValue ||
                    ItemBookValue != null &&
                    ItemBookValue.SequenceEqual(other.ItemBookValue)
                ) && 
                (
                    ItemTotalDamageValue == other.ItemTotalDamageValue ||
                    ItemTotalDamageValue != null &&
                    ItemTotalDamageValue.SequenceEqual(other.ItemTotalDamageValue)
                ) && 
                (
                    Lessee == other.Lessee ||
                    Lessee != null &&
                    Lessee.SequenceEqual(other.Lessee)
                ) && 
                (
                    ItemRecoveredValue == other.ItemRecoveredValue ||
                    ItemRecoveredValue != null &&
                    ItemRecoveredValue.SequenceEqual(other.ItemRecoveredValue)
                ) && 
                (
                    ItemDetailDescription == other.ItemDetailDescription ||
                    ItemDetailDescription != null &&
                    ItemDetailDescription.SequenceEqual(other.ItemDetailDescription)
                ) && 
                (
                    ItemFederalIdentification == other.ItemFederalIdentification ||
                    ItemFederalIdentification != null &&
                    ItemFederalIdentification.SequenceEqual(other.ItemFederalIdentification)
                ) && 
                (
                    ItemNcicIdentification == other.ItemNcicIdentification ||
                    ItemNcicIdentification != null &&
                    ItemNcicIdentification.SequenceEqual(other.ItemNcicIdentification)
                ) && 
                (
                    Lessor == other.Lessor ||
                    Lessor != null &&
                    Lessor.SequenceEqual(other.Lessor)
                ) && 
                (
                    ItemPreviousYearValue == other.ItemPreviousYearValue ||
                    ItemPreviousYearValue != null &&
                    ItemPreviousYearValue.SequenceEqual(other.ItemPreviousYearValue)
                ) && 
                (
                    ItemMissingValue == other.ItemMissingValue ||
                    ItemMissingValue != null &&
                    ItemMissingValue.SequenceEqual(other.ItemMissingValue)
                ) && 
                (
                    IsLivestock == other.IsLivestock ||
                    IsLivestock != null &&
                    IsLivestock.SequenceEqual(other.IsLivestock)
                ) && 
                (
                    ItemMaintenanceActivity == other.ItemMaintenanceActivity ||
                    ItemMaintenanceActivity != null &&
                    ItemMaintenanceActivity.SequenceEqual(other.ItemMaintenanceActivity)
                ) && 
                (
                    ItemLotNumber == other.ItemLotNumber ||
                    ItemLotNumber != null &&
                    ItemLotNumber.SequenceEqual(other.ItemLotNumber)
                ) && 
                (
                    LivestockTag == other.LivestockTag ||
                    LivestockTag != null &&
                    LivestockTag.SequenceEqual(other.LivestockTag)
                ) && 
                (
                    IsItemPendingInventory == other.IsItemPendingInventory ||
                    IsItemPendingInventory != null &&
                    IsItemPendingInventory.SequenceEqual(other.IsItemPendingInventory)
                ) && 
                (
                    IsMerchandise == other.IsMerchandise ||
                    IsMerchandise != null &&
                    IsMerchandise.SequenceEqual(other.IsMerchandise)
                ) && 
                (
                    IsItemSighted == other.IsItemSighted ||
                    IsItemSighted != null &&
                    IsItemSighted.SequenceEqual(other.IsItemSighted)
                ) && 
                (
                    IsToolPower == other.IsToolPower ||
                    IsToolPower != null &&
                    IsToolPower.SequenceEqual(other.IsToolPower)
                ) && 
                (
                    IsItemAntique == other.IsItemAntique ||
                    IsItemAntique != null &&
                    IsItemAntique.SequenceEqual(other.IsItemAntique)
                ) && 
                (
                    ItemMaintenanceSchedule == other.ItemMaintenanceSchedule ||
                    ItemMaintenanceSchedule != null &&
                    ItemMaintenanceSchedule.SequenceEqual(other.ItemMaintenanceSchedule)
                ) && 
                (
                    ItemLotIdentification == other.ItemLotIdentification ||
                    ItemLotIdentification != null &&
                    ItemLotIdentification.SequenceEqual(other.ItemLotIdentification)
                ) && 
                (
                    ItemSerialIdentificationRange == other.ItemSerialIdentificationRange ||
                    ItemSerialIdentificationRange != null &&
                    ItemSerialIdentificationRange.SequenceEqual(other.ItemSerialIdentificationRange)
                ) && 
                (
                    ItemHazardousMaterialsContainer == other.ItemHazardousMaterialsContainer ||
                    ItemHazardousMaterialsContainer != null &&
                    ItemHazardousMaterialsContainer.SequenceEqual(other.ItemHazardousMaterialsContainer)
                ) && 
                (
                    ItemRecoveredAdditionalValue == other.ItemRecoveredAdditionalValue ||
                    ItemRecoveredAdditionalValue != null &&
                    ItemRecoveredAdditionalValue.SequenceEqual(other.ItemRecoveredAdditionalValue)
                ) && 
                (
                    ItemRecoveredContrabandValue == other.ItemRecoveredContrabandValue ||
                    ItemRecoveredContrabandValue != null &&
                    ItemRecoveredContrabandValue.SequenceEqual(other.ItemRecoveredContrabandValue)
                ) && 
                (
                    ItemGenderUseCode == other.ItemGenderUseCode ||
                    ItemGenderUseCode != null &&
                    ItemGenderUseCode.SequenceEqual(other.ItemGenderUseCode)
                ) && 
                (
                    ItemSeizure == other.ItemSeizure ||
                    ItemSeizure != null &&
                    ItemSeizure.SequenceEqual(other.ItemSeizure)
                ) && 
                (
                    ItemPartialLot == other.ItemPartialLot ||
                    ItemPartialLot != null &&
                    ItemPartialLot.SequenceEqual(other.ItemPartialLot)
                ) && 
                (
                    LivestockSexCode == other.LivestockSexCode ||
                    LivestockSexCode != null &&
                    LivestockSexCode.SequenceEqual(other.LivestockSexCode)
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
                    if (ItemDetailCode != null)
                    hashCode = hashCode * 59 + ItemDetailCode.GetHashCode();
                    if (ItemDetail != null)
                    hashCode = hashCode * 59 + ItemDetail.GetHashCode();
                    if (ItemBookValue != null)
                    hashCode = hashCode * 59 + ItemBookValue.GetHashCode();
                    if (ItemTotalDamageValue != null)
                    hashCode = hashCode * 59 + ItemTotalDamageValue.GetHashCode();
                    if (Lessee != null)
                    hashCode = hashCode * 59 + Lessee.GetHashCode();
                    if (ItemRecoveredValue != null)
                    hashCode = hashCode * 59 + ItemRecoveredValue.GetHashCode();
                    if (ItemDetailDescription != null)
                    hashCode = hashCode * 59 + ItemDetailDescription.GetHashCode();
                    if (ItemFederalIdentification != null)
                    hashCode = hashCode * 59 + ItemFederalIdentification.GetHashCode();
                    if (ItemNcicIdentification != null)
                    hashCode = hashCode * 59 + ItemNcicIdentification.GetHashCode();
                    if (Lessor != null)
                    hashCode = hashCode * 59 + Lessor.GetHashCode();
                    if (ItemPreviousYearValue != null)
                    hashCode = hashCode * 59 + ItemPreviousYearValue.GetHashCode();
                    if (ItemMissingValue != null)
                    hashCode = hashCode * 59 + ItemMissingValue.GetHashCode();
                    if (IsLivestock != null)
                    hashCode = hashCode * 59 + IsLivestock.GetHashCode();
                    if (ItemMaintenanceActivity != null)
                    hashCode = hashCode * 59 + ItemMaintenanceActivity.GetHashCode();
                    if (ItemLotNumber != null)
                    hashCode = hashCode * 59 + ItemLotNumber.GetHashCode();
                    if (LivestockTag != null)
                    hashCode = hashCode * 59 + LivestockTag.GetHashCode();
                    if (IsItemPendingInventory != null)
                    hashCode = hashCode * 59 + IsItemPendingInventory.GetHashCode();
                    if (IsMerchandise != null)
                    hashCode = hashCode * 59 + IsMerchandise.GetHashCode();
                    if (IsItemSighted != null)
                    hashCode = hashCode * 59 + IsItemSighted.GetHashCode();
                    if (IsToolPower != null)
                    hashCode = hashCode * 59 + IsToolPower.GetHashCode();
                    if (IsItemAntique != null)
                    hashCode = hashCode * 59 + IsItemAntique.GetHashCode();
                    if (ItemMaintenanceSchedule != null)
                    hashCode = hashCode * 59 + ItemMaintenanceSchedule.GetHashCode();
                    if (ItemLotIdentification != null)
                    hashCode = hashCode * 59 + ItemLotIdentification.GetHashCode();
                    if (ItemSerialIdentificationRange != null)
                    hashCode = hashCode * 59 + ItemSerialIdentificationRange.GetHashCode();
                    if (ItemHazardousMaterialsContainer != null)
                    hashCode = hashCode * 59 + ItemHazardousMaterialsContainer.GetHashCode();
                    if (ItemRecoveredAdditionalValue != null)
                    hashCode = hashCode * 59 + ItemRecoveredAdditionalValue.GetHashCode();
                    if (ItemRecoveredContrabandValue != null)
                    hashCode = hashCode * 59 + ItemRecoveredContrabandValue.GetHashCode();
                    if (ItemGenderUseCode != null)
                    hashCode = hashCode * 59 + ItemGenderUseCode.GetHashCode();
                    if (ItemSeizure != null)
                    hashCode = hashCode * 59 + ItemSeizure.GetHashCode();
                    if (ItemPartialLot != null)
                    hashCode = hashCode * 59 + ItemPartialLot.GetHashCode();
                    if (LivestockSexCode != null)
                    hashCode = hashCode * 59 + LivestockSexCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JItemAugmentationType left, JItemAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JItemAugmentationType left, JItemAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
