﻿using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chat
{
    public class messageModel
    {
        private string currentUser;
        private string otherUser;
        messageController mc;
        static Dictionary<string, Message> messageDictionary;
        static List<Message> messageList = new List<Message>();
        static List<Message> messageListNext = new List<Message>();
        static List<messageBlob> messageBlobList = new List<messageBlob>();

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "inXj8sTPJUWlgLwQVJZSR2p4NR7EeJ4xZwHobH09",
            BasePath = "https://poli-chat-db-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient client;

        public messageModel(string currentUser, string otherUser, messageController mc)
        {
            this.currentUser = currentUser;
            this.otherUser = otherUser;
            this.mc = mc;
            client = new FireSharp.FirebaseClient(config);
            if (client != null) { }
            //MessageBox.Show("conn established"); 
            else
                MessageBox.Show("Connection error");
        }

        public async void messageUpdateMessage(string currentUser, string otherUser, Boolean newOtherUser)
        {
            //MessageBox.Show(currentUser + ", " + otherUser);
            string firstUser;
            string secondUser;

            if (String.Compare(currentUser, otherUser) > 0)
            {
                firstUser = otherUser;
                secondUser = currentUser;
            }
            else
            {
                firstUser = currentUser;
                secondUser = otherUser;
            }
            var response = await client.GetAsync("messages/" + firstUser + "_" + secondUser);
            messageDictionary = response.ResultAs<Dictionary<string, Message>>();
            if (messageDictionary != null)
            {
                try
                {
                    lock (((ICollection)messageList).SyncRoot)
                    {
                        messageList.Clear();
                        var aux = from x in messageDictionary select x;

                        foreach (var item in aux)
                        {
                            item.Value.dts = DateTime.ParseExact(item.Value.timestamp, "dd.M.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            messageList.Add(item.Value);

                        }
                        //order messages
                        messageList = messageList.OrderBy(o =>  o.dts).ToList();
                        if (messageList.Count > messageListNext.Count || newOtherUser)
                        {
                            mc.updateView(messageList, currentUser, otherUser);
                            messageListNext = messageList;
                        }
                    }
                }
                catch { };
   
            }
            else if (messageDictionary == null && newOtherUser)
            {
                messageList.Clear();
                mc.updateView(messageList, currentUser, otherUser);
            }



        }


    }
}
