using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SachOnline.Controllers
{
    public class SachOnlineController : Controller
    {
        // GET: SachOnline
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// GetChuDe 
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuDePartial()
        {
            return PartialView();
        }
        /// <summary>
        /// GetNhaXuatBan
        /// </summary>
        /// <returns></returns>
        public ActionResult NhaXuatBanPartial()
        {
            return PartialView();
        }
        /// <summary>
        /// GetSlider
        /// </summary>
        /// <returns></returns>
        public ActionResult SliderPartial()
        {
            return PartialView();
        }
        /// <summary>
        /// GetSachBanNhieu
        /// </summary>
        /// <returns></returns>
        public ActionResult SachBanNhieuPartial()
        {
            return PartialView();
        }
        public ActionResult FooterPartial()
        {
            return PartialView();
        }
        public ActionResult NavPartial()
        {
            return PartialView();
        }
    }
}