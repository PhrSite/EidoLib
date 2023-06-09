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
        /// A data type for a code that identifies a kind of knife.
        /// </summary>
        /// <value>A data type for a code that identifies a kind of knife.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexKnifeCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum BAYONETEnum for BAYONET
            /// </summary>
            [EnumMember(Value = "BAYONET")]
            BAYONETEnum = 0,
            /// <summary>
            /// Enum BONINGEnum for BONING
            /// </summary>
            [EnumMember(Value = "BONING")]
            BONINGEnum = 1,
            /// <summary>
            /// Enum BOWIEEnum for BOWIE
            /// </summary>
            [EnumMember(Value = "BOWIE")]
            BOWIEEnum = 2,
            /// <summary>
            /// Enum BREADEnum for BREAD
            /// </summary>
            [EnumMember(Value = "BREAD")]
            BREADEnum = 3,
            /// <summary>
            /// Enum BUCKEnum for BUCK
            /// </summary>
            [EnumMember(Value = "BUCK")]
            BUCKEnum = 4,
            /// <summary>
            /// Enum BUTCHEREnum for BUTCHER
            /// </summary>
            [EnumMember(Value = "BUTCHER")]
            BUTCHEREnum = 5,
            /// <summary>
            /// Enum BUTCHERKITCHENEnum for BUTCHER_KITCHEN
            /// </summary>
            [EnumMember(Value = "BUTCHER_KITCHEN")]
            BUTCHERKITCHENEnum = 6,
            /// <summary>
            /// Enum CARVINGEnum for CARVING
            /// </summary>
            [EnumMember(Value = "CARVING")]
            CARVINGEnum = 7,
            /// <summary>
            /// Enum CARVINGPARINGEnum for CARVING_PARING
            /// </summary>
            [EnumMember(Value = "CARVING_PARING")]
            CARVINGPARINGEnum = 8,
            /// <summary>
            /// Enum CHEFSEnum for CHEFS
            /// </summary>
            [EnumMember(Value = "CHEFS")]
            CHEFSEnum = 9,
            /// <summary>
            /// Enum CLEAVEREnum for CLEAVER
            /// </summary>
            [EnumMember(Value = "CLEAVER")]
            CLEAVEREnum = 10,
            /// <summary>
            /// Enum DAGGEREnum for DAGGER
            /// </summary>
            [EnumMember(Value = "DAGGER")]
            DAGGEREnum = 11,
            /// <summary>
            /// Enum DIRKEnum for DIRK
            /// </summary>
            [EnumMember(Value = "DIRK")]
            DIRKEnum = 12,
            /// <summary>
            /// Enum DIRKDAGGERSTILETTOEnum for DIRK_DAGGER_STILETTO
            /// </summary>
            [EnumMember(Value = "DIRK_DAGGER_STILETTO")]
            DIRKDAGGERSTILETTOEnum = 13,
            /// <summary>
            /// Enum DIVERSEnum for DIVERS
            /// </summary>
            [EnumMember(Value = "DIVERS")]
            DIVERSEnum = 14,
            /// <summary>
            /// Enum FISHFILLETEnum for FISH FILLET
            /// </summary>
            [EnumMember(Value = "FISH FILLET")]
            FISHFILLETEnum = 15,
            /// <summary>
            /// Enum FIXEDBLADEEnum for FIXED BLADE
            /// </summary>
            [EnumMember(Value = "FIXED BLADE")]
            FIXEDBLADEEnum = 16,
            /// <summary>
            /// Enum FOLDEDBLADEEnum for FOLDED BLADE
            /// </summary>
            [EnumMember(Value = "FOLDED BLADE")]
            FOLDEDBLADEEnum = 17,
            /// <summary>
            /// Enum HUNTINGEnum for HUNTING
            /// </summary>
            [EnumMember(Value = "HUNTING")]
            HUNTINGEnum = 18,
            /// <summary>
            /// Enum HUNTINGBOWIEEnum for HUNTING_BOWIE
            /// </summary>
            [EnumMember(Value = "HUNTING_BOWIE")]
            HUNTINGBOWIEEnum = 19,
            /// <summary>
            /// Enum JACKKNIFEEnum for JACKKNIFE
            /// </summary>
            [EnumMember(Value = "JACKKNIFE")]
            JACKKNIFEEnum = 20,
            /// <summary>
            /// Enum KITCHENEnum for KITCHEN
            /// </summary>
            [EnumMember(Value = "KITCHEN")]
            KITCHENEnum = 21,
            /// <summary>
            /// Enum LOCKINGBLADEEnum for LOCKING BLADE
            /// </summary>
            [EnumMember(Value = "LOCKING BLADE")]
            LOCKINGBLADEEnum = 22,
            /// <summary>
            /// Enum PARINGEnum for PARING
            /// </summary>
            [EnumMember(Value = "PARING")]
            PARINGEnum = 23,
            /// <summary>
            /// Enum POCKETEnum for POCKET
            /// </summary>
            [EnumMember(Value = "POCKET")]
            POCKETEnum = 24,
            /// <summary>
            /// Enum SIMULATEDEnum for SIMULATED
            /// </summary>
            [EnumMember(Value = "SIMULATED")]
            SIMULATEDEnum = 25,
            /// <summary>
            /// Enum STEAKEnum for STEAK
            /// </summary>
            [EnumMember(Value = "STEAK")]
            STEAKEnum = 26,
            /// <summary>
            /// Enum STILETTOEnum for STILETTO
            /// </summary>
            [EnumMember(Value = "STILETTO")]
            STILETTOEnum = 27,
            /// <summary>
            /// Enum SURVIVALEnum for SURVIVAL
            /// </summary>
            [EnumMember(Value = "SURVIVAL")]
            SURVIVALEnum = 28,
            /// <summary>
            /// Enum SWISSARMYSTYLEEnum for SWISS ARMY STYLE
            /// </summary>
            [EnumMember(Value = "SWISS ARMY STYLE")]
            SWISSARMYSTYLEEnum = 29,
            /// <summary>
            /// Enum SWITCHBLADEEnum for SWITCHBLADE
            /// </summary>
            [EnumMember(Value = "SWITCHBLADE")]
            SWITCHBLADEEnum = 30,
            /// <summary>
            /// Enum TOYEnum for TOY
            /// </summary>
            [EnumMember(Value = "TOY")]
            TOYEnum = 31,
            /// <summary>
            /// Enum USARMYSTYLEEnum for US ARMY STYLE
            /// </summary>
            [EnumMember(Value = "US ARMY STYLE")]
            USARMYSTYLEEnum = 32,
            /// <summary>
            /// Enum UTILITYEnum for UTILITY
            /// </summary>
            [EnumMember(Value = "UTILITY")]
            UTILITYEnum = 33        }
}
