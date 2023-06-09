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
    /// A data type for the part of the roadway where a traffic accident occurred.
    /// </summary>
    [DataContract]
    public partial class StLocationRoadwayType : IEquatable<StLocationRoadwayType>
    { 
        /// <summary>
        /// A unique federal inspection/inventory identification assigned to a bridge, underpass, overpass, or tunnel bridge/structure that is also linkable to the national bridge inventory. NIEM reference is st:RoadwayStructureIdentification
        /// </summary>
        /// <value>A unique federal inspection/inventory identification assigned to a bridge, underpass, overpass, or tunnel bridge/structure that is also linkable to the national bridge inventory. NIEM reference is st:RoadwayStructureIdentification</value>

        [DataMember(Name="roadwayStructureIdentification")]
        public List<NcIdentificationType> RoadwayStructureIdentification { get; set; }

        /// <summary>
        /// An inclination of the roadway, expressed in the rate of rise or fall in feet (meters) per 100 feet (meters) of horizontal distance. NIEM reference is st:RoadwayInclinationValue
        /// </summary>
        /// <value>An inclination of the roadway, expressed in the rate of rise or fall in feet (meters) per 100 feet (meters) of horizontal distance. NIEM reference is st:RoadwayInclinationValue</value>

        [DataMember(Name="roadwayInclinationValue")]
        public List<NiemXsdecimal> RoadwayInclinationValue { get; set; }

        /// <summary>
        /// An AADT on ramp NIEM reference is st:AADTRampNumeric
        /// </summary>
        /// <value>An AADT on ramp NIEM reference is st:AADTRampNumeric</value>

        [DataMember(Name="aadtRampNumeric")]
        public List<NcNumericType> AadtRampNumeric { get; set; }

        /// <summary>
        /// A total number of through lanes on the segment. This excludes auxiliary lanes, such as collector-distributor lanes, weaving lanes, frontage road lanes, parking and turning lanes, acceleration/deceleration lanes, toll collection lanes, shoulders, and truck NIEM reference is st:ThroughLanesNumeric
        /// </summary>
        /// <value>A total number of through lanes on the segment. This excludes auxiliary lanes, such as collector-distributor lanes, weaving lanes, frontage road lanes, parking and turning lanes, acceleration/deceleration lanes, toll collection lanes, shoulders, and truck NIEM reference is st:ThroughLanesNumeric</value>

        [DataMember(Name="throughLanesNumeric")]
        public List<NcNumericType> ThroughLanesNumeric { get; set; }

        /// <summary>
        /// A bridge, underpass, overpass, or tunnel bridge/structure that is also linkable to the national bridge inventory. NIEM reference is st:BridgeStructure
        /// </summary>
        /// <value>A bridge, underpass, overpass, or tunnel bridge/structure that is also linkable to the national bridge inventory. NIEM reference is st:BridgeStructure</value>

        [DataMember(Name="bridgeStructure")]
        public List<NcFacilityType> BridgeStructure { get; set; }

        /// <summary>
        /// True if road curvature measurement parameters are applicable to this particular road part; false otherwise. NIEM reference is st:RoadwayCurveApplicableIndicator
        /// </summary>
        /// <value>True if road curvature measurement parameters are applicable to this particular road part; false otherwise. NIEM reference is st:RoadwayCurveApplicableIndicator</value>

        [DataMember(Name="isRoadwayCurveApplicable")]
        public List<NiemXsboolean> IsRoadwayCurveApplicable { get; set; }

        /// <summary>
        /// A measurement of the curvature in the roadway expressed in terms of its radius (use feet or meters). NIEM reference is st:RoadwayCurveRadiusLengthMeasure
        /// </summary>
        /// <value>A measurement of the curvature in the roadway expressed in terms of its radius (use feet or meters). NIEM reference is st:RoadwayCurveRadiusLengthMeasure</value>

        [DataMember(Name="roadwayCurveRadiusLengthMeasure")]
        public List<NcLengthMeasureType> RoadwayCurveRadiusLengthMeasure { get; set; }

        /// <summary>
        /// A measurement of the curvature in the roadway expressed in terms of its length (use feet or meters). NIEM reference is st:RoadwayCurveLengthMeasure
        /// </summary>
        /// <value>A measurement of the curvature in the roadway expressed in terms of its length (use feet or meters). NIEM reference is st:RoadwayCurveLengthMeasure</value>

        [DataMember(Name="roadwayCurveLengthMeasure")]
        public List<NcLengthMeasureType> RoadwayCurveLengthMeasure { get; set; }

        /// <summary>
        /// A measurement of the curvature in the roadway expressed in terms of its superelevation (use feet or meters). NIEM reference is st:RoadwayCurveSuperelevationMeasure
        /// </summary>
        /// <value>A measurement of the curvature in the roadway expressed in terms of its superelevation (use feet or meters). NIEM reference is st:RoadwayCurveSuperelevationMeasure</value>

        [DataMember(Name="roadwayCurveSuperelevationMeasure")]
        public List<NcLengthMeasureType> RoadwayCurveSuperelevationMeasure { get; set; }

        /// <summary>
        /// An inclination of the roadway, expressed in the rate of rise or fall in feet (meters) per 100 feet (meters) of horizontal distance. NIEM reference is st:RoadwayGradeSlopePercent
        /// </summary>
        /// <value>An inclination of the roadway, expressed in the rate of rise or fall in feet (meters) per 100 feet (meters) of horizontal distance. NIEM reference is st:RoadwayGradeSlopePercent</value>

        [DataMember(Name="roadwayGradeSlopePercent")]
        public List<NiemXsdecimal> RoadwayGradeSlopePercent { get; set; }

        /// <summary>
        /// An AADT value to represent the current data year. For two-way facilities, provide the AADT for both directions; provide the directional AADT if part of a one-way couplet or for one-way streets NIEM reference is st:AverageAnnualDailyTrafficNumeric
        /// </summary>
        /// <value>An AADT value to represent the current data year. For two-way facilities, provide the AADT for both directions; provide the directional AADT if part of a one-way couplet or for one-way streets NIEM reference is st:AverageAnnualDailyTrafficNumeric</value>

        [DataMember(Name="averageAnnualDailyTrafficNumeric")]
        public List<NcNumericType> AverageAnnualDailyTrafficNumeric { get; set; }

        /// <summary>
        /// A width of the lane(s) where crash occurred (use feet or meters). NIEM reference is st:RoadwayLaneWidthMeasure
        /// </summary>
        /// <value>A width of the lane(s) where crash occurred (use feet or meters). NIEM reference is st:RoadwayLaneWidthMeasure</value>

        [DataMember(Name="roadwayLaneWidthMeasure")]
        public List<NcLengthMeasureType> RoadwayLaneWidthMeasure { get; set; }

        /// <summary>
        /// A widths of the shoulder(s) where crash occurred (use feet or meters). NIEM reference is st:RoadwayShoulderWidthMeasure
        /// </summary>
        /// <value>A widths of the shoulder(s) where crash occurred (use feet or meters). NIEM reference is st:RoadwayShoulderWidthMeasure</value>

        [DataMember(Name="roadwayShoulderWidthMeasure")]
        public List<NcLengthMeasureType> RoadwayShoulderWidthMeasure { get; set; }

        /// <summary>
        /// A width of portion of divided highway separating the road for traffic in opposing directions where the crash occurred. If a crash occurs at a mid-block section, the median width is based on the mid-block section. If the crash occurs at an intersection, the NIEM reference is st:RoadwayMedianWidthMeasure
        /// </summary>
        /// <value>A width of portion of divided highway separating the road for traffic in opposing directions where the crash occurred. If a crash occurs at a mid-block section, the median width is based on the mid-block section. If the crash occurs at an intersection, the NIEM reference is st:RoadwayMedianWidthMeasure</value>

        [DataMember(Name="roadwayMedianWidthMeasure")]
        public List<NcLengthMeasureType> RoadwayMedianWidthMeasure { get; set; }

        /// <summary>
        /// A unique US DOT/AAR number assigned for identification purposes to a railroad crossing by a state highway agency in cooperation with the Federal Railroad Administration. NIEM reference is st:RoadwayRailwayCrossingIdentification
        /// </summary>
        /// <value>A unique US DOT/AAR number assigned for identification purposes to a railroad crossing by a state highway agency in cooperation with the Federal Railroad Administration. NIEM reference is st:RoadwayRailwayCrossingIdentification</value>

        [DataMember(Name="roadwayRailwayCrossingIdentification")]
        public List<NcIdentificationType> RoadwayRailwayCrossingIdentification { get; set; }

        /// <summary>
        /// A total number of entering vehicles for all approaches of an intersection. Actual or estimated traffic volume expressed as an average annual daily count. NIEM reference is st:RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity
        /// </summary>
        /// <value>A total number of entering vehicles for all approaches of an intersection. Actual or estimated traffic volume expressed as an average annual daily count. NIEM reference is st:RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity</value>

        [DataMember(Name="roadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity")]
        public List<NcQuantityType> RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity { get; set; }

        /// <summary>
        /// An intersection consists of two or more roadways. NIEM reference is st:IntersectionCategoryCode
        /// </summary>
        /// <value>An intersection consists of two or more roadways. NIEM reference is st:IntersectionCategoryCode</value>

        [DataMember(Name="intersectionCategoryCode")]
        public List<MmuccIntersectionCategoryCodeType> IntersectionCategoryCode { get; set; }

        /// <summary>
        /// A functional class of the segment. NIEM reference is st:FunctionalClassCode
        /// </summary>
        /// <value>A functional class of the segment. NIEM reference is st:FunctionalClassCode</value>

        [DataMember(Name="functionalClassCode")]
        public List<StFunctionalClassCodeType> FunctionalClassCode { get; set; }

        /// <summary>
        /// A geometric or layout and inclination characteristics of the roadway in the direction of travel for this vehicle. NIEM reference is st:RoadwayGradeCode
        /// </summary>
        /// <value>A geometric or layout and inclination characteristics of the roadway in the direction of travel for this vehicle. NIEM reference is st:RoadwayGradeCode</value>

        [DataMember(Name="roadwayGradeCode")]
        public List<MmuccRoadwayGradeCodeType> RoadwayGradeCode { get; set; }

        /// <summary>
        /// A Horizontal Alignment. The geometric or layout and inclination characteristics of the roadway in the direction of travel for this vehicle. NIEM reference is st:RoadwayHorizontalAlignmentCode
        /// </summary>
        /// <value>A Horizontal Alignment. The geometric or layout and inclination characteristics of the roadway in the direction of travel for this vehicle. NIEM reference is st:RoadwayHorizontalAlignmentCode</value>

        [DataMember(Name="roadwayHorizontalAlignmentCode")]
        public List<MmuccRoadwayHorizontalAlignmentCodeType> RoadwayHorizontalAlignmentCode { get; set; }

        /// <summary>
        /// An indicator of traffic control present at intersection/junction. NIEM reference is st:IntersectionJunctionTrafficControlCategoryCode
        /// </summary>
        /// <value>An indicator of traffic control present at intersection/junction. NIEM reference is st:IntersectionJunctionTrafficControlCategoryCode</value>

        [DataMember(Name="intersectionJunctionTrafficControlCategoryCode")]
        public List<StIntersectionJunctionTrafficControlCodeType> IntersectionJunctionTrafficControlCategoryCode { get; set; }

        /// <summary>
        /// A type of roadway illumination. NIEM reference is st:RoadwayLightingCode
        /// </summary>
        /// <value>A type of roadway illumination. NIEM reference is st:RoadwayLightingCode</value>

        [DataMember(Name="roadwayLightingCode")]
        public List<StRoadwayLightingCodeType> RoadwayLightingCode { get; set; }

        /// <summary>
        /// A designation of the roadway as part of the National Highway System. NIEM reference is st:RoadwayNationalHighwayPartCode
        /// </summary>
        /// <value>A designation of the roadway as part of the National Highway System. NIEM reference is st:RoadwayNationalHighwayPartCode</value>

        [DataMember(Name="roadwayNationalHighwayPartCode")]
        public List<MmuccStandardSelectionCodeType> RoadwayNationalHighwayPartCode { get; set; }

        /// <summary>
        /// stLocationRoadwayType JSON-LD context
        /// </summary>
        /// <value>stLocationRoadwayType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsstLocationRoadwayTypeContextJsonldEnum for ../JSON-LD_Contexts/stLocationRoadwayTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/stLocationRoadwayTypeContext.jsonld")]
            JSONLDContextsstLocationRoadwayTypeContextJsonldEnum = 0        }

        /// <summary>
        /// stLocationRoadwayType JSON-LD context
        /// </summary>
        /// <value>stLocationRoadwayType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StLocationRoadwayType {\n");
            sb.Append("  RoadwayStructureIdentification: ").Append(RoadwayStructureIdentification).Append("\n");
            sb.Append("  RoadwayInclinationValue: ").Append(RoadwayInclinationValue).Append("\n");
            sb.Append("  AadtRampNumeric: ").Append(AadtRampNumeric).Append("\n");
            sb.Append("  ThroughLanesNumeric: ").Append(ThroughLanesNumeric).Append("\n");
            sb.Append("  BridgeStructure: ").Append(BridgeStructure).Append("\n");
            sb.Append("  IsRoadwayCurveApplicable: ").Append(IsRoadwayCurveApplicable).Append("\n");
            sb.Append("  RoadwayCurveRadiusLengthMeasure: ").Append(RoadwayCurveRadiusLengthMeasure).Append("\n");
            sb.Append("  RoadwayCurveLengthMeasure: ").Append(RoadwayCurveLengthMeasure).Append("\n");
            sb.Append("  RoadwayCurveSuperelevationMeasure: ").Append(RoadwayCurveSuperelevationMeasure).Append("\n");
            sb.Append("  RoadwayGradeSlopePercent: ").Append(RoadwayGradeSlopePercent).Append("\n");
            sb.Append("  AverageAnnualDailyTrafficNumeric: ").Append(AverageAnnualDailyTrafficNumeric).Append("\n");
            sb.Append("  RoadwayLaneWidthMeasure: ").Append(RoadwayLaneWidthMeasure).Append("\n");
            sb.Append("  RoadwayShoulderWidthMeasure: ").Append(RoadwayShoulderWidthMeasure).Append("\n");
            sb.Append("  RoadwayMedianWidthMeasure: ").Append(RoadwayMedianWidthMeasure).Append("\n");
            sb.Append("  RoadwayRailwayCrossingIdentification: ").Append(RoadwayRailwayCrossingIdentification).Append("\n");
            sb.Append("  RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity: ").Append(RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity).Append("\n");
            sb.Append("  IntersectionCategoryCode: ").Append(IntersectionCategoryCode).Append("\n");
            sb.Append("  FunctionalClassCode: ").Append(FunctionalClassCode).Append("\n");
            sb.Append("  RoadwayGradeCode: ").Append(RoadwayGradeCode).Append("\n");
            sb.Append("  RoadwayHorizontalAlignmentCode: ").Append(RoadwayHorizontalAlignmentCode).Append("\n");
            sb.Append("  IntersectionJunctionTrafficControlCategoryCode: ").Append(IntersectionJunctionTrafficControlCategoryCode).Append("\n");
            sb.Append("  RoadwayLightingCode: ").Append(RoadwayLightingCode).Append("\n");
            sb.Append("  RoadwayNationalHighwayPartCode: ").Append(RoadwayNationalHighwayPartCode).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((StLocationRoadwayType)obj);
        }

        /// <summary>
        /// Returns true if StLocationRoadwayType instances are equal
        /// </summary>
        /// <param name="other">Instance of StLocationRoadwayType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StLocationRoadwayType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RoadwayStructureIdentification == other.RoadwayStructureIdentification ||
                    RoadwayStructureIdentification != null &&
                    RoadwayStructureIdentification.SequenceEqual(other.RoadwayStructureIdentification)
                ) && 
                (
                    RoadwayInclinationValue == other.RoadwayInclinationValue ||
                    RoadwayInclinationValue != null &&
                    RoadwayInclinationValue.SequenceEqual(other.RoadwayInclinationValue)
                ) && 
                (
                    AadtRampNumeric == other.AadtRampNumeric ||
                    AadtRampNumeric != null &&
                    AadtRampNumeric.SequenceEqual(other.AadtRampNumeric)
                ) && 
                (
                    ThroughLanesNumeric == other.ThroughLanesNumeric ||
                    ThroughLanesNumeric != null &&
                    ThroughLanesNumeric.SequenceEqual(other.ThroughLanesNumeric)
                ) && 
                (
                    BridgeStructure == other.BridgeStructure ||
                    BridgeStructure != null &&
                    BridgeStructure.SequenceEqual(other.BridgeStructure)
                ) && 
                (
                    IsRoadwayCurveApplicable == other.IsRoadwayCurveApplicable ||
                    IsRoadwayCurveApplicable != null &&
                    IsRoadwayCurveApplicable.SequenceEqual(other.IsRoadwayCurveApplicable)
                ) && 
                (
                    RoadwayCurveRadiusLengthMeasure == other.RoadwayCurveRadiusLengthMeasure ||
                    RoadwayCurveRadiusLengthMeasure != null &&
                    RoadwayCurveRadiusLengthMeasure.SequenceEqual(other.RoadwayCurveRadiusLengthMeasure)
                ) && 
                (
                    RoadwayCurveLengthMeasure == other.RoadwayCurveLengthMeasure ||
                    RoadwayCurveLengthMeasure != null &&
                    RoadwayCurveLengthMeasure.SequenceEqual(other.RoadwayCurveLengthMeasure)
                ) && 
                (
                    RoadwayCurveSuperelevationMeasure == other.RoadwayCurveSuperelevationMeasure ||
                    RoadwayCurveSuperelevationMeasure != null &&
                    RoadwayCurveSuperelevationMeasure.SequenceEqual(other.RoadwayCurveSuperelevationMeasure)
                ) && 
                (
                    RoadwayGradeSlopePercent == other.RoadwayGradeSlopePercent ||
                    RoadwayGradeSlopePercent != null &&
                    RoadwayGradeSlopePercent.SequenceEqual(other.RoadwayGradeSlopePercent)
                ) && 
                (
                    AverageAnnualDailyTrafficNumeric == other.AverageAnnualDailyTrafficNumeric ||
                    AverageAnnualDailyTrafficNumeric != null &&
                    AverageAnnualDailyTrafficNumeric.SequenceEqual(other.AverageAnnualDailyTrafficNumeric)
                ) && 
                (
                    RoadwayLaneWidthMeasure == other.RoadwayLaneWidthMeasure ||
                    RoadwayLaneWidthMeasure != null &&
                    RoadwayLaneWidthMeasure.SequenceEqual(other.RoadwayLaneWidthMeasure)
                ) && 
                (
                    RoadwayShoulderWidthMeasure == other.RoadwayShoulderWidthMeasure ||
                    RoadwayShoulderWidthMeasure != null &&
                    RoadwayShoulderWidthMeasure.SequenceEqual(other.RoadwayShoulderWidthMeasure)
                ) && 
                (
                    RoadwayMedianWidthMeasure == other.RoadwayMedianWidthMeasure ||
                    RoadwayMedianWidthMeasure != null &&
                    RoadwayMedianWidthMeasure.SequenceEqual(other.RoadwayMedianWidthMeasure)
                ) && 
                (
                    RoadwayRailwayCrossingIdentification == other.RoadwayRailwayCrossingIdentification ||
                    RoadwayRailwayCrossingIdentification != null &&
                    RoadwayRailwayCrossingIdentification.SequenceEqual(other.RoadwayRailwayCrossingIdentification)
                ) && 
                (
                    RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity == other.RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity ||
                    RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity != null &&
                    RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity.SequenceEqual(other.RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity)
                ) && 
                (
                    IntersectionCategoryCode == other.IntersectionCategoryCode ||
                    IntersectionCategoryCode != null &&
                    IntersectionCategoryCode.SequenceEqual(other.IntersectionCategoryCode)
                ) && 
                (
                    FunctionalClassCode == other.FunctionalClassCode ||
                    FunctionalClassCode != null &&
                    FunctionalClassCode.SequenceEqual(other.FunctionalClassCode)
                ) && 
                (
                    RoadwayGradeCode == other.RoadwayGradeCode ||
                    RoadwayGradeCode != null &&
                    RoadwayGradeCode.SequenceEqual(other.RoadwayGradeCode)
                ) && 
                (
                    RoadwayHorizontalAlignmentCode == other.RoadwayHorizontalAlignmentCode ||
                    RoadwayHorizontalAlignmentCode != null &&
                    RoadwayHorizontalAlignmentCode.SequenceEqual(other.RoadwayHorizontalAlignmentCode)
                ) && 
                (
                    IntersectionJunctionTrafficControlCategoryCode == other.IntersectionJunctionTrafficControlCategoryCode ||
                    IntersectionJunctionTrafficControlCategoryCode != null &&
                    IntersectionJunctionTrafficControlCategoryCode.SequenceEqual(other.IntersectionJunctionTrafficControlCategoryCode)
                ) && 
                (
                    RoadwayLightingCode == other.RoadwayLightingCode ||
                    RoadwayLightingCode != null &&
                    RoadwayLightingCode.SequenceEqual(other.RoadwayLightingCode)
                ) && 
                (
                    RoadwayNationalHighwayPartCode == other.RoadwayNationalHighwayPartCode ||
                    RoadwayNationalHighwayPartCode != null &&
                    RoadwayNationalHighwayPartCode.SequenceEqual(other.RoadwayNationalHighwayPartCode)
                ) && 
                (
                    Context == other.Context ||
                    Context != null &&
                    Context.Equals(other.Context)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RoadwayStructureIdentification != null)
                    hashCode = hashCode * 59 + RoadwayStructureIdentification.GetHashCode();
                    if (RoadwayInclinationValue != null)
                    hashCode = hashCode * 59 + RoadwayInclinationValue.GetHashCode();
                    if (AadtRampNumeric != null)
                    hashCode = hashCode * 59 + AadtRampNumeric.GetHashCode();
                    if (ThroughLanesNumeric != null)
                    hashCode = hashCode * 59 + ThroughLanesNumeric.GetHashCode();
                    if (BridgeStructure != null)
                    hashCode = hashCode * 59 + BridgeStructure.GetHashCode();
                    if (IsRoadwayCurveApplicable != null)
                    hashCode = hashCode * 59 + IsRoadwayCurveApplicable.GetHashCode();
                    if (RoadwayCurveRadiusLengthMeasure != null)
                    hashCode = hashCode * 59 + RoadwayCurveRadiusLengthMeasure.GetHashCode();
                    if (RoadwayCurveLengthMeasure != null)
                    hashCode = hashCode * 59 + RoadwayCurveLengthMeasure.GetHashCode();
                    if (RoadwayCurveSuperelevationMeasure != null)
                    hashCode = hashCode * 59 + RoadwayCurveSuperelevationMeasure.GetHashCode();
                    if (RoadwayGradeSlopePercent != null)
                    hashCode = hashCode * 59 + RoadwayGradeSlopePercent.GetHashCode();
                    if (AverageAnnualDailyTrafficNumeric != null)
                    hashCode = hashCode * 59 + AverageAnnualDailyTrafficNumeric.GetHashCode();
                    if (RoadwayLaneWidthMeasure != null)
                    hashCode = hashCode * 59 + RoadwayLaneWidthMeasure.GetHashCode();
                    if (RoadwayShoulderWidthMeasure != null)
                    hashCode = hashCode * 59 + RoadwayShoulderWidthMeasure.GetHashCode();
                    if (RoadwayMedianWidthMeasure != null)
                    hashCode = hashCode * 59 + RoadwayMedianWidthMeasure.GetHashCode();
                    if (RoadwayRailwayCrossingIdentification != null)
                    hashCode = hashCode * 59 + RoadwayRailwayCrossingIdentification.GetHashCode();
                    if (RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity != null)
                    hashCode = hashCode * 59 + RoadwayIntersectionAverageAnnualDailyEnteringTrafficQuantity.GetHashCode();
                    if (IntersectionCategoryCode != null)
                    hashCode = hashCode * 59 + IntersectionCategoryCode.GetHashCode();
                    if (FunctionalClassCode != null)
                    hashCode = hashCode * 59 + FunctionalClassCode.GetHashCode();
                    if (RoadwayGradeCode != null)
                    hashCode = hashCode * 59 + RoadwayGradeCode.GetHashCode();
                    if (RoadwayHorizontalAlignmentCode != null)
                    hashCode = hashCode * 59 + RoadwayHorizontalAlignmentCode.GetHashCode();
                    if (IntersectionJunctionTrafficControlCategoryCode != null)
                    hashCode = hashCode * 59 + IntersectionJunctionTrafficControlCategoryCode.GetHashCode();
                    if (RoadwayLightingCode != null)
                    hashCode = hashCode * 59 + RoadwayLightingCode.GetHashCode();
                    if (RoadwayNationalHighwayPartCode != null)
                    hashCode = hashCode * 59 + RoadwayNationalHighwayPartCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StLocationRoadwayType left, StLocationRoadwayType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StLocationRoadwayType left, StLocationRoadwayType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
