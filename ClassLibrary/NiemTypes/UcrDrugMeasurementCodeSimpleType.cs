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
        /// A data type for the kinds of measurements used to specify a quantity of drugs or narcotics.
        /// </summary>
        /// <value>A data type for the kinds of measurements used to specify a quantity of drugs or narcotics.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UcrDrugMeasurementCodeSimpleType
        {
            /// <summary>
            /// Enum DUEnum for DU
            /// </summary>
            [EnumMember(Value = "DU")]
            DUEnum = 0,
            /// <summary>
            /// Enum FOEnum for FO
            /// </summary>
            [EnumMember(Value = "FO")]
            FOEnum = 1,
            /// <summary>
            /// Enum GLEnum for GL
            /// </summary>
            [EnumMember(Value = "GL")]
            GLEnum = 2,
            /// <summary>
            /// Enum GMEnum for GM
            /// </summary>
            [EnumMember(Value = "GM")]
            GMEnum = 3,
            /// <summary>
            /// Enum KGEnum for KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KGEnum = 4,
            /// <summary>
            /// Enum LBEnum for LB
            /// </summary>
            [EnumMember(Value = "LB")]
            LBEnum = 5,
            /// <summary>
            /// Enum LTEnum for LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LTEnum = 6,
            /// <summary>
            /// Enum MLEnum for ML
            /// </summary>
            [EnumMember(Value = "ML")]
            MLEnum = 7,
            /// <summary>
            /// Enum NPEnum for NP
            /// </summary>
            [EnumMember(Value = "NP")]
            NPEnum = 8,
            /// <summary>
            /// Enum OZEnum for OZ
            /// </summary>
            [EnumMember(Value = "OZ")]
            OZEnum = 9,
            /// <summary>
            /// Enum XXEnum for XX
            /// </summary>
            [EnumMember(Value = "XX")]
            XXEnum = 10        }
}