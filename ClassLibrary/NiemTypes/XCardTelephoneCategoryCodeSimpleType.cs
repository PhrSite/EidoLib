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
        /// A data type for a type of telephone.
        /// </summary>
        /// <value>A data type for a type of telephone.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum XCardTelephoneCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum CellEnum for cell
            /// </summary>
            [EnumMember(Value = "cell")]
            CellEnum = 0,
            /// <summary>
            /// Enum FaxEnum for fax
            /// </summary>
            [EnumMember(Value = "fax")]
            FaxEnum = 1,
            /// <summary>
            /// Enum HomeEnum for home
            /// </summary>
            [EnumMember(Value = "home")]
            HomeEnum = 2,
            /// <summary>
            /// Enum PagerEnum for pager
            /// </summary>
            [EnumMember(Value = "pager")]
            PagerEnum = 3,
            /// <summary>
            /// Enum TextEnum for text
            /// </summary>
            [EnumMember(Value = "text")]
            TextEnum = 4,
            /// <summary>
            /// Enum TextphoneEnum for textphone
            /// </summary>
            [EnumMember(Value = "textphone")]
            TextphoneEnum = 5,
            /// <summary>
            /// Enum VideoEnum for video
            /// </summary>
            [EnumMember(Value = "video")]
            VideoEnum = 6,
            /// <summary>
            /// Enum VoiceEnum for voice
            /// </summary>
            [EnumMember(Value = "voice")]
            VoiceEnum = 7,
            /// <summary>
            /// Enum WorkEnum for work
            /// </summary>
            [EnumMember(Value = "work")]
            WorkEnum = 8        }
}
