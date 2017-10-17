using System.Web;
using System.Web.Optimization;

namespace Peng.Dylan.Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            #region 
            bundles.Add(new ScriptBundle("~/bundles/H-ui.admin").Include(
                      "~/Content/H-ui.admin/lib/jquery/1.9.1/jquery.min.js",
                      "~/Content/H-ui.admin/lib/layer/2.4/layer.js",
                      "~/Content/H-ui.admin/h-ui/js/H-ui.js",
                      "~/Content/H-ui.admin/h-ui.admin/js/H-ui.admin.page.js"));

            bundles.Add(new StyleBundle("~/H-ui.admin/css").Include(
                      "~/Content/H-ui.admin/h-ui/css/H-ui.min.css",
                      "~/Content/H-ui.admin/h-ui/css/H-ui.admin.css",
                      "~/Content/H-ui.admin/lib/Hui-iconfont/1.0.8/iconfont.css",
                      "~/Content/H-ui.admin/h-ui.admin/skin/default/skin.css",
                      "~/Content/H-ui.admin/h-ui.admin/css/style.css"
                      ));
            #endregion
        }
    }
}
