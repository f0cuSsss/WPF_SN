using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security;
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

        /* TODO: Попробовтаь создать на обчной стринге и проверить */
        //private SecureString _password;
        //public String Password
        //{
        //    get
        //    {
        //        if (!_password.Equals(null))
        //            return SecureStringToString(_password);
        //        else
        //        {
        //            return "Password is null";
        //        }
        //    }
        //    set
        //    {
        //        foreach (var item in value)
        //        {
        //            _password.AppendChar(item);
        //        }

        //    }
        //}
        ///// <summary>
        ///// Получить String с SecureString
        ///// </summary>
        ///// <param name="secureString"></param>
        ///// <returns></returns>
        //private String SecureStringToString(SecureString secureString)
        //{
        //    IntPtr secStrPtr = IntPtr.Zero;
        //    try
        //    {
        //        secStrPtr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
        //        return Marshal.PtrToStringUni(secStrPtr);
        //    }
        //    finally
        //    {
        //        Marshal.ZeroFreeGlobalAllocUnicode(secStrPtr);
        //    }
        //}


         /* Так хранить нельзя! */
        public String Password { get; set; }

        public Dictionary<String, string> getCountriesCodes()
        {
            // Формируем команду отправки сообщения
            String msg = Configs.DB_CMD + Configs.CMD_SEPARATOR + StrQueriesDB.GET_COUNTRYCODE;

            // Обмениваемся данными с сервером
            String serverAnswer = null;
            try
            {
                serverAnswer = Exchange.Perform(msg);
            }
            catch
            {
                //throw new Exception(ex.Message);
                return null;
            }

            //List<String> countries = null;

            Dictionary<String, String> countryCode = null;

            /* Анализируем ответ сервера */
            String[] parts = serverAnswer.Split(Configs.CMD_SEPARATOR);
            if (Configs.STATUS_DB_OK.Equals(parts[0]))
            {
                countryCode = new Dictionary<string, string>();
                String[] argsRow = null;
                String[] argsCol = null;
                try
                {
                    argsRow = parts[1].Split(Configs.ROWDB_SEPARATOR);
                    foreach (var item in argsRow)
                    {
                        argsCol = item.Split(Configs.COLUMNDB_SEPARATOR);
                        countryCode.Add(argsCol[0], argsCol[1]);
                        if (!item.Equals(String.Empty))
                        {
                            //countries.Add($"{argsCol[0]}");
                            //countryCode.Add(argsCol[0], argsCol[1]);
                        }
                    }

                } catch { }
            }
            else if (Configs.STATUS_DB_FAIL.Equals(parts[0]))
            {

            }
            else
            {

            }


            ///* Анализируем ответ сервера */
            //String[] parts = serverAnswer.Split(Configs.CMD_SEPARATOR);
            //if (Configs.STATUS_DB_OK.Equals(parts[0]))
            //{
            //    countries = new List<string>();
            //    String[] argsRow = null;
            //    String[] argsCol = null;
            //    try
            //    {
            //        argsRow = parts[1].Split(Configs.ROWDB_SEPARATOR);
            //        foreach (var item in argsRow)
            //        {
            //            argsCol = item.Split(Configs.COLUMNDB_SEPARATOR);
            //            if (!item.Equals(String.Empty))
            //            {
            //                countries.Add($"{argsCol[0]}");
            //            }
            //        }

            //    }
            //    catch
            //    {
            //        //throw;
            //        //return;
            //    }

            //}
            //else if (Configs.STATUS_DB_FAIL.Equals(parts[0]))
            //{

            //}
            //else
            //{

            //}

            //return countries;
            return countryCode;
        }

        //=========================================================================

        
    }
}
