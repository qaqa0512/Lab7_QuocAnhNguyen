using Lab7_QuocAnhNguyen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab7_QuocAnhNguyen.Controllers
{
    public class SachController : ApiController
    {
        Quanlysach[] sachs = new Quanlysach[]
       {
            new Quanlysach {Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName = "Nguyễn Nhật Ánh", Price = 1, Content = "Truyện kể về Tuổi thơ ..."},
            new Quanlysach {Id = 2, Title = "Pro ASP.NET MVC5", AuthorName = "Adam Freeman", Price = 3.75M, Content = "The ASP.NET MVC 5 Framework is the lastest evolution of Microsoft's ASP.NET web platform."}
       };

        public IEnumerable<Quanlysach> GetAllSachs()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var product = sachs.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
