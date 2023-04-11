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
        /// A data type for a code that identifies a metal.
        /// </summary>
        /// <value>A data type for a code that identifies a metal.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexMetalCodeSimpleType
        {
            /// <summary>
            /// Enum ACTINIUMEnum for ACTINIUM
            /// </summary>
            [EnumMember(Value = "ACTINIUM")]
            ACTINIUMEnum = 0,
            /// <summary>
            /// Enum ALUMINUMEnum for ALUMINUM
            /// </summary>
            [EnumMember(Value = "ALUMINUM")]
            ALUMINUMEnum = 1,
            /// <summary>
            /// Enum ALUMINUMBRONZEEnum for ALUMINUM_BRONZE
            /// </summary>
            [EnumMember(Value = "ALUMINUM_BRONZE")]
            ALUMINUMBRONZEEnum = 2,
            /// <summary>
            /// Enum AMALGAMEnum for AMALGAM
            /// </summary>
            [EnumMember(Value = "AMALGAM")]
            AMALGAMEnum = 3,
            /// <summary>
            /// Enum ANTIMONYEnum for ANTIMONY
            /// </summary>
            [EnumMember(Value = "ANTIMONY")]
            ANTIMONYEnum = 4,
            /// <summary>
            /// Enum ARSENICEnum for ARSENIC
            /// </summary>
            [EnumMember(Value = "ARSENIC")]
            ARSENICEnum = 5,
            /// <summary>
            /// Enum BARIUMEnum for BARIUM
            /// </summary>
            [EnumMember(Value = "BARIUM")]
            BARIUMEnum = 6,
            /// <summary>
            /// Enum BERYLLIUMEnum for BERYLLIUM
            /// </summary>
            [EnumMember(Value = "BERYLLIUM")]
            BERYLLIUMEnum = 7,
            /// <summary>
            /// Enum BISMUTHEnum for BISMUTH
            /// </summary>
            [EnumMember(Value = "BISMUTH")]
            BISMUTHEnum = 8,
            /// <summary>
            /// Enum BORONEnum for BORON
            /// </summary>
            [EnumMember(Value = "BORON")]
            BORONEnum = 9,
            /// <summary>
            /// Enum BRASSEnum for BRASS
            /// </summary>
            [EnumMember(Value = "BRASS")]
            BRASSEnum = 10,
            /// <summary>
            /// Enum BRONZEEnum for BRONZE
            /// </summary>
            [EnumMember(Value = "BRONZE")]
            BRONZEEnum = 11,
            /// <summary>
            /// Enum BRONZEARSENICEnum for BRONZE_ARSENIC
            /// </summary>
            [EnumMember(Value = "BRONZE_ARSENIC")]
            BRONZEARSENICEnum = 12,
            /// <summary>
            /// Enum BRONZETINEnum for BRONZE_TIN
            /// </summary>
            [EnumMember(Value = "BRONZE_TIN")]
            BRONZETINEnum = 13,
            /// <summary>
            /// Enum CADMIUMEnum for CADMIUM
            /// </summary>
            [EnumMember(Value = "CADMIUM")]
            CADMIUMEnum = 14,
            /// <summary>
            /// Enum CALCIUMEnum for CALCIUM
            /// </summary>
            [EnumMember(Value = "CALCIUM")]
            CALCIUMEnum = 15,
            /// <summary>
            /// Enum CERIUMEnum for CERIUM
            /// </summary>
            [EnumMember(Value = "CERIUM")]
            CERIUMEnum = 16,
            /// <summary>
            /// Enum CESIUMEnum for CESIUM
            /// </summary>
            [EnumMember(Value = "CESIUM")]
            CESIUMEnum = 17,
            /// <summary>
            /// Enum CHROMIUMEnum for CHROMIUM
            /// </summary>
            [EnumMember(Value = "CHROMIUM")]
            CHROMIUMEnum = 18,
            /// <summary>
            /// Enum COBALTEnum for COBALT
            /// </summary>
            [EnumMember(Value = "COBALT")]
            COBALTEnum = 19,
            /// <summary>
            /// Enum COPPEREnum for COPPER
            /// </summary>
            [EnumMember(Value = "COPPER")]
            COPPEREnum = 20,
            /// <summary>
            /// Enum DYSPROSIUMEnum for DYSPROSIUM
            /// </summary>
            [EnumMember(Value = "DYSPROSIUM")]
            DYSPROSIUMEnum = 21,
            /// <summary>
            /// Enum ERBIUMEnum for ERBIUM
            /// </summary>
            [EnumMember(Value = "ERBIUM")]
            ERBIUMEnum = 22,
            /// <summary>
            /// Enum EUROPIUMEnum for EUROPIUM
            /// </summary>
            [EnumMember(Value = "EUROPIUM")]
            EUROPIUMEnum = 23,
            /// <summary>
            /// Enum FRANCIUMEnum for FRANCIUM
            /// </summary>
            [EnumMember(Value = "FRANCIUM")]
            FRANCIUMEnum = 24,
            /// <summary>
            /// Enum GADOLINIUMEnum for GADOLINIUM
            /// </summary>
            [EnumMember(Value = "GADOLINIUM")]
            GADOLINIUMEnum = 25,
            /// <summary>
            /// Enum GALLIUMEnum for GALLIUM
            /// </summary>
            [EnumMember(Value = "GALLIUM")]
            GALLIUMEnum = 26,
            /// <summary>
            /// Enum GERMANIUMEnum for GERMANIUM
            /// </summary>
            [EnumMember(Value = "GERMANIUM")]
            GERMANIUMEnum = 27,
            /// <summary>
            /// Enum GOLDEnum for GOLD
            /// </summary>
            [EnumMember(Value = "GOLD")]
            GOLDEnum = 28,
            /// <summary>
            /// Enum HAFNIUMEnum for HAFNIUM
            /// </summary>
            [EnumMember(Value = "HAFNIUM")]
            HAFNIUMEnum = 29,
            /// <summary>
            /// Enum HOLMIUMEnum for HOLMIUM
            /// </summary>
            [EnumMember(Value = "HOLMIUM")]
            HOLMIUMEnum = 30,
            /// <summary>
            /// Enum INDIUMEnum for INDIUM
            /// </summary>
            [EnumMember(Value = "INDIUM")]
            INDIUMEnum = 31,
            /// <summary>
            /// Enum IRIDIUMEnum for IRIDIUM
            /// </summary>
            [EnumMember(Value = "IRIDIUM")]
            IRIDIUMEnum = 32,
            /// <summary>
            /// Enum IRONEnum for IRON
            /// </summary>
            [EnumMember(Value = "IRON")]
            IRONEnum = 33,
            /// <summary>
            /// Enum LANTHANUMEnum for LANTHANUM
            /// </summary>
            [EnumMember(Value = "LANTHANUM")]
            LANTHANUMEnum = 34,
            /// <summary>
            /// Enum LEADEnum for LEAD
            /// </summary>
            [EnumMember(Value = "LEAD")]
            LEADEnum = 35,
            /// <summary>
            /// Enum LITHIUMEnum for LITHIUM
            /// </summary>
            [EnumMember(Value = "LITHIUM")]
            LITHIUMEnum = 36,
            /// <summary>
            /// Enum LUTETIUMEnum for LUTETIUM
            /// </summary>
            [EnumMember(Value = "LUTETIUM")]
            LUTETIUMEnum = 37,
            /// <summary>
            /// Enum MAGNESIUMEnum for MAGNESIUM
            /// </summary>
            [EnumMember(Value = "MAGNESIUM")]
            MAGNESIUMEnum = 38,
            /// <summary>
            /// Enum MANGANESEEnum for MANGANESE
            /// </summary>
            [EnumMember(Value = "MANGANESE")]
            MANGANESEEnum = 39,
            /// <summary>
            /// Enum MERCURYEnum for MERCURY
            /// </summary>
            [EnumMember(Value = "MERCURY")]
            MERCURYEnum = 40,
            /// <summary>
            /// Enum MOLYBDENUMEnum for MOLYBDENUM
            /// </summary>
            [EnumMember(Value = "MOLYBDENUM")]
            MOLYBDENUMEnum = 41,
            /// <summary>
            /// Enum NEODYMIUMEnum for NEODYMIUM
            /// </summary>
            [EnumMember(Value = "NEODYMIUM")]
            NEODYMIUMEnum = 42,
            /// <summary>
            /// Enum NICKELEnum for NICKEL
            /// </summary>
            [EnumMember(Value = "NICKEL")]
            NICKELEnum = 43,
            /// <summary>
            /// Enum NIOBIUMEnum for NIOBIUM
            /// </summary>
            [EnumMember(Value = "NIOBIUM")]
            NIOBIUMEnum = 44,
            /// <summary>
            /// Enum OSMIUMEnum for OSMIUM
            /// </summary>
            [EnumMember(Value = "OSMIUM")]
            OSMIUMEnum = 45,
            /// <summary>
            /// Enum PALLADIUMEnum for PALLADIUM
            /// </summary>
            [EnumMember(Value = "PALLADIUM")]
            PALLADIUMEnum = 46,
            /// <summary>
            /// Enum PEWTEREnum for PEWTER
            /// </summary>
            [EnumMember(Value = "PEWTER")]
            PEWTEREnum = 47,
            /// <summary>
            /// Enum PLATINUMEnum for PLATINUM
            /// </summary>
            [EnumMember(Value = "PLATINUM")]
            PLATINUMEnum = 48,
            /// <summary>
            /// Enum POLONIUMEnum for POLONIUM
            /// </summary>
            [EnumMember(Value = "POLONIUM")]
            POLONIUMEnum = 49,
            /// <summary>
            /// Enum POTASSIUMEnum for POTASSIUM
            /// </summary>
            [EnumMember(Value = "POTASSIUM")]
            POTASSIUMEnum = 50,
            /// <summary>
            /// Enum PRASEODYMIUMEnum for PRASEODYMIUM
            /// </summary>
            [EnumMember(Value = "PRASEODYMIUM")]
            PRASEODYMIUMEnum = 51,
            /// <summary>
            /// Enum PROMETHIUMEnum for PROMETHIUM
            /// </summary>
            [EnumMember(Value = "PROMETHIUM")]
            PROMETHIUMEnum = 52,
            /// <summary>
            /// Enum PROTACTINIUMEnum for PROTACTINIUM
            /// </summary>
            [EnumMember(Value = "PROTACTINIUM")]
            PROTACTINIUMEnum = 53,
            /// <summary>
            /// Enum RADIUMEnum for RADIUM
            /// </summary>
            [EnumMember(Value = "RADIUM")]
            RADIUMEnum = 54,
            /// <summary>
            /// Enum RHENIUMEnum for RHENIUM
            /// </summary>
            [EnumMember(Value = "RHENIUM")]
            RHENIUMEnum = 55,
            /// <summary>
            /// Enum RHODIUMEnum for RHODIUM
            /// </summary>
            [EnumMember(Value = "RHODIUM")]
            RHODIUMEnum = 56,
            /// <summary>
            /// Enum RUBIDIUMEnum for RUBIDIUM
            /// </summary>
            [EnumMember(Value = "RUBIDIUM")]
            RUBIDIUMEnum = 57,
            /// <summary>
            /// Enum RUTHENIUMEnum for RUTHENIUM
            /// </summary>
            [EnumMember(Value = "RUTHENIUM")]
            RUTHENIUMEnum = 58,
            /// <summary>
            /// Enum SAMARIUMEnum for SAMARIUM
            /// </summary>
            [EnumMember(Value = "SAMARIUM")]
            SAMARIUMEnum = 59,
            /// <summary>
            /// Enum SCANDIUMEnum for SCANDIUM
            /// </summary>
            [EnumMember(Value = "SCANDIUM")]
            SCANDIUMEnum = 60,
            /// <summary>
            /// Enum SELENIUMEnum for SELENIUM
            /// </summary>
            [EnumMember(Value = "SELENIUM")]
            SELENIUMEnum = 61,
            /// <summary>
            /// Enum SILICONEnum for SILICON
            /// </summary>
            [EnumMember(Value = "SILICON")]
            SILICONEnum = 62,
            /// <summary>
            /// Enum SILVEREnum for SILVER
            /// </summary>
            [EnumMember(Value = "SILVER")]
            SILVEREnum = 63,
            /// <summary>
            /// Enum SODIUMEnum for SODIUM
            /// </summary>
            [EnumMember(Value = "SODIUM")]
            SODIUMEnum = 64,
            /// <summary>
            /// Enum STEELEnum for STEEL
            /// </summary>
            [EnumMember(Value = "STEEL")]
            STEELEnum = 65,
            /// <summary>
            /// Enum STEELSTAINLESSEnum for STEEL_STAINLESS
            /// </summary>
            [EnumMember(Value = "STEEL_STAINLESS")]
            STEELSTAINLESSEnum = 66,
            /// <summary>
            /// Enum STRONTIUMEnum for STRONTIUM
            /// </summary>
            [EnumMember(Value = "STRONTIUM")]
            STRONTIUMEnum = 67,
            /// <summary>
            /// Enum TANTALUMEnum for TANTALUM
            /// </summary>
            [EnumMember(Value = "TANTALUM")]
            TANTALUMEnum = 68,
            /// <summary>
            /// Enum TECHNETIUMEnum for TECHNETIUM
            /// </summary>
            [EnumMember(Value = "TECHNETIUM")]
            TECHNETIUMEnum = 69,
            /// <summary>
            /// Enum TELLURIUMEnum for TELLURIUM
            /// </summary>
            [EnumMember(Value = "TELLURIUM")]
            TELLURIUMEnum = 70,
            /// <summary>
            /// Enum TERBIUMEnum for TERBIUM
            /// </summary>
            [EnumMember(Value = "TERBIUM")]
            TERBIUMEnum = 71,
            /// <summary>
            /// Enum THALLIUMEnum for THALLIUM
            /// </summary>
            [EnumMember(Value = "THALLIUM")]
            THALLIUMEnum = 72,
            /// <summary>
            /// Enum THORIUMEnum for THORIUM
            /// </summary>
            [EnumMember(Value = "THORIUM")]
            THORIUMEnum = 73,
            /// <summary>
            /// Enum THULIUMEnum for THULIUM
            /// </summary>
            [EnumMember(Value = "THULIUM")]
            THULIUMEnum = 74,
            /// <summary>
            /// Enum TINEnum for TIN
            /// </summary>
            [EnumMember(Value = "TIN")]
            TINEnum = 75,
            /// <summary>
            /// Enum TRANSURANIUMEnum for TRANSURANIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM")]
            TRANSURANIUMEnum = 76,
            /// <summary>
            /// Enum TRANSURANIUMAMERICIUMEnum for TRANSURANIUM_AMERICIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_AMERICIUM")]
            TRANSURANIUMAMERICIUMEnum = 77,
            /// <summary>
            /// Enum TRANSURANIUMBERKELIUMEnum for TRANSURANIUM_BERKELIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_BERKELIUM")]
            TRANSURANIUMBERKELIUMEnum = 78,
            /// <summary>
            /// Enum TRANSURANIUMCALIFORNIUMEnum for TRANSURANIUM_CALIFORNIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_CALIFORNIUM")]
            TRANSURANIUMCALIFORNIUMEnum = 79,
            /// <summary>
            /// Enum TRANSURANIUMCURIUMEnum for TRANSURANIUM_CURIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_CURIUM")]
            TRANSURANIUMCURIUMEnum = 80,
            /// <summary>
            /// Enum TRANSURANIUMEINSTEINIUMEnum for TRANSURANIUM_EINSTEINIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_EINSTEINIUM")]
            TRANSURANIUMEINSTEINIUMEnum = 81,
            /// <summary>
            /// Enum TRANSURANIUMFERMIUMEnum for TRANSURANIUM_FERMIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_FERMIUM")]
            TRANSURANIUMFERMIUMEnum = 82,
            /// <summary>
            /// Enum TRANSURANIUMLAWRENCIUMEnum for TRANSURANIUM_LAWRENCIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_LAWRENCIUM")]
            TRANSURANIUMLAWRENCIUMEnum = 83,
            /// <summary>
            /// Enum TRANSURANIUMMENDELEVIUMEnum for TRANSURANIUM_MENDELEVIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_MENDELEVIUM")]
            TRANSURANIUMMENDELEVIUMEnum = 84,
            /// <summary>
            /// Enum TRANSURANIUMNEPTUNIUMEnum for TRANSURANIUM_NEPTUNIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_NEPTUNIUM")]
            TRANSURANIUMNEPTUNIUMEnum = 85,
            /// <summary>
            /// Enum TRANSURANIUMNOBELIUMEnum for TRANSURANIUM_NOBELIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_NOBELIUM")]
            TRANSURANIUMNOBELIUMEnum = 86,
            /// <summary>
            /// Enum TRANSURANIUMPLUTONIUMEnum for TRANSURANIUM_PLUTONIUM
            /// </summary>
            [EnumMember(Value = "TRANSURANIUM_PLUTONIUM")]
            TRANSURANIUMPLUTONIUMEnum = 87,
            /// <summary>
            /// Enum TUNGSTENEnum for TUNGSTEN
            /// </summary>
            [EnumMember(Value = "TUNGSTEN")]
            TUNGSTENEnum = 88,
            /// <summary>
            /// Enum URANIUMEnum for URANIUM
            /// </summary>
            [EnumMember(Value = "URANIUM")]
            URANIUMEnum = 89,
            /// <summary>
            /// Enum VANADIUMEnum for VANADIUM
            /// </summary>
            [EnumMember(Value = "VANADIUM")]
            VANADIUMEnum = 90,
            /// <summary>
            /// Enum YTTRIUMEnum for YTTRIUM
            /// </summary>
            [EnumMember(Value = "YTTRIUM")]
            YTTRIUMEnum = 91,
            /// <summary>
            /// Enum ZINCEnum for ZINC
            /// </summary>
            [EnumMember(Value = "ZINC")]
            ZINCEnum = 92,
            /// <summary>
            /// Enum ZIRCONIUMEnum for ZIRCONIUM
            /// </summary>
            [EnumMember(Value = "ZIRCONIUM")]
            ZIRCONIUMEnum = 93        }
}