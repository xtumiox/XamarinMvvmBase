// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TestXamarin2.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView FlowersTableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton RefreshButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (FlowersTableView != null) {
				FlowersTableView.Dispose ();
				FlowersTableView = null;
			}
			if (RefreshButton != null) {
				RefreshButton.Dispose ();
				RefreshButton = null;
			}
		}
	}
}
