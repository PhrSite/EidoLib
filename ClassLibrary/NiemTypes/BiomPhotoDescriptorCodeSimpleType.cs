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
        /// A data type for an attribute of a captured facial image
        /// </summary>
        /// <value>A data type for an attribute of a captured facial image</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomPhotoDescriptorCodeSimpleType
        {
            /// <summary>
            /// Enum GLASSESEnum for GLASSES
            /// </summary>
            [EnumMember(Value = "GLASSES")]
            GLASSESEnum = 0,
            /// <summary>
            /// Enum HATEnum for HAT
            /// </summary>
            [EnumMember(Value = "HAT")]
            HATEnum = 1,
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 2,
            /// <summary>
            /// Enum PHYSICALEnum for PHYSICAL
            /// </summary>
            [EnumMember(Value = "PHYSICAL")]
            PHYSICALEnum = 3,
            /// <summary>
            /// Enum SCARFEnum for SCARF
            /// </summary>
            [EnumMember(Value = "SCARF")]
            SCARFEnum = 4        }
}
