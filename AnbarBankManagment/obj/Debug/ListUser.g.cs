﻿#pragma checksum "..\..\ListUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0381C0A5358815042F6EB8F3EEBE8775BF80343F1E53FD7BC68A0F0AE5DF58CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AnbarBankManagment;
using Arash.PersianDateControls;
using Microsoft.Windows.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AnbarBankManagment {
    
    
    /// <summary>
    /// ListUser
    /// </summary>
    public partial class ListUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\ListUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Header;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ListUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnback;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ListUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle btnadduser;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\ListUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid userlist;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AnbarBankManagment;component/listuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListUser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\ListUser.xaml"
            ((AnbarBankManagment.ListUser)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\ListUser.xaml"
            ((AnbarBankManagment.ListUser)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Header = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 39 "..\..\ListUser.xaml"
            this.Header.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Header_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnback = ((System.Windows.Controls.Image)(target));
            
            #line 47 "..\..\ListUser.xaml"
            this.btnback.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Back_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnadduser = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 57 "..\..\ListUser.xaml"
            this.btnadduser.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Btnadduser_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.userlist = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

