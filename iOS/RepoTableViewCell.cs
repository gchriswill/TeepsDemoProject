using Foundation;
using System;
using UIKit;

namespace CGRepos.iOS
{
    public partial class RepoTableViewCell : UITableViewCell
        {

		/* MARK: - 
         *
         * COMMENT: Very simple stuff here. Just binding properties from
         * the UI componenets...
         * 
         * AUTHOR: @gchriswill 
         */
		#region Class Computed Properties
		public String name
            {
            get { return RepoNameLabel.Text; }
            set { RepoNameLabel.Text = value; }
            }

        public string createdAt
            {
            get { return RepoCreatedAtLabel.Text; }
            set { RepoCreatedAtLabel.Text = value; }
            }

        public string description
            {
            get { return RepoDescriptionLabel.Text; }
            set { RepoDescriptionLabel.Text = value; }
            }
        #endregion

        #region Class Constructors
        public RepoTableViewCell(IntPtr handle) : base(handle)
            {
            }
        #endregion
        }
}