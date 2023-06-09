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
        /// A data type for a code that identifies the hand the person is more adept with using.
        /// </summary>
        /// <value>A data type for a code that identifies the hand the person is more adept with using.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexPersonHandedCodeSimpleType
        {
            /// <summary>
            /// Enum AMBIDEXTROUSEnum for AMBIDEXTROUS
            /// </summary>
            [EnumMember(Value = "AMBIDEXTROUS")]
            AMBIDEXTROUSEnum = 0,
            /// <summary>
            /// Enum LEFTEnum for LEFT
            /// </summary>
            [EnumMember(Value = "LEFT")]
            LEFTEnum = 1,
            /// <summary>
            /// Enum RIGHTEnum for RIGHT
            /// </summary>
            [EnumMember(Value = "RIGHT")]
            RIGHTEnum = 2,
            /// <summary>
            /// Enum UNKNOWNEnum for UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWNEnum = 3        }
}
