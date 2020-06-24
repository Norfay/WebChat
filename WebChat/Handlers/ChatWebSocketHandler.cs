using Microsoft.Web.WebSockets;

namespace ClientApi.Handlers
{
    //Обработчик вебсокет-запросов для чатов
    public class ChatWebSocketHandler : WebSocketHandler
    {        
        private static WebSocketCollection _chatClients = new WebSocketCollection();

        public ChatWebSocketHandler(){}

        //обработчки открытия вебсокет-соединения
        public override void OnOpen()
        {
            _chatClients.Add(this);
        }        

        /// <summary>
        /// Обработчик отправки вебсокет-сообщения
        /// </summary>
        /// <param name="message">Принятое сообщение</param>
        public override void OnMessage(string message)
        {           
            _chatClients.Broadcast(message); //for testing
        }

        public override void OnClose()
        {
            Close();
        }       
    }
}