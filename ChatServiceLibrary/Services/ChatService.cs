using ChatModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                     ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ChatService : IChatService
    {
        private IChatServiceCallback _callback = null;
        private ObservableCollection<ChatRoom> _chatRooms;
        private Dictionary<string, IChatServiceCallback> _clients;

        public string CreateChatRoom(string roomName, string roomSize)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ChatParticipant> GetChatParticipants(string _roomCode)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ChatRoom> GetChatRooms()
        {
            throw new NotImplementedException();
        }

        public string JoinChatRoom()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
