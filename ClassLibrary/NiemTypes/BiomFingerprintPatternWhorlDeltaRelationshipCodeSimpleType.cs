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
        /// A data type for a relationship between a whorl and a delta in a fingerprint pattern
        /// </summary>
        /// <value>A data type for a relationship between a whorl and a delta in a fingerprint pattern</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomFingerprintPatternWhorlDeltaRelationshipCodeSimpleType
        {
            /// <summary>
            /// Enum IEnum for I
            /// </summary>
            [EnumMember(Value = "I")]
            IEnum = 0,
            /// <summary>
            /// Enum MEnum for M
            /// </summary>
            [EnumMember(Value = "M")]
            MEnum = 1,
            /// <summary>
            /// Enum OEnum for O
            /// </summary>
            [EnumMember(Value = "O")]
            OEnum = 2        }
}
