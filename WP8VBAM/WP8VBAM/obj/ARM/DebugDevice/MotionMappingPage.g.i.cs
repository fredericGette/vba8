﻿#pragma checksum "C:\Users\frede\Source\Repos\vba8\WP8VBAM\WP8VBAM\MotionMappingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A855292CDC60D45E0D33F79B6B5E471D"
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
using Microsoft.Phone.Shell;
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
    
    
    public partial class MotionMappingPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton appBarOkButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton appBarCancelButton;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.ListPicker Leftbtn;
        
        internal Microsoft.Phone.Controls.ListPicker Rightbtn;
        
        internal Microsoft.Phone.Controls.ListPicker Upbtn;
        
        internal Microsoft.Phone.Controls.ListPicker Downbtn;
        
        internal System.Windows.Controls.Button CalibrateBtn;
        
        internal System.Windows.Controls.Slider horizontalDeadzoneSlider;
        
        internal System.Windows.Shapes.Rectangle horizontalDeadzoneLock;
        
        internal System.Windows.Media.ImageBrush horizontalDeadzoneImage;
        
        internal System.Windows.Controls.Slider verticalDeadzoneSlider;
        
        internal System.Windows.Shapes.Rectangle verticalDeadzoneLock;
        
        internal System.Windows.Media.ImageBrush verticalDeadzoneImage;
        
        internal System.Windows.Controls.CheckBox adaptOrientationSwitch;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/VBA8;component/MotionMappingPage.xaml", System.UriKind.Relative));
            this.appBarOkButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("appBarOkButton")));
            this.appBarCancelButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("appBarCancelButton")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Leftbtn = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Leftbtn")));
            this.Rightbtn = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Rightbtn")));
            this.Upbtn = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Upbtn")));
            this.Downbtn = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Downbtn")));
            this.CalibrateBtn = ((System.Windows.Controls.Button)(this.FindName("CalibrateBtn")));
            this.horizontalDeadzoneSlider = ((System.Windows.Controls.Slider)(this.FindName("horizontalDeadzoneSlider")));
            this.horizontalDeadzoneLock = ((System.Windows.Shapes.Rectangle)(this.FindName("horizontalDeadzoneLock")));
            this.horizontalDeadzoneImage = ((System.Windows.Media.ImageBrush)(this.FindName("horizontalDeadzoneImage")));
            this.verticalDeadzoneSlider = ((System.Windows.Controls.Slider)(this.FindName("verticalDeadzoneSlider")));
            this.verticalDeadzoneLock = ((System.Windows.Shapes.Rectangle)(this.FindName("verticalDeadzoneLock")));
            this.verticalDeadzoneImage = ((System.Windows.Media.ImageBrush)(this.FindName("verticalDeadzoneImage")));
            this.adaptOrientationSwitch = ((System.Windows.Controls.CheckBox)(this.FindName("adaptOrientationSwitch")));
        }
    }
}

