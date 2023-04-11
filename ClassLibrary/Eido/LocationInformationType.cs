/////////////////////////////////////////////////////////////////////////////////////
//  File: LocationInformationType.cs                                16 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace Eido
{
    /// <summary>
    /// A data type for a location associated with an incident.
    /// See Section 2.18 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class LocationInformationType : PrologueType
    {
        /// <summary>
        /// Location type (Caller, Initial, CurrentIncident, Staging, Investigation, Tower Location,
        /// etc. Shall only contains values present in the Location type registry.
        /// See Section 3.8 of NENA-STA-021.1a-2022.
        /// Required.
        /// </summary>
        public string locationTypeDescriptionRegistryText { get; set; }

        /// <summary>
        /// A type for an external adapter for a Presence Information Data Format-Location Object(PIDF-LO).
        /// This is the (escaped) XML presence document.
        /// </summary>
        public string locationByValue { get; set; }

        /// <summary>
        /// Optional text further describing the location type.
        /// </summary>
        public string locationDescriptionText { get; set; }

        /// <summary>
        /// A URL where a location associated with an incident can be dereferenced.
        /// </summary>
        public string locationByReferenceUrl { get; set; }

        /// <summary>
        /// A nearest cross street to an incident's location in PIDF-LO format.
        /// </summary>
        public List<string> crossStreetByValue { get; set; }

        /// <summary>
        /// A URL where a nearest cross street to an incident's location can be dereferenced.
        /// </summary>
        public List<string> crossStreetByReferenceUrl { get; set; }

        /// <summary>
        /// An additional street, that with the location forms an intersection, in PIDF-LO format.
        /// </summary>
        public List<string> intersectingStreetByValue { get; set; }

        /// <summary>
        /// A URL where an additional street, that with the location forms an intersection, can be 
        /// dereferenced.
        /// </summary>
        public List<string> intersectingStreetByReferenceUrl { get; set; }

        /// <summary>
        /// The nearest cell tower and sector/face of the tower receiving a call associated 
        /// with an incident.
        /// </summary>
        public string cellTowerSectorId { get; set; }

        /// <summary>
        /// Additional information associated with an incident call, location, or person. Linked 
        /// elements type are AdditionalDataType
        /// </summary>
        public List<ReferenceType> additionalDataReference { get; set; }

        /// <summary>
        /// Notes and comments associated with an incident. Linked elements type 
        /// are NotesType
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
