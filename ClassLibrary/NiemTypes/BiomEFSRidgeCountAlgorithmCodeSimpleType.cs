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
        /// A data type for a quadrant matrix for associating minutiae
        /// </summary>
        /// <value>A data type for a quadrant matrix for associating minutiae</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomEFSRidgeCountAlgorithmCodeSimpleType
        {
            /// <summary>
            /// Enum EFTS7Enum for EFTS7
            /// </summary>
            [EnumMember(Value = "EFTS7")]
            EFTS7Enum = 0,
            /// <summary>
            /// Enum OCTANTEnum for OCTANT
            /// </summary>
            [EnumMember(Value = "OCTANT")]
            OCTANTEnum = 1,
            /// <summary>
            /// Enum QUADRANTEnum for QUADRANT
            /// </summary>
            [EnumMember(Value = "QUADRANT")]
            QUADRANTEnum = 2        }
}