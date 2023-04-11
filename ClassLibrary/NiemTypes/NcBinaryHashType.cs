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
    /// A data type for a hash value representing an object encoded in a binary format.
    /// </summary>
    [DataContract]
    public partial class NcBinaryHashType : IEquatable<NcBinaryHashType>
    { 
        /// <summary>
        /// A binary hash value. NIEM reference is nc:BinaryHashCode
        /// </summary>
        /// <value>A binary hash value. NIEM reference is nc:BinaryHashCode</value>

        [DataMember(Name="code")]
        public List<NiemXsstring> Code { get; set; }

        /// <summary>
        /// A hash function used to generate a hash value representing an object encoded in a binary format. NIEM reference is nc:BinaryHashFunctionCode
        /// </summary>
        /// <value>A hash function used to generate a hash value representing an object encoded in a binary format. NIEM reference is nc:BinaryHashFunctionCode</value>

        [DataMember(Name="functionCode")]
        public List<NcBinaryHashFunctionCodeType> FunctionCode { get; set; }

        /// <summary>
        /// A hash function used to generate a hash value representing an object encoded in a binary format. NIEM reference is nc:BinaryHashFunctionText
        /// </summary>
        /// <value>A hash function used to generate a hash value representing an object encoded in a binary format. NIEM reference is nc:BinaryHashFunctionText</value>

        [DataMember(Name="function")]
        public List<NcTextType> Function { get; set; }

        /// <summary>
        /// ncBinaryHashType JSON-LD context
        /// </summary>
        /// <value>ncBinaryHashType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncBinaryHashTypeContextJsonldEnum for ../JSON-LD_Contexts/ncBinaryHashTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncBinaryHashTypeContext.jsonld")]
            JSONLDContextsncBinaryHashTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncBinaryHashType JSON-LD context
        /// </summary>
        /// <value>ncBinaryHashType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcBinaryHashType {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FunctionCode: ").Append(FunctionCode).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcBinaryHashType)obj);
        }

        /// <summary>
        /// Returns true if NcBinaryHashType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcBinaryHashType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcBinaryHashType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.SequenceEqual(other.Code)
                ) && 
                (
                    FunctionCode == other.FunctionCode ||
                    FunctionCode != null &&
                    FunctionCode.SequenceEqual(other.FunctionCode)
                ) && 
                (
                    Function == other.Function ||
                    Function != null &&
                    Function.SequenceEqual(other.Function)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (FunctionCode != null)
                    hashCode = hashCode * 59 + FunctionCode.GetHashCode();
                    if (Function != null)
                    hashCode = hashCode * 59 + Function.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcBinaryHashType left, NcBinaryHashType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcBinaryHashType left, NcBinaryHashType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
