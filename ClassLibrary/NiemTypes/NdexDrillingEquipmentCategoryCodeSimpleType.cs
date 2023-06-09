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
        /// A data type for a code that identifies the type of drilling tool.
        /// </summary>
        /// <value>A data type for a code that identifies the type of drilling tool.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexDrillingEquipmentCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum BAILEREnum for BAILER
            /// </summary>
            [EnumMember(Value = "BAILER")]
            BAILEREnum = 0,
            /// <summary>
            /// Enum BITDRILLINGEnum for BIT_DRILLING
            /// </summary>
            [EnumMember(Value = "BIT_DRILLING")]
            BITDRILLINGEnum = 1,
            /// <summary>
            /// Enum BLOWOUTPREVENTEREnum for BLOWOUT PREVENTER
            /// </summary>
            [EnumMember(Value = "BLOWOUT PREVENTER")]
            BLOWOUTPREVENTEREnum = 2,
            /// <summary>
            /// Enum CASINGCUTTEREnum for CASING CUTTER
            /// </summary>
            [EnumMember(Value = "CASING CUTTER")]
            CASINGCUTTEREnum = 3,
            /// <summary>
            /// Enum CASINGROLLEREnum for CASING ROLLER
            /// </summary>
            [EnumMember(Value = "CASING ROLLER")]
            CASINGROLLEREnum = 4,
            /// <summary>
            /// Enum CATHEADEnum for CATHEAD
            /// </summary>
            [EnumMember(Value = "CATHEAD")]
            CATHEADEnum = 5,
            /// <summary>
            /// Enum CATHEADBREAKOUTEnum for CATHEAD_BREAKOUT
            /// </summary>
            [EnumMember(Value = "CATHEAD_BREAKOUT")]
            CATHEADBREAKOUTEnum = 6,
            /// <summary>
            /// Enum CATHEADMAKEUPEnum for CATHEAD_MAKEUP
            /// </summary>
            [EnumMember(Value = "CATHEAD_MAKEUP")]
            CATHEADMAKEUPEnum = 7,
            /// <summary>
            /// Enum CATWORKEnum for CATWORK
            /// </summary>
            [EnumMember(Value = "CATWORK")]
            CATWORKEnum = 8,
            /// <summary>
            /// Enum COLLAREnum for COLLAR
            /// </summary>
            [EnumMember(Value = "COLLAR")]
            COLLAREnum = 9,
            /// <summary>
            /// Enum COLLARDIEEnum for COLLAR_DIE
            /// </summary>
            [EnumMember(Value = "COLLAR_DIE")]
            COLLARDIEEnum = 10,
            /// <summary>
            /// Enum COLLARDRILLEnum for COLLAR_DRILL
            /// </summary>
            [EnumMember(Value = "COLLAR_DRILL")]
            COLLARDRILLEnum = 11,
            /// <summary>
            /// Enum DRAWWORKSEnum for DRAWWORKS
            /// </summary>
            [EnumMember(Value = "DRAWWORKS")]
            DRAWWORKSEnum = 12,
            /// <summary>
            /// Enum DRILLEnum for DRILL
            /// </summary>
            [EnumMember(Value = "DRILL")]
            DRILLEnum = 13,
            /// <summary>
            /// Enum DRILLBLASTHOLEEnum for DRILL_BLASTHOLE
            /// </summary>
            [EnumMember(Value = "DRILL_BLASTHOLE")]
            DRILLBLASTHOLEEnum = 14,
            /// <summary>
            /// Enum DRILLROCKEnum for DRILL_ROCK
            /// </summary>
            [EnumMember(Value = "DRILL_ROCK")]
            DRILLROCKEnum = 15,
            /// <summary>
            /// Enum DRILLINGUNITROTARYTABLEEnum for DRILLING UNIT_ROTARY TABLE
            /// </summary>
            [EnumMember(Value = "DRILLING UNIT_ROTARY TABLE")]
            DRILLINGUNITROTARYTABLEEnum = 16,
            /// <summary>
            /// Enum HYDRAHOOKEnum for HYDRA HOOK
            /// </summary>
            [EnumMember(Value = "HYDRA HOOK")]
            HYDRAHOOKEnum = 17,
            /// <summary>
            /// Enum KELLYSPINNEREnum for KELLY SPINNER
            /// </summary>
            [EnumMember(Value = "KELLY SPINNER")]
            KELLYSPINNEREnum = 18,
            /// <summary>
            /// Enum KEYSEATWIPEREnum for KEYSEAT WIPER
            /// </summary>
            [EnumMember(Value = "KEYSEAT WIPER")]
            KEYSEATWIPEREnum = 19,
            /// <summary>
            /// Enum MILLEnum for MILL
            /// </summary>
            [EnumMember(Value = "MILL")]
            MILLEnum = 20,
            /// <summary>
            /// Enum MUDPITTANKEnum for MUD PIT TANK
            /// </summary>
            [EnumMember(Value = "MUD PIT TANK")]
            MUDPITTANKEnum = 21,
            /// <summary>
            /// Enum PACKEREnum for PACKER
            /// </summary>
            [EnumMember(Value = "PACKER")]
            PACKEREnum = 22,
            /// <summary>
            /// Enum PIPELINEPIGEnum for PIPELINE_PIG
            /// </summary>
            [EnumMember(Value = "PIPELINE_PIG")]
            PIPELINEPIGEnum = 23,
            /// <summary>
            /// Enum PUMPINGUNITEnum for PUMPING UNIT
            /// </summary>
            [EnumMember(Value = "PUMPING UNIT")]
            PUMPINGUNITEnum = 24,
            /// <summary>
            /// Enum RATHOLEGUIDEEnum for RATHOLE GUIDE
            /// </summary>
            [EnumMember(Value = "RATHOLE GUIDE")]
            RATHOLEGUIDEEnum = 25,
            /// <summary>
            /// Enum REAMEREnum for REAMER
            /// </summary>
            [EnumMember(Value = "REAMER")]
            REAMEREnum = 26,
            /// <summary>
            /// Enum REAMERENLARGERSEnum for REAMER_ENLARGERS
            /// </summary>
            [EnumMember(Value = "REAMER_ENLARGERS")]
            REAMERENLARGERSEnum = 27,
            /// <summary>
            /// Enum REAMEROPENERSEnum for REAMER_OPENERS
            /// </summary>
            [EnumMember(Value = "REAMER_OPENERS")]
            REAMEROPENERSEnum = 28,
            /// <summary>
            /// Enum SHAKERSHALEEnum for SHAKER_ SHALE
            /// </summary>
            [EnumMember(Value = "SHAKER_ SHALE")]
            SHAKERSHALEEnum = 29,
            /// <summary>
            /// Enum SHOCKEnum for SHOCK
            /// </summary>
            [EnumMember(Value = "SHOCK")]
            SHOCKEnum = 30,
            /// <summary>
            /// Enum SPIDEREnum for SPIDER
            /// </summary>
            [EnumMember(Value = "SPIDER")]
            SPIDEREnum = 31,
            /// <summary>
            /// Enum SPIDERELEVATOREnum for SPIDER_ELEVATOR
            /// </summary>
            [EnumMember(Value = "SPIDER_ELEVATOR")]
            SPIDERELEVATOREnum = 32,
            /// <summary>
            /// Enum SPIDERTUBINGEnum for SPIDER_TUBING
            /// </summary>
            [EnumMember(Value = "SPIDER_TUBING")]
            SPIDERTUBINGEnum = 33,
            /// <summary>
            /// Enum STABILIZEREnum for STABILIZER
            /// </summary>
            [EnumMember(Value = "STABILIZER")]
            STABILIZEREnum = 34,
            /// <summary>
            /// Enum SUBEnum for SUB
            /// </summary>
            [EnumMember(Value = "SUB")]
            SUBEnum = 35,
            /// <summary>
            /// Enum SUBBASKETEnum for SUB_BASKET
            /// </summary>
            [EnumMember(Value = "SUB_BASKET")]
            SUBBASKETEnum = 36,
            /// <summary>
            /// Enum SUBKICKEnum for SUB_KICK
            /// </summary>
            [EnumMember(Value = "SUB_KICK")]
            SUBKICKEnum = 37,
            /// <summary>
            /// Enum SUBPINEnum for SUB_PIN
            /// </summary>
            [EnumMember(Value = "SUB_PIN")]
            SUBPINEnum = 38,
            /// <summary>
            /// Enum SUBRODEnum for SUB_ROD
            /// </summary>
            [EnumMember(Value = "SUB_ROD")]
            SUBRODEnum = 39,
            /// <summary>
            /// Enum SUBSHEAREnum for SUB_SHEAR
            /// </summary>
            [EnumMember(Value = "SUB_SHEAR")]
            SUBSHEAREnum = 40,
            /// <summary>
            /// Enum SWIVELEnum for SWIVEL
            /// </summary>
            [EnumMember(Value = "SWIVEL")]
            SWIVELEnum = 41,
            /// <summary>
            /// Enum SWIVELPOWEREnum for SWIVEL_POWER
            /// </summary>
            [EnumMember(Value = "SWIVEL_POWER")]
            SWIVELPOWEREnum = 42,
            /// <summary>
            /// Enum TONGEnum for TONG
            /// </summary>
            [EnumMember(Value = "TONG")]
            TONGEnum = 43,
            /// <summary>
            /// Enum TONGPOWEREnum for TONG_POWER
            /// </summary>
            [EnumMember(Value = "TONG_POWER")]
            TONGPOWEREnum = 44,
            /// <summary>
            /// Enum TOOLJOINTEnum for TOOL JOINT
            /// </summary>
            [EnumMember(Value = "TOOL JOINT")]
            TOOLJOINTEnum = 45,
            /// <summary>
            /// Enum TRAVELINGBLOCKCROWNEnum for TRAVELING BLOCK_CROWN
            /// </summary>
            [EnumMember(Value = "TRAVELING BLOCK_CROWN")]
            TRAVELINGBLOCKCROWNEnum = 46,
            /// <summary>
            /// Enum VALVECONTROLSEnum for VALVE CONTROLS
            /// </summary>
            [EnumMember(Value = "VALVE CONTROLS")]
            VALVECONTROLSEnum = 47,
            /// <summary>
            /// Enum VALVEDRILLINGEnum for VALVE_DRILLING
            /// </summary>
            [EnumMember(Value = "VALVE_DRILLING")]
            VALVEDRILLINGEnum = 48,
            /// <summary>
            /// Enum WASHOVERSHOEEnum for WASHOVER SHOE
            /// </summary>
            [EnumMember(Value = "WASHOVER SHOE")]
            WASHOVERSHOEEnum = 49,
            /// <summary>
            /// Enum WRENCHSPINNINGEnum for WRENCH_ SPINNING
            /// </summary>
            [EnumMember(Value = "WRENCH_ SPINNING")]
            WRENCHSPINNINGEnum = 50        }
}
