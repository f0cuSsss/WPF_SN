using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_SN.Base;
using WPF_SN.Commands;
using WPF_SN.Interfaces;
using WPF_SN.NavigationService;

namespace WPF_SN.ViewModels
{
    public class AuthViewModel : BaseViewModel, IPageViewModel
    {
        private Double _width;
        public Double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                OnPropertyChanged("Wight");
            }
        }

        private Double _height;
        public Double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged("Height");
            }
        }

        public double getWidth() => Width;
        public double getHeight() => Height;

        public AuthViewModel()
        {
            Width = 350; Height = 440;
        }

        /* Команда "Регистрации" */
        private ICommand _toRegister;
        public ICommand toRegister
        {
            get
            {
                return _toRegister ?? (_toRegister = new RelayCommand(x =>
                {
                    Mediator.Notify("ToRegister", "");
                }));
            }
        }


        /* Команда "Войти" */
        private ICommand _tryAuth;
        public ICommand tryAuth
        {
            get
            {
                return _tryAuth ?? (_tryAuth = new RelayCommand(x =>
                {
                    if(trySignIn())
                    {
                       Mediator.Notify("ToMessanger", "");
                    }
                    else
                    {
                        MessageBox.Show("Authorisation Error");
                    }
                    
                }));
            }
        }

        private bool trySignIn()
        {
            return true;
        }


        /* Команда "Забыл пароль" */
        private ICommand _toForgotPass;
        public ICommand toForgotPass
        {
            get
            {
                return _toForgotPass ?? (_toForgotPass = new RelayCommand(x =>
                {
                    Mediator.Notify("ToForgotPass", "");
                }));
            }
        }

    }
}
