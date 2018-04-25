using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Com.Bumptech.Glide;
using FFImageLoading;
using FFImageLoading.Views;

namespace LoadImageWithRV
{
   public class MyAdapter : RecyclerView.Adapter
    {
        Context mContext;
        List<string> mList;
        public MyAdapter(Context context, List<string> list) {
            this.mContext = context;
            this.mList = list;
        }
        public override int ItemCount => mList.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder myViewHolder = holder as MyViewHolder;
            // ImageService.Instance.LoadUrl(mList[position]).Into(myViewHolder.miv);
            Glide.With(mContext).Load(mList[position]).Into(myViewHolder.miv);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return new MyViewHolder(LayoutInflater.From(parent.Context).
                Inflate(Resource.Layout.item_layout, parent, false));
        }
    }
    public  class MyViewHolder : RecyclerView.ViewHolder
    {
        // public  ImageViewAsync miv;
        public ImageView miv;
        public MyViewHolder(View itemView) : base(itemView)
        {
            //miv = itemView.FindViewById<ImageViewAsync>(Resource.Id.item_iv);
            miv = itemView.FindViewById<ImageView>(Resource.Id.item_iv);
        }
    }

}