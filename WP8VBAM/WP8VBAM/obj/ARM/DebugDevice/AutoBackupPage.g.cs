﻿#pragma checksum "C:\Users\frede\Source\Repos\vba8\WP8VBAM\WP8VBAM\AutoBackupPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EED37F172C75CC6430D9E6664A92339E"
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
using Telerik.Windows.Controls;


namespace PhoneDirect3DXamlAppInterop {
    
    
    public partial class AutoBackupPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal Microsoft.Phone.Controls.ListPicker backupTypePicker;
        
        internal Telerik.Windows.Controls.RadListPicker NBackupsPicker;
        
        internal System.Windows.Controls.CheckBox backupIngameSaveCheck;
        
        internal System.Windows.Controls.CheckBox backupLastManualSLotCheck;
        
        internal System.Windows.Controls.CheckBox backupAutoSLotCheck;
        
        internal System.Windows.Controls.CheckBox backupOnlyWifiCheck;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/VBA8;component/AutoBackupPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.backupTypePicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("backupTypePicker")));
            this.NBackupsPicker = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("NBackupsPicker")));
            this.backupIngameSaveCheck = ((System.Windows.Controls.CheckBox)(this.FindName("backupIngameSaveCheck")));
            this.backupLastManualSLotCheck = ((System.Windows.Controls.CheckBox)(this.FindName("backupLastManualSLotCheck")));
            this.backupAutoSLotCheck = ((System.Windows.Controls.CheckBox)(this.FindName("backupAutoSLotCheck")));
            this.backupOnlyWifiCheck = ((System.Windows.Controls.CheckBox)(this.FindName("backupOnlyWifiCheck")));
        }
    }
}

