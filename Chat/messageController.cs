﻿using System;
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
        private string currentUser;
        private string otherUser;
        private int milliseconds = 500;
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
            mf.updateMessageView(messageList, currentUser, otherUser);
        }

        public void updateOtherUser(string otherUser)
        {
            this.otherUser = otherUser;
        }

        public void permanentThread()
        {
            while (true)
            {
                if (otherUser != "")
                {
                    mm.messageUpdateMessage(currentUser, otherUser);
                }
                Thread.Sleep(milliseconds);
            }

        }

    }
}
