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
        /// A data type for an angle of direction between -179 and 180, with 0 being upright
        /// </summary>
        /// <value>A data type for an angle of direction between -179 and 180, with 0 being upright</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomRelativeRotationMeasureSimpleType
        {
            /// <summary>
            /// Enum NUMBER_MINUS_179 for -179
            /// </summary>
            [EnumMember(Value = "-179")]
            NUMBER_MINUS_179 = 0,
            /// <summary>
            /// Enum NUMBER_180 for 180
            /// </summary>
            [EnumMember(Value = "180")]
            NUMBER_180 = 1        }
}