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
        /// A data type for a kind of fingerprint capture technique type.
        /// </summary>
        /// <value>A data type for a kind of fingerprint capture technique type.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomFingerprintCaptureTechniqueCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum FlatEnum for Flat
            /// </summary>
            [EnumMember(Value = "Flat")]
            FlatEnum = 0,
            /// <summary>
            /// Enum RolledEnum for Rolled
            /// </summary>
            [EnumMember(Value = "Rolled")]
            RolledEnum = 1,
            /// <summary>
            /// Enum SlappedEnum for Slapped
            /// </summary>
            [EnumMember(Value = "Slapped")]
            SlappedEnum = 2        }
}
