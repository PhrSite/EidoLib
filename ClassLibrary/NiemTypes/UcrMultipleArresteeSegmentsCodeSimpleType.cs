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
        /// A data type for the ways in which an arrested subject is counted or scored in a system so that a subject is counted only once despite potentially multiple arrests at a time.
        /// </summary>
        /// <value>A data type for the ways in which an arrested subject is counted or scored in a system so that a subject is counted only once despite potentially multiple arrests at a time.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UcrMultipleArresteeSegmentsCodeSimpleType
        {
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 0,
            /// <summary>
            /// Enum MEnum for M
            /// </summary>
            [EnumMember(Value = "M")]
            MEnum = 1,
            /// <summary>
            /// Enum NEnum for N
            /// </summary>
            [EnumMember(Value = "N")]
            NEnum = 2        }
}
