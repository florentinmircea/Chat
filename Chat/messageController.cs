using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Chat
{
    public class messageController
    {
        private User otherUserEntity;
        private string currentUser;
        private string otherUser;
        private int milliseconds = 300;
        Boolean newOtherUser = false;
        messageModel mm;
        MainForm mf;
        public messageController(string currentUser, string otherUser, MainForm mf)
        {
            this.currentUser = currentUser;
            this.otherUser = otherUser;

            this.mf = mf;
            this.mm = new messageModel(currentUser, otherUser, this);
            Thread thr = new Thread(new ThreadStart(this.permanentThread));
            thr.Start();
        }

        public void updateView(List<Message> messageList, string currentUser, string otherUser)
        {
            mf.updateMessageView(messageList, currentUser, otherUser, this.otherUserEntity);
        }

        public void updateOtherUser(User otherUser)
        {
            this.otherUserEntity = otherUser;
            this.otherUser = otherUser.username;
            newOtherUser = true;
        }

        public void permanentThread()
        {
            while (true)
            {
                if (otherUser != "")
                {
                    mm.messageUpdateMessage(currentUser, otherUser, newOtherUser);
                    newOtherUser = false;
                }
                Thread.Sleep(milliseconds);
            }

        }

    }
}
