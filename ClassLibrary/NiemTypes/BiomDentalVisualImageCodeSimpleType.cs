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
        /// A data type for a visual image view code
        /// </summary>
        /// <value>A data type for a visual image view code</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BiomDentalVisualImageCodeSimpleType
        {
            /// <summary>
            /// Enum EFLREnum for EFLR
            /// </summary>
            [EnumMember(Value = "EFLR")]
            EFLREnum = 0,
            /// <summary>
            /// Enum EFNSEnum for EFNS
            /// </summary>
            [EnumMember(Value = "EFNS")]
            EFNSEnum = 1,
            /// <summary>
            /// Enum EFOLEnum for EFOL
            /// </summary>
            [EnumMember(Value = "EFOL")]
            EFOLEnum = 2,
            /// <summary>
            /// Enum EFOREnum for EFOR
            /// </summary>
            [EnumMember(Value = "EFOR")]
            EFOREnum = 3,
            /// <summary>
            /// Enum EFPLEnum for EFPL
            /// </summary>
            [EnumMember(Value = "EFPL")]
            EFPLEnum = 4,
            /// <summary>
            /// Enum EFPREnum for EFPR
            /// </summary>
            [EnumMember(Value = "EFPR")]
            EFPREnum = 5,
            /// <summary>
            /// Enum EFWIEnum for EFWI
            /// </summary>
            [EnumMember(Value = "EFWI")]
            EFWIEnum = 6,
            /// <summary>
            /// Enum IBLBEnum for IBLB
            /// </summary>
            [EnumMember(Value = "IBLB")]
            IBLBEnum = 7,
            /// <summary>
            /// Enum IBLLEnum for IBLL
            /// </summary>
            [EnumMember(Value = "IBLL")]
            IBLLEnum = 8,
            /// <summary>
            /// Enum IBLREnum for IBLR
            /// </summary>
            [EnumMember(Value = "IBLR")]
            IBLREnum = 9,
            /// <summary>
            /// Enum IBRBEnum for IBRB
            /// </summary>
            [EnumMember(Value = "IBRB")]
            IBRBEnum = 10,
            /// <summary>
            /// Enum IBULEnum for IBUL
            /// </summary>
            [EnumMember(Value = "IBUL")]
            IBULEnum = 11,
            /// <summary>
            /// Enum IBUREnum for IBUR
            /// </summary>
            [EnumMember(Value = "IBUR")]
            IBUREnum = 12,
            /// <summary>
            /// Enum ICLEnum for ICL
            /// </summary>
            [EnumMember(Value = "ICL")]
            ICLEnum = 13,
            /// <summary>
            /// Enum ICREnum for ICR
            /// </summary>
            [EnumMember(Value = "ICR")]
            ICREnum = 14,
            /// <summary>
            /// Enum IFJBEnum for IFJB
            /// </summary>
            [EnumMember(Value = "IFJB")]
            IFJBEnum = 15,
            /// <summary>
            /// Enum IFJLEnum for IFJL
            /// </summary>
            [EnumMember(Value = "IFJL")]
            IFJLEnum = 16,
            /// <summary>
            /// Enum IFJUEnum for IFJU
            /// </summary>
            [EnumMember(Value = "IFJU")]
            IFJUEnum = 17,
            /// <summary>
            /// Enum ILLEnum for ILL
            /// </summary>
            [EnumMember(Value = "ILL")]
            ILLEnum = 18,
            /// <summary>
            /// Enum ILLBEnum for ILLB
            /// </summary>
            [EnumMember(Value = "ILLB")]
            ILLBEnum = 19,
            /// <summary>
            /// Enum ILLFEnum for ILLF
            /// </summary>
            [EnumMember(Value = "ILLF")]
            ILLFEnum = 20,
            /// <summary>
            /// Enum ILLLEnum for ILLL
            /// </summary>
            [EnumMember(Value = "ILLL")]
            ILLLEnum = 21,
            /// <summary>
            /// Enum ILLREnum for ILLR
            /// </summary>
            [EnumMember(Value = "ILLR")]
            ILLREnum = 22,
            /// <summary>
            /// Enum ILRBEnum for ILRB
            /// </summary>
            [EnumMember(Value = "ILRB")]
            ILRBEnum = 23,
            /// <summary>
            /// Enum ILUEnum for ILU
            /// </summary>
            [EnumMember(Value = "ILU")]
            ILUEnum = 24,
            /// <summary>
            /// Enum ILUFEnum for ILUF
            /// </summary>
            [EnumMember(Value = "ILUF")]
            ILUFEnum = 25,
            /// <summary>
            /// Enum ILULEnum for ILUL
            /// </summary>
            [EnumMember(Value = "ILUL")]
            ILULEnum = 26,
            /// <summary>
            /// Enum ILUREnum for ILUR
            /// </summary>
            [EnumMember(Value = "ILUR")]
            ILUREnum = 27,
            /// <summary>
            /// Enum IOLAEnum for IOLA
            /// </summary>
            [EnumMember(Value = "IOLA")]
            IOLAEnum = 28,
            /// <summary>
            /// Enum IOLFEnum for IOLF
            /// </summary>
            [EnumMember(Value = "IOLF")]
            IOLFEnum = 29,
            /// <summary>
            /// Enum IOLLEnum for IOLL
            /// </summary>
            [EnumMember(Value = "IOLL")]
            IOLLEnum = 30,
            /// <summary>
            /// Enum IOLREnum for IOLR
            /// </summary>
            [EnumMember(Value = "IOLR")]
            IOLREnum = 31,
            /// <summary>
            /// Enum IOUAEnum for IOUA
            /// </summary>
            [EnumMember(Value = "IOUA")]
            IOUAEnum = 32,
            /// <summary>
            /// Enum IOUFEnum for IOUF
            /// </summary>
            [EnumMember(Value = "IOUF")]
            IOUFEnum = 33,
            /// <summary>
            /// Enum IOULEnum for IOUL
            /// </summary>
            [EnumMember(Value = "IOUL")]
            IOULEnum = 34,
            /// <summary>
            /// Enum IOUREnum for IOUR
            /// </summary>
            [EnumMember(Value = "IOUR")]
            IOUREnum = 35,
            /// <summary>
            /// Enum IPBEnum for IPB
            /// </summary>
            [EnumMember(Value = "IPB")]
            IPBEnum = 36,
            /// <summary>
            /// Enum IPCEnum for IPC
            /// </summary>
            [EnumMember(Value = "IPC")]
            IPCEnum = 37,
            /// <summary>
            /// Enum ITLEnum for ITL
            /// </summary>
            [EnumMember(Value = "ITL")]
            ITLEnum = 38,
            /// <summary>
            /// Enum ITUEnum for ITU
            /// </summary>
            [EnumMember(Value = "ITU")]
            ITUEnum = 39        }
}
