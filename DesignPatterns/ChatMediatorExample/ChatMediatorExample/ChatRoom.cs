using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediatorExample
{
    public class ChatRoom
    {
        public static void showMessage(User user, string message)
        {
            Console.WriteLine(new DateTime().ToString() + " [" + user.getName() + "] : " + message);
        }
    }
}
