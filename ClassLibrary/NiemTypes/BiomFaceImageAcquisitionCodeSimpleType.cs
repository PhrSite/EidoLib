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
        /// A data type code for the source of a facial photo
        /// </summary>
        /// <value>A data type code for the source of a facial photo</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomFaceImageAcquisitionCodeSimpleType
        {
            /// <summary>
            /// Enum ANALOGVIDEOEnum for ANALOG VIDEO
            /// </summary>
            [EnumMember(Value = "ANALOG VIDEO")]
            ANALOGVIDEOEnum = 0,
            /// <summary>
            /// Enum DIGITALCAMERAEnum for DIGITAL CAMERA
            /// </summary>
            [EnumMember(Value = "DIGITAL CAMERA")]
            DIGITALCAMERAEnum = 1,
            /// <summary>
            /// Enum DIGITALVIDEOEnum for DIGITAL VIDEO
            /// </summary>
            [EnumMember(Value = "DIGITAL VIDEO")]
            DIGITALVIDEOEnum = 2,
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 3,
            /// <summary>
            /// Enum SCANNEREnum for SCANNER
            /// </summary>
            [EnumMember(Value = "SCANNER")]
            SCANNEREnum = 4,
            /// <summary>
            /// Enum TYPE20Enum for TYPE20
            /// </summary>
            [EnumMember(Value = "TYPE20")]
            TYPE20Enum = 5,
            /// <summary>
            /// Enum UNKNOWNPHOTOEnum for UNKNOWN PHOTO
            /// </summary>
            [EnumMember(Value = "UNKNOWN PHOTO")]
            UNKNOWNPHOTOEnum = 6,
            /// <summary>
            /// Enum UNKNOWNVIDEOEnum for UNKNOWN VIDEO
            /// </summary>
            [EnumMember(Value = "UNKNOWN VIDEO")]
            UNKNOWNVIDEOEnum = 7,
            /// <summary>
            /// Enum UNSPECIFIEDEnum for UNSPECIFIED
            /// </summary>
            [EnumMember(Value = "UNSPECIFIED")]
            UNSPECIFIEDEnum = 8,
            /// <summary>
            /// Enum VENDOREnum for VENDOR
            /// </summary>
            [EnumMember(Value = "VENDOR")]
            VENDOREnum = 9        }
}
