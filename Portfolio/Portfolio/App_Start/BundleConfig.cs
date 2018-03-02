﻿using System.Web;
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

            // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
            // 運用の準備が完了したら、https://modernizr.com のビルド ツールを使用し、必要なテストのみを選択します。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Library/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Library/bootstrap.js",
                      "~/Scripts/Library/respond.js",
                      "~/Scripts/Screen/skrollr.js",
                      "~/Scripts/Screen/multiElement.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/fixed.css",
                      "~/Content/reset.css",
                      "~/Content/style.css"));

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
