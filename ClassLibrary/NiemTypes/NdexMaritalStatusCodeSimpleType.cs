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
        /// A data type for a code that identifies marital status.
        /// </summary>
        /// <value>A data type for a code that identifies marital status.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexMaritalStatusCodeSimpleType
        {
            /// <summary>
            /// Enum ANNULLEDEnum for ANNULLED
            /// </summary>
            [EnumMember(Value = "ANNULLED")]
            ANNULLEDEnum = 0,
            /// <summary>
            /// Enum COHABITATINGEnum for COHABITATING
            /// </summary>
            [EnumMember(Value = "COHABITATING")]
            COHABITATINGEnum = 1,
            /// <summary>
            /// Enum DIVORCEDEnum for DIVORCED
            /// </summary>
            [EnumMember(Value = "DIVORCED")]
            DIVORCEDEnum = 2,
            /// <summary>
            /// Enum ENGAGEDEnum for ENGAGED
            /// </summary>
            [EnumMember(Value = "ENGAGED")]
            ENGAGEDEnum = 3,
            /// <summary>
            /// Enum MARRIEDEnum for MARRIED
            /// </summary>
            [EnumMember(Value = "MARRIED")]
            MARRIEDEnum = 4,
            /// <summary>
            /// Enum SEPARATEDEnum for SEPARATED
            /// </summary>
            [EnumMember(Value = "SEPARATED")]
            SEPARATEDEnum = 5,
            /// <summary>
            /// Enum SINGLEEnum for SINGLE
            /// </summary>
            [EnumMember(Value = "SINGLE")]
            SINGLEEnum = 6,
            /// <summary>
            /// Enum UNKNOWNEnum for UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWNEnum = 7,
            /// <summary>
            /// Enum WIDOWEDEnum for WIDOWED
            /// </summary>
            [EnumMember(Value = "WIDOWED")]
            WIDOWEDEnum = 8        }
}
