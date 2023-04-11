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
        /// A data type for a code set that denotes the methods of payment for Duty Tax
        /// </summary>
        /// <value>A data type for a code set that denotes the methods of payment for Duty Tax</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ItcodesDutyTaxPaymentMethodCodeSimpleType
        {
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 0,
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 1,
            /// <summary>
            /// Enum EEnum for E
            /// </summary>
            [EnumMember(Value = "E")]
            EEnum = 2,
            /// <summary>
            /// Enum FEnum for F
            /// </summary>
            [EnumMember(Value = "F")]
            FEnum = 3,
            /// <summary>
            /// Enum HEnum for H
            /// </summary>
            [EnumMember(Value = "H")]
            HEnum = 4,
            /// <summary>
            /// Enum IEnum for I
            /// </summary>
            [EnumMember(Value = "I")]
            IEnum = 5,
            /// <summary>
            /// Enum KEnum for K
            /// </summary>
            [EnumMember(Value = "K")]
            KEnum = 6,
            /// <summary>
            /// Enum OEnum for O
            /// </summary>
            [EnumMember(Value = "O")]
            OEnum = 7,
            /// <summary>
            /// Enum PEnum for P
            /// </summary>
            [EnumMember(Value = "P")]
            PEnum = 8,
            /// <summary>
            /// Enum REnum for R
            /// </summary>
            [EnumMember(Value = "R")]
            REnum = 9,
            /// <summary>
            /// Enum SEnum for S
            /// </summary>
            [EnumMember(Value = "S")]
            SEnum = 10,
            /// <summary>
            /// Enum VEnum for V
            /// </summary>
            [EnumMember(Value = "V")]
            VEnum = 11,
            /// <summary>
            /// Enum WEnum for W
            /// </summary>
            [EnumMember(Value = "W")]
            WEnum = 12,
            /// <summary>
            /// Enum XEnum for X
            /// </summary>
            [EnumMember(Value = "X")]
            XEnum = 13,
            /// <summary>
            /// Enum YEnum for Y
            /// </summary>
            [EnumMember(Value = "Y")]
            YEnum = 14        }
}