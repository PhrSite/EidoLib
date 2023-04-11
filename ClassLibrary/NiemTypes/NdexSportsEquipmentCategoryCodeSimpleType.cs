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
        /// A data type for a code that identifies a type of sports/recreational equipment.
        /// </summary>
        /// <value>A data type for a code that identifies a type of sports/recreational equipment.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexSportsEquipmentCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum AQUALUNGEnum for AQUALUNG
            /// </summary>
            [EnumMember(Value = "AQUALUNG")]
            AQUALUNGEnum = 0,
            /// <summary>
            /// Enum BALLEnum for BALL
            /// </summary>
            [EnumMember(Value = "BALL")]
            BALLEnum = 1,
            /// <summary>
            /// Enum BBGUNEnum for BB GUN
            /// </summary>
            [EnumMember(Value = "BB GUN")]
            BBGUNEnum = 2,
            /// <summary>
            /// Enum BENCHEXERCISEEnum for BENCH_EXERCISE
            /// </summary>
            [EnumMember(Value = "BENCH_EXERCISE")]
            BENCHEXERCISEEnum = 3,
            /// <summary>
            /// Enum BICYCLERACKEnum for BICYCLE RACK
            /// </summary>
            [EnumMember(Value = "BICYCLE RACK")]
            BICYCLERACKEnum = 4,
            /// <summary>
            /// Enum BICYCLESKIRACKEnum for BICYCLE_SKI RACK
            /// </summary>
            [EnumMember(Value = "BICYCLE_SKI RACK")]
            BICYCLESKIRACKEnum = 5,
            /// <summary>
            /// Enum BOWEnum for BOW
            /// </summary>
            [EnumMember(Value = "BOW")]
            BOWEnum = 6,
            /// <summary>
            /// Enum CROSSCOUNTRYSKIMACHINEEXERCISEEnum for CROSS COUNTRY SKI_MACHINE_EXERCISE
            /// </summary>
            [EnumMember(Value = "CROSS COUNTRY SKI_MACHINE_EXERCISE")]
            CROSSCOUNTRYSKIMACHINEEXERCISEEnum = 7,
            /// <summary>
            /// Enum CYCLEEXERCISEEnum for CYCLE_EXERCISE
            /// </summary>
            [EnumMember(Value = "CYCLE_EXERCISE")]
            CYCLEEXERCISEEnum = 8,
            /// <summary>
            /// Enum FISHINGRODPOLEEnum for FISHING ROD_POLE
            /// </summary>
            [EnumMember(Value = "FISHING ROD_POLE")]
            FISHINGRODPOLEEnum = 9,
            /// <summary>
            /// Enum GOLFCARTNONMOTORIZEDEnum for GOLF CART_NONMOTORIZED
            /// </summary>
            [EnumMember(Value = "GOLF CART_NONMOTORIZED")]
            GOLFCARTNONMOTORIZEDEnum = 10,
            /// <summary>
            /// Enum GOLFCLUBSEnum for GOLF CLUBS
            /// </summary>
            [EnumMember(Value = "GOLF CLUBS")]
            GOLFCLUBSEnum = 11,
            /// <summary>
            /// Enum GUNBBEnum for GUN_BB
            /// </summary>
            [EnumMember(Value = "GUN_BB")]
            GUNBBEnum = 12,
            /// <summary>
            /// Enum HOMEGYMEnum for HOME_GYM
            /// </summary>
            [EnumMember(Value = "HOME_GYM")]
            HOMEGYMEnum = 13,
            /// <summary>
            /// Enum INCLINEBENCHEXERCISEEnum for INCLINE BENCH_EXERCISE
            /// </summary>
            [EnumMember(Value = "INCLINE BENCH_EXERCISE")]
            INCLINEBENCHEXERCISEEnum = 14,
            /// <summary>
            /// Enum LANTERNEnum for LANTERN
            /// </summary>
            [EnumMember(Value = "LANTERN")]
            LANTERNEnum = 15,
            /// <summary>
            /// Enum LASERTAGGUNEnum for LASER TAG GUN
            /// </summary>
            [EnumMember(Value = "LASER TAG GUN")]
            LASERTAGGUNEnum = 16,
            /// <summary>
            /// Enum LEGDEVELOPINGMACHINEEXERCISEEnum for LEG DEVELOPING MACHINE_EXERCISE
            /// </summary>
            [EnumMember(Value = "LEG DEVELOPING MACHINE_EXERCISE")]
            LEGDEVELOPINGMACHINEEXERCISEEnum = 17,
            /// <summary>
            /// Enum PAINTBALLGUNEnum for PAINT BALL GUN
            /// </summary>
            [EnumMember(Value = "PAINT BALL GUN")]
            PAINTBALLGUNEnum = 18,
            /// <summary>
            /// Enum PARACHUTEEnum for PARACHUTE
            /// </summary>
            [EnumMember(Value = "PARACHUTE")]
            PARACHUTEEnum = 19,
            /// <summary>
            /// Enum RACKETEnum for RACKET
            /// </summary>
            [EnumMember(Value = "RACKET")]
            RACKETEnum = 20,
            /// <summary>
            /// Enum REELEnum for REEL
            /// </summary>
            [EnumMember(Value = "REEL")]
            REELEnum = 21,
            /// <summary>
            /// Enum ROLLERBLADESEnum for ROLLER BLADES
            /// </summary>
            [EnumMember(Value = "ROLLER BLADES")]
            ROLLERBLADESEnum = 22,
            /// <summary>
            /// Enum ROWINGMACHINEEXERCISEEnum for ROWING MACHINE_EXERCISE
            /// </summary>
            [EnumMember(Value = "ROWING MACHINE_EXERCISE")]
            ROWINGMACHINEEXERCISEEnum = 23,
            /// <summary>
            /// Enum SADDLEEnum for SADDLE
            /// </summary>
            [EnumMember(Value = "SADDLE")]
            SADDLEEnum = 24,
            /// <summary>
            /// Enum SCOOTEREnum for SCOOTER
            /// </summary>
            [EnumMember(Value = "SCOOTER")]
            SCOOTEREnum = 25,
            /// <summary>
            /// Enum SCUBAEnum for SCUBA
            /// </summary>
            [EnumMember(Value = "SCUBA")]
            SCUBAEnum = 26,
            /// <summary>
            /// Enum SKATEBOARDEnum for SKATE BOARD
            /// </summary>
            [EnumMember(Value = "SKATE BOARD")]
            SKATEBOARDEnum = 27,
            /// <summary>
            /// Enum SKATESICEEnum for SKATES_ICE
            /// </summary>
            [EnumMember(Value = "SKATES_ICE")]
            SKATESICEEnum = 28,
            /// <summary>
            /// Enum SKATESINLINEEnum for SKATES_INLINE
            /// </summary>
            [EnumMember(Value = "SKATES_INLINE")]
            SKATESINLINEEnum = 29,
            /// <summary>
            /// Enum SKATESROLLEREnum for SKATES_ROLLER
            /// </summary>
            [EnumMember(Value = "SKATES_ROLLER")]
            SKATESROLLEREnum = 30,
            /// <summary>
            /// Enum SKIRACKEnum for SKI RACK
            /// </summary>
            [EnumMember(Value = "SKI RACK")]
            SKIRACKEnum = 31,
            /// <summary>
            /// Enum SKISEnum for SKIS
            /// </summary>
            [EnumMember(Value = "SKIS")]
            SKISEnum = 32,
            /// <summary>
            /// Enum SKISSNOWEnum for SKIS_SNOW
            /// </summary>
            [EnumMember(Value = "SKIS_SNOW")]
            SKISSNOWEnum = 33,
            /// <summary>
            /// Enum SKISWATEREnum for SKIS_WATER
            /// </summary>
            [EnumMember(Value = "SKIS_WATER")]
            SKISWATEREnum = 34,
            /// <summary>
            /// Enum SLANTBOARDEnum for SLANT BOARD
            /// </summary>
            [EnumMember(Value = "SLANT BOARD")]
            SLANTBOARDEnum = 35,
            /// <summary>
            /// Enum SNOWBOARDEnum for SNOWBOARD
            /// </summary>
            [EnumMember(Value = "SNOWBOARD")]
            SNOWBOARDEnum = 36,
            /// <summary>
            /// Enum STEPMACHINEEXERCISEEnum for STEP MACHINE_EXERCISE
            /// </summary>
            [EnumMember(Value = "STEP MACHINE_EXERCISE")]
            STEPMACHINEEXERCISEEnum = 37,
            /// <summary>
            /// Enum STOPWATCHEnum for STOP WATCH
            /// </summary>
            [EnumMember(Value = "STOP WATCH")]
            STOPWATCHEnum = 38,
            /// <summary>
            /// Enum SURFBOARDEnum for SURFBOARD
            /// </summary>
            [EnumMember(Value = "SURFBOARD")]
            SURFBOARDEnum = 39,
            /// <summary>
            /// Enum SWORDEnum for SWORD
            /// </summary>
            [EnumMember(Value = "SWORD")]
            SWORDEnum = 40,
            /// <summary>
            /// Enum TENTEnum for TENT
            /// </summary>
            [EnumMember(Value = "TENT")]
            TENTEnum = 41,
            /// <summary>
            /// Enum TREADMILLEXERCISEEnum for TREADMILL_EXERCISE
            /// </summary>
            [EnumMember(Value = "TREADMILL_EXERCISE")]
            TREADMILLEXERCISEEnum = 42,
            /// <summary>
            /// Enum TREESTANDEnum for TREE STAND
            /// </summary>
            [EnumMember(Value = "TREE STAND")]
            TREESTANDEnum = 43        }
}
