﻿

#pragma checksum "D:\Илья\GIT\InfoSchool\InfoSchool\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AE25B30FC04D6210C2C2E24334C28399"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfoSchool
{
    partial class Settings : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 15 "..\..\Settings.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.goTo_registerPage;
                 #line default
                 #line hidden
                #line 15 "..\..\Settings.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.myButton_pressed;
                 #line default
                 #line hidden
                #line 15 "..\..\Settings.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerReleased += this.myButton_unpressed;
                 #line default
                 #line hidden
                #line 15 "..\..\Settings.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerEntered += this.myButton_unpressed;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


