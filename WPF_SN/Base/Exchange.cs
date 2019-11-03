using System;
using System.Net.Sockets;

namespace WPF_SN.Base
{
    class Exchange
    {
        public static String Perform(String msg)
        {
            Socket clientSocket;
            byte[] buf;
            String str;

            clientSocket = null; // Переменная для цикла сообщений
            buf = new byte[256]; // буфер для обмена
            str = String.Empty; // Перевод буфера в строку

            try
            {
                Ini.setSettings();
            }
            catch
            {
                throw new Exception("Некоректная настройка");
            }

            // Переводим сообщение в байты 
            buf = Ini.communicationEncoding.GetBytes(msg);
            try
            { // Подключаемся к пункту назначения - код как у сервера
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // Соединяемся...
                clientSocket.Connect(Ini.endPoint);
                // Отправляем сообщение
                clientSocket.Send(buf);
                // Получаем ответ и переводим в строку
                str = "";
                do
                {
                    int n = clientSocket.Receive(buf);
                    str += Ini.communicationEncoding.GetString(buf, 0, n);
                } while (clientSocket.Available > 0);


                // Закрываем сокет
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return str;
        }
    }
}
