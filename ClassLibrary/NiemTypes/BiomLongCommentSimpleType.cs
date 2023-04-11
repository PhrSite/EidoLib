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
        /// A data type for a comment of maximum 4000 characters.
        /// </summary>
        /// <value>A data type for a comment of maximum 4000 characters.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomLongCommentSimpleType
        {
            /// <summary>
            /// Enum NUMBER_4000 for 4000
            /// </summary>
            [EnumMember(Value = "4000")]
            NUMBER_4000 = 0        }
}