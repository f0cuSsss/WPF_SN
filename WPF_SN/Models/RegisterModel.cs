using System;
using System.Net.Sockets;
using WPF_SN.Base;

namespace WPF_SN.Models
{
    class RegisterModel
    {
        #region Singleton
        private static RegisterModel instance;
        public static RegisterModel getInstance()
        {
            if (instance == null)
                instance = new RegisterModel();
            return instance;
        }
        #endregion

        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }


    }
}
