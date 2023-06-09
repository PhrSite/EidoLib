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
        /// A data type for a code that identifies a type of charge.
        /// </summary>
        /// <value>A data type for a code that identifies a type of charge.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexChargeCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum COMPLAINTEnum for COMPLAINT
            /// </summary>
            [EnumMember(Value = "COMPLAINT")]
            COMPLAINTEnum = 0,
            /// <summary>
            /// Enum INDICTMENTEnum for INDICTMENT
            /// </summary>
            [EnumMember(Value = "INDICTMENT")]
            INDICTMENTEnum = 1,
            /// <summary>
            /// Enum INFORMATIONEnum for INFORMATION
            /// </summary>
            [EnumMember(Value = "INFORMATION")]
            INFORMATIONEnum = 2        }
}
