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
        /// A data type for a code that indicates the release status of the subject involved in supervised release.
        /// </summary>
        /// <value>A data type for a code that indicates the release status of the subject involved in supervised release.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexSupervisedReleaseStatusCodeSimpleType
        {
            /// <summary>
            /// Enum ABSCONDEREnum for ABSCONDER
            /// </summary>
            [EnumMember(Value = "ABSCONDER")]
            ABSCONDEREnum = 0,
            /// <summary>
            /// Enum ACTIVEEnum for ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVEEnum = 1,
            /// <summary>
            /// Enum CANCELEDEnum for CANCELED
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELEDEnum = 2,
            /// <summary>
            /// Enum CANCELEDDECEASEDEnum for CANCELED DECEASED
            /// </summary>
            [EnumMember(Value = "CANCELED DECEASED")]
            CANCELEDDECEASEDEnum = 3,
            /// <summary>
            /// Enum CANCELEDREVOKEDEnum for CANCELED REVOKED
            /// </summary>
            [EnumMember(Value = "CANCELED REVOKED")]
            CANCELEDREVOKEDEnum = 4,
            /// <summary>
            /// Enum CANCELEDTRANSFERREDEnum for CANCELED TRANSFERRED
            /// </summary>
            [EnumMember(Value = "CANCELED TRANSFERRED")]
            CANCELEDTRANSFERREDEnum = 5,
            /// <summary>
            /// Enum CANCELEDUNSUCCESSFULEnum for CANCELED UNSUCCESSFUL
            /// </summary>
            [EnumMember(Value = "CANCELED UNSUCCESSFUL")]
            CANCELEDUNSUCCESSFULEnum = 6,
            /// <summary>
            /// Enum COMPLETEDEnum for COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETEDEnum = 7,
            /// <summary>
            /// Enum COMPLETEDEARLYEnum for COMPLETED EARLY
            /// </summary>
            [EnumMember(Value = "COMPLETED EARLY")]
            COMPLETEDEARLYEnum = 8        }
}
