using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Content;
using System.Collections.Generic;
using System;

namespace LoadImageWithRV
{
    [Activity(Label = "LoadImageWithRV", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public const string baseUrl= "https://picsum.photos/400/800/?image=";

        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        List<string> mList;
        MyAdapter mMyAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            initData();
            initView();

        }

        private void initData()
        {
            mList = new List<string>();
            for (int i =1; i<300;i++) {
                string url = baseUrl + i;
                mList.Add(url);
            }
        }

        private void initView()
        {
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mLayoutManager = new GridLayoutManager(this, 2);
            mRecyclerView.SetLayoutManager(mLayoutManager);
            mMyAdapter = new MyAdapter(this, mList);
            mRecyclerView.SetAdapter(mMyAdapter);
        }
    }

}

