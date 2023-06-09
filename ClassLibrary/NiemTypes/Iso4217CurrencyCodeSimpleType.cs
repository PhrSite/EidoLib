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
        /// A data type for a currency that qualifies a monetary amount.
        /// </summary>
        /// <value>A data type for a currency that qualifies a monetary amount.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum Iso4217CurrencyCodeSimpleType
        {
            /// <summary>
            /// Enum AEDEnum for AED
            /// </summary>
            [EnumMember(Value = "AED")]
            AEDEnum = 0,
            /// <summary>
            /// Enum AFNEnum for AFN
            /// </summary>
            [EnumMember(Value = "AFN")]
            AFNEnum = 1,
            /// <summary>
            /// Enum ALLEnum for ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALLEnum = 2,
            /// <summary>
            /// Enum AMDEnum for AMD
            /// </summary>
            [EnumMember(Value = "AMD")]
            AMDEnum = 3,
            /// <summary>
            /// Enum ANGEnum for ANG
            /// </summary>
            [EnumMember(Value = "ANG")]
            ANGEnum = 4,
            /// <summary>
            /// Enum AOAEnum for AOA
            /// </summary>
            [EnumMember(Value = "AOA")]
            AOAEnum = 5,
            /// <summary>
            /// Enum ARSEnum for ARS
            /// </summary>
            [EnumMember(Value = "ARS")]
            ARSEnum = 6,
            /// <summary>
            /// Enum AUDEnum for AUD
            /// </summary>
            [EnumMember(Value = "AUD")]
            AUDEnum = 7,
            /// <summary>
            /// Enum AWGEnum for AWG
            /// </summary>
            [EnumMember(Value = "AWG")]
            AWGEnum = 8,
            /// <summary>
            /// Enum AZNEnum for AZN
            /// </summary>
            [EnumMember(Value = "AZN")]
            AZNEnum = 9,
            /// <summary>
            /// Enum BAMEnum for BAM
            /// </summary>
            [EnumMember(Value = "BAM")]
            BAMEnum = 10,
            /// <summary>
            /// Enum BBDEnum for BBD
            /// </summary>
            [EnumMember(Value = "BBD")]
            BBDEnum = 11,
            /// <summary>
            /// Enum BDTEnum for BDT
            /// </summary>
            [EnumMember(Value = "BDT")]
            BDTEnum = 12,
            /// <summary>
            /// Enum BGNEnum for BGN
            /// </summary>
            [EnumMember(Value = "BGN")]
            BGNEnum = 13,
            /// <summary>
            /// Enum BHDEnum for BHD
            /// </summary>
            [EnumMember(Value = "BHD")]
            BHDEnum = 14,
            /// <summary>
            /// Enum BIFEnum for BIF
            /// </summary>
            [EnumMember(Value = "BIF")]
            BIFEnum = 15,
            /// <summary>
            /// Enum BMDEnum for BMD
            /// </summary>
            [EnumMember(Value = "BMD")]
            BMDEnum = 16,
            /// <summary>
            /// Enum BNDEnum for BND
            /// </summary>
            [EnumMember(Value = "BND")]
            BNDEnum = 17,
            /// <summary>
            /// Enum BOBEnum for BOB
            /// </summary>
            [EnumMember(Value = "BOB")]
            BOBEnum = 18,
            /// <summary>
            /// Enum BOVEnum for BOV
            /// </summary>
            [EnumMember(Value = "BOV")]
            BOVEnum = 19,
            /// <summary>
            /// Enum BRLEnum for BRL
            /// </summary>
            [EnumMember(Value = "BRL")]
            BRLEnum = 20,
            /// <summary>
            /// Enum BSDEnum for BSD
            /// </summary>
            [EnumMember(Value = "BSD")]
            BSDEnum = 21,
            /// <summary>
            /// Enum BTNEnum for BTN
            /// </summary>
            [EnumMember(Value = "BTN")]
            BTNEnum = 22,
            /// <summary>
            /// Enum BWPEnum for BWP
            /// </summary>
            [EnumMember(Value = "BWP")]
            BWPEnum = 23,
            /// <summary>
            /// Enum BYREnum for BYR
            /// </summary>
            [EnumMember(Value = "BYR")]
            BYREnum = 24,
            /// <summary>
            /// Enum BZDEnum for BZD
            /// </summary>
            [EnumMember(Value = "BZD")]
            BZDEnum = 25,
            /// <summary>
            /// Enum CADEnum for CAD
            /// </summary>
            [EnumMember(Value = "CAD")]
            CADEnum = 26,
            /// <summary>
            /// Enum CDFEnum for CDF
            /// </summary>
            [EnumMember(Value = "CDF")]
            CDFEnum = 27,
            /// <summary>
            /// Enum CHEEnum for CHE
            /// </summary>
            [EnumMember(Value = "CHE")]
            CHEEnum = 28,
            /// <summary>
            /// Enum CHFEnum for CHF
            /// </summary>
            [EnumMember(Value = "CHF")]
            CHFEnum = 29,
            /// <summary>
            /// Enum CHWEnum for CHW
            /// </summary>
            [EnumMember(Value = "CHW")]
            CHWEnum = 30,
            /// <summary>
            /// Enum CLFEnum for CLF
            /// </summary>
            [EnumMember(Value = "CLF")]
            CLFEnum = 31,
            /// <summary>
            /// Enum CLPEnum for CLP
            /// </summary>
            [EnumMember(Value = "CLP")]
            CLPEnum = 32,
            /// <summary>
            /// Enum CNYEnum for CNY
            /// </summary>
            [EnumMember(Value = "CNY")]
            CNYEnum = 33,
            /// <summary>
            /// Enum COPEnum for COP
            /// </summary>
            [EnumMember(Value = "COP")]
            COPEnum = 34,
            /// <summary>
            /// Enum COUEnum for COU
            /// </summary>
            [EnumMember(Value = "COU")]
            COUEnum = 35,
            /// <summary>
            /// Enum CRCEnum for CRC
            /// </summary>
            [EnumMember(Value = "CRC")]
            CRCEnum = 36,
            /// <summary>
            /// Enum CUCEnum for CUC
            /// </summary>
            [EnumMember(Value = "CUC")]
            CUCEnum = 37,
            /// <summary>
            /// Enum CUPEnum for CUP
            /// </summary>
            [EnumMember(Value = "CUP")]
            CUPEnum = 38,
            /// <summary>
            /// Enum CVEEnum for CVE
            /// </summary>
            [EnumMember(Value = "CVE")]
            CVEEnum = 39,
            /// <summary>
            /// Enum CZKEnum for CZK
            /// </summary>
            [EnumMember(Value = "CZK")]
            CZKEnum = 40,
            /// <summary>
            /// Enum DJFEnum for DJF
            /// </summary>
            [EnumMember(Value = "DJF")]
            DJFEnum = 41,
            /// <summary>
            /// Enum DKKEnum for DKK
            /// </summary>
            [EnumMember(Value = "DKK")]
            DKKEnum = 42,
            /// <summary>
            /// Enum DOPEnum for DOP
            /// </summary>
            [EnumMember(Value = "DOP")]
            DOPEnum = 43,
            /// <summary>
            /// Enum DZDEnum for DZD
            /// </summary>
            [EnumMember(Value = "DZD")]
            DZDEnum = 44,
            /// <summary>
            /// Enum EGPEnum for EGP
            /// </summary>
            [EnumMember(Value = "EGP")]
            EGPEnum = 45,
            /// <summary>
            /// Enum ERNEnum for ERN
            /// </summary>
            [EnumMember(Value = "ERN")]
            ERNEnum = 46,
            /// <summary>
            /// Enum ETBEnum for ETB
            /// </summary>
            [EnumMember(Value = "ETB")]
            ETBEnum = 47,
            /// <summary>
            /// Enum EUREnum for EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUREnum = 48,
            /// <summary>
            /// Enum FJDEnum for FJD
            /// </summary>
            [EnumMember(Value = "FJD")]
            FJDEnum = 49,
            /// <summary>
            /// Enum FKPEnum for FKP
            /// </summary>
            [EnumMember(Value = "FKP")]
            FKPEnum = 50,
            /// <summary>
            /// Enum GBPEnum for GBP
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBPEnum = 51,
            /// <summary>
            /// Enum GELEnum for GEL
            /// </summary>
            [EnumMember(Value = "GEL")]
            GELEnum = 52,
            /// <summary>
            /// Enum GHSEnum for GHS
            /// </summary>
            [EnumMember(Value = "GHS")]
            GHSEnum = 53,
            /// <summary>
            /// Enum GIPEnum for GIP
            /// </summary>
            [EnumMember(Value = "GIP")]
            GIPEnum = 54,
            /// <summary>
            /// Enum GMDEnum for GMD
            /// </summary>
            [EnumMember(Value = "GMD")]
            GMDEnum = 55,
            /// <summary>
            /// Enum GNFEnum for GNF
            /// </summary>
            [EnumMember(Value = "GNF")]
            GNFEnum = 56,
            /// <summary>
            /// Enum GTQEnum for GTQ
            /// </summary>
            [EnumMember(Value = "GTQ")]
            GTQEnum = 57,
            /// <summary>
            /// Enum GYDEnum for GYD
            /// </summary>
            [EnumMember(Value = "GYD")]
            GYDEnum = 58,
            /// <summary>
            /// Enum HKDEnum for HKD
            /// </summary>
            [EnumMember(Value = "HKD")]
            HKDEnum = 59,
            /// <summary>
            /// Enum HNLEnum for HNL
            /// </summary>
            [EnumMember(Value = "HNL")]
            HNLEnum = 60,
            /// <summary>
            /// Enum HRKEnum for HRK
            /// </summary>
            [EnumMember(Value = "HRK")]
            HRKEnum = 61,
            /// <summary>
            /// Enum HTGEnum for HTG
            /// </summary>
            [EnumMember(Value = "HTG")]
            HTGEnum = 62,
            /// <summary>
            /// Enum HUFEnum for HUF
            /// </summary>
            [EnumMember(Value = "HUF")]
            HUFEnum = 63,
            /// <summary>
            /// Enum IDREnum for IDR
            /// </summary>
            [EnumMember(Value = "IDR")]
            IDREnum = 64,
            /// <summary>
            /// Enum ILSEnum for ILS
            /// </summary>
            [EnumMember(Value = "ILS")]
            ILSEnum = 65,
            /// <summary>
            /// Enum INREnum for INR
            /// </summary>
            [EnumMember(Value = "INR")]
            INREnum = 66,
            /// <summary>
            /// Enum IQDEnum for IQD
            /// </summary>
            [EnumMember(Value = "IQD")]
            IQDEnum = 67,
            /// <summary>
            /// Enum IRREnum for IRR
            /// </summary>
            [EnumMember(Value = "IRR")]
            IRREnum = 68,
            /// <summary>
            /// Enum ISKEnum for ISK
            /// </summary>
            [EnumMember(Value = "ISK")]
            ISKEnum = 69,
            /// <summary>
            /// Enum JMDEnum for JMD
            /// </summary>
            [EnumMember(Value = "JMD")]
            JMDEnum = 70,
            /// <summary>
            /// Enum JODEnum for JOD
            /// </summary>
            [EnumMember(Value = "JOD")]
            JODEnum = 71,
            /// <summary>
            /// Enum JPYEnum for JPY
            /// </summary>
            [EnumMember(Value = "JPY")]
            JPYEnum = 72,
            /// <summary>
            /// Enum KESEnum for KES
            /// </summary>
            [EnumMember(Value = "KES")]
            KESEnum = 73,
            /// <summary>
            /// Enum KGSEnum for KGS
            /// </summary>
            [EnumMember(Value = "KGS")]
            KGSEnum = 74,
            /// <summary>
            /// Enum KHREnum for KHR
            /// </summary>
            [EnumMember(Value = "KHR")]
            KHREnum = 75,
            /// <summary>
            /// Enum KMFEnum for KMF
            /// </summary>
            [EnumMember(Value = "KMF")]
            KMFEnum = 76,
            /// <summary>
            /// Enum KPWEnum for KPW
            /// </summary>
            [EnumMember(Value = "KPW")]
            KPWEnum = 77,
            /// <summary>
            /// Enum KRWEnum for KRW
            /// </summary>
            [EnumMember(Value = "KRW")]
            KRWEnum = 78,
            /// <summary>
            /// Enum KWDEnum for KWD
            /// </summary>
            [EnumMember(Value = "KWD")]
            KWDEnum = 79,
            /// <summary>
            /// Enum KYDEnum for KYD
            /// </summary>
            [EnumMember(Value = "KYD")]
            KYDEnum = 80,
            /// <summary>
            /// Enum KZTEnum for KZT
            /// </summary>
            [EnumMember(Value = "KZT")]
            KZTEnum = 81,
            /// <summary>
            /// Enum LAKEnum for LAK
            /// </summary>
            [EnumMember(Value = "LAK")]
            LAKEnum = 82,
            /// <summary>
            /// Enum LBPEnum for LBP
            /// </summary>
            [EnumMember(Value = "LBP")]
            LBPEnum = 83,
            /// <summary>
            /// Enum LKREnum for LKR
            /// </summary>
            [EnumMember(Value = "LKR")]
            LKREnum = 84,
            /// <summary>
            /// Enum LRDEnum for LRD
            /// </summary>
            [EnumMember(Value = "LRD")]
            LRDEnum = 85,
            /// <summary>
            /// Enum LSLEnum for LSL
            /// </summary>
            [EnumMember(Value = "LSL")]
            LSLEnum = 86,
            /// <summary>
            /// Enum LTLEnum for LTL
            /// </summary>
            [EnumMember(Value = "LTL")]
            LTLEnum = 87,
            /// <summary>
            /// Enum LVLEnum for LVL
            /// </summary>
            [EnumMember(Value = "LVL")]
            LVLEnum = 88,
            /// <summary>
            /// Enum LYDEnum for LYD
            /// </summary>
            [EnumMember(Value = "LYD")]
            LYDEnum = 89,
            /// <summary>
            /// Enum MADEnum for MAD
            /// </summary>
            [EnumMember(Value = "MAD")]
            MADEnum = 90,
            /// <summary>
            /// Enum MDLEnum for MDL
            /// </summary>
            [EnumMember(Value = "MDL")]
            MDLEnum = 91,
            /// <summary>
            /// Enum MGAEnum for MGA
            /// </summary>
            [EnumMember(Value = "MGA")]
            MGAEnum = 92,
            /// <summary>
            /// Enum MKDEnum for MKD
            /// </summary>
            [EnumMember(Value = "MKD")]
            MKDEnum = 93,
            /// <summary>
            /// Enum MMKEnum for MMK
            /// </summary>
            [EnumMember(Value = "MMK")]
            MMKEnum = 94,
            /// <summary>
            /// Enum MNTEnum for MNT
            /// </summary>
            [EnumMember(Value = "MNT")]
            MNTEnum = 95,
            /// <summary>
            /// Enum MOPEnum for MOP
            /// </summary>
            [EnumMember(Value = "MOP")]
            MOPEnum = 96,
            /// <summary>
            /// Enum MROEnum for MRO
            /// </summary>
            [EnumMember(Value = "MRO")]
            MROEnum = 97,
            /// <summary>
            /// Enum MUREnum for MUR
            /// </summary>
            [EnumMember(Value = "MUR")]
            MUREnum = 98,
            /// <summary>
            /// Enum MVREnum for MVR
            /// </summary>
            [EnumMember(Value = "MVR")]
            MVREnum = 99,
            /// <summary>
            /// Enum MWKEnum for MWK
            /// </summary>
            [EnumMember(Value = "MWK")]
            MWKEnum = 100,
            /// <summary>
            /// Enum MXNEnum for MXN
            /// </summary>
            [EnumMember(Value = "MXN")]
            MXNEnum = 101,
            /// <summary>
            /// Enum MXVEnum for MXV
            /// </summary>
            [EnumMember(Value = "MXV")]
            MXVEnum = 102,
            /// <summary>
            /// Enum MYREnum for MYR
            /// </summary>
            [EnumMember(Value = "MYR")]
            MYREnum = 103,
            /// <summary>
            /// Enum MZNEnum for MZN
            /// </summary>
            [EnumMember(Value = "MZN")]
            MZNEnum = 104,
            /// <summary>
            /// Enum NADEnum for NAD
            /// </summary>
            [EnumMember(Value = "NAD")]
            NADEnum = 105,
            /// <summary>
            /// Enum NGNEnum for NGN
            /// </summary>
            [EnumMember(Value = "NGN")]
            NGNEnum = 106,
            /// <summary>
            /// Enum NIOEnum for NIO
            /// </summary>
            [EnumMember(Value = "NIO")]
            NIOEnum = 107,
            /// <summary>
            /// Enum NOKEnum for NOK
            /// </summary>
            [EnumMember(Value = "NOK")]
            NOKEnum = 108,
            /// <summary>
            /// Enum NPREnum for NPR
            /// </summary>
            [EnumMember(Value = "NPR")]
            NPREnum = 109,
            /// <summary>
            /// Enum NZDEnum for NZD
            /// </summary>
            [EnumMember(Value = "NZD")]
            NZDEnum = 110,
            /// <summary>
            /// Enum OMREnum for OMR
            /// </summary>
            [EnumMember(Value = "OMR")]
            OMREnum = 111,
            /// <summary>
            /// Enum PABEnum for PAB
            /// </summary>
            [EnumMember(Value = "PAB")]
            PABEnum = 112,
            /// <summary>
            /// Enum PENEnum for PEN
            /// </summary>
            [EnumMember(Value = "PEN")]
            PENEnum = 113,
            /// <summary>
            /// Enum PGKEnum for PGK
            /// </summary>
            [EnumMember(Value = "PGK")]
            PGKEnum = 114,
            /// <summary>
            /// Enum PHPEnum for PHP
            /// </summary>
            [EnumMember(Value = "PHP")]
            PHPEnum = 115,
            /// <summary>
            /// Enum PKREnum for PKR
            /// </summary>
            [EnumMember(Value = "PKR")]
            PKREnum = 116,
            /// <summary>
            /// Enum PLNEnum for PLN
            /// </summary>
            [EnumMember(Value = "PLN")]
            PLNEnum = 117,
            /// <summary>
            /// Enum PYGEnum for PYG
            /// </summary>
            [EnumMember(Value = "PYG")]
            PYGEnum = 118,
            /// <summary>
            /// Enum QAREnum for QAR
            /// </summary>
            [EnumMember(Value = "QAR")]
            QAREnum = 119,
            /// <summary>
            /// Enum RONEnum for RON
            /// </summary>
            [EnumMember(Value = "RON")]
            RONEnum = 120,
            /// <summary>
            /// Enum RSDEnum for RSD
            /// </summary>
            [EnumMember(Value = "RSD")]
            RSDEnum = 121,
            /// <summary>
            /// Enum RUBEnum for RUB
            /// </summary>
            [EnumMember(Value = "RUB")]
            RUBEnum = 122,
            /// <summary>
            /// Enum RWFEnum for RWF
            /// </summary>
            [EnumMember(Value = "RWF")]
            RWFEnum = 123,
            /// <summary>
            /// Enum SAREnum for SAR
            /// </summary>
            [EnumMember(Value = "SAR")]
            SAREnum = 124,
            /// <summary>
            /// Enum SBDEnum for SBD
            /// </summary>
            [EnumMember(Value = "SBD")]
            SBDEnum = 125,
            /// <summary>
            /// Enum SCREnum for SCR
            /// </summary>
            [EnumMember(Value = "SCR")]
            SCREnum = 126,
            /// <summary>
            /// Enum SDGEnum for SDG
            /// </summary>
            [EnumMember(Value = "SDG")]
            SDGEnum = 127,
            /// <summary>
            /// Enum SEKEnum for SEK
            /// </summary>
            [EnumMember(Value = "SEK")]
            SEKEnum = 128,
            /// <summary>
            /// Enum SGDEnum for SGD
            /// </summary>
            [EnumMember(Value = "SGD")]
            SGDEnum = 129,
            /// <summary>
            /// Enum SHPEnum for SHP
            /// </summary>
            [EnumMember(Value = "SHP")]
            SHPEnum = 130,
            /// <summary>
            /// Enum SLLEnum for SLL
            /// </summary>
            [EnumMember(Value = "SLL")]
            SLLEnum = 131,
            /// <summary>
            /// Enum SOSEnum for SOS
            /// </summary>
            [EnumMember(Value = "SOS")]
            SOSEnum = 132,
            /// <summary>
            /// Enum SRDEnum for SRD
            /// </summary>
            [EnumMember(Value = "SRD")]
            SRDEnum = 133,
            /// <summary>
            /// Enum SSPEnum for SSP
            /// </summary>
            [EnumMember(Value = "SSP")]
            SSPEnum = 134,
            /// <summary>
            /// Enum STDEnum for STD
            /// </summary>
            [EnumMember(Value = "STD")]
            STDEnum = 135,
            /// <summary>
            /// Enum SVCEnum for SVC
            /// </summary>
            [EnumMember(Value = "SVC")]
            SVCEnum = 136,
            /// <summary>
            /// Enum SYPEnum for SYP
            /// </summary>
            [EnumMember(Value = "SYP")]
            SYPEnum = 137,
            /// <summary>
            /// Enum SZLEnum for SZL
            /// </summary>
            [EnumMember(Value = "SZL")]
            SZLEnum = 138,
            /// <summary>
            /// Enum THBEnum for THB
            /// </summary>
            [EnumMember(Value = "THB")]
            THBEnum = 139,
            /// <summary>
            /// Enum TJSEnum for TJS
            /// </summary>
            [EnumMember(Value = "TJS")]
            TJSEnum = 140,
            /// <summary>
            /// Enum TMTEnum for TMT
            /// </summary>
            [EnumMember(Value = "TMT")]
            TMTEnum = 141,
            /// <summary>
            /// Enum TNDEnum for TND
            /// </summary>
            [EnumMember(Value = "TND")]
            TNDEnum = 142,
            /// <summary>
            /// Enum TOPEnum for TOP
            /// </summary>
            [EnumMember(Value = "TOP")]
            TOPEnum = 143,
            /// <summary>
            /// Enum TRYEnum for TRY
            /// </summary>
            [EnumMember(Value = "TRY")]
            TRYEnum = 144,
            /// <summary>
            /// Enum TTDEnum for TTD
            /// </summary>
            [EnumMember(Value = "TTD")]
            TTDEnum = 145,
            /// <summary>
            /// Enum TWDEnum for TWD
            /// </summary>
            [EnumMember(Value = "TWD")]
            TWDEnum = 146,
            /// <summary>
            /// Enum TZSEnum for TZS
            /// </summary>
            [EnumMember(Value = "TZS")]
            TZSEnum = 147,
            /// <summary>
            /// Enum UAHEnum for UAH
            /// </summary>
            [EnumMember(Value = "UAH")]
            UAHEnum = 148,
            /// <summary>
            /// Enum UGXEnum for UGX
            /// </summary>
            [EnumMember(Value = "UGX")]
            UGXEnum = 149,
            /// <summary>
            /// Enum USDEnum for USD
            /// </summary>
            [EnumMember(Value = "USD")]
            USDEnum = 150,
            /// <summary>
            /// Enum USNEnum for USN
            /// </summary>
            [EnumMember(Value = "USN")]
            USNEnum = 151,
            /// <summary>
            /// Enum USSEnum for USS
            /// </summary>
            [EnumMember(Value = "USS")]
            USSEnum = 152,
            /// <summary>
            /// Enum UYIEnum for UYI
            /// </summary>
            [EnumMember(Value = "UYI")]
            UYIEnum = 153,
            /// <summary>
            /// Enum UYUEnum for UYU
            /// </summary>
            [EnumMember(Value = "UYU")]
            UYUEnum = 154,
            /// <summary>
            /// Enum UZSEnum for UZS
            /// </summary>
            [EnumMember(Value = "UZS")]
            UZSEnum = 155,
            /// <summary>
            /// Enum VEFEnum for VEF
            /// </summary>
            [EnumMember(Value = "VEF")]
            VEFEnum = 156,
            /// <summary>
            /// Enum VNDEnum for VND
            /// </summary>
            [EnumMember(Value = "VND")]
            VNDEnum = 157,
            /// <summary>
            /// Enum VUVEnum for VUV
            /// </summary>
            [EnumMember(Value = "VUV")]
            VUVEnum = 158,
            /// <summary>
            /// Enum WSTEnum for WST
            /// </summary>
            [EnumMember(Value = "WST")]
            WSTEnum = 159,
            /// <summary>
            /// Enum XAFEnum for XAF
            /// </summary>
            [EnumMember(Value = "XAF")]
            XAFEnum = 160,
            /// <summary>
            /// Enum XAGEnum for XAG
            /// </summary>
            [EnumMember(Value = "XAG")]
            XAGEnum = 161,
            /// <summary>
            /// Enum XAUEnum for XAU
            /// </summary>
            [EnumMember(Value = "XAU")]
            XAUEnum = 162,
            /// <summary>
            /// Enum XBAEnum for XBA
            /// </summary>
            [EnumMember(Value = "XBA")]
            XBAEnum = 163,
            /// <summary>
            /// Enum XBBEnum for XBB
            /// </summary>
            [EnumMember(Value = "XBB")]
            XBBEnum = 164,
            /// <summary>
            /// Enum XBCEnum for XBC
            /// </summary>
            [EnumMember(Value = "XBC")]
            XBCEnum = 165,
            /// <summary>
            /// Enum XBDEnum for XBD
            /// </summary>
            [EnumMember(Value = "XBD")]
            XBDEnum = 166,
            /// <summary>
            /// Enum XCDEnum for XCD
            /// </summary>
            [EnumMember(Value = "XCD")]
            XCDEnum = 167,
            /// <summary>
            /// Enum XDREnum for XDR
            /// </summary>
            [EnumMember(Value = "XDR")]
            XDREnum = 168,
            /// <summary>
            /// Enum XFUEnum for XFU
            /// </summary>
            [EnumMember(Value = "XFU")]
            XFUEnum = 169,
            /// <summary>
            /// Enum XOFEnum for XOF
            /// </summary>
            [EnumMember(Value = "XOF")]
            XOFEnum = 170,
            /// <summary>
            /// Enum XPDEnum for XPD
            /// </summary>
            [EnumMember(Value = "XPD")]
            XPDEnum = 171,
            /// <summary>
            /// Enum XPFEnum for XPF
            /// </summary>
            [EnumMember(Value = "XPF")]
            XPFEnum = 172,
            /// <summary>
            /// Enum XPTEnum for XPT
            /// </summary>
            [EnumMember(Value = "XPT")]
            XPTEnum = 173,
            /// <summary>
            /// Enum XSUEnum for XSU
            /// </summary>
            [EnumMember(Value = "XSU")]
            XSUEnum = 174,
            /// <summary>
            /// Enum XTSEnum for XTS
            /// </summary>
            [EnumMember(Value = "XTS")]
            XTSEnum = 175,
            /// <summary>
            /// Enum XUAEnum for XUA
            /// </summary>
            [EnumMember(Value = "XUA")]
            XUAEnum = 176,
            /// <summary>
            /// Enum XXXEnum for XXX
            /// </summary>
            [EnumMember(Value = "XXX")]
            XXXEnum = 177,
            /// <summary>
            /// Enum YEREnum for YER
            /// </summary>
            [EnumMember(Value = "YER")]
            YEREnum = 178,
            /// <summary>
            /// Enum ZAREnum for ZAR
            /// </summary>
            [EnumMember(Value = "ZAR")]
            ZAREnum = 179,
            /// <summary>
            /// Enum ZMWEnum for ZMW
            /// </summary>
            [EnumMember(Value = "ZMW")]
            ZMWEnum = 180,
            /// <summary>
            /// Enum ZWLEnum for ZWL
            /// </summary>
            [EnumMember(Value = "ZWL")]
            ZWLEnum = 181        }
}
