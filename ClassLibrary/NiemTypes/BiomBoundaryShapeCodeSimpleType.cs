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
        /// A data type for a shape of a boundary of a feature within an image
        /// </summary>
        /// <value>A data type for a shape of a boundary of a feature within an image</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomBoundaryShapeCodeSimpleType
        {
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 0,
            /// <summary>
            /// Enum EEnum for E
            /// </summary>
            [EnumMember(Value = "E")]
            EEnum = 1,
            /// <summary>
            /// Enum PEnum for P
            /// </summary>
            [EnumMember(Value = "P")]
            PEnum = 2        }
}
