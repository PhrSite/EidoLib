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
    /// A data type for additional information about a vehicle.
    /// </summary>
    [DataContract]
    public partial class JVehicleAugmentationType : IEquatable<JVehicleAugmentationType>
    { 
        /// <summary>
        /// A structure that a vehicle is currently or routinely garaged within. NIEM reference is j:VehicleGarage
        /// </summary>
        /// <value>A structure that a vehicle is currently or routinely garaged within. NIEM reference is j:VehicleGarage</value>

        [DataMember(Name="vehicleGarage")]
        public List<NcFacilityType> VehicleGarage { get; set; }

        /// <summary>
        /// A manufacturer-assigned identification affixed to the paperwork when the manufacturer ships the vehicle. NIEM reference is j:VehicleInvoiceIdentification
        /// </summary>
        /// <value>A manufacturer-assigned identification affixed to the paperwork when the manufacturer ships the vehicle. NIEM reference is j:VehicleInvoiceIdentification</value>

        [DataMember(Name="vehicleInvoiceIdentification")]
        public List<NcIdentificationType> VehicleInvoiceIdentification { get; set; }

        /// <summary>
        /// A Vehicle Identification Number Analysis; a combination of a vehicle make and model information. NIEM reference is j:VehicleVINAText
        /// </summary>
        /// <value>A Vehicle Identification Number Analysis; a combination of a vehicle make and model information. NIEM reference is j:VehicleVINAText</value>

        [DataMember(Name="vehicleVina")]
        public List<NcTextType> VehicleVina { get; set; }

        /// <summary>
        /// A monetary amount used as the tax basis for a vehicle. NIEM reference is j:VehicleTaxableAmount
        /// </summary>
        /// <value>A monetary amount used as the tax basis for a vehicle. NIEM reference is j:VehicleTaxableAmount</value>

        [DataMember(Name="vehicleTaxableAmount")]
        public List<NcAmountType> VehicleTaxableAmount { get; set; }

        /// <summary>
        /// An entity which conveys vehicles by way of a lease. NIEM reference is j:Lessor
        /// </summary>
        /// <value>An entity which conveys vehicles by way of a lease. NIEM reference is j:Lessor</value>

        [DataMember(Name="lessor")]
        public List<JLessorType> Lessor { get; set; }

        /// <summary>
        /// An entity which has a contract or lease to use a vehicle. NIEM reference is j:Lessee
        /// </summary>
        /// <value>An entity which has a contract or lease to use a vehicle. NIEM reference is j:Lessee</value>

        [DataMember(Name="lessee")]
        public List<JLesseeType> Lessee { get; set; }

        /// <summary>
        /// A date on which the vehicle was shipped by the manufacturer to the purchaser. NIEM reference is j:VehicleShipDate
        /// </summary>
        /// <value>A date on which the vehicle was shipped by the manufacturer to the purchaser. NIEM reference is j:VehicleShipDate</value>

        [DataMember(Name="vehicleShipDate")]
        public List<NcDateType> VehicleShipDate { get; set; }

        /// <summary>
        /// True if a vehicle is being searched for by law enforcement; false otherwise. NIEM reference is j:VehicleWantedIndicator
        /// </summary>
        /// <value>True if a vehicle is being searched for by law enforcement; false otherwise. NIEM reference is j:VehicleWantedIndicator</value>

        [DataMember(Name="isVehicleWanted")]
        public List<NiemXsboolean> IsVehicleWanted { get; set; }

        /// <summary>
        /// True if a vehicle is normally stored in a garage; false otherwise. NIEM reference is j:VehicleGarageIndicator
        /// </summary>
        /// <value>True if a vehicle is normally stored in a garage; false otherwise. NIEM reference is j:VehicleGarageIndicator</value>

        [DataMember(Name="isVehicleGarage")]
        public List<NiemXsboolean> IsVehicleGarage { get; set; }

        /// <summary>
        /// A value specified by the vehicle manufacturer as the load-carrying capacity of a single axle system, as measured at the tire-ground interfaces NIEM reference is j:VehicleGrossAxleWeightRatingMeasure
        /// </summary>
        /// <value>A value specified by the vehicle manufacturer as the load-carrying capacity of a single axle system, as measured at the tire-ground interfaces NIEM reference is j:VehicleGrossAxleWeightRatingMeasure</value>

        [DataMember(Name="vehicleGrossAxleWeightRatingMeasure")]
        public List<NcWeightMeasureType> VehicleGrossAxleWeightRatingMeasure { get; set; }

        /// <summary>
        /// A date on which the vehicle was invoiced by the manufacturer to the purchaser. NIEM reference is j:VehicleInvoiceDate
        /// </summary>
        /// <value>A date on which the vehicle was invoiced by the manufacturer to the purchaser. NIEM reference is j:VehicleInvoiceDate</value>

        [DataMember(Name="vehicleInvoiceDate")]
        public List<NcDateType> VehicleInvoiceDate { get; set; }

        /// <summary>
        /// An approximate maximum load weight intended for the vehicle to transport, commonly applied to vans, pickups and single-unit trucks NIEM reference is j:VehicleNominalTonRateMeasure
        /// </summary>
        /// <value>An approximate maximum load weight intended for the vehicle to transport, commonly applied to vans, pickups and single-unit trucks NIEM reference is j:VehicleNominalTonRateMeasure</value>

        [DataMember(Name="vehicleNominalTonRateMeasure")]
        public List<NcWeightMeasureType> VehicleNominalTonRateMeasure { get; set; }

        /// <summary>
        /// True if a paper copy of the manufacturer&#x27;s certificate of origin (MCO) was sent from the manufacturer to the purchaser of the vehicle; false otherwise. NIEM reference is j:VehiclePaperMCOIssuedIndicator
        /// </summary>
        /// <value>True if a paper copy of the manufacturer&#x27;s certificate of origin (MCO) was sent from the manufacturer to the purchaser of the vehicle; false otherwise. NIEM reference is j:VehiclePaperMCOIssuedIndicator</value>

        [DataMember(Name="isVehiclePaperMcoIssued")]
        public List<NiemXsboolean> IsVehiclePaperMcoIssued { get; set; }

        /// <summary>
        /// A number of times a vehicle goes through an emissions inspection. NIEM reference is j:VehicleEmissionInspectionQuantity
        /// </summary>
        /// <value>A number of times a vehicle goes through an emissions inspection. NIEM reference is j:VehicleEmissionInspectionQuantity</value>

        [DataMember(Name="vehicleEmissionInspectionQuantity")]
        public List<NiemXsnonNegativeInteger> VehicleEmissionInspectionQuantity { get; set; }

        /// <summary>
        /// An official examination to test the emissions level of a vehicle. NIEM reference is j:VehicleEmissionInspection
        /// </summary>
        /// <value>An official examination to test the emissions level of a vehicle. NIEM reference is j:VehicleEmissionInspection</value>

        [DataMember(Name="vehicleEmissionInspection")]
        public List<JVehicleEmissionInspectionType> VehicleEmissionInspection { get; set; }

        /// <summary>
        /// A NICB Division location in the United States, showing interest in a stolen vehicle entry. NIEM reference is j:VehicleOwnershipNICBText
        /// </summary>
        /// <value>A NICB Division location in the United States, showing interest in a stolen vehicle entry. NIEM reference is j:VehicleOwnershipNICBText</value>

        [DataMember(Name="vehicleOwnershipNicb")]
        public List<NcTextType> VehicleOwnershipNicb { get; set; }

        /// <summary>
        /// True if the part is a potential component or accessory for a motor-driven conveyance designed to carry its operator, and optionally passengers and cargo, over land; false otherwise. NIEM reference is j:VehiclePartOrAccessoryIndicator
        /// </summary>
        /// <value>True if the part is a potential component or accessory for a motor-driven conveyance designed to carry its operator, and optionally passengers and cargo, over land; false otherwise. NIEM reference is j:VehiclePartOrAccessoryIndicator</value>

        [DataMember(Name="isVehiclePartOrAccessory")]
        public List<NiemXsboolean> IsVehiclePartOrAccessory { get; set; }

        /// <summary>
        /// An official examination of the safety of a vehicle. NIEM reference is j:VehicleSafetyInspection
        /// </summary>
        /// <value>An official examination of the safety of a vehicle. NIEM reference is j:VehicleSafetyInspection</value>

        [DataMember(Name="vehicleSafetyInspection")]
        public List<JVehicleSafetyInspectionType> VehicleSafetyInspection { get; set; }

        /// <summary>
        /// A brand issued to a vehicle. NIEM reference is j:VehicleBrand
        /// </summary>
        /// <value>A brand issued to a vehicle. NIEM reference is j:VehicleBrand</value>

        [DataMember(Name="vehicleBrand")]
        public List<JVehicleBrandType> VehicleBrand { get; set; }

        /// <summary>
        /// An organization that brands a vehicle. NIEM reference is j:VehicleBrander
        /// </summary>
        /// <value>An organization that brands a vehicle. NIEM reference is j:VehicleBrander</value>

        [DataMember(Name="vehicleBrander")]
        public List<JVehicleBranderType> VehicleBrander { get; set; }

        /// <summary>
        /// A kind of special function being served by this vehicle regardless of whether the function is marked on the vehicle. NIEM reference is j:VehicleUseCode
        /// </summary>
        /// <value>A kind of special function being served by this vehicle regardless of whether the function is marked on the vehicle. NIEM reference is j:VehicleUseCode</value>

        [DataMember(Name="vehicleUseCode")]
        public List<MmuccVehicleUseCodeType> VehicleUseCode { get; set; }

        /// <summary>
        /// A deed or other official document showing the legal ownership of a vehicle. NIEM reference is j:VehicleTitle
        /// </summary>
        /// <value>A deed or other official document showing the legal ownership of a vehicle. NIEM reference is j:VehicleTitle</value>

        [DataMember(Name="vehicleTitle")]
        public List<JItemTitleType> VehicleTitle { get; set; }

        /// <summary>
        /// jVehicleAugmentationType JSON-LD context
        /// </summary>
        /// <value>jVehicleAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjVehicleAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/jVehicleAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jVehicleAugmentationTypeContext.jsonld")]
            JSONLDContextsjVehicleAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jVehicleAugmentationType JSON-LD context
        /// </summary>
        /// <value>jVehicleAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JVehicleAugmentationType {\n");
            sb.Append("  VehicleGarage: ").Append(VehicleGarage).Append("\n");
            sb.Append("  VehicleInvoiceIdentification: ").Append(VehicleInvoiceIdentification).Append("\n");
            sb.Append("  VehicleVina: ").Append(VehicleVina).Append("\n");
            sb.Append("  VehicleTaxableAmount: ").Append(VehicleTaxableAmount).Append("\n");
            sb.Append("  Lessor: ").Append(Lessor).Append("\n");
            sb.Append("  Lessee: ").Append(Lessee).Append("\n");
            sb.Append("  VehicleShipDate: ").Append(VehicleShipDate).Append("\n");
            sb.Append("  IsVehicleWanted: ").Append(IsVehicleWanted).Append("\n");
            sb.Append("  IsVehicleGarage: ").Append(IsVehicleGarage).Append("\n");
            sb.Append("  VehicleGrossAxleWeightRatingMeasure: ").Append(VehicleGrossAxleWeightRatingMeasure).Append("\n");
            sb.Append("  VehicleInvoiceDate: ").Append(VehicleInvoiceDate).Append("\n");
            sb.Append("  VehicleNominalTonRateMeasure: ").Append(VehicleNominalTonRateMeasure).Append("\n");
            sb.Append("  IsVehiclePaperMcoIssued: ").Append(IsVehiclePaperMcoIssued).Append("\n");
            sb.Append("  VehicleEmissionInspectionQuantity: ").Append(VehicleEmissionInspectionQuantity).Append("\n");
            sb.Append("  VehicleEmissionInspection: ").Append(VehicleEmissionInspection).Append("\n");
            sb.Append("  VehicleOwnershipNicb: ").Append(VehicleOwnershipNicb).Append("\n");
            sb.Append("  IsVehiclePartOrAccessory: ").Append(IsVehiclePartOrAccessory).Append("\n");
            sb.Append("  VehicleSafetyInspection: ").Append(VehicleSafetyInspection).Append("\n");
            sb.Append("  VehicleBrand: ").Append(VehicleBrand).Append("\n");
            sb.Append("  VehicleBrander: ").Append(VehicleBrander).Append("\n");
            sb.Append("  VehicleUseCode: ").Append(VehicleUseCode).Append("\n");
            sb.Append("  VehicleTitle: ").Append(VehicleTitle).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JVehicleAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if JVehicleAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of JVehicleAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JVehicleAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VehicleGarage == other.VehicleGarage ||
                    VehicleGarage != null &&
                    VehicleGarage.SequenceEqual(other.VehicleGarage)
                ) && 
                (
                    VehicleInvoiceIdentification == other.VehicleInvoiceIdentification ||
                    VehicleInvoiceIdentification != null &&
                    VehicleInvoiceIdentification.SequenceEqual(other.VehicleInvoiceIdentification)
                ) && 
                (
                    VehicleVina == other.VehicleVina ||
                    VehicleVina != null &&
                    VehicleVina.SequenceEqual(other.VehicleVina)
                ) && 
                (
                    VehicleTaxableAmount == other.VehicleTaxableAmount ||
                    VehicleTaxableAmount != null &&
                    VehicleTaxableAmount.SequenceEqual(other.VehicleTaxableAmount)
                ) && 
                (
                    Lessor == other.Lessor ||
                    Lessor != null &&
                    Lessor.SequenceEqual(other.Lessor)
                ) && 
                (
                    Lessee == other.Lessee ||
                    Lessee != null &&
                    Lessee.SequenceEqual(other.Lessee)
                ) && 
                (
                    VehicleShipDate == other.VehicleShipDate ||
                    VehicleShipDate != null &&
                    VehicleShipDate.SequenceEqual(other.VehicleShipDate)
                ) && 
                (
                    IsVehicleWanted == other.IsVehicleWanted ||
                    IsVehicleWanted != null &&
                    IsVehicleWanted.SequenceEqual(other.IsVehicleWanted)
                ) && 
                (
                    IsVehicleGarage == other.IsVehicleGarage ||
                    IsVehicleGarage != null &&
                    IsVehicleGarage.SequenceEqual(other.IsVehicleGarage)
                ) && 
                (
                    VehicleGrossAxleWeightRatingMeasure == other.VehicleGrossAxleWeightRatingMeasure ||
                    VehicleGrossAxleWeightRatingMeasure != null &&
                    VehicleGrossAxleWeightRatingMeasure.SequenceEqual(other.VehicleGrossAxleWeightRatingMeasure)
                ) && 
                (
                    VehicleInvoiceDate == other.VehicleInvoiceDate ||
                    VehicleInvoiceDate != null &&
                    VehicleInvoiceDate.SequenceEqual(other.VehicleInvoiceDate)
                ) && 
                (
                    VehicleNominalTonRateMeasure == other.VehicleNominalTonRateMeasure ||
                    VehicleNominalTonRateMeasure != null &&
                    VehicleNominalTonRateMeasure.SequenceEqual(other.VehicleNominalTonRateMeasure)
                ) && 
                (
                    IsVehiclePaperMcoIssued == other.IsVehiclePaperMcoIssued ||
                    IsVehiclePaperMcoIssued != null &&
                    IsVehiclePaperMcoIssued.SequenceEqual(other.IsVehiclePaperMcoIssued)
                ) && 
                (
                    VehicleEmissionInspectionQuantity == other.VehicleEmissionInspectionQuantity ||
                    VehicleEmissionInspectionQuantity != null &&
                    VehicleEmissionInspectionQuantity.SequenceEqual(other.VehicleEmissionInspectionQuantity)
                ) && 
                (
                    VehicleEmissionInspection == other.VehicleEmissionInspection ||
                    VehicleEmissionInspection != null &&
                    VehicleEmissionInspection.SequenceEqual(other.VehicleEmissionInspection)
                ) && 
                (
                    VehicleOwnershipNicb == other.VehicleOwnershipNicb ||
                    VehicleOwnershipNicb != null &&
                    VehicleOwnershipNicb.SequenceEqual(other.VehicleOwnershipNicb)
                ) && 
                (
                    IsVehiclePartOrAccessory == other.IsVehiclePartOrAccessory ||
                    IsVehiclePartOrAccessory != null &&
                    IsVehiclePartOrAccessory.SequenceEqual(other.IsVehiclePartOrAccessory)
                ) && 
                (
                    VehicleSafetyInspection == other.VehicleSafetyInspection ||
                    VehicleSafetyInspection != null &&
                    VehicleSafetyInspection.SequenceEqual(other.VehicleSafetyInspection)
                ) && 
                (
                    VehicleBrand == other.VehicleBrand ||
                    VehicleBrand != null &&
                    VehicleBrand.SequenceEqual(other.VehicleBrand)
                ) && 
                (
                    VehicleBrander == other.VehicleBrander ||
                    VehicleBrander != null &&
                    VehicleBrander.SequenceEqual(other.VehicleBrander)
                ) && 
                (
                    VehicleUseCode == other.VehicleUseCode ||
                    VehicleUseCode != null &&
                    VehicleUseCode.SequenceEqual(other.VehicleUseCode)
                ) && 
                (
                    VehicleTitle == other.VehicleTitle ||
                    VehicleTitle != null &&
                    VehicleTitle.SequenceEqual(other.VehicleTitle)
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
                    if (VehicleGarage != null)
                    hashCode = hashCode * 59 + VehicleGarage.GetHashCode();
                    if (VehicleInvoiceIdentification != null)
                    hashCode = hashCode * 59 + VehicleInvoiceIdentification.GetHashCode();
                    if (VehicleVina != null)
                    hashCode = hashCode * 59 + VehicleVina.GetHashCode();
                    if (VehicleTaxableAmount != null)
                    hashCode = hashCode * 59 + VehicleTaxableAmount.GetHashCode();
                    if (Lessor != null)
                    hashCode = hashCode * 59 + Lessor.GetHashCode();
                    if (Lessee != null)
                    hashCode = hashCode * 59 + Lessee.GetHashCode();
                    if (VehicleShipDate != null)
                    hashCode = hashCode * 59 + VehicleShipDate.GetHashCode();
                    if (IsVehicleWanted != null)
                    hashCode = hashCode * 59 + IsVehicleWanted.GetHashCode();
                    if (IsVehicleGarage != null)
                    hashCode = hashCode * 59 + IsVehicleGarage.GetHashCode();
                    if (VehicleGrossAxleWeightRatingMeasure != null)
                    hashCode = hashCode * 59 + VehicleGrossAxleWeightRatingMeasure.GetHashCode();
                    if (VehicleInvoiceDate != null)
                    hashCode = hashCode * 59 + VehicleInvoiceDate.GetHashCode();
                    if (VehicleNominalTonRateMeasure != null)
                    hashCode = hashCode * 59 + VehicleNominalTonRateMeasure.GetHashCode();
                    if (IsVehiclePaperMcoIssued != null)
                    hashCode = hashCode * 59 + IsVehiclePaperMcoIssued.GetHashCode();
                    if (VehicleEmissionInspectionQuantity != null)
                    hashCode = hashCode * 59 + VehicleEmissionInspectionQuantity.GetHashCode();
                    if (VehicleEmissionInspection != null)
                    hashCode = hashCode * 59 + VehicleEmissionInspection.GetHashCode();
                    if (VehicleOwnershipNicb != null)
                    hashCode = hashCode * 59 + VehicleOwnershipNicb.GetHashCode();
                    if (IsVehiclePartOrAccessory != null)
                    hashCode = hashCode * 59 + IsVehiclePartOrAccessory.GetHashCode();
                    if (VehicleSafetyInspection != null)
                    hashCode = hashCode * 59 + VehicleSafetyInspection.GetHashCode();
                    if (VehicleBrand != null)
                    hashCode = hashCode * 59 + VehicleBrand.GetHashCode();
                    if (VehicleBrander != null)
                    hashCode = hashCode * 59 + VehicleBrander.GetHashCode();
                    if (VehicleUseCode != null)
                    hashCode = hashCode * 59 + VehicleUseCode.GetHashCode();
                    if (VehicleTitle != null)
                    hashCode = hashCode * 59 + VehicleTitle.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JVehicleAugmentationType left, JVehicleAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JVehicleAugmentationType left, JVehicleAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
