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
        /// A data type for a finger position
        /// </summary>
        /// <value>A data type for a finger position</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomFingerPositionCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_0 for 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 0,
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 2,
            /// <summary>
            /// Enum NUMBER_16 for 16
            /// </summary>
            [EnumMember(Value = "16")]
            NUMBER_16 = 3,
            /// <summary>
            /// Enum NUMBER_17 for 17
            /// </summary>
            [EnumMember(Value = "17")]
            NUMBER_17 = 4,
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 5,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 6,
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 7,
            /// <summary>
            /// Enum NUMBER_5 for 5
            /// </summary>
            [EnumMember(Value = "5")]
            NUMBER_5 = 8,
            /// <summary>
            /// Enum NUMBER_6 for 6
            /// </summary>
            [EnumMember(Value = "6")]
            NUMBER_6 = 9,
            /// <summary>
            /// Enum NUMBER_7 for 7
            /// </summary>
            [EnumMember(Value = "7")]
            NUMBER_7 = 10,
            /// <summary>
            /// Enum NUMBER_8 for 8
            /// </summary>
            [EnumMember(Value = "8")]
            NUMBER_8 = 11,
            /// <summary>
            /// Enum NUMBER_9 for 9
            /// </summary>
            [EnumMember(Value = "9")]
            NUMBER_9 = 12        }
}
