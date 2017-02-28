using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Java.IO;

namespace TabAndSwipe
{
    [Activity(Label = "TabAndSwipe", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            TabLayout tabLayout = (TabLayout)FindViewById(Resource.Id.tablayout_navigation);

            ViewPager viewPager = (ViewPager)FindViewById(Resource.Id.pager);
            SetupviewPager(viewPager);

            tabLayout.SetupWithViewPager(viewPager);
        }

        private void SetupviewPager(ViewPager viewPager)
        {
            throw new NotImplementedException();
        }
        //viewPager.OffscreenPageLimit = 3;

        //PageAdapter adapter = new PageAdapter(SupportFragmentManager);
        //adapter.AddFragment(new Fragment1(), "Eins");
        //adapter.AddFragment(new Fragment2(), "Zwei");
        //adapter.AddFragment(new Fragment3(), "Drei");

        //viewPager.Adapter = adapter;
    }
}

