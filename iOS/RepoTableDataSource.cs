using System;
using System.Collections.Generic;
using UIKit;
using CGRepos.Models;
using CGRepos.Constants;

namespace CGRepos.iOS
    {

	/* MARK: - 
     *
     * TITLE: Data Source Class
     * DESCRIPTION: This class is in charge for handling the downloaded data by 
     * mapping it to the UI.
     *
     * AUTHOR: @gchriswill 
     */
	public class RepoTableDataSource : UITableViewDataSource
        {

		#region Class Computed Properties
        public List<Repos> Items = new List<Repos>();
		#endregion

		#region Class Constructors
		public RepoTableDataSource()
			{
            
			}
		#endregion

		#region Override Methods
		public override nint NumberOfSections(UITableView tableView)
			{
			// Hard coded 1 section
			return 1;
			}

		public override nint RowsInSection(UITableView tableView, nint section)
			{
			return Items.Count;
			}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
			{

            // Dequeing Reusable Cell whit an id from the projet's contants
            var cell = tableView.DequeueReusableCell(CONSTANTS.CELL_ID, indexPath) as RepoTableViewCell;
			var item = this.Items[indexPath.Row];

            // Dynamic Cell Setup
            cell.name = item.name;

			/* MARK: - 
		     *
		     * COMMENT: Very simple and built in feature in C# for parsing a 
		     * string date with native methods...
		     * 
		     * AUTHOR: @gchriswill 
		     */
			DateTime date = DateTime.Parse(item.created_at);
            cell.createdAt = date.ToString("mm/dd/yyyy");
            cell.description = item.description;

			return cell;
			}
		#endregion

		}
	}
