using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.Collections.Generic;
using CGRepos.Models;

namespace CGRepos.Droid
    {

	/* MARK: - 
     *
     * TITLE: Base Adapter Subclass
     * DESCRIPTION: This class is in charge for handling the downloaded data by 
     * mapping it to the UI.
     *
     * AUTHOR: @gchriswill 
     */
	public class RepoAdapter : BaseAdapter
        {

        MainActivity mainContext;

        public RepoAdapter(MainActivity mainContext)
            {
            this.mainContext = mainContext;
            }

        public List<Repos> Items { get; set;} = new List<Repos>();

        public override int Count => Items.Count;

        public override Java.Lang.Object GetItem(int position)
            {
            return "";
            }

        public override long GetItemId(int position)
            {
            return Items.Count;
            }

        public override View GetView(int position, View convertView, ViewGroup parent)
            {

            View viewHolder = null;

            if (convertView == null){
                viewHolder = LayoutInflater.FromContext(mainContext).Inflate(Resource.Layout.repo_list_item, null);
            }else{
                viewHolder = convertView;
            }

            TextView nameTextView = viewHolder.FindViewById(Resource.Id.name_text) as TextView;
            nameTextView.SetText(Items[position].name,TextView.BufferType.Normal);

			/* MARK: - 
             *
             * COMMENT: Very simple and built in feature in C# for parsing a 
             * string date with native methods...
             * 
             * Same as iOS technique...
             * 
             * AUTHOR: @gchriswill 
             */
			string createdAt = Items[position].created_at;
			string date = DateTime.Parse(createdAt).ToString("mm/dd/yyyy");

            TextView dateTextView = viewHolder.FindViewById(Resource.Id.date_text) as TextView;
            dateTextView.SetText(date, TextView.BufferType.Normal);

            TextView description = viewHolder.FindViewById(Resource.Id.description_text) as TextView;
            description.SetText(Items[position].description, TextView.BufferType.Normal);

            return viewHolder;
            }
        }
    }
