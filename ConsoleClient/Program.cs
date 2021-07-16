using System;
using Newtonsoft.Json;

namespace MyMessenger_Stepik
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();

        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }

        static void Main(string[] args)
        {
            /* Message msg = new Message("yu", "hello", DateTime.UtcNow);
             string output = JsonConvert.SerializeObject(msg);
             Console.WriteLine(output);

             Message deserializeMessage = JsonConvert.DeserializeObject<Message>(output);
             Console.WriteLine(deserializeMessage);*/

            //Console.WriteLine("Start!");
            //Console.WriteLine(msg.ToString());

            MessageID = 1;
            Console.WriteLine("Введите Ваше имя:");
            //UserName = "RusAl";
            UserName = Console.ReadLine();
            string MessageText = "";
            while (MessageText != "exit")
            {
                GetNewMessages();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(Sendmsg);
                }
            }
        }
    }
}
