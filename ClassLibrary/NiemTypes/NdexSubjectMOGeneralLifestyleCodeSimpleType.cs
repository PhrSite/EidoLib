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
        /// A data type for a code that identifies lifestyle characteristics for the subject person based on investigator experience.
        /// </summary>
        /// <value>A data type for a code that identifies lifestyle characteristics for the subject person based on investigator experience.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexSubjectMOGeneralLifestyleCodeSimpleType
        {
            /// <summary>
            /// Enum ALCOHOLICEnum for ALCOHOLIC
            /// </summary>
            [EnumMember(Value = "ALCOHOLIC")]
            ALCOHOLICEnum = 0,
            /// <summary>
            /// Enum BISEXUALEnum for BISEXUAL
            /// </summary>
            [EnumMember(Value = "BISEXUAL")]
            BISEXUALEnum = 1,
            /// <summary>
            /// Enum DRUGSELLEREnum for DRUG SELLER
            /// </summary>
            [EnumMember(Value = "DRUG SELLER")]
            DRUGSELLEREnum = 2,
            /// <summary>
            /// Enum DRUGUSEREnum for DRUG USER
            /// </summary>
            [EnumMember(Value = "DRUG USER")]
            DRUGUSEREnum = 3,
            /// <summary>
            /// Enum HABITUALOFFENDEREnum for HABITUAL OFFENDER
            /// </summary>
            [EnumMember(Value = "HABITUAL OFFENDER")]
            HABITUALOFFENDEREnum = 4,
            /// <summary>
            /// Enum HETEROSEXUALEnum for HETEROSEXUAL
            /// </summary>
            [EnumMember(Value = "HETEROSEXUAL")]
            HETEROSEXUALEnum = 5,
            /// <summary>
            /// Enum HITCHHIKEREnum for HITCHHIKER
            /// </summary>
            [EnumMember(Value = "HITCHHIKER")]
            HITCHHIKEREnum = 6,
            /// <summary>
            /// Enum HOMOSEXUALEnum for HOMOSEXUAL
            /// </summary>
            [EnumMember(Value = "HOMOSEXUAL")]
            HOMOSEXUALEnum = 7,
            /// <summary>
            /// Enum LONEREnum for LONER
            /// </summary>
            [EnumMember(Value = "LONER")]
            LONEREnum = 8,
            /// <summary>
            /// Enum MENTALLYILLEnum for MENTALLY ILL
            /// </summary>
            [EnumMember(Value = "MENTALLY ILL")]
            MENTALLYILLEnum = 9,
            /// <summary>
            /// Enum PEDOPHILEEnum for PEDOPHILE
            /// </summary>
            [EnumMember(Value = "PEDOPHILE")]
            PEDOPHILEEnum = 10,
            /// <summary>
            /// Enum PIMPEnum for PIMP
            /// </summary>
            [EnumMember(Value = "PIMP")]
            PIMPEnum = 11,
            /// <summary>
            /// Enum PROSTITUTEEnum for PROSTITUTE
            /// </summary>
            [EnumMember(Value = "PROSTITUTE")]
            PROSTITUTEEnum = 12,
            /// <summary>
            /// Enum REGISTEREDSEXOFFENDEREnum for REGISTERED SEX OFFENDER
            /// </summary>
            [EnumMember(Value = "REGISTERED SEX OFFENDER")]
            REGISTEREDSEXOFFENDEREnum = 13,
            /// <summary>
            /// Enum STREETPERSONHOMELESSEnum for STREET PERSON_HOMELESS
            /// </summary>
            [EnumMember(Value = "STREET PERSON_HOMELESS")]
            STREETPERSONHOMELESSEnum = 14,
            /// <summary>
            /// Enum STUDENTEnum for STUDENT
            /// </summary>
            [EnumMember(Value = "STUDENT")]
            STUDENTEnum = 15,
            /// <summary>
            /// Enum TRANSIENTEnum for TRANSIENT
            /// </summary>
            [EnumMember(Value = "TRANSIENT")]
            TRANSIENTEnum = 16,
            /// <summary>
            /// Enum TRANSVESTITEEnum for TRANSVESTITE
            /// </summary>
            [EnumMember(Value = "TRANSVESTITE")]
            TRANSVESTITEEnum = 17,
            /// <summary>
            /// Enum UNKNOWNEnum for UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWNEnum = 18        }
}
