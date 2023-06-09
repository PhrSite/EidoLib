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
        /// A data type for units of time.
        /// </summary>
        /// <value>A data type for units of time.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UneceTimeCodeSimpleType
        {
            /// <summary>
            /// Enum ANNEnum for ANN
            /// </summary>
            [EnumMember(Value = "ANN")]
            ANNEnum = 0,
            /// <summary>
            /// Enum B52Enum for B52
            /// </summary>
            [EnumMember(Value = "B52")]
            B52Enum = 1,
            /// <summary>
            /// Enum B98Enum for B98
            /// </summary>
            [EnumMember(Value = "B98")]
            B98Enum = 2,
            /// <summary>
            /// Enum C26Enum for C26
            /// </summary>
            [EnumMember(Value = "C26")]
            C26Enum = 3,
            /// <summary>
            /// Enum C47Enum for C47
            /// </summary>
            [EnumMember(Value = "C47")]
            C47Enum = 4,
            /// <summary>
            /// Enum D42Enum for D42
            /// </summary>
            [EnumMember(Value = "D42")]
            D42Enum = 5,
            /// <summary>
            /// Enum DAYEnum for DAY
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAYEnum = 6,
            /// <summary>
            /// Enum HUREnum for HUR
            /// </summary>
            [EnumMember(Value = "HUR")]
            HUREnum = 7,
            /// <summary>
            /// Enum MINEnum for MIN
            /// </summary>
            [EnumMember(Value = "MIN")]
            MINEnum = 8,
            /// <summary>
            /// Enum MONEnum for MON
            /// </summary>
            [EnumMember(Value = "MON")]
            MONEnum = 9,
            /// <summary>
            /// Enum SECEnum for SEC
            /// </summary>
            [EnumMember(Value = "SEC")]
            SECEnum = 10,
            /// <summary>
            /// Enum WEEEnum for WEE
            /// </summary>
            [EnumMember(Value = "WEE")]
            WEEEnum = 11        }
}
