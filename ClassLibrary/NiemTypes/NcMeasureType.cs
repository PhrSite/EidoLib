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
    /// A data type for a measurement.
    /// </summary>
    [DataContract]
    public partial class NcMeasureType : IEquatable<NcMeasureType>
    { 
        /// <summary>
        /// A decimal measurement value. NIEM reference is nc:MeasureDecimalValue
        /// </summary>
        /// <value>A decimal measurement value. NIEM reference is nc:MeasureDecimalValue</value>

        [DataMember(Name="decimalValue")]
        public List<NiemXsdecimal> DecimalValue { get; set; }

        /// <summary>
        /// A double measurement value. NIEM reference is nc:MeasureDoubleValue
        /// </summary>
        /// <value>A double measurement value. NIEM reference is nc:MeasureDoubleValue</value>

        [DataMember(Name="doubleValue")]
        public List<NiemXsdouble> DoubleValue { get; set; }

        /// <summary>
        /// An integer measurement value. NIEM reference is nc:MeasureIntegerValue
        /// </summary>
        /// <value>An integer measurement value. NIEM reference is nc:MeasureIntegerValue</value>

        [DataMember(Name="integerValue")]
        public List<NiemXsinteger> IntegerValue { get; set; }

        /// <summary>
        /// An unsigned integer measurement value. NIEM reference is nc:MeasureUnsignedIntegerValue
        /// </summary>
        /// <value>An unsigned integer measurement value. NIEM reference is nc:MeasureUnsignedIntegerValue</value>

        [DataMember(Name="unsignedIntegerValue")]
        public List<NiemXsunsignedInt> UnsignedIntegerValue { get; set; }

        /// <summary>
        /// A decimal measurement range. NIEM reference is nc:MeasureDecimalRange
        /// </summary>
        /// <value>A decimal measurement range. NIEM reference is nc:MeasureDecimalRange</value>

        [DataMember(Name="decimalRange")]
        public List<NcDecimalRangeType> DecimalRange { get; set; }

        /// <summary>
        /// A double measurement range. NIEM reference is nc:MeasureDoubleRange
        /// </summary>
        /// <value>A double measurement range. NIEM reference is nc:MeasureDoubleRange</value>

        [DataMember(Name="doubleRange")]
        public List<NcDoubleRangeType> DoubleRange { get; set; }

        /// <summary>
        /// An integer measurement range. NIEM reference is nc:MeasureIntegerRange
        /// </summary>
        /// <value>An integer measurement range. NIEM reference is nc:MeasureIntegerRange</value>

        [DataMember(Name="integerRange")]
        public List<NcIntegerRangeType> IntegerRange { get; set; }

        /// <summary>
        /// An unsigned integer measurement range. NIEM reference is nc:MeasureUnsignedIntegerRange
        /// </summary>
        /// <value>An unsigned integer measurement range. NIEM reference is nc:MeasureUnsignedIntegerRange</value>

        [DataMember(Name="unsignedIntegerRange")]
        public List<NcUnsignedIntegerRangeType> UnsignedIntegerRange { get; set; }

        /// <summary>
        /// A list of decimal measurement values, all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureDecimalValueList
        /// </summary>
        /// <value>A list of decimal measurement values, all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureDecimalValueList</value>

        [DataMember(Name="decimalValueList")]
        public List<string> DecimalValueList { get; set; }

        /// <summary>
        /// A list of double measurement values, all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureDoubleValueList
        /// </summary>
        /// <value>A list of double measurement values, all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureDoubleValueList</value>

        [DataMember(Name="doubleValueList")]
        public List<string> DoubleValueList { get; set; }

        /// <summary>
        /// A list of integer measurement values, all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureIntegerValueList
        /// </summary>
        /// <value>A list of integer measurement values, all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureIntegerValueList</value>

        [DataMember(Name="integerValueList")]
        public List<string> IntegerValueList { get; set; }

        /// <summary>
        /// A list of measurement values , all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureTextList
        /// </summary>
        /// <value>A list of measurement values , all using the same measurement method/device and of the same units. NIEM reference is nc:MeasureTextList</value>

        [DataMember(Name="textList")]
        public List<string> TextList { get; set; }

        /// <summary>
        /// A textual description of a measurement value. NIEM reference is nc:MeasureValueText
        /// </summary>
        /// <value>A textual description of a measurement value. NIEM reference is nc:MeasureValueText</value>

        [DataMember(Name="value")]
        public List<NcTextType> Value { get; set; }

        /// <summary>
        /// A date a measurement was made. NIEM reference is nc:MeasureDate
        /// </summary>
        /// <value>A date a measurement was made. NIEM reference is nc:MeasureDate</value>

        [DataMember(Name="date")]
        public List<NcDateType> Date { get; set; }

        /// <summary>
        /// A comment regarding the measurement value and/or its error estimate. NIEM reference is nc:MeasureCommentText
        /// </summary>
        /// <value>A comment regarding the measurement value and/or its error estimate. NIEM reference is nc:MeasureCommentText</value>

        [DataMember(Name="comment")]
        public List<NcTextType> Comment { get; set; }

        /// <summary>
        /// A person or organization who makes a measurement. NIEM reference is nc:Measurer
        /// </summary>
        /// <value>A person or organization who makes a measurement. NIEM reference is nc:Measurer</value>

        [DataMember(Name="measurer")]
        public List<NcEntityType> Measurer { get; set; }

        /// <summary>
        /// A textual description of the error in a measurement value. NIEM reference is nc:MeasureErrorText
        /// </summary>
        /// <value>A textual description of the error in a measurement value. NIEM reference is nc:MeasureErrorText</value>

        [DataMember(Name="error")]
        public List<NcTextType> Error { get; set; }

        /// <summary>
        /// A calculated estimate of the error in a measurement value. NIEM reference is nc:MeasureErrorValue
        /// </summary>
        /// <value>A calculated estimate of the error in a measurement value. NIEM reference is nc:MeasureErrorValue</value>

        [DataMember(Name="errorValue")]
        public List<NiemXsdecimal> ErrorValue { get; set; }

        /// <summary>
        /// A textual description of the quality of a measurement value. NIEM reference is nc:MeasureQualityText
        /// </summary>
        /// <value>A textual description of the quality of a measurement value. NIEM reference is nc:MeasureQualityText</value>

        [DataMember(Name="quality")]
        public List<NcTextType> Quality { get; set; }

        /// <summary>
        /// A unit that qualifies the measurement value. NIEM reference is nc:MeasureUnitText
        /// </summary>
        /// <value>A unit that qualifies the measurement value. NIEM reference is nc:MeasureUnitText</value>

        [DataMember(Name="unit")]
        public List<NcTextType> Unit { get; set; }

        /// <summary>
        /// A method used to make a measurement. NIEM reference is nc:MeasureMethodText
        /// </summary>
        /// <value>A method used to make a measurement. NIEM reference is nc:MeasureMethodText</value>

        [DataMember(Name="method")]
        public List<NcTextType> Method { get; set; }

        /// <summary>
        /// True if a measurement has been guessed, or estimated without use of a measuring device or analytical method; false otherwise. NIEM reference is nc:MeasureEstimatedIndicator
        /// </summary>
        /// <value>True if a measurement has been guessed, or estimated without use of a measuring device or analytical method; false otherwise. NIEM reference is nc:MeasureEstimatedIndicator</value>

        [DataMember(Name="isEstimated")]
        public List<NiemXsboolean> IsEstimated { get; set; }

        /// <summary>
        /// ncMeasureType JSON-LD context
        /// </summary>
        /// <value>ncMeasureType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncMeasureTypeContextJsonldEnum for ../JSON-LD_Contexts/ncMeasureTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncMeasureTypeContext.jsonld")]
            JSONLDContextsncMeasureTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncMeasureType JSON-LD context
        /// </summary>
        /// <value>ncMeasureType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcMeasureType {\n");
            sb.Append("  DecimalValue: ").Append(DecimalValue).Append("\n");
            sb.Append("  DoubleValue: ").Append(DoubleValue).Append("\n");
            sb.Append("  IntegerValue: ").Append(IntegerValue).Append("\n");
            sb.Append("  UnsignedIntegerValue: ").Append(UnsignedIntegerValue).Append("\n");
            sb.Append("  DecimalRange: ").Append(DecimalRange).Append("\n");
            sb.Append("  DoubleRange: ").Append(DoubleRange).Append("\n");
            sb.Append("  IntegerRange: ").Append(IntegerRange).Append("\n");
            sb.Append("  UnsignedIntegerRange: ").Append(UnsignedIntegerRange).Append("\n");
            sb.Append("  DecimalValueList: ").Append(DecimalValueList).Append("\n");
            sb.Append("  DoubleValueList: ").Append(DoubleValueList).Append("\n");
            sb.Append("  IntegerValueList: ").Append(IntegerValueList).Append("\n");
            sb.Append("  TextList: ").Append(TextList).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Measurer: ").Append(Measurer).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorValue: ").Append(ErrorValue).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  IsEstimated: ").Append(IsEstimated).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcMeasureType)obj);
        }

        /// <summary>
        /// Returns true if NcMeasureType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcMeasureType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcMeasureType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DecimalValue == other.DecimalValue ||
                    DecimalValue != null &&
                    DecimalValue.SequenceEqual(other.DecimalValue)
                ) && 
                (
                    DoubleValue == other.DoubleValue ||
                    DoubleValue != null &&
                    DoubleValue.SequenceEqual(other.DoubleValue)
                ) && 
                (
                    IntegerValue == other.IntegerValue ||
                    IntegerValue != null &&
                    IntegerValue.SequenceEqual(other.IntegerValue)
                ) && 
                (
                    UnsignedIntegerValue == other.UnsignedIntegerValue ||
                    UnsignedIntegerValue != null &&
                    UnsignedIntegerValue.SequenceEqual(other.UnsignedIntegerValue)
                ) && 
                (
                    DecimalRange == other.DecimalRange ||
                    DecimalRange != null &&
                    DecimalRange.SequenceEqual(other.DecimalRange)
                ) && 
                (
                    DoubleRange == other.DoubleRange ||
                    DoubleRange != null &&
                    DoubleRange.SequenceEqual(other.DoubleRange)
                ) && 
                (
                    IntegerRange == other.IntegerRange ||
                    IntegerRange != null &&
                    IntegerRange.SequenceEqual(other.IntegerRange)
                ) && 
                (
                    UnsignedIntegerRange == other.UnsignedIntegerRange ||
                    UnsignedIntegerRange != null &&
                    UnsignedIntegerRange.SequenceEqual(other.UnsignedIntegerRange)
                ) && 
                (
                    DecimalValueList == other.DecimalValueList ||
                    DecimalValueList != null &&
                    DecimalValueList.SequenceEqual(other.DecimalValueList)
                ) && 
                (
                    DoubleValueList == other.DoubleValueList ||
                    DoubleValueList != null &&
                    DoubleValueList.SequenceEqual(other.DoubleValueList)
                ) && 
                (
                    IntegerValueList == other.IntegerValueList ||
                    IntegerValueList != null &&
                    IntegerValueList.SequenceEqual(other.IntegerValueList)
                ) && 
                (
                    TextList == other.TextList ||
                    TextList != null &&
                    TextList.SequenceEqual(other.TextList)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.SequenceEqual(other.Value)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.SequenceEqual(other.Date)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.SequenceEqual(other.Comment)
                ) && 
                (
                    Measurer == other.Measurer ||
                    Measurer != null &&
                    Measurer.SequenceEqual(other.Measurer)
                ) && 
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.SequenceEqual(other.Error)
                ) && 
                (
                    ErrorValue == other.ErrorValue ||
                    ErrorValue != null &&
                    ErrorValue.SequenceEqual(other.ErrorValue)
                ) && 
                (
                    Quality == other.Quality ||
                    Quality != null &&
                    Quality.SequenceEqual(other.Quality)
                ) && 
                (
                    Unit == other.Unit ||
                    Unit != null &&
                    Unit.SequenceEqual(other.Unit)
                ) && 
                (
                    Method == other.Method ||
                    Method != null &&
                    Method.SequenceEqual(other.Method)
                ) && 
                (
                    IsEstimated == other.IsEstimated ||
                    IsEstimated != null &&
                    IsEstimated.SequenceEqual(other.IsEstimated)
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
                    if (DecimalValue != null)
                    hashCode = hashCode * 59 + DecimalValue.GetHashCode();
                    if (DoubleValue != null)
                    hashCode = hashCode * 59 + DoubleValue.GetHashCode();
                    if (IntegerValue != null)
                    hashCode = hashCode * 59 + IntegerValue.GetHashCode();
                    if (UnsignedIntegerValue != null)
                    hashCode = hashCode * 59 + UnsignedIntegerValue.GetHashCode();
                    if (DecimalRange != null)
                    hashCode = hashCode * 59 + DecimalRange.GetHashCode();
                    if (DoubleRange != null)
                    hashCode = hashCode * 59 + DoubleRange.GetHashCode();
                    if (IntegerRange != null)
                    hashCode = hashCode * 59 + IntegerRange.GetHashCode();
                    if (UnsignedIntegerRange != null)
                    hashCode = hashCode * 59 + UnsignedIntegerRange.GetHashCode();
                    if (DecimalValueList != null)
                    hashCode = hashCode * 59 + DecimalValueList.GetHashCode();
                    if (DoubleValueList != null)
                    hashCode = hashCode * 59 + DoubleValueList.GetHashCode();
                    if (IntegerValueList != null)
                    hashCode = hashCode * 59 + IntegerValueList.GetHashCode();
                    if (TextList != null)
                    hashCode = hashCode * 59 + TextList.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Measurer != null)
                    hashCode = hashCode * 59 + Measurer.GetHashCode();
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                    if (ErrorValue != null)
                    hashCode = hashCode * 59 + ErrorValue.GetHashCode();
                    if (Quality != null)
                    hashCode = hashCode * 59 + Quality.GetHashCode();
                    if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                    if (Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();
                    if (IsEstimated != null)
                    hashCode = hashCode * 59 + IsEstimated.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcMeasureType left, NcMeasureType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcMeasureType left, NcMeasureType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}