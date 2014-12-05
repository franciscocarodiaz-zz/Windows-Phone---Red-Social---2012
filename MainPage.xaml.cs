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
using RedSocial.ViewModels;
namespace RedSocial
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string id;
        private string pass;

        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            this.Unloaded += new RoutedEventHandler(MainPage_Unloaded);
            //id = this.NavigationContext.QueryString["userId"];
            //pass = this.NavigationContext.QueryString["pass"];
        }

        void MainPage_Unloaded(object sender, RoutedEventArgs e)
        {
            GpsController.stopThread();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            id = this.NavigationContext.QueryString["userId"];
            pass = this.NavigationContext.QueryString["pass"];

            GpsController.OnLocationChanged += 
                new GpsController.LocationHandler
                    (GpsController_OnLocationChanged);
            GpsController.initializeGps();
            GpsController.startThread();

           // GpsController_OnLocationChanged(this, 
           //     new System.Device.Location.
           //         GeoCoordinate(37, -6));

        }



        void GpsController_OnLocationChanged(object sender, 
            System.Device.Location.GeoCoordinate myArgs)
        {
            Pushpin push = new Pushpin();
            push.Location = myArgs;
            push.Template = (ControlTemplate)
                Application.Current.Resources
                ["PushpinMyLocationTemplate"];
            push.Width = 60;
            push.Height = 60;
            mapLayerMyLocation.Children.Clear();
            mapLayerMyLocation.Children.Add(push);
        }


        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.FriendsViewModel.IsDataLoaded)
            {
                App.FriendsViewModel.DataLoaded += new EventHandler(FriendsViewModel_DataLoaded);
                App.FriendsViewModel.LoadData(id, pass);
            }
        }

        void FriendsViewModel_DataLoaded(object sender, EventArgs e)
        {
            /*Esto realmente no habría que hacerlo, ya que lo debe hacer el Expresion Blend sólo, pero como no lo hace,
             lo tenemos que meter nosotros hardcodeado.
             Primero de todo limpiamos la lista para que no haya elementos repetidos.
             */
            listaAmigos.Items.Clear();
            foreach (FriendViewModel f in App.FriendsViewModel.Items)
                listaAmigos.Items.Add(f);
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //Esto lo haremos en la página destino
        	//RedSocial.ViewModels.FriendViewModel f = FriendsViewModel.Items[listaAmigos.SelectedIndex];

            NavigationService.Navigate(new Uri("/Detalle.xaml?indexFriendSelect=" + listaAmigos.SelectedIndex, UriKind.Relative));

        }
    }
}