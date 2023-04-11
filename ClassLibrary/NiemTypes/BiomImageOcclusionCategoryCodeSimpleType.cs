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
        /// A data type for a kind of blockage in an image
        /// </summary>
        /// <value>A data type for a kind of blockage in an image</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomImageOcclusionCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 0,
            /// <summary>
            /// Enum HEnum for H
            /// </summary>
            [EnumMember(Value = "H")]
            HEnum = 1,
            /// <summary>
            /// Enum LEnum for L
            /// </summary>
            [EnumMember(Value = "L")]
            LEnum = 2,
            /// <summary>
            /// Enum OEnum for O
            /// </summary>
            [EnumMember(Value = "O")]
            OEnum = 3,
            /// <summary>
            /// Enum REnum for R
            /// </summary>
            [EnumMember(Value = "R")]
            REnum = 4,
            /// <summary>
            /// Enum SEnum for S
            /// </summary>
            [EnumMember(Value = "S")]
            SEnum = 5        }
}
