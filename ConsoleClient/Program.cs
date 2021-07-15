using System;
using Newtonsoft.Json;

namespace MyMessenger_Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("yu", "hello", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);

            Message deserializeMessage = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializeMessage);

            //Console.WriteLine("Start!");
            //Console.WriteLine(msg.ToString());
        }
    }
}
