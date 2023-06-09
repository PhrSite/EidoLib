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
        /// A data type for a kind of financial account holder.
        /// </summary>
        /// <value>A data type for a kind of financial account holder.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcFinancialAccountHolderCodeSimpleType
        {
            /// <summary>
            /// Enum FATCA101Enum for FATCA101
            /// </summary>
            [EnumMember(Value = "FATCA101")]
            FATCA101Enum = 0,
            /// <summary>
            /// Enum FATCA102Enum for FATCA102
            /// </summary>
            [EnumMember(Value = "FATCA102")]
            FATCA102Enum = 1,
            /// <summary>
            /// Enum FATCA103Enum for FATCA103
            /// </summary>
            [EnumMember(Value = "FATCA103")]
            FATCA103Enum = 2        }
}
