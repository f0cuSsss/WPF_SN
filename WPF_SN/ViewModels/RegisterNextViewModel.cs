using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WPF_SN.Commands;
using WPF_SN.Interfaces;
using WPF_SN.Models;
using WPF_SN.NavigationService;

namespace WPF_SN.ViewModels
{
    public class RegisterNextViewModel : Base.BaseViewModel, IPageViewModel
    {
        public List<String> listCountries { get; set; }
        public List<String> listCodes { get; set; }

        public int countryIndex { get; set; }
        public int codeIndex { get; set; }
        public String Phone { get; set; }
        public String Password1 { get; set; }
        public String Password2 { get; set; }


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


        public double getWidth() => Width;

        public double getHeight() => Height;

        public RegisterNextViewModel()
        {
            //listCountries = RegisterNextModel.getInstance().getCountriesCodes().ToList();
            listCodes = new List<string> { "Code1", "Code2", "Code3" };

            //Dictionary<String, String> dss = RegisterNextModel.getInstance().getCountriesCodes();
            
            //if(dss == null)
            //{
            //    MessageBox.Show("Пусто");
            //}
            //else
            //{
            //    MessageBox.Show("Не пусто");
            //}

            countryIndex = codeIndex = 0;
            Height = 550;
            Width = 350;
        }

        /* Команда "Зарегестрировать" */
        private ICommand _tryReg;
        public ICommand tryReg
        {
            get
            {
                return _tryReg ?? (_tryReg = new RelayCommand(x =>
                {
                    MessageBox.Show("Trying registration...");
                }));
            }
        }

        /* Команда "Перейти к предыдущей форме регистрации" */
        private ICommand _backToReg;
        public ICommand BackToReg
        {
            get
            {
                return _backToReg ?? (_backToReg = new RelayCommand(x =>
                {
                    Mediator.Notify("ToRegister", "");
                }));
            }
        }

        /* Команда "Перейти к авторизации" */
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


        //MessageBox.Show("Confirmed!" 
        //    + Environment.NewLine +
        //    $"FirstName: {RegisterModel.getInstance().FirstName}"
        //    + Environment.NewLine +
        //    $"SecondName: {RegisterModel.getInstance().SecondName}"
        //    + Environment.NewLine +
        //    $"Login: {RegisterModel.getInstance().Login}"
        //    + Environment.NewLine +
        //    $"Email: {RegisterModel.getInstance().Email}" 
        //    + Environment.NewLine +

        //    $"CountryID: {countryIndex}"
        //    + Environment.NewLine +
        //    $"PhoneCodeID: {codeIndex}"
        //    + Environment.NewLine +
        //    $"Phone: {Phone}" 
        //    + Environment.NewLine +
        //    $"Password: {RegisterNextModel.getInstance().Password}"
        //    );


    }
}
