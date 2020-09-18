using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HW3.Models;
using static HW3.Services.ForumService;

namespace HW3.Controllers
{
    public class ForumController : Controller
    {

        private readonly IForumService forumService;
        public ForumController(IForumService forumService)
        {
            this.forumService = forumService;
        }
        public IActionResult List()
        {
            var Forum = forumService.GetForums();
            return View(Forum);
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
        public IActionResult Add(Forums forum)
        {
            forum.Id = forum.Id;
            forum.ForumName = forum.ForumName;
            forum.ForumTimeStamp = DateTime.Now;
            forumService.AddForum(forum);
            return RedirectToAction(nameof(List));
        }

       // [HttpGet]
       // [Route("View/{id:int}")]
        public IActionResult ViewOne(int id)
        {          
            var forum = forumService.GetForum(id);
            return View(forum);
        }
        [Route("Forum/ViewOne/ViewTwo/{id:int}")]
        public IActionResult ViewTwo(int id)
        {
            var topic = forumService.GetTopic(id);
            return View(topic);
        }
        [HttpGet("Forum/ViewOne/AddTopic/{id:int}")]
        public IActionResult AddTopic(int id)
        {            
            return View(id);
        }
        [HttpPost("Forum/ViewOne/AddTopic/{id:int}")]
        public IActionResult AddTopic(Topics topic)
        {
            var newTopic = new Topics
            {
                ForumId = topic.ForumId,
                TopicName = topic.TopicName,
                TopicTimeStamp = DateTime.Now
            };
            forumService.AddTopic(newTopic);
            return RedirectToAction("ViewOne", new { id = topic.ForumId });
        }
        [Route("Forum/ViewOne/ViewTwo/BackToTopics/{id:int}")]
        public IActionResult BackToTopics(int id)
        {
            return RedirectToAction("ViewOne", new { id });
        }
        public IActionResult BackToForums()
        {
            return RedirectToAction(nameof(List));
        }
        [HttpGet("Forum/ViewOne/ViewTwo/AddReply/{id:int}")]
        public IActionResult AddReply(int id)
        {
            return View(id);
        }
        [HttpPost("Forum/ViewOne/ViewTwo/AddReply/{id:int}")]
        public IActionResult AddReply(Replies addedreply)
        {
            var newReply = new Replies
            {
                TopicId = addedreply.TopicId,
                Reply = addedreply.Reply,
                //TopicTimeStamp = DateTime.Now
            };
            forumService.AddReply(newReply);
            return RedirectToAction("ViewTwo", new { id = addedreply.TopicId });
        }
    }
}
