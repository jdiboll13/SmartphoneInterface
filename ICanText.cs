namespace SmartphoneInterface
{
    interface ICanText
    {
        string TextMessage { get; set; }
        void SendText();
        void ReceiveText();
        void SendImageMessage();
    }
}