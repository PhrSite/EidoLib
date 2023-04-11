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
        /// A data type of integer that has a value range of 1 to 999
        /// </summary>
        /// <value>A data type of integer that has a value range of 1 to 999</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomInteger1to999SimpleType
        {
            /// <summary>
            /// Enum NUMBER_999 for 999
            /// </summary>
            [EnumMember(Value = "999")]
            NUMBER_999 = 0        }
}
