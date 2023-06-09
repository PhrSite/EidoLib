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
        /// A data type for each of the available color spaces for images
        /// </summary>
        /// <value>A data type for each of the available color spaces for images</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomCSPCodeSimpleType
        {
            /// <summary>
            /// Enum GRAYEnum for GRAY
            /// </summary>
            [EnumMember(Value = "GRAY")]
            GRAYEnum = 0,
            /// <summary>
            /// Enum RGBEnum for RGB
            /// </summary>
            [EnumMember(Value = "RGB")]
            RGBEnum = 1,
            /// <summary>
            /// Enum SRGBEnum for SRGB
            /// </summary>
            [EnumMember(Value = "SRGB")]
            SRGBEnum = 2,
            /// <summary>
            /// Enum SYCCEnum for SYCC
            /// </summary>
            [EnumMember(Value = "SYCC")]
            SYCCEnum = 3,
            /// <summary>
            /// Enum UNKEnum for UNK
            /// </summary>
            [EnumMember(Value = "UNK")]
            UNKEnum = 4,
            /// <summary>
            /// Enum YCCEnum for YCC
            /// </summary>
            [EnumMember(Value = "YCC")]
            YCCEnum = 5        }
}
