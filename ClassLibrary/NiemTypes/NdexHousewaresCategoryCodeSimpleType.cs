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
        /// A data type for a code that identifies a type of household goods.
        /// </summary>
        /// <value>A data type for a code that identifies a type of household goods.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexHousewaresCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum AIRCONDITIONEREnum for AIR CONDITIONER
            /// </summary>
            [EnumMember(Value = "AIR CONDITIONER")]
            AIRCONDITIONEREnum = 0,
            /// <summary>
            /// Enum BATHTUBEnum for BATHTUB
            /// </summary>
            [EnumMember(Value = "BATHTUB")]
            BATHTUBEnum = 1,
            /// <summary>
            /// Enum BLENDEREnum for BLENDER
            /// </summary>
            [EnumMember(Value = "BLENDER")]
            BLENDEREnum = 2,
            /// <summary>
            /// Enum BOWLEnum for BOWL
            /// </summary>
            [EnumMember(Value = "BOWL")]
            BOWLEnum = 3,
            /// <summary>
            /// Enum BOWLSILVEREnum for BOWL_SILVER
            /// </summary>
            [EnumMember(Value = "BOWL_SILVER")]
            BOWLSILVEREnum = 4,
            /// <summary>
            /// Enum BUFFERPOLISHEREnum for BUFFER_POLISHER
            /// </summary>
            [EnumMember(Value = "BUFFER_POLISHER")]
            BUFFERPOLISHEREnum = 5,
            /// <summary>
            /// Enum BUFFERPOLISHERFLOOREnum for BUFFER_POLISHER_FLOOR
            /// </summary>
            [EnumMember(Value = "BUFFER_POLISHER_FLOOR")]
            BUFFERPOLISHERFLOOREnum = 6,
            /// <summary>
            /// Enum CANOPENEREnum for CAN OPENER
            /// </summary>
            [EnumMember(Value = "CAN OPENER")]
            CANOPENEREnum = 7,
            /// <summary>
            /// Enum COFFEEMAKEREnum for COFFEE MAKER
            /// </summary>
            [EnumMember(Value = "COFFEE MAKER")]
            COFFEEMAKEREnum = 8,
            /// <summary>
            /// Enum COOKINGUTENSILSEnum for COOKING UTENSILS
            /// </summary>
            [EnumMember(Value = "COOKING UTENSILS")]
            COOKINGUTENSILSEnum = 9,
            /// <summary>
            /// Enum COOKINGUTENSILSKNIFEEnum for COOKING UTENSILS_KNIFE
            /// </summary>
            [EnumMember(Value = "COOKING UTENSILS_KNIFE")]
            COOKINGUTENSILSKNIFEEnum = 10,
            /// <summary>
            /// Enum DEHUMIDIFIEREnum for DEHUMIDIFIER
            /// </summary>
            [EnumMember(Value = "DEHUMIDIFIER")]
            DEHUMIDIFIEREnum = 11,
            /// <summary>
            /// Enum DISHEnum for DISH
            /// </summary>
            [EnumMember(Value = "DISH")]
            DISHEnum = 12,
            /// <summary>
            /// Enum DISHSILVEREnum for DISH_SILVER
            /// </summary>
            [EnumMember(Value = "DISH_SILVER")]
            DISHSILVEREnum = 13,
            /// <summary>
            /// Enum DISHWASHEREnum for DISHWASHER
            /// </summary>
            [EnumMember(Value = "DISHWASHER")]
            DISHWASHEREnum = 14,
            /// <summary>
            /// Enum DRYEREnum for DRYER
            /// </summary>
            [EnumMember(Value = "DRYER")]
            DRYEREnum = 15,
            /// <summary>
            /// Enum DRYERCLOTHESEnum for DRYER_CLOTHES
            /// </summary>
            [EnumMember(Value = "DRYER_CLOTHES")]
            DRYERCLOTHESEnum = 16,
            /// <summary>
            /// Enum DRYERHAIREnum for DRYER_HAIR
            /// </summary>
            [EnumMember(Value = "DRYER_HAIR")]
            DRYERHAIREnum = 17,
            /// <summary>
            /// Enum FANEnum for FAN
            /// </summary>
            [EnumMember(Value = "FAN")]
            FANEnum = 18,
            /// <summary>
            /// Enum FOODMIXEREnum for FOOD MIXER
            /// </summary>
            [EnumMember(Value = "FOOD MIXER")]
            FOODMIXEREnum = 19,
            /// <summary>
            /// Enum FOODPROCESSOREnum for FOOD PROCESSOR
            /// </summary>
            [EnumMember(Value = "FOOD PROCESSOR")]
            FOODPROCESSOREnum = 20,
            /// <summary>
            /// Enum FREEZEREnum for FREEZER
            /// </summary>
            [EnumMember(Value = "FREEZER")]
            FREEZEREnum = 21,
            /// <summary>
            /// Enum FRYEREnum for FRYER
            /// </summary>
            [EnumMember(Value = "FRYER")]
            FRYEREnum = 22,
            /// <summary>
            /// Enum FURNACEEnum for FURNACE
            /// </summary>
            [EnumMember(Value = "FURNACE")]
            FURNACEEnum = 23,
            /// <summary>
            /// Enum GARBAGEDISPOSALEnum for GARBAGE DISPOSAL
            /// </summary>
            [EnumMember(Value = "GARBAGE DISPOSAL")]
            GARBAGEDISPOSALEnum = 24,
            /// <summary>
            /// Enum GRILLEnum for GRILL
            /// </summary>
            [EnumMember(Value = "GRILL")]
            GRILLEnum = 25,
            /// <summary>
            /// Enum HANDHELDMIXERELECTRICEnum for HANDHELD MIXER_ELECTRIC
            /// </summary>
            [EnumMember(Value = "HANDHELD MIXER_ELECTRIC")]
            HANDHELDMIXERELECTRICEnum = 26,
            /// <summary>
            /// Enum HANDHELDMIXERNONELECTRICEnum for HANDHELD MIXER_NONELECTRIC
            /// </summary>
            [EnumMember(Value = "HANDHELD MIXER_NONELECTRIC")]
            HANDHELDMIXERNONELECTRICEnum = 27,
            /// <summary>
            /// Enum HEATPUMPEnum for HEAT PUMP
            /// </summary>
            [EnumMember(Value = "HEAT PUMP")]
            HEATPUMPEnum = 28,
            /// <summary>
            /// Enum HOTTUBEnum for HOT TUB
            /// </summary>
            [EnumMember(Value = "HOT TUB")]
            HOTTUBEnum = 29,
            /// <summary>
            /// Enum HUMIDIFIEREnum for HUMIDIFIER
            /// </summary>
            [EnumMember(Value = "HUMIDIFIER")]
            HUMIDIFIEREnum = 30,
            /// <summary>
            /// Enum ICECREAMMACHINEEnum for ICE CREAM MACHINE
            /// </summary>
            [EnumMember(Value = "ICE CREAM MACHINE")]
            ICECREAMMACHINEEnum = 31,
            /// <summary>
            /// Enum ICEMAKEREnum for ICE MAKER
            /// </summary>
            [EnumMember(Value = "ICE MAKER")]
            ICEMAKEREnum = 32,
            /// <summary>
            /// Enum ICEBOXEnum for ICEBOX
            /// </summary>
            [EnumMember(Value = "ICEBOX")]
            ICEBOXEnum = 33,
            /// <summary>
            /// Enum IRONEnum for IRON
            /// </summary>
            [EnumMember(Value = "IRON")]
            IRONEnum = 34,
            /// <summary>
            /// Enum JUICEREnum for JUICER
            /// </summary>
            [EnumMember(Value = "JUICER")]
            JUICEREnum = 35,
            /// <summary>
            /// Enum MANDOLINEnum for MANDOLIN
            /// </summary>
            [EnumMember(Value = "MANDOLIN")]
            MANDOLINEnum = 36,
            /// <summary>
            /// Enum MEATSLICEREnum for MEAT SLICER
            /// </summary>
            [EnumMember(Value = "MEAT SLICER")]
            MEATSLICEREnum = 37,
            /// <summary>
            /// Enum MICROWAVEOVENEnum for MICROWAVE_OVEN
            /// </summary>
            [EnumMember(Value = "MICROWAVE_OVEN")]
            MICROWAVEOVENEnum = 38,
            /// <summary>
            /// Enum OILBURNEREnum for OIL BURNER
            /// </summary>
            [EnumMember(Value = "OIL BURNER")]
            OILBURNEREnum = 39,
            /// <summary>
            /// Enum PITCHEREnum for PITCHER
            /// </summary>
            [EnumMember(Value = "PITCHER")]
            PITCHEREnum = 40,
            /// <summary>
            /// Enum PITCHERSILVEREnum for PITCHER_SILVER
            /// </summary>
            [EnumMember(Value = "PITCHER_SILVER")]
            PITCHERSILVEREnum = 41,
            /// <summary>
            /// Enum PLATEEnum for PLATE
            /// </summary>
            [EnumMember(Value = "PLATE")]
            PLATEEnum = 42,
            /// <summary>
            /// Enum PLATESILVEREnum for PLATE_SILVER
            /// </summary>
            [EnumMember(Value = "PLATE_SILVER")]
            PLATESILVEREnum = 43,
            /// <summary>
            /// Enum POPCORNMAKEREnum for POPCORN MAKER
            /// </summary>
            [EnumMember(Value = "POPCORN MAKER")]
            POPCORNMAKEREnum = 44,
            /// <summary>
            /// Enum PORTABLETOILETEnum for PORTABLE TOILET
            /// </summary>
            [EnumMember(Value = "PORTABLE TOILET")]
            PORTABLETOILETEnum = 45,
            /// <summary>
            /// Enum RANGEEnum for RANGE
            /// </summary>
            [EnumMember(Value = "RANGE")]
            RANGEEnum = 46,
            /// <summary>
            /// Enum RANGEHOODEnum for RANGE HOOD
            /// </summary>
            [EnumMember(Value = "RANGE HOOD")]
            RANGEHOODEnum = 47,
            /// <summary>
            /// Enum RANGEOVENEnum for RANGE_OVEN
            /// </summary>
            [EnumMember(Value = "RANGE_OVEN")]
            RANGEOVENEnum = 48,
            /// <summary>
            /// Enum REFRIGERATOREnum for REFRIGERATOR
            /// </summary>
            [EnumMember(Value = "REFRIGERATOR")]
            REFRIGERATOREnum = 49,
            /// <summary>
            /// Enum RUGSHAMPOOEREnum for RUG SHAMPOOER
            /// </summary>
            [EnumMember(Value = "RUG SHAMPOOER")]
            RUGSHAMPOOEREnum = 50,
            /// <summary>
            /// Enum SCISSORSEnum for SCISSORS
            /// </summary>
            [EnumMember(Value = "SCISSORS")]
            SCISSORSEnum = 51,
            /// <summary>
            /// Enum SEWINGMACHINEEnum for SEWING MACHINE
            /// </summary>
            [EnumMember(Value = "SEWING MACHINE")]
            SEWINGMACHINEEnum = 52,
            /// <summary>
            /// Enum SILVERPIECESEnum for SILVER_PIECES
            /// </summary>
            [EnumMember(Value = "SILVER_PIECES")]
            SILVERPIECESEnum = 53,
            /// <summary>
            /// Enum SILVERWAREEnum for SILVERWARE
            /// </summary>
            [EnumMember(Value = "SILVERWARE")]
            SILVERWAREEnum = 54,
            /// <summary>
            /// Enum SMALLAPPLIANCEEnum for SMALL APPLIANCE
            /// </summary>
            [EnumMember(Value = "SMALL APPLIANCE")]
            SMALLAPPLIANCEEnum = 55,
            /// <summary>
            /// Enum SPACEHEATEREnum for SPACE HEATER
            /// </summary>
            [EnumMember(Value = "SPACE HEATER")]
            SPACEHEATEREnum = 56,
            /// <summary>
            /// Enum STEAMCARPETCLEANEREnum for STEAM CARPET CLEANER
            /// </summary>
            [EnumMember(Value = "STEAM CARPET CLEANER")]
            STEAMCARPETCLEANEREnum = 57,
            /// <summary>
            /// Enum TEASETEnum for TEA SET
            /// </summary>
            [EnumMember(Value = "TEA SET")]
            TEASETEnum = 58,
            /// <summary>
            /// Enum TEASETSILVEREnum for TEA SET_SILVER
            /// </summary>
            [EnumMember(Value = "TEA SET_SILVER")]
            TEASETSILVEREnum = 59,
            /// <summary>
            /// Enum TOASTEREnum for TOASTER
            /// </summary>
            [EnumMember(Value = "TOASTER")]
            TOASTEREnum = 60,
            /// <summary>
            /// Enum TOASTEROVENEnum for TOASTER_OVEN
            /// </summary>
            [EnumMember(Value = "TOASTER_OVEN")]
            TOASTEROVENEnum = 61,
            /// <summary>
            /// Enum TRASHBARRELPOLYCARTEnum for TRASH BARREL_POLY CART
            /// </summary>
            [EnumMember(Value = "TRASH BARREL_POLY CART")]
            TRASHBARRELPOLYCARTEnum = 62,
            /// <summary>
            /// Enum TRASHCOMPACTOREnum for TRASH COMPACTOR
            /// </summary>
            [EnumMember(Value = "TRASH COMPACTOR")]
            TRASHCOMPACTOREnum = 63,
            /// <summary>
            /// Enum TRAYEnum for TRAY
            /// </summary>
            [EnumMember(Value = "TRAY")]
            TRAYEnum = 64,
            /// <summary>
            /// Enum TRAYSILVEREnum for TRAY_SILVER
            /// </summary>
            [EnumMember(Value = "TRAY_SILVER")]
            TRAYSILVEREnum = 65,
            /// <summary>
            /// Enum VACUUMCLEANEREnum for VACUUM CLEANER
            /// </summary>
            [EnumMember(Value = "VACUUM CLEANER")]
            VACUUMCLEANEREnum = 66,
            /// <summary>
            /// Enum VACUUMCLEANERATTACHMENTSEnum for VACUUM CLEANER ATTACHMENTS
            /// </summary>
            [EnumMember(Value = "VACUUM CLEANER ATTACHMENTS")]
            VACUUMCLEANERATTACHMENTSEnum = 67,
            /// <summary>
            /// Enum WASHINGMACHINECLOTHESWASHEREnum for WASHING MACHINE_CLOTHES WASHER
            /// </summary>
            [EnumMember(Value = "WASHING MACHINE_CLOTHES WASHER")]
            WASHINGMACHINECLOTHESWASHEREnum = 68,
            /// <summary>
            /// Enum WATERHEATEREnum for WATER HEATER
            /// </summary>
            [EnumMember(Value = "WATER HEATER")]
            WATERHEATEREnum = 69,
            /// <summary>
            /// Enum WATERSOFTENEREnum for WATER SOFTENER
            /// </summary>
            [EnumMember(Value = "WATER SOFTENER")]
            WATERSOFTENEREnum = 70,
            /// <summary>
            /// Enum WOODBURNINGSTOVEEnum for WOODBURNING STOVE
            /// </summary>
            [EnumMember(Value = "WOODBURNING STOVE")]
            WOODBURNINGSTOVEEnum = 71,
            /// <summary>
            /// Enum YOGURTMACHINEEnum for YOGURT MACHINE
            /// </summary>
            [EnumMember(Value = "YOGURT MACHINE")]
            YOGURTMACHINEEnum = 72        }
}
