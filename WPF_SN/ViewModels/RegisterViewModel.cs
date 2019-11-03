using System;
using System.Windows;
using System.Windows.Input;
using WPF_SN.Base;
using WPF_SN.Commands;
using WPF_SN.Models;
using WPF_SN.Views;

namespace WPF_SN.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        private String _firstName;
        public String FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                RegisterModel.getInstance().FirstName = _firstName;
                OnPropertyChanged();
            }
        }

        public String _secondName;
        public String SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                _secondName = value;
                RegisterModel.getInstance().SecondName = _secondName;
                OnPropertyChanged();
            }
        }

        private String _login;
        public String Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                RegisterModel.getInstance().Login = _login;
                OnPropertyChanged("Login");
            }
        }

        private String _email;
        public String Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                RegisterModel.getInstance().Email = _email;
                OnPropertyChanged();
            }
        }


        public RegisterViewModel()
        {
            _nextButton = new RelayCommand(NextCommand_Execute, NextCommand_CanExecute);
            _signInButton = new RelayCommand(SignInCommand_Execute, () => true);
        }

        private ICommand _nextButton;
        public ICommand NextCommand
        {
            get { return _nextButton; }
        }

        private ICommand _signInButton;
        public ICommand SignInCommand
        {
            get { return _signInButton; }
        }

        public void SignInCommand_Execute()
        {
            MessageBox.Show("Sign in command(this)");
        }


        public void NextCommand_Execute()
        {
            Register.getInstance().showForm();
        }

        public bool NextCommand_CanExecute() =>      String.IsNullOrEmpty(FirstName) 
                                                    &&  String.IsNullOrEmpty(SecondName)
                                                    &&  String.IsNullOrEmpty(Login)
                                                    &&  String.IsNullOrEmpty(Email)
                                                    ? false : true;
    }
}
