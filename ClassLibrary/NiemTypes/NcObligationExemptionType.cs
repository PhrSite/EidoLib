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
    /// A data type for a waival or dismissal of an obligation.
    /// </summary>
    [DataContract]
    public partial class NcObligationExemptionType : IEquatable<NcObligationExemptionType>
    { 
        /// <summary>
        /// An amount of an exemption from a payment obligation. NIEM reference is nc:FinancialObligationExemptionAmount
        /// </summary>
        /// <value>An amount of an exemption from a payment obligation. NIEM reference is nc:FinancialObligationExemptionAmount</value>

        [DataMember(Name="financialAmount")]
        public List<NcAmountType> FinancialAmount { get; set; }

        /// <summary>
        /// A description of an exemption from an obligation. NIEM reference is nc:ObligationExemptionDescriptionText
        /// </summary>
        /// <value>A description of an exemption from an obligation. NIEM reference is nc:ObligationExemptionDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// ncObligationExemptionType JSON-LD context
        /// </summary>
        /// <value>ncObligationExemptionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncObligationExemptionTypeContextJsonldEnum for ../JSON-LD_Contexts/ncObligationExemptionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncObligationExemptionTypeContext.jsonld")]
            JSONLDContextsncObligationExemptionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncObligationExemptionType JSON-LD context
        /// </summary>
        /// <value>ncObligationExemptionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcObligationExemptionType {\n");
            sb.Append("  FinancialAmount: ").Append(FinancialAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcObligationExemptionType)obj);
        }

        /// <summary>
        /// Returns true if NcObligationExemptionType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcObligationExemptionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcObligationExemptionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FinancialAmount == other.FinancialAmount ||
                    FinancialAmount != null &&
                    FinancialAmount.SequenceEqual(other.FinancialAmount)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
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
                    if (FinancialAmount != null)
                    hashCode = hashCode * 59 + FinancialAmount.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcObligationExemptionType left, NcObligationExemptionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcObligationExemptionType left, NcObligationExemptionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
