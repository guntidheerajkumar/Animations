using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace Examples
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.Title = "Sample App";
			this.EdgesForExtendedLayout = UIRectEdge.None;
		}
	}
}
