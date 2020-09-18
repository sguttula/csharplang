using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HW3.Models;
using static HW3.Services.TopicService;

namespace HW3.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicService topicService;
        public TopicController(ITopicService topicService)
        {
            this.topicService = topicService;
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        public IActionResult List()
        {
            var topic = topicService.GetTopics();
            return View(topic);
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
        public IActionResult Add(Topics topic)
        {
            topic.Id = topic.Id;
            topic.TopicName = topic.TopicName;
            topic.TopicTimeStamp = topic.TopicTimeStamp;
            topicService.AddTopic(topic);
            return RedirectToAction(nameof(List));
        }
    }
}
