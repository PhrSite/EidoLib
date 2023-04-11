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
        /// A data type for a sensitivity level of an incident.
        /// </summary>
        /// <value>A data type for a sensitivity level of an incident.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JIncidentLevelDisseminationCodeSimpleType
        {
            /// <summary>
            /// Enum GreenEnum for Green
            /// </summary>
            [EnumMember(Value = "Green")]
            GreenEnum = 0,
            /// <summary>
            /// Enum RedEnum for Red
            /// </summary>
            [EnumMember(Value = "Red")]
            RedEnum = 1,
            /// <summary>
            /// Enum YellowEnum for Yellow
            /// </summary>
            [EnumMember(Value = "Yellow")]
            YellowEnum = 2        }
}