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
        /// A data type for a coordinate from the Universal Transverse Mercator (UTM) Coordinate System, which represents a location with a hemisphere, zone, an easting value, and a northing value.
        /// </summary>
        /// <value>A data type for a coordinate from the Universal Transverse Mercator (UTM) Coordinate System, which represents a location with a hemisphere, zone, an easting value, and a northing value.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcUTMCoordinateSimpleType
        {
            /// <summary>
            /// Enum _019150960NS096097Enum for (0[1-9]|[1-5][0-9]|60)([NS])([0-9]{6}[0-9]{7})
            /// </summary>
            [EnumMember(Value = "(0[1-9]|[1-5][0-9]|60)([NS])([0-9]{6}[0-9]{7})")]
            _019150960NS096097Enum = 0        }
}
