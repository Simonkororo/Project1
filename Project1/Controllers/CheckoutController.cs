﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ProjectDbContext _db;


        public CheckoutController(ProjectDbContext db) 
        {
            _db = db;

        }
        public async Task<IActionResult> Index(int? id, string? discountCode) //memberId, discountObj
        {
            Member memberObj = await _db.Member.Where(obj=>obj.MemberID==id).FirstOrDefaultAsync();
            Discount discountObj = await _db.Discount.Where(obj=>obj.DiscountName==discountCode).FirstOrDefaultAsync();
             //public Member Member { get; set; }
        //public Discount Discount { get; set; }
        //public Order Order { get; set; }
        //public OrderDetail OrderDetail { get; set; }
        //public Payment Payment { get; set; }
        //IEnumerable<Location> Location { get; set; }

            return View();
        }
    }
}
