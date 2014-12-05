using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using RedSocial.WebService;
using System.Linq;

namespace RedSocial.ViewModels
{
    public class FriendsViewModel
    {

        private string userId;
        private string pass;

        public FriendsViewModel()
        {
            Items = new ObservableCollection<FriendViewModel>();
        }

        /// <summary>
        /// Colección para objetos ItemViewModel.
        /// </summary>
        public ObservableCollection<FriendViewModel> Items { get; private set; }


        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Crear y agregar unos pocos objetos ItemViewModel a la colección Items.
        /// </summary>
        public void LoadData(string userId, string pass)
        {
            this.userId = userId;
            this.pass = pass;
            WSConnectionImpl wsConnection = new WSConnectionImpl();
            wsConnection.OnWSConnectionFinished += new WSConnectionImpl.WSConnectionHandler(wsConnection_OnWSConnectionFinished);
            wsConnection.getFriendsInformacion(userId, pass);
            //IEnumerable<FriendViewModel> ad = from elem in Items where elem.Id == "10" select elem;
            
        }

        /// <summary>
        /// Crear y agregar unos pocos objetos ItemViewModel a la colección Items.
        /// </summary>
        public void LoadData()
        {
            if (userId != null && pass != null)
            {
                WSConnectionImpl wsConnection = new WSConnectionImpl();
                wsConnection.OnWSConnectionFinished += new WSConnectionImpl.WSConnectionHandler(wsConnection_OnWSConnectionFinished);
                wsConnection.getFriendsInformacion(userId, pass);
            }
        }

        private void wsConnection_OnWSConnectionFinished(object myObject, object result)
        {
            //this.Items.Add(new ItemViewModel() { LineOne = "runtime dieciséis", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });
            List<FriendViewModel> lista = (List<FriendViewModel>)result;
            foreach (FriendViewModel friend in lista)
            {
                Items.Add(friend);
            }
            this.IsDataLoaded = true;
            NotifyDataLoaded();
        }

        public event EventHandler DataLoaded;

        private void NotifyDataLoaded()
        {
            EventHandler handler = DataLoaded;
            if (null != handler)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}