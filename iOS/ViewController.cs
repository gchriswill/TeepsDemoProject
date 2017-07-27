using System;
using System.Net;
using CGRepos.Models;
using Newtonsoft.Json;
using CGRepos.Constants;
using System.Diagnostics;
using System.Collections.Generic;

using UIKit;

namespace CGRepos.iOS
    {
    public partial class ViewController : UIViewController
        {

		/* MARK: - 
	     *
	     * TITLE: View Controller Class
	     * DESCRIPTION: This class is in charge of the web request to github due 
	     * to issues with the package manager at global scope. I spent some time 
	     * trying to use the webclient at global directory, but apparently the 
	     * packge wasn't recognized by VS at globally.
	     * 
	     * A work around was to implement this client in both platform's scope, 
	     * iOS and Android individualy...
	     *
	     * AUTHOR: @gchriswill 
	     */
		private WebClient Webc = new WebClient();

        public ViewController(IntPtr handle) : base(handle)
            {
            }

        public override void ViewDidLoad()
            {
            base.ViewDidLoad();

            Webc = new WebClient();
            Webc.Headers.Add("user-agent", CONSTANTS.USER_AGENT);

            }

        public override void ViewWillAppear(bool animated)
            {
            base.ViewWillAppear(animated);

			RepoTableView.RowHeight = 96f;
			RepoTableView.DataSource = new RepoTableDataSource();
            loadRepoData();
            }

        public override void DidReceiveMemoryWarning()
            {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
            }

		/* MARK: - 
	     *
	     * COMMENT: GET Resquest Function and JSON Parser with Model. This 
	     * function is in charge for making the resquest to 
	     * github.
	     * 
	     * Also, it parses the downloaded data by mapping it with a model, which 
	     * can be found at global scope in the global directory...
	     *
	     * AUTHOR: @gchriswill 
	     */
		public void loadRepoData()
			{

            RepoTableDataSource dataSource = RepoTableView.DataSource as RepoTableDataSource;
            List<Repos> Repolist = new List<Repos>();

			try
				{
				string data = Webc.DownloadString(CONSTANTS.GITHUB_URL);
				Repolist = JsonConvert.DeserializeObject<List<Repos>>(data);
				}
			catch (Exception ex)
				{
				Debug.WriteLine(@"ERROR!!!!!! {0}", ex.Message);
				}
		        dataSource.Items = Repolist;
                RepoTableView.ReloadData();
            }
        }
    }
