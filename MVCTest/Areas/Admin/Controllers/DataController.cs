using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Areas.Admin.Models.Map;
using MVCTest.Areas.Admin.Models;
namespace MVCTest.Areas.Admin.Controllers
{
    public class DataController : Controller
    {
        // GET: Admin/Data
        MapData map = new MapData();
        public ActionResult Index()
        {
            return View(map.DanhSach());
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            return RedirectToAction("Login");
        }



        //public ActionResult AddNew()
        //{
        //    return View();
        //}

        //public ActionResult AddNewContent()
        //{
        //    return View();
        //}

        public ActionResult Edit()
        {   
            return View(map.Chitiet(1));
        }

        public ActionResult GotoIndex()
        {
            var urlHlper = Url;
            string IndexUrl = urlHlper.Action("Index", "Home", new { area = "" });
            return Redirect(IndexUrl);
        }

        [HttpPost]

        public ActionResult CheckLogin(Admin.Models.Admin model)
        {
        ContentEtities db = new ContentEtities();
            Admin.Models.Admin Datatrue = db.Admins.SingleOrDefault(n => n.userName == model.userName && n.password == model.password);
            if (Datatrue != null)
            {
                //HttpContext.Response.Cookies.Append("Admin", Datatrue);
                return RedirectToAction("Edit");
            }

                return RedirectToAction("Login");
            
        }

        public ActionResult SaveEdit(Content model, HttpPostedFileBase FileLogo, HttpPostedFileBase ImgSlide1, HttpPostedFileBase ImgSlide2, HttpPostedFileBase ImgMain1, HttpPostedFileBase ImgMain2, HttpPostedFileBase ImgProduct1, HttpPostedFileBase ImgProduct2, HttpPostedFileBase ImgProduct3, HttpPostedFileBase ImgCrop1, HttpPostedFileBase ImgCrop2)
        {


        ContentEtities db = new ContentEtities();
            var update = db.Contents.Find(1);
            string rootFolder = Server.MapPath("/Areas/Admin/ImgData/");
            if(FileLogo != null)
            {
            string pathLogo = rootFolder + FileLogo.FileName;
            FileLogo.SaveAs(pathLogo);
            update.imglogo = "/Areas/Admin/ImgData/" + FileLogo.FileName;
            }
            else
            {
            update.imglogo = update.imglogo;
            }

            if (ImgSlide1 != null)
            {
                
            string pathSlide1 = rootFolder + ImgSlide1.FileName;
            ImgSlide1.SaveAs(pathSlide1);
            update.slideI1img1 = "/Areas/Admin/ImgData/" + ImgSlide1.FileName;


            }
            else
            {
                update.slideI1img1 = update.slideI1img1;
            }

            if (ImgSlide2 != null)
            {
            string pathSlide2 = rootFolder + ImgSlide2.FileName;
            ImgSlide2.SaveAs(pathSlide2);
            update.slideI1img2 = "/Areas/Admin/ImgData/" + ImgSlide2.FileName;
            
            }
            else
            {
                update.slideI1img2 = update.slideI1img2;
            }

            if (ImgMain1 != null)
            {
            string pathMain1 = rootFolder + ImgMain1.FileName;
            ImgMain1.SaveAs(pathMain1);
            update.main1Img = "/Areas/Admin/ImgData/" + ImgMain1.FileName;

            }
            else
            {
                update.main1Img = update.main1Img;
            }

            if (ImgMain2 != null)
            {
                
            string pathMain2 = rootFolder + ImgMain2.FileName;
            ImgMain2.SaveAs(pathMain2);
            update.main2Img = "/Areas/Admin/ImgData/" + ImgMain2.FileName;

            }
            else
            {
                update.main2Img = update.main2Img;
            }

            if (ImgProduct1 != null)
            {
            string pathProduct1 = rootFolder + ImgProduct1.FileName;
            ImgProduct1.SaveAs(pathProduct1);
            update.product1Img = "/Areas/Admin/ImgData/" + ImgProduct1.FileName;
            }
            else
            {
                update.product1Img = update.product1Img;
            }

            if (ImgProduct2 != null)
            {
                string pathProduct2 = rootFolder + ImgProduct2.FileName;
                ImgProduct2.SaveAs(pathProduct2);
                update.product2Img = "/Areas/Admin/ImgData/" + ImgProduct2.FileName;
            }
            else
            {
                update.product2Img = update.product2Img;
            }

            if (ImgProduct2 != null)
            {
                string pathProduct2 = rootFolder + ImgProduct2.FileName;
                ImgProduct2.SaveAs(pathProduct2);
                update.product2Img = "/Areas/Admin/ImgData/" + ImgProduct2.FileName;
            }
            else
            {
                update.product2Img = update.product2Img;
            }


            if (ImgProduct3 != null)
            {
                string pathProduct3 = rootFolder + ImgProduct3.FileName;
                ImgProduct3.SaveAs(pathProduct3);
                update.product3Img = "/Areas/Admin/ImgData/" + ImgProduct3.FileName;
            }
            else
            {
                update.product3Img = update.product3Img;
            }

            if (ImgCrop1 != null)
            {
            string pathCrop1 = rootFolder + ImgCrop1.FileName;
            ImgCrop1.SaveAs(pathCrop1);
            update.crop1Img = "/Areas/Admin/ImgData/" + ImgCrop1.FileName;
                
            }
            else
            {
                update.crop1Img = update.crop1Img;
            }

            if (ImgCrop1 != null)
            {
            string pathCrop2 = rootFolder + ImgCrop2.FileName;
            ImgCrop2.SaveAs(pathCrop2);
            update.crop2Img = "/Areas/Admin/ImgData/" + ImgCrop2.FileName;
                

            }
            else
            {
                update.crop2Img = update.crop2Img;
            }
            update.nameLogo = model.nameLogo;
            update.groupLogo = model.groupLogo;
            update.slide1Title = model.slide1Title;
            update.slide2Title = model.slide2Title;
            update.slide1Desc = model.slide1Desc;
            update.slide2Desc = model.slide2Desc;
            update.main1Title = model.main1Title;
            update.main2Title = model.main2Title;
            update.main1Desc = model.main1Desc;
            update.main2Desc = model.main2Desc;
            update.product1Title = model.product1Title;
            update.product2Title = model.product2Title;
            update.product3Title = model.product3Title;
            update.product1Desc = model.product1Desc;
            update.product2Desc = model.product2Desc;
            update.product3Desc = model.product3Desc;
            update.crop1Title = model.crop1Title;
            update.crop2Title = model.crop2Title;
            update.crop1address = model.crop1address;
            update.crop2address = model.crop2address;
            update.crop1Desc = model.crop1Desc;
            update.crop2Desc = model.crop2Desc;
            update.FooterDesc = model.FooterDesc;
            update.address = model.address;
            update.gmail = model.gmail;
            update.phone = model.phone;

            db.SaveChanges();
            Response.Write("<script>alert('Lưu thành công')</script>");
            return RedirectToAction("Edit");
        }
    }
}