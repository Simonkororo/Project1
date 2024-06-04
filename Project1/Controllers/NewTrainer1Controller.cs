using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Controllers
{
    public class NewTrainer1Controller : VerifyUserRoles
    {
        private readonly UserManager<ProjectUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ProjectUser> _signInManager;
        private readonly IWebHostEnvironment _environment;
        private readonly ProjectDbContext _context;

        public NewTrainer1Controller(ProjectDbContext context, IWebHostEnvironment environment, UserManager<ProjectUser> userManager, SignInManager<ProjectUser> signInManager, RoleManager<ApplicationRole> roleManager) : base(userManager, signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
            _environment = environment;
        }

        // GET: NewTrainer1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trainer.ToListAsync());
        }

        // GET: NewTrainer1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer
                .FirstOrDefaultAsync(m => m.TrainerID == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // GET: NewTrainer1/Create
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User); //在AspUser中找到User
            if (user == null)
            {
                return NotFound();
            }

            var member = _context.Member.FirstOrDefault(m => m.AspID == user.Id);//從member找到會員
            if (member == null)
            {
                return NotFound("Member not found");
            }

            var model = new Trainer
            {
                MemberID = member.MemberID,
                TrainerName = member.Name,
                Status = "尚未審核" // 設置審核狀態為"尚未審核"
            };
            return View(model);
        }

        // POST: NewTrainer1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrainerID,MemberID,TrainerName,SpecializationID,Experience,Qualifications,Status")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }

                var member = _context.Member.FirstOrDefault(m => m.AspID == user.Id);
                if (member == null)
                {
                    return NotFound("Member not found");
                }

                //保存圖片
                //if (photo != null && photo.Length > 0)
                //{
                //    // 生成唯一的檔名
                //    var fileName = Path.GetFileNameWithoutExtension(photo.FileName);
                //    var extension = Path.GetExtension(photo.FileName);
                //    var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";

                //    // 指定保存路徑
                //    var uploadPath = Path.Combine(_environment.WebRootPath, "img", "TrainersPhoto");
                //    var filePath = Path.Combine(uploadPath, uniqueFileName);

                //    // 確保目錄存在
                //    if (!Directory.Exists(uploadPath))
                //    {
                //        Directory.CreateDirectory(uploadPath);
                //    }

                //    // 保存檔案
                //    using (var stream = new FileStream(filePath, FileMode.Create))
                //    {
                //        await photo.CopyToAsync(stream);
                //    }

                //    // 將圖片路徑保存到資料庫
                //    trainer.Photo = Path.Combine("img", "TrainersPhoto", uniqueFileName).Replace("\\", "/");
                //}

                _context.Add(trainer);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "會員加入成功";
                return RedirectToAction("Index", "Home");
            }
            return View(trainer);
        }

        // GET: NewTrainer1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //抓到MemberID
            var userId = _userManager.GetUserId(User);
            var member = await _context.Member.FirstOrDefaultAsync(m => m.AspID == userId);
            //Console.WriteLine($"MemberID: {member.MemberID}");
            var trainer = await _context.Trainer.FirstOrDefaultAsync(t => t.MemberID == member.MemberID);
            if (trainer == null)
            {
                return NotFound();
            }
            //var photoPath = trainer.Photo;
            //ViewData["PhotoPath"] = photoPath;
            return View(trainer);
        }

        // POST: NewTrainer1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrainerID,MemberID,TrainerName,SpecializationID,Experience,Qualifications,Status,Photo")] Trainer trainer,IFormFile photo)
        {
            var userId = _userManager.GetUserId(User);
            var member = await _context.Member.FirstOrDefaultAsync(m => m.AspID == userId);
            var existingTrainer = await _context.Trainer.FirstOrDefaultAsync(t => t.MemberID == member.MemberID);
            if (trainer == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    //var existingTrainer = await _context.Trainer.FindAsync(id);
                    //if (existingTrainer == null)
                    //{
                    //    return NotFound();
                    //}

                    //if (photo != null && photo.Length > 0)
                    //{

                    //    // 保存新圖片
                    //    var fileName = Path.GetFileNameWithoutExtension(photo.FileName);
                    //    var extension = Path.GetExtension(photo.FileName);
                    //    var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                    //    var uploadPath = Path.Combine(_environment.WebRootPath, "img/", "TrainersPhoto");
                    //    var filePath = Path.Combine(uploadPath, uniqueFileName);

                    //    if (!Directory.Exists(uploadPath))
                    //    {
                    //        Directory.CreateDirectory(uploadPath);
                    //    }

                    //    using (var stream = new FileStream(filePath, FileMode.Create))
                    //    {
                    //        await photo.CopyToAsync(stream);
                    //    }

                    //    existingTrainer.Photo = Path.Combine("img/TrainersPhoto", uniqueFileName);/*.Replace("\\", "/");*/
                    //}

                    _context.Update(existingTrainer);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "資料更新成功";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerExists(trainer.TrainerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));
            }
            return View(trainer);
        }

        // GET: NewTrainer1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer
                .FirstOrDefaultAsync(m => m.TrainerID == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // POST: NewTrainer1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainer = await _context.Trainer.FindAsync(id);
            if (trainer != null)
            {
                _context.Trainer.Remove(trainer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerExists(int id)
        {
            return _context.Trainer.Any(e => e.TrainerID == id);
        }
    }
}
