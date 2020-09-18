using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HW3.Models;
using static HW3.Services.ReplyService;

namespace HW3.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IReplyService replyService;
        public ReplyController(IReplyService replyService)
        {
            this.replyService = replyService;
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        public IActionResult List()
        {
            var reply = replyService.GetReplies();
            return View(reply);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Replies replyname)
        {
            replyname.Reply = replyname.Reply;
            replyService.AddReply(replyname);
            return RedirectToAction(nameof(List));
        }
    }
}
