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
        /// A data type for a kind of technique for processing latent friction ridge impressions
        /// </summary>
        /// <value>A data type for a kind of technique for processing latent friction ridge impressions</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomLatentProcessingCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum _12IEnum for 12I
            /// </summary>
            [EnumMember(Value = "12I")]
            _12IEnum = 0,
            /// <summary>
            /// Enum ADXEnum for ADX
            /// </summary>
            [EnumMember(Value = "ADX")]
            ADXEnum = 1,
            /// <summary>
            /// Enum ALSEnum for ALS
            /// </summary>
            [EnumMember(Value = "ALS")]
            ALSEnum = 2,
            /// <summary>
            /// Enum AMBEnum for AMB
            /// </summary>
            [EnumMember(Value = "AMB")]
            AMBEnum = 3,
            /// <summary>
            /// Enum AY7Enum for AY7
            /// </summary>
            [EnumMember(Value = "AY7")]
            AY7Enum = 4,
            /// <summary>
            /// Enum BAREnum for BAR
            /// </summary>
            [EnumMember(Value = "BAR")]
            BAREnum = 5,
            /// <summary>
            /// Enum BLEEnum for BLE
            /// </summary>
            [EnumMember(Value = "BLE")]
            BLEEnum = 6,
            /// <summary>
            /// Enum BLPEnum for BLP
            /// </summary>
            [EnumMember(Value = "BLP")]
            BLPEnum = 7,
            /// <summary>
            /// Enum BPAEnum for BPA
            /// </summary>
            [EnumMember(Value = "BPA")]
            BPAEnum = 8,
            /// <summary>
            /// Enum BRYEnum for BRY
            /// </summary>
            [EnumMember(Value = "BRY")]
            BRYEnum = 9,
            /// <summary>
            /// Enum CBBEnum for CBB
            /// </summary>
            [EnumMember(Value = "CBB")]
            CBBEnum = 10,
            /// <summary>
            /// Enum CDSEnum for CDS
            /// </summary>
            [EnumMember(Value = "CDS")]
            CDSEnum = 11,
            /// <summary>
            /// Enum COGEnum for COG
            /// </summary>
            [EnumMember(Value = "COG")]
            COGEnum = 12,
            /// <summary>
            /// Enum DABEnum for DAB
            /// </summary>
            [EnumMember(Value = "DAB")]
            DABEnum = 13,
            /// <summary>
            /// Enum DFOEnum for DFO
            /// </summary>
            [EnumMember(Value = "DFO")]
            DFOEnum = 14,
            /// <summary>
            /// Enum FLPEnum for FLP
            /// </summary>
            [EnumMember(Value = "FLP")]
            FLPEnum = 15,
            /// <summary>
            /// Enum GENEnum for GEN
            /// </summary>
            [EnumMember(Value = "GEN")]
            GENEnum = 16,
            /// <summary>
            /// Enum GRPEnum for GRP
            /// </summary>
            [EnumMember(Value = "GRP")]
            GRPEnum = 17,
            /// <summary>
            /// Enum GTVEnum for GTV
            /// </summary>
            [EnumMember(Value = "GTV")]
            GTVEnum = 18,
            /// <summary>
            /// Enum HCAEnum for HCA
            /// </summary>
            [EnumMember(Value = "HCA")]
            HCAEnum = 19,
            /// <summary>
            /// Enum IODEnum for IOD
            /// </summary>
            [EnumMember(Value = "IOD")]
            IODEnum = 20,
            /// <summary>
            /// Enum ISREnum for ISR
            /// </summary>
            [EnumMember(Value = "ISR")]
            ISREnum = 21,
            /// <summary>
            /// Enum LASEnum for LAS
            /// </summary>
            [EnumMember(Value = "LAS")]
            LASEnum = 22,
            /// <summary>
            /// Enum LCVEnum for LCV
            /// </summary>
            [EnumMember(Value = "LCV")]
            LCVEnum = 23,
            /// <summary>
            /// Enum LIQEnum for LIQ
            /// </summary>
            [EnumMember(Value = "LIQ")]
            LIQEnum = 24,
            /// <summary>
            /// Enum LQDEnum for LQD
            /// </summary>
            [EnumMember(Value = "LQD")]
            LQDEnum = 25,
            /// <summary>
            /// Enum MBDEnum for MBD
            /// </summary>
            [EnumMember(Value = "MBD")]
            MBDEnum = 26,
            /// <summary>
            /// Enum MBPEnum for MBP
            /// </summary>
            [EnumMember(Value = "MBP")]
            MBPEnum = 27,
            /// <summary>
            /// Enum MGPEnum for MGP
            /// </summary>
            [EnumMember(Value = "MGP")]
            MGPEnum = 28,
            /// <summary>
            /// Enum MPDEnum for MPD
            /// </summary>
            [EnumMember(Value = "MPD")]
            MPDEnum = 29,
            /// <summary>
            /// Enum MRMEnum for MRM
            /// </summary>
            [EnumMember(Value = "MRM")]
            MRMEnum = 30,
            /// <summary>
            /// Enum NINEnum for NIN
            /// </summary>
            [EnumMember(Value = "NIN")]
            NINEnum = 31,
            /// <summary>
            /// Enum OTHEnum for OTH
            /// </summary>
            [EnumMember(Value = "OTH")]
            OTHEnum = 32,
            /// <summary>
            /// Enum PDVEnum for PDV
            /// </summary>
            [EnumMember(Value = "PDV")]
            PDVEnum = 33,
            /// <summary>
            /// Enum R6GEnum for R6G
            /// </summary>
            [EnumMember(Value = "R6G")]
            R6GEnum = 34,
            /// <summary>
            /// Enum RAMEnum for RAM
            /// </summary>
            [EnumMember(Value = "RAM")]
            RAMEnum = 35,
            /// <summary>
            /// Enum RUVEnum for RUV
            /// </summary>
            [EnumMember(Value = "RUV")]
            RUVEnum = 36,
            /// <summary>
            /// Enum SAOEnum for SAO
            /// </summary>
            [EnumMember(Value = "SAO")]
            SAOEnum = 37,
            /// <summary>
            /// Enum SDBEnum for SDB
            /// </summary>
            [EnumMember(Value = "SDB")]
            SDBEnum = 38,
            /// <summary>
            /// Enum SGFEnum for SGF
            /// </summary>
            [EnumMember(Value = "SGF")]
            SGFEnum = 39,
            /// <summary>
            /// Enum SPREnum for SPR
            /// </summary>
            [EnumMember(Value = "SPR")]
            SPREnum = 40,
            /// <summary>
            /// Enum SSPEnum for SSP
            /// </summary>
            [EnumMember(Value = "SSP")]
            SSPEnum = 41,
            /// <summary>
            /// Enum SVNEnum for SVN
            /// </summary>
            [EnumMember(Value = "SVN")]
            SVNEnum = 42,
            /// <summary>
            /// Enum TECEnum for TEC
            /// </summary>
            [EnumMember(Value = "TEC")]
            TECEnum = 43,
            /// <summary>
            /// Enum TIDEnum for TID
            /// </summary>
            [EnumMember(Value = "TID")]
            TIDEnum = 44,
            /// <summary>
            /// Enum VISEnum for VIS
            /// </summary>
            [EnumMember(Value = "VIS")]
            VISEnum = 45,
            /// <summary>
            /// Enum WHPEnum for WHP
            /// </summary>
            [EnumMember(Value = "WHP")]
            WHPEnum = 46,
            /// <summary>
            /// Enum ZICEnum for ZIC
            /// </summary>
            [EnumMember(Value = "ZIC")]
            ZICEnum = 47        }
}
