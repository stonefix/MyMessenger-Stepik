using System;
using System.Collections.Generic;
using System.Text;

namespace MyMessenger_Stepik
{
    public class Message
    {
        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }

        public Message()
        {
            UserName = "System";
            MessageText = "Server is running...";
            TimeStamp = DateTime.Now;
        }

        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            string output = String.Format("{0}, <{2}>: {1}", UserName, MessageText, TimeStamp);
            return output;
        }
    }
}
