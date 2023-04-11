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
        /// A data type for a code that identifies the type of art object.
        /// </summary>
        /// <value>A data type for a code that identifies the type of art object.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexArtObjectCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum LITHOGRAPHEnum for LITHOGRAPH
            /// </summary>
            [EnumMember(Value = "LITHOGRAPH")]
            LITHOGRAPHEnum = 0,
            /// <summary>
            /// Enum MODELEnum for MODEL
            /// </summary>
            [EnumMember(Value = "MODEL")]
            MODELEnum = 1,
            /// <summary>
            /// Enum PAINTINGEnum for PAINTING
            /// </summary>
            [EnumMember(Value = "PAINTING")]
            PAINTINGEnum = 2,
            /// <summary>
            /// Enum PHOTOGRAPHEnum for PHOTOGRAPH
            /// </summary>
            [EnumMember(Value = "PHOTOGRAPH")]
            PHOTOGRAPHEnum = 3,
            /// <summary>
            /// Enum SCULPTUREEnum for SCULPTURE
            /// </summary>
            [EnumMember(Value = "SCULPTURE")]
            SCULPTUREEnum = 4        }
}