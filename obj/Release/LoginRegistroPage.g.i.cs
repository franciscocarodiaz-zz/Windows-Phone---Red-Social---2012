﻿#pragma checksum "D:\Users\Luismi\Universidad\Docencia\2011-2012\Máster DAIDM\WP7\Implementaciones nueva\RedSocial\RedSocial\LoginRegistroPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5368BA8970517FF2DE92F62BD5809096"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.261
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RedSocial {
    
    
    public partial class LoginRegistroPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard CheckingUserCredential;
        
        internal System.Windows.Media.Animation.Storyboard FinishCheckingUserCredential;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivotLogin;
        
        internal System.Windows.Controls.Canvas canvasChecking;
        
        internal System.Windows.Controls.ProgressBar pbProgressChecking;
        
        internal System.Windows.Controls.Canvas canvasCredentials;
        
        internal System.Windows.Controls.TextBox tbNameLogin;
        
        internal System.Windows.Controls.Button btLogin;
        
        internal System.Windows.Controls.PasswordBox tbPasswordLogin;
        
        internal System.Windows.Controls.TextBox tbUsernameRegister;
        
        internal System.Windows.Controls.TextBox tbNameRegister;
        
        internal System.Windows.Controls.TextBox tbSurnameRegister;
        
        internal System.Windows.Controls.TextBox tbAddressRegister;
        
        internal System.Windows.Controls.TextBox tbEmailRegister;
        
        internal System.Windows.Controls.PasswordBox tbPasswordRegister;
        
        internal System.Windows.Controls.PasswordBox tbPassword2Register;
        
        internal System.Windows.Controls.Button btRegister;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RedSocial;component/LoginRegistroPage.xaml", System.UriKind.Relative));
            this.CheckingUserCredential = ((System.Windows.Media.Animation.Storyboard)(this.FindName("CheckingUserCredential")));
            this.FinishCheckingUserCredential = ((System.Windows.Media.Animation.Storyboard)(this.FindName("FinishCheckingUserCredential")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivotLogin = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivotLogin")));
            this.canvasChecking = ((System.Windows.Controls.Canvas)(this.FindName("canvasChecking")));
            this.pbProgressChecking = ((System.Windows.Controls.ProgressBar)(this.FindName("pbProgressChecking")));
            this.canvasCredentials = ((System.Windows.Controls.Canvas)(this.FindName("canvasCredentials")));
            this.tbNameLogin = ((System.Windows.Controls.TextBox)(this.FindName("tbNameLogin")));
            this.btLogin = ((System.Windows.Controls.Button)(this.FindName("btLogin")));
            this.tbPasswordLogin = ((System.Windows.Controls.PasswordBox)(this.FindName("tbPasswordLogin")));
            this.tbUsernameRegister = ((System.Windows.Controls.TextBox)(this.FindName("tbUsernameRegister")));
            this.tbNameRegister = ((System.Windows.Controls.TextBox)(this.FindName("tbNameRegister")));
            this.tbSurnameRegister = ((System.Windows.Controls.TextBox)(this.FindName("tbSurnameRegister")));
            this.tbAddressRegister = ((System.Windows.Controls.TextBox)(this.FindName("tbAddressRegister")));
            this.tbEmailRegister = ((System.Windows.Controls.TextBox)(this.FindName("tbEmailRegister")));
            this.tbPasswordRegister = ((System.Windows.Controls.PasswordBox)(this.FindName("tbPasswordRegister")));
            this.tbPassword2Register = ((System.Windows.Controls.PasswordBox)(this.FindName("tbPassword2Register")));
            this.btRegister = ((System.Windows.Controls.Button)(this.FindName("btRegister")));
        }
    }
}

