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
        /// A data type for a code that identifies the length of the person's hair.
        /// </summary>
        /// <value>A data type for a code that identifies the length of the person's hair.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexPersonHairLengthCodeSimpleType
        {
            /// <summary>
            /// Enum BALDBALDINGEnum for BALD_BALDING
            /// </summary>
            [EnumMember(Value = "BALD_BALDING")]
            BALDBALDINGEnum = 0,
            /// <summary>
            /// Enum LONGEnum for LONG
            /// </summary>
            [EnumMember(Value = "LONG")]
            LONGEnum = 1,
            /// <summary>
            /// Enum MEDIUMSHOULDERLENGTHEnum for MEDIUM_SHOULDER LENGTH
            /// </summary>
            [EnumMember(Value = "MEDIUM_SHOULDER LENGTH")]
            MEDIUMSHOULDERLENGTHEnum = 2,
            /// <summary>
            /// Enum SHORTCOLLARLENGTHEnum for SHORT_COLLAR LENGTH
            /// </summary>
            [EnumMember(Value = "SHORT_COLLAR LENGTH")]
            SHORTCOLLARLENGTHEnum = 3,
            /// <summary>
            /// Enum UNKNOWNEnum for UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWNEnum = 4,
            /// <summary>
            /// Enum WOREHAIRPIECEEnum for WORE HAIR PIECE
            /// </summary>
            [EnumMember(Value = "WORE HAIR PIECE")]
            WOREHAIRPIECEEnum = 5        }
}
