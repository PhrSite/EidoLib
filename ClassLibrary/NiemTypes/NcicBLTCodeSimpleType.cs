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
        /// A data type for 12 - Blood Type (BLT) Field Codes
        /// </summary>
        /// <value>A data type for 12 - Blood Type (BLT) Field Codes</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcicBLTCodeSimpleType
        {
            /// <summary>
            /// Enum _0NEGEnum for 0NEG
            /// </summary>
            [EnumMember(Value = "0NEG")]
            _0NEGEnum = 0,
            /// <summary>
            /// Enum _0P0SEnum for 0P0S
            /// </summary>
            [EnumMember(Value = "0P0S")]
            _0P0SEnum = 1,
            /// <summary>
            /// Enum _0UNKEnum for 0UNK
            /// </summary>
            [EnumMember(Value = "0UNK")]
            _0UNKEnum = 2,
            /// <summary>
            /// Enum ABNEGEnum for ABNEG
            /// </summary>
            [EnumMember(Value = "ABNEG")]
            ABNEGEnum = 3,
            /// <summary>
            /// Enum ABP0SEnum for ABP0S
            /// </summary>
            [EnumMember(Value = "ABP0S")]
            ABP0SEnum = 4,
            /// <summary>
            /// Enum ABUNKEnum for ABUNK
            /// </summary>
            [EnumMember(Value = "ABUNK")]
            ABUNKEnum = 5,
            /// <summary>
            /// Enum ANEGEnum for ANEG
            /// </summary>
            [EnumMember(Value = "ANEG")]
            ANEGEnum = 6,
            /// <summary>
            /// Enum AP0SEnum for AP0S
            /// </summary>
            [EnumMember(Value = "AP0S")]
            AP0SEnum = 7,
            /// <summary>
            /// Enum AUNKEnum for AUNK
            /// </summary>
            [EnumMember(Value = "AUNK")]
            AUNKEnum = 8,
            /// <summary>
            /// Enum BNEGEnum for BNEG
            /// </summary>
            [EnumMember(Value = "BNEG")]
            BNEGEnum = 9,
            /// <summary>
            /// Enum BP0SEnum for BP0S
            /// </summary>
            [EnumMember(Value = "BP0S")]
            BP0SEnum = 10,
            /// <summary>
            /// Enum BUNKEnum for BUNK
            /// </summary>
            [EnumMember(Value = "BUNK")]
            BUNKEnum = 11,
            /// <summary>
            /// Enum UNKWNEnum for UNKWN
            /// </summary>
            [EnumMember(Value = "UNKWN")]
            UNKWNEnum = 12        }
}
