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
        /// A data type for a set of criteria under which the facial image was captured
        /// </summary>
        /// <value>A data type for a set of criteria under which the facial image was captured</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomFaceImageAcquisitionProfileCodeSimpleType
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
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 2,
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 3,
            /// <summary>
            /// Enum NUMBER_12 for 12
            /// </summary>
            [EnumMember(Value = "12")]
            NUMBER_12 = 4,
            /// <summary>
            /// Enum NUMBER_13 for 13
            /// </summary>
            [EnumMember(Value = "13")]
            NUMBER_13 = 5,
            /// <summary>
            /// Enum NUMBER_14 for 14
            /// </summary>
            [EnumMember(Value = "14")]
            NUMBER_14 = 6,
            /// <summary>
            /// Enum NUMBER_15 for 15
            /// </summary>
            [EnumMember(Value = "15")]
            NUMBER_15 = 7,
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 8,
            /// <summary>
            /// Enum NUMBER_30 for 30
            /// </summary>
            [EnumMember(Value = "30")]
            NUMBER_30 = 9,
            /// <summary>
            /// Enum NUMBER_32 for 32
            /// </summary>
            [EnumMember(Value = "32")]
            NUMBER_32 = 10,
            /// <summary>
            /// Enum NUMBER_40 for 40
            /// </summary>
            [EnumMember(Value = "40")]
            NUMBER_40 = 11,
            /// <summary>
            /// Enum NUMBER_42 for 42
            /// </summary>
            [EnumMember(Value = "42")]
            NUMBER_42 = 12,
            /// <summary>
            /// Enum NUMBER_50 for 50
            /// </summary>
            [EnumMember(Value = "50")]
            NUMBER_50 = 13,
            /// <summary>
            /// Enum NUMBER_51 for 51
            /// </summary>
            [EnumMember(Value = "51")]
            NUMBER_51 = 14,
            /// <summary>
            /// Enum NUMBER_52 for 52
            /// </summary>
            [EnumMember(Value = "52")]
            NUMBER_52 = 15        }
}
