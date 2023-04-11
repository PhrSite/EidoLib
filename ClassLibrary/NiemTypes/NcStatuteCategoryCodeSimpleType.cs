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
        /// A data type for kinds of statutes.
        /// </summary>
        /// <value>A data type for kinds of statutes.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcStatuteCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 0,
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 1,
            /// <summary>
            /// Enum DEnum for D
            /// </summary>
            [EnumMember(Value = "D")]
            DEnum = 2,
            /// <summary>
            /// Enum JEnum for J
            /// </summary>
            [EnumMember(Value = "J")]
            JEnum = 3,
            /// <summary>
            /// Enum NEnum for N
            /// </summary>
            [EnumMember(Value = "N")]
            NEnum = 4,
            /// <summary>
            /// Enum PEnum for P
            /// </summary>
            [EnumMember(Value = "P")]
            PEnum = 5        }
}
