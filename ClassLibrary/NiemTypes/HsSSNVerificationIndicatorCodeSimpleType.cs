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
        /// A data type for a verification of a SSN by the Social Security Administration (SSA).
        /// </summary>
        /// <value>A data type for a verification of a SSN by the Social Security Administration (SSA).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HsSSNVerificationIndicatorCodeSimpleType
        {
            /// <summary>
            /// Enum Star for *
            /// </summary>
            [EnumMember(Value = "*")]
            Star = 0,
            /// <summary>
            /// Enum Period for .
            /// </summary>
            [EnumMember(Value = ".")]
            Period = 1,
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 2,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 3,
            /// <summary>
            /// Enum NUMBER_5 for 5
            /// </summary>
            [EnumMember(Value = "5")]
            NUMBER_5 = 4,
            /// <summary>
            /// Enum FEnum for F
            /// </summary>
            [EnumMember(Value = "F")]
            FEnum = 5,
            /// <summary>
            /// Enum MEnum for M
            /// </summary>
            [EnumMember(Value = "M")]
            MEnum = 6,
            /// <summary>
            /// Enum PEnum for P
            /// </summary>
            [EnumMember(Value = "P")]
            PEnum = 7,
            /// <summary>
            /// Enum REnum for R
            /// </summary>
            [EnumMember(Value = "R")]
            REnum = 8,
            /// <summary>
            /// Enum VEnum for V
            /// </summary>
            [EnumMember(Value = "V")]
            VEnum = 9,
            /// <summary>
            /// Enum XEnum for X
            /// </summary>
            [EnumMember(Value = "X")]
            XEnum = 10,
            /// <summary>
            /// Enum ZEnum for Z
            /// </summary>
            [EnumMember(Value = "Z")]
            ZEnum = 11        }
}