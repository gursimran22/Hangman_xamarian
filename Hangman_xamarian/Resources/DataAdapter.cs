using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Hangman_xamarian.Resources
{
    class DataAdapter : BaseAdapter<HangmanScore>
    {
        private readonly Activity context;
        private readonly List<HangmanScore> mItems;

        public DataAdapter(Activity context, List<HangmanScore> items)
        {
            this.mItems = items;
            this.context = context;
        }



        public override int Count
        {
            get { return mItems.Count; }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override HangmanScore this[int position]
        {
            get { return mItems[position]; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            var row = convertView;


            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.listview_row, null, false);
            }

            TextView txtRowName = row.FindViewById<TextView>(Resource.Id.txtRowName);
            txtRowName.Text = mItems[position].Name;

            TextView txtRowScore = row.FindViewById<TextView>(Resource.Id.txtRowScore);
            txtRowScore.Text = mItems[position].Score.ToString();

            return row;


        }
    }
}