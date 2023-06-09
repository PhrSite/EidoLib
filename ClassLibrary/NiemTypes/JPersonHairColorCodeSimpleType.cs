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
        /// A data type for a code set identifying a hair color of a person.
        /// </summary>
        /// <value>A data type for a code set identifying a hair color of a person.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JPersonHairColorCodeSimpleType
        {
            /// <summary>
            /// Enum BaldEnum for Bald
            /// </summary>
            [EnumMember(Value = "Bald")]
            BaldEnum = 0,
            /// <summary>
            /// Enum BlackEnum for Black
            /// </summary>
            [EnumMember(Value = "Black")]
            BlackEnum = 1,
            /// <summary>
            /// Enum BlondeOrStrawberryEnum for Blonde or Strawberry
            /// </summary>
            [EnumMember(Value = "Blonde or Strawberry")]
            BlondeOrStrawberryEnum = 2,
            /// <summary>
            /// Enum BlueEnum for Blue
            /// </summary>
            [EnumMember(Value = "Blue")]
            BlueEnum = 3,
            /// <summary>
            /// Enum BrownEnum for Brown
            /// </summary>
            [EnumMember(Value = "Brown")]
            BrownEnum = 4,
            /// <summary>
            /// Enum GrayOrPartiallyGrayEnum for Gray or Partially Gray
            /// </summary>
            [EnumMember(Value = "Gray or Partially Gray")]
            GrayOrPartiallyGrayEnum = 5,
            /// <summary>
            /// Enum GreenEnum for Green
            /// </summary>
            [EnumMember(Value = "Green")]
            GreenEnum = 6,
            /// <summary>
            /// Enum OrangeEnum for Orange
            /// </summary>
            [EnumMember(Value = "Orange")]
            OrangeEnum = 7,
            /// <summary>
            /// Enum PinkEnum for Pink
            /// </summary>
            [EnumMember(Value = "Pink")]
            PinkEnum = 8,
            /// <summary>
            /// Enum PurpleEnum for Purple
            /// </summary>
            [EnumMember(Value = "Purple")]
            PurpleEnum = 9,
            /// <summary>
            /// Enum RedOrAuburnEnum for Red or Auburn
            /// </summary>
            [EnumMember(Value = "Red or Auburn")]
            RedOrAuburnEnum = 10,
            /// <summary>
            /// Enum SandyEnum for Sandy
            /// </summary>
            [EnumMember(Value = "Sandy")]
            SandyEnum = 11,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 12,
            /// <summary>
            /// Enum WhiteEnum for White
            /// </summary>
            [EnumMember(Value = "White")]
            WhiteEnum = 13        }
}
