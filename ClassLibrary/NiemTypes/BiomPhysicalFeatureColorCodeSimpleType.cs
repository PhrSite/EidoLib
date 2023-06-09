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
        /// A data type for a color of a physical feature. This code is used to indicate the color of a SMT
        /// </summary>
        /// <value>A data type for a color of a physical feature. This code is used to indicate the color of a SMT</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomPhysicalFeatureColorCodeSimpleType
        {
            /// <summary>
            /// Enum BLACKEnum for BLACK
            /// </summary>
            [EnumMember(Value = "BLACK")]
            BLACKEnum = 0,
            /// <summary>
            /// Enum BLUEEnum for BLUE
            /// </summary>
            [EnumMember(Value = "BLUE")]
            BLUEEnum = 1,
            /// <summary>
            /// Enum BROWNEnum for BROWN
            /// </summary>
            [EnumMember(Value = "BROWN")]
            BROWNEnum = 2,
            /// <summary>
            /// Enum GRAYEnum for GRAY
            /// </summary>
            [EnumMember(Value = "GRAY")]
            GRAYEnum = 3,
            /// <summary>
            /// Enum GREENEnum for GREEN
            /// </summary>
            [EnumMember(Value = "GREEN")]
            GREENEnum = 4,
            /// <summary>
            /// Enum MULTIEnum for MULTI
            /// </summary>
            [EnumMember(Value = "MULTI")]
            MULTIEnum = 5,
            /// <summary>
            /// Enum ORANGEEnum for ORANGE
            /// </summary>
            [EnumMember(Value = "ORANGE")]
            ORANGEEnum = 6,
            /// <summary>
            /// Enum OUTLINEEnum for OUTLINE
            /// </summary>
            [EnumMember(Value = "OUTLINE")]
            OUTLINEEnum = 7,
            /// <summary>
            /// Enum PURPLEEnum for PURPLE
            /// </summary>
            [EnumMember(Value = "PURPLE")]
            PURPLEEnum = 8,
            /// <summary>
            /// Enum REDEnum for RED
            /// </summary>
            [EnumMember(Value = "RED")]
            REDEnum = 9,
            /// <summary>
            /// Enum WHITEEnum for WHITE
            /// </summary>
            [EnumMember(Value = "WHITE")]
            WHITEEnum = 10,
            /// <summary>
            /// Enum YELLOWEnum for YELLOW
            /// </summary>
            [EnumMember(Value = "YELLOW")]
            YELLOWEnum = 11        }
}
