using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SN.Base;
using WPF_SN.Interfaces;
using WPF_SN.NavigationService;

namespace WPF_SN.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Double _width;
        public Double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                OnPropertyChanged("Width");
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

        private List<IPageViewModel> _pageViewModels;
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        private IPageViewModel _currentPageViewModel;
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                _currentPageViewModel = value;
                OnPropertyChanged("CurrentPageViewModel");
            }
        }

        public MainViewModel()
        {
            // Add available pages and set page
            PageViewModels.Add(new AuthViewModel());
            PageViewModels.Add(new RegisterViewModel());
            PageViewModels.Add(new RegisterNextViewModel());
            PageViewModels.Add(new MessangerViewModel());

            CurrentPageViewModel = PageViewModels[0];


            Mediator.Subscribe("ToSignIn", ToSignIn);
            Mediator.Subscribe("ToRegister", ToReg);
            Mediator.Subscribe("ToNextReg", ToNextReg);
            Mediator.Subscribe("ToMessanger", ToMessanger);
            //Mediator.Subscribe("GoTo2Screen", OnGo2Screen);

            setSize();

        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
            setSize();
        }

        /* Методы перехода */
        private void ToSignIn(object obj) => ChangeViewModel(PageViewModels[0]);
        private void ToReg(object obj) => ChangeViewModel(PageViewModels[1]);
        private void ToNextReg(object obj) => ChangeViewModel(PageViewModels[2]);
        private void ToMessanger(object obj) => ChangeViewModel(PageViewModels[3]);

        private void setSize()
        {
            Height = CurrentPageViewModel.getHeight();
            Width = CurrentPageViewModel.getWidth();
        }


    }
}

