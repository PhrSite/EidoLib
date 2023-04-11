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
    /// A data type for additional information about a conveyance.
    /// </summary>
    [DataContract]
    public partial class ScrVehicleAugmentationType : IEquatable<ScrVehicleAugmentationType>
    { 
        /// <summary>
        /// A kind of conveyance identification. NIEM reference is scr:ConveyanceIdentificationCategoryCode
        /// </summary>
        /// <value>A kind of conveyance identification. NIEM reference is scr:ConveyanceIdentificationCategoryCode</value>

        [DataMember(Name="conveyanceIdentificationCategoryCode")]
        public List<ScrConveyanceIdentificationCategoryCodeType> ConveyanceIdentificationCategoryCode { get; set; }

        /// <summary>
        /// A class of conveyance being used. NIEM reference is scr:VehicleCategoryCodeText
        /// </summary>
        /// <value>A class of conveyance being used. NIEM reference is scr:VehicleCategoryCodeText</value>

        [DataMember(Name="vehicleCategoryCode")]
        public List<NiemXstoken> VehicleCategoryCode { get; set; }

        /// <summary>
        /// A kind of conveyance. NIEM reference is scr:ConveyanceCategoryCode
        /// </summary>
        /// <value>A kind of conveyance. NIEM reference is scr:ConveyanceCategoryCode</value>

        [DataMember(Name="conveyanceCategoryCode")]
        public List<ScrConveyanceCategoryCodeType> ConveyanceCategoryCode { get; set; }

        /// <summary>
        /// A reason that a vehicle subject is of interest. NIEM reference is scr:VehicleSubjectCategoryCodeText
        /// </summary>
        /// <value>A reason that a vehicle subject is of interest. NIEM reference is scr:VehicleSubjectCategoryCodeText</value>

        [DataMember(Name="vehicleSubjectCategoryCode")]
        public List<NiemXstoken> VehicleSubjectCategoryCode { get; set; }

        /// <summary>
        /// A conveyance ID issuing jurisdiction type. NIEM reference is scr:ConveyanceIDIssuingJurisdictionCode
        /// </summary>
        /// <value>A conveyance ID issuing jurisdiction type. NIEM reference is scr:ConveyanceIDIssuingJurisdictionCode</value>

        [DataMember(Name="conveyanceIdIssuingJurisdictionCode")]
        public List<ScrConveyanceIDIssuingJurisdictionCategoryCodeType> ConveyanceIdIssuingJurisdictionCode { get; set; }

        /// <summary>
        /// scrVehicleAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrVehicleAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsscrVehicleAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/scrVehicleAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/scrVehicleAugmentationTypeContext.jsonld")]
            JSONLDContextsscrVehicleAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// scrVehicleAugmentationType JSON-LD context
        /// </summary>
        /// <value>scrVehicleAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScrVehicleAugmentationType {\n");
            sb.Append("  ConveyanceIdentificationCategoryCode: ").Append(ConveyanceIdentificationCategoryCode).Append("\n");
            sb.Append("  VehicleCategoryCode: ").Append(VehicleCategoryCode).Append("\n");
            sb.Append("  ConveyanceCategoryCode: ").Append(ConveyanceCategoryCode).Append("\n");
            sb.Append("  VehicleSubjectCategoryCode: ").Append(VehicleSubjectCategoryCode).Append("\n");
            sb.Append("  ConveyanceIdIssuingJurisdictionCode: ").Append(ConveyanceIdIssuingJurisdictionCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ScrVehicleAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if ScrVehicleAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScrVehicleAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScrVehicleAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ConveyanceIdentificationCategoryCode == other.ConveyanceIdentificationCategoryCode ||
                    ConveyanceIdentificationCategoryCode != null &&
                    ConveyanceIdentificationCategoryCode.SequenceEqual(other.ConveyanceIdentificationCategoryCode)
                ) && 
                (
                    VehicleCategoryCode == other.VehicleCategoryCode ||
                    VehicleCategoryCode != null &&
                    VehicleCategoryCode.SequenceEqual(other.VehicleCategoryCode)
                ) && 
                (
                    ConveyanceCategoryCode == other.ConveyanceCategoryCode ||
                    ConveyanceCategoryCode != null &&
                    ConveyanceCategoryCode.SequenceEqual(other.ConveyanceCategoryCode)
                ) && 
                (
                    VehicleSubjectCategoryCode == other.VehicleSubjectCategoryCode ||
                    VehicleSubjectCategoryCode != null &&
                    VehicleSubjectCategoryCode.SequenceEqual(other.VehicleSubjectCategoryCode)
                ) && 
                (
                    ConveyanceIdIssuingJurisdictionCode == other.ConveyanceIdIssuingJurisdictionCode ||
                    ConveyanceIdIssuingJurisdictionCode != null &&
                    ConveyanceIdIssuingJurisdictionCode.SequenceEqual(other.ConveyanceIdIssuingJurisdictionCode)
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
                    if (ConveyanceIdentificationCategoryCode != null)
                    hashCode = hashCode * 59 + ConveyanceIdentificationCategoryCode.GetHashCode();
                    if (VehicleCategoryCode != null)
                    hashCode = hashCode * 59 + VehicleCategoryCode.GetHashCode();
                    if (ConveyanceCategoryCode != null)
                    hashCode = hashCode * 59 + ConveyanceCategoryCode.GetHashCode();
                    if (VehicleSubjectCategoryCode != null)
                    hashCode = hashCode * 59 + VehicleSubjectCategoryCode.GetHashCode();
                    if (ConveyanceIdIssuingJurisdictionCode != null)
                    hashCode = hashCode * 59 + ConveyanceIdIssuingJurisdictionCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScrVehicleAugmentationType left, ScrVehicleAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScrVehicleAugmentationType left, ScrVehicleAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
