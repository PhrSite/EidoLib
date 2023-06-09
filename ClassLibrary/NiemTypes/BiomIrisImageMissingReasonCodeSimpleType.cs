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
        /// A data type for a reason for a missing iris image
        /// </summary>
        /// <value>A data type for a reason for a missing iris image</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomIrisImageMissingReasonCodeSimpleType
        {
            /// <summary>
            /// Enum MAEnum for MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MAEnum = 0,
            /// <summary>
            /// Enum UCEnum for UC
            /// </summary>
            [EnumMember(Value = "UC")]
            UCEnum = 1        }
}
