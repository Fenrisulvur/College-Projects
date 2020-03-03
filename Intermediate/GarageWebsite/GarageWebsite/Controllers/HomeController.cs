using GarageWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace GarageWebsite.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Camel Towing: Who we are";

            return View();
        }

        public ActionResult Beans()
        {
            ViewBag.Message = "BEANZ";

            return View();
        }

        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(string Name, string EmailId, string PhoneNo, string Subject, string Message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("coreyfults@gmail.com");
                mail.From = new MailAddress(EmailId);
                mail.Subject = Subject;

                string userMessage = "";
                userMessage = "<br/>Name :" + Name;
                userMessage = userMessage + "<br/>Email Id: " + EmailId;
                userMessage = userMessage + "<br/>Phone No: " + PhoneNo;
                userMessage = userMessage + "<br/>Message: " + Message;
                string Body = "Hi, <br/><br/> A new enquiry by user. Detail is as follows:<br/><br/> " + userMessage + "<br/><br/>Thanks";

                mail.Body = Body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                //SMTP Server Address of gmail
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("coreyfults@gmail.com", "Dragonfire9908");
                // Smtp Email ID and Password For authentication
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.Message = "Thank you for contacting us.";
            }
            catch(Exception e)
            {
                ViewBag.Message = e.ToString();
            }

            return View();
        }
        public ActionResult Services()
        {
            ServiceDBHandler IHandler = new ServiceDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }
    }
}