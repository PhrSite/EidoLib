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
        /// A data type for kinds of vehicles that a licensed driver may be approved to operate.
        /// </summary>
        /// <value>A data type for kinds of vehicles that a licensed driver may be approved to operate.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AamvaD20DriverLicenseClassCodeSimpleType
        {
            /// <summary>
            /// Enum AEnum for A
            /// </summary>
            [EnumMember(Value = "A")]
            AEnum = 0,
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 1,
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 2,
            /// <summary>
            /// Enum MEnum for M
            /// </summary>
            [EnumMember(Value = "M")]
            MEnum = 3        }
}
