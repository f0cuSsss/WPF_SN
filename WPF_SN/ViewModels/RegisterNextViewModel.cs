using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WPF_SN.Commands;
using WPF_SN.Models;

namespace WPF_SN.ViewModels
{
    class RegisterNextViewModel : Base.BaseViewModel
    {
        public List<String> listCountries { get; set; }
        public List<String> listCodes { get; set; }

        public int countryIndex { get; set; }
        public int codeIndex { get; set; }
        public String Phone { get; set; }
        public String Password1 { get; set; }
        public String Password2 { get; set; }


        private ICommand _confirmButton;
        private ICommand _signInButton;


        public RegisterNextViewModel()
        {
            listCountries = RegisterNextModel.getInstance().getCountriesCodes().ToList();
            listCodes = new List<string> { "Code1", "Code2", "Code3" };

            _confirmButton = new RelayCommand(ConfirmCommand_Execute, ConfirmCommand_CanExecute);
            //_signInButton = new RelayCommand(SignInCommand_Execute, () => true);
            _signInButton = (new Commands.SignInCommand()).SignIn;
            countryIndex = codeIndex = 0;
            
        }
       
        public ICommand SaveCommand
        {
            get { return _confirmButton; }
        }

        //public ICommand SignInCommand
        //{
        //    get { return _signInButton; }
        //}

        //public void SignInCommand_Execute()
        //{
        //    MessageBox.Show("Sing in page");
        //}

        public void ConfirmCommand_Execute()
        {
            MessageBox.Show("Confirmed!" 
                + Environment.NewLine +
                $"FirstName: {RegisterModel.getInstance().FirstName}"
                + Environment.NewLine +
                $"SecondName: {RegisterModel.getInstance().SecondName}"
                + Environment.NewLine +
                $"Login: {RegisterModel.getInstance().Login}"
                + Environment.NewLine +
                $"Email: {RegisterModel.getInstance().Email}" 
                + Environment.NewLine +

                $"CountryID: {countryIndex}"
                + Environment.NewLine +
                $"PhoneCodeID: {codeIndex}"
                + Environment.NewLine +
                $"Phone: {Phone}" 
                + Environment.NewLine +
                $"Password: {RegisterNextModel.getInstance().Password}"
                );
        }


        public bool ConfirmCommand_CanExecute() => String.IsNullOrEmpty(Phone) 
                                                    //&& String.IsNullOrEmpty(RegisterNextModel.getInstance().Password.ToString()) 
                                                    //&& String.IsNullOrEmpty(RegisterNextModel.getInstance().Password2.ToString())
                                                    ? false : true;

    }
}
