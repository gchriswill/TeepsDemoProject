// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CGRepos.iOS
{
    [Register ("RepoTableViewCell")]
    partial class RepoTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RepoCreatedAtLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RepoDescriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RepoNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (RepoCreatedAtLabel != null) {
                RepoCreatedAtLabel.Dispose ();
                RepoCreatedAtLabel = null;
            }

            if (RepoDescriptionLabel != null) {
                RepoDescriptionLabel.Dispose ();
                RepoDescriptionLabel = null;
            }

            if (RepoNameLabel != null) {
                RepoNameLabel.Dispose ();
                RepoNameLabel = null;
            }
        }
    }
}