using System;
using System.Windows;
using System.Windows.Input;

namespace WPF_SN.Commands
{
    public class SignInCommand
    {
        private ICommand _signInButton;

        public ICommand SignIn
        {
            get { return _signInButton; }
        }

        public SignInCommand()
        {
            _signInButton = new RelayCommand_v1(SignInCommand_Execute, SignInCommand_CanExecute);
        }

        public void SignInCommand_Execute()
        {
            MessageBox.Show("Sing in page");
        }

        public bool SignInCommand_CanExecute() => true;
    }
}
