using System.Web;
using System.Web.Optimization;

namespace Dashboard
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));



            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery-3.3.1.slim.min.js", "~/Scripts/bootstrap.min.js", "~/Scripts/popper.min.js",
                      //   "~/Scripts/custom/calendarscript.js",
                      "~/Scripts/custom/Dashboard.js", "~/Scripts/custom/progress-circle.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css", "~/Content/site.css", "~/Content/Custom/Dashboard.css",
                      //"~/Content/Custom/CalendarStyle.css", 
                      "~/Content/Custom/circle.css", "~/Content/Custom/jquerysctipttop.css"));


            //  < script src = "https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity = "sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin = "anonymous" ></ script >
            //        < !--calendar style-- >                      
            //             < !--script for circular progress bar-- >

            //            < link href = "http://www.jqueryscript.net/css/jquerysctipttop.css" rel = "stylesheet" type = "text/css" >
            //          < link href = "css/circle.css" rel = "stylesheet" type = "text/css" >
            //                  < script src = "progress-circle.js" ></ script >
        }
    }
}
