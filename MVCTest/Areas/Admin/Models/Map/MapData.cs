using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVCTest.Areas.Admin.Models.Map
{
    public class MapData
    {
        ContentEtities db = new ContentEtities();
        public List<Content> DanhSach()
        {
            return db.Contents.ToList();
        }

        public Content Chitiet(int id)
        {
            return db.Contents.Find(id);
        }

        public bool EditContent(Content model, HttpPostedFileBase FileLogo, HttpPostedFileBase ImgSlide1, HttpPostedFileBase ImgSlide2, HttpPostedFileBase ImgMain1, HttpPostedFileBase ImgMain2, HttpPostedFileBase ImgProduct1, HttpPostedFileBase ImgProduct2, HttpPostedFileBase ImgProduct3, HttpPostedFileBase ImgCrop1, HttpPostedFileBase ImgCrop2)
        {
            var update = db.Contents.Find(model.id);

            if (update == null)
            {
                return false;
            }

            return true;
        }

    }
}