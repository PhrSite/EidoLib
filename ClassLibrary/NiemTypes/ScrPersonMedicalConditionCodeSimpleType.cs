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
        /// A data type describing the kinds of medical conditions for a person involved in a screening activity
        /// </summary>
        /// <value>A data type describing the kinds of medical conditions for a person involved in a screening activity</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ScrPersonMedicalConditionCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 0,
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 1,
            /// <summary>
            /// Enum NUMBER_25 for 25
            /// </summary>
            [EnumMember(Value = "25")]
            NUMBER_25 = 2,
            /// <summary>
            /// Enum NUMBER_5 for 5
            /// </summary>
            [EnumMember(Value = "5")]
            NUMBER_5 = 3,
            /// <summary>
            /// Enum NUMBER_50 for 50
            /// </summary>
            [EnumMember(Value = "50")]
            NUMBER_50 = 4,
            /// <summary>
            /// Enum NUMBER_55 for 55
            /// </summary>
            [EnumMember(Value = "55")]
            NUMBER_55 = 5,
            /// <summary>
            /// Enum NUMBER_60 for 60
            /// </summary>
            [EnumMember(Value = "60")]
            NUMBER_60 = 6,
            /// <summary>
            /// Enum NUMBER_65 for 65
            /// </summary>
            [EnumMember(Value = "65")]
            NUMBER_65 = 7,
            /// <summary>
            /// Enum NUMBER_70 for 70
            /// </summary>
            [EnumMember(Value = "70")]
            NUMBER_70 = 8,
            /// <summary>
            /// Enum NUMBER_80 for 80
            /// </summary>
            [EnumMember(Value = "80")]
            NUMBER_80 = 9,
            /// <summary>
            /// Enum NUMBER_85 for 85
            /// </summary>
            [EnumMember(Value = "85")]
            NUMBER_85 = 10,
            /// <summary>
            /// Enum NUMBER_90 for 90
            /// </summary>
            [EnumMember(Value = "90")]
            NUMBER_90 = 11        }
}