﻿#pragma checksum "D:\Users\Luismi\Universidad\Docencia\2011-2012\Máster DAIDM\WP7\Implementaciones nueva\RedSocial\RedSocial\FriendInformationPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AAF15083FBFAA3308124199149DFEBF6"
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
using Microsoft.Phone.Controls.Maps;
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
    
    
    public partial class FriendInformationPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock friendInfoPage;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock tbUserInfoAddress;
        
        internal System.Windows.Controls.TextBlock tbUserInfoMail;
        
        internal System.Windows.Controls.TextBlock tbUserInfoName;
        
        internal System.Windows.Controls.TextBlock tbUserInfoSurname;
        
        internal System.Windows.Controls.TextBlock tbUserInfoBirthDate;
        
        internal System.Windows.Controls.TextBlock tbUserInfoLatitude;
        
        internal System.Windows.Controls.TextBlock tbUserInfoLongitude;
        
        internal System.Windows.Controls.TextBlock tbUserInfoLatitude_caption;
        
        internal System.Windows.Controls.TextBlock tbUserInfoLatitude_caption1;
        
        internal System.Windows.Controls.TextBlock tbUserInfoAltitude;
        
        internal System.Windows.Controls.TextBlock tbUserInfoAltitude_caption;
        
        internal System.Windows.Controls.TextBlock tbUserInfoDate;
        
        internal System.Windows.Controls.TextBlock tbUserInfoDate_caption;
        
        internal Microsoft.Phone.Controls.Maps.Map mapFriend;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RedSocial;component/FriendInformationPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.friendInfoPage = ((System.Windows.Controls.TextBlock)(this.FindName("friendInfoPage")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.tbUserInfoAddress = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoAddress")));
            this.tbUserInfoMail = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoMail")));
            this.tbUserInfoName = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoName")));
            this.tbUserInfoSurname = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoSurname")));
            this.tbUserInfoBirthDate = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoBirthDate")));
            this.tbUserInfoLatitude = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoLatitude")));
            this.tbUserInfoLongitude = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoLongitude")));
            this.tbUserInfoLatitude_caption = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoLatitude_caption")));
            this.tbUserInfoLatitude_caption1 = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoLatitude_caption1")));
            this.tbUserInfoAltitude = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoAltitude")));
            this.tbUserInfoAltitude_caption = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoAltitude_caption")));
            this.tbUserInfoDate = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoDate")));
            this.tbUserInfoDate_caption = ((System.Windows.Controls.TextBlock)(this.FindName("tbUserInfoDate_caption")));
            this.mapFriend = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("mapFriend")));
        }
    }
}

