﻿#pragma checksum "..\..\..\Windows\Clients.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B64BDBD4312A4132A0AE3C9B1AAFC0FBA02919892CA7EB7F07BEFEBC9B18448"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using School.Windows;
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


namespace School.Windows {
    
    
    /// <summary>
    /// Clients
    /// </summary>
    public partial class Clients : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Windows\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Clients_panel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Gender;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Birthday_mouth;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\Clients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_client;
        
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
            System.Uri resourceLocater = new System.Uri("/School;component/windows/clients.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Clients.xaml"
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
            
            #line 8 "..\..\..\Windows\Clients.xaml"
            ((School.Windows.Clients)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Clients_panel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 3:
            this.Gender = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\Windows\Clients.xaml"
            this.Gender.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Gender_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Windows\Clients.xaml"
            this.Gender.Loaded += new System.Windows.RoutedEventHandler(this.Gender_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Windows\Clients.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Birthday_mouth = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Windows\Clients.xaml"
            this.Birthday_mouth.Click += new System.Windows.RoutedEventHandler(this.Birthday_mouth_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Add_client = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Windows\Clients.xaml"
            this.Add_client.Click += new System.Windows.RoutedEventHandler(this.Add_client_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
