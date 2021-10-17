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

        public string CreateChatRoom(string _roomName, int _roomSize)
        {
            string _roomCode = GenerateNewRoomCode();
            if (_roomCode == string.Empty)
            {
                Console.WriteLine("Se han acabado los códigos de sala disponibles");
                const string max_room_codes_reached = "2004";
                return max_room_codes_reached;
            } 
            else
            {
                _chatRooms.Add(new ChatRoom(_roomCode, _roomName, _roomSize));
                Console.WriteLine("Se ha creado una chat room con código: {0}",
                    _roomCode);
                const string chat_room_created = "2000";
                return chat_room_created;
            }
        }

        private string GenerateNewRoomCode()
        {
            string _newRoomCode = GenerateRoomCode();
            while (RoomCodeIsOccupied(_newRoomCode))
            {
                _newRoomCode = GenerateRoomCode();
            }
            return _newRoomCode;
        }

        private bool RoomCodeIsOccupied(string _roomCode)
        {
            foreach (ChatRoom _chatRoom in _chatRooms)
            {
                if (_chatRoom.RoomCode.Equals(_roomCode))
                {
                    return true;
                }
            }
            return false;
        }

        private string GenerateRoomCode()
        {
            Random _random = new Random();
            const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string _roomCode = new string(Enumerable.Repeat(_chars, 5)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
            return _roomCode;
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
