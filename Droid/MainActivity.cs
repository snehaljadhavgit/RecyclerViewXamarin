using Android.App;
using Android.Widget;
using Android.OS;
using RecycleViewComponent.Droid.Adapters;
using Android.Support.V7.Widget;
using RecycleViewComponent.Droid.Listeners;
using System;

namespace RecycleViewComponent.Droid
{
    [Activity(Label = "RecycleViewComponent", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity , IOClickItemViewInterface<String>
    {
        //int count = 1;

        DemoAdapter demoAdapter;
        RecyclerView recyclerView;

      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recycleDemo);
            recyclerView.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
            recyclerView.HasFixedSize = true;
            CreateCollection();
            demoAdapter = new DemoAdapter(this);
            recyclerView.SetAdapter(demoAdapter);

            StaticVariableClass.dataSource.CollectionChanged+=DataSource_CollectionChanged;
        }

        private void CreateCollection()
        {
            StaticVariableClass.dataSource.Add("h");
            StaticVariableClass.dataSource.Add("ngh");
            StaticVariableClass.dataSource.Add("hgm");
            StaticVariableClass.dataSource.Add("hvvh");
            StaticVariableClass.dataSource.Add("hvvh");
            StaticVariableClass.dataSource.Add("n");
            StaticVariableClass.dataSource.Add("hvvh");
            StaticVariableClass.dataSource.Add("hvvh");
            StaticVariableClass.dataSource.Add("ghm");
            StaticVariableClass.dataSource.Add("bjs");
            StaticVariableClass.dataSource.Add("svv");
            StaticVariableClass.dataSource.Add("vs");
            StaticVariableClass.dataSource.Add("hvvh");
            StaticVariableClass.dataSource.Add("vfdsv");
            StaticVariableClass.dataSource.Add("gm");
            StaticVariableClass.dataSource.Add("ghm");
            StaticVariableClass.dataSource.Add("hgm");
            StaticVariableClass.dataSource.Add("hm");
            StaticVariableClass.dataSource.Add("rt");
            StaticVariableClass.dataSource.Add("ert");


            
        }

        void DataSource_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            demoAdapter.NotifyDataSetChanged();
        }
        public void ItemViewClicK(String obj)
        {
            throw new System.NotImplementedException();
        }

    }
}

