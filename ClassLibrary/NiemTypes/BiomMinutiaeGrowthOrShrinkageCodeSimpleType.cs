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
        /// A data type for a growth or shrinkage of an image, i.e. whether this impression may be larger or smaller than other exemplars for this subject
        /// </summary>
        /// <value>A data type for a growth or shrinkage of an image, i.e. whether this impression may be larger or smaller than other exemplars for this subject</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomMinutiaeGrowthOrShrinkageCodeSimpleType
        {
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 0,
            /// <summary>
            /// Enum GEnum for G
            /// </summary>
            [EnumMember(Value = "G")]
            GEnum = 1,
            /// <summary>
            /// Enum SEnum for S
            /// </summary>
            [EnumMember(Value = "S")]
            SEnum = 2        }
}
