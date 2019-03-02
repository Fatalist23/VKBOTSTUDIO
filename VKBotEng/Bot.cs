using System;
using System.Collections.Generic;
using System.Text;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Enums.SafetyEnums;

namespace VKBotEng
{
    class Bot
    {
        private VkApi VkData;


         public Bot()
        {
            VkData = new VkApi();
            VkData.Authorize(new ApiAuthParams(){AccessToken = "1aa508fa46aaa32670c3bd58863fc2d796b694a2b186a9c2866942523da8a984b82f9eac45f161e91c04e" });
           
        }



    }
}
