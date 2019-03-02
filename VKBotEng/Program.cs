using System;
using VkNet.Model.RequestParams;


namespace VKBotEng
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot VK = new Bot();
            while (true)
            {
               Console.WriteLine( VK.GetMessages(new GetConversationsParams()));
            }
           
            Bot AK = new Bot();
            Console.ReadLine();

        }
    }
}
