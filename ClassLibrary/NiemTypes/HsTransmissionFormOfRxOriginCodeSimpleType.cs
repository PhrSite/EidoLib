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
        /// A data type for a transmission method by which a pharmacy receives a prescription.
        /// </summary>
        /// <value>A data type for a transmission method by which a pharmacy receives a prescription.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HsTransmissionFormOfRxOriginCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_01 for 01
            /// </summary>
            [EnumMember(Value = "01")]
            NUMBER_01 = 0,
            /// <summary>
            /// Enum NUMBER_02 for 02
            /// </summary>
            [EnumMember(Value = "02")]
            NUMBER_02 = 1,
            /// <summary>
            /// Enum NUMBER_03 for 03
            /// </summary>
            [EnumMember(Value = "03")]
            NUMBER_03 = 2,
            /// <summary>
            /// Enum NUMBER_04 for 04
            /// </summary>
            [EnumMember(Value = "04")]
            NUMBER_04 = 3,
            /// <summary>
            /// Enum NUMBER_05 for 05
            /// </summary>
            [EnumMember(Value = "05")]
            NUMBER_05 = 4,
            /// <summary>
            /// Enum NUMBER_99 for 99
            /// </summary>
            [EnumMember(Value = "99")]
            NUMBER_99 = 5        }
}