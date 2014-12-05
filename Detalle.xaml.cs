using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;

namespace RedSocial
{
    public partial class Detalle : PhoneApplicationPage
    {
        private String indexFriendSelect;

        public Detalle()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            //idUser = this.NavigationContext.QueryString["userId"];
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            indexFriendSelect = this.NavigationContext.QueryString["indexFriendSelect"];
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            RedSocial.ViewModels.FriendViewModel f = App.FriendsViewModel.Items[Convert.ToInt32(indexFriendSelect)];
            //Seteamos lso elementos. Aunque no sé si debería funcionar sólo enlazándolo a través de Expression Blen, yo lo he intentado y a mi no me funciona
            tNombre.Text = f.Name;
            tApellido.Text = f.Surname;
            tDireccion.Text = f.Address;
            tEmail.Text = f.Email;
            tCumpleaños.Text = f.Birthdate.ToString("d MMM yyyy");

            //Centramos el mapa en la localización del amigo
           GpsController_OnLocationChanged(this, new System.Device.Location.GeoCoordinate(f.Latitude, f.Longitude));

        }

        void GpsController_OnLocationChanged(object sender,
            System.Device.Location.GeoCoordinate myArgs)
        {
            Pushpin push = new Pushpin();
            push.Location = myArgs;
            push.Template = (ControlTemplate)
                Application.Current.Resources
                ["PushpinMyLocationTemplate"];
            push.Width = 30;
            push.Height = 30;
            mapFriend.Center = myArgs;
            mapFriend.ZoomLevel = 8;
            mapLayerFriend.Children.Clear();
            mapLayerFriend.Children.Add(push);
    }

    }
}