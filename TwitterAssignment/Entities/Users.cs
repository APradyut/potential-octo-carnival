﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAssignment.Entities
{
	public class Users:GeneralDBEntity
	{
		public string Name { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		public string Phone { get; set; }
	}
}
