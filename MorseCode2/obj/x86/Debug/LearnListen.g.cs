﻿#pragma checksum "C:\Users\Damian\Desktop\MorseCode2\MorseCode2\LearnListen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CD19DB4168BD08D8276EDFCF0CFC241C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MorseCode
{
    partial class LearnListen : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\LearnListen.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Tapped += this.Button_Click_1;
                    #line default
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\LearnListen.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Tapped += this.PlayButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.media1 = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 17 "..\..\..\LearnListen.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.media1).MediaOpened += this.Media1_MediaOpened;
                    #line default
                }
                break;
            case 4:
                {
                    this.AnswerBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\LearnListen.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Tapped += this.Button_Click_2;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\LearnListen.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Tapped += this.Button_Click_3;
                    #line default
                }
                break;
            case 7:
                {
                    this.Answer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.Correct = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.Image2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
