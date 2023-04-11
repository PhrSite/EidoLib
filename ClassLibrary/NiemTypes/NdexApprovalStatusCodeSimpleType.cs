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
        /// A data type for a code that identifies the status of the request for addition to the approved visitor list.
        /// </summary>
        /// <value>A data type for a code that identifies the status of the request for addition to the approved visitor list.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexApprovalStatusCodeSimpleType
        {
            /// <summary>
            /// Enum APPROVEDEnum for APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVEDEnum = 0,
            /// <summary>
            /// Enum DENIEDEnum for DENIED
            /// </summary>
            [EnumMember(Value = "DENIED")]
            DENIEDEnum = 1,
            /// <summary>
            /// Enum PENDINGEnum for PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDINGEnum = 2,
            /// <summary>
            /// Enum REVOKEDEnum for REVOKED
            /// </summary>
            [EnumMember(Value = "REVOKED")]
            REVOKEDEnum = 3        }
}
