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
        /// A data type for a hash function used to generate a hash value representing an object encoded in a binary format.
        /// </summary>
        /// <value>A data type for a hash function used to generate a hash value representing an object encoded in a binary format.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcBinaryHashFunctionCodeSimpleType
        {
            /// <summary>
            /// Enum MD2Enum for MD2
            /// </summary>
            [EnumMember(Value = "MD2")]
            MD2Enum = 0,
            /// <summary>
            /// Enum MD4Enum for MD4
            /// </summary>
            [EnumMember(Value = "MD4")]
            MD4Enum = 1,
            /// <summary>
            /// Enum MD5Enum for MD5
            /// </summary>
            [EnumMember(Value = "MD5")]
            MD5Enum = 2,
            /// <summary>
            /// Enum SHA1Enum for SHA-1
            /// </summary>
            [EnumMember(Value = "SHA-1")]
            SHA1Enum = 3,
            /// <summary>
            /// Enum SHA224Enum for SHA-224
            /// </summary>
            [EnumMember(Value = "SHA-224")]
            SHA224Enum = 4,
            /// <summary>
            /// Enum SHA256Enum for SHA-256
            /// </summary>
            [EnumMember(Value = "SHA-256")]
            SHA256Enum = 5,
            /// <summary>
            /// Enum SHA384Enum for SHA-384
            /// </summary>
            [EnumMember(Value = "SHA-384")]
            SHA384Enum = 6,
            /// <summary>
            /// Enum SHA512Enum for SHA-512
            /// </summary>
            [EnumMember(Value = "SHA-512")]
            SHA512Enum = 7        }
}
