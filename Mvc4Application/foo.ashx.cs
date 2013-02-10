using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Application
{
    /// <summary>
    /// Summary description for foo
    /// </summary>
    public class foo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");

            throw new Exception("zzz");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}