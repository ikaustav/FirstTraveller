﻿#pragma checksum "C:\Users\Kaustav\documents\visual studio 2013\Projects\First Traveller\First Traveller\Places\DetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E6D2ACFEF872D997246A461CFEA06B03"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace First_Traveller.Places {
    
    
    public partial class DetailsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock typeHeader;
        
        internal System.Windows.Controls.TextBlock errorMsg;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock add;
        
        internal System.Windows.Controls.TextBlock phnNo;
        
        internal System.Windows.Controls.TextBlock intrntnlPhn;
        
        internal System.Windows.Controls.TextBlock vcnty;
        
        internal System.Windows.Controls.TextBlock web;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/First%20Traveller;component/Places/DetailsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.typeHeader = ((System.Windows.Controls.TextBlock)(this.FindName("typeHeader")));
            this.errorMsg = ((System.Windows.Controls.TextBlock)(this.FindName("errorMsg")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.add = ((System.Windows.Controls.TextBlock)(this.FindName("add")));
            this.phnNo = ((System.Windows.Controls.TextBlock)(this.FindName("phnNo")));
            this.intrntnlPhn = ((System.Windows.Controls.TextBlock)(this.FindName("intrntnlPhn")));
            this.vcnty = ((System.Windows.Controls.TextBlock)(this.FindName("vcnty")));
            this.web = ((System.Windows.Controls.TextBlock)(this.FindName("web")));
        }
    }
}

