using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WPF_SN.Base;

namespace WPF_SN.Models
{
    class RegisterNextModel
    {
        #region Singleton
        private static RegisterNextModel instance;
        public static RegisterNextModel getInstance()
        {
            if (instance == null)
                instance = new RegisterNextModel();
            return instance;
        }
        #endregion

        Socket clientSocket;
        byte[] buf;
        String str, msg;

        public IEnumerable<String> getCountries()
        {
            List<String> countries = new List<string>();
            countries.Add("Первая");
            countries.Add("Вторая");
            countries.Add("Третья");
            countries.Add("Четвертая");
            return countries;
        }

        public IEnumerable<String> getCountriesCodes()
        {
            // Формируем команду отправки сообщения
            String msg =
                          Configs.DB_CMD + Configs.CMD_SEPARATOR + StrQueriesDB.GET_COUNTRYCODE;

            // Обмениваемся данными с сервером
            String serverAnswer = null;
            try
            {
                serverAnswer = Exchange(msg);
            }
            catch (Exception ex)
            {
                return null;
            }

            // TODO: Разобрать ответ от сервера
        }

    //=========================================================================

        public String Exchange(String msg)
        {
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
