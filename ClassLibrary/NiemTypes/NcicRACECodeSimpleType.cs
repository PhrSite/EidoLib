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
        /// A data type for 3 - Race (RAC), Protected Person Race (PPR), and Person with Information Race (PIR) Field Codes
        /// </summary>
        /// <value>A data type for 3 - Race (RAC), Protected Person Race (PPR), and Person with Information Race (PIR) Field Codes</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcicRACECodeSimpleType
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
            /// Enum IEnum for I
            /// </summary>
            [EnumMember(Value = "I")]
            IEnum = 2,
            /// <summary>
            /// Enum UEnum for U
            /// </summary>
            [EnumMember(Value = "U")]
            UEnum = 3,
            /// <summary>
            /// Enum WEnum for W
            /// </summary>
            [EnumMember(Value = "W")]
            WEnum = 4        }
}
