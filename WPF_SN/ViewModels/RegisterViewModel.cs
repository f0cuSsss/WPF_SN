using System;
using System.Windows;
using System.Windows.Input;
using WPF_SN.Base;
using WPF_SN.Commands;
using WPF_SN.Interfaces;
using WPF_SN.Models;
using WPF_SN.NavigationService;
using WPF_SN.Views;

namespace WPF_SN.ViewModels
{
    public class RegisterViewModel : BaseViewModel, IPageViewModel
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

        /*=================================*/

        private Double _width;
        public Double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                //OnPropertyChanged("Wight");
            }
        }

        private Double _height;
        public Double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                //OnPropertyChanged("Height");
            }
        }


        public RegisterViewModel()
        {
            Width = 350; Height = 550;
        }

        private ICommand _toNextReg;
        public ICommand ToNextReg
        {
            get
            {
                return _toNextReg ?? (_toNextReg = new RelayCommand(x =>
                {
                    Mediator.Notify("ToNextReg", "");
                }));
            }
        }

        /* Команда "Авторизации" */
        private ICommand _toSignIn;
        public ICommand ToSignIn
        {
            get
            {
                return _toSignIn ?? (_toSignIn = new RelayCommand(x =>
                {
                    Mediator.Notify("ToSignIn", "");
                }));
            }
        }

        public double getWidth() => Width;

        public double getHeight() => Height;
    }
}
