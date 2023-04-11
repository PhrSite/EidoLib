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
        /// A data type for the units of measurement for the displacement of a conveyance engine.
        /// </summary>
        /// <value>A data type for the units of measurement for the displacement of a conveyance engine.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JEngineDisplacementUnitCodeSimpleType
        {
            /// <summary>
            /// Enum CcEnum for cc
            /// </summary>
            [EnumMember(Value = "cc")]
            CcEnum = 0,
            /// <summary>
            /// Enum LiterEnum for liter
            /// </summary>
            [EnumMember(Value = "liter")]
            LiterEnum = 1        }
}
