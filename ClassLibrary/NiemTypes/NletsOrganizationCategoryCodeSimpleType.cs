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
        /// A data type for the functional kinds of an organization.
        /// </summary>
        /// <value>A data type for the functional kinds of an organization.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NletsOrganizationCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum CJEnum for CJ
            /// </summary>
            [EnumMember(Value = "CJ")]
            CJEnum = 0,
            /// <summary>
            /// Enum FEEnum for FE
            /// </summary>
            [EnumMember(Value = "FE")]
            FEEnum = 1,
            /// <summary>
            /// Enum JAEnum for JA
            /// </summary>
            [EnumMember(Value = "JA")]
            JAEnum = 2,
            /// <summary>
            /// Enum JCEnum for JC
            /// </summary>
            [EnumMember(Value = "JC")]
            JCEnum = 3,
            /// <summary>
            /// Enum JFEnum for JF
            /// </summary>
            [EnumMember(Value = "JF")]
            JFEnum = 4,
            /// <summary>
            /// Enum JGEnum for JG
            /// </summary>
            [EnumMember(Value = "JG")]
            JGEnum = 5,
            /// <summary>
            /// Enum JJEnum for JJ
            /// </summary>
            [EnumMember(Value = "JJ")]
            JJEnum = 6,
            /// <summary>
            /// Enum LEEnum for LE
            /// </summary>
            [EnumMember(Value = "LE")]
            LEEnum = 7,
            /// <summary>
            /// Enum NJEnum for NJ
            /// </summary>
            [EnumMember(Value = "NJ")]
            NJEnum = 8,
            /// <summary>
            /// Enum PDEnum for PD
            /// </summary>
            [EnumMember(Value = "PD")]
            PDEnum = 9,
            /// <summary>
            /// Enum SAEnum for SA
            /// </summary>
            [EnumMember(Value = "SA")]
            SAEnum = 10,
            /// <summary>
            /// Enum SOEnum for SO
            /// </summary>
            [EnumMember(Value = "SO")]
            SOEnum = 11        }
}