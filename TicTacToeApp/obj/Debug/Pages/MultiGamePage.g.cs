﻿#pragma checksum "..\..\..\Pages\MultiGamePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43FA6DE2BA4BCF6F09D23DCC533FCBCA46B6FA1271314F8F5E016A3542BF6B5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TicTacToeApp.Pages;


namespace TicTacToeApp.Pages {
    
    
    /// <summary>
    /// MultiGamePage
    /// </summary>
    public partial class MultiGamePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentPlayerLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell00;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell01;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell02;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell10;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell11;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell12;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell20;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell21;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\MultiGamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Cell22;
        
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
            System.Uri resourceLocater = new System.Uri("/TicTacToeApp;component/pages/multigamepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MultiGamePage.xaml"
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
            
            #line 11 "..\..\..\Pages\MultiGamePage.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CurrentPlayerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Cell00 = ((System.Windows.Controls.Label)(target));
            
            #line 18 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell00.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cell01 = ((System.Windows.Controls.Label)(target));
            
            #line 19 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell01.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Cell02 = ((System.Windows.Controls.Label)(target));
            
            #line 20 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell02.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cell10 = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell10.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Cell11 = ((System.Windows.Controls.Label)(target));
            
            #line 22 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell11.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Cell12 = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell12.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Cell20 = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell20.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Cell21 = ((System.Windows.Controls.Label)(target));
            
            #line 25 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell21.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Cell22 = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\..\Pages\MultiGamePage.xaml"
            this.Cell22.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
