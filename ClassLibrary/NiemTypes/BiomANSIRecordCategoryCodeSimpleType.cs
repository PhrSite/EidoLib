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
        /// A data type for a kind of record based on ANSI/NIST-ITL 1-2013 (Obsolete)
        /// </summary>
        /// <value>A data type for a kind of record based on ANSI/NIST-ITL 1-2013 (Obsolete)</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomANSIRecordCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_01 for 01
            /// </summary>
            [EnumMember(Value = "01")]
            NUMBER_01 = 0,
            /// <summary>
            /// Enum NUMBER_02 for 02
            /// </summary>
            [EnumMember(Value = "02")]
            NUMBER_02 = 1,
            /// <summary>
            /// Enum NUMBER_04 for 04
            /// </summary>
            [EnumMember(Value = "04")]
            NUMBER_04 = 2,
            /// <summary>
            /// Enum NUMBER_07 for 07
            /// </summary>
            [EnumMember(Value = "07")]
            NUMBER_07 = 3,
            /// <summary>
            /// Enum NUMBER_8 for 8
            /// </summary>
            [EnumMember(Value = "8")]
            NUMBER_8 = 4,
            /// <summary>
            /// Enum NUMBER_9 for 9
            /// </summary>
            [EnumMember(Value = "9")]
            NUMBER_9 = 5,
            /// <summary>
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 6,
            /// <summary>
            /// Enum NUMBER_100 for 100
            /// </summary>
            [EnumMember(Value = "100")]
            NUMBER_100 = 7,
            /// <summary>
            /// Enum NUMBER_1000 for 1000
            /// </summary>
            [EnumMember(Value = "1000")]
            NUMBER_1000 = 8,
            /// <summary>
            /// Enum NUMBER_10000 for 10000
            /// </summary>
            [EnumMember(Value = "10000")]
            NUMBER_10000 = 9,
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 10,
            /// <summary>
            /// Enum NUMBER_12 for 12
            /// </summary>
            [EnumMember(Value = "12")]
            NUMBER_12 = 11,
            /// <summary>
            /// Enum NUMBER_13 for 13
            /// </summary>
            [EnumMember(Value = "13")]
            NUMBER_13 = 12,
            /// <summary>
            /// Enum NUMBER_14 for 14
            /// </summary>
            [EnumMember(Value = "14")]
            NUMBER_14 = 13,
            /// <summary>
            /// Enum NUMBER_15 for 15
            /// </summary>
            [EnumMember(Value = "15")]
            NUMBER_15 = 14,
            /// <summary>
            /// Enum NUMBER_16 for 16
            /// </summary>
            [EnumMember(Value = "16")]
            NUMBER_16 = 15,
            /// <summary>
            /// Enum NUMBER_17 for 17
            /// </summary>
            [EnumMember(Value = "17")]
            NUMBER_17 = 16,
            /// <summary>
            /// Enum NUMBER_18 for 18
            /// </summary>
            [EnumMember(Value = "18")]
            NUMBER_18 = 17,
            /// <summary>
            /// Enum NUMBER_19 for 19
            /// </summary>
            [EnumMember(Value = "19")]
            NUMBER_19 = 18,
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 19,
            /// <summary>
            /// Enum NUMBER_200 for 200
            /// </summary>
            [EnumMember(Value = "200")]
            NUMBER_200 = 20,
            /// <summary>
            /// Enum NUMBER_2000 for 2000
            /// </summary>
            [EnumMember(Value = "2000")]
            NUMBER_2000 = 21,
            /// <summary>
            /// Enum NUMBER_21 for 21
            /// </summary>
            [EnumMember(Value = "21")]
            NUMBER_21 = 22,
            /// <summary>
            /// Enum NUMBER_22 for 22
            /// </summary>
            [EnumMember(Value = "22")]
            NUMBER_22 = 23,
            /// <summary>
            /// Enum NUMBER_400 for 400
            /// </summary>
            [EnumMember(Value = "400")]
            NUMBER_400 = 24,
            /// <summary>
            /// Enum NUMBER_40000 for 40000
            /// </summary>
            [EnumMember(Value = "40000")]
            NUMBER_40000 = 25,
            /// <summary>
            /// Enum NUMBER_80 for 80
            /// </summary>
            [EnumMember(Value = "80")]
            NUMBER_80 = 26,
            /// <summary>
            /// Enum NUMBER_800 for 800
            /// </summary>
            [EnumMember(Value = "800")]
            NUMBER_800 = 27,
            /// <summary>
            /// Enum NUMBER_8000 for 8000
            /// </summary>
            [EnumMember(Value = "8000")]
            NUMBER_8000 = 28,
            /// <summary>
            /// Enum NUMBER_98 for 98
            /// </summary>
            [EnumMember(Value = "98")]
            NUMBER_98 = 29,
            /// <summary>
            /// Enum NUMBER_99 for 99
            /// </summary>
            [EnumMember(Value = "99")]
            NUMBER_99 = 30        }
}
