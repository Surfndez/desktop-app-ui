using System;
using CoreGraphics;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace IVPN_Uninstaller
{
    public partial class AppDelegate : NSApplicationDelegate
    {
        MainWindowController mainWindowController;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            mainWindowController = new MainWindowController();
            mainWindowController.Window.MakeKeyAndOrderFront(this);
        }
    }
}

