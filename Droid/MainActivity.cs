using Android.App;
using Android.Widget;
using Android.OS;

using System.Net;
using System.Collections.Generic;
using CGRepos.Models;
using CGRepos.Constants;
using Newtonsoft.Json;
using System;

namespace CGRepos.Droid
    {

    /* MARK: - 
     *
     * TITLE: Main Activity Class (Same as iOS scope)
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
    [Activity(Label = "CGRepos", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
        {
        ListView repoListView = null;
        RepoAdapter repoAdapter = null;
        private WebClient Webc;
        List<Repos> Items = new List<Repos>();

        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Webc = new WebClient();
            Webc.Headers.Add("user-agent", CONSTANTS.USER_AGENT);

			
            repoAdapter = new RepoAdapter(this);
            repoListView = FindViewById<ListView>(Resource.Id.repo_list_view);
            repoListView.Adapter = repoAdapter;

            loadRepoData();

            }


		/* MARK: - 
	     *
	     * COMMENT: This function executesd a runnable object to run on a 
	     * separate thread from the UI thread, for requesting the data from 
	     * Github and it parses the downloaded data by mapping it with a model, 
	     * which can be found at global scope in the global directory...
	     *
	     * Also, executes a closure for running a function on the UI thread for 
	     * updating the UI with the downloaded data...
	     *
	     * AUTHOR: @gchriswill 
	     */
		public void loadRepoData()
            {
            new Java.Lang.Runnable(() =>
            {
            try
                {
                    string data = Webc.DownloadString(CONSTANTS.GITHUB_URL);
                    Items = JsonConvert.DeserializeObject<List<Repos>>(data);
                    RunOnUiThread(()=> onUI());
                }
            catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(@"ERROR!!!!!! {0}", ex.Message);
                }
            }).Run();
            }


        public void onUI()
            {
			repoAdapter.Items = Items;
			repoAdapter.NotifyDataSetChanged();
            }
        }
    }

