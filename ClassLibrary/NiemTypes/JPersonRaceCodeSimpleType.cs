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
        /// A data type for a code set identifying a race of a person.
        /// </summary>
        /// <value>A data type for a code set identifying a race of a person.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JPersonRaceCodeSimpleType
        {
            /// <summary>
            /// Enum AsianEnum for Asian
            /// </summary>
            [EnumMember(Value = "Asian")]
            AsianEnum = 0,
            /// <summary>
            /// Enum BlackEnum for Black
            /// </summary>
            [EnumMember(Value = "Black")]
            BlackEnum = 1,
            /// <summary>
            /// Enum NativeAmericanEnum for Native American
            /// </summary>
            [EnumMember(Value = "Native American")]
            NativeAmericanEnum = 2,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 3,
            /// <summary>
            /// Enum WhiteEnum for White
            /// </summary>
            [EnumMember(Value = "White")]
            WhiteEnum = 4        }
}
