using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat
{
    public class messageController
    {
        private string currentUser;
        private string otherUser;
        private int milliseconds = 2500;
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
            mf.updateView(messageList, currentUser, otherUser);
        }

        public void permanentThread()
        {
            mm.messageUpdateMessage(currentUser, otherUser);
            Thread.Sleep(milliseconds);
        }

    }
}
