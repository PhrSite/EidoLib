﻿/////////////////////////////////////////////////////////////////////////////////////
//  File: EidoUnitTests.cs                                          19 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Eido;
using NiemTypes;

using AdditionalData;
using Ng911Lib.Utilities;
using Pidf;

namespace EidoUnitTests
{
    /// <summary>
    /// Tests to see if the classes for an EIDO can be deserialized from a string.
    /// There is only one sample test file provided in the NENA EIDO-JSON GitHub repository.
    /// </summary>
    [Trait("Category", "unit")]
    public class EidoUnitTests
    {
        private string FilePath = @"..\..\..\EidoTestFiles\";

        public EidoUnitTests()
        {
            
            //BuildEidoWithJcard();
        }

        // Only do this once if the file does not exist. Otherwise it will not work.
        private void BuildEidoWithJcard()
        {
            string strPath = Path.Combine(FilePath, "EidoWithJcard.json");
            if (File.Exists(strPath) == true)
                return;

            EidoType eido = GetSampleCallTransferEido();
            vcardType Vc = new vcardType();
            Vc.org = new org[1];
            org Org = new org();
            Vc.org[0] = Org;
            Org.text = new string[1];
            Org.text[0] = "PSAP Name";
            Vc.FirstName = "John";
            Vc.LastName = "Doe";
            Vc.Street = "123 Main Street";
            Vc.City = "AnyTown";
            Vc.State = "NY";
            Vc.TelephoneNumber = "8185553333";
            Vc.EMail = "Psap@PsapName.org";

            eido.agencyComponent[0].agencyJcard = JCard.XcardToJsonString(Vc); ;
            string strEido = EidoHelper.ToJsonString(eido);
            File.WriteAllText(strPath, strEido);
        }

        /// <summary>
        /// The SampleCallTransferEido.json file was taken from the Samples directory of
        /// the NENA EIDO-JSON GitHub repository at https://github.com/NENA911/EIDO-JSON.
        /// </summary>
        private EidoType GetSampleCallTransferEido()
        {
            string strEido = File.ReadAllText(Path.Combine(FilePath, "SampleCallTransferEido.json"));
            EidoType eido = EidoHelper.FromString(strEido);
            Assert.NotNull(eido);
            return eido;
        }

        [Fact]
        public void SampleCallTransferEido()
        {
            EidoType eido = GetSampleCallTransferEido();

            Assert.True(eido.Id != null && eido.Id == "urn:emergency:uid:incidentid:a56e556d871:bcf.state.pa.us",
                "eido.Id is wrong");
            Assert.True(eido.eidoVersion != null && eido.eidoVersion == "1.0");
            DateTime Dt;
            Assert.True(eido.lastUpdateTimestamp != null && DateTime.TryParse(eido.lastUpdateTimestamp,
                out Dt) == true, "The lastUpdateTimestamp is wrong");
            Assert.True(eido.updatedByAgencyReference?.Ref != null && eido.updatedByAgencyReference.Ref ==
                "state.pa.us", "The updatedByAgencyReference is wrong");
            Assert.True(eido.updatedByAgentReference?.Ref != null &&
                eido.updatedByAgentReference.Ref == "tjones.atroop@state.pa.us",
                "The updatedByAgentReference is wrong");
            Assert.True(eido.issuingElementIdentification != null && eido.issuingElementIdentification ==
                "idx.state.pa.us", "The issuingElementIdentification is wrong");

            Assert.True(eido.callComponent != null && eido.callComponent.Count == 1,
                "The callComponent is null or empty");
            CallInformationType Cit = eido.callComponent[0];

            Assert.True(eido.callbackComponent != null && eido.callbackComponent.Count == 1,
                "The callbackComponent is null or empty");
            CallbackType Cbt = eido.callbackComponent[0];

            Assert.True(eido.agencyComponent != null && eido.agencyComponent.Count == 1,
                "The agencyComponent is null or empty");
            AgencyType At = eido.agencyComponent[0];

            Assert.True(eido.agentComponent != null && eido.agentComponent.Count == 1,
                "The agentComponent is null or empty");
            AgentType Agt = eido.agentComponent[0];

            Assert.True(eido.additionalDataComponent != null && eido.additionalDataComponent.Count == 3,
                "The additionalDataComponent is null or empty");

            Assert.True(eido.locationComponent != null && eido.locationComponent.Count == 2,
                "The locationComponent is null or empty");

            Assert.True(eido.personComponent != null && eido.personComponent.Count == 1,
                "The personComponent is null or empty");
        }

        [Fact]
        public void SampleCallTransferEido_CallComponent()
        {
            EidoType eido = GetSampleCallTransferEido();

            Assert.True(eido.callComponent != null && eido.callComponent.Count == 1,
                "The callComponent is null or empty");
            CallInformationType Cit = eido.callComponent[0];
            Assert.True(Cit.Id != null && Cit.Id == "urn:emergency:uid:callid:a56e556d871:bcf.state.pa.us",
                "The Id field is wrong");
            Assert.True(Cit.lastUpdateTimestamp != null && Cit.lastUpdateTimestamp ==
                "2021-04-30T14:42:00.0-04:00", "The lastUpdateTimestamp is wrong");
            Assert.True(Cit.updatedByAgencyReference?.Ref != null && Cit.updatedByAgencyReference.Ref ==
                "state.pa.us", "The updatedByAgencyReference.Ref is wrong");
            Assert.True(Cit.updatedByAgentReference?.Ref != null && Cit.updatedByAgentReference.Ref ==
                "tjones.atroop@state.pa.us", "The updatedByAgentReference.Ref is wrong");
            Assert.True(Cit.queueIdentifier != null && Cit.queueIdentifier == "sos@state.pa.us",
                "The queueIdentifier is wrong");
            Assert.True(Cit.standardPrimaryCallType != null && Cit.standardPrimaryCallType ==
                "emergency", "The standardPrimaryCallType is wrong");
            Assert.True(Cit.direction != null && Cit.direction == "incoming", "The direction is wrong");

            Assert.True(Cit.additionalDataReference != null && Cit.additionalDataReference.Count == 3,
                "The additionalDataReference is null or empty");
            Assert.True(Cit.additionalDataReference[0].Ref == "123e4567-e89b-12d3-a456-426614174000",
                "The first additionalDataReference is wrong");
            Assert.True(Cit.additionalDataReference[1].Ref == "123e4567-e89b-12d3-a456-426614174001",
                "The second additionalDataReference is wrong");
            Assert.True(Cit.additionalDataReference[2].Ref == "123e4567-e89b-12d3-a456-426614174002",
                "The first additionalDataReference is wrong");
            Assert.True(Cit.callStartTimestamp != null && Cit.callStartTimestamp ==
                "2021-04-30T14:40:00.0-04:00", "The callStartTimestamp is wrong");
            Assert.True(Cit.answerDate != null && Cit.answerDate == "2021-04-30T14:42:00.0-04:00",
                "The answerDate is wrong");
            Assert.True(Cit.callStateRegistryText != null && Cit.callStateRegistryText == "callAnswered",
                "The callStateRegistryText is wrong");
            Assert.True(Cit.callBackReference?.Ref != null && Cit.callBackReference.Ref ==
                "123e4567-e89b-1234-a456-426614174000", "The callBackReference is wrong");
            Assert.True(Cit.agentReference != null && Cit.agentReference.Count == 1,
                "The agentReference is null or empty");
            Assert.True(Cit.agentReference[0].Ref != null && Cit.agentReference[0].Ref ==
                "tjones.atroop@state.pa.us", "The agentReference is wrong");
            Assert.True(Cit.locationReference != null && Cit.locationReference.Count == 2,
                "The locationReference is null or empty");
            Assert.True(Cit.locationReference[0].Ref != null && Cit.locationReference[0].Ref ==
                "123e4567-dead-12d3-a456-426614174000", "The first locationReference is wrong");
            Assert.True(Cit.locationReference[1].Ref != null && Cit.locationReference[1].Ref ==
                "123e4567-beef-12d3-a456-426614174000", "The first locationReference is wrong");
            Assert.True(Cit.personReference != null && Cit.personReference.Count == 1,
                "The personReference is null or empty");
            Assert.True(Cit.personReference[0].Ref != null && Cit.personReference[0].Ref ==
                "123e4567-abcd-12d3-a456-426614174000", "The personReference is wrong");
        }

        [Fact]
        public void SampleCallTransferEido_CallBackComponent()
        {
            EidoType eido = GetSampleCallTransferEido();

            Assert.True(eido.callbackComponent != null && eido.callbackComponent.Count == 1,
                "The callbackComponent is null or empty");
            CallbackType Cbt = eido.callbackComponent[0];
            Assert.True(Cbt.Id == "123e4567-e89b-1234-a456-426614174000", "Cbt.Id is wrong");
            Assert.True(Cbt.lastUpdateTimestamp == "2021-04-30T14:40:00.0-04:00",
                "Cbt.lastUpdateTimestamp is wrong");
            Assert.True(Cbt.updatedByAgencyReference != null && Cbt.updatedByAgencyReference.Ref == 
                "state.pa.us", "The updatedByAgencyReference.Ref is wrong");
            Assert.True(Cbt.updatedByAgentReference?.Ref != null && Cbt.updatedByAgentReference.Ref ==
                "tjones.atroop@state.pa.us", "Cbt.updatedByAgentReference is wrong");
            Assert.True(Cbt.callBackInformationUri != null && Cbt.callBackInformationUri.Count == 2,
                "The callBackInformationUri is null or the count is wrong");
            Assert.True(Cbt.callBackInformationUri[0] == "sip:8195551212@osp.com", "The first " +
                "callBackInformationUri is wrong");
            Assert.True(Cbt.callBackInformationUri[1] == "tel:8195551212", "The second " +
                "callBackInformationUri is wrong");
            Assert.True(Cbt.deviceContactHeader == "sip:conferenceid3053@bridge.ngcs.com;isfocus",
                "The deviceContactHeader is wrong");
        }

        [Fact]
        public void SampleCallTransferEido_agencyComponent()
        {
            EidoType eido = GetSampleCallTransferEido();
            Assert.True(eido.agencyComponent != null && eido.agencyComponent.Count == 1,
                "The agencyComponent is null or the count is wrong.");
            AgencyType At = eido.agencyComponent[0];
            Assert.True(At.Id == "state.pa.us", "At.Id is wrong");
            Assert.True(At.lastUpdateTimestamp == "2021-04-30T14:40:00.0-04:00", "The lastUpdateTimestamp is wrong");
            Assert.True(At.updatedByAgencyReference?.Ref == "state.pa.us", "At.updatedByAgencyReference is wrong");
            Assert.True(At.agencyRoleDescriptionRegistryText?[0] == "CallReceiving",
                "At.agencyRoleDescriptionRegistryText[0] is wrong");
            Assert.True(At.agencyType?[0] == "psap", "The agencyType is wrong");

        }

        [Fact]
        public void SampleCallTransferEido_agentComponent()
        {
            EidoType eido = GetSampleCallTransferEido();
            Assert.True(eido.agentComponent != null && eido.agentComponent.Count == 1,
                "The agentComponent is null or the count is wrong");
            AgentType At = eido.agentComponent[0];
            Assert.True(At.Id == "tjones.atroop@state.pa.us", "At.Id is wrong");
            Assert.True(At.lastUpdateTimestamp == "2021-04-30T14:42:00.0-04:00", "The lastUpdateTimestamp is wrong");
            Assert.True(At.updatedByAgencyReference?.Ref == "state.pa.us", "The updatedByAgencyReference is wrong");
            Assert.True(At.updatedByAgentReference?.Ref == "tjones.atroop@state.pa.us",
                "The updatedByAgentReference is wrong");
            Assert.True(At.agentWorkstationPositionIdentification == "5", "The agentWorkstationPositionIdentification is wrong");
            Assert.True(At.agentRoleRegistryText?[0] == "Call Taking", "The agentRoleRegistryText is wrong");
            Assert.True(At.agencyReference?.Ref == "state.pa.us", "The agencyReference is wrong");
        }

        [Fact]
        public void SampleCallTransferEido_personComponent()
        {
            EidoType eido = GetSampleCallTransferEido();
            Assert.True(eido.personComponent != null && eido.personComponent.Count == 1,
                "The personComponent is null or the count is wrong");
            PersonInformationType Pit = eido.personComponent[0];
            Assert.True(Pit.Id == "123e4567-abcd-12d3-a456-426614174000", "Pit.Id is wrong");
            Assert.True(Pit.lastUpdateTimestamp == "2021-04-30T14:40:00.0-04:00", "Pit.lastUpdateTimestamp is wrong");
            Assert.True(Pit.updatedByAgencyReference?.Ref == "state.pa.us", "Pit.updatedByAgencyReference is wrong");
            Assert.True(Pit.personIncidentRoleRegistryText?[0] == "Caller", "Pit.personIncidentRoleRegistryText is wrong");
            Assert.True(Pit.callIdentifier?[0] == "urn:emergency:uid:callid:a56e556d871:bcf.state.pa.us",
                "Pit.callIdentifier is wrong");
            Assert.True(Pit.callBackReference?.Ref == "123e4567-e89b-1234-a456-426614174000",
                "Pit.callBackReference is wrong");
        }

        [Fact]
        public void SampleCallTransferEido_AdditionalDataComponent()
        {
            EidoType eido = GetSampleCallTransferEido();
            Assert.True(eido.additionalDataComponent != null && eido.additionalDataComponent.Count == 3,
                "The additionalDataComponent is null or the count is wrong");

            // The sample file does not have the urlPurpose property set to the appropriate purpose
            // values so a client does not know which type to deserialize the string into.
            // For example, additionalDataComponent[0].urlPurpose should be set to EmergencyCallData.ServiceInfo.
            // So its necessary to check the schema of the XML data before deserializing the XML document
            // into a class.
            foreach (AdditionalDataType Adt  in eido.additionalDataComponent)
            {
                if (Adt.additionalDataByValue != null)
                {
                    string strType = GetAdditionalDataType(Adt.urlPurpose, Adt.additionalDataByValue);
                    Assert.True(string.IsNullOrEmpty(strType) == false, "strType is null or empty");

                    switch (strType)
                    {
                        case PurposeTypes.Comment:
                            CommentType Ct = XmlHelper.DeserializeFromString<CommentType>(Adt.
                                additionalDataByValue);
                            Assert.True(Ct != null, "The third additionalDataComponent is invalid");
                            break;
                        case PurposeTypes.DeviceInfo:

                            break;
                        case PurposeTypes.ProviderInfo:
                            ProviderInfoType Pit = XmlHelper.DeserializeFromString<ProviderInfoType>(
                                Adt.additionalDataByValue);
                            Assert.True(Pit != null, "The second additionalDataComponent is invalid");
                            break;
                        case PurposeTypes.ServiceInfo:
                            ServiceInfoType Sit = XmlHelper.DeserializeFromString<ServiceInfoType>(
                                Adt.additionalDataByValue);
                            Assert.True(Sit != null, "The first additionalDataComponent is invalid");
                            break;
                        case PurposeTypes.SubscriberInfo:

                            break;
                    }
                }
                else if (string.IsNullOrEmpty(Adt.additionalDataByReferenceUrl) == false)
                {
                    // TODO: De-reference the additionalDataByReferenceUrl to get the additional data.
                }
            }
        }

        /// <summary>
        /// Gets the XML schema type for additional data. If the strPurpose is null, then this function
        /// searches the strAddDataXml input string for the additional data XML schema identifier.
        /// </summary>
        /// <param name="strPurpose">Purpose parameter that identifies the additional data schema. This
        /// parameter can be set to null if a purpose parameter was not provided.</param>
        /// <param name="strAddDataXml">String containing the additional data XML document.</param>
        /// <returns>Returns a string that identifies the schema of the additional data XML document.
        /// For example: EmergencyCallData.ServiceInfo. Returns null if the additional data XML
        /// schema could not be identified.</returns>
        private string GetAdditionalDataType(string strPurpose, string strAddDataXml)
        {
            if (string.IsNullOrEmpty(strPurpose) == false)
                return strPurpose;

            string strType = null;
            if (strAddDataXml.IndexOf(PurposeTypes.Comment) >= 0)
                strType = PurposeTypes.Comment;
            else if (strAddDataXml.IndexOf(PurposeTypes.DeviceInfo) >= 0)
                strType = PurposeTypes.DeviceInfo;
            else if (strAddDataXml.IndexOf(PurposeTypes.ProviderInfo) >= 0)
                strType = PurposeTypes.ProviderInfo;
            else if (strAddDataXml.IndexOf(PurposeTypes.ServiceInfo) >= 0)
                strType = PurposeTypes.ServiceInfo;
            else if (strAddDataXml.IndexOf(PurposeTypes.SubscriberInfo) >= 0)
                strType = PurposeTypes.SubscriberInfo;

            return strType;
        }

        [Fact]
        public void SampleCallTransferEido_LocationComponent()
        {
            EidoType eido = GetSampleCallTransferEido();
            Assert.True(eido.locationComponent != null && eido.locationComponent.Count == 2,
                "The locationComponent is null or the count is wrong");

            LocationInformationType Lit1 = eido.locationComponent[0];
            Assert.True(Lit1.locationTypeDescriptionRegistryText == "RoutingLocation",
                "The first locationTypeDescriptionRegistryText is wrong");
            Assert.NotNull(Lit1.locationByValue);
            Presence pres = XmlHelper.DeserializeFromString<Presence>(Lit1.locationByValue);
            Assert.True(pres != null, "Lit1.locationByValue is not valid");

            LocationInformationType Lit2 = eido.locationComponent[1];
            Assert.True(Lit2.locationTypeDescriptionRegistryText == "Caller", "The second " +
                "locationTypeDescriptionRegistryText is wrong");
            Assert.True(Lit2.locationByReferenceUrl == "https://lrf.osp.com?oasufdqwerjn12346jfias",
                "Lit2.locationByReferenceUrl is wrong");
        }

        [Fact]
        public void EidoWithJcard()
        {
            string strEidoPath = Path.Combine(FilePath, "EidoWithJcard.json");
            Assert.True(File.Exists(strEidoPath), "EidoWithJcard.json not found");
            string strEido = File.ReadAllText(Path.Combine(FilePath, "EidoWithJcard.json"));
            Assert.True(string.IsNullOrEmpty(strEido) == false, "Error reading the file");
            EidoType eido = EidoHelper.FromString(strEido);
            Assert.True(eido != null, "Error deserializing the EIDO");
            string strJcard = eido.agencyComponent?[0]?.agencyJcard;
            Assert.True(string.IsNullOrEmpty(strJcard) == false, "No JCard available");

            vcardType Vc = JCard.JCardStringToVCardType(strJcard);
            Assert.True(Vc != null, "Error converting the JCard string to a vcardType");
            Assert.True(Vc.FirstName == "John", "FirstName is wrong");
            Assert.True(Vc.LastName == "Doe");
            string strOrg = Vc.org?[0].text?[0];
            Assert.True(strOrg == "PSAP Name", "The organization is wrong");
            Assert.True(Vc.Street == "123 Main Street", "Street is wrong");
            Assert.True(Vc.City == "AnyTown", "City is wrong");
            Assert.True(Vc.State == "NY", "State is wrong");
            Assert.True(Vc.TelephoneNumber == "8185553333", "TelephoneNumber is wrong");
            Assert.True(Vc.EMail == "Psap@PsapName.org", "EMail is wrong");
        }

    }
}
