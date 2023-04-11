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
        /// A data type for 5 - Vehicle Color (VCO) Field Codes
        /// </summary>
        /// <value>A data type for 5 - Vehicle Color (VCO) Field Codes</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcicVCOCodeSimpleType
        {
            /// <summary>
            /// Enum _0NGEnum for 0NG
            /// </summary>
            [EnumMember(Value = "0NG")]
            _0NGEnum = 0,
            /// <summary>
            /// Enum AMEEnum for AME
            /// </summary>
            [EnumMember(Value = "AME")]
            AMEEnum = 1,
            /// <summary>
            /// Enum BGEEnum for BGE
            /// </summary>
            [EnumMember(Value = "BGE")]
            BGEEnum = 2,
            /// <summary>
            /// Enum BLKEnum for BLK
            /// </summary>
            [EnumMember(Value = "BLK")]
            BLKEnum = 3,
            /// <summary>
            /// Enum BLUEnum for BLU
            /// </summary>
            [EnumMember(Value = "BLU")]
            BLUEnum = 4,
            /// <summary>
            /// Enum BR0Enum for BR0
            /// </summary>
            [EnumMember(Value = "BR0")]
            BR0Enum = 5,
            /// <summary>
            /// Enum BRZEnum for BRZ
            /// </summary>
            [EnumMember(Value = "BRZ")]
            BRZEnum = 6,
            /// <summary>
            /// Enum C0MEnum for C0M
            /// </summary>
            [EnumMember(Value = "C0M")]
            C0MEnum = 7,
            /// <summary>
            /// Enum CAMEnum for CAM
            /// </summary>
            [EnumMember(Value = "CAM")]
            CAMEnum = 8,
            /// <summary>
            /// Enum CPREnum for CPR
            /// </summary>
            [EnumMember(Value = "CPR")]
            CPREnum = 9,
            /// <summary>
            /// Enum CRMEnum for CRM
            /// </summary>
            [EnumMember(Value = "CRM")]
            CRMEnum = 10,
            /// <summary>
            /// Enum DBLEnum for DBL
            /// </summary>
            [EnumMember(Value = "DBL")]
            DBLEnum = 11,
            /// <summary>
            /// Enum DGREnum for DGR
            /// </summary>
            [EnumMember(Value = "DGR")]
            DGREnum = 12,
            /// <summary>
            /// Enum GLDEnum for GLD
            /// </summary>
            [EnumMember(Value = "GLD")]
            GLDEnum = 13,
            /// <summary>
            /// Enum GRNEnum for GRN
            /// </summary>
            [EnumMember(Value = "GRN")]
            GRNEnum = 14,
            /// <summary>
            /// Enum GRYEnum for GRY
            /// </summary>
            [EnumMember(Value = "GRY")]
            GRYEnum = 15,
            /// <summary>
            /// Enum LAVEnum for LAV
            /// </summary>
            [EnumMember(Value = "LAV")]
            LAVEnum = 16,
            /// <summary>
            /// Enum LBLEnum for LBL
            /// </summary>
            [EnumMember(Value = "LBL")]
            LBLEnum = 17,
            /// <summary>
            /// Enum LGREnum for LGR
            /// </summary>
            [EnumMember(Value = "LGR")]
            LGREnum = 18,
            /// <summary>
            /// Enum MAREnum for MAR
            /// </summary>
            [EnumMember(Value = "MAR")]
            MAREnum = 19,
            /// <summary>
            /// Enum MULC0LEnum for MUL/C0L
            /// </summary>
            [EnumMember(Value = "MUL/C0L")]
            MULC0LEnum = 20,
            /// <summary>
            /// Enum MVEEnum for MVE
            /// </summary>
            [EnumMember(Value = "MVE")]
            MVEEnum = 21,
            /// <summary>
            /// Enum PLEEnum for PLE
            /// </summary>
            [EnumMember(Value = "PLE")]
            PLEEnum = 22,
            /// <summary>
            /// Enum PNKEnum for PNK
            /// </summary>
            [EnumMember(Value = "PNK")]
            PNKEnum = 23,
            /// <summary>
            /// Enum REDEnum for RED
            /// </summary>
            [EnumMember(Value = "RED")]
            REDEnum = 24,
            /// <summary>
            /// Enum SILEnum for SIL
            /// </summary>
            [EnumMember(Value = "SIL")]
            SILEnum = 25,
            /// <summary>
            /// Enum TANEnum for TAN
            /// </summary>
            [EnumMember(Value = "TAN")]
            TANEnum = 26,
            /// <summary>
            /// Enum TEAEnum for TEA
            /// </summary>
            [EnumMember(Value = "TEA")]
            TEAEnum = 27,
            /// <summary>
            /// Enum TPEEnum for TPE
            /// </summary>
            [EnumMember(Value = "TPE")]
            TPEEnum = 28,
            /// <summary>
            /// Enum TRQEnum for TRQ
            /// </summary>
            [EnumMember(Value = "TRQ")]
            TRQEnum = 29,
            /// <summary>
            /// Enum WHIEnum for WHI
            /// </summary>
            [EnumMember(Value = "WHI")]
            WHIEnum = 30,
            /// <summary>
            /// Enum YELEnum for YEL
            /// </summary>
            [EnumMember(Value = "YEL")]
            YELEnum = 31        }
}