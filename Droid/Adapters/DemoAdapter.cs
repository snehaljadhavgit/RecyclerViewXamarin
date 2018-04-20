using System;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using RecycleViewComponent.Droid.Listeners;

namespace RecycleViewComponent.Droid.Adapters
{
    public class DemoAdapter : RecyclerView.Adapter 
    {
        Context mContext;
        IOClickItemViewInterface<String> mListner;
        public DemoAdapter(Context context, IOClickItemViewInterface<String> listner)
        {
            mContext = context;
            mListner = listner;
        }

        public override int ItemCount => StaticVariableClass.dataSource.Count;

      

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            DemoViewHolder mDemoAdapterViewHolder = holder as DemoViewHolder;
            mDemoAdapterViewHolder.Bind(mListner, StaticVariableClass.dataSource[position]);
            mDemoAdapterViewHolder.textViewTitle.Text = StaticVariableClass.dataSource[position];
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.row_recycle_demo, parent, false);
            return new DemoViewHolder(itemView);
        }
    }

    public class DemoViewHolder : RecyclerView.ViewHolder
    {
        public TextView textViewTitle;

        public DemoViewHolder(View itemView) : base(itemView)
        {
            textViewTitle = itemView.FindViewById<TextView>(Resource.Id.textViewTitle);

            ItemView.Click += ItemView_Click;
        }

        void ItemView_Click(object sender, EventArgs e)
        {
            
        }

        public void Bind(IOClickItemViewInterface<String> listener, string str)
        {
            listener.ItemViewClicK(str);
        }

    }
}
