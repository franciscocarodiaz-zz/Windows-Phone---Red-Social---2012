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
using Microsoft.Phone.Controls.Primitives;
using RedSocial.WebService;
using System.Windows.Threading;

namespace RedSocial
{
    public partial class LoginRegistroPage : PhoneApplicationPage
    {
        DispatcherTimer dt = new DispatcherTimer();

        public LoginRegistroPage()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            //canvasChecking.Visibility = System.Windows.Visibility.Visible;
            CheckingUserCredentials.Begin();
            WSConnectionImpl wsConnection = new WSConnectionImpl();
            wsConnection.OnWSConnectionFinished += new WSConnectionImpl.WSConnectionHandler(onUserChecked);
            wsConnection.checkUser(tbNameLogin.Text, tbPasswordLogin.Password);
            pbProgressChecking.Maximum = 100;
            pbProgressChecking.Minimum = 0;
            pbProgressChecking.Value = 0;

            dt.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dt.Tick += new EventHandler(funcion_tick);
            dt.Start();
        }

        void funcion_tick(object sender, EventArgs events)
        {
            if (pbProgressChecking.Value < pbProgressChecking.Maximum)
                pbProgressChecking.Value += 10;
        }

        void onUserChecked(object myObject, object result)
        {
            switch ((int)result)
            {
                case 1:
                    NavigationService.Navigate(new Uri("/MainPage.xaml?userId=" + tbNameLogin.Text +"&pass=" + tbPasswordLogin.Password, UriKind.Relative));
                    StartTransition();
                    break;
                case -1:
                    MessageBox.Show(StringsResource.ErrorLogin1, StringsResource.ErrorLoginTitle, MessageBoxButton.OK);
                    break;
                case -2:
                    MessageBox.Show(StringsResource.ErrorLogin2, StringsResource.ErrorLoginTitle, MessageBoxButton.OK);
                    break;
                case -3:
                    MessageBox.Show(StringsResource.ErrorLogin3, StringsResource.ErrorLoginTitle, MessageBoxButton.OK);
                    break;
            }
            CheckingUserCredentialsEnd.Begin();
        }

        private void StartTransition()
        {
            SwivelTransition rotatetransition = new SwivelTransition();
            rotatetransition.Mode = SwivelTransitionMode.ForwardOut;

            PhoneApplicationPage phoneApplicationPage =
            (PhoneApplicationPage)(((PhoneApplicationFrame)Application.Current.RootVisual)).Content;

            ITransition transition = rotatetransition.GetTransition(phoneApplicationPage);
            transition.Completed += delegate
            {
                transition.Stop();
            };
            transition.Begin();
        }

        private LinearGradientBrush makeLinearGradientBrush(Color begin, Color end)
        {
            GradientStopCollection gsc = new GradientStopCollection();
            GradientStop gs = new GradientStop();
            gs.Color = begin;
            gs.Offset = 0;
            gsc.Add(gs);
            gs = new GradientStop();
            gs.Color = end;
            gs.Offset = 1;
            gsc.Add(gs);
            return new LinearGradientBrush(gsc, 90);
        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {
            Boolean error = false;
            if (tbUsernameRegister.Text.Equals(""))
            {
                tbUsernameRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbUsernameRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }

            if (tbSurnameRegister.Text.Equals(""))
            {
                tbSurnameRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbSurnameRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }


            if (tbNameRegister.Text.Equals(""))
            {
                tbNameRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbNameRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }


            if (tbAddressRegister.Text.Equals(""))
            {
                tbAddressRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbAddressRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }


            if (tbEmailRegister.Text.Equals(""))
            {
                tbEmailRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbEmailRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }


            if (tbPasswordRegister.Password.Equals(""))
            {
                tbPasswordRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbPasswordRegister.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }


            if (tbPassword2Register.Password.Equals("") || !tbPassword2Register.Password.Equals(tbPasswordRegister.Password))
            {
                tbPassword2Register.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferiorError"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
                error = true;
            }
            else
            {
                tbPassword2Register.Background = makeLinearGradientBrush((Color)Application.Current.Resources["colorTextBoxInferior"], (Color)Application.Current.Resources["colorTextBoxSuperior"]);
            }


            if (!error)
            {
                WSConnectionImpl wsConnection = new WSConnectionImpl();
                wsConnection.OnWSConnectionFinished += new WSConnectionImpl.WSConnectionHandler(onUserCreated);
                wsConnection.addUser(tbUsernameRegister.Text, tbNameRegister.Text, tbSurnameRegister.Text, tbAddressRegister.Text, tbEmailRegister.Text, DateTime.Now, tbPasswordRegister.Password);
                //CheckingUserCredential.Begin();
                pbProgressChecking.Maximum = 100;
                pbProgressChecking.Minimum = 0;
                pbProgressChecking.Value = 0;

                dt.Interval = new TimeSpan(0, 0, 0, 0, 100);
                dt.Tick += new EventHandler(funcion_tick);
                dt.Start();
            }
        }

        void onUserCreated(object myObject, object result)
        {
            switch ((int)result)
            {
                case 1:
                    pivotLogin.SelectedIndex = 0;
                    MessageBox.Show(StringsResource.UserCreated, StringsResource.UserCreatedTitle, MessageBoxButton.OK);
                    break;
                case -1:
                    MessageBox.Show(StringsResource.ErrorRegister1, StringsResource.UserCreatedTitle, MessageBoxButton.OK);
                    break;
                case -2:
                    MessageBox.Show(StringsResource.ErrorRegister1, StringsResource.UserCreatedTitle, MessageBoxButton.OK);
                    break;
            }
        }
    }
}