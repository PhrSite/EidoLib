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
        /// A data type for a religion to which a person can subscribe or believe; a categorization of spiritual beliefs.
        /// </summary>
        /// <value>A data type for a religion to which a person can subscribe or believe; a categorization of spiritual beliefs.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum Hl7ReligionCodeSimpleType
        {
            /// <summary>
            /// Enum ABCEnum for ABC
            /// </summary>
            [EnumMember(Value = "ABC")]
            ABCEnum = 0,
            /// <summary>
            /// Enum AGNEnum for AGN
            /// </summary>
            [EnumMember(Value = "AGN")]
            AGNEnum = 1,
            /// <summary>
            /// Enum AMEEnum for AME
            /// </summary>
            [EnumMember(Value = "AME")]
            AMEEnum = 2,
            /// <summary>
            /// Enum AMTEnum for AMT
            /// </summary>
            [EnumMember(Value = "AMT")]
            AMTEnum = 3,
            /// <summary>
            /// Enum ANGEnum for ANG
            /// </summary>
            [EnumMember(Value = "ANG")]
            ANGEnum = 4,
            /// <summary>
            /// Enum AOGEnum for AOG
            /// </summary>
            [EnumMember(Value = "AOG")]
            AOGEnum = 5,
            /// <summary>
            /// Enum ATHEnum for ATH
            /// </summary>
            [EnumMember(Value = "ATH")]
            ATHEnum = 6,
            /// <summary>
            /// Enum BAHEnum for BAH
            /// </summary>
            [EnumMember(Value = "BAH")]
            BAHEnum = 7,
            /// <summary>
            /// Enum BAPEnum for BAP
            /// </summary>
            [EnumMember(Value = "BAP")]
            BAPEnum = 8,
            /// <summary>
            /// Enum BMAEnum for BMA
            /// </summary>
            [EnumMember(Value = "BMA")]
            BMAEnum = 9,
            /// <summary>
            /// Enum BOTEnum for BOT
            /// </summary>
            [EnumMember(Value = "BOT")]
            BOTEnum = 10,
            /// <summary>
            /// Enum BTAEnum for BTA
            /// </summary>
            [EnumMember(Value = "BTA")]
            BTAEnum = 11,
            /// <summary>
            /// Enum BTHEnum for BTH
            /// </summary>
            [EnumMember(Value = "BTH")]
            BTHEnum = 12,
            /// <summary>
            /// Enum BUDEnum for BUD
            /// </summary>
            [EnumMember(Value = "BUD")]
            BUDEnum = 13,
            /// <summary>
            /// Enum CATEnum for CAT
            /// </summary>
            [EnumMember(Value = "CAT")]
            CATEnum = 14,
            /// <summary>
            /// Enum CFREnum for CFR
            /// </summary>
            [EnumMember(Value = "CFR")]
            CFREnum = 15,
            /// <summary>
            /// Enum CHREnum for CHR
            /// </summary>
            [EnumMember(Value = "CHR")]
            CHREnum = 16,
            /// <summary>
            /// Enum CHSEnum for CHS
            /// </summary>
            [EnumMember(Value = "CHS")]
            CHSEnum = 17,
            /// <summary>
            /// Enum CMAEnum for CMA
            /// </summary>
            [EnumMember(Value = "CMA")]
            CMAEnum = 18,
            /// <summary>
            /// Enum CNFEnum for CNF
            /// </summary>
            [EnumMember(Value = "CNF")]
            CNFEnum = 19,
            /// <summary>
            /// Enum COCEnum for COC
            /// </summary>
            [EnumMember(Value = "COC")]
            COCEnum = 20,
            /// <summary>
            /// Enum COGEnum for COG
            /// </summary>
            [EnumMember(Value = "COG")]
            COGEnum = 21,
            /// <summary>
            /// Enum COIEnum for COI
            /// </summary>
            [EnumMember(Value = "COI")]
            COIEnum = 22,
            /// <summary>
            /// Enum COLEnum for COL
            /// </summary>
            [EnumMember(Value = "COL")]
            COLEnum = 23,
            /// <summary>
            /// Enum COMEnum for COM
            /// </summary>
            [EnumMember(Value = "COM")]
            COMEnum = 24,
            /// <summary>
            /// Enum COPEnum for COP
            /// </summary>
            [EnumMember(Value = "COP")]
            COPEnum = 25,
            /// <summary>
            /// Enum COTEnum for COT
            /// </summary>
            [EnumMember(Value = "COT")]
            COTEnum = 26,
            /// <summary>
            /// Enum CRREnum for CRR
            /// </summary>
            [EnumMember(Value = "CRR")]
            CRREnum = 27,
            /// <summary>
            /// Enum EOTEnum for EOT
            /// </summary>
            [EnumMember(Value = "EOT")]
            EOTEnum = 28,
            /// <summary>
            /// Enum EPIEnum for EPI
            /// </summary>
            [EnumMember(Value = "EPI")]
            EPIEnum = 29,
            /// <summary>
            /// Enum ERLEnum for ERL
            /// </summary>
            [EnumMember(Value = "ERL")]
            ERLEnum = 30,
            /// <summary>
            /// Enum EVCEnum for EVC
            /// </summary>
            [EnumMember(Value = "EVC")]
            EVCEnum = 31,
            /// <summary>
            /// Enum FRQEnum for FRQ
            /// </summary>
            [EnumMember(Value = "FRQ")]
            FRQEnum = 32,
            /// <summary>
            /// Enum FWBEnum for FWB
            /// </summary>
            [EnumMember(Value = "FWB")]
            FWBEnum = 33,
            /// <summary>
            /// Enum GREEnum for GRE
            /// </summary>
            [EnumMember(Value = "GRE")]
            GREEnum = 34,
            /// <summary>
            /// Enum HINEnum for HIN
            /// </summary>
            [EnumMember(Value = "HIN")]
            HINEnum = 35,
            /// <summary>
            /// Enum HOTEnum for HOT
            /// </summary>
            [EnumMember(Value = "HOT")]
            HOTEnum = 36,
            /// <summary>
            /// Enum HSHEnum for HSH
            /// </summary>
            [EnumMember(Value = "HSH")]
            HSHEnum = 37,
            /// <summary>
            /// Enum HVAEnum for HVA
            /// </summary>
            [EnumMember(Value = "HVA")]
            HVAEnum = 38,
            /// <summary>
            /// Enum JAIEnum for JAI
            /// </summary>
            [EnumMember(Value = "JAI")]
            JAIEnum = 39,
            /// <summary>
            /// Enum JCOEnum for JCO
            /// </summary>
            [EnumMember(Value = "JCO")]
            JCOEnum = 40,
            /// <summary>
            /// Enum JEWEnum for JEW
            /// </summary>
            [EnumMember(Value = "JEW")]
            JEWEnum = 41,
            /// <summary>
            /// Enum JOREnum for JOR
            /// </summary>
            [EnumMember(Value = "JOR")]
            JOREnum = 42,
            /// <summary>
            /// Enum JOTEnum for JOT
            /// </summary>
            [EnumMember(Value = "JOT")]
            JOTEnum = 43,
            /// <summary>
            /// Enum JRCEnum for JRC
            /// </summary>
            [EnumMember(Value = "JRC")]
            JRCEnum = 44,
            /// <summary>
            /// Enum JRFEnum for JRF
            /// </summary>
            [EnumMember(Value = "JRF")]
            JRFEnum = 45,
            /// <summary>
            /// Enum JRNEnum for JRN
            /// </summary>
            [EnumMember(Value = "JRN")]
            JRNEnum = 46,
            /// <summary>
            /// Enum JWNEnum for JWN
            /// </summary>
            [EnumMember(Value = "JWN")]
            JWNEnum = 47,
            /// <summary>
            /// Enum LMSEnum for LMS
            /// </summary>
            [EnumMember(Value = "LMS")]
            LMSEnum = 48,
            /// <summary>
            /// Enum LUTEnum for LUT
            /// </summary>
            [EnumMember(Value = "LUT")]
            LUTEnum = 49,
            /// <summary>
            /// Enum MENEnum for MEN
            /// </summary>
            [EnumMember(Value = "MEN")]
            MENEnum = 50,
            /// <summary>
            /// Enum METEnum for MET
            /// </summary>
            [EnumMember(Value = "MET")]
            METEnum = 51,
            /// <summary>
            /// Enum MOMEnum for MOM
            /// </summary>
            [EnumMember(Value = "MOM")]
            MOMEnum = 52,
            /// <summary>
            /// Enum MOSEnum for MOS
            /// </summary>
            [EnumMember(Value = "MOS")]
            MOSEnum = 53,
            /// <summary>
            /// Enum MOTEnum for MOT
            /// </summary>
            [EnumMember(Value = "MOT")]
            MOTEnum = 54,
            /// <summary>
            /// Enum MSHEnum for MSH
            /// </summary>
            [EnumMember(Value = "MSH")]
            MSHEnum = 55,
            /// <summary>
            /// Enum MSUEnum for MSU
            /// </summary>
            [EnumMember(Value = "MSU")]
            MSUEnum = 56,
            /// <summary>
            /// Enum NAMEnum for NAM
            /// </summary>
            [EnumMember(Value = "NAM")]
            NAMEnum = 57,
            /// <summary>
            /// Enum NAZEnum for NAZ
            /// </summary>
            [EnumMember(Value = "NAZ")]
            NAZEnum = 58,
            /// <summary>
            /// Enum NOEEnum for NOE
            /// </summary>
            [EnumMember(Value = "NOE")]
            NOEEnum = 59,
            /// <summary>
            /// Enum NRLEnum for NRL
            /// </summary>
            [EnumMember(Value = "NRL")]
            NRLEnum = 60,
            /// <summary>
            /// Enum ORTEnum for ORT
            /// </summary>
            [EnumMember(Value = "ORT")]
            ORTEnum = 61,
            /// <summary>
            /// Enum OTHEnum for OTH
            /// </summary>
            [EnumMember(Value = "OTH")]
            OTHEnum = 62,
            /// <summary>
            /// Enum PENEnum for PEN
            /// </summary>
            [EnumMember(Value = "PEN")]
            PENEnum = 63,
            /// <summary>
            /// Enum PRCEnum for PRC
            /// </summary>
            [EnumMember(Value = "PRC")]
            PRCEnum = 64,
            /// <summary>
            /// Enum PREEnum for PRE
            /// </summary>
            [EnumMember(Value = "PRE")]
            PREEnum = 65,
            /// <summary>
            /// Enum PROEnum for PRO
            /// </summary>
            [EnumMember(Value = "PRO")]
            PROEnum = 66,
            /// <summary>
            /// Enum QUAEnum for QUA
            /// </summary>
            [EnumMember(Value = "QUA")]
            QUAEnum = 67,
            /// <summary>
            /// Enum RECEnum for REC
            /// </summary>
            [EnumMember(Value = "REC")]
            RECEnum = 68,
            /// <summary>
            /// Enum REOEnum for REO
            /// </summary>
            [EnumMember(Value = "REO")]
            REOEnum = 69,
            /// <summary>
            /// Enum SAAEnum for SAA
            /// </summary>
            [EnumMember(Value = "SAA")]
            SAAEnum = 70,
            /// <summary>
            /// Enum SEVEnum for SEV
            /// </summary>
            [EnumMember(Value = "SEV")]
            SEVEnum = 71,
            /// <summary>
            /// Enum SHNEnum for SHN
            /// </summary>
            [EnumMember(Value = "SHN")]
            SHNEnum = 72,
            /// <summary>
            /// Enum SIKEnum for SIK
            /// </summary>
            [EnumMember(Value = "SIK")]
            SIKEnum = 73,
            /// <summary>
            /// Enum SOUEnum for SOU
            /// </summary>
            [EnumMember(Value = "SOU")]
            SOUEnum = 74,
            /// <summary>
            /// Enum SPIEnum for SPI
            /// </summary>
            [EnumMember(Value = "SPI")]
            SPIEnum = 75,
            /// <summary>
            /// Enum UCCEnum for UCC
            /// </summary>
            [EnumMember(Value = "UCC")]
            UCCEnum = 76,
            /// <summary>
            /// Enum UMDEnum for UMD
            /// </summary>
            [EnumMember(Value = "UMD")]
            UMDEnum = 77,
            /// <summary>
            /// Enum UNIEnum for UNI
            /// </summary>
            [EnumMember(Value = "UNI")]
            UNIEnum = 78,
            /// <summary>
            /// Enum UNUEnum for UNU
            /// </summary>
            [EnumMember(Value = "UNU")]
            UNUEnum = 79,
            /// <summary>
            /// Enum VAREnum for VAR
            /// </summary>
            [EnumMember(Value = "VAR")]
            VAREnum = 80,
            /// <summary>
            /// Enum WESEnum for WES
            /// </summary>
            [EnumMember(Value = "WES")]
            WESEnum = 81,
            /// <summary>
            /// Enum WMCEnum for WMC
            /// </summary>
            [EnumMember(Value = "WMC")]
            WMCEnum = 82        }
}
