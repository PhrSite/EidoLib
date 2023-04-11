/////////////////////////////////////////////////////////////////////////////////////
//  File: EidoUnitTests.cs                                          19 Dec 22 PHR
/////////////////////////////////////////////////////////////////////////////////////

using Eido;
using NiemTypes;

namespace EidoUnitTests
{
    [Trait("Category", "unit")]
    public class EidoUnitTests
    {
        private string FilePath = @"..\..\..\EidoTestFiles\";

        [Fact]
        public void SampleCallTransferEido()
        {
            string strEido = File.ReadAllText(Path.Combine(FilePath, "SampleCallTransferEido.json"));
            EidoType eido = EidoHelper.FromString(strEido);
            Assert.NotNull(eido);

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
            string strEido = File.ReadAllText(Path.Combine(FilePath, "SampleCallTransferEido.json"));
            EidoType eido = EidoHelper.FromString(strEido);
            Assert.NotNull(eido);

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
            string strEido = File.ReadAllText(Path.Combine(FilePath, "SampleCallTransferEido.json"));
            EidoType eido = EidoHelper.FromString(strEido);
            Assert.NotNull(eido);
            Assert.True(eido.callbackComponent != null && eido.callbackComponent.Count == 1,
                "The callbackComponent is null or empty");
            CallbackType Cbt = eido.callbackComponent[0];

        }
    }
}
