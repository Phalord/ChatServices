using ChatModel;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace ChatServiceLibrary
{
    public interface IChatServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void ChatRoomJoined();

        [OperationContract(IsOneWay = true)]
        void UserConnected(ObservableCollection<ChatParticipant> participants);
    }
}
