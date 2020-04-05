using System.Web;
using System.Web.Optimization;

namespace WebApplication_mvc_19_03
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
             "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
          "~/Content/style.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
          "~/Scripts/jquery-3.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
          "~/Scripts/bootstrap.min.js"));

         // Material Icon
            bundles.Add(new StyleBundle("~/bundles/materialdesignicons/css").Include(
         "~/Content/materialdesignicons.min.css", new CssRewriteUrlTransform()));

         // pe-icon-7 Icon
            bundles.Add(new StyleBundle("~/bundles/pe-icon-7-stroke/css").Include(
       "~/Content/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapbundle/js").Include(
         "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryeasing/js").Include(
          "~/Scripts/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app/js").Include(
         "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/bundles/icons/css").Include(
             "~/Content/icons.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/app/css").Include(
             "~/Content/app.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/vendor/js").Include(
          "~/Scripts/vendor.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/appmin/js").Include(
          "~/Scripts/app.min.js"));

        }
    }
}
