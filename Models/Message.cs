namespace ComModule
{
    public class SendMessage
    {
        public int Id { get; set; }
        public string COMId { get; set; }
        public string Sender {get; set;}
        public string Reciever {get; set;}
        public string Message {get; set;}
        public string SentTime {get; set;}
        public bool ReadReceipt {get; set;}
        public string DateSent {get; set;}
        public string OtherInfo {get; set;}
        public string MessageStatus {get; set;}

    }
}