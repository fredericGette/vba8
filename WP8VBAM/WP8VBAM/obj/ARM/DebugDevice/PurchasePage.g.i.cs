﻿#pragma checksum "C:\Users\frede\Source\Repos\vba8\WP8VBAM\WP8VBAM\PurchasePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B118EA66A3A4925494EDBAE3EE50EFB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace PhoneDirect3DXamlAppInterop {
    
    
    public partial class PurchasePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock titleLabel;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBlock txtLoading;
        
        internal System.Windows.Controls.TextBlock txtError;
        
        internal System.Windows.Controls.ItemsControl pics;
        
        internal System.Windows.Controls.Button UseCodeButton;
        
        internal System.Windows.Controls.TextBox tblkDeviceID;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/VBA8;component/PurchasePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.titleLabel = ((System.Windows.Controls.TextBlock)(this.FindName("titleLabel")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.txtLoading = ((System.Windows.Controls.TextBlock)(this.FindName("txtLoading")));
            this.txtError = ((System.Windows.Controls.TextBlock)(this.FindName("txtError")));
            this.pics = ((System.Windows.Controls.ItemsControl)(this.FindName("pics")));
            this.UseCodeButton = ((System.Windows.Controls.Button)(this.FindName("UseCodeButton")));
            this.tblkDeviceID = ((System.Windows.Controls.TextBox)(this.FindName("tblkDeviceID")));
        }
    }
}

