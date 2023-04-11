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
        /// A data type for angles of an entitys pose in a photograph.
        /// </summary>
        /// <value>A data type for angles of an entitys pose in a photograph.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcImagePoseCodeSimpleType
        {
            /// <summary>
            /// Enum FrontalEnum for Frontal
            /// </summary>
            [EnumMember(Value = "Frontal")]
            FrontalEnum = 0,
            /// <summary>
            /// Enum ObliqueEnum for Oblique
            /// </summary>
            [EnumMember(Value = "Oblique")]
            ObliqueEnum = 1,
            /// <summary>
            /// Enum SideEnum for Side
            /// </summary>
            [EnumMember(Value = "Side")]
            SideEnum = 2        }
}
