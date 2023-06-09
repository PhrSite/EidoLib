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
    /// A data type for an agreement between a bondsman and a subject in which a bondsman pays the subject&#x27;s bail or portion of the bail in exchange for certain conditions.
    /// </summary>
    [DataContract]
    public partial class JBailBondType : NcActivityType, IEquatable<JBailBondType>
    { 
        /// <summary>
        /// A monetary amount approved for bond. NIEM reference is j:BailBondAmount
        /// </summary>
        /// <value>A monetary amount approved for bond. NIEM reference is j:BailBondAmount</value>

        [DataMember(Name="amount")]
        public List<NcAmountType> Amount { get; set; }

        /// <summary>
        /// A description of a condition or requirement for a subject attached to a bond. NIEM reference is j:BailBondConditionDescriptionText
        /// </summary>
        /// <value>A description of a condition or requirement for a subject attached to a bond. NIEM reference is j:BailBondConditionDescriptionText</value>

        [DataMember(Name="conditionDescription")]
        public List<NcTextType> ConditionDescription { get; set; }

        /// <summary>
        /// An entity that issues a bond. NIEM reference is j:BailBondIssuerEntity
        /// </summary>
        /// <value>An entity that issues a bond. NIEM reference is j:BailBondIssuerEntity</value>

        [DataMember(Name="issuerEntity")]
        public List<NcEntityType> IssuerEntity { get; set; }

        /// <summary>
        /// A description of what a subject pays for a bond. NIEM reference is j:BailBondPaymentDescriptionText
        /// </summary>
        /// <value>A description of what a subject pays for a bond. NIEM reference is j:BailBondPaymentDescriptionText</value>

        [DataMember(Name="paymentDescription")]
        public List<NcTextType> PaymentDescription { get; set; }

        /// <summary>
        /// A date a bond is revoked. NIEM reference is j:BailBondRevokeDate
        /// </summary>
        /// <value>A date a bond is revoked. NIEM reference is j:BailBondRevokeDate</value>

        [DataMember(Name="revokeDate")]
        public List<NcDateType> RevokeDate { get; set; }

        /// <summary>
        /// An entity who has agreed to be responsible for a subject. NIEM reference is j:BailBondSuretyEntity
        /// </summary>
        /// <value>An entity who has agreed to be responsible for a subject. NIEM reference is j:BailBondSuretyEntity</value>

        [DataMember(Name="suretyEntity")]
        public List<NcEntityType> SuretyEntity { get; set; }

        /// <summary>
        /// A date a bond no longer is in effect. NIEM reference is j:BailBondTerminationDate
        /// </summary>
        /// <value>A date a bond no longer is in effect. NIEM reference is j:BailBondTerminationDate</value>

        [DataMember(Name="terminationDate")]
        public List<NcDateType> TerminationDate { get; set; }

        /// <summary>
        /// A kind of reason a bond is no longer in effect. NIEM reference is j:BailBondTerminationCategoryText
        /// </summary>
        /// <value>A kind of reason a bond is no longer in effect. NIEM reference is j:BailBondTerminationCategoryText</value>

        [DataMember(Name="terminationCategory")]
        public List<NcTextType> TerminationCategory { get; set; }

        /// <summary>
        /// jBailBondType JSON-LD context
        /// </summary>
        /// <value>jBailBondType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjBailBondTypeContextJsonldEnum for ../JSON-LD_Contexts/jBailBondTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jBailBondTypeContext.jsonld")]
            JSONLDContextsjBailBondTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jBailBondType JSON-LD context
        /// </summary>
        /// <value>jBailBondType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JBailBondType {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ConditionDescription: ").Append(ConditionDescription).Append("\n");
            sb.Append("  IssuerEntity: ").Append(IssuerEntity).Append("\n");
            sb.Append("  PaymentDescription: ").Append(PaymentDescription).Append("\n");
            sb.Append("  RevokeDate: ").Append(RevokeDate).Append("\n");
            sb.Append("  SuretyEntity: ").Append(SuretyEntity).Append("\n");
            sb.Append("  TerminationDate: ").Append(TerminationDate).Append("\n");
            sb.Append("  TerminationCategory: ").Append(TerminationCategory).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JBailBondType)obj);
        }

        /// <summary>
        /// Returns true if JBailBondType instances are equal
        /// </summary>
        /// <param name="other">Instance of JBailBondType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JBailBondType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.SequenceEqual(other.Amount)
                ) && 
                (
                    ConditionDescription == other.ConditionDescription ||
                    ConditionDescription != null &&
                    ConditionDescription.SequenceEqual(other.ConditionDescription)
                ) && 
                (
                    IssuerEntity == other.IssuerEntity ||
                    IssuerEntity != null &&
                    IssuerEntity.SequenceEqual(other.IssuerEntity)
                ) && 
                (
                    PaymentDescription == other.PaymentDescription ||
                    PaymentDescription != null &&
                    PaymentDescription.SequenceEqual(other.PaymentDescription)
                ) && 
                (
                    RevokeDate == other.RevokeDate ||
                    RevokeDate != null &&
                    RevokeDate.SequenceEqual(other.RevokeDate)
                ) && 
                (
                    SuretyEntity == other.SuretyEntity ||
                    SuretyEntity != null &&
                    SuretyEntity.SequenceEqual(other.SuretyEntity)
                ) && 
                (
                    TerminationDate == other.TerminationDate ||
                    TerminationDate != null &&
                    TerminationDate.SequenceEqual(other.TerminationDate)
                ) && 
                (
                    TerminationCategory == other.TerminationCategory ||
                    TerminationCategory != null &&
                    TerminationCategory.SequenceEqual(other.TerminationCategory)
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
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (ConditionDescription != null)
                    hashCode = hashCode * 59 + ConditionDescription.GetHashCode();
                    if (IssuerEntity != null)
                    hashCode = hashCode * 59 + IssuerEntity.GetHashCode();
                    if (PaymentDescription != null)
                    hashCode = hashCode * 59 + PaymentDescription.GetHashCode();
                    if (RevokeDate != null)
                    hashCode = hashCode * 59 + RevokeDate.GetHashCode();
                    if (SuretyEntity != null)
                    hashCode = hashCode * 59 + SuretyEntity.GetHashCode();
                    if (TerminationDate != null)
                    hashCode = hashCode * 59 + TerminationDate.GetHashCode();
                    if (TerminationCategory != null)
                    hashCode = hashCode * 59 + TerminationCategory.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JBailBondType left, JBailBondType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JBailBondType left, JBailBondType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
