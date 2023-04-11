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
        /// A data type for a code for describing a biometric modality defined by CBEFF
        /// </summary>
        /// <value>A data type for a code for describing a biometric modality defined by CBEFF</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomCBEFFCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_00000000 for 00000000
            /// </summary>
            [EnumMember(Value = "00000000")]
            NUMBER_00000000 = 0,
            /// <summary>
            /// Enum NUMBER_00000001 for 00000001
            /// </summary>
            [EnumMember(Value = "00000001")]
            NUMBER_00000001 = 1,
            /// <summary>
            /// Enum NUMBER_00000004 for 00000004
            /// </summary>
            [EnumMember(Value = "00000004")]
            NUMBER_00000004 = 2,
            /// <summary>
            /// Enum NUMBER_00000020 for 00000020
            /// </summary>
            [EnumMember(Value = "00000020")]
            NUMBER_00000020 = 3,
            /// <summary>
            /// Enum NUMBER_00000040 for 00000040
            /// </summary>
            [EnumMember(Value = "00000040")]
            NUMBER_00000040 = 4,
            /// <summary>
            /// Enum NUMBER_80 for 80
            /// </summary>
            [EnumMember(Value = "80")]
            NUMBER_80 = 5,
            /// <summary>
            /// Enum NUMBER_00000100 for 00000100
            /// </summary>
            [EnumMember(Value = "00000100")]
            NUMBER_00000100 = 6,
            /// <summary>
            /// Enum NUMBER_00000200 for 00000200
            /// </summary>
            [EnumMember(Value = "00000200")]
            NUMBER_00000200 = 7,
            /// <summary>
            /// Enum NUMBER_00000400 for 00000400
            /// </summary>
            [EnumMember(Value = "00000400")]
            NUMBER_00000400 = 8,
            /// <summary>
            /// Enum NUMBER_800 for 800
            /// </summary>
            [EnumMember(Value = "800")]
            NUMBER_800 = 9,
            /// <summary>
            /// Enum NUMBER_00001000 for 00001000
            /// </summary>
            [EnumMember(Value = "00001000")]
            NUMBER_00001000 = 10,
            /// <summary>
            /// Enum NUMBER_00002000 for 00002000
            /// </summary>
            [EnumMember(Value = "00002000")]
            NUMBER_00002000 = 11,
            /// <summary>
            /// Enum NUMBER_8000 for 8000
            /// </summary>
            [EnumMember(Value = "8000")]
            NUMBER_8000 = 12,
            /// <summary>
            /// Enum NUMBER_00010000 for 00010000
            /// </summary>
            [EnumMember(Value = "00010000")]
            NUMBER_00010000 = 13,
            /// <summary>
            /// Enum NUMBER_00040000 for 00040000
            /// </summary>
            [EnumMember(Value = "00040000")]
            NUMBER_00040000 = 14        }
}
