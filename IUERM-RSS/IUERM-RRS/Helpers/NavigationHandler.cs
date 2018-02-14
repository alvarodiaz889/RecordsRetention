using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace IUERM_RRS.Helpers
{
    public class NavigationHandler
    {
        public static HttpCookie CreateNavCookie(HttpCookie navCookie, bool isMobile)
        {
            string cookieName = "navCookie";
            if (isMobile) { cookieName = "navMobileCookie"; }

            // Setup the menu
            //string navigationMenu = NavigationHandler.SetupMenu(isMobile); // no longer used
            string navigationMenu = NavigationHandler.ScrapeMenu(isMobile);
            HttpContext context = HttpContext.Current;

            if (navCookie == null)
            {
                navCookie = new HttpCookie(cookieName);
            }

            // To prevent "A potentially dangerous Request.Cookies value was detected from the client"
            navCookie.Value = BitConverter.ToString(Encoding.Default.GetBytes(navigationMenu));
            navCookie.Expires = DateTime.Now.AddDays(30);

            return navCookie;

        }

        public static string ScrapeMenu(bool isMobile)
        {
            string content = "";

            string fileLocation = HttpContext.Current.Server.MapPath("/index.html");

            // only if file exists
            if (System.IO.File.Exists(fileLocation))
            {
                content = System.IO.File.ReadAllText(fileLocation);
            }

            // extract main content
            var html = new HtmlDocument();
            html.LoadHtml(content);

            var root = html.DocumentNode;

            var finalHtml = "";

            try
            {
                var body = root.SelectNodes("//nav");

                foreach (HtmlNode nav in body)
                {
                    if (isMobile)
                    {
                        HtmlAttribute ariaLabel = nav.Attributes[@"aria-label"];
                        if (ariaLabel == null)
                        {
                            // mobile
                            finalHtml = nav.OuterHtml;
                            break;
                        }
                    }
                    else
                    {
                        finalHtml = nav.OuterHtml;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
            }

            // replace relative links created by WCMS
            finalHtml = finalHtml.Replace("href='", "href='/");
            finalHtml = finalHtml.Replace("href=\"", "href=\"/");

            return HttpUtility.HtmlDecode(finalHtml);

        }
    }
}

