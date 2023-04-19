/////////////////////////////////////////////////////////////////////////////////////
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
    /// There is only one sample test file provided in the NENA EIDO-JSON GitHub repository.
    /// </summary>
    [Trait("Category", "unit")]
    public class EidoUnitTests
    {
        private string FilePath = @"..\..\..\EidoTestFiles\";

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

            AdditionalDataType Adt1 = eido.additionalDataComponent[0];
            ServiceInfoType Sit = XmlHelper.DeserializeFromString<ServiceInfoType>(
                Adt1.additionalDataByValue);
            Assert.True(Sit != null, "The first additionalDataComponent is invalid");

            AdditionalDataType Adt2 = eido.additionalDataComponent[1];
            ProviderInfoType Pit = XmlHelper.DeserializeFromString<ProviderInfoType>(
                Adt2.additionalDataByValue);
            Assert.True(Pit != null, "The second additionalDataComponent is invalid");

            AdditionalDataType Adt3 = eido.additionalDataComponent[2];
            CommentType Ct = XmlHelper.DeserializeFromString<CommentType>( Adt3.additionalDataByValue);
            Assert.True(Ct != null, "The third additionalDataComponent is invalid");
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
    }
}
