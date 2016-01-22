using System;
using CoreGraphics;
using UIKit;

namespace RootDirectoryFontPlist
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button = new UIButton(new CGRect(100, 100, 100, 100));
            button.SetTitle('\ue6fe'.ToString(), UIControlState.Normal);
            button.Font = UIFont.FromName("icomoon", (nfloat)24);
            button.BackgroundColor = UIColor.Clear;
            button.SetTitleColor(UIColor.Green, UIControlState.Normal);
            View.AddSubview(button);
        }
    }
}