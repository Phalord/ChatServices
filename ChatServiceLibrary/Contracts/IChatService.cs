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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatService" in both code and config file together.
    [ServiceContract (CallbackContract = typeof(IChatServiceCallback),
                      SessionMode = SessionMode.Required)]
    public interface IChatService
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage();

        [OperationContract(IsOneWay = false)]
        string JoinChatRoom();

        [OperationContract(IsOneWay = false)]
        string CreateChatRoom(string roomName, int roomSize);

        [OperationContract(IsOneWay = false)]
        ObservableCollection<ChatParticipant> GetChatParticipants(string _roomCode);

        [OperationContract(IsOneWay = false)]
        ObservableCollection<ChatRoom> GetChatRooms();
    }
}
