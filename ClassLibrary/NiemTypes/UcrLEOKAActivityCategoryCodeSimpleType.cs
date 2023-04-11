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
        /// A data type for a kind of activity or circumstance in which a law enforcement officer was engaged at the time of assault.
        /// </summary>
        /// <value>A data type for a kind of activity or circumstance in which a law enforcement officer was engaged at the time of assault.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UcrLEOKAActivityCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum NUMBER_01 for 01
            /// </summary>
            [EnumMember(Value = "01")]
            NUMBER_01 = 0,
            /// <summary>
            /// Enum NUMBER_02 for 02
            /// </summary>
            [EnumMember(Value = "02")]
            NUMBER_02 = 1,
            /// <summary>
            /// Enum NUMBER_03 for 03
            /// </summary>
            [EnumMember(Value = "03")]
            NUMBER_03 = 2,
            /// <summary>
            /// Enum NUMBER_04 for 04
            /// </summary>
            [EnumMember(Value = "04")]
            NUMBER_04 = 3,
            /// <summary>
            /// Enum NUMBER_05 for 05
            /// </summary>
            [EnumMember(Value = "05")]
            NUMBER_05 = 4,
            /// <summary>
            /// Enum NUMBER_06 for 06
            /// </summary>
            [EnumMember(Value = "06")]
            NUMBER_06 = 5,
            /// <summary>
            /// Enum NUMBER_07 for 07
            /// </summary>
            [EnumMember(Value = "07")]
            NUMBER_07 = 6,
            /// <summary>
            /// Enum NUMBER_8 for 8
            /// </summary>
            [EnumMember(Value = "8")]
            NUMBER_8 = 7,
            /// <summary>
            /// Enum NUMBER_9 for 9
            /// </summary>
            [EnumMember(Value = "9")]
            NUMBER_9 = 8,
            /// <summary>
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 9,
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 10        }
}
