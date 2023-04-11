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
    /// A data type for a set of details of how the obligation will be fulfilled
    /// </summary>
    [DataContract]
    public partial class ItObligationGuaranteeType : IEquatable<ItObligationGuaranteeType>
    { 
        /// <summary>
        /// A unique identifier for the obligation guarantee NIEM reference is it:GuaranteeReferenceID
        /// </summary>
        /// <value>A unique identifier for the obligation guarantee NIEM reference is it:GuaranteeReferenceID</value>

        [DataMember(Name="guaranteeReferenceId")]
        public List<NiemXsstring> GuaranteeReferenceId { get; set; }

        /// <summary>
        /// A code specifying details regarding undertaking given in cash, bond or as a written guarantee to ensure an obligation will be fulfilled NIEM reference is it:SecurityDetailsCodeText
        /// </summary>
        /// <value>A code specifying details regarding undertaking given in cash, bond or as a written guarantee to ensure an obligation will be fulfilled NIEM reference is it:SecurityDetailsCodeText</value>

        [DataMember(Name="securityDetailsCode")]
        public List<NcTextType> SecurityDetailsCode { get; set; }

        /// <summary>
        /// itObligationGuaranteeType JSON-LD context
        /// </summary>
        /// <value>itObligationGuaranteeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsitObligationGuaranteeTypeContextJsonldEnum for ../JSON-LD_Contexts/itObligationGuaranteeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/itObligationGuaranteeTypeContext.jsonld")]
            JSONLDContextsitObligationGuaranteeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// itObligationGuaranteeType JSON-LD context
        /// </summary>
        /// <value>itObligationGuaranteeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItObligationGuaranteeType {\n");
            sb.Append("  GuaranteeReferenceId: ").Append(GuaranteeReferenceId).Append("\n");
            sb.Append("  SecurityDetailsCode: ").Append(SecurityDetailsCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ItObligationGuaranteeType)obj);
        }

        /// <summary>
        /// Returns true if ItObligationGuaranteeType instances are equal
        /// </summary>
        /// <param name="other">Instance of ItObligationGuaranteeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItObligationGuaranteeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    GuaranteeReferenceId == other.GuaranteeReferenceId ||
                    GuaranteeReferenceId != null &&
                    GuaranteeReferenceId.SequenceEqual(other.GuaranteeReferenceId)
                ) && 
                (
                    SecurityDetailsCode == other.SecurityDetailsCode ||
                    SecurityDetailsCode != null &&
                    SecurityDetailsCode.SequenceEqual(other.SecurityDetailsCode)
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
                    if (GuaranteeReferenceId != null)
                    hashCode = hashCode * 59 + GuaranteeReferenceId.GetHashCode();
                    if (SecurityDetailsCode != null)
                    hashCode = hashCode * 59 + SecurityDetailsCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ItObligationGuaranteeType left, ItObligationGuaranteeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ItObligationGuaranteeType left, ItObligationGuaranteeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
