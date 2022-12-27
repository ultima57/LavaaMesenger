namespace LavaaMesendjer.ConsoleClient.obj {
    [Serializable]
    public class Message {

        public string Username { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public Message(string username, string messageText, DateTime timeStamp) {
            Username = username;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }

        public Message() {
            Username = "System";
            MessageText = "Server is running...";
            TimeStamp = DateTime.Now;
        }

        public override string? ToString() {
            string ouput = String.Format("{0} <{2}>: {1} ", Username, MessageText, TimeStamp);
            return ouput;
        }
    }
}
