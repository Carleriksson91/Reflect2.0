using System.Web;
using System.Web.Optimization;

namespace Reflect
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Static external/Vex/js/vex.min.js",
                        "~/Static external/Vex/js/vex.combined.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Static/js/R.Global.js",
                      "~/Static/js/R.EventHandler.js",
                      "~/Static/js/R.Question.js",
                      "~/Static/js/R.Main.js"

                      
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Static external/Vex/css/vex.css",
                       "~/Static external/Vex/css/vex-theme-flat-attack.css",
                      "~/Static external/Vex/css/vex-theme-os.css"

                      ));
        }
    }
}
