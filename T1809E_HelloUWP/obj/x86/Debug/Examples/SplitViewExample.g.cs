﻿#pragma checksum "C:\Users\xuan hung\source\repos\T1809E_HelloUWP\T1809E_HelloUWP\Examples\SplitViewExample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2CE51BAD1B172B094F1C0B0F9DB5A112"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T1809E_HelloUWP.Examples
{
    partial class SplitViewExample : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Examples\SplitViewExample.xaml line 11
                {
                    this.MySV = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // Examples\SplitViewExample.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element3 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element3).Tapped += this.UIElement_OnTapped;
                }
                break;
            case 4: // Examples\SplitViewExample.xaml line 19
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

