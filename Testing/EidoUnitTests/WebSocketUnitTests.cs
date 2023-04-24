/////////////////////////////////////////////////////////////////////////////////////
//  File:   WebSocketUnitTests.cs                                   21 Apr 23 PHR
/////////////////////////////////////////////////////////////////////////////////////


using Eido;
using Newtonsoft.Json;
using WebSocketSubNot;

namespace EidoUnitTests
{
    [Trait("Category", "unit")]
    public class WebSocketUnitTests
    {
        private string FilePath = @"..\..\..\WebSocketTestFiles\";

        private string ReadFile(string strFileName)
        {
            string str = null;
            str = File.ReadAllText(Path.Combine(FilePath, strFileName));
            Assert.NotNull(str);
            return str;
        }

        [Fact]
        public void BasicSubscribe()
        {
            string strJson = ReadFile("BasicSubscribe.json");
            SubscribeRequest Sr = EidoHelper.DeserializeFromString<SubscribeRequest>(strJson);
            Assert.NotNull(Sr);

            Assert.True(Sr.subscribe.requestId == "63bfd612-f558-4489-b653-caa76a7edb9b",
                "The requestId is wrong");
            Assert.True(Sr.subscribe.requestType == "EIDO", "The requestType is wrong");
            Assert.True(Sr.subscribe.requestSubType == "new", "The requestSubType is wrong");
            Assert.True(Sr.subscribe.requestAccepts == "application/emergency.eido+json; version=\"1,2,3\"",
                "requestAccepts is wrong");
            Assert.True(Sr.subscribe.qualFilter == "<filter_string>", "qualFilter is wrong");
            Assert.True(Sr.subscribe.minRate == 1500, "minRate is wrong");
            Assert.True(Sr.subscribe.maxRate == null, "maxRate is not null");
            Assert.True(Sr.subscribe.qualFilterEvalPeriod == null, "qualFilterEvalPeriod is wrong");
            Assert.True(Sr.subscribe.expires == null, "expires is not null");
        }

        [Fact]
        public void BasicSubscribeResponse()
        {
            string strJson = ReadFile("BasicSubscribeResponse.json");
            SubscribeResponse Sr = EidoHelper.DeserializeFromString<SubscribeResponse>(strJson);
            Assert.NotNull(Sr);
            Assert.True(Sr.subscribeResponse.requestId == "63bfd612-f558-4489-b653-caa76a7edb9b",
                "requestId is wrong");
            Assert.True(Sr.subscribeResponse.subscriptionId == "sub1234", "subscriptionId is wrong");
            Assert.True(Sr.subscribeResponse.expires == 3600, "expires is wrong");
            Assert.True(Sr.subscribeResponse.statusCode == 200, "statusCode is wrong");
            Assert.True(Sr.subscribeResponse.statusText == "OK", "statusText is wrong");

            Assert.True(Sr.subscribeResponse.qualFilterEvalPeriod == null, "qualFilterEvalPeriod is not null");
            Assert.True(Sr.subscribeResponse.minRate == null, "minRate is not null");
            Assert.True(Sr.subscribeResponse.maxRate == null, "maxRate is not null");
        }

        /// <summary>
        /// The NotifyWithEido.json file uses the EIDO from the test file called SampleCallTransferEido.json
        /// </summary>
        [Fact]
        public void NotifyWithEido()
        {
            string strJson = ReadFile("NotifyWithEido.json");
            NotifyEvent Ne = EidoHelper.DeserializeFromString<NotifyEvent>(strJson);
            Assert.NotNull(Ne);

            Assert.True(Ne.Event.subscriptionId == "sub1234", "subscriptionId is wrong");
            Assert.True(Ne.Event.transactionId == "f894fjhdsh940jdf@192.168.2.1", "transactionId is wrong");

            Assert.True(Ne.Event.notification != null && Ne.Event.notification.Count == 1,
                "notification is null or empty");

            // If we make it here, the EIDO was successfully deserialized, so just spot check a few things.
            EidoType eido = Ne.Event.notification[0];
            Assert.True(eido.updatedByAgencyReference?.Ref != null && eido.updatedByAgencyReference.Ref ==
                "state.pa.us", "The updatedByAgencyReference is wrong");
            Assert.True(eido.updatedByAgentReference?.Ref != null &&
                eido.updatedByAgentReference.Ref == "tjones.atroop@state.pa.us",
                "The updatedByAgentReference is wrong");
            Assert.True(eido.issuingElementIdentification != null && eido.issuingElementIdentification ==
                "idx.state.pa.us", "The issuingElementIdentification is wrong");
            Assert.True(eido.callComponent != null && eido.callComponent.Count == 1,
                "The callComponent is null or empty");
            Assert.True(eido.callbackComponent != null && eido.callbackComponent.Count == 1,
                "The callbackComponent is null or empty");
            Assert.True(eido.agencyComponent != null && eido.agencyComponent.Count == 1,
                "The agencyComponent is null or empty");
            Assert.True(eido.agentComponent != null && eido.agentComponent.Count == 1,
                "The agentComponent is null or empty");
            Assert.True(eido.additionalDataComponent != null && eido.additionalDataComponent.Count == 3,
                "The additionalDataComponent is null or empty");
            Assert.True(eido.locationComponent != null && eido.locationComponent.Count == 2,
                "The locationComponent is null or empty");
            Assert.True(eido.personComponent != null && eido.personComponent.Count == 1,
                "The personComponent is null or empty");
        }

        [Fact]
        public void NotifyResponse()
        {
            string strJson = ReadFile("NotifyResponse.json");
            NotifyEventResponse Nr = EidoHelper.DeserializeFromString<NotifyEventResponse>(strJson);
            Assert.NotNull(Nr);
            Assert.True(Nr.eventResponse.transactionId == "f894fjhdsh940jdf@192.168.2.1", "transctionId is wrong");
            Assert.True(Nr.eventResponse.statusCode == 200, "statusCode is wrong");
            Assert.True(Nr.eventResponse.statusText == "OK", "statusText is wrong");
        }

        [Fact]
        public void BasicUnsubscribe()
        {
            string strJson = ReadFile("BasicUnsubscribe.json");
            UnsubscribeRequest Ur = EidoHelper.DeserializeFromString<UnsubscribeRequest>(strJson);
            Assert.NotNull(Ur);
            Assert.True(Ur.unsubscribe.requestId == "63bfd612-f558-4489-b653-caa76a7edb9b",
                "requestId is wrong");
            Assert.True(Ur.unsubscribe.subscriptionId == "sub1234", "subscriptionId is wrong");
        }

        [Fact]
        public void BasicUnsubscribeResponse()
        {
            string strJson = ReadFile("BasicUnsubscribeResponse.json");
            UnsubscribeResponse Ur = EidoHelper.DeserializeFromString<UnsubscribeResponse>(strJson);
            Assert.NotNull(Ur);
            Assert.True(Ur.unsubscribeResponse.subscriptionId == "sub1234", "subscriptionId is wrong");
            Assert.True(Ur.unsubscribeResponse.statusCode == 200, "statusCode is wrong");
            Assert.True(Ur.unsubscribeResponse.statusText == "Unsubscribed", "statusText is wrong");
        }

        [Fact]
        public void TerminateRequest()
        {
            string strJson = ReadFile("TerminateRequest.json");
            TerminateRequest Tr = EidoHelper.DeserializeFromString<TerminateRequest>(strJson);
            Assert.NotNull(Tr);
            Assert.True(Tr.terminate.requestId == "63bfd612-f558-4489-b653-caa76a7edb9b", "requestId is wrong");
            Assert.True(Tr.terminate.subscriptionId == "sub1234", "subscriptionId is wrong");
        }

        [Fact]
        public void TerminateResponse()
        {
            string strJson = ReadFile("TerminateResponse.json");
            TerminateResponse Tr = EidoHelper.DeserializeFromString<TerminateResponse>(strJson);
            Assert.NotNull(Tr);
            Assert.True(Tr.terminateResponse.requestId == "63bfd612-f558-4489-b653-caa76a7edb9b",
                "requestId is wrong");
            Assert.True(Tr.terminateResponse.subscriptionId == "sub1234", "subscriptionId is wrong");
            Assert.True(Tr.terminateResponse.statusCode == 200, "statusCode is wrong");
            Assert.True(Tr.terminateResponse.statusText == "OK", "statusText is wrong");
        }
    }
}
