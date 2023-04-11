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
        /// A data type for a class to which the Drug Enforcement Agency (DEA) has assigned the product under the Controlled Substances Act of 1970.
        /// </summary>
        /// <value>A data type for a class to which the Drug Enforcement Agency (DEA) has assigned the product under the Controlled Substances Act of 1970.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DeaDEAClassScheduleCodeCodeSimpleType
        {
            /// <summary>
            /// Enum IEnum for I
            /// </summary>
            [EnumMember(Value = "I")]
            IEnum = 0,
            /// <summary>
            /// Enum IIEnum for II
            /// </summary>
            [EnumMember(Value = "II")]
            IIEnum = 1,
            /// <summary>
            /// Enum IIIEnum for III
            /// </summary>
            [EnumMember(Value = "III")]
            IIIEnum = 2,
            /// <summary>
            /// Enum IVEnum for IV
            /// </summary>
            [EnumMember(Value = "IV")]
            IVEnum = 3,
            /// <summary>
            /// Enum VEnum for V
            /// </summary>
            [EnumMember(Value = "V")]
            VEnum = 4        }
}