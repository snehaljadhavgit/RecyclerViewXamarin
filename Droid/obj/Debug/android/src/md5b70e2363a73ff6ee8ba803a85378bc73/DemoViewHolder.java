package md5b70e2363a73ff6ee8ba803a85378bc73;


public class DemoViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("RecycleViewComponent.Droid.Adapters.DemoViewHolder, RecycleViewComponent.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DemoViewHolder.class, __md_methods);
	}


	public DemoViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == DemoViewHolder.class)
			mono.android.TypeManager.Activate ("RecycleViewComponent.Droid.Adapters.DemoViewHolder, RecycleViewComponent.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
