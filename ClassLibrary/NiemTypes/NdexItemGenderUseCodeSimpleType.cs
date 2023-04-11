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
        /// A data type for a code that identifies the gender for which the property is intended, such as a girl's bicycle or a man's jacket.
        /// </summary>
        /// <value>A data type for a code that identifies the gender for which the property is intended, such as a girl's bicycle or a man's jacket.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexItemGenderUseCodeSimpleType
        {
            /// <summary>
            /// Enum FEMALEEnum for FEMALE
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALEEnum = 0,
            /// <summary>
            /// Enum FEMALEGIRLSEnum for FEMALE_GIRLS
            /// </summary>
            [EnumMember(Value = "FEMALE_GIRLS")]
            FEMALEGIRLSEnum = 1,
            /// <summary>
            /// Enum FEMALEWOMENSEnum for FEMALE_WOMENS
            /// </summary>
            [EnumMember(Value = "FEMALE_WOMENS")]
            FEMALEWOMENSEnum = 2,
            /// <summary>
            /// Enum MALEEnum for MALE
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALEEnum = 3,
            /// <summary>
            /// Enum MALEBOYSEnum for MALE_BOYS
            /// </summary>
            [EnumMember(Value = "MALE_BOYS")]
            MALEBOYSEnum = 4,
            /// <summary>
            /// Enum MALEMENSEnum for MALE_MENS
            /// </summary>
            [EnumMember(Value = "MALE_MENS")]
            MALEMENSEnum = 5,
            /// <summary>
            /// Enum UNISEXEnum for UNISEX
            /// </summary>
            [EnumMember(Value = "UNISEX")]
            UNISEXEnum = 6        }
}