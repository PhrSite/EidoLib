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
    /// A data type for a full telephone number.
    /// </summary>
    [DataContract]
    public partial class NcFullTelephoneNumberType : IEquatable<NcFullTelephoneNumberType>
    { 
        /// <summary>
        /// A complete telephone number. NIEM reference is nc:TelephoneNumberFullID
        /// </summary>
        /// <value>A complete telephone number. NIEM reference is nc:TelephoneNumberFullID</value>

        [DataMember(Name="telephoneNumberFullId")]
        public List<NiemXsstring> TelephoneNumberFullId { get; set; }

        /// <summary>
        /// An additional sequence of numbers to be entered after a call connects to be directed to the appropriate place. NIEM reference is nc:TelephoneSuffixID
        /// </summary>
        /// <value>An additional sequence of numbers to be entered after a call connects to be directed to the appropriate place. NIEM reference is nc:TelephoneSuffixID</value>

        [DataMember(Name="telephoneSuffixId")]
        public List<NiemXsstring> TelephoneSuffixId { get; set; }

        /// <summary>
        /// ncFullTelephoneNumberType JSON-LD context
        /// </summary>
        /// <value>ncFullTelephoneNumberType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncFullTelephoneNumberTypeContextJsonldEnum for ../JSON-LD_Contexts/ncFullTelephoneNumberTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncFullTelephoneNumberTypeContext.jsonld")]
            JSONLDContextsncFullTelephoneNumberTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncFullTelephoneNumberType JSON-LD context
        /// </summary>
        /// <value>ncFullTelephoneNumberType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcFullTelephoneNumberType {\n");
            sb.Append("  TelephoneNumberFullId: ").Append(TelephoneNumberFullId).Append("\n");
            sb.Append("  TelephoneSuffixId: ").Append(TelephoneSuffixId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcFullTelephoneNumberType)obj);
        }

        /// <summary>
        /// Returns true if NcFullTelephoneNumberType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcFullTelephoneNumberType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcFullTelephoneNumberType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TelephoneNumberFullId == other.TelephoneNumberFullId ||
                    TelephoneNumberFullId != null &&
                    TelephoneNumberFullId.SequenceEqual(other.TelephoneNumberFullId)
                ) && 
                (
                    TelephoneSuffixId == other.TelephoneSuffixId ||
                    TelephoneSuffixId != null &&
                    TelephoneSuffixId.SequenceEqual(other.TelephoneSuffixId)
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
                    if (TelephoneNumberFullId != null)
                    hashCode = hashCode * 59 + TelephoneNumberFullId.GetHashCode();
                    if (TelephoneSuffixId != null)
                    hashCode = hashCode * 59 + TelephoneSuffixId.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcFullTelephoneNumberType left, NcFullTelephoneNumberType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcFullTelephoneNumberType left, NcFullTelephoneNumberType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
