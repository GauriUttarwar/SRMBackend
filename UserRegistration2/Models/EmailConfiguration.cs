﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceRequestManagment.Models
{
	public class EmailConfiguration
	{
		public string From { get; set; }
		public string SmtpServer { get; set; }
		public int port { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
