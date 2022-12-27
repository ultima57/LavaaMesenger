using Newtonsoft.Json;

namespace LavaaMesendjer.ConsoleClient.obj {
    class Program {
        static void Main(string[] args) {
            Message msg = new Message();
            Message msg1 = new Message("Gosling", "drive", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg1);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg.ToString());
            Console.WriteLine(msg.ToString());
        }
    }
}