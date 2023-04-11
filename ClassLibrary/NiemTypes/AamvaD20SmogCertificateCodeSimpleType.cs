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
        /// A data type for whether or not a vehicle has a current smog certificate.
        /// </summary>
        /// <value>A data type for whether or not a vehicle has a current smog certificate.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AamvaD20SmogCertificateCodeSimpleType
        {
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 0,
            /// <summary>
            /// Enum EEnum for E
            /// </summary>
            [EnumMember(Value = "E")]
            EEnum = 1,
            /// <summary>
            /// Enum NEnum for N
            /// </summary>
            [EnumMember(Value = "N")]
            NEnum = 2,
            /// <summary>
            /// Enum YEnum for Y
            /// </summary>
            [EnumMember(Value = "Y")]
            YEnum = 3        }
}
