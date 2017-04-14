﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GUISUVVueComponent.Controllers
{
    public class GUVTestController : Controller
    {
        #region Base
        public IActionResult Base()
        {
            return View();
        }
        #endregion



        #region table
        /// <summary>
        /// 加载后台数据生成表格
        /// </summary>
        /// <returns></returns>
        public IActionResult Table()
        {
            return View();
        }
        /// <summary>
        /// 表格获取数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("students")]
        public JsonResult Students()
        {
            return new JsonResult(new List<dynamic>() { new { ID = 1, Name = "张三" }, new { ID = 2, Name = "李四" } }, new Newtonsoft.Json.JsonSerializerSettings());
        }

        #endregion


        #region 组件
        /// <summary>
        /// 组件
        /// </summary>
        /// <returns></returns>
        [HttpGet("component")]
        public IActionResult Component()
        {
            return View();
        }
        #endregion
        #region 组件
        /// <summary>
        /// 组件
        /// </summary>
        /// <returns></returns>
        [HttpGet("component1")]
        public IActionResult Component1()
        {
            return View();
        }
        #endregion
        #region 组件
        /// <summary>
        /// 组件
        /// </summary>
        /// <returns></returns>
        [HttpGet("component2")]
        public IActionResult Component2()
        {
            return View();
        }
        #endregion
        #region 验证
        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        [HttpGet("validate")]
        public IActionResult Validate()
        {
            return View();
        }
        #endregion


        #region todolist
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("todolist")]
        public IActionResult ToDoListComponent()
        {
            return View();
        }
        #endregion


        #region Form表单
        public IActionResult Form()
        {
            return View();
        }
        #endregion


        #region Computed
        public IActionResult Computed()
        {
            return View();
        }
        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns></returns>
        [HttpGet("/answerquestion")]
        public string GetString(string value = "无")
        {
            return new Random().Next(1, 100) + value;
        }
        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns></returns>
        [HttpGet("/validusername")]
        public bool ValidUserName(string userName)
        {
            var arr = new string[] { "abc", "aaa", "bbb", "ccc" };
            return arr.Contains(userName);
        }
        #endregion


        #region ClassStyle
        public IActionResult ClassStyle()
        {
            return View();
        }
        #endregion


        #region 事件
        public IActionResult Event()
        {
            return View();
        }
        #endregion


        #region 动画
        [HttpGet("animate")]
        public IActionResult Animate()
        {
            return View();
        }

        #endregion
    }
}
