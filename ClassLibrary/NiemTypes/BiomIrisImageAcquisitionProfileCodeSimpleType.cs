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
        /// A data type for a set of criteria under which the iris image was captured
        /// </summary>
        /// <value>A data type for a set of criteria under which the iris image was captured</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomIrisImageAcquisitionProfileCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 0,
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 1,
            /// <summary>
            /// Enum NUMBER_12 for 12
            /// </summary>
            [EnumMember(Value = "12")]
            NUMBER_12 = 2,
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 3,
            /// <summary>
            /// Enum NUMBER_30 for 30
            /// </summary>
            [EnumMember(Value = "30")]
            NUMBER_30 = 4,
            /// <summary>
            /// Enum NUMBER_40 for 40
            /// </summary>
            [EnumMember(Value = "40")]
            NUMBER_40 = 5        }
}
