﻿#pragma checksum "..\..\..\Controls\Client.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A5FDEBDCE1DAA0D6C88CCFF0AEDE88C23CF561CEBF64C19B7B6146940F0492A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using School.Controls;
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


namespace School.Controls {
    
    
    /// <summary>
    /// Client
    /// </summary>
    public partial class Client : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Id;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Gender;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Fio;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Birthday;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Phone;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Email;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Reg_data;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Tag_panel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit_client;
        
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
            System.Uri resourceLocater = new System.Uri("/School;component/controls/client.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\Client.xaml"
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
            this.Image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.Id = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Gender = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Fio = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Birthday = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Phone = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Email = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Reg_data = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Tag_panel = ((System.Windows.Controls.WrapPanel)(target));
            
            #line 18 "..\..\..\Controls\Client.xaml"
            this.Tag_panel.Loaded += new System.Windows.RoutedEventHandler(this.Tag_panel_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Edit_client = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Controls\Client.xaml"
            this.Edit_client.Click += new System.Windows.RoutedEventHandler(this.Edit_client_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

