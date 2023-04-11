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
        /// A data type for compass directions.
        /// </summary>
        /// <value>A data type for compass directions.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcDirectionCodeSimpleType
        {
            /// <summary>
            /// Enum EEnum for E
            /// </summary>
            [EnumMember(Value = "E")]
            EEnum = 0,
            /// <summary>
            /// Enum ENEEnum for ENE
            /// </summary>
            [EnumMember(Value = "ENE")]
            ENEEnum = 1,
            /// <summary>
            /// Enum ESEEnum for ESE
            /// </summary>
            [EnumMember(Value = "ESE")]
            ESEEnum = 2,
            /// <summary>
            /// Enum NEnum for N
            /// </summary>
            [EnumMember(Value = "N")]
            NEnum = 3,
            /// <summary>
            /// Enum NEEnum for NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NEEnum = 4,
            /// <summary>
            /// Enum NNEEnum for NNE
            /// </summary>
            [EnumMember(Value = "NNE")]
            NNEEnum = 5,
            /// <summary>
            /// Enum NNWEnum for NNW
            /// </summary>
            [EnumMember(Value = "NNW")]
            NNWEnum = 6,
            /// <summary>
            /// Enum NWEnum for NW
            /// </summary>
            [EnumMember(Value = "NW")]
            NWEnum = 7,
            /// <summary>
            /// Enum SEnum for S
            /// </summary>
            [EnumMember(Value = "S")]
            SEnum = 8,
            /// <summary>
            /// Enum SEEnum for SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SEEnum = 9,
            /// <summary>
            /// Enum SSEEnum for SSE
            /// </summary>
            [EnumMember(Value = "SSE")]
            SSEEnum = 10,
            /// <summary>
            /// Enum SSWEnum for SSW
            /// </summary>
            [EnumMember(Value = "SSW")]
            SSWEnum = 11,
            /// <summary>
            /// Enum SWEnum for SW
            /// </summary>
            [EnumMember(Value = "SW")]
            SWEnum = 12,
            /// <summary>
            /// Enum WEnum for W
            /// </summary>
            [EnumMember(Value = "W")]
            WEnum = 13,
            /// <summary>
            /// Enum WNWEnum for WNW
            /// </summary>
            [EnumMember(Value = "WNW")]
            WNWEnum = 14,
            /// <summary>
            /// Enum WSWEnum for WSW
            /// </summary>
            [EnumMember(Value = "WSW")]
            WSWEnum = 15        }
}