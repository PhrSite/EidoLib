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
        /// A data type for a degree of longitude.
        /// </summary>
        /// <value>A data type for a degree of longitude.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcLongitudeDegreeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_180 for 180
            /// </summary>
            [EnumMember(Value = "180")]
            NUMBER_180 = 0,
            /// <summary>
            /// Enum NUMBER_MINUS_180 for -180
            /// </summary>
            [EnumMember(Value = "-180")]
            NUMBER_MINUS_180 = 1        }
}
