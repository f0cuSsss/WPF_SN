using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_SN.Interfaces;

namespace WPF_SN
{
    public class MessangerViewModel : Base.BaseViewModel, IPageViewModel
    {
        //public ObservableCollection<ChatContactNode> contacts { get; set; }

        //public ObservableCollection<ChatLogNode> chatList { get; set; }

        //public Command SendMsgToChat { get; set; }
        //public Command keyPress { get; set; }


        // public string userMsg { get; set; }


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


        public MessangerViewModel()
        {
            //contacts = ChatContactsModel.getInstance().getContacts();
            //setupCommands();
            Height = 560;
            Width = 940;
        }

        //private string _correspondenceNickName;
        //public ChatContactNode correspondenceNickName
        //{
        //    set
        //    {
        //        _correspondenceNickName = value.contactName;
        //        if (value != null)
        //        {
        //            chatList = ChatLogModel.getInstance().getChat(_correspondenceNickName);
        //            OnPropertyChanged(nameof(chatList));
        //        }

        //    }
        //}

        private void setupCommands()
        {
            //SendMsgToChat = new Command(() =>
            //{
            //    if (this._correspondenceNickName == null)
            //    {
            //        MessageBox.Show("Select User to send meesage");
            //        return;
            //    }
            //    ChatLogModel.getInstance().addMessageToLog(_correspondenceNickName, "It's me", userMsg);


            //    if (userMsg != "")
            //    {
            //        string[] words = userMsg.Split();
            //        foreach (string word in words)
            //        {
            //            // TODO доработать логику выбора ответа
            //            ObservableCollection<string> Answers = ChatBotModel.getInstance().getAnswers(word);
            //            if (Answers.Count < 1)
            //            {
            //                ChatLogModel.getInstance().addMessageToLog(_correspondenceNickName, _correspondenceNickName, "Я тебя не понимаю, напиши что-то годное!");
            //            }
            //            else
            //            {
            //                ChatLogModel.getInstance().addMessageToLog(_correspondenceNickName, _correspondenceNickName, Answers[1]);
            //            }
            //        }

            //        chatList = ChatLogModel.getInstance().getChat(_correspondenceNickName);
            //        OnPropertyChanged(nameof(chatList));

            //        userMsg = "";
            //        OnPropertyChanged(nameof(userMsg));
            //    }

            //});

            //keyPress = new Command(() =>
            //{
            //    if (this._correspondenceNickName == null)
            //    {
            //        MessageBox.Show("Select User to send meesage");
            //        return;
            //    }
            //    ChatLogModel.getInstance().addMessageToLog(_correspondenceNickName, "It's me", userMsg);


            //    if (userMsg != "")
            //    {
            //        string[] words = userMsg.Split();
            //        foreach (string word in words)
            //        {
            //            // TODO доработать логику выбора ответа
            //            ObservableCollection<string> Answers = ChatBotModel.getInstance().getAnswers(word);
            //            if (Answers.Count < 1)
            //            {
            //                ChatLogModel.getInstance().addMessageToLog(_correspondenceNickName, _correspondenceNickName, "Я тебя не понимаю, напиши что-то годное!");
            //            }
            //            else
            //            {
            //                ChatLogModel.getInstance().addMessageToLog(_correspondenceNickName, _correspondenceNickName, Answers[1]);
            //            }
            //        }

            //        chatList = ChatLogModel.getInstance().getChat(_correspondenceNickName);
            //        OnPropertyChanged(nameof(chatList));

            //        userMsg = "";
            //        OnPropertyChanged(nameof(userMsg));
            //    }

            //});

        }



        private void TBmsg_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Enter)
            //{
            //    //ButtonSendMessage.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //}

        }
    }
}
