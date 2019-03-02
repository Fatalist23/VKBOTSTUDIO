using System;


namespace VKBotEng
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot VK = new Bot();
            foreach (var mes in VK.GetMessages())
            {
                Console.WriteLine(mes);
            }

            Console.ReadLine();

        }
    }
}
