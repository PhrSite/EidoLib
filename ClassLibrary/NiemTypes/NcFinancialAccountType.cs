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
    /// A data type for a financial account maintained by a financial institution.
    /// </summary>
    [DataContract]
    public partial class NcFinancialAccountType : IEquatable<NcFinancialAccountType>
    { 
        /// <summary>
        /// A name of a person or organization appearing on a financial account. NIEM reference is nc:FinancialAccountListedName
        /// </summary>
        /// <value>A name of a person or organization appearing on a financial account. NIEM reference is nc:FinancialAccountListedName</value>

        [DataMember(Name="listedName")]
        public List<NcTextType> ListedName { get; set; }

        /// <summary>
        /// An account balance at the time of financial compilation. NIEM reference is nc:FinancialAccountPresentBalanceAmount
        /// </summary>
        /// <value>An account balance at the time of financial compilation. NIEM reference is nc:FinancialAccountPresentBalanceAmount</value>

        [DataMember(Name="presentBalanceAmount")]
        public List<NcAmountType> PresentBalanceAmount { get; set; }

        /// <summary>
        /// A kind of account or financial service maintained by a financial institution. NIEM reference is nc:FinancialAccountCategoryText
        /// </summary>
        /// <value>A kind of account or financial service maintained by a financial institution. NIEM reference is nc:FinancialAccountCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// An identifier assigned to a type of financial account. NIEM reference is nc:FinancialAccountNumberID
        /// </summary>
        /// <value>An identifier assigned to a type of financial account. NIEM reference is nc:FinancialAccountNumberID</value>

        [DataMember(Name="numberId")]
        public List<NiemXsstring> NumberId { get; set; }

        /// <summary>
        /// True if the account was closed or transferred in its entirety during the calendar year; false otherwise. NIEM reference is nc:FinancialAccountClosedIndicator
        /// </summary>
        /// <value>True if the account was closed or transferred in its entirety during the calendar year; false otherwise. NIEM reference is nc:FinancialAccountClosedIndicator</value>

        [DataMember(Name="isClosed")]
        public List<NiemXsboolean> IsClosed { get; set; }

        /// <summary>
        /// An entity that holds a financial account. NIEM reference is nc:FinancialAccountHolder
        /// </summary>
        /// <value>An entity that holds a financial account. NIEM reference is nc:FinancialAccountHolder</value>

        [DataMember(Name="holder")]
        public List<NcFinancialAccountHolderType> Holder { get; set; }

        /// <summary>
        /// ncFinancialAccountType JSON-LD context
        /// </summary>
        /// <value>ncFinancialAccountType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncFinancialAccountTypeContextJsonldEnum for ../JSON-LD_Contexts/ncFinancialAccountTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncFinancialAccountTypeContext.jsonld")]
            JSONLDContextsncFinancialAccountTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncFinancialAccountType JSON-LD context
        /// </summary>
        /// <value>ncFinancialAccountType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcFinancialAccountType {\n");
            sb.Append("  ListedName: ").Append(ListedName).Append("\n");
            sb.Append("  PresentBalanceAmount: ").Append(PresentBalanceAmount).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  NumberId: ").Append(NumberId).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  Holder: ").Append(Holder).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcFinancialAccountType)obj);
        }

        /// <summary>
        /// Returns true if NcFinancialAccountType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcFinancialAccountType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcFinancialAccountType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ListedName == other.ListedName ||
                    ListedName != null &&
                    ListedName.SequenceEqual(other.ListedName)
                ) && 
                (
                    PresentBalanceAmount == other.PresentBalanceAmount ||
                    PresentBalanceAmount != null &&
                    PresentBalanceAmount.SequenceEqual(other.PresentBalanceAmount)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    NumberId == other.NumberId ||
                    NumberId != null &&
                    NumberId.SequenceEqual(other.NumberId)
                ) && 
                (
                    IsClosed == other.IsClosed ||
                    IsClosed != null &&
                    IsClosed.SequenceEqual(other.IsClosed)
                ) && 
                (
                    Holder == other.Holder ||
                    Holder != null &&
                    Holder.SequenceEqual(other.Holder)
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
                    if (ListedName != null)
                    hashCode = hashCode * 59 + ListedName.GetHashCode();
                    if (PresentBalanceAmount != null)
                    hashCode = hashCode * 59 + PresentBalanceAmount.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (NumberId != null)
                    hashCode = hashCode * 59 + NumberId.GetHashCode();
                    if (IsClosed != null)
                    hashCode = hashCode * 59 + IsClosed.GetHashCode();
                    if (Holder != null)
                    hashCode = hashCode * 59 + Holder.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcFinancialAccountType left, NcFinancialAccountType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcFinancialAccountType left, NcFinancialAccountType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}