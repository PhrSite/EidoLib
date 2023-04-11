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
        /// A data type for describing whether a family suffers from financial problems.
        /// </summary>
        /// <value>A data type for describing whether a family suffers from financial problems.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HsJuvenileFamilyFinancialProblemCodeSimpleType
        {
            /// <summary>
            /// Enum NoEnum for No
            /// </summary>
            [EnumMember(Value = "No")]
            NoEnum = 0,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 1,
            /// <summary>
            /// Enum YesEnum for Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            YesEnum = 2        }
}