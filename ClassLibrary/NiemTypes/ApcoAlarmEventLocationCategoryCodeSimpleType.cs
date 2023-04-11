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
        /// A data type for the kinds of location at which an alarm event occurs.
        /// </summary>
        /// <value>A data type for the kinds of location at which an alarm event occurs.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ApcoAlarmEventLocationCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum CommercialEnum for commercial
            /// </summary>
            [EnumMember(Value = "commercial")]
            CommercialEnum = 0,
            /// <summary>
            /// Enum ResidentialEnum for residential
            /// </summary>
            [EnumMember(Value = "residential")]
            ResidentialEnum = 1        }
}
