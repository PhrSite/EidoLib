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
        /// A data type for a kind of finger view
        /// </summary>
        /// <value>A data type for a kind of finger view</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomFingerViewCodeSimpleType
        {
            /// <summary>
            /// Enum EJIEnum for EJI
            /// </summary>
            [EnumMember(Value = "EJI")]
            EJIEnum = 0,
            /// <summary>
            /// Enum FV1Enum for FV1
            /// </summary>
            [EnumMember(Value = "FV1")]
            FV1Enum = 1,
            /// <summary>
            /// Enum FV2Enum for FV2
            /// </summary>
            [EnumMember(Value = "FV2")]
            FV2Enum = 2,
            /// <summary>
            /// Enum FV3Enum for FV3
            /// </summary>
            [EnumMember(Value = "FV3")]
            FV3Enum = 3,
            /// <summary>
            /// Enum FV4Enum for FV4
            /// </summary>
            [EnumMember(Value = "FV4")]
            FV4Enum = 4,
            /// <summary>
            /// Enum NAEnum for NA
            /// </summary>
            [EnumMember(Value = "NA")]
            NAEnum = 5,
            /// <summary>
            /// Enum TIPEnum for TIP
            /// </summary>
            [EnumMember(Value = "TIP")]
            TIPEnum = 6,
            /// <summary>
            /// Enum TPPEnum for TPP
            /// </summary>
            [EnumMember(Value = "TPP")]
            TPPEnum = 7        }
}
