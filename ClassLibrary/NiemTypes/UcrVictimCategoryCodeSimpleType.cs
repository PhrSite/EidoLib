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
        /// A data type for kinds of victims in an incident.
        /// </summary>
        /// <value>A data type for kinds of victims in an incident.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UcrVictimCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 0,
            /// <summary>
            /// Enum FEnum for F
            /// </summary>
            [EnumMember(Value = "F")]
            FEnum = 1,
            /// <summary>
            /// Enum GEnum for G
            /// </summary>
            [EnumMember(Value = "G")]
            GEnum = 2,
            /// <summary>
            /// Enum IEnum for I
            /// </summary>
            [EnumMember(Value = "I")]
            IEnum = 3,
            /// <summary>
            /// Enum LEnum for L
            /// </summary>
            [EnumMember(Value = "L")]
            LEnum = 4,
            /// <summary>
            /// Enum OEnum for O
            /// </summary>
            [EnumMember(Value = "O")]
            OEnum = 5,
            /// <summary>
            /// Enum REnum for R
            /// </summary>
            [EnumMember(Value = "R")]
            REnum = 6,
            /// <summary>
            /// Enum SEnum for S
            /// </summary>
            [EnumMember(Value = "S")]
            SEnum = 7,
            /// <summary>
            /// Enum UEnum for U
            /// </summary>
            [EnumMember(Value = "U")]
            UEnum = 8        }
}