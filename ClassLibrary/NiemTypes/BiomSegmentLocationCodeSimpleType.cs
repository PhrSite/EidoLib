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
        /// A data type for a finger segment location
        /// </summary>
        /// <value>A data type for a finger segment location</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomSegmentLocationCodeSimpleType
        {
            /// <summary>
            /// Enum DSTEnum for DST
            /// </summary>
            [EnumMember(Value = "DST")]
            DSTEnum = 0,
            /// <summary>
            /// Enum MEDEnum for MED
            /// </summary>
            [EnumMember(Value = "MED")]
            MEDEnum = 1,
            /// <summary>
            /// Enum NAEnum for NA
            /// </summary>
            [EnumMember(Value = "NA")]
            NAEnum = 2,
            /// <summary>
            /// Enum PRXEnum for PRX
            /// </summary>
            [EnumMember(Value = "PRX")]
            PRXEnum = 3,
            /// <summary>
            /// Enum UNKEnum for UNK
            /// </summary>
            [EnumMember(Value = "UNK")]
            UNKEnum = 4        }
}