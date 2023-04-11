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
        /// A data type for a lighting spectrum used in capturing an iris image
        /// </summary>
        /// <value>A data type for a lighting spectrum used in capturing an iris image</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomAcquisitionLightingSpectrumCodeSimpleType
        {
            /// <summary>
            /// Enum DEFINEDEnum for DEFINED
            /// </summary>
            [EnumMember(Value = "DEFINED")]
            DEFINEDEnum = 0,
            /// <summary>
            /// Enum NIREnum for NIR
            /// </summary>
            [EnumMember(Value = "NIR")]
            NIREnum = 1,
            /// <summary>
            /// Enum REDEnum for RED
            /// </summary>
            [EnumMember(Value = "RED")]
            REDEnum = 2,
            /// <summary>
            /// Enum UNDEFINEDEnum for UNDEFINED
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINEDEnum = 3,
            /// <summary>
            /// Enum VISEnum for VIS
            /// </summary>
            [EnumMember(Value = "VIS")]
            VISEnum = 4        }
}
