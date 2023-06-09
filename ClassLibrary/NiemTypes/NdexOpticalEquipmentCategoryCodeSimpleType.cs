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
        /// A data type for a code that identifies a type of optical equipment.
        /// </summary>
        /// <value>A data type for a code that identifies a type of optical equipment.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexOpticalEquipmentCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum BINOCULARSEnum for BINOCULARS
            /// </summary>
            [EnumMember(Value = "BINOCULARS")]
            BINOCULARSEnum = 0,
            /// <summary>
            /// Enum BINOCULARSFIELDGLASSESEnum for BINOCULARS_FIELD GLASSES
            /// </summary>
            [EnumMember(Value = "BINOCULARS_FIELD GLASSES")]
            BINOCULARSFIELDGLASSESEnum = 1,
            /// <summary>
            /// Enum BINOCULARSSPYGLASSEnum for BINOCULARS_SPYGLASS
            /// </summary>
            [EnumMember(Value = "BINOCULARS_SPYGLASS")]
            BINOCULARSSPYGLASSEnum = 2,
            /// <summary>
            /// Enum EYEGLASSESEnum for EYEGLASSES
            /// </summary>
            [EnumMember(Value = "EYEGLASSES")]
            EYEGLASSESEnum = 3,
            /// <summary>
            /// Enum EYEGLASSESFRAMESEnum for EYEGLASSES_FRAMES
            /// </summary>
            [EnumMember(Value = "EYEGLASSES_FRAMES")]
            EYEGLASSESFRAMESEnum = 4,
            /// <summary>
            /// Enum MICROSCOPEEnum for MICROSCOPE
            /// </summary>
            [EnumMember(Value = "MICROSCOPE")]
            MICROSCOPEEnum = 5,
            /// <summary>
            /// Enum NIGHTVISIONGOGGLESEnum for NIGHT VISION GOGGLES
            /// </summary>
            [EnumMember(Value = "NIGHT VISION GOGGLES")]
            NIGHTVISIONGOGGLESEnum = 6,
            /// <summary>
            /// Enum PERISCOPEEnum for PERISCOPE
            /// </summary>
            [EnumMember(Value = "PERISCOPE")]
            PERISCOPEEnum = 7,
            /// <summary>
            /// Enum SCOPEEnum for SCOPE
            /// </summary>
            [EnumMember(Value = "SCOPE")]
            SCOPEEnum = 8,
            /// <summary>
            /// Enum SCOPETELESCOPEEnum for SCOPE_ TELESCOPE
            /// </summary>
            [EnumMember(Value = "SCOPE_ TELESCOPE")]
            SCOPETELESCOPEEnum = 9,
            /// <summary>
            /// Enum SCOPEGUNEnum for SCOPE_GUN
            /// </summary>
            [EnumMember(Value = "SCOPE_GUN")]
            SCOPEGUNEnum = 10,
            /// <summary>
            /// Enum TELESCOPEEnum for TELESCOPE
            /// </summary>
            [EnumMember(Value = "TELESCOPE")]
            TELESCOPEEnum = 11,
            /// <summary>
            /// Enum VIEWEREnum for VIEWER
            /// </summary>
            [EnumMember(Value = "VIEWER")]
            VIEWEREnum = 12        }
}
