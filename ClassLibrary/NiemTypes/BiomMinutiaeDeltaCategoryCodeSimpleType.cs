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
        /// A data type for a kind of delta
        /// </summary>
        /// <value>A data type for a kind of delta</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomMinutiaeDeltaCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum Empty for null
            /// </summary>
            [EnumMember(Value = null)]
            Empty = 0,
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 1,
            /// <summary>
            /// Enum I00Enum for I00
            /// </summary>
            [EnumMember(Value = "I00")]
            I00Enum = 2,
            /// <summary>
            /// Enum I02Enum for I02
            /// </summary>
            [EnumMember(Value = "I02")]
            I02Enum = 3,
            /// <summary>
            /// Enum I03Enum for I03
            /// </summary>
            [EnumMember(Value = "I03")]
            I03Enum = 4,
            /// <summary>
            /// Enum I04Enum for I04
            /// </summary>
            [EnumMember(Value = "I04")]
            I04Enum = 5,
            /// <summary>
            /// Enum I05Enum for I05
            /// </summary>
            [EnumMember(Value = "I05")]
            I05Enum = 6,
            /// <summary>
            /// Enum I07Enum for I07
            /// </summary>
            [EnumMember(Value = "I07")]
            I07Enum = 7,
            /// <summary>
            /// Enum I08Enum for I08
            /// </summary>
            [EnumMember(Value = "I08")]
            I08Enum = 8,
            /// <summary>
            /// Enum I09Enum for I09
            /// </summary>
            [EnumMember(Value = "I09")]
            I09Enum = 9,
            /// <summary>
            /// Enum I10Enum for I10
            /// </summary>
            [EnumMember(Value = "I10")]
            I10Enum = 10,
            /// <summary>
            /// Enum I16Enum for I16
            /// </summary>
            [EnumMember(Value = "I16")]
            I16Enum = 11,
            /// <summary>
            /// Enum I17Enum for I17
            /// </summary>
            [EnumMember(Value = "I17")]
            I17Enum = 12,
            /// <summary>
            /// Enum LEnum for L
            /// </summary>
            [EnumMember(Value = "L")]
            LEnum = 13,
            /// <summary>
            /// Enum REnum for R
            /// </summary>
            [EnumMember(Value = "R")]
            REnum = 14        }
}
