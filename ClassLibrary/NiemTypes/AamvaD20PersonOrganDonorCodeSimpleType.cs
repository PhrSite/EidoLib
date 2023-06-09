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
        /// A data type for organs a person could be willing to donate upon death.
        /// </summary>
        /// <value>A data type for organs a person could be willing to donate upon death.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AamvaD20PersonOrganDonorCodeSimpleType
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
            /// Enum EEnum for E
            /// </summary>
            [EnumMember(Value = "E")]
            EEnum = 3,
            /// <summary>
            /// Enum FEnum for F
            /// </summary>
            [EnumMember(Value = "F")]
            FEnum = 4,
            /// <summary>
            /// Enum HEnum for H
            /// </summary>
            [EnumMember(Value = "H")]
            HEnum = 5,
            /// <summary>
            /// Enum IEnum for I
            /// </summary>
            [EnumMember(Value = "I")]
            IEnum = 6,
            /// <summary>
            /// Enum KEnum for K
            /// </summary>
            [EnumMember(Value = "K")]
            KEnum = 7,
            /// <summary>
            /// Enum LEnum for L
            /// </summary>
            [EnumMember(Value = "L")]
            LEnum = 8,
            /// <summary>
            /// Enum MEnum for M
            /// </summary>
            [EnumMember(Value = "M")]
            MEnum = 9,
            /// <summary>
            /// Enum NEnum for N
            /// </summary>
            [EnumMember(Value = "N")]
            NEnum = 10,
            /// <summary>
            /// Enum PEnum for P
            /// </summary>
            [EnumMember(Value = "P")]
            PEnum = 11,
            /// <summary>
            /// Enum QEnum for Q
            /// </summary>
            [EnumMember(Value = "Q")]
            QEnum = 12,
            /// <summary>
            /// Enum REnum for R
            /// </summary>
            [EnumMember(Value = "R")]
            REnum = 13,
            /// <summary>
            /// Enum SEnum for S
            /// </summary>
            [EnumMember(Value = "S")]
            SEnum = 14,
            /// <summary>
            /// Enum TEnum for T
            /// </summary>
            [EnumMember(Value = "T")]
            TEnum = 15,
            /// <summary>
            /// Enum UEnum for U
            /// </summary>
            [EnumMember(Value = "U")]
            UEnum = 16,
            /// <summary>
            /// Enum VEnum for V
            /// </summary>
            [EnumMember(Value = "V")]
            VEnum = 17,
            /// <summary>
            /// Enum WEnum for W
            /// </summary>
            [EnumMember(Value = "W")]
            WEnum = 18,
            /// <summary>
            /// Enum ZEnum for Z
            /// </summary>
            [EnumMember(Value = "Z")]
            ZEnum = 19        }
}
