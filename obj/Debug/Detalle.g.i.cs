﻿#pragma checksum "C:\Users\Ivan\Documents\Visual Studio 2010\Projects\RedSocial\Detalle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DA16CABF5997D277EFE04C2937DA7BD"
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
    
    
    public partial class Detalle : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock lNombre;
        
        internal System.Windows.Controls.TextBlock lApelldio;
        
        internal System.Windows.Controls.TextBlock lDireccion;
        
        internal System.Windows.Controls.TextBlock lEmail;
        
        internal System.Windows.Controls.TextBlock lCumpleaños;
        
        internal System.Windows.Controls.TextBlock tNombre;
        
        internal System.Windows.Controls.TextBlock tApellido;
        
        internal System.Windows.Controls.TextBlock tDireccion;
        
        internal System.Windows.Controls.TextBlock tEmail;
        
        internal System.Windows.Controls.TextBlock tCumpleaños;
        
        internal Microsoft.Phone.Controls.Maps.Map mapFriend;
        
        internal Microsoft.Phone.Controls.Maps.MapLayer mapLayerFriend;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RedSocial;component/Detalle.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.lNombre = ((System.Windows.Controls.TextBlock)(this.FindName("lNombre")));
            this.lApelldio = ((System.Windows.Controls.TextBlock)(this.FindName("lApelldio")));
            this.lDireccion = ((System.Windows.Controls.TextBlock)(this.FindName("lDireccion")));
            this.lEmail = ((System.Windows.Controls.TextBlock)(this.FindName("lEmail")));
            this.lCumpleaños = ((System.Windows.Controls.TextBlock)(this.FindName("lCumpleaños")));
            this.tNombre = ((System.Windows.Controls.TextBlock)(this.FindName("tNombre")));
            this.tApellido = ((System.Windows.Controls.TextBlock)(this.FindName("tApellido")));
            this.tDireccion = ((System.Windows.Controls.TextBlock)(this.FindName("tDireccion")));
            this.tEmail = ((System.Windows.Controls.TextBlock)(this.FindName("tEmail")));
            this.tCumpleaños = ((System.Windows.Controls.TextBlock)(this.FindName("tCumpleaños")));
            this.mapFriend = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("mapFriend")));
            this.mapLayerFriend = ((Microsoft.Phone.Controls.Maps.MapLayer)(this.FindName("mapLayerFriend")));
        }
    }
}

