﻿using CleanArchMvc.Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService= categoryService;
        }

        [HttpGet]   
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetCategories();
            return View(categories);
        }
    }
}
