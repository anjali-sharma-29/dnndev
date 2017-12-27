using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace UmbracoFieldDisplay
{
    public class HomeController: RenderMvcController
    {
        public ViewResult Home(string View,RenderModel model)
        {
            return base.View(model);
        }
        [HttpGet]
        public void Gallery()
        {
            
        }
        public ViewResult Gallery(string View,RenderModel model)
        {
            return base.View(model);
        }
    }
    public class IndexController:SurfaceController
    {
        public ViewResult Index(string View, RenderModel model)
        {
            return base.View(model);
        }
        public ActionResult Gallery()
        {
            return RedirectToAction("Gallery","Home");
        }
    }
    public class PhotosController:SurfaceController
    {
        public ViewResult Photos(string View,RenderModel model)
        {
            return base.View(model);
        }
    }
    public class TestController:SurfaceController
    {
        public ViewResult Test(string View, RenderModel model)
        {
            return base.View(model);
        }
        public ViewResult Test1(RenderModel model)
        {
            return base.View("/Views/Test1.cshtml",model);
        }
    }
}