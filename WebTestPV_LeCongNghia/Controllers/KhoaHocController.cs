using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTestPV_LeCongNghia.Models;
using System.Data.Entity;

namespace WebTestPV_LeCongNghia.Controllers
{
    public class KhoaHocController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            var khoaHocs = db.KhoaHocs.ToList();
            return View(khoaHocs);
        }

        [HttpGet]
        public JsonResult MonHocs(int id)
        {
            try
            {
                var monHocs = db.MonHocs
                                .Where(m => m.KhoaHocID == id)
                                .Select(m => new MonHocDto
                                {
                                    ID = m.ID,
                                    TenMonHoc = m.TenMonHoc
                                })
                                .ToList();

                if (monHocs == null || !monHocs.Any())
                {
                    return Json(new { error = "Không tìm thấy môn học." }, JsonRequestBehavior.AllowGet);
                }

                return Json(monHocs, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                // Ghi log lỗi chi tiết
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


    }

}