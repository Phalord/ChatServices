using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModel
{
    public class ChatRoom
    {
        public ChatRoom(string roomCode, string roomName, int roomSize)
        {
            RoomCode = roomCode;
            RoomName = roomName;
            RoomSize = roomSize;
            Participants = new List<ChatParticipant>();
            MessageHistory = new List<Message>();
        }

        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public int RoomSize { get; set; }
        public List<ChatParticipant> Participants { get; private set; }
        public List<Message> MessageHistory { get; private set; }

        public void AddParticipant(ChatParticipant _chatParticipant)
        {
            Participants.Add(_chatParticipant);
        }

        public void SendMessage(Message _message)
        {
            MessageHistory.Add(_message);
        }

        public void DeleteMessage(Message _message)
        {
            MessageHistory.Remove(_message);
        }
    }
}
