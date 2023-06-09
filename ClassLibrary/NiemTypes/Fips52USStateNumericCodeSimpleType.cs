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
        /// A data type for numeric state codes.
        /// </summary>
        /// <value>A data type for numeric state codes.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum Fips52USStateNumericCodeSimpleType
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
            /// Enum NUMBER_05 for 05
            /// </summary>
            [EnumMember(Value = "05")]
            NUMBER_05 = 3,
            /// <summary>
            /// Enum NUMBER_06 for 06
            /// </summary>
            [EnumMember(Value = "06")]
            NUMBER_06 = 4,
            /// <summary>
            /// Enum NUMBER_8 for 8
            /// </summary>
            [EnumMember(Value = "8")]
            NUMBER_8 = 5,
            /// <summary>
            /// Enum NUMBER_9 for 9
            /// </summary>
            [EnumMember(Value = "9")]
            NUMBER_9 = 6,
            /// <summary>
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 7,
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 8,
            /// <summary>
            /// Enum NUMBER_12 for 12
            /// </summary>
            [EnumMember(Value = "12")]
            NUMBER_12 = 9,
            /// <summary>
            /// Enum NUMBER_13 for 13
            /// </summary>
            [EnumMember(Value = "13")]
            NUMBER_13 = 10,
            /// <summary>
            /// Enum NUMBER_15 for 15
            /// </summary>
            [EnumMember(Value = "15")]
            NUMBER_15 = 11,
            /// <summary>
            /// Enum NUMBER_16 for 16
            /// </summary>
            [EnumMember(Value = "16")]
            NUMBER_16 = 12,
            /// <summary>
            /// Enum NUMBER_17 for 17
            /// </summary>
            [EnumMember(Value = "17")]
            NUMBER_17 = 13,
            /// <summary>
            /// Enum NUMBER_18 for 18
            /// </summary>
            [EnumMember(Value = "18")]
            NUMBER_18 = 14,
            /// <summary>
            /// Enum NUMBER_19 for 19
            /// </summary>
            [EnumMember(Value = "19")]
            NUMBER_19 = 15,
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 16,
            /// <summary>
            /// Enum NUMBER_21 for 21
            /// </summary>
            [EnumMember(Value = "21")]
            NUMBER_21 = 17,
            /// <summary>
            /// Enum NUMBER_22 for 22
            /// </summary>
            [EnumMember(Value = "22")]
            NUMBER_22 = 18,
            /// <summary>
            /// Enum NUMBER_23 for 23
            /// </summary>
            [EnumMember(Value = "23")]
            NUMBER_23 = 19,
            /// <summary>
            /// Enum NUMBER_24 for 24
            /// </summary>
            [EnumMember(Value = "24")]
            NUMBER_24 = 20,
            /// <summary>
            /// Enum NUMBER_25 for 25
            /// </summary>
            [EnumMember(Value = "25")]
            NUMBER_25 = 21,
            /// <summary>
            /// Enum NUMBER_26 for 26
            /// </summary>
            [EnumMember(Value = "26")]
            NUMBER_26 = 22,
            /// <summary>
            /// Enum NUMBER_27 for 27
            /// </summary>
            [EnumMember(Value = "27")]
            NUMBER_27 = 23,
            /// <summary>
            /// Enum NUMBER_28 for 28
            /// </summary>
            [EnumMember(Value = "28")]
            NUMBER_28 = 24,
            /// <summary>
            /// Enum NUMBER_29 for 29
            /// </summary>
            [EnumMember(Value = "29")]
            NUMBER_29 = 25,
            /// <summary>
            /// Enum NUMBER_30 for 30
            /// </summary>
            [EnumMember(Value = "30")]
            NUMBER_30 = 26,
            /// <summary>
            /// Enum NUMBER_31 for 31
            /// </summary>
            [EnumMember(Value = "31")]
            NUMBER_31 = 27,
            /// <summary>
            /// Enum NUMBER_32 for 32
            /// </summary>
            [EnumMember(Value = "32")]
            NUMBER_32 = 28,
            /// <summary>
            /// Enum NUMBER_33 for 33
            /// </summary>
            [EnumMember(Value = "33")]
            NUMBER_33 = 29,
            /// <summary>
            /// Enum NUMBER_34 for 34
            /// </summary>
            [EnumMember(Value = "34")]
            NUMBER_34 = 30,
            /// <summary>
            /// Enum NUMBER_35 for 35
            /// </summary>
            [EnumMember(Value = "35")]
            NUMBER_35 = 31,
            /// <summary>
            /// Enum NUMBER_36 for 36
            /// </summary>
            [EnumMember(Value = "36")]
            NUMBER_36 = 32,
            /// <summary>
            /// Enum NUMBER_37 for 37
            /// </summary>
            [EnumMember(Value = "37")]
            NUMBER_37 = 33,
            /// <summary>
            /// Enum NUMBER_38 for 38
            /// </summary>
            [EnumMember(Value = "38")]
            NUMBER_38 = 34,
            /// <summary>
            /// Enum NUMBER_39 for 39
            /// </summary>
            [EnumMember(Value = "39")]
            NUMBER_39 = 35,
            /// <summary>
            /// Enum NUMBER_40 for 40
            /// </summary>
            [EnumMember(Value = "40")]
            NUMBER_40 = 36,
            /// <summary>
            /// Enum NUMBER_41 for 41
            /// </summary>
            [EnumMember(Value = "41")]
            NUMBER_41 = 37,
            /// <summary>
            /// Enum NUMBER_42 for 42
            /// </summary>
            [EnumMember(Value = "42")]
            NUMBER_42 = 38,
            /// <summary>
            /// Enum NUMBER_44 for 44
            /// </summary>
            [EnumMember(Value = "44")]
            NUMBER_44 = 39,
            /// <summary>
            /// Enum NUMBER_45 for 45
            /// </summary>
            [EnumMember(Value = "45")]
            NUMBER_45 = 40,
            /// <summary>
            /// Enum NUMBER_46 for 46
            /// </summary>
            [EnumMember(Value = "46")]
            NUMBER_46 = 41,
            /// <summary>
            /// Enum NUMBER_47 for 47
            /// </summary>
            [EnumMember(Value = "47")]
            NUMBER_47 = 42,
            /// <summary>
            /// Enum NUMBER_48 for 48
            /// </summary>
            [EnumMember(Value = "48")]
            NUMBER_48 = 43,
            /// <summary>
            /// Enum NUMBER_49 for 49
            /// </summary>
            [EnumMember(Value = "49")]
            NUMBER_49 = 44,
            /// <summary>
            /// Enum NUMBER_50 for 50
            /// </summary>
            [EnumMember(Value = "50")]
            NUMBER_50 = 45,
            /// <summary>
            /// Enum NUMBER_51 for 51
            /// </summary>
            [EnumMember(Value = "51")]
            NUMBER_51 = 46,
            /// <summary>
            /// Enum NUMBER_53 for 53
            /// </summary>
            [EnumMember(Value = "53")]
            NUMBER_53 = 47,
            /// <summary>
            /// Enum NUMBER_54 for 54
            /// </summary>
            [EnumMember(Value = "54")]
            NUMBER_54 = 48,
            /// <summary>
            /// Enum NUMBER_55 for 55
            /// </summary>
            [EnumMember(Value = "55")]
            NUMBER_55 = 49,
            /// <summary>
            /// Enum NUMBER_56 for 56
            /// </summary>
            [EnumMember(Value = "56")]
            NUMBER_56 = 50,
            /// <summary>
            /// Enum NUMBER_60 for 60
            /// </summary>
            [EnumMember(Value = "60")]
            NUMBER_60 = 51,
            /// <summary>
            /// Enum NUMBER_64 for 64
            /// </summary>
            [EnumMember(Value = "64")]
            NUMBER_64 = 52,
            /// <summary>
            /// Enum NUMBER_66 for 66
            /// </summary>
            [EnumMember(Value = "66")]
            NUMBER_66 = 53,
            /// <summary>
            /// Enum NUMBER_67 for 67
            /// </summary>
            [EnumMember(Value = "67")]
            NUMBER_67 = 54,
            /// <summary>
            /// Enum NUMBER_68 for 68
            /// </summary>
            [EnumMember(Value = "68")]
            NUMBER_68 = 55,
            /// <summary>
            /// Enum NUMBER_69 for 69
            /// </summary>
            [EnumMember(Value = "69")]
            NUMBER_69 = 56,
            /// <summary>
            /// Enum NUMBER_70 for 70
            /// </summary>
            [EnumMember(Value = "70")]
            NUMBER_70 = 57,
            /// <summary>
            /// Enum NUMBER_71 for 71
            /// </summary>
            [EnumMember(Value = "71")]
            NUMBER_71 = 58,
            /// <summary>
            /// Enum NUMBER_72 for 72
            /// </summary>
            [EnumMember(Value = "72")]
            NUMBER_72 = 59,
            /// <summary>
            /// Enum NUMBER_74 for 74
            /// </summary>
            [EnumMember(Value = "74")]
            NUMBER_74 = 60,
            /// <summary>
            /// Enum NUMBER_76 for 76
            /// </summary>
            [EnumMember(Value = "76")]
            NUMBER_76 = 61,
            /// <summary>
            /// Enum NUMBER_78 for 78
            /// </summary>
            [EnumMember(Value = "78")]
            NUMBER_78 = 62,
            /// <summary>
            /// Enum NUMBER_79 for 79
            /// </summary>
            [EnumMember(Value = "79")]
            NUMBER_79 = 63,
            /// <summary>
            /// Enum NUMBER_81 for 81
            /// </summary>
            [EnumMember(Value = "81")]
            NUMBER_81 = 64,
            /// <summary>
            /// Enum NUMBER_84 for 84
            /// </summary>
            [EnumMember(Value = "84")]
            NUMBER_84 = 65,
            /// <summary>
            /// Enum NUMBER_86 for 86
            /// </summary>
            [EnumMember(Value = "86")]
            NUMBER_86 = 66,
            /// <summary>
            /// Enum NUMBER_89 for 89
            /// </summary>
            [EnumMember(Value = "89")]
            NUMBER_89 = 67,
            /// <summary>
            /// Enum NUMBER_95 for 95
            /// </summary>
            [EnumMember(Value = "95")]
            NUMBER_95 = 68        }
}
