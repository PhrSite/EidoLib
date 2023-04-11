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
        /// A data type for a complete coordinate string from the Military Grid Reference System (MGRS) which represents a location with a Universal Transverse Mercator (UTM) or Univeral Polar Steriographic (UPS) coordinate and a unique military grid square.
        /// </summary>
        /// <value>A data type for a complete coordinate string from the Military Grid Reference System (MGRS) which represents a location with a Universal Transverse Mercator (UTM) or Univeral Polar Steriographic (UPS) coordinate and a unique military grid square.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MoMGRSCoordinateStringSimpleType
        {
            /// <summary>
            /// Enum _019150960CHJNPXAHJNPZAHJNPVABYZACFHJLPUXZAHJNPZ090905Enum for (((0[1-9]|[1-5][0-9]|60)[C-HJ-NP-X][A-HJ-NP-Z][A-HJ-NP-V])|([ABYZ][A-CF-HJ-LP-UX-Z][A-HJ-NP-Z]))([0-9][0-9]){0,5}
            /// </summary>
            [EnumMember(Value = "(((0[1-9]|[1-5][0-9]|60)[C-HJ-NP-X][A-HJ-NP-Z][A-HJ-NP-V])|([ABYZ][A-CF-HJ-LP-UX-Z][A-HJ-NP-Z]))([0-9][0-9]){0,5}")]
            _019150960CHJNPXAHJNPZAHJNPVABYZACFHJLPUXZAHJNPZ090905Enum = 0        }
}
