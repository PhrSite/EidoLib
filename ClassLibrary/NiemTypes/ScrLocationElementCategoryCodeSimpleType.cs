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
        /// A data type for a kind of location element.
        /// </summary>
        /// <value>A data type for a kind of location element.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ScrLocationElementCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum AirportEnum for Airport
            /// </summary>
            [EnumMember(Value = "Airport")]
            AirportEnum = 0,
            /// <summary>
            /// Enum BPOEnum for BPO
            /// </summary>
            [EnumMember(Value = "BPO")]
            BPOEnum = 1,
            /// <summary>
            /// Enum DOEnum for DO
            /// </summary>
            [EnumMember(Value = "DO")]
            DOEnum = 2,
            /// <summary>
            /// Enum FloorEnum for Floor
            /// </summary>
            [EnumMember(Value = "Floor")]
            FloorEnum = 3,
            /// <summary>
            /// Enum HeadquartersEnum for Headquarters
            /// </summary>
            [EnumMember(Value = "Headquarters")]
            HeadquartersEnum = 4,
            /// <summary>
            /// Enum IOEnum for IO
            /// </summary>
            [EnumMember(Value = "IO")]
            IOEnum = 5,
            /// <summary>
            /// Enum LaneEnum for Lane
            /// </summary>
            [EnumMember(Value = "Lane")]
            LaneEnum = 6,
            /// <summary>
            /// Enum PortOfEntryEnum for Port of Entry
            /// </summary>
            [EnumMember(Value = "Port of Entry")]
            PortOfEntryEnum = 7,
            /// <summary>
            /// Enum RoomEnum for Room
            /// </summary>
            [EnumMember(Value = "Room")]
            RoomEnum = 8        }
}
