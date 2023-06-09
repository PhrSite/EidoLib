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
        /// A data type for a kind of image of a person
        /// </summary>
        /// <value>A data type for a kind of image of a person</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomPersonImageCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum BUTTOCKSEnum for BUTTOCKS
            /// </summary>
            [EnumMember(Value = "BUTTOCKS")]
            BUTTOCKSEnum = 0,
            /// <summary>
            /// Enum CHESTEnum for CHEST
            /// </summary>
            [EnumMember(Value = "CHEST")]
            CHESTEnum = 1,
            /// <summary>
            /// Enum CONDITIONEnum for CONDITION
            /// </summary>
            [EnumMember(Value = "CONDITION")]
            CONDITIONEnum = 2,
            /// <summary>
            /// Enum EXTRAORALEnum for EXTRAORAL
            /// </summary>
            [EnumMember(Value = "EXTRAORAL")]
            EXTRAORALEnum = 3,
            /// <summary>
            /// Enum FACEEnum for FACE
            /// </summary>
            [EnumMember(Value = "FACE")]
            FACEEnum = 4,
            /// <summary>
            /// Enum FEETEnum for FEET
            /// </summary>
            [EnumMember(Value = "FEET")]
            FEETEnum = 5,
            /// <summary>
            /// Enum FRONTALCEnum for FRONTAL-C
            /// </summary>
            [EnumMember(Value = "FRONTAL-C")]
            FRONTALCEnum = 6,
            /// <summary>
            /// Enum FRONTALNEnum for FRONTAL-N
            /// </summary>
            [EnumMember(Value = "FRONTAL-N")]
            FRONTALNEnum = 7,
            /// <summary>
            /// Enum GENITALSEnum for GENITALS
            /// </summary>
            [EnumMember(Value = "GENITALS")]
            GENITALSEnum = 8,
            /// <summary>
            /// Enum HANDSBACKEnum for HANDS-BACK
            /// </summary>
            [EnumMember(Value = "HANDS-BACK")]
            HANDSBACKEnum = 9,
            /// <summary>
            /// Enum HANDSPALMEnum for HANDS-PALM
            /// </summary>
            [EnumMember(Value = "HANDS-PALM")]
            HANDSPALMEnum = 10,
            /// <summary>
            /// Enum HEADEnum for HEAD
            /// </summary>
            [EnumMember(Value = "HEAD")]
            HEADEnum = 11,
            /// <summary>
            /// Enum INTRAORALEnum for INTRAORAL
            /// </summary>
            [EnumMember(Value = "INTRAORAL")]
            INTRAORALEnum = 12,
            /// <summary>
            /// Enum LEFTARMEnum for LEFT ARM
            /// </summary>
            [EnumMember(Value = "LEFT ARM")]
            LEFTARMEnum = 13,
            /// <summary>
            /// Enum LEFTLEGEnum for LEFT LEG
            /// </summary>
            [EnumMember(Value = "LEFT LEG")]
            LEFTLEGEnum = 14,
            /// <summary>
            /// Enum LIPEnum for LIP
            /// </summary>
            [EnumMember(Value = "LIP")]
            LIPEnum = 15,
            /// <summary>
            /// Enum MARKEnum for MARK
            /// </summary>
            [EnumMember(Value = "MARK")]
            MARKEnum = 16,
            /// <summary>
            /// Enum MISSINGEnum for MISSING
            /// </summary>
            [EnumMember(Value = "MISSING")]
            MISSINGEnum = 17,
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 18,
            /// <summary>
            /// Enum REARCEnum for REAR-C
            /// </summary>
            [EnumMember(Value = "REAR-C")]
            REARCEnum = 19,
            /// <summary>
            /// Enum REARNEnum for REAR-N
            /// </summary>
            [EnumMember(Value = "REAR-N")]
            REARNEnum = 20,
            /// <summary>
            /// Enum RIGHTARMEnum for RIGHT ARM
            /// </summary>
            [EnumMember(Value = "RIGHT ARM")]
            RIGHTARMEnum = 21,
            /// <summary>
            /// Enum RIGHTLEGEnum for RIGHT LEG
            /// </summary>
            [EnumMember(Value = "RIGHT LEG")]
            RIGHTLEGEnum = 22,
            /// <summary>
            /// Enum SCAREnum for SCAR
            /// </summary>
            [EnumMember(Value = "SCAR")]
            SCAREnum = 23,
            /// <summary>
            /// Enum TATTOOEnum for TATTOO
            /// </summary>
            [EnumMember(Value = "TATTOO")]
            TATTOOEnum = 24,
            /// <summary>
            /// Enum TORSOBACKEnum for TORSO-BACK
            /// </summary>
            [EnumMember(Value = "TORSO-BACK")]
            TORSOBACKEnum = 25,
            /// <summary>
            /// Enum TORSOFRONTEnum for TORSO-FRONT
            /// </summary>
            [EnumMember(Value = "TORSO-FRONT")]
            TORSOFRONTEnum = 26        }
}
