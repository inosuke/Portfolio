using System.Web;
using System.Web.Optimization;

namespace Portfolio
{
    public class BundleConfig
    {
        // バンドルの詳細については、https://go.microsoft.com/fwlink/?LinkId=301862 を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Library/jquery-{version}.js",
                        "~/Scripts/Library/skrollr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Screen/skrollr.js",
                      "~/Scripts/Screen/multiElement.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/fixed.css",
                      "~/Content/reset.css"));

            bundles.Add(new StyleBundle("~/Content/Landing").Include(
                      "~/Content/Common/Common.css",
                      "~/Content/PageStyleSheets/Landing.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Landing").Include(
                      "~/Scripts/Library/jquery-{version}.js",
                      "~/Scripts/Screen/Landing.js"));

            bundles.Add(new StyleBundle("~/Content/Factory").Include(
                      "~/Content/Common/Common.css",
                      "~/Content/PageStyleSheets/Factory.css"));
        }
    }
}
