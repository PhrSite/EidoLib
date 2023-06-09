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
        /// A data type for a code set identifying a blood group and RH factor of a person.
        /// </summary>
        /// <value>A data type for a code set identifying a blood group and RH factor of a person.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JPersonBloodTypeCodeSimpleType
        {
            /// <summary>
            /// Enum ANegativeEnum for A Negative
            /// </summary>
            [EnumMember(Value = "A Negative")]
            ANegativeEnum = 0,
            /// <summary>
            /// Enum APositiveEnum for A Positive
            /// </summary>
            [EnumMember(Value = "A Positive")]
            APositiveEnum = 1,
            /// <summary>
            /// Enum AUnknownEnum for A Unknown
            /// </summary>
            [EnumMember(Value = "A Unknown")]
            AUnknownEnum = 2,
            /// <summary>
            /// Enum ABNegativeEnum for AB Negative
            /// </summary>
            [EnumMember(Value = "AB Negative")]
            ABNegativeEnum = 3,
            /// <summary>
            /// Enum ABPositiveEnum for AB Positive
            /// </summary>
            [EnumMember(Value = "AB Positive")]
            ABPositiveEnum = 4,
            /// <summary>
            /// Enum ABUnknownEnum for AB Unknown
            /// </summary>
            [EnumMember(Value = "AB Unknown")]
            ABUnknownEnum = 5,
            /// <summary>
            /// Enum BNegativeEnum for B Negative
            /// </summary>
            [EnumMember(Value = "B Negative")]
            BNegativeEnum = 6,
            /// <summary>
            /// Enum BPositiveEnum for B Positive
            /// </summary>
            [EnumMember(Value = "B Positive")]
            BPositiveEnum = 7,
            /// <summary>
            /// Enum BUnknownEnum for B Unknown
            /// </summary>
            [EnumMember(Value = "B Unknown")]
            BUnknownEnum = 8,
            /// <summary>
            /// Enum ONegativeEnum for O Negative
            /// </summary>
            [EnumMember(Value = "O Negative")]
            ONegativeEnum = 9,
            /// <summary>
            /// Enum OPositiveEnum for O Positive
            /// </summary>
            [EnumMember(Value = "O Positive")]
            OPositiveEnum = 10,
            /// <summary>
            /// Enum OUnknownEnum for O Unknown
            /// </summary>
            [EnumMember(Value = "O Unknown")]
            OUnknownEnum = 11,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 12        }
}
