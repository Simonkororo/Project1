﻿using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class Member
	{
		[Key]
		public int MemberID { get; set; } // 會員編號，主鍵

		[Required]
		public string Name { get; set; } // 會員名稱

		[Required]
		[EmailAddress]
		public string Email { get; set; } // 會員電子郵件，設為帳號

		[Required]
		public string Phone { get; set; } // 會員手機號碼

		public DateTime? Birthday { get; set; } // 會員生日

		[Required]
		public DateTime? RegistrationDate { get; set; } // 會員註冊日期

		public string? ResidenceArea { get; set; } // 會員居住區域

		public bool? IsTrainer { get; set; } // 是否為訓練師，1/0

		public bool? IsAdministrator { get; set; } // 是否為系統管理員，1/0

		public string? Photo { get; set; }

    }
}
