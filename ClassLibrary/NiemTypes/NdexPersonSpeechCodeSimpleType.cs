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
        /// A data type for a code that identifies impediments that affect a person's speech or other speech characteristics that may help distinguish a person.
        /// </summary>
        /// <value>A data type for a code that identifies impediments that affect a person's speech or other speech characteristics that may help distinguish a person.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexPersonSpeechCodeSimpleType
        {
            /// <summary>
            /// Enum ACCENTEnum for ACCENT
            /// </summary>
            [EnumMember(Value = "ACCENT")]
            ACCENTEnum = 0,
            /// <summary>
            /// Enum DISGUISEDEnum for DISGUISED
            /// </summary>
            [EnumMember(Value = "DISGUISED")]
            DISGUISEDEnum = 1,
            /// <summary>
            /// Enum FOREIGNEnum for FOREIGN
            /// </summary>
            [EnumMember(Value = "FOREIGN")]
            FOREIGNEnum = 2,
            /// <summary>
            /// Enum HIGHPITCHEnum for HIGH PITCH
            /// </summary>
            [EnumMember(Value = "HIGH PITCH")]
            HIGHPITCHEnum = 3,
            /// <summary>
            /// Enum LISPSEnum for LISPS
            /// </summary>
            [EnumMember(Value = "LISPS")]
            LISPSEnum = 4,
            /// <summary>
            /// Enum LOUDEnum for LOUD
            /// </summary>
            [EnumMember(Value = "LOUD")]
            LOUDEnum = 5,
            /// <summary>
            /// Enum LOWPITCHEnum for LOW PITCH
            /// </summary>
            [EnumMember(Value = "LOW PITCH")]
            LOWPITCHEnum = 6,
            /// <summary>
            /// Enum MEDIUMEnum for MEDIUM
            /// </summary>
            [EnumMember(Value = "MEDIUM")]
            MEDIUMEnum = 7,
            /// <summary>
            /// Enum MONOTONEEnum for MONOTONE
            /// </summary>
            [EnumMember(Value = "MONOTONE")]
            MONOTONEEnum = 8,
            /// <summary>
            /// Enum MUMBLESEnum for MUMBLES
            /// </summary>
            [EnumMember(Value = "MUMBLES")]
            MUMBLESEnum = 9,
            /// <summary>
            /// Enum NASALEnum for NASAL
            /// </summary>
            [EnumMember(Value = "NASAL")]
            NASALEnum = 10,
            /// <summary>
            /// Enum NORMALEnum for NORMAL
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMALEnum = 11,
            /// <summary>
            /// Enum OFFENSIVEEnum for OFFENSIVE
            /// </summary>
            [EnumMember(Value = "OFFENSIVE")]
            OFFENSIVEEnum = 12,
            /// <summary>
            /// Enum QUIETEnum for QUIET
            /// </summary>
            [EnumMember(Value = "QUIET")]
            QUIETEnum = 13,
            /// <summary>
            /// Enum RAPIDEnum for RAPID
            /// </summary>
            [EnumMember(Value = "RAPID")]
            RAPIDEnum = 14,
            /// <summary>
            /// Enum RASPYEnum for RASPY
            /// </summary>
            [EnumMember(Value = "RASPY")]
            RASPYEnum = 15,
            /// <summary>
            /// Enum SLOWEnum for SLOW
            /// </summary>
            [EnumMember(Value = "SLOW")]
            SLOWEnum = 16,
            /// <summary>
            /// Enum SLURREDEnum for SLURRED
            /// </summary>
            [EnumMember(Value = "SLURRED")]
            SLURREDEnum = 17,
            /// <summary>
            /// Enum SOFTLOWEnum for SOFT_LOW
            /// </summary>
            [EnumMember(Value = "SOFT_LOW")]
            SOFTLOWEnum = 18,
            /// <summary>
            /// Enum STREETTALKEnum for STREET TALK
            /// </summary>
            [EnumMember(Value = "STREET TALK")]
            STREETTALKEnum = 19,
            /// <summary>
            /// Enum STUTTERSEnum for STUTTERS
            /// </summary>
            [EnumMember(Value = "STUTTERS")]
            STUTTERSEnum = 20,
            /// <summary>
            /// Enum TALKATIVEEnum for TALKATIVE
            /// </summary>
            [EnumMember(Value = "TALKATIVE")]
            TALKATIVEEnum = 21,
            /// <summary>
            /// Enum UNKNOWNEnum for UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWNEnum = 22,
            /// <summary>
            /// Enum VULGARPROFANEEnum for VULGAR_PROFANE
            /// </summary>
            [EnumMember(Value = "VULGAR_PROFANE")]
            VULGARPROFANEEnum = 23        }
}
