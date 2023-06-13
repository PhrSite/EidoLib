/////////////////////////////////////////////////////////////////////////////////////
//  File:   SubNotMsgTypes.cs                                       13 Jun 23 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace WebSocketSubNot;

/// <summary>
/// Class that defines all of the messages types for the EIDO conveyance subscribe/notify interface.
/// See Section 2.1.5 of NENA-STA-024.1a-2023.
/// </summary>
public static class SubNotMsgTypes
{
    /// <summary>
    /// Subscribe request. See Section 2.1.5.1.1 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string SubscribeRequest = "subscribe";

    /// <summary>
    /// Response to a subscribe request. See Section 2.1.5.1.2 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string SubscribeResponse = "subscribeResponse";

    /// <summary>
    /// Request to un-subscribe. See Section 2.1.5.2.1 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string UnsubscribeRequest = "unsubscribe";

    /// <summary>
    /// Response to an un-subscribe request. See Section 2.1.5.2.1 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string UnscribeResponse = "unsubscribeResponse";

    /// <summary>
    /// Request containing an EIDO JSON document. See Section 2.1.6.2 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string EventRequest = "event";

    /// <summary>
    /// Response to an event request. See Section 2.1.6.3.1 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string EventResponse = "eventResponse";

    /// <summary>
    /// Request to terminate a subscription. See Section 2.1.6.4 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string TerminateRequest = "terminate";

    /// <summary>
    /// Response to a request to terminate a subscription. See Section 2.1.6.5.1 of NENA-STA-024.1a-2023.
    /// </summary>
    public const string TerminateResponse = "terminateResponse";
}
