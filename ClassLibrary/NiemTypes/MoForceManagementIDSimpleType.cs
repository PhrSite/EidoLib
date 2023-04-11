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
        /// A data type for a  set of identifiers and indexes used to identify data within the GFM XSD. FMIDs convey no information about the entity they identify, are a fixed size, and are exchanged as a single attribute.
        /// </summary>
        /// <value>A data type for a  set of identifiers and indexes used to identify data within the GFM XSD. FMIDs convey no information about the entity they identify, are a fixed size, and are exchanged as a single attribute.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MoForceManagementIDSimpleType
        {
            /// <summary>
            /// Enum NUMBER_18446744073709551615 for 18446744073709551615
            /// </summary>
            [EnumMember(Value = "18446744073709551615")]
            NUMBER_18446744073709551615 = 0,
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 1        }
}
