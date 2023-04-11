/////////////////////////////////////////////////////////////////////////////////////
//  File:   EidoHelper.cs                                           15 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json;

namespace Eido
{
    /// <summary>
    /// Helper functions for handling Emergency Incident Data Object (EIDO) JSON document
    /// objects.
    /// </summary>
    public static class EidoHelper
    {
        /// <summary>
        /// JsonSerializerSettings to use when serializing or de-serializing an EIDO.
        /// </summary>
        public static JsonSerializerSettings JsonSerSettings =
            new JsonSerializerSettings()
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

        /// <summary>
        /// De-serializes a JSON string containing an EIDO to an EidoType object.
        /// </summary>
        /// <param name="strJson">Input JSON string.</param>
        /// <returns>Returns an EIDO if successful or null if an error occured.</returns>
        public static EidoType FromString(string strJson)
        {
            EidoType EidoObj = null;
            try
            {
                EidoObj = JsonConvert.DeserializeObject<EidoType>(strJson, JsonSerSettings);
            }
            catch (JsonSerializationException)
            {
                EidoObj = null;
            }
            catch (Exception)
            {
                EidoObj = null;
            }

            return EidoObj;
        }

        /// <summary>
        /// Serializes an EidoType object to a JSON string.
        /// </summary>
        /// <param name="EidoObj">Input object to serialize</param>
        /// <returns>Returns a string containing the JSON of the EidoType</returns>
        public static string ToJsonString(EidoType EidoObj)
        {
            string strJson = null;
            try
            {
                strJson = JsonConvert.SerializeObject(EidoObj, Formatting.Indented);
            }
            catch (JsonSerializationException) { strJson = null; }
            catch (Exception) { strJson = null; }

            return strJson;
        }

        /// <summary>
        /// Gets the current time using the NENA Timestamp format specified in Section 2.3 of 
        /// NENA-STA-010.3.
        /// </summary>
        /// <returns>Returns the NENA formatted Timestamp</returns>
        public static string GetNenaTimestamp()
        {
            return DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffzzz");
        }

        /// <summary>
        /// Gets the time using the NENA Timestamp format specified in Section 2.3 Timestamp of 
        /// NENA-STA-010.3.
        /// </summary>
        /// <param name="Tm">Input DateTime to convert.</param>
        /// <returns>Returns the NENA formatted Timestamp</returns>
        public static string GetNenaTimestamp(DateTime Tm)
        {
            return Tm.ToString("yyyy-MM-ddTHH:mm:ss.fffffzzz");
        }
    }
}
