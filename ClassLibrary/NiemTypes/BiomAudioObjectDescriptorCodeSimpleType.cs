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
        /// A data type for an enumeration of codes describing Audio Objects
        /// </summary>
        /// <value>A data type for an enumeration of codes describing Audio Objects</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomAudioObjectDescriptorCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_0 for 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 0,
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 2,
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 3,
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 4,
            /// <summary>
            /// Enum NUMBER_5 for 5
            /// </summary>
            [EnumMember(Value = "5")]
            NUMBER_5 = 5        }
}
