﻿using Microsoft.AspNetCore.Mvc;
using wzPractice.Models;

namespace wzPractice.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<TestStudent> GetData()
        {
            List<TestStudent> list = new List<TestStudent>() {
                new TestStudent (){ UserName="张三",Sex = "男",Hobby="吃饭",Age=24},
                new TestStudent (){ UserName="李四",Sex = "男",Hobby="睡觉",Age=25},
                new TestStudent (){ UserName="王五",Sex = "男",Hobby="喝茶",Age=26},
            };
            return list;
        }
        public IActionResult AddStudent(TestStudent student)
        {
            return View();
        }
        public IActionResult DeleteStudent(TestStudent student)
        {
            return View();
        }
        public IActionResult UpdateStudent(TestStudent student)
        {
            return View();
        }
    }
}
