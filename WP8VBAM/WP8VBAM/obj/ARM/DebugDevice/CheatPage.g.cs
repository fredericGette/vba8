﻿#pragma checksum "C:\Users\frede\Source\Repos\vba8\WP8VBAM\WP8VBAM\CheatPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C62A35A135D636D25267CF9BFFA0464"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
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
    
    
    public partial class CheatPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot mainPivot;
        
        internal Microsoft.Phone.Controls.PivotItem addPivot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock descLabel;
        
        internal System.Windows.Controls.TextBox cheatDescBox;
        
        internal System.Windows.Controls.TextBox cheatCodeBox;
        
        internal Microsoft.Phone.Controls.PivotItem listPivot;
        
        internal System.Windows.Controls.Grid listPanel;
        
        internal System.Windows.Controls.TextBlock gameNameLabel;
        
        internal System.Windows.Controls.ListBox cheatList;
        
        internal Microsoft.Phone.Controls.PivotItem searchPivot;
        
        internal System.Windows.Controls.TextBox txtSearchString;
        
        internal Coding4Fun.Toolkit.Controls.RoundButton searchButton;
        
        internal System.Windows.Controls.ScrollViewer gameList;
        
        internal System.Windows.Controls.ListBox exactMatches;
        
        internal System.Windows.Controls.ListBox partialMatches;
        
        internal System.Windows.Controls.ListBox codeList;
        
        internal System.Windows.Controls.Grid cheatTextStackpanel;
        
        internal Microsoft.Phone.Controls.WebBrowser cheatTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/VBA8;component/CheatPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("mainPivot")));
            this.addPivot = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("addPivot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.descLabel = ((System.Windows.Controls.TextBlock)(this.FindName("descLabel")));
            this.cheatDescBox = ((System.Windows.Controls.TextBox)(this.FindName("cheatDescBox")));
            this.cheatCodeBox = ((System.Windows.Controls.TextBox)(this.FindName("cheatCodeBox")));
            this.listPivot = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("listPivot")));
            this.listPanel = ((System.Windows.Controls.Grid)(this.FindName("listPanel")));
            this.gameNameLabel = ((System.Windows.Controls.TextBlock)(this.FindName("gameNameLabel")));
            this.cheatList = ((System.Windows.Controls.ListBox)(this.FindName("cheatList")));
            this.searchPivot = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("searchPivot")));
            this.txtSearchString = ((System.Windows.Controls.TextBox)(this.FindName("txtSearchString")));
            this.searchButton = ((Coding4Fun.Toolkit.Controls.RoundButton)(this.FindName("searchButton")));
            this.gameList = ((System.Windows.Controls.ScrollViewer)(this.FindName("gameList")));
            this.exactMatches = ((System.Windows.Controls.ListBox)(this.FindName("exactMatches")));
            this.partialMatches = ((System.Windows.Controls.ListBox)(this.FindName("partialMatches")));
            this.codeList = ((System.Windows.Controls.ListBox)(this.FindName("codeList")));
            this.cheatTextStackpanel = ((System.Windows.Controls.Grid)(this.FindName("cheatTextStackpanel")));
            this.cheatTextBox = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("cheatTextBox")));
        }
    }
}

