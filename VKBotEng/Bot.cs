using System;
using System.Collections.Generic;
using System.Text;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.Keyboard;

namespace VKBotEng
{
    class Bot
    {
        private VkApi VkData;
        private uint UserId;

         public Bot()
        {
            VkData = new VkApi();
            VkData.Authorize(new ApiAuthParams(){AccessToken = "1aa508fa46aaa32670c3bd58863fc2d796b694a2b186a9c2866942523da8a984b82f9eac45f161e91c04e" });
           
        }

         public string GetMessages(GetConversationsParams Params)
         {
            
            return GetMessageText(VkData.Messages.GetConversations(Params));
         }

         public string GetMessageText(GetConversationsResult Messages)
         {
             UserId = (uint)Messages.Items[0].LastMessage.FromId;
             return Messages.Items[0].LastMessage.Text;
         }

         public void MessageCheck(string Message)
         {
             switch (Message)
             {
                case "Старт": break;

                default: break;
             }
         }

         private MessageKeyboard GenerateKeyBoard(KeyboardButtonColor KeyColor,string[] args)
         {
            KeyboardBuilder Builder = new KeyboardBuilder();
             foreach (var Key in args)
             {
                 Builder.AddButton(Key, "smth", KeyColor);
             }

             return Builder.Build();
         }

         public void SendMessage(string MessageText)
         {
             VkData.Messages.Send(new MessagesSendParams { UserId = UserId, Message = MessageText, RandomId = new Random().Next(100, 1000000000) });
         }
         public void SendMessage(string MessageText,MessageKeyboard Board)
         {
             VkData.Messages.Send(new MessagesSendParams { UserId = UserId,Keyboard = Board, Message = MessageText, RandomId = new Random().Next(100, 1000000000) });
         }

    }
}
