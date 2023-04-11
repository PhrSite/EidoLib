/////////////////////////////////////////////////////////////////////////////////////
//  File: VehicleInformationType.cs                                 17 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using NiemTypes;

namespace Eido
{
    /// <summary>
    /// Used to exchange information about vehicles associated with an Incident including: suspect
    /// vehicles, vehicles involved in accidents, and other vehicles involved with the Incident.
    /// See Section 2.17 of NENA-STA-021.1a-2022.
    /// </summary>
    public partial class VehicleInformationType : PrologueType
    {
        /// <summary>
        /// NIEM vehicle information.
        /// </summary>
        public NcVehicleType ncVehicleComponent { get; set; }

        /// <summary>
        /// Information about a vehicle associated with an incident. Shall only contain values 
        /// present in the Vehicle Relationship Type registry.
        /// See Section 3.7 of NENA-STA-021.1a-2022.
        /// Required.
        /// </summary>
        public List<string> vehicleRelationshipType { get; set; }

        /// <summary>
        /// The date and time that the relationship of the vehicle to the incident was established.
        /// Required.
        /// </summary>
        public string vehicleRelationshipTimeStamp { get; set; } = EidoHelper.GetNenaTimestamp();

        /// <summary>
        /// Additional information associated with a vehicle. Linked element type is AdditionalDataType.
        /// </summary>
        public List<ReferenceType> additionalDataReference { get; set; }

        /// <summary>
        /// A location associated with an vehicle. Linked elements type is LocationInformationType.
        /// </summary>
        public List<ReferenceType> locationReference { get; set; }

        /// <summary>
        /// Reference to a Notes Data Component. Contains optional alphanumeric text further describing 
        /// the vehicle. Linked elements type is NotesType.
        /// </summary>
        public List<ReferenceType> notesReference { get; set; }
    }
}
