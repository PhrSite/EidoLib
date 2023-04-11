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
        /// A data type for a period of time or a situation in which an entity is available to be contacted with the given contact information.
        /// </summary>
        /// <value>A data type for a period of time or a situation in which an entity is available to be contacted with the given contact information.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcContactInformationAvailabilityCodeSimpleType
        {
            /// <summary>
            /// Enum DayEnum for day
            /// </summary>
            [EnumMember(Value = "day")]
            DayEnum = 0,
            /// <summary>
            /// Enum EmergencyEnum for emergency
            /// </summary>
            [EnumMember(Value = "emergency")]
            EmergencyEnum = 1,
            /// <summary>
            /// Enum EveningEnum for evening
            /// </summary>
            [EnumMember(Value = "evening")]
            EveningEnum = 2,
            /// <summary>
            /// Enum NightEnum for night
            /// </summary>
            [EnumMember(Value = "night")]
            NightEnum = 3,
            /// <summary>
            /// Enum PrimaryEnum for primary
            /// </summary>
            [EnumMember(Value = "primary")]
            PrimaryEnum = 4,
            /// <summary>
            /// Enum SecondaryEnum for secondary
            /// </summary>
            [EnumMember(Value = "secondary")]
            SecondaryEnum = 5        }
}
