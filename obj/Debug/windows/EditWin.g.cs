﻿#pragma checksum "..\..\..\windows\EditWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6283A4E5CC099B14CE07D2B8F07A0AD8C8AD08BDD9C5BFEC0A294BDEA1A35056"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MTS.windows;
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


namespace MTS.windows {
    
    
    /// <summary>
    /// EditWin
    /// </summary>
    public partial class EditWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\windows\EditWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\windows\EditWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLname;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\windows\EditWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNumber;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\windows\EditWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTarif;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\windows\EditWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editSub;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\windows\EditWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editCan;
        
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
            System.Uri resourceLocater = new System.Uri("/MTS;component/windows/editwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\EditWin.xaml"
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
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbLname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbTarif = ((System.Windows.Controls.ComboBox)(target));
            
            #line 81 "..\..\..\windows\EditWin.xaml"
            this.cbTarif.Loaded += new System.Windows.RoutedEventHandler(this.cbTarif_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editSub = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\windows\EditWin.xaml"
            this.editSub.Click += new System.Windows.RoutedEventHandler(this.editSub_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editCan = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\windows\EditWin.xaml"
            this.editCan.Click += new System.Windows.RoutedEventHandler(this.editCan_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

