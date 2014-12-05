using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using RedSocial.SocialWebService;
using System.Collections.Generic;
using RedSocial.ViewModels;

namespace RedSocial.WebService
{
    public class WSConnectionImpl
    {

        public delegate void WSConnectionHandler(object myObject, Object result);
        public event WSConnectionHandler OnWSConnectionFinished;

        public void checkUser(string userId, string password)
        {
            ServicioWebSoapClient soc = new ServicioWebSoapClient();
            soc.checkUserCompleted += new EventHandler<checkUserCompletedEventArgs>(checkUserComplete);
            soc.checkUserAsync(userId, password);
        }

        private void checkUserComplete(object sender, checkUserCompletedEventArgs param)
        {
            OnWSConnectionFinished(this, param.Result);
        }

        public void addUser(string userId, string name, string surname, string address, string email, DateTime birthdate, string password)
        {
            ServicioWebSoapClient soc = new ServicioWebSoapClient();
            soc.AddUserCompleted += new EventHandler<AddUserCompletedEventArgs>(addUserComplete);
            soc.AddUserAsync(userId, name, surname, address, email, birthdate, password);
        }

        private void addUserComplete(object sender, AddUserCompletedEventArgs param)
        {
            OnWSConnectionFinished(this, param.Result);
        }

        public void getFriendsInformacion(string userId, string password)
        {
            ServicioWebSoapClient soc = new ServicioWebSoapClient();
            soc.GetFriendsInformationCompleted += new EventHandler<GetFriendsInformationCompletedEventArgs>(friendsInformacionComplete);
            soc.GetFriendsInformationAsync(userId, password);
        }

        private void friendsInformacionComplete(object sender, GetFriendsInformationCompletedEventArgs param)
        {
            List<FriendViewModel> friends = new List<FriendViewModel>();
            foreach (ArrayOfString elem in param.Result)
            {
                friends.Add(new ViewModels.FriendViewModel(elem));
            }
            OnWSConnectionFinished(this, friends);
        }
    }
}
