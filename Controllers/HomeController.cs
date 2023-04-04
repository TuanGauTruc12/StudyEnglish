﻿using StudyEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyEnglish.Controllers
{
    public class HomeController : BaseController
    {
        StudyEnglishContext db = new StudyEnglishContext();
        public ActionResult Index()
        {
            ViewData["videos"] = db.Video.ToList();
            ViewData["categories"] = db.DanhMuc.ToList();


            //- View:
            //+ Tên danh mục
            // col 4 col4 col 4
            // + trong 1 col có image & tên video, mức độ
            //+ Trang chi tiết có video, tên, mức độ và câu hỏi ở dưới video
            // + Admin: thêm xóa sửa câu hỏi, video
            //+ tìm kiếm video
            //user đã đăng nhập mới hiển thị câu hỏi bên dưới video
            //+ thi trắc nghiệm được lọc và hiển thị 50 câu ngẫu nhiên
            return View();
        }
    }
}