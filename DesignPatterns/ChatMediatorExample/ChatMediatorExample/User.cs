using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediatorExample
{
    public class User
    {
        private string name;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public User(string name)
        {
            this.name = name;
        }

        public void sendMessage(string message)
        {
            ChatRoom.showMessage(this, message);
        }
    }
}
