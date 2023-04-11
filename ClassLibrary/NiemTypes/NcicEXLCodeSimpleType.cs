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
        /// A data type for 20 - Warrants Extradition Limitation (EXL) Field Codes
        /// </summary>
        /// <value>A data type for 20 - Warrants Extradition Limitation (EXL) Field Codes</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcicEXLCodeSimpleType
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
            /// Enum NUMBER_03 for 03
            /// </summary>
            [EnumMember(Value = "03")]
            NUMBER_03 = 2,
            /// <summary>
            /// Enum NUMBER_04 for 04
            /// </summary>
            [EnumMember(Value = "04")]
            NUMBER_04 = 3,
            /// <summary>
            /// Enum NUMBER_05 for 05
            /// </summary>
            [EnumMember(Value = "05")]
            NUMBER_05 = 4,
            /// <summary>
            /// Enum NUMBER_06 for 06
            /// </summary>
            [EnumMember(Value = "06")]
            NUMBER_06 = 5,
            /// <summary>
            /// Enum AEnum for A
            /// </summary>
            [EnumMember(Value = "A")]
            AEnum = 6,
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 7,
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 8,
            /// <summary>
            /// Enum DEnum for D
            /// </summary>
            [EnumMember(Value = "D")]
            DEnum = 9,
            /// <summary>
            /// Enum EEnum for E
            /// </summary>
            [EnumMember(Value = "E")]
            EEnum = 10,
            /// <summary>
            /// Enum FEnum for F
            /// </summary>
            [EnumMember(Value = "F")]
            FEnum = 11        }
}
